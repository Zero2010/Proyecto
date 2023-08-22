using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Data.Sql;
using System.Data;
using System.Configuration;



namespace Modelo
{
    public class Conexion
    {
        public string sql;
        public SqlDataReader oDR;

        public SqlConnection con                        = new SqlConnection();
        public System.Data.DataTable dt                 = new System.Data.DataTable();
        public SqlCommand cmd                           = new SqlCommand();
        public SqlDataAdapter da                        = new SqlDataAdapter();
        public DataTable dt2                            = new DataTable();
        public List<ViewModelProductos> listaproductos  = new List<ViewModelProductos>();
        public List<string> listado                     = new List<string>();

        public System.Data.SqlClient.SqlCommand dbCommand;
        public System.Data.SqlClient.SqlConnection dbConnection;
        public System.Data.SqlClient.SqlDataAdapter dbDataAdapter;
        public System.Data.DataSet dbDataset;
        public System.Data.DataTable dbDataTable;

        public DataTable EjecutarDatatable()
        {
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public List<ViewModelProductos> EjecutarQuery(string consulta)
        {
            try
            {
                if (consulta != "")
                {
                    String ServidorSql = "DESKTOP-KBD8QDK\\SQLEXPRESS";
                    String BD = "InvPro";
                    String Password = "10jul1982";
                    String UserName = "sa";
                    string cadenaConexion;

                    cadenaConexion = "Data Source=" + ServidorSql + ";Initial Catalog=" + BD + ";User ID=" + UserName + ";Password=" + Password;
                    SqlConnection dbConnection = new System.Data.SqlClient.SqlConnection(cadenaConexion);
                    dbConnection.Open();


                    dbCommand = new SqlCommand(consulta, dbConnection);

                    SqlDataReader registro = dbCommand.ExecuteReader();


                    while (registro.Read())
                    {
                        listaproductos = new List<ViewModelProductos> {
                                    new ViewModelProductos{     Ean           = registro["Ean"].ToString(),
                                                                Descripcion   = registro["Descripcion"].ToString(),
                                                                Sku           = registro["Sku"].ToString()
                                    }
                                 };
                    }

                    dbConnection.Close();
                }
                return listaproductos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Conectar()
        {
            try
            {
                String ServidorSql  = "DESKTOP-KBD8QDK\\SQLEXPRESS";
                String BD           = "InvPro";
                String Password     = "10jul1982";
                String UserName     = "sa";
                string cadenaConexion;

                cadenaConexion = "Data Source=" + ServidorSql + ";Initial Catalog=" + BD + ";User ID=" + UserName + ";Password=" + Password;
                SqlConnection dbConnection = new System.Data.SqlClient.SqlConnection(cadenaConexion);
                dbConnection.Open();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                //Desconectar();
            }
        }

        public void Desconectar()
        {
            dbConnection.Close();
        }

        public void InsertRegistros(string Consulta, string id)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    Conectar();

                cmd.Connection  = con;
                cmd.CommandText = Consulta;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Desconectar();
                ex.Message.ToString();
            }
        }
    }
}
