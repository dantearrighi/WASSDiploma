using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data.Database;

namespace WASSv1._0.Clientes
{
    public partial class frmClienteABM : Form
    {
        // Constructor ALTA
        public frmClienteABM()
        {
            InitializeComponent();
            this.ModoForm = TipoForm.Alta;
            this.Text = "Añadir nuevo Cliente";
            this.gbDatosCliente.Text = "Ingreso de Datos";
        }

        // Constructor MODIFICACIÓN
        public frmClienteABM(Entidades.Cliente cli)
        {
            InitializeComponent();

            this.ModoForm = TipoForm.Modificacion;
            this.Text = "Modificar Cliente";
            this.gbDatosCliente.Text = "Edición de Datos";
            txtDniCuil.Text = cli.DniCuil;
            txtNombre.Text = cli.Nombre;
            txtApellido.Text = cli.Apellido;
            txtEmail.Text = cli.Email;
            txtTel1.Text = cli.Tel1;
            txtTel2.Text = cli.Tel2;
            
            


        }



        #region ///***///***///***/// V A R I A B L E S \\\***\\\***\\\***\\\

        public string dniActual;

        ClienteAdapter Datos_ClienteAdapter = new ClienteAdapter();

        #endregion


        #region ///***///***///***/// P R O P I E D A D E S \\\***\\\***\\\***\\\

        TipoForm _modoForm;
        public TipoForm ModoForm
        {
            get { return _modoForm; }
            set { _modoForm = value; }
        }


        #endregion

        
        #region ///***///***///***/// E N U M E R A D O R E S \\\***\\\***\\\***\\\


        public enum TipoForm
        {
            Alta,
            Modificacion

        }

        #endregion


        #region ///***///***///***/// E V E N T O S \\\***\\\***\\\***\\\

        // BOTON GUARDAR CLICK //ALTA CLIENTE 
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (ModoForm == TipoForm.Modificacion)
            {
                Entidades.Cliente cli = new Entidades.Cliente();

                cli.DniCuil = txtDniCuil.Text;
                cli.Nombre = txtNombre.Text;
                cli.Apellido = txtApellido.Text;
                cli.Email = txtEmail.Text;
                cli.Tel1 = txtTel1.Text;
                cli.Tel2 = txtTel2.Text;

                Datos_ClienteAdapter.Actualizar(cli, dniActual);
             }
            else if (ModoForm == TipoForm.Alta)
            {
                // Genero una nueva instancia de la entidad
                Entidades.Cliente cli = new Entidades.Cliente();

                // Valido Datos
                if (Validar())
                {
                    try
                    {
                        // TXT to nuevoCliente
                       
                        cli.DniCuil = txtDniCuil.Text;
                        cli.Nombre = txtNombre.Text;
                        cli.Apellido = txtApellido.Text;
                        cli.Email = txtEmail.Text;
                        cli.Tel1 = txtTel1.Text;
                        cli.Tel2 = txtTel2.Text;


                        // nuevoCliente to Base de Datos (capa de datos)
                        Datos_ClienteAdapter.AñadirNuevo(cli);
                        
                        
                    }
                    catch (Exception ex)
                    {
                        // Muestro cualquier error de la aplicacion
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        // Libero objetos
                        cli = null;
                    }
                }
                              
            }
            this.Close();


            
        }

        #endregion


        bool Validar()
        {
            string mensaje = "";
            txtDniCuil.Text = txtDniCuil.Text.Trim();
            //Valido numero de documento
            if (txtDniCuil.Text.Trim() == "")
                mensaje += "- El DNI no puede estar en blanco." + "\n";

            //Consulta BD para no añadir dni repetido

            ClienteAdapter ClienteAdapter = new ClienteAdapter();

            List<Entidades.Cliente> ListaClientes = ClienteAdapter.GetAll();

            if (ModoForm == TipoForm.Alta)
            {
                foreach (Entidades.Cliente cli in ListaClientes)
                {
                    if (cli.DniCuil == txtDniCuil.Text)
                    {
                        mensaje += "Ya existe un cliente registrado con el DNI ingresado." + "\n";
                    }
                }
            }

            // Mostrar Errors
            if (!String.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;


        }

        //Teclas Rapidas
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {

                case Keys.Escape:
                    this.Close();
                    break;



                default:

                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
