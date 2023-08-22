using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;

namespace Controlador.Estados
{
 public class NumeroUrgencia
    {
        static List<Controlador.Servicio.Respaldo.Respaldo> listaUrgencia = new List<Servicio.Respaldo.Respaldo>();
        Controlador.Servicio.Respaldo.Respaldo respaldo = new Controlador.Servicio.Respaldo.Respaldo();
        Controlador.Metodos.Metodos metodos = new Controlador.Metodos.Metodos();
        Modelo.Conexion conexion = new Modelo.Conexion();
        string[] tipoNumeroUrgencia;
        int valor;
        string nuevoValor;
        int count;

        public string[] AtencionNumeroUrgencia()
        {
            tipoNumeroUrgencia = conexion.Ejecutivo();

            return tipoNumeroUrgencia;
        }

        public int GenerarNumero(string serie, string letra, string path, string numero, int estado)
        {
            List<string> lista = new List<string>();
            List<int> numeros = new List<int>();
            List<string> Serienumeros = new List<string>();

            switch (estado)
            {
                case 1:
                    listaUrgencia.Clear();
                    int count = 0;
                    if (Directory.Exists(path))
                    {
                        string[] archivos = System.IO.Directory.GetFiles(path);

                        foreach (var a in archivos)
                        {
                            StreamReader objReader = new StreamReader(a);
                            string sLine = "";
                            ArrayList arrText = new ArrayList();

                            while (sLine != null)
                            {
                                sLine = objReader.ReadLine();

                                if (sLine != "" && sLine != null)
                                {
                                    var valores = sLine.Split(';');
                                    //var pet = new { Age = 10, Name = "Fluffy" }; 

                                    Controlador.Servicio.Respaldo.Respaldo p = new Controlador.Servicio.Respaldo.Respaldo()
                                    {
                                        Id = count,
                                        Serie = Convert.ToInt32(valores[0].ToString()),
                                        Numero = Convert.ToInt32(valores[1].ToString())
                                    };

                                    count++;
                                    listaUrgencia.Add(p);
                                }
                            }


                            var tmpList = listaUrgencia.Where(x => x.Serie == Convert.ToInt16(serie)).ToList();
                            var countser = tmpList.GroupBy(x => x.Serie).Select(y => new { serie = y.Count() }).ToList();




                            if (tmpList.Count==0)
                            {
                                valor = 0;
                            }
                            else
                            {
                                foreach (var item in tmpList)
                                {
                                    if (item.Serie == Convert.ToInt16(serie))
                                    {

                                        valor = item.Numero - 1;
                                        break;
                                    }
                                }
                            }




                            objReader.Close();
                            numeros.Sort();
                        }
                    }
                    break;
                case 2:
                    listaUrgencia.Clear();
                    valor = 0;
                    if (System.IO.File.Exists(path))
                    {
                        StreamReader objReader = new StreamReader(path);
                        string sLine = "";
                        ArrayList arrText = new ArrayList();

                        count = 0;
                        while (sLine != null)
                        {
                            sLine = objReader.ReadLine();

                            if (sLine != "" && sLine != null)
                            {
                                var valores = sLine.Split('~');
                                Controlador.Servicio.Respaldo.Respaldo p = new Controlador.Servicio.Respaldo.Respaldo()
                                {
                                    Id = count,
                                    Serie = Convert.ToInt32(valores[2].ToString()),
                                    Numero = Convert.ToInt32(valores[5].ToString())
                                };

                                count++;
                                listaUrgencia.Add(p);
                            }
                        }

                        var tmpList = listaUrgencia.FindAll(x => x.Serie == listaUrgencia[0].Serie).ToList();
                        var countser = tmpList.GroupBy(x => x.Serie).Select(y => new { serie = y.Count() }).ToList();

                        nuevoValor = "";
                        foreach (var item in countser)
                        {
                            for (int i = 1; i < item.serie; i++)
                            {
                                var tmpList1 = listaUrgencia.FindAll(x => x.Serie == listaUrgencia[i].Serie).ToList();
                                var temnum = tmpList1.Min(x => (int)x.Numero);
                                var temser = tmpList1.Min(x => (int)x.Serie);

                                if (Convert.ToString(temser) == serie)
                                {

                                    if (temnum==Convert.ToInt16(numero))
                                    {
                                        valor = -1;
                                    }
                                    else
                                    {
                                        valor = 0;
                                    }
                                                                    }
                                //else
                                //{
                                //    valor = -1;
                                //}
                            }
                        }
                        objReader.Close();
                    }
                    else
                    {
                        valor = 1;
                    }
                    break;
                case 3:
                    if (Directory.Exists(path))
                        listaUrgencia.Clear();
                    {
                        string[] archivos = System.IO.Directory.GetFiles(path);

                        count = 0;
                        foreach (var a in archivos)
                        {
                            StreamReader objReader = new StreamReader(a);
                            string sLine = "";
                            ArrayList arrText = new ArrayList();

                            while (sLine != null)
                            {
                                sLine = objReader.ReadLine();

                                if (sLine != "" && sLine != null)
                                {
                                    var valores = sLine.Split(';');
                                    Controlador.Servicio.Respaldo.Respaldo p = new Controlador.Servicio.Respaldo.Respaldo()
                                    {
                                        Id = count,
                                        Serie = Convert.ToInt32(valores[0].ToString()),
                                        Numero = Convert.ToInt32(valores[1].ToString())
                                    };

                                    count++;
                                    listaUrgencia.Add(p);
                                }
                            }


                            //var tmpList = listaUrgencia.FindAll(x => x.Serie == listaUrgencia[0].Serie).ToList();
                            //var countser = tmpList.GroupBy(x => x.Serie).Select(y => new { serie = y.Count() }).ToList();


                            nuevoValor = "";
                            foreach (var item in listaUrgencia)//countser
                            {
                                for (int i = 0; i < item.Serie; i++)
                                {
                                    var tmpList1 = listaUrgencia.FindAll(x => x.Serie == listaUrgencia[i].Serie).ToList();
                                    //var tmpList1= listaUrgencia.Where(x => x.Serie == item.Serie).ToList();
                                    var temnum = tmpList1.Min(x => (int)x.Numero);
                                    var temser = tmpList1.Min(x => (int)x.Serie);
                                    nuevoValor += temser + ";" + temnum + "|";
                                    break;
                                }
                            }

                            objReader.Close();


                            if (Directory.Exists(path))
                            {
                                archivos = System.IO.Directory.GetFiles(path);
                                File.Delete(archivos[0]);
                                //Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(path, Microsoft.VisualBasic.FileIO.DeleteDirectoryOption.DeleteAllContents);
                            }

                            //Global.URG = (nuevoValor);
                            //respaldo.GenerarRespaldo(Global.URG, "URG");


                            foreach (var item in nuevoValor.Split('|'))
                            {
                                if (item != "")
                                {
                                    Global.URG = (item);
                                    respaldo.GenerarRespaldo(Global.URG, "URG");
                                }

                            }

                        }
                    }                  

                    break;
            }
            return valor;
        }


    }
}
