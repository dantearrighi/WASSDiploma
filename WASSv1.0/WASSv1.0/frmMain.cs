using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data.Database;
using System.Media;


namespace WASSv1._0
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
           
        }

        
        // VARIABLES LOCALES
        ClienteAdapter Datos_ClienteAdapter = new ClienteAdapter();
        Adapter Datos_Adapter = new Adapter();
        
        #region ***   EVENTOS   ***

        private void btnClientes_Click(object sender, EventArgs e)
        {
            VerListaClientes();

        }


        private void btnListaTramites_Click(object sender, EventArgs e)
        {
            VerListaTramites();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            int x = DesktopBounds.Width;
            int y = DesktopBounds.Height;

           btnCerrarWASS.Location = new Point(x-110, y-115);
            

            // *** SET BD ***

            string rutaBD = Datos_Adapter.getCadenaConexionTXT();

            if (rutaBD == "")
            {
                MessageBox.Show("Deberá seleccionar el archivo de base de datos por unica vez.", "WASS se instaló correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                openFileDialog1.ShowDialog();
                string path = openFileDialog1.FileName;
                Datos_Adapter.escribirCadenaTXT(path);
            }
            else
            {
                Datos_Adapter.setCadenaConexion();
            }
            


        }

        private void btnCerrarWASS_Click(object sender, EventArgs e)
        {
            // Se recomienda hacer backup. Desea hacerlo ahora?
            /*
            MessageBox.Show("Acá consulta si querés hacer copia de seguridad antes de salir. En caso de hacerlo, pregunta donde ubicar los archivos de excel. Luego muestra un listado con la cantidad de registros guardados.");
            */ this.Close();
        }

        private void teclasDeAccesoRápidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interacción.frmTeclasAccRap formTeclasAcc = new WASSv1._0.Interacción.frmTeclasAccRap();
            formTeclasAcc.ShowDialog();

           
        }

      
        //TECLAS ACCESO RAPIDO
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                
                case Keys.F4:
                    VerListaClientes();
                    break;

                case Keys.F8:
                    VerListaTramites();
                    break;

                case Keys.T:
                    VerListaTramites();
                    break;

                case Keys.C:
                    VerListaClientes();
                    break;

                case Keys.F9:
                    Tramites.frmTramiteABM formTramiteABM = new Tramites.frmTramiteABM();
                    formTramiteABM.ModoForm = WASSv1._0.Tramites.frmTramiteABM.TipoForm.Alta;
                    formTramiteABM.ShowDialog();
                    break;

                case Keys.F5:
                    Clientes.frmClienteABM formClienteABM = new Clientes.frmClienteABM();
                    formClienteABM.ModoForm = WASSv1._0.Clientes.frmClienteABM.TipoForm.Alta;
                    formClienteABM.ShowDialog();
                    break;
                
                case Keys.F12:
                    Calculos.frmCalculos formCalculos = new WASSv1._0.Calculos.frmCalculos();
                    formCalculos.ShowDialog();
                    break;

                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.Tab:
                    MessageBox.Show(keyData.ToString());
                    break;

                
                    

                    
                default:

                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion


        #region *** METODOS ***
        

        //Ver Clientes
        private void VerListaClientes()
        {
            //Nueva instancia form Lista Clientes
            Clientes.frmListaClientes formListaClientes = new Clientes.frmListaClientes();

            formListaClientes.ShowDialog();
        }

        //Ver Tramites
        private static void VerListaTramites()
        {
            Tramites.frmListaTramites formListaTramites = new Tramites.frmListaTramites();

            formListaTramites.ShowDialog();
        }

        #endregion 

        private void listaDeTrámitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerListaTramites();
        }

        private void listaDeTrámitesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerListaClientes();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes.frmClienteABM formClienteABM = new Clientes.frmClienteABM();
            formClienteABM.ModoForm = WASSv1._0.Clientes.frmClienteABM.TipoForm.Alta;
            formClienteABM.ShowDialog();
        }

        private void nuevoTramiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tramites.frmTramiteABM formTramiteABM = new Tramites.frmTramiteABM();
            formTramiteABM.ModoForm = WASSv1._0.Tramites.frmTramiteABM.TipoForm.Alta;
            formTramiteABM.ShowDialog();
        }

        private void btnCalculos_Click(object sender, EventArgs e)
        {
            Calculos.frmCalculos formCalculos = new WASSv1._0.Calculos.frmCalculos();
            formCalculos.ShowDialog();
        }

       

        
    }
}
