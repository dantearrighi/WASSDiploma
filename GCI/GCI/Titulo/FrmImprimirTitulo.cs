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
    public partial class FrmImprimirTitulo : Form
    {
        int dni_prof;
        int id_dir_prof;
        string icie_prof;

        public FrmImprimirTitulo(int dni, int id_dir, string icie)
        {
            InitializeComponent();
            dni_prof = dni;
            id_dir_prof = id_dir;
            icie_prof = icie;
        }

        private void FrmImprimirTitulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Titulos.Profesionales' Puede moverla o quitarla según sea necesario.
            this.ProfesionalesTableAdapter.Fill(this.Titulos.Profesionales,dni_prof,id_dir_prof,icie_prof);

            this.reportViewer1.RefreshReport();
        }
    }
}
