using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Metodos
{
    class Metodos
    {

        public void Archivo_Plano(string path, string[] archivo, string fecha)
        {
            if (Directory.Exists(path))
            {
                System.IO.File.WriteAllLines(path + fecha, archivo);
            }
            
            else
            {
                DirectoryInfo di = Directory.CreateDirectory(path);

                using (StreamWriter file = new StreamWriter(path + fecha, true))
                {
                    foreach (var item in archivo)
                    {
                        file.WriteLine(item);
                    }

                    file.Close();
                }
            }


        }

        public void Archivo_Plano(string path, string archivo, string fecha)
        {
            using (FileStream flujoArchivo = new FileStream(path + fecha, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter escritor = new StreamWriter(flujoArchivo))
                {
                    foreach (var item in archivo)
                    {
                        escritor.WriteLine(item);
                    }

                    escritor.Close();

                }
            }
        }

        //public void Archivo_Plano(string path, string[] archivo, string fecha)
        //{
        //    if (Directory.Exists(path))
        //    {
        //        //DirectoryInfo di = Directory.CreateDirectory(path + fecha);


        //        using (StreamWriter file = new StreamWriter(path + fecha, true))
        //        {

        //            foreach (var item in archivo)
        //            {
        //                file.WriteLine(item);
        //            }

        //            file.Close();
        //        }
        //    }
        //    else
        //    {
        //        //DirectoryInfo di = Directory.CreateDirectory(path + fecha);

        //        using (StreamWriter file = new StreamWriter(path + fecha, true))
        //        {
        //            foreach (var item in archivo)
        //            {
        //                file.WriteLine(item);
        //            }

        //            file.Close();
        //        }

        //    }
        //}

        //public void Archivo_Plano(string path, string archivo, string fecha)
        //{
        //    if (Directory.Exists(path))
        //    {
        //        //DirectoryInfo di = Directory.CreateDirectory(path + fecha);

        //        using (StreamWriter file = new StreamWriter(path + fecha, true))
        //        {
        //            file.WriteLine(archivo);
        //            file.Close();
        //        }
        //    }
        //    else
        //    {
        //        //DirectoryInfo di = Directory.CreateDirectory(path + fecha);

        //        using (StreamWriter file = new StreamWriter(path + fecha, true))
        //        {
        //            file.WriteLine(archivo);
        //            file.Close();
        //        }

        //    }
        //}

    }
}
