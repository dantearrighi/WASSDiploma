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

using Microsoft.Office.Interop;

namespace WASSv1._0.Clientes
{
    public partial class frmListaClientes : Form
    {
        public frmListaClientes()
        {
            InitializeComponent();

            this.btnImportar.Visible = false;
            this.btnExportar.Visible = false;

            //Propiedades de la Grilla y Columnas
            this.dgvListadoClientes.DataSource = Datos_ClienteAdapter.GetAllClientes();
            this.dgvListadoClientes.Columns["DNI - CUIL"].Width = 125;
            this.dgvListadoClientes.Columns["Apellido y Nombre"].Width = 220;
            this.dgvListadoClientes.Columns["Email"].Width = 150;
        }

        //VARIABLES - CAPA DATOS

        ClienteAdapter Datos_ClienteAdapter = new ClienteAdapter();
        public Entidades.Cliente cliSelect = new Entidades.Cliente();

        
        #region *******************   EVENTOS   *************************
        
        // CLICK Boton Cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // CLICK Boton Importar
        private void btnImportar_Click(object sender, EventArgs e)
        {
            ImportarClientes();

           
        }


        // Cambia Texto FILTRO
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = Convert.ToString(txtFiltro.Text);

            if (rbApellido.Checked)
            {

                dgvListadoClientes.DataSource = Datos_ClienteAdapter.GetAllClientesApe(filtro);
            }

            else if (rbDNICUIL.Checked)
            {
                dgvListadoClientes.DataSource = Datos_ClienteAdapter.GetAllClientesDni(filtro);
            }

        }

        // Click Boton Modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarCliente();
            
        }

        // Doble Click Grilla
        private void dgvListadoClientes_DoubleClick(object sender, EventArgs e)
        {
            if (btnSeleccionarCli.Visible)
            {
                SeleccionarCliente();
            }
            else
            {
                ModificarCliente();
            }
        }

        // Click Boton Añadir Nuevo
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            AñadirCliente();
            
        }

        // Click Eliminar
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            EliminarCliente();

        }

        // Click EXCEL
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (btnImportar.Visible)
            {
                this.btnExportar.Visible = false;
                this.btnImportar.Visible = false;
               
            }
            else
            {
                this.btnExportar.Visible = true;
                this.btnImportar.Visible = true;
               
            }
        }

        
        // TECLAS RAPIDAS
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {

                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.Enter:

                    if (this.btnSeleccionarCli.Visible)
                    {
                        SeleccionarCliente();
                    }
                    break;

                


                default:

                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //CLICK SELECCIONAR CLIENTE
         private void btnSeleccionarCli_Click(object sender, EventArgs e)
        {
           SeleccionarCliente();
        }
    
        
        // CLICK ELIMINAR
        private void btnElimClie_Click(object sender, EventArgs e)
        {
            Interacción.frmConfirmarElim formConfirmar = new WASSv1._0.Interacción.frmConfirmarElim();
           string apellidoynombre =  dgvListadoClientes.SelectedRows[0].Cells["Apellido y Nombre"].Value.ToString();
           
           formConfirmar.Text = "Eliminar Cliente";
           formConfirmar.lblMensaje.Text = "Se eliminará a " + apellidoynombre.ToUpper() +" de la lista de Clientes. Para confirmar haga click en Eliminar.";
            if (formConfirmar.ShowDialog() == DialogResult.Yes)
            {
                EliminarCliente();
            }
        }
        
        
        
        #endregion

        
        // *****************************************************************
       
 
        private void ImportarClientes()
        {

            OpenFileDialog OpenFileDialog = new OpenFileDialog();


            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {

                /*
                                //En DataSource especificas la ruta del archivo  @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", OpenFileDialog.FileName);
                            string CadenaConexion = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", OpenFileDialog.FileName); //@"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=C:\Clientes2.xls;" + @"Extended Properties=" + '"' + "Excel 8.0;HDR=YES" + '"'; 
 

                    OleDbConnection con= new OleDbConnection(CadenaConexion); 

                    //Usuario y dirección son columnas en la hoja de excel 
                    string strSQL="SELECT dni, nombre, apellido, email FROM [hoja1$]"; 

                    OleDbDataAdapter da=new OleDbDataAdapter(strSQL,con); 

                    DataSet ds=new DataSet();

                    da.Fill(ds);

    
                
                                for(int i = 0; i< ds.Tables[0].Rows.Count; i++)
                                {
                                        Entidades.Cliente clienteDeExcel = new Entidades.Cliente();
                                        clienteDeExcel.DniCuil = ds.Tables[0].Rows[i].Field<Double>(0).ToString();
                                    clienteDeExcel.Nombre = ds.Tables[0].Rows[i].Field<String>(1);
                                    clienteDeExcel.Apellido = ds.Tables[0].Rows[i].Field<String>(2);
                                    clienteDeExcel.Email = ds.Tables[0].Rows[i].Field<String>(3);

                                    Datos_ClienteAdapter.AñadirNuevo(clienteDeExcel);
                                }

                                */




                                                      
                string connectionString = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", OpenFileDialog.FileName);
                string sqlExcel = String.Format("select * from [{0}$]", "Hoja1");

                DataSet ExDataSet = new DataSet();
                //
                OleDbConnection ExConexion = new OleDbConnection(connectionString);
                OleDbCommand OleDbCommand = new OleDbCommand(sqlExcel, ExConexion);
                OleDbDataAdapter ExDataAdapter = new OleDbDataAdapter(OleDbCommand);
                //
                ExDataAdapter.Fill(ExDataSet);

                Entidades.Cliente clienteDeExcel = new Entidades.Cliente();

                for (int i = 0; i < ExDataSet.Tables[0].Rows.Count; i++)
                {
                    

                    clienteDeExcel.DniCuil = ExDataSet.Tables[0].Rows[i].Field<String>(0).ToString();
                    clienteDeExcel.Nombre = ExDataSet.Tables[0].Rows[i].Field<String>(1);
                    clienteDeExcel.Apellido = ExDataSet.Tables[0].Rows[i].Field<String>(2);
                    clienteDeExcel.Email = ExDataSet.Tables[0].Rows[i].Field<String>(3);
                    clienteDeExcel.Tel1 = ExDataSet.Tables[0].Rows[i].Field<Double>(4).ToString();
                    clienteDeExcel.Tel2 = ExDataSet.Tables[0].Rows[i].Field<Double>(5).ToString();

                    Datos_ClienteAdapter.AñadirNuevo(clienteDeExcel);
                }

            }
            ActualizarListado();
        }

        private void ActualizarListado()
        {
            dgvListadoClientes.DataSource = Datos_ClienteAdapter.GetAllClientes();
        }

        private void ModificarCliente()
        {
            string dniClienSeleccionado = dgvListadoClientes.SelectedRows[0].Cells["DNI - CUIL"].Value.ToString(); 
            
            Entidades.Cliente CliToEdit = Datos_ClienteAdapter.GetOne(dniClienSeleccionado);
            
            frmClienteABM formModificarCliente = new frmClienteABM(CliToEdit);

            // DNI de la BD que se va a reemplazar
            formModificarCliente.dniActual = CliToEdit.DniCuil;

            formModificarCliente.ShowDialog();

            ActualizarListado();
        }

        //ALTA CLIENTE
        private void AñadirCliente()
        {
            Clientes.frmClienteABM formAltaCliente = new frmClienteABM();

            

            formAltaCliente.ShowDialog();

            ActualizarListado();

        }

        private void EliminarCliente()
        {
            string dnielim = dgvListadoClientes.SelectedRows[0].Cells["DNI - CUIL"].Value.ToString();

            Datos_ClienteAdapter.Quitar(dnielim);

            ActualizarListado();
        }

        public void SeleccionarCliente()
        {
            string dniClienSelect = dgvListadoClientes.SelectedRows[0].Cells["DNI - CUIL"].Value.ToString();
            cliSelect = Datos_ClienteAdapter.GetOne(dniClienSelect);

            this.Close();
                      
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            this.exportarClientes();

        }

        
        // M E T O D O S **************************************


        #region Exportar

        // Exportar Clientes 
        public void exportarClientes()
        {
            Clientes.frmListaClientes frmListaClientes = new frmListaClientes();
          

            frmListaClientes.Show();
            frmListaClientes.Hide();

            Microsoft.Office.Interop.Excel.ApplicationClass ExcelAppCli = new Microsoft.Office.Interop.Excel.ApplicationClass();
            ExcelAppCli.Application.Workbooks.Add(Type.Missing);

            SaveFileDialog drCli = new SaveFileDialog();
            drCli.FileName = "Clientes " + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
            drCli.Filter = "Excel files (*.xls)|*.xls";
            drCli.Title = "CLIENTES";


            if (drCli.ShowDialog() == DialogResult.OK)
            {
                for (int i = 1; i < frmListaClientes.dgvListadoClientes.Columns.Count + 1; i++)
                {
                    ExcelAppCli.Cells[1, i] = frmListaClientes.dgvListadoClientes.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < frmListaClientes.dgvListadoClientes.Rows.Count; i++)
                {
                    for (int j = 0; j < frmListaClientes.dgvListadoClientes.Columns.Count; j++)
                    {
                        ExcelAppCli.Cells[i + 2, j + 1] = frmListaClientes.dgvListadoClientes.Rows[i].Cells[j].Value.ToString();
                    }
                }


                ExcelAppCli.ActiveWorkbook.SaveCopyAs(drCli.FileName);
                ExcelAppCli.ActiveWorkbook.Saved = true;
                ExcelAppCli.Quit();
            }
            int cantCli = frmListaClientes.dgvListadoClientes.Rows.Count;
        }







        /*
        private void btnToExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
            ExcelApp.Application.Workbooks.Add(Type.Missing);

            SaveFileDialog dr = new SaveFileDialog();
            dr.FileName = "";
            dr.Filter = "Excel files (*.xls)|*.xls";
            dr.ShowDialog();


            for (int i = 1; i < dataGridViewInventario.Columns.Count + 1; i++)
            {
                ExcelApp.Cells[1, i] = dataGridViewInventario.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridViewInventario.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewInventario.Columns.Count; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = dataGridViewInventario.Rows[i].Cells[j].Value.ToString();
                }
            }


            ExcelApp.ActiveWorkbook.SaveCopyAs(dr.FileName);
            ExcelApp.ActiveWorkbook.Saved = true;
            ExcelApp.Quit();

        }
        */ 

        #endregion     

       

        
       

        

        
    }
}
