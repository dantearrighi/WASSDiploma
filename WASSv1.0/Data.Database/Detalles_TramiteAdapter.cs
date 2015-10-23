using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using Entidades;
using System.Data.SqlTypes;
using System.Data;

namespace Data.Database
{
    public class Detalles_TramiteAdapter:Adapter
    {
        public void AñadirNuevo(Detalles_Tramite det_tram)
        {

            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "INSERT INTO [Detalles_Tramites] ([idTramite], [fechaDetalle], [descripcion]) VALUES (@IDTRAMITE, @FECHADETALLE, @DESCRIPCION)";
            Comando.Parameters.Add(new SqlCeParameter("@IDTRAMITE", SqlDbType.Int));
            Comando.Parameters["@IDTRAMITE"].Value = det_tram.idTramite;
            Comando.Parameters.Add(new SqlCeParameter("@FECHADETALLE", SqlDbType.DateTime));
            Comando.Parameters["@FECHADETALLE"].Value = det_tram.FechaDetalle;
         
            Comando.Parameters.Add(new SqlCeParameter("@DESCRIPCION", SqlDbType.NVarChar));
            Comando.Parameters["@DESCRIPCION"].Value = det_tram.Descripcion;


            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();

        } 

        public void Quitar(int idTram, DateTime fechaDet)
        {

            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

        //    string fechaDetalle = Convert.ToString(fechaDet);

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "DELETE FROM [Detalles_Tramites] WHERE (([fechaDetalle] = @FECHADETALLE) AND ([idTramite]=@IDTRAMITE))";
            Comando.Parameters.Add(new SqlCeParameter("@FECHADETALLE", SqlDbType.DateTime));
            Comando.Parameters["@FECHADETALLE"].Value = fechaDet;
            Comando.Parameters.Add(new SqlCeParameter("@IDTRAMITE", SqlDbType.Int));
            Comando.Parameters["@IDTRAMITE"].Value = idTram;

            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }

        public DataTable GetDetallesTramite(int idTram)
        {
            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT Detalles_Tramites.fechaDetalle, Detalles_Tramites.descripcion FROM Detalles_Tramites WHERE (Detalles_Tramites.idTramite = @IDTRAMITE)", Con);
            Comando.Parameters.Add(new SqlCeParameter("@IDTRAMITE", SqlDbType.Int));
            Comando.Parameters["@IDTRAMITE"].Value = idTram;

            //Crea DataTable para ser Origen de la Grilla
            DataTable dataTableDetallesTramite = new DataTable();

            //Creacion de Columnas
            DataColumn fechaDetalleCOL = new DataColumn("fechaDetalle");
            
            DataColumn descripcionCol = new DataColumn("descripcion");



            //Agrego columnas a DataTable de DetallesTramite
            dataTableDetallesTramite.Columns.Add(fechaDetalleCOL);
       
            dataTableDetallesTramite.Columns.Add(descripcionCol);


            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drDetallesTram = Comando.ExecuteReader();

                while (drDetallesTram.Read())
                {
                    DataRow rowDetallesTram = dataTableDetallesTramite.NewRow();

                    rowDetallesTram[fechaDetalleCOL] = (DateTime)drDetallesTram["fechaDetalle"];
                    rowDetallesTram[descripcionCol] = (string)drDetallesTram["descripcion"];


                    dataTableDetallesTramite.Rows.Add(rowDetallesTram);
                }
                drDetallesTram.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar información del Trámite", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return dataTableDetallesTramite;
        }

        /*
        public DataTable GetAll()
        {
            //Lista de tramites a devolver
            List<Tramite> ListaTramites = new List<Tramite>();

            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT * FROM Tramites", Con);
            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drTramites = Comando.ExecuteReader();

                while (drTramites.Read())
                {
                    //Leo BD y lleno lista de Tramites
                    Tramite tram = new Tramite();

                    tram.IdTramite = (int)drTramites["idTramite"];
                    tram.DniCuilCliente = (string)drTramites["dniCuilCli"];
                    tram.Estado = (string)drTramites["estado"];
                    tram.TipoTramite = (string)drTramites["tipoTramite"];
                    tram.EnviadoPor = (string)drTramites["enviadoPor"];
                    tram.DerivadoA = (string)drTramites["derivadoA"];

                    ListaTramites.Add(tram);
                }
                drTramites.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Tramites", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return ListaTramites;




        }
        */ 
    }
}
