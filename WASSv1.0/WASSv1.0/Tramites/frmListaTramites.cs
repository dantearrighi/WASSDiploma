using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data.Database;
using System.Data.OleDb;

namespace WASSv1._0.Tramites
{
    public partial class frmListaTramites : Form
    {
        public frmListaTramites()
        {
            InitializeComponent();
            ActualizarListado();

            this.dgvListaTramites.DefaultCellStyle.BackColor = Color.FloralWhite;
       //   this.dgvListaTramites.Columns["idTramite"].HeaderText = "ID";
            this.dgvListaTramites.Columns["idTramite"].Visible= false;
       //   this.dgvListaTramites.Columns["idTramite"].DefaultCellStyle.BackColor = Color.Beige;//kaahki , lavender, lavenderblush, lemmonchiffon, lightskyblue, lightsteelblue mintcream
            this.dgvListaTramites.Columns["Nombre y Apellido"].Width = 200;
            this.dgvListaTramites.Columns["Nombre y Apellido"].DefaultCellStyle.BackColor = Color.Beige;
            this.dgvListaTramites.Columns["dniCuilCli"].HeaderText = "DNI - CUIL";
            this.dgvListaTramites.Columns["dniCuilCli"].DefaultCellStyle.BackColor = Color.Beige;
            // Columna Tipo Tramite oculta
            this.dgvListaTramites.Columns["tipoTramite"].HeaderText = "Tipo de Tramite";
            this.dgvListaTramites.Columns["tipoTramite"].Width = 110;
            this.dgvListaTramites.Columns["tipoTramite"].Visible = false;

            this.dgvListaTramites.Columns["enviadoPor"].HeaderText = "Enviado por";
            this.dgvListaTramites.Columns["derivadoA"].HeaderText = "Derivado a";
            this.dgvListaTramites.Columns["fechaDetalle"].HeaderText = "Ultimo Movimiento";
            this.dgvListaTramites.Columns["fechaDetalle"].Width = 150;
            this.dgvListaTramites.Columns["descripcion"].HeaderText = "Descripción";
            this.dgvListaTramites.Columns["descripcion"].Width= 500;
            this.btnExcel.Visible = true;

           btnImportar.Visible = false;
           btnImportarDETALLESTramites.Visible = false;
           btnExportar.Visible = false;
            
            
               

            //this.dgvListaTramites.Columns["enviadoPor"].Visible = false;
            //this.dgvListaTramites.Columns["derivadoA"].Visible = false;
            
        }

        #region ///***///***///***/// V A R I A B L E S \\\***\\\***\\\***\\\

        
        // CAPADATOS TRAMITE ADAPTER
        TramiteAdapter Datos_TramiteAdapter = new TramiteAdapter();
        Detalles_TramiteAdapter Datos_DetalleTramiteAdapter = new Detalles_TramiteAdapter();
        ClienteAdapter Datos_ClienteAdapter = new ClienteAdapter();


        #endregion


        
        #region ///***///***///***///  E V E N T O S \\\***\\\***\\\***

        // CLICK Nuevo Tramite
        private void btnNuevoTramite_Click(object sender, EventArgs e)
        {
            

           

            // Cargar Datos de los COMBO BOX DERIVADOA, ENVIADOPOR, TIPOTRAMITE

         //   formTramiteNuevo.cbxDerivadoA.DataSource = Datos_TramiteAdapter.GetAll();
        //    formTramiteNuevo.cbxDerivadoA.ValueMember = "derivadoA";
       //     formTramiteNuevo.cbxDerivadoA.SelectedItem = null;

            //Carga el AutoCompletar del comboBox
            // formTramiteNuevo.cbxDerivadoA.AutoCompleteCustomSource = // ProveedorAdapter.GetListadoNombres();




            //ALTA TRAMITE
            frmTramiteABM formTramiteNuevo = new frmTramiteABM();
            formTramiteNuevo.ShowDialog();
            ActualizarListado();

        }

        // CLICK Importar
        private void btnImportar_Click(object sender, EventArgs e)
        {
            ImportarTramites();
        }

        // CLICK Importar Detalles
        private void btnImportarDETALLESTramites_Click(object sender, EventArgs e)
        {
            ImportarDetallesTramites();
            ActualizarListado();
        }

        // Filtro de busqueda
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (rbApellido.Checked)
            {
                this.dgvListaTramites.DataSource = Datos_TramiteAdapter.GetAllTramitesListadoPorAPELLIDO(txtFiltro.Text);
            }
            else if (rbDni.Checked)
            {
                this.dgvListaTramites.DataSource = Datos_TramiteAdapter.GetAllTramitesListadoPorDNI(txtFiltro.Text);
            }
        }

        // CLICK Modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            VerModificarTramite();
            this.txtFiltro.Text = "";
            ActualizarListado();

        }

        // CLICK Doble en la grilla
        private void dgvListaTramites_DoubleClick(object sender, EventArgs e)
        {
            VerModificarTramite();
            this.txtFiltro.Text = "";
            ActualizarListado();
        }

        // CLICK BTN EXCEL
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (btnExcel.Visible)
            {
                btnExcel.Visible = false;

                btnImportarDETALLESTramites.Visible = true;
                btnImportar.Visible = true;
                btnExportar.Visible = true;
            }
        }
        
        
        #endregion


        #region ///***///***///***/// M E T O D O S  \\\***\\\***\\\***\\\

        //ACTUALIZAR LISTADO DE TRAMITES
        private void ActualizarListado()
        {
            dgvListaTramites.DataSource = Datos_TramiteAdapter.GetAllTramitesListado();
            dgvListaTramites.Columns["idTramite"].Visible = true;
            dgvListaTramites.Columns["enviadoPor"].Width = 150;
            dgvListaTramites.Columns["derivadoA"].Width = 150;
            this.lblCantTramites.Text = dgvListaTramites.Rows.Count.ToString() + " Trámites";
        }
        
        //IMPORTAR TRAMITES
        private void ImportarTramites()
        {

            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {

                string connectionString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", OpenFileDialog.FileName);
                string sqlExcel = String.Format("select * from [{0}$]", "Hoja1");

                DataSet ExDataSet = new DataSet();
                //
                OleDbConnection ExConexion = new OleDbConnection(connectionString);
                OleDbCommand OleDbCommand = new OleDbCommand(sqlExcel, ExConexion);
                OleDbDataAdapter ExDataAdapter = new OleDbDataAdapter(OleDbCommand);
                //
                ExDataAdapter.Fill(ExDataSet);

                Entidades.Tramite tramiteDeExcel = new Entidades.Tramite();

                for (int i = 0; i < ExDataSet.Tables[0].Rows.Count; i++)
                {


                    tramiteDeExcel.IdTramite = Convert.ToInt32(ExDataSet.Tables[0].Rows[i].Field<Double>(0));
                    tramiteDeExcel.DniCuilCliente = ExDataSet.Tables[0].Rows[i].Field<Double>(1).ToString();
                    tramiteDeExcel.TipoTramite = ExDataSet.Tables[0].Rows[i].Field<String>(2);
                    tramiteDeExcel.EnviadoPor = ExDataSet.Tables[0].Rows[i].Field<String>(3);
                    tramiteDeExcel.DerivadoA = ExDataSet.Tables[0].Rows[i].Field<String>(4);


                   Datos_TramiteAdapter.AñadirNuevo(tramiteDeExcel);
                }

            }
            ActualizarListado();
        }

        //IMPORTAR DETALLES TRAMITES
        private void ImportarDetallesTramites()
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {

                string connectionString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", OpenFileDialog.FileName);
                string sqlExcel = String.Format("select * from [{0}$]", "Hoja1");

                DataSet ExDataSet = new DataSet();
                //
                OleDbConnection ExConexion = new OleDbConnection(connectionString);
                OleDbCommand OleDbCommand = new OleDbCommand(sqlExcel, ExConexion);
                OleDbDataAdapter ExDataAdapter = new OleDbDataAdapter(OleDbCommand);
                //
                ExDataAdapter.Fill(ExDataSet);

                Entidades.Detalles_Tramite Detalles_tramiteDeExcel = new Entidades.Detalles_Tramite();

                for (int i = 0; i < ExDataSet.Tables[0].Rows.Count; i++)
                {


                    Detalles_tramiteDeExcel.idTramite = Convert.ToInt32(ExDataSet.Tables[0].Rows[i].Field<Double>(0));
                    Detalles_tramiteDeExcel.FechaDetalle = ExDataSet.Tables[0].Rows[i].Field<DateTime>(1);
                  //  Detalles_tramiteDeExcel.Estado = ExDataSet.Tables[0].Rows[i].Field<String>(2);
                    Detalles_tramiteDeExcel.Descripcion= ExDataSet.Tables[0].Rows[i].Field<String>(3);
                    


                    Datos_DetalleTramiteAdapter.AñadirNuevo(Detalles_tramiteDeExcel);
                }

            }
            ActualizarListado();
        }

        //MODIFICAR TRAMITE
        private void VerModificarTramite()
        {
            Entidades.Tramite tramToEdit = new Entidades.Tramite();
            

            // Obtengo, desde la grilla, los datos del tramite a editar.

            tramToEdit.IdTramite = Convert.ToInt32(dgvListaTramites.SelectedRows[0].Cells["idTramite"].Value.ToString());
            tramToEdit.DniCuilCliente = dgvListaTramites.SelectedRows[0].Cells["dniCuilCli"].Value.ToString();
            tramToEdit.TipoTramite = dgvListaTramites.SelectedRows[0].Cells["tipoTramite"].Value.ToString();
            tramToEdit.EnviadoPor = dgvListaTramites.SelectedRows[0].Cells["enviadoPor"].Value.ToString();
            tramToEdit.DerivadoA = dgvListaTramites.SelectedRows[0].Cells["derivadoA"].Value.ToString();


            // del Tramite al FORM ABM/MODIFICAR

            frmTramiteABM formTramiteModificar = new frmTramiteABM(tramToEdit);
        //  formTramiteModificar.txtIDTramite.Text = tramToEdit.IdTramite.ToString();
            formTramiteModificar.txtDNICUIL.Text = tramToEdit.DniCuilCliente.ToString();
            formTramiteModificar.txtTipoTramite.Text = tramToEdit.TipoTramite.ToString();
            formTramiteModificar.txtEnviadoPor.Text = tramToEdit.EnviadoPor.ToString();
            formTramiteModificar.txtDerivadoA.Text = tramToEdit.DerivadoA.ToString();

            // del Cliente al FORM
            Entidades.Cliente cliTramToEdit = Datos_ClienteAdapter.GetOne(tramToEdit.DniCuilCliente.ToString());
            formTramiteModificar.txtNombre.Text = cliTramToEdit.Nombre.ToString();
            formTramiteModificar.txtApellido.Text = cliTramToEdit.Apellido.ToString();

            // de Detalles_Tramites al FORM
            formTramiteModificar.txtDetalles.Text = dgvListaTramites.SelectedRows[0].Cells["descripcion"].Value.ToString();
            formTramiteModificar.txtUltimoMovFecha.Text = dgvListaTramites.SelectedRows[0].Cells["fechaDetalle"].Value.ToString();
            formTramiteModificar.dgvDetallesTramite.DataSource = Datos_DetalleTramiteAdapter.GetDetallesTramite(tramToEdit.IdTramite);

            // Columnas de la grilla
            formTramiteModificar.dgvDetallesTramite.Columns["fechaDetalle"].HeaderText = "Desde";
            formTramiteModificar.dgvDetallesTramite.Columns["fechaDetalle"].Width = 150;

            formTramiteModificar.dgvDetallesTramite.Columns["descripcion"].HeaderText = "Descripcion";
            formTramiteModificar.dgvDetallesTramite.Columns["descripcion"].Width = 480;

            formTramiteModificar.ShowDialog();
        }

        //TECLAS RAPIDAS
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


        #endregion

        private void frmListaTramites_Load(object sender, EventArgs e)
        {
            /* this.btnExcel.Hide();
            this.btnExportar.Hide();
            this.btnImportar.Hide();
            this.btnImportarDETALLESTramites.Hide();
            */
          

        }

       

    
    }
}
