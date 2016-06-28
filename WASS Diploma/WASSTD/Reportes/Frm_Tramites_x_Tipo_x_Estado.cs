using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WASSTD.Reportes
{
    public partial class Frm_Tramites_x_Tipo_x_Estado : Form
    {
        public Frm_Tramites_x_Tipo_x_Estado()
        {
            InitializeComponent();
        }

        private void Frm_Tramites_x_Tipo_x_Estado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Tramites_x_Estado.Tramites_x_Tipo_x_Estados' Puede moverla o quitarla según sea necesario.
            this.Tramites_x_Tipo_x_EstadosTableAdapter.Fill(this.Tramites_x_Estado.Tramites_x_Tipo_x_Estados);

            this.reportViewer1.RefreshReport();
        }
    }
}
