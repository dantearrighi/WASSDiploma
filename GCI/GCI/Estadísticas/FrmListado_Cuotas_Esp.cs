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
    public partial class FrmListado_Cuotas_Esp : Form
    {
        DateTime fecha_desde;
        DateTime fecha_hasta;

        public FrmListado_Cuotas_Esp(DateTime fecha_desde_p, DateTime fecha_hasta_p)
        {
            InitializeComponent();
            fecha_desde = fecha_desde_p;
            fecha_hasta = fecha_hasta_p;
        }

        private void FrmListado_Cuotas_Esp_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Listado_Cuotas_Esp.Movimientos' Puede moverla o quitarla según sea necesario.
            this.MovimientosTableAdapter.Fill(this.Listado_Cuotas_Esp.Movimientos,fecha_desde.ToShortDateString(),fecha_hasta.ToShortDateString());
            this.reportViewer1.RefreshReport();
        }
    }
}
