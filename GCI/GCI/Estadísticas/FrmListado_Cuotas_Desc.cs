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
    public partial class FrmListado_Cuotas_Desc : Form
    {
        DateTime fecha_desde;
        DateTime fecha_hasta;

        public FrmListado_Cuotas_Desc(DateTime fecha_desde_p,DateTime fecha_hasta_p)
        {
            InitializeComponent();
            fecha_desde = fecha_desde_p;
            fecha_hasta = fecha_hasta_p;
        }

        private void FrmListado_Cuotas_Desc_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Listados_Cuotas_Desc.Movimientos' Puede moverla o quitarla según sea necesario.
            this.MovimientosTableAdapter.Fill(this.Listados_Cuotas_Desc.Movimientos,fecha_desde.ToShortDateString(),fecha_hasta.ToShortDateString());

            this.reportViewer1.RefreshReport();
        }
    }
}
