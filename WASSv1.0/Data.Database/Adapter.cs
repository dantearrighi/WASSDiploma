using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.IO;

namespace Data.Database
{
    public class Adapter
    {

        static string CadenaCon;
         

        //Crear y devuelve Conexion
        public static SqlCeConnection CrearConexion()
        {
            SqlCeConnection Conexion;
            try
            {
                //Objeto Conexion
                Conexion = new SqlCeConnection(CadenaCon);

                //Devolvemos el objeto Conexion
                return Conexion;

            }
            finally
            {
                //No nos olvidemos de eliminar las referencias a objetos que no utilicemos
                Conexion = null;
            }


        }

        public string getCadenaConexionTXT()
        {
            StreamReader lector = File.OpenText("cadenaconexion.txt");
            string linea;

            linea = lector.ReadLine();
                
            if(linea==null)
            {
               linea = "";
            }
            lector.Close();
                
            return linea;
 
        }
       
        public void setCadenaConexion()
        {

            CadenaCon = getCadenaConexionTXT();
            
        }

        public void escribirCadenaTXT(string ruta)
        {
            StreamWriter escritor = File.AppendText("cadenaconexion.txt");

            escritor.WriteLine("Data Source=" + ruta + "; Persist Security Info=True; Password = '811955'");

            escritor.Close();

            setCadenaConexion();
            
        }
    }
}
