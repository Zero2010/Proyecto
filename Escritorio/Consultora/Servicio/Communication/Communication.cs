using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.VisualBasic;

namespace TPSejeLMSP.Communications
{
    public class Communication
    {
        public string Message { get; set; }
        public List<string> Data { get; set; }
        public Commands Command { get; set; }

        public const string Header = "TS20TP";

        public Communication()
        { }

        public static Communication Parse(string content)
        {
            int messageLength, command;
            Communication returnObject = new Communication();

            returnObject.Message = content;
            if (content.Length >= (int)StructureLength.CMD_POS && content.Substring(0, (int)StructureLength.HEAD_LEN) == Header)
            {
                if (int.TryParse(content.Substring((int)StructureLength.LEN_POS, (int)StructureLength.LEN_LEN), out messageLength))
                {
                    if (messageLength >= (int)StructureLength.MIN_MSG_LEN && messageLength <= (int)StructureLength.MAX_MSG_LEN)
                    {
                        if (content.Length >= messageLength)
                        {
                            if (content.Last() == '@')
                            {
                                returnObject.Data = content.Substring((int)StructureLength.DAT_POS, messageLength - (int)StructureLength.FIX_LEN).Split('|').ToList();
                                if (int.TryParse(content.Substring((int)StructureLength.CMD_POS, (int)StructureLength.CMD_LEN), out command))
                                {
                                    if (Enum.IsDefined(typeof(Commands), command) && command != (int)Commands.Error)
                                    {
                                        returnObject.Command = (Commands)Enum.Parse(typeof(Commands), command.ToString(), true);
                                        if (IsChecksumValid(content))
                                            return returnObject;
                                        else
                                            throw new CommunicationException(GetError(FormatErrorType.MSGCKS), FormatErrorType.MSGCKS);
                                    }
                                    else if (command == (int)Commands.Error)
                                    {
                                        int internalErrorCode = Convert.ToInt32(returnObject.Data[0]);
                                        int? numeroTurno = null;
                                        string internalErrorMessage, letraTurno = null;

                                        if (returnObject.Data.Count > 1)
                                        {
                                            internalErrorMessage = returnObject.Data[1];
                                            if (!string.IsNullOrEmpty(internalErrorMessage))
                                            {
                                                string[] internalErrorData = internalErrorMessage.Split('_');
                                                if (internalErrorData.Length >= 3)
                                                {
                                                    internalErrorMessage = internalErrorData[0];
                                                    letraTurno = internalErrorData[1];
                                                    numeroTurno = Convert.ToInt32(internalErrorData[2]);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            internalErrorMessage = GetInternalError(internalErrorCode);
                                        }
                                                                                
                                        InternalError internalError = new InternalError()
                                        {
                                            ErrorCode = internalErrorCode,
                                            Message = internalErrorMessage,
                                            LetraTurno = letraTurno,
                                            NumeroTurno = numeroTurno
                                        };
                                        throw new CommunicationException(GetError(FormatErrorType.GENSCS), FormatErrorType.GENSCS, internalError);
                                    }
                                    else
                                        throw new CommunicationException(GetError(FormatErrorType.MSGCMD), FormatErrorType.MSGCMD);
                                }
                                else
                                    throw new CommunicationException(GetError(FormatErrorType.MSGCMD), FormatErrorType.MSGCMD);
                            }
                            else
                                throw new CommunicationException(GetError(FormatErrorType.MSGFMT), FormatErrorType.MSGFMT);
                        }
                        else
                            throw new CommunicationException(GetError(FormatErrorType.MSGLEN), FormatErrorType.MSGLEN);
                    }
                    else
                    {
                        FormatErrorType error = (messageLength < (int)StructureLength.MIN_MSG_LEN ? FormatErrorType.MSGMIN : FormatErrorType.MSGMAX);
                        throw new CommunicationException(GetError(error), error);
                    }
                }
                else
                    throw new CommunicationException(GetError(FormatErrorType.MSGDAT), FormatErrorType.MSGDAT);
            }
            else
                throw new CommunicationException(GetError(FormatErrorType.MSGHDR), FormatErrorType.MSGHDR);
        }

        public static bool TryParse(string content, out Communication result)
        {
            try
            {
                result = Parse(content);
                return true;
            }
            catch
            {
                result = null;
                return false;
            }
        }

        public static string BuildMessage(Commands command, List<string> data)
        {
            string datas = string.Join("|", data);
            string cmd = ((int)command).ToString().PadLeft(3, '0');
            int length = Header.Length + 5 + cmd.Length + datas.Length + 4 + 1;

            return Header + length.ToString().PadLeft(5, '0') + cmd + datas + BuildChecksum(Header + length.ToString().PadLeft(5, '0') + cmd + datas) + "@";
        }

        private static string BuildChecksum(string data)
        {
            long cks = 0;
            for (int i = 1; i <= data.Length; i++)
            {  
                cks -= Strings.Asc(Strings.Mid(data, i, 1));
            }
            return Strings.Right(Conversion.Hex(cks), 4).PadLeft(4, '0');
        }

        private static bool IsChecksumValid(string receiveText)
        {
            return !(Strings.Mid(receiveText, Convert.ToInt32(Strings.Mid(receiveText, 7, 5)) - 5 + 1, 4) != BuildChecksum(Strings.Mid(receiveText, 1, receiveText.Length - 5)));
        }

        private static string GetError(FormatErrorType command)
        {
            switch (command)
            {
                case FormatErrorType.MSGMIN:
                    return "Largo de mensaje < permitido";
                case FormatErrorType.MSGMAX:
                    return "Largo de mensaje > permitido";
                case FormatErrorType.MSGFMT:
                    return "Error de formato en mensaje";
                case FormatErrorType.MSGLEN:
                    return "Error de tamaño de mensaje";
                case FormatErrorType.MSGCMD:
                    return "Comando no válido";
                case FormatErrorType.MSGCKS:
                    return "Checksum no válido";
                case FormatErrorType.MSGDAT:
                    return "Parámetros no válidos";
                case FormatErrorType.GENSCS:
                    return "Error general";
                case FormatErrorType.MSGHDR:
                    return "Header no válido";
                default:
                    return "Error General";
            }
        }

        private static string GetInternalError(int errorCode)
        {
            switch (errorCode)
            {
                case 14001: return "Oficina no reconocida";
                case 14002: return "Oficina sin comunicación";
                case 12001: return "Largo de mensaje menor al mínimo permitido";
                case 12002: return "Largo de mensaje mayor al máximo permitido";
                case 12003: return "Formato erróneo";
                case 12004: return "Tamaño de mensaje erróneo";
                case 12005: return "Comando asociado en mensaje no válido";
                case 12006: return "Checksum no válido";
                case 12096: return "Error de sincronización";
                case 12097: return "Transacción en progreso";
                case 12098: return "Timeout en recibir respuesta";
                case 12099: return "Error general";
                case 13001: return "Largo de mensaje menor al mínimo permitido";
                case 13002: return "Largo de mensaje mayor al máximo permitido";
                case 13003: return "Formato erróneo";
                case 13004: return "Tamaño de mensaje erróneo";
                case 13005: return "Comando asociado en mensaje no válido";
                case 13006: return "Checksum no válido";
                case 13007: return "Número de parámetros no válidos";
                case 13020: return "Otro Ejecutivo conectado en mismo Escritorio";
                case 13021: return "Mismo Ejecutivo conectado en otro Escritorio";
                case 13022: return "Error en Login";
                case 13023: return "Escritorio no definido";
                case 13025: return "Atención no válida";
                case 13026: return "Series incorrectas";
                case 13027: return "Serie incorrecta";
                case 13028: return "Turno no ha sido emitido";
                case 13029: return "Turno previamente atendido";
                case 11522: return "Error de Login";
                case 13099: return "Error General";
                default: return "Error Desconocido";
            }
        }
    }
}