using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WASSTD
{
    public partial class FrmListado_Tit_Uni : Form
    {
        public FrmListado_Tit_Uni()
        {
            InitializeComponent();
        }

        private void FrmListado_Tit_Uni_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Listados_Tit_Uni.Titulos' Puede moverla o quitarla según sea necesario.
            this.TitulosTableAdapter.Fill(this.Listados_Tit_Uni.Titulos);

            this.reportViewer1.RefreshReport();
        }
    }
}
