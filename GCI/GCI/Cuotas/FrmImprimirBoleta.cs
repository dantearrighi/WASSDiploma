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
    public partial class FrmImprimirBoleta : Form
    {
        int menor_1;
        int mayor_1;
        string desc_1;
        int tipo_matricula_1;

        public FrmImprimirBoleta(int menor, int mayor, string desc, int tipo_matricula)
        {
            InitializeComponent();
            menor_1 = menor;
            mayor_1 = mayor;
            desc_1 = desc;
            tipo_matricula_1 = tipo_matricula;
        }

        private void FrmImprimirBoleta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Boletas.Cuotas' Puede moverla o quitarla según sea necesario.
            this.CuotasTableAdapter.Fill(this.Boletas.Cuotas, tipo_matricula_1, menor_1, mayor_1, desc_1);
            this.reportViewer1.RefreshReport();
        }
    }
}
