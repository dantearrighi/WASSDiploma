using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GCI
{
    public partial class FrmListado_Tit_Esp : Form
    {
        public FrmListado_Tit_Esp()
        {
            InitializeComponent();
        }

        private void FrmListado_Tit_Esp_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Listado_Tit_Esp.Titulos' Puede moverla o quitarla según sea necesario.
            this.TitulosTableAdapter.Fill(this.Listado_Tit_Esp.Titulos);

            this.reportViewer1.RefreshReport();
        }
    }
}
