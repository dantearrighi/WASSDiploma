using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlServerCe;
using Entidades;

namespace Data.Database
{
 public   class PagosEntrantesAdapter : Adapter
    {
        public DataTable GetPagosTramite(int idTram, string dnicuil)
        {

            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT PagosEntrantes.fecha, PagosEntrantes.valor, PagosEntrantes.detalle FROM PagosEntrantes WHERE (idTramite = @IDTRAMITE) AND (dniCuilCliente = @DNICUIL)", Con);
            Comando.Parameters.Add(new SqlCeParameter("@IDTRAMITE", SqlDbType.Int));
            Comando.Parameters["@IDTRAMITE"].Value = idTram;
            Comando.Parameters.Add(new SqlCeParameter("@DNICUIL", SqlDbType.NVarChar));
            Comando.Parameters["@DNICUIL"].Value = dnicuil;

            //Crea DataTable para ser Origen de la Grilla
            DataTable dtPagos = new DataTable();

            //Creacion de Columnas
            DataColumn fechaCOL = new DataColumn("fecha");
            DataColumn valorCOL = new DataColumn("valor");
            DataColumn detalleCol = new DataColumn("detalle");



            //Agrego columnas a DataTable de DetallesTramite
            dtPagos.Columns.Add(fechaCOL);
            dtPagos.Columns.Add(valorCOL);
            dtPagos.Columns.Add(detalleCol);


            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drPagos = Comando.ExecuteReader();

                while (drPagos.Read())
                {
                    DataRow rowPagos = dtPagos.NewRow();

                    rowPagos[fechaCOL] = (DateTime)drPagos["fecha"];
                    rowPagos[valorCOL] = (decimal)drPagos["valor"];
                    rowPagos[detalleCol] = (string)drPagos["detalle"];


                    dtPagos.Rows.Add(rowPagos);
                }
                drPagos.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar información sobre pagos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return dtPagos;
        }

     //AñadirPago
        public void AñadirNuevo(PagoEntrante pagEntr)
        {

            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "INSERT INTO [PagosEntrantes] ([idTramite], [dniCuilCliente], [fecha], [valor], [detalle]) VALUES (@IDTRAMITE, @DNICUILCLI, @FECHA, @VALOR, @DETALLE)";
            Comando.Parameters.Add(new SqlCeParameter("@IDTRAMITE", SqlDbType.Int));
            Comando.Parameters["@IDTRAMITE"].Value = pagEntr.IdTramite;
            Comando.Parameters.Add(new SqlCeParameter("@DNICUILCLI", SqlDbType.NVarChar));
            Comando.Parameters["@DNICUILCLI"].Value = pagEntr.DniCuilCliente;
            Comando.Parameters.Add(new SqlCeParameter("@FECHA", SqlDbType.DateTime));
            Comando.Parameters["@FECHA"].Value = pagEntr.Fecha;
            Comando.Parameters.Add(new SqlCeParameter("@VALOR", SqlDbType.Money));
            Comando.Parameters["@VALOR"].Value = pagEntr.Valor;
            Comando.Parameters.Add(new SqlCeParameter("@DETALLE", SqlDbType.NVarChar));
            Comando.Parameters["@DETALLE"].Value = pagEntr.Detalle;

            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();

        } 
    }
}
