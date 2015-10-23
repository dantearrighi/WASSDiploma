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
    public partial class FrmImprimirRecibo : Form
    {
        int comp_id;

        public FrmImprimirRecibo(int id)
        {
            InitializeComponent();
            comp_id = id;
        }

        private void FrmImprimirRecibo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Recibos.Movimientos' Puede moverla o quitarla según sea necesario.
            this.MovimientosTableAdapter.Fill(this.Recibos.Movimientos, comp_id);

            this.reportViewer1.RefreshReport();
        }
    }
}
