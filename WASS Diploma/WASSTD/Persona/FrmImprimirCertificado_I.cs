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
    public partial class FrmImprimirCertificado_I : Form
    {
        string icie_prof;

        public FrmImprimirCertificado_I(string icie)
        {
            InitializeComponent();
            icie_prof = icie;
        }

        private void FrmImprimirCertificado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Certificado_Prof.Profesionales' Puede moverla o quitarla según sea necesario.
            this.ProfesionalesTableAdapter.Fill(this.Certificado_Prof_I.Profesionales, icie_prof);

            this.reportViewer1.RefreshReport();
        }
    }
}
