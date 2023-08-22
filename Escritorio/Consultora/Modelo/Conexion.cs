using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Conexion
    {
        public string Idejecutivo {set; get;}
        public string Usuario { set; get; }
        public string contrasenia { set; get; }
        public string Ip { set; get; }
        public string Puerto { set; get; }

        private string pausaPath = @"C:\Consultora\Pausa\";
        private string motivoPath = @"C:\Consultora\Motivo\";
        private string urgenciaPath = @"C:\Consultora\Serie\";
        private string ejecutivoPath = @"C:\Consultora\Ejecutivo\";
        private string sucursalPath = @"C:\Consultora\Sucursal\";
        private string numeroUrgenciaPath = @"C:\Consultora\NumeroUrgencia\";

        private string respaldoPath = @"C:\Consultora\Respaldo\";
        private string LogPath = @"C:\Consultora\Log\";

        public string[] TipoPausa;
        public string[] TipoMotivo;
        public string[] TipoUrgencia;
        public string[] TipoEjecutivo;
        public string[] TipoSucursal;
        public string[] TipoRespaldo;
        public string[] TipoNumeroUrgencia;
        public string[] TipoTransmicion;
        public string[] TipoLog;

        public string texto;
        public string[] hora;
        public string valor="";
        string cadenaTransmicion;
        int tamanioKilobits=0;

        int IdSerie =Convert.ToInt16(ConfigurationManager.AppSettings["IdSerie"]);

        List<string> lista = new List<string>();
        List<int> numeros = new List<int>();
        List<string> Serienumeros = new List<string>();

        public string[] cargarPausas()
        {
            try
            {
                string[] archivos = System.IO.Directory.GetFiles(pausaPath);

                Array.Sort(archivos, StringComparer.InvariantCulture);

                Array.Reverse(archivos);

                System.IO.StreamReader sr = new System.IO.StreamReader(archivos[0], System.Text.Encoding.UTF8, false);

                texto = sr.ReadToEnd();
                sr.Close();

                texto = texto.Replace("\r\n", ";");

                TipoPausa = texto.Split(';');
                return TipoPausa;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public string[] cargaMotivo()
        {
            try
            {
                string[] archivos = System.IO.Directory.GetFiles(motivoPath);
                string valor="";
                string cadena="";

                Array.Sort(archivos, StringComparer.InvariantCulture);

                Array.Reverse(archivos);

                System.IO.StreamReader sr = new System.IO.StreamReader(archivos[0], System.Text.Encoding.UTF8, false);
                texto = sr.ReadToEnd();
                sr.Close();

                texto = texto.Replace("\r\n", ";");

                TipoMotivo = texto.Split(';');

                
                foreach (var item in TipoMotivo)
                {
                    var valor1 = item.Split('|');
                    var tamano = valor1.Length;

                    if ((item) != "")
                    {
                        switch (tamano)
                        {
                            case 4:
                                if (Convert.ToInt16(valor1[3]) == IdSerie)
                                {
                                    valor = String.Format(item);
                                    cadena += valor + ";";
                                }
                                break;
                            case 5:
                                if (Convert.ToInt16(valor1[3]) == IdSerie || Convert.ToInt16(valor1[4]) == IdSerie)
                                {
                                    valor = String.Format(item);
                                    cadena += valor + ";";
                                }
                                break;
                            case 6:
                                if (Convert.ToInt16(valor1[3]) == IdSerie || Convert.ToInt16(valor1[4]) == IdSerie || Convert.ToInt16(valor1[5]) == IdSerie)
                                {
                                    valor = String.Format(item);
                                    cadena += valor + ";";
                                }
                                break;
                        }
                    }
                }
                var v1 = cadena.Remove(cadena.Length -1).Split(';');
                string[] cad = v1;
                return cad;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string[] cargaUrgencia()
        {
            try
            {
                string[] archivos = System.IO.Directory.GetFiles(urgenciaPath);

                Array.Sort(archivos, StringComparer.InvariantCulture);

                Array.Reverse(archivos);

                System.IO.StreamReader sr = new System.IO.StreamReader(archivos[0], System.Text.Encoding.UTF8, false);
                texto = sr.ReadToEnd();
                sr.Close();

                texto = texto.Replace("\r\n", ";");

                TipoUrgencia = texto.Split(';');
                return TipoUrgencia;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string[] Ejecutivo()
        {
            try
            {
                string[] archivos = System.IO.Directory.GetFiles(ejecutivoPath);

                Array.Sort(archivos, StringComparer.InvariantCulture);

                Array.Reverse(archivos);

                System.IO.StreamReader sr = new System.IO.StreamReader(archivos[0], System.Text.Encoding.UTF8, false);
                texto = sr.ReadToEnd();
                sr.Close();

                texto = texto.Replace("\r\n", ";");

                TipoEjecutivo = texto.Split(';');
                return TipoEjecutivo;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public string[] Sucursal()
        {
            try
            {
                string[] archivos = System.IO.Directory.GetFiles(sucursalPath);

                Array.Sort(archivos, StringComparer.InvariantCulture);

                Array.Reverse(archivos);

                System.IO.StreamReader sr = new System.IO.StreamReader(archivos[0], System.Text.Encoding.UTF8, false);
                texto = sr.ReadToEnd();
                sr.Close();

                texto = texto.Replace("\r\n", ";");

                TipoSucursal = texto.Split(';');
                return TipoSucursal;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string[] Respaldo()
        {
            try
            {
                string[] archivos = System.IO.Directory.GetFiles(sucursalPath);

                Array.Sort(archivos, StringComparer.InvariantCulture);

                Array.Reverse(archivos);

                System.IO.StreamReader sr = new System.IO.StreamReader(archivos[0], System.Text.Encoding.UTF8, false);
                texto = sr.ReadToEnd();
                sr.Close();

                texto = texto.Replace("\r\n", ";");

                TipoRespaldo = texto.Split(';');
                return TipoRespaldo;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public string[] NumeroUrgencia()
        {
            try
            {
                string[] archivos = System.IO.Directory.GetFiles(numeroUrgenciaPath);

                Array.Sort(archivos, StringComparer.InvariantCulture);

                Array.Reverse(archivos);

                System.IO.StreamReader sr = new System.IO.StreamReader(archivos[0], System.Text.Encoding.UTF8, false);
                texto = sr.ReadToEnd();
                sr.Close();

                texto = texto.Replace("\r\n", ";");

                TipoNumeroUrgencia = texto.Split(';');
                return TipoNumeroUrgencia;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string[] Transmicion(string path)
        {
            try
            {
                if (System.IO.File.Exists(path))
                {
                    StreamReader objReader = new StreamReader(path);
                    string sLine = "";
                    ArrayList arrText = new ArrayList();

                    while (sLine != null)
                    {
                        sLine = objReader.ReadLine();

                        if (sLine != "" && sLine != null)
                        {
                            lista.Add(sLine);;
                        }
                    }

                    cadenaTransmicion = "";
                    foreach (var item in lista.ToArray())
                    {
                        tamanioKilobits = System.Text.ASCIIEncoding.ASCII.GetByteCount(cadenaTransmicion);
                        if (tamanioKilobits <= 3200)
                        {
                            cadenaTransmicion += item + "|";
                        }
                        else
                        {

                        }
                    }

                }

                return TipoTransmicion;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }

}
