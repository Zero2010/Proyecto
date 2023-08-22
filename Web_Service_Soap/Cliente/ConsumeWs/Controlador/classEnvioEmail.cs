using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.Xml;
using System.IO;

namespace Controlador
{
    class classEnvioEmail
    {
        //se declaran las variables que se usaran para almacenar las variables del xml
        string Xml_Mail_Smtp=ConfigurationManager.AppSettings["Mail_Smtp"];
        int Xml_Mail_Puerto =Convert.ToInt16(ConfigurationManager.AppSettings["Mail_Puerto"]);
        string Xml_Mail_Envio = ConfigurationManager.AppSettings["Mail_Envio"];
        string Xml_Mail_Envio_Nombre = ConfigurationManager.AppSettings["Mail_Envio_Nombre"];
        string Xml_Mail_Contrasena = ConfigurationManager.AppSettings["Mail_Contrasena"];
        string Xml_Mail_Destinatario = ConfigurationManager.AppSettings["Mail_Destinatario"];
        string Xml_Mail_Destinatario_Nombre = ConfigurationManager.AppSettings["Mail_Destinatario_Nombre"];
        string Xml_Mail_Asunto = ConfigurationManager.AppSettings["Mail_Asunto"];
        string Xml_Mail_Copia = ConfigurationManager.AppSettings["Mail_Copia"];
        string path;

        public string archivoEmail(string nombreAntiguo, string nombreNuevo)
        {
            return "";
        }


        public string envioMail(string nombreArchivo,string tipo )
        {
            // Crear el Mail
            using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
            {
                mail.To.Add(new System.Net.Mail.MailAddress(Xml_Mail_Destinatario));

                //este estracto de codigo se usa para agregar multiples copias de correos
                //estos deben ser separados con ;
                string[] copias = Xml_Mail_Copia.Trim().Split(';'); 
                for (int h = 0; h <= copias.Length - 1; h++)
                {
                    string _MailCC = copias[h];
                    if (_MailCC != "")
                    {
                        mail.CC.Add(new MailAddress(_MailCC));
                    }
                }


                mail.From = new System.Net.Mail.MailAddress(Xml_Mail_Envio, Xml_Mail_Envio_Nombre, System.Text.Encoding.UTF8);
                mail.Subject = Xml_Mail_Asunto + " Archivo : '" + tipo + "' con Fecha : (" + DateTime.Today.ToShortDateString() + ")";
                mail.SubjectEncoding = System.Text.Encoding.UTF8;
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = false;


                switch (tipo.ToLower())
                {
                    case "cotizacion":
                        path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Sea\" + tipo + @"\Respuesta\" + nombreArchivo;
                        break;
                    case "facturacion":
                        path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Sea\" + tipo + @"\Respuesta\" + nombreArchivo;
                        break;
                    case "garantia":
                        path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Sea\" + tipo + @"\Respuesta\" + nombreArchivo;
                        break;
                    case "recepcion":
                        path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Sea\" + tipo + @"\Respuesta\" + nombreArchivo;
                        break;
                    case "reserva":
                        path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Sea\" + tipo + @"\Respuesta\" + nombreArchivo;
                        break;
                }

                mail.Body = cuerpoEmail(nombreArchivo);

                // Configuración SMTP
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient(Xml_Mail_Smtp, Xml_Mail_Puerto);

                // Crear Credencial de Autenticacion
                smtp.Credentials = new System.Net.NetworkCredential(Xml_Mail_Destinatario, Xml_Mail_Contrasena);
                //smtp.EnableSsl = false;

                smtp.Timeout = 5000000;

                // Agregar el Adjunto si deseamos hacerlo
                mail.Attachments.Add(new Attachment(path));

                try
                //enviode email
                { smtp.Send(mail); }
                catch (Exception ex)
                //marca error en caso de que existan problemas
                { throw ex; }

                return "";
            }
        }



        public string cuerpoEmail(string nombre)
        {
            string cuerpo = "Estimado(a) : \n" + "\n" + " Según lo solicitado se ha cargado con exito el Archivo: '" + nombre + "' con Fecha : (" + DateTime.Today.ToShortDateString() + ") \n" +
                     ", el cual se adjunta a este email de forma automatica, ante cualquier problema contactese con el area de sistemas de xxxx " +
                     " \n\n\n\n\n\n\n\n Atte. \n Departameto de Sistemas xxxx";

            return cuerpo;
        }


    }
}
