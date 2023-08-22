using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Controlador
{
    public class classConsume
    {
        classCotizacion objCotizacion = new classCotizacion();
        classFacturacion objFacturacion = new classFacturacion();
        classGarantia objGarantia = new classGarantia();
        classRecepcion objRecepcion = new classRecepcion();
        classReserva objReserva = new classReserva();
        classEnvioEmail objenviomail = new classEnvioEmail();


        public string[] arrayrespuesta;
        public string cabecera="";
        string[] cadena;
        string[] nuevaCadena;
        string archivo_no_Procesado;

        public void Abrir_Archivo(string documento, string nombre)
        {
            string line;
            cabecera = nombre.Replace(".txt", "");
            cabecera = cabecera.ToLower();
            string cadenaarray="";
            bool validacion = documento.Contains("chequear_txt");
            

            if (validacion == false)
            {
                if (cabecera == "cotizacion" || cabecera == "facturacion" || cabecera == "garantia" || cabecera == "recepcion" || cabecera == "reserva")
                {
                        
                if (documento!= "")
                {
                    // Lee línea a línea enviando registros al ws.
                    System.IO.StreamReader file = new System.IO.StreamReader(documento);

                    while ((line = file.ReadLine()) != null)
                    {
                        //!= null
                        //deacuerda al nombre de la cabecera se escogera uno de los 5 ws para hacer el proceso de consumirlo
                        //para ello el resultado de dicho proceso se almacenara en la variable cadena
                        cabecera = cabecera.ToLower();
                        switch (cabecera)
                        {
                            case "cotizacion":
                                nuevaCadena=contarCadena(line.Split('|'), cabecera);
                                cadena = objCotizacion.EjecutarCotizacion(nuevaCadena, cabecera);
                                break;
                            case "facturacion":
                                nuevaCadena = contarCadena(line.Split('|'), cabecera);
                                cadena = objFacturacion.EjecutarFacturacion(nuevaCadena, cabecera);
                                break;
                            case "garantia":
                                nuevaCadena = contarCadena(line.Split('|'), cabecera);
                                cadena = objGarantia.EjecutarGarantia(nuevaCadena, cabecera);
                                break;
                            case "recepcion":
                                nuevaCadena = contarCadena(line.Split('|'), cabecera);
                                cadena = objRecepcion.EjecutarRecepcion(nuevaCadena, cabecera);
                                break;
                            case "reserva":
                                nuevaCadena = contarCadena(line.Split('|'), cabecera);
                                cadena = objReserva.EjecutarReserva(nuevaCadena, cabecera);
                                break;
                        }


                        foreach (string value in cadena)
                        {
                            //por cada vez que se ingrese un registro este se va a separar con un |
                            cadenaarray += value + "|";
                        }
                    
                    
                    }

                    if (cadenaarray != "")
                    {
                        arrayrespuesta = cadenaarray.Split('|');

                        // este proceso hace que si no existe la carpeta sea que contiene los 5 ws se pueda crear, para almacenar
                        //el resultado del proceso el cual se almacena con la fecha y hora correspondiente
                        string path = escribirFichero(cabecera);
                        //crea el formato del archivo, el cual es la respuesta del ws
                        cabecera = cabecera + "_" + DateTime.Today.ToShortDateString() + "_" + DateTime.Now.ToLongTimeString() + ".txt";
                        //se reemplaza los : de la hora ya que este da problemas al generar el nombre del archivo plano
                        using (StreamWriter writer = new StreamWriter(path + "\\" + cabecera.Replace(":", "."), true))
                        {
                            for (int i = 0; i < arrayrespuesta.Length; i++)
                            {
                                // crea line a linea en un archivo plano la respuesta del ws, ademas separa cada campo con el caracter |
                                writer.WriteLine(arrayrespuesta[i].ToString().Replace(",", "|").Replace("'", ""));
                            }
                        }
                        objenviomail.envioMail(cabecera.Replace(":", "."), nombre.Replace(".txt", ""));

                        file.Close();
                        File.Move(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Sea\" + nombre.Replace(".txt", "") + @"\" + nombre + ".txt", Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Sea\" + nombre.Replace(".txt", "") + @"\" + cabecera.Replace(":", "."));
                    }}
                }
            }
        }




        public string escribirFichero(string texto)
        {
            string path="";
            //consulta si existe la carpeta Sea y tambien como el nombre del archivo es cualquiera de 5 ws toma su nombre para ser creado, y tambien
            //crea una carpeta llamada respuesta que es donde se almacena la respuesta ya procesada del ws
            if (!System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Sea\" + texto + @"\Respuesta\"))
            {   
                // en caso de no estar creada la carpeta esta se crea y entrega el path de vuelta
                if (texto=="")
                {
                    //en caso que la carpeta este creada no se crea la carpeta, sino que continua con el proceso
                    if (!System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Sea\"))
                    {
                        System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Sea\");
                        path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Sea\";
                    }
                }
                else
                {   //si al cargar los datos la carpeta respuesta no existe se crea y se envia path de retorno 
                    System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Sea\" + texto + @"\Respuesta\");
                    path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Sea\" + texto + @"\Respuesta\";
                }
            }
            else 
            {
                // si la carpteta ya fue creada solo envia el path de vuelta para que se pueda almacenar el archivo plano
                path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Sea\" + texto + @"\Respuesta\";
            }
                //retorna el path de de la carpeta
                return path;
        }



        public string moverFichero(string pathorigen, string nombrearchivo)
        {
            string pathdestino = "";

            nombrearchivo = nombrearchivo.ToLower();
            switch (nombrearchivo)
            {
                // el path de destino se crea deacuerdo al nombre del mismo
                case "cotizacion":
                    pathdestino = pathorigen + nombrearchivo;
                    break;
                case "facturacion":
                    pathdestino = pathorigen + nombrearchivo;
                    break;
                case "garantia":
                    pathdestino = pathorigen + nombrearchivo;
                    break;
                case "recepcion":
                    pathdestino = pathorigen + nombrearchivo;
                    break;
                case "reserva":
                    pathdestino = pathorigen + nombrearchivo;
                    break;
                default:
                    pathdestino="";
                    break;
            }

            if (pathdestino != "")
            {
                if (System.IO.File.Exists(pathdestino + "\\" + nombrearchivo + ".txt"))
                {

                    if (System.IO.File.Exists(pathdestino + "\\" + "chequear_txt"))
                    {
                        archivo_no_Procesado = (nombrearchivo + "_no_Procesado_" + DateTime.Today.ToShortDateString() + "_" + DateTime.Now.ToLongTimeString()).Replace(":",".");
                        File.Move(pathorigen + nombrearchivo + ".txt", pathdestino + "\\" + "chequear_txt" + "\\" + nombrearchivo + ".txt");
                        File.Delete(pathdestino + "\\" + nombrearchivo + ".txt");
                        return pathdestino + "\\" + "chequear_txt" + "\\" + archivo_no_Procesado + ".txt";
                    }
                    else
                    {
                        archivo_no_Procesado = (nombrearchivo + "_no_Procesado_" + DateTime.Today.ToShortDateString() + "_" + DateTime.Now.ToLongTimeString()).Replace(":", ".");
                        System.IO.Directory.CreateDirectory(pathdestino + "\\" + "chequear_txt");

                        File.Move(pathdestino + "\\" + nombrearchivo + ".txt", pathdestino + "\\" + "chequear_txt" + "\\" + archivo_no_Procesado + ".txt");

                        //File.Move(pathorigen + nombrearchivo + ".txt", pathdestino + "\\" + "chequear_txt" + "\\" + archivo_no_Procesado + ".txt");
                        //File.Delete(pathdestino + "\\" + nombrearchivo + ".txt");
                        return pathdestino + "\\" + "chequear_txt" + "\\" + nombrearchivo + ".txt";
                    }
                }
                else 
                {
                    //verifica que la carpeta donde iran los archivos de resultados existan
                    escribirFichero(nombrearchivo);

                    //Dim text() As String = System.IO.File.ReadAllText("C:\MiArchivo.txt")

                    string text = System.IO.File.ReadAllText(pathorigen + nombrearchivo + ".txt");

                    if (text != "")
                    {
                        //mueve los archivos desde la la carpeta sea hasta donde tendra su ubicacion definitiva
                        File.Move(pathorigen + nombrearchivo + ".txt", pathdestino + "\\" + nombrearchivo + ".txt");

                        // se retorna con el path donde quedada el archivo final para su proceso de consumo del ws
                        return pathdestino + "\\" + nombrearchivo + ".txt";
                    }
                    else
                    {
                        return "";
                    }
                }

            }

            return pathdestino;
        }




        public string[] contarCadena(string[] cadena, string tipo)
        {
            int cantCadena=0;

            switch (tipo)
            {
                // el path de destino se crea deacuerdo al nombre del mismo
                case "cotizacion":
                    cantCadena = 18;//es la cantidad de registros que deberia tener cada txt
                    break;
                case "facturacion":
                    cantCadena = 33;
                    break;
                case "garantia":
                    cantCadena = 32;
                    break;
                case "recepcion":
                    cantCadena = 14;
                    break;
                case "reserva":
                    cantCadena = 19;
                    break;
            }

            Array.Resize(ref cadena, cantCadena);

            return cadena;
        }
        


    }
}
