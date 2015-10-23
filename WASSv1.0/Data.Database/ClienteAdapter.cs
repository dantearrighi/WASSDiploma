using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using Entidades;
using System.Data;

namespace Data.Database
{
  public  class ClienteAdapter : Adapter
    {

        public void AñadirNuevo(Cliente cli)
        {

            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "INSERT INTO [Clientes] ([dnicuil], [nombre], [apellido], [email], [tel1], [tel2]) VALUES (@DNICUIL, @NOMBRE, @APELLIDO, @EMAIL, @TEL1, @TEL2)";
            Comando.Parameters.Add(new SqlCeParameter("@DNICUIL", SqlDbType.NVarChar));
            Comando.Parameters["@DNICUIL"].Value = cli.DniCuil;
            Comando.Parameters.Add(new SqlCeParameter("@NOMBRE", SqlDbType.NVarChar));
            Comando.Parameters["@NOMBRE"].Value = cli.Nombre;
            Comando.Parameters.Add(new SqlCeParameter("@APELLIDO", SqlDbType.NVarChar));
            Comando.Parameters["@APELLIDO"].Value = cli.Apellido;
            Comando.Parameters.Add(new SqlCeParameter("@EMAIL", SqlDbType.NVarChar));
            Comando.Parameters["@EMAIL"].Value = cli.Email;
            Comando.Parameters.Add(new SqlCeParameter("@TEL1", SqlDbType.NVarChar));
            Comando.Parameters["@TEL1"].Value = cli.Tel1;
            Comando.Parameters.Add(new SqlCeParameter("@TEL2", SqlDbType.NVarChar));
            Comando.Parameters["@TEL2"].Value = cli.Tel2;

            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();

        }

        public void Quitar(string dniCuill)
        {

            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "DELETE FROM [Clientes] WHERE ([dnicuil] = @dnicuill)";
            Comando.Parameters.Add(new SqlCeParameter("@dnicuill", SqlDbType.NVarChar));
            Comando.Parameters["@dnicuill"].Value = dniCuill;

            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }

        public void Actualizar(Entidades.Cliente cli, string dniActual)
        {
            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "UPDATE [Clientes] SET [dnicuil]=@DNINuevo,[nombre] = @NOMBRE, [apellido] = @APELLIDO, [email] = @EMAIL, [tel1]=@TEL1, [tel2]=@TEL2 WHERE (([dnicuil] = @DNICUILACTUAL))";
            Comando.Parameters.Add(new SqlCeParameter("@DNICUILACTUAL", SqlDbType.NVarChar));
            Comando.Parameters["@DNICUILACTUAL"].Value = dniActual;
            Comando.Parameters.Add(new SqlCeParameter("@NOMBRE", SqlDbType.NVarChar));
            Comando.Parameters["@NOMBRE"].Value = cli.Nombre;
            Comando.Parameters.Add(new SqlCeParameter("@APELLIDO", SqlDbType.NVarChar));
            Comando.Parameters["@APELLIDO"].Value = cli.Apellido;
            Comando.Parameters.Add(new SqlCeParameter("@EMAIL", SqlDbType.NVarChar));
            Comando.Parameters["@EMAIL"].Value = cli.Email;
            Comando.Parameters.Add(new SqlCeParameter("@TEL1", SqlDbType.NVarChar));
            Comando.Parameters["@TEL1"].Value = cli.Tel1;
            Comando.Parameters.Add(new SqlCeParameter("@TEL2", SqlDbType.NVarChar));
            Comando.Parameters["@TEL2"].Value = cli.Tel2;
            Comando.Parameters.Add(new SqlCeParameter("@DNINuevo", SqlDbType.NVarChar));
            Comando.Parameters["@DNINuevo"].Value = cli.DniCuil;

            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }
      
        public DataTable GetAllClientes()
        {
            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT Clientes.dnicuil, Clientes.apellido + ', ' + Clientes.nombre AS [Apellido y Nombre], Clientes.email, Clientes.tel1, Clientes.tel2 FROM Clientes", Con);
            

            //Crea DataTable para ser Origen de la Grilla
            DataTable dataTableClientes = new DataTable();

            //Creacion de Columnas
            DataColumn dnicuilCOL = new DataColumn("DNI - CUIL");
            DataColumn nombreyapellidoCOL = new DataColumn("Apellido y Nombre");
            DataColumn emailCOL = new DataColumn("Email");
            DataColumn tel1COL = new DataColumn("Teléfono");
            DataColumn tel2COL = new DataColumn("Teléfono Alt.");



            //Agrego columnas a DataTable de Clientes
            dataTableClientes.Columns.Add(dnicuilCOL);
            dataTableClientes.Columns.Add(nombreyapellidoCOL);
            dataTableClientes.Columns.Add(emailCOL);
            dataTableClientes.Columns.Add(tel1COL);
            dataTableClientes.Columns.Add(tel2COL);

            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drClientes = Comando.ExecuteReader();

                while (drClientes.Read())
                {
                    DataRow rowCliente = dataTableClientes.NewRow();

                    rowCliente[dnicuilCOL] = (string)drClientes["dnicuil"];
                    rowCliente[nombreyapellidoCOL] = (string)drClientes["Apellido y Nombre"];
                    rowCliente[emailCOL] = (string)drClientes["email"];
                    rowCliente[tel1COL] = (string)drClientes["tel1"];
                    rowCliente[tel2COL] = (string)drClientes["tel2"];



                    dataTableClientes.Rows.Add(rowCliente);
                }
                drClientes.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar información de Clientes", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return dataTableClientes;
        }

        public DataTable GetAllClientesApe(string filtro)
        {
            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT Clientes.dnicuil, Clientes.apellido + ', ' + Clientes.nombre AS [Apellido y Nombre], Clientes.email, Clientes.tel1, Clientes.tel2 FROM Clientes WHERE Clientes.apellido like @FILTRO  + '%'", Con);
            Comando.Parameters.Add(new SqlCeParameter("@FILTRO", SqlDbType.NVarChar));
            Comando.Parameters["@FILTRO"].Value = filtro;

            //Crea DataTable para ser Origen de la Grilla
            DataTable dataTableClientes = new DataTable();

            //Creacion de Columnas
            DataColumn dnicuilCOL = new DataColumn("DNI - CUIL");
            DataColumn nombreyapellidoCOL = new DataColumn("Apellido y Nombre");
            DataColumn emailCOL = new DataColumn("Email");
            DataColumn tel1COL = new DataColumn("Teléfono");
            DataColumn tel2COL = new DataColumn("Teléfono Alt.");
           


            //Agrego columnas a DataTable de DetallesTramite
            dataTableClientes.Columns.Add(dnicuilCOL);
            dataTableClientes.Columns.Add(nombreyapellidoCOL);
            dataTableClientes.Columns.Add(emailCOL);
            dataTableClientes.Columns.Add(tel1COL);
            dataTableClientes.Columns.Add(tel2COL);
         
            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drClientes = Comando.ExecuteReader();

                while (drClientes.Read())
                {
                    DataRow rowCliente = dataTableClientes.NewRow();

                    rowCliente[dnicuilCOL] = (string)drClientes["dnicuil"];
                    rowCliente[nombreyapellidoCOL] = (string)drClientes["Apellido y Nombre"];
                    rowCliente[emailCOL] = (string)drClientes["email"];
                    rowCliente[tel1COL] = (string)drClientes["tel1"];
                    rowCliente[tel2COL] = (string)drClientes["tel2"];
                   


                   dataTableClientes.Rows.Add(rowCliente);
                }
                drClientes.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar información de Clientes", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return dataTableClientes;
        }
      
        public DataTable GetAllClientesDni(string filtro)
        {
            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)                                                                                                                      
            SqlCeCommand Comando = new SqlCeCommand("SELECT Clientes.dnicuil, Clientes.apellido + ', ' + Clientes.nombre AS [Apellido y Nombre], Clientes.email, Clientes.tel1, Clientes.tel2 FROM Clientes WHERE Clientes.dnicuil like @FILTRO + '%'", Con);
            Comando.Parameters.Add(new SqlCeParameter("@FILTRO", SqlDbType.NVarChar));
            Comando.Parameters["@FILTRO"].Value = filtro;

            //Crea DataTable para ser Origen de la Grilla
            DataTable dataTableClientes = new DataTable();

            //Creacion de Columnas
            DataColumn dnicuilCOL = new DataColumn("DNI - CUIL");
            DataColumn nombreyapellidoCOL = new DataColumn("Apellido y Nombre");
            DataColumn emailCOL = new DataColumn("Email");
            DataColumn tel1COL = new DataColumn("Teléfono");
            DataColumn tel2COL = new DataColumn("Teléfono Alt.");



            //Agrego columnas a DataTable de DetallesTramite
            dataTableClientes.Columns.Add(dnicuilCOL);
            dataTableClientes.Columns.Add(nombreyapellidoCOL);
            dataTableClientes.Columns.Add(emailCOL);
            dataTableClientes.Columns.Add(tel1COL);
            dataTableClientes.Columns.Add(tel2COL);

            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drClientes = Comando.ExecuteReader();

                while (drClientes.Read())
                {
                    DataRow rowCliente = dataTableClientes.NewRow();

                    rowCliente[dnicuilCOL] = (string)drClientes["dnicuil"];
                    rowCliente[nombreyapellidoCOL] = (string)drClientes["Apellido y Nombre"];
                    rowCliente[emailCOL] = (string)drClientes["email"];
                    rowCliente[tel1COL] = (string)drClientes["tel1"];
                    rowCliente[tel2COL] = (string)drClientes["tel2"];



                    dataTableClientes.Rows.Add(rowCliente);
                }
                drClientes.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar información de Clientes", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return dataTableClientes;
        }

      // Get ALL's Otros
        public List<Entidades.Cliente> GetAllApe(string filtro)
        {
            List<Entidades.Cliente> ListaClientes = new List<Entidades.Cliente>();

            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT * FROM Clientes WHERE apellido like  '%' + @FILTRO + '%'", Con);
            Comando.Parameters.Add(new SqlCeParameter("@FILTRO", SqlDbType.NVarChar));
            Comando.Parameters["@FILTRO"].Value = filtro;

            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drClientes = Comando.ExecuteReader();

                while (drClientes.Read())
                {
                    Entidades.Cliente cli = new Entidades.Cliente();

                    cli.Apellido = (string)drClientes["apellido"];
                    cli.Nombre = (string)drClientes["nombre"];
                    cli.DniCuil = (string)drClientes["dnicuil"];
                    cli.Email = (string)drClientes["email"];
                    cli.Tel1 = (string)drClientes["tel1"];
                    cli.Tel2 = (string)drClientes["tel2"];



                    ListaClientes.Add(cli);
                }
                drClientes.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Clientes", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return ListaClientes;

        }

        public List<Entidades.Cliente> GetAllDni(string filtro)
        {
            List<Entidades.Cliente> ListaClientes = new List<Entidades.Cliente>();

            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT * FROM Clientes WHERE dnicuil like  '%' + @FILTRO + '%'", Con);
            Comando.Parameters.Add(new SqlCeParameter("@FILTRO", SqlDbType.NVarChar));
            Comando.Parameters["@FILTRO"].Value = filtro;

            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drClientes = Comando.ExecuteReader();

                while (drClientes.Read())
                {
                    Entidades.Cliente cli = new Entidades.Cliente();

                    cli.Apellido = (string)drClientes["apellido"];
                    cli.Nombre = (string)drClientes["nombre"];
                    cli.DniCuil = (string)drClientes["dnicuil"];
                    cli.Email = (string)drClientes["email"];
                    cli.Tel1 = (string)drClientes["tel1"];
                    cli.Tel2 = (string)drClientes["tel2"];




                    ListaClientes.Add(cli);
                }
                drClientes.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Clientes", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return ListaClientes;

        }

      // Se usa
        public List<Entidades.Cliente> GetAll()
        {
            List<Entidades.Cliente> ListaClientes = new List<Entidades.Cliente>();
            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT * FROM Clientes", Con);
            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drClientes = Comando.ExecuteReader();

                while (drClientes.Read())
                {
                    Entidades.Cliente cli = new Entidades.Cliente();

                   
                    cli.Apellido = (string)drClientes["apellido"];
                    cli.Nombre = (string)drClientes["nombre"];
                    cli.DniCuil = (string)drClientes["dnicuil"];
                    cli.Email = (string)drClientes["email"];
                    cli.Tel1 = (string)drClientes["tel1"];
                    cli.Tel2 = (string)drClientes["tel2"];
                    


                    ListaClientes.Add(cli);
                }
                drClientes.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Clientes", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return ListaClientes;




        }


        public Entidades.Cliente GetOne(string dni)
        {
            
               Entidades.Cliente cli = new Entidades.Cliente();

            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT * FROM Clientes WHERE dnicuil = @DNI", Con);
            Comando.Parameters.Add(new SqlCeParameter("@DNI", SqlDbType.NVarChar));
            Comando.Parameters["@DNI"].Value = dni;

            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drClientes = Comando.ExecuteReader();

                drClientes.Read();
                
                 

                    cli.Apellido = (string)drClientes["apellido"];
                    cli.Nombre = (string)drClientes["nombre"];
                    cli.DniCuil = (string)drClientes["dnicuil"];
                    cli.Email = (string)drClientes["email"];
                    cli.Tel1 = (string)drClientes["tel1"];
                    cli.Tel2 = (string)drClientes["tel2"];




                    
                
                drClientes.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos del Clientes", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return cli;

        }
    
  
  }
}
