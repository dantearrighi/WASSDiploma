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
    public partial class FrmImprimirBoleta_Prof : Form
    {
        int mayor;
        int menor;
        string desc;
        int dni;
        int tipo_matricula;

        public FrmImprimirBoleta_Prof(int mayor_p, int menor_p, string desc_p, int dni_p, int tipo_matricula_p)
        {
            InitializeComponent();
            menor = menor_p;
            mayor = mayor_p;
            desc = desc_p;
            dni = dni_p;
            tipo_matricula = tipo_matricula_p;
        }

        private void FrmImprimirBoleta_Prof_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Boleta_Prof.Movimientos' Puede moverla o quitarla según sea necesario.
            this.MovimientosTableAdapter.Fill(this.Boleta_Prof.Movimientos, menor, mayor, desc, dni,tipo_matricula);

            this.reportViewer1.RefreshReport();
        }
    }
}
