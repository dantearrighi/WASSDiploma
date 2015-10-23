using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Data.Database;

namespace WASSv1._0.Tramites
{
    public partial class frmTramiteABM : Form
    {
        //Constructor ALTA
        public frmTramiteABM()
        {
            InitializeComponent();

         
            this.ModoForm = TipoForm.Alta;
            this.Text = "Alta de Trámite";

            int ultimoId = Datos_TramiteAdapter.GetUltimoID();
            ultimoId = ultimoId + 1;
            this.txtIDTramite.Text = Convert.ToString(ultimoId);
           
           
            this.txtDetalles.Text = "Alta";
            this.Width = 748;

            this.txtApellido.ReadOnly = true;
            this.txtNombre.ReadOnly = true;
            this.txtDNICUIL.ReadOnly = true;

            this.btnAddDetalleLong.Visible = false;
            this.txtDescripcionNueva.Visible = false;
          

            this.btnGuardarNuevoDetalle.Visible = false;
            this.lblDescriNueva.Visible = true;
            this.label5.Visible = false;

            this.txtUltimoMovFecha.Text = DateTime.Now.ToString() ;
            this.txtUltimoMovFecha.ReadOnly = true;

            this.btnRegistrarPagoIngresado.Visible = false;
          
                    
        }

      
        //Constructor MODIFICACION
        public frmTramiteABM(Tramite tram)
        {
            InitializeComponent();

            
            this.ModoForm = TipoForm.Modificacion;
            this.Text = "Ver / Modificar Trámite";
            this.txtIDTramite.ReadOnly = true;
            this.txtDNICUIL.ReadOnly = true;
            this.txtNombre.ReadOnly = true;
            this.txtApellido.ReadOnly = true;
            this.dgvDetallesTramite.DataSource = Datos_DetallesTramiteAdapter.GetDetallesTramite(tram.IdTramite);
            this.dgvDetallesTramite.DefaultCellStyle.BackColor = Color.Beige;
            tramiteActual = tram;
            this.txtDetalles.ReadOnly = true;
            this.txtDetalles.BackColor = Color.LightBlue;
            this.txtUltimoMovFecha.ReadOnly = true;
            this.txtUltimoMovFecha.BackColor = Color.LightBlue;
            this.Width = 748;
            this.btnBuscarCli.Visible = false;
            this.lblBuscarCli.Visible = false;
            this.btnRegistrarPagoIngresado.Visible = false;
          


            

         
            
            
        }

       
           
          
        
 
        #region ///***///***///***/// V A R I A B L E S \\\***\\\***\\\***\\\

        PagosEntrantesAdapter Datos_PagosEntrantesAdapter = new PagosEntrantesAdapter();
        
        Detalles_TramiteAdapter Datos_DetallesTramiteAdapter = new Detalles_TramiteAdapter();

        Data.Database.TramiteAdapter Datos_TramiteAdapter = new Data.Database.TramiteAdapter();

        InformesAdapter Datos_InformesAdapter = new InformesAdapter();
        Entidades.Tramite tramiteActual;

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
       
        // GUARDAR TRAMITE CLICK
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ModoForm == TipoForm.Alta)
            {
                // Genero una nueva instancia de la entidad
                Tramite tram = new Tramite();
                Detalles_Tramite det_tram = new Detalles_Tramite();

                // Valido Datos
                if (Validar())
                {
                    try
                    {
                        // TXT to nuevoTramite

                        tram.IdTramite = Convert.ToInt32(txtIDTramite.Text);
                        tram.DniCuilCliente = txtDNICUIL.Text;
                        tram.TipoTramite = txtTipoTramite.Text;
                        tram.EnviadoPor = txtEnviadoPor.Text;
                        tram.DerivadoA = txtDerivadoA.Text;
                        det_tram.idTramite = tram.IdTramite;
                        det_tram.FechaDetalle = DateTime.Now;
                        
                        det_tram.Descripcion = txtDetalles.Text;

                        // nuevoCliente to Base de Datos (capa de datos)
                        Datos_TramiteAdapter.AñadirNuevo(tram);
                        Datos_DetallesTramiteAdapter.AñadirNuevo(det_tram);

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        // Muestro cualquier error de la aplicacion
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        // Libero objetos
                        tram = null;
                        det_tram = null;
                    }
                }

            }
            else
            {
                // Esto no lo probé
                Tramite tramiToEdit = new Tramite();
                
                    tramiToEdit.IdTramite = tramiteActual.IdTramite;
                    tramiToEdit.EnviadoPor = txtEnviadoPor.Text.Trim();
                    tramiToEdit.DerivadoA = txtDerivadoA.Text.Trim();
                    tramiToEdit.TipoTramite = txtTipoTramite.Text.Trim();
                    tramiToEdit.DniCuilCliente = txtDNICUIL.Text.Trim();
                
                Datos_TramiteAdapter.Actualizar(tramiToEdit);
            }

            this.Close();
        }

        // BUSCARCLIENTE() CLICK LUPA
        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            Clientes.frmListaClientes formSeleccionarCliente = new WASSv1._0.Clientes.frmListaClientes();
            formSeleccionarCliente.btnImportar.Visible = false;
            formSeleccionarCliente.btnElimClie.Visible = false;
            formSeleccionarCliente.btnSeleccionarCli.Visible = true;
            formSeleccionarCliente.btnExcel.Visible = false;
            
            formSeleccionarCliente.ShowDialog();

            //VALIDAR SI EXISTEN TRAMITES PARA ESTE CLIENTE. SI ES ASI, PREGUNTAR SI DEseA CREAR OTRO Y
            ///MOSTRAR LOS DATOS DEL TRAMITE ACTUAL.
     /*       DataTable TramitesDelCliente=  Datos_TramiteAdapter.GetAllTramitesListadoPorDNI(formSeleccionarCliente.cliSelect.DniCuil);

            if (TramitesDelCliente.Rows.Count != 0)
            {
                string mensajetramiterepetido = "Se ha encontrado un trámite similar con los siguientes datos:\n\nNombre: "+formSeleccionarCliente.cliSelect.Nombre.ToString() + "\nApellido: " formSeleccionarCliente.cliSelect.Apellido.ToString() + "\nDNI-CUIL: "formSeleccionarCliente.cliSelect.DniCuil.ToString()+"\nTipo de Trámite: "+ TramitesDelCliente.Columns[3].
                MessageBox.Show("Se ha encontrado un trámite similar:\n\nNombre: ");
            
            }
      */ 
            this.txtDNICUIL.Text = formSeleccionarCliente.cliSelect.DniCuil;
            this.txtNombre.Text = formSeleccionarCliente.cliSelect.Nombre;
            this.txtApellido.Text = formSeleccionarCliente.cliSelect.Apellido;


            
        }

        // TECLAS
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {

                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.Enter:
                    if (this.txtDescripcionNueva.Focused)
                    {
                        GuardarDetalleNuevo();
                    }
                    break;
                
               
                
                default:

                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // REPORTE CLICK
        private void btnImprimirReporte_Click(object sender, EventArgs e)
        {
            string idTram = tramiteActual.IdTramite.ToString();

            string sql = "SELECT Tramites.idTramite, Tramites.dniCuilCli,	Clientes.apellido + ', ' + Clientes.nombre AS [Nombre y Apellido], Clientes.tel1, Clientes.tel2, Clientes.email, Tramites.tipoTramite, Tramites.enviadoPor, Tramites.derivadoA, Detalles_Tramites.fechaDetalle, Detalles_Tramites.descripcion FROM [Tramites] INNER JOIN [Clientes] on Tramites.dniCuilCli = Clientes.dnicuil INNER JOIN [Detalles_Tramites] on Tramites.idTramite = Detalles_Tramites.idTramite WHERE (Tramites.idTramite =" + idTram + ")";

            if(Datos_InformesAdapter.BuscarRegistros(sql))
            {
                 System.IO.Directory.CreateDirectory("C:\\XML");
            string url = "C:\\XML\\informeTramite.xml";

               Datos_InformesAdapter.tablas.WriteXml(url, XmlWriteMode.WriteSchema);
              
            }

            frmInformeTramite formInformeTramite = new frmInformeTramite();
            formInformeTramite.ShowDialog();
            System.IO.File.Delete("C:\\XML\\informeTramite.xml");


           
        }

        // AGREGAR DETALLES DEL TRAMITE CLICK LARGO
        private void btnAddDetalleLong_Click(object sender, EventArgs e)
        {
            btnAddDetalleLong.Visible = false;
        }

        // GUARDAR DETALLE NUEVO CLICK
        private void btnGuardarNuevoDetalle_Click(object sender, EventArgs e)
        {
            GuardarDetalleNuevo();

        }

        private void GuardarDetalleNuevo()
        {
            Detalles_Tramite det_tram_nuevo = new Detalles_Tramite();

            // txtIDTramite está oculto. Tomar el ID de otro Lado.
            det_tram_nuevo.idTramite = tramiteActual.IdTramite;
            det_tram_nuevo.FechaDetalle = DateTime.Now;

            det_tram_nuevo.Descripcion = txtDescripcionNueva.Text.ToString().Trim();

            Datos_DetallesTramiteAdapter.AñadirNuevo(det_tram_nuevo);


            this.txtDetalles.Text = det_tram_nuevo.Descripcion;
            this.txtUltimoMovFecha.Text = det_tram_nuevo.FechaDetalle.ToString();


            this.dgvDetallesTramite.DataSource = Datos_DetallesTramiteAdapter.GetDetallesTramite(det_tram_nuevo.idTramite);
            btnAddDetalleLong.Text = "Añadir otro Detalle";
            btnAddDetalleLong.Visible = true;
        }

       
        // AÑADIR PAGO CLICK

        private void btnAñadirPago_Click(object sender, EventArgs e)
        {
            if (this.ModoForm == TipoForm.Modificacion)
            {

                this.txtPagoDetalle.Visible = true;
                this.txtPagoValor.Visible = true;
                this.dateTimePicker1.Visible = true;
                this.lblPagConcepto.Visible = true;
                this.lblPagMonto.Visible = true;
                this.lblFechaPago.Visible = true;
                this.btnAñadirPago.Visible = false;
                this.btnRegistrarPagoIngresado.Visible = true;
            }
            else
            {
                MessageBox.Show("Para registrar pagos de un trámite, debe primero completar los datos, confirmar el alta del mismo haciendo click en el botón ''Guardar'', luego seleccionarlo de la lista de trámites e ingresar en la opción Ver/Modificar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }


        #endregion


        #region ///***///***///***/// M E T O D O S \\\***\\\***\\\***\\\

        bool Validar()
        {
            string mensaje = "";
            txtIDTramite.Text = txtIDTramite.Text.Trim();
            //Valido numero de documento
            if (txtIDTramite.Text.Trim() == "")
                mensaje += "- El ID del tramite no puede estar en blanco." + "\n";


            //Consulta BD para no añadir IDrepetido



            List<Tramite> ListaTramites = Datos_TramiteAdapter.GetAll();

            if (ModoForm == TipoForm.Alta)
            {
                foreach (Entidades.Tramite trami in ListaTramites)
                {
                    if (trami.IdTramite == Convert.ToInt32(txtIDTramite.Text.Trim()))
                    {
                        mensaje += "Ya existe un tramite registrado con ese ID." + "\n";
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

        
        private void ActualizarListaPagos(int idTramite, string dniCuil)
        {
            this.dgvPagos.DataSource = Datos_PagosEntrantesAdapter.GetPagosTramite(idTramite,dniCuil);
        }


        #endregion



        private void frmTramiteABM_Load(object sender, EventArgs e)
        {
            if (this.ModoForm == TipoForm.Modificacion)
            {
                ActualizarListaPagos(tramiteActual.IdTramite, txtDNICUIL.Text);

                this.dgvPagos.Columns["valor"].Width = 45;
                this.dgvPagos.Columns["fecha"].Width = 80;
                this.dgvPagos.Columns["detalle"].Width = 265;
                this.dgvPagos.Columns["valor"].HeaderText = "Monto";
                this.dgvPagos.Columns["fecha"].HeaderText = "Fecha";
                this.dgvPagos.Columns["detalle"].HeaderText = "Comentarios";
            } 
        }

        private void btnRegistrarPagoIngresado_Click(object sender, EventArgs e)
        {
            PagoEntrante pagoEntr = new PagoEntrante();

            pagoEntr.Detalle = txtPagoDetalle.Text;
            pagoEntr.DniCuilCliente = txtDNICUIL.Text;
            pagoEntr.Fecha = dateTimePicker1.Value;
            pagoEntr.IdTramite = tramiteActual.IdTramite;
            pagoEntr.Valor = Convert.ToDecimal(txtPagoValor.Text);

            Datos_PagosEntrantesAdapter.AñadirNuevo(pagoEntr);

            
            this.txtPagoDetalle.Visible = false;
            this.txtPagoValor.Visible = false;
            this.dateTimePicker1.Visible = false;
            this.lblPagConcepto.Visible = false;
            this.lblPagMonto.Visible = false;
            this.lblFechaPago.Visible = false;
            this.btnAñadirPago.Text = "Añadir pago";

            // ActualizarListaPagos
            ActualizarListaPagos(pagoEntr.IdTramite, pagoEntr.DniCuilCliente);

            this.btnRegistrarPagoIngresado.Visible = false;
            this.btnAñadirPago.Visible = true;
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            /*
             * if (this.dgvDetallesTramite.SelectedRows.Count == 1)
            {
                Interacción.frmConfirmarElim formConfirmarElim = new WASSv1._0.Interacción.frmConfirmarElim();
                formConfirmarElim.Text = "Eliminar detalle";
                formConfirmarElim.lblMensaje.Text = "¿Esta seguro que desea eliminar el detalle seleccionado?";

                if (formConfirmarElim.ShowDialog() == DialogResult.Yes)
                {
                    DateTime fechaDetalleElim = Convert.ToDateTime(this.dgvDetallesTramite.SelectedRows[0].Cells["fechaDetalle"].Value);
                    Datos_DetallesTramiteAdapter.Quitar(tramiteActual.IdTramite, fechaDetalleElim);
                    this.dgvDetallesTramite.DataSource = Datos_DetallesTramiteAdapter.GetDetallesTramite(tramiteActual.IdTramite);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun detalle", "Eliminar detalle", MessageBoxButtons.OK);
            }
             * */
            MessageBox.Show("Funcionalidad no programada.", "Error", MessageBoxButtons.OK);
        }

        

        





    }
}
