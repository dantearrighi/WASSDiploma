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
    public partial class FrmListado_Prof_TM : Form
    {
        DateTime fecha_desde;
        DateTime fecha_hasta;

        public FrmListado_Prof_TM(DateTime fecha_desde_p, DateTime fecha_hasta_p)
        {
            InitializeComponent();
            fecha_desde = fecha_desde_p;
            fecha_hasta = fecha_hasta_p;
        }

        private void FrmListado_Prof_TM_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Listados_Prof_Esp.Profesionales' Puede moverla o quitarla según sea necesario.
            this.ProfesionalesTableAdapter.Fill(this.Listados_Prof_TM.Profesionales,fecha_desde,fecha_hasta);
            this.reportViewer1.RefreshReport();

        }
    }
}
