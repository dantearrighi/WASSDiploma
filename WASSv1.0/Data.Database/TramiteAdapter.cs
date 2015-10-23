using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using Entidades;
using System.Data;

namespace Data.Database
{
   public class TramiteAdapter : Adapter
    {
        public void AñadirNuevo(Tramite tram)
        {

            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "INSERT INTO [Tramites] ([idTramite], [dniCuilCli], [tipoTramite], [enviadoPor], [derivadoA]) VALUES (@IDTRAMITE, @DNICUILCLI, @TIPOTRAMITE, @ENVIADOPOR, @DERIVADOA)";
            Comando.Parameters.Add(new SqlCeParameter("@IDTRAMITE", SqlDbType.Int));
            Comando.Parameters["@IDTRAMITE"].Value = tram.IdTramite;
            Comando.Parameters.Add(new SqlCeParameter("@DNICUILCLI", SqlDbType.NVarChar));
            Comando.Parameters["@DNICUILCLI"].Value = tram.DniCuilCliente;
            Comando.Parameters.Add(new SqlCeParameter("@TIPOTRAMITE", SqlDbType.NVarChar));
            Comando.Parameters["@TIPOTRAMITE"].Value = tram.TipoTramite;
            Comando.Parameters.Add(new SqlCeParameter("@ENVIADOPOR", SqlDbType.NVarChar));
            Comando.Parameters["@ENVIADOPOR"].Value = tram.EnviadoPor;
            Comando.Parameters.Add(new SqlCeParameter("@DERIVADOA", SqlDbType.NVarChar));
            Comando.Parameters["@DERIVADOA"].Value = tram.DerivadoA;

            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();

        } //Añade nuevo tramite sin detalles

        public void Quitar(int idTram, string dniCuilCli)
        {

            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "DELETE FROM [Tramites] WHERE (([dniCuilCli] = @DNICUILCLI) AND ([idTramite]=@IDTRAMITE))";
            Comando.Parameters.Add(new SqlCeParameter("@DNICUILCLI", SqlDbType.NVarChar));
            Comando.Parameters["@DNICUILCLI"].Value = dniCuilCli;
            Comando.Parameters.Add(new SqlCeParameter("@IDTRAMITE", SqlDbType.Int));
            Comando.Parameters["@IDTRAMITE"].Value = idTram;

            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();

            
        }

        public void Actualizar(Tramite tram)
        {
            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "UPDATE [Tramites] SET [tipoTramite] = @TIPOTRAMITE, [enviadoPor] = @ENVIADOPOR, [derivadoA]=@DERIVADOA WHERE (([dniCuilCli] = @DNICUILCLI) AND ([idTramite]=@IDTRAMITE))";
            Comando.Parameters.Add(new SqlCeParameter("@DNICUILCLI", SqlDbType.NVarChar));
            Comando.Parameters["@DNICUILCLI"].Value = tram.DniCuilCliente;
            Comando.Parameters.Add(new SqlCeParameter("@IDTRAMITE", SqlDbType.Int));
            Comando.Parameters["@IDTRAMITE"].Value = tram.IdTramite;
            Comando.Parameters.Add(new SqlCeParameter("@TIPOTRAMITE", SqlDbType.NVarChar));
            Comando.Parameters["@TIPOTRAMITE"].Value = tram.TipoTramite;
           
            Comando.Parameters.Add(new SqlCeParameter("@ENVIADOPOR", SqlDbType.NVarChar));
            Comando.Parameters["@ENVIADOPOR"].Value = tram.EnviadoPor;
            Comando.Parameters.Add(new SqlCeParameter("@DERIVADOA", SqlDbType.NVarChar));
            Comando.Parameters["@DERIVADOA"].Value = tram.DerivadoA;


            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }

       
        public List<Tramite> GetAll()
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
       

        public int GetUltimoID()
        {
            int ultimoID;

            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT MAX(idTramite) AS ULTIMOID FROM Tramites", Con);
            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drTramites = Comando.ExecuteReader();

                drTramites.Read();
               
               ultimoID = (int)drTramites["ULTIMOID"];
               
               drTramites.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el Ultimo ID.", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return ultimoID;




        }

        /* NO SE USA List<Tramite> GetAllApe(filtroape)
       // Buscar por Apellido
        public List<Tramite> GetAllApe(string filtroApe)
        {
            List<Tramite> ListaTramites= new List<Tramite>();

            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT Tramites.idTramite, Tramites.dniCuilCli, Tramites.tipoTramite, Tramites.enviadoPor, Tramites.derivadoA FROM Tramites INNER JOIN Clientes on Tramites.dniCuilCli = Clientes.dnicuil WHERE apellido like  '%' + @FILTROAPE + '%'", Con);
            Comando.Parameters.Add(new SqlCeParameter("@FILTROAPE", SqlDbType.NVarChar));
            Comando.Parameters["@FILTROAPE"].Value = filtroApe;

            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drTramitesClientes = Comando.ExecuteReader();

                while (drTramitesClientes.Read())
                {
                    //Leo BD y lleno lista de Tramites
                    Tramite tram = new Tramite();

                    tram.IdTramite = (int)drTramitesClientes["idTramite"];
                    tram.DniCuilCliente = (string)drTramitesClientes["dniCuilCli"];
                    tram.TipoTramite = (string)drTramitesClientes["tipoTramite"];
                    tram.EnviadoPor = (string)drTramitesClientes["enviadoPor"];
                    tram.DerivadoA = (string)drTramitesClientes["derivadoA"];

                    ListaTramites.Add(tram);
                }
                drTramitesClientes.Close();

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

       // Buscar por Id Tramite
        public List<Tramite> GetAllIdTramite(string filtroIdTramite)
        {
            List<Tramite> ListaTramites = new List<Tramite>();

            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT Tramites.idTramite, Tramites.dniCuilCli, Tramites.tipoTramite, Tramites.enviadoPor, Tramites.derivadoA FROM Tramites INNER JOIN Clientes on Tramites.dniCuilCli = Clientes.dnicuil WHERE apellido like  '%' + @FILTROIDTRAMITE + '%'", Con);
            Comando.Parameters.Add(new SqlCeParameter("@FILTROIDTRAMITE", SqlDbType.NVarChar));
            Comando.Parameters["@FILTROIDTRAMITE"].Value = filtroIdTramite;

            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drTramitesClientes = Comando.ExecuteReader();

                while (drTramitesClientes.Read())
                {
                    //Leo BD y lleno lista de Tramites
                    Tramite tram = new Tramite();

                    tram.IdTramite = (int)drTramitesClientes["idTramite"];
                    tram.DniCuilCliente = (string)drTramitesClientes["dniCuilCli"];
                   
                    tram.TipoTramite = (string)drTramitesClientes["tipoTramite"];
                    tram.EnviadoPor = (string)drTramitesClientes["enviadoPor"];
                    tram.DerivadoA = (string)drTramitesClientes["derivadoA"];

                    ListaTramites.Add(tram);
                }
                drTramitesClientes.Close();

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


       // GET DATATABLE Listado de Tramites + Detalles
        public DataTable GetAllTramitesListado()
        {
            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT Tramites.idTramite, Tramites.dniCuilCli, Clientes.apellido + ', ' + Clientes.nombre AS [Nombre y Apellido], Tramites.tipoTramite, Detalles_Tramites.fechaDetalle, Tramites.enviadoPor,  Tramites.derivadoA, Detalles_Tramites.descripcion FROM [Tramites] INNER JOIN [Clientes] on Tramites.dniCuilCli = Clientes.dnicuil INNER JOIN [Detalles_Tramites] on Tramites.idTramite = Detalles_Tramites.idTramite where fechaDetalle IN (SELECT MAX(fechadetalle) as ULTFECHA FROM Detalles_Tramites WHERE Tramites.idTramite = Detalles_Tramites.idTramite) Order by Clientes.Apellido" , Con);
           

            //Crea DataTable para ser Origen de la Grilla
            DataTable dataTableTramitesListado = new DataTable();

            //Creacion de Columnas

            DataColumn idTramiteCOL = new DataColumn("idTramite");
            DataColumn dniCuilCliCOL = new DataColumn("dniCuilCli");
           // DataColumn NombreCOL = new DataColumn("Nombre");
           // DataColumn ApellidoCOL = new DataColumn("Apellido");
            DataColumn nombreyapellidoCOL = new DataColumn("Nombre y Apellido");
            DataColumn tipoTramite = new DataColumn("tipoTramite");
            
            DataColumn fechaDetalleCOL = new DataColumn("fechaDetalle");
            DataColumn enviadoPorCOL = new DataColumn("enviadoPor");
            DataColumn derivadoACOL = new DataColumn("derivadoA");
            DataColumn descripcionCol = new DataColumn("descripcion");



            //Agrego columnas a DataTable de DetallesTramite

            dataTableTramitesListado.Columns.Add(idTramiteCOL);
            dataTableTramitesListado.Columns.Add(dniCuilCliCOL);
          //  dataTableTramitesListado.Columns.Add(NombreCOL);
           // dataTableTramitesListado.Columns.Add(ApellidoCOL);
            dataTableTramitesListado.Columns.Add(nombreyapellidoCOL);
            dataTableTramitesListado.Columns.Add(tipoTramite);
            ;
            dataTableTramitesListado.Columns.Add(descripcionCol);
            dataTableTramitesListado.Columns.Add(fechaDetalleCOL);
            dataTableTramitesListado.Columns.Add(enviadoPorCOL);
            dataTableTramitesListado.Columns.Add(derivadoACOL);
            


            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drDetallesTram = Comando.ExecuteReader();

                while (drDetallesTram.Read())
                {
                    DataRow rowDetallesTram = dataTableTramitesListado.NewRow();

                    rowDetallesTram[idTramiteCOL] = (int)drDetallesTram["idTramite"];
                    rowDetallesTram[fechaDetalleCOL] = (DateTime)drDetallesTram["fechaDetalle"];
                    rowDetallesTram[descripcionCol] = (string)drDetallesTram["descripcion"];
                    rowDetallesTram[dniCuilCliCOL] = (string)drDetallesTram["dniCuilCli"];
                   // rowDetallesTram[NombreCOL] = (string)drDetallesTram["Nombre"];
                   // rowDetallesTram[ApellidoCOL] = (string)drDetallesTram["Apellido"];
                   rowDetallesTram[nombreyapellidoCOL] = (string)drDetallesTram["Nombre y Apellido"];
                    rowDetallesTram[tipoTramite] = (string)drDetallesTram["tipoTramite"];
                    rowDetallesTram[enviadoPorCOL]=(string)drDetallesTram["enviadoPor"];
                    rowDetallesTram[derivadoACOL]=(string)drDetallesTram["derivadoA"];


                    dataTableTramitesListado.Rows.Add(rowDetallesTram);
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



            return dataTableTramitesListado;
        }

        // GET DATATABLE Listado de Tramites + Detalles POR APELLIDO
        public DataTable GetAllTramitesListadoPorAPELLIDO(string filtroApe)
        {
            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta) 
            SqlCeCommand Comando = new SqlCeCommand("SELECT Tramites.dniCuilCli, Clientes.apellido + ', ' + Clientes.nombre AS [Nombre y Apellido], Tramites.tipoTramite, Detalles_Tramites.fechaDetalle, Tramites.idTramite, Tramites.enviadoPor, Tramites.derivadoA, Detalles_Tramites.descripcion FROM [Tramites] INNER JOIN [Clientes] on Tramites.dniCuilCli = Clientes.dnicuil INNER JOIN [Detalles_Tramites] on Tramites.idTramite = Detalles_Tramites.idTramite WHERE  fechaDetalle IN(SELECT MAX(fechaDetalle) AS ULTFECHA FROM Detalles_Tramites WHERE (Clientes.apellido like @APELLIDO + '%') AND (Tramites.idTramite = Detalles_Tramites.idTramite)) Order by Clientes.Apellido", Con);
            Comando.Parameters.Add(new SqlCeParameter("@APELLIDO", SqlDbType.NVarChar));
            Comando.Parameters["@APELLIDO"].Value = filtroApe;

            //Crea DataTable para ser Origen de la Grilla
            DataTable dataTableTramitesListado = new DataTable();

            //Creacion de Columnas
            DataColumn idTramiteCOL = new DataColumn("idTramite");
            DataColumn dniCuilCliCOL = new DataColumn("dniCuilCli");
            // DataColumn NombreCOL = new DataColumn("Nombre");
            // DataColumn ApellidoCOL = new DataColumn("Apellido");
            DataColumn nombreyapellidoCOL = new DataColumn("Nombre y Apellido");
            DataColumn tipoTramite = new DataColumn("tipoTramite");
           
            DataColumn fechaDetalleCOL = new DataColumn("fechaDetalle");
            DataColumn enviadoPorCOL = new DataColumn("enviadoPor");
            DataColumn derivadoACOL = new DataColumn("derivadoA");
            DataColumn descripcionCol = new DataColumn("descripcion");



            //Agrego columnas a DataTable de DetallesTramite
            dataTableTramitesListado.Columns.Add(idTramiteCOL);
            dataTableTramitesListado.Columns.Add(dniCuilCliCOL);
            //  dataTableTramitesListado.Columns.Add(NombreCOL);
            // dataTableTramitesListado.Columns.Add(ApellidoCOL);
            dataTableTramitesListado.Columns.Add(nombreyapellidoCOL);
            dataTableTramitesListado.Columns.Add(tipoTramite);
          
            dataTableTramitesListado.Columns.Add(descripcionCol);
            dataTableTramitesListado.Columns.Add(fechaDetalleCOL);
            dataTableTramitesListado.Columns.Add(enviadoPorCOL);
            dataTableTramitesListado.Columns.Add(derivadoACOL);



            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drDetallesTram = Comando.ExecuteReader();

                while (drDetallesTram.Read())
                {
                    DataRow rowDetallesTram = dataTableTramitesListado.NewRow();

                    rowDetallesTram[fechaDetalleCOL] = (DateTime)drDetallesTram["fechaDetalle"];
                    
                    rowDetallesTram[descripcionCol] = (string)drDetallesTram["descripcion"];
                    rowDetallesTram[idTramiteCOL] = (int)drDetallesTram["idTramite"];
                    rowDetallesTram[dniCuilCliCOL] = (string)drDetallesTram["dniCuilCli"];
                    // rowDetallesTram[NombreCOL] = (string)drDetallesTram["Nombre"];
                    // rowDetallesTram[ApellidoCOL] = (string)drDetallesTram["Apellido"];
                    rowDetallesTram[nombreyapellidoCOL] = (string)drDetallesTram["Nombre y Apellido"];
                    rowDetallesTram[tipoTramite] = (string)drDetallesTram["tipoTramite"];
                    rowDetallesTram[enviadoPorCOL] = (string)drDetallesTram["enviadoPor"];
                    rowDetallesTram[derivadoACOL] = (string)drDetallesTram["derivadoA"];


                    dataTableTramitesListado.Rows.Add(rowDetallesTram);
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



            return dataTableTramitesListado;
        }


     // GET DATATABLE Listado de Tramites + Detalles POR DNI
        public DataTable GetAllTramitesListadoPorDNI(string dniCli)
        {
            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta) 
            SqlCeCommand Comando = new SqlCeCommand("SELECT Tramites.dniCuilCli, Clientes.apellido + ', ' + Clientes.nombre AS [Nombre y Apellido], Tramites.tipoTramite, Detalles_Tramites.fechaDetalle, Tramites.idTramite, Tramites.enviadoPor, Tramites.derivadoA, Detalles_Tramites.descripcion FROM [Tramites] INNER JOIN [Clientes] on Tramites.dniCuilCli = Clientes.dnicuil INNER JOIN [Detalles_Tramites] on Tramites.idTramite = Detalles_Tramites.idTramite WHERE  fechaDetalle IN(SELECT MAX(fechaDetalle) AS ULTFECHA FROM Detalles_Tramites WHERE (Clientes.dnicuil like @DNI + '%') AND (Tramites.idTramite = Detalles_Tramites.idTramite)) Order by Clientes.Apellido", Con);
            Comando.Parameters.Add(new SqlCeParameter("@DNI", SqlDbType.NVarChar));
            Comando.Parameters["@DNI"].Value = dniCli;

            //Crea DataTable para ser Origen de la Grilla
            DataTable dataTableTramitesListado = new DataTable();

            //Creacion de Columnas
            DataColumn idTramiteCOL = new DataColumn("idTramite");
            DataColumn dniCuilCliCOL = new DataColumn("dniCuilCli");
            // DataColumn NombreCOL = new DataColumn("Nombre");
            // DataColumn ApellidoCOL = new DataColumn("Apellido");
            DataColumn nombreyapellidoCOL = new DataColumn("Nombre y Apellido");
            DataColumn tipoTramite = new DataColumn("tipoTramite");

            DataColumn fechaDetalleCOL = new DataColumn("fechaDetalle");
            DataColumn enviadoPorCOL = new DataColumn("enviadoPor");
            DataColumn derivadoACOL = new DataColumn("derivadoA");
            DataColumn descripcionCol = new DataColumn("descripcion");



            //Agrego columnas a DataTable de DetallesTramite
            dataTableTramitesListado.Columns.Add(idTramiteCOL);
            dataTableTramitesListado.Columns.Add(dniCuilCliCOL);
            //  dataTableTramitesListado.Columns.Add(NombreCOL);
            // dataTableTramitesListado.Columns.Add(ApellidoCOL);
            dataTableTramitesListado.Columns.Add(nombreyapellidoCOL);
            dataTableTramitesListado.Columns.Add(tipoTramite);

            dataTableTramitesListado.Columns.Add(descripcionCol);
            dataTableTramitesListado.Columns.Add(fechaDetalleCOL);
            dataTableTramitesListado.Columns.Add(enviadoPorCOL);
            dataTableTramitesListado.Columns.Add(derivadoACOL);



            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drDetallesTram = Comando.ExecuteReader();

                while (drDetallesTram.Read())
                {
                    DataRow rowDetallesTram = dataTableTramitesListado.NewRow();

                    rowDetallesTram[fechaDetalleCOL] = (DateTime)drDetallesTram["fechaDetalle"];

                    rowDetallesTram[descripcionCol] = (string)drDetallesTram["descripcion"];
                    rowDetallesTram[idTramiteCOL] = (int)drDetallesTram["idTramite"];
                    rowDetallesTram[dniCuilCliCOL] = (string)drDetallesTram["dniCuilCli"];
                    // rowDetallesTram[NombreCOL] = (string)drDetallesTram["Nombre"];
                    // rowDetallesTram[ApellidoCOL] = (string)drDetallesTram["Apellido"];
                    rowDetallesTram[nombreyapellidoCOL] = (string)drDetallesTram["Nombre y Apellido"];
                    rowDetallesTram[tipoTramite] = (string)drDetallesTram["tipoTramite"];
                    rowDetallesTram[enviadoPorCOL] = (string)drDetallesTram["enviadoPor"];
                    rowDetallesTram[derivadoACOL] = (string)drDetallesTram["derivadoA"];


                    dataTableTramitesListado.Rows.Add(rowDetallesTram);
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



            return dataTableTramitesListado;
        }  


    }
}
