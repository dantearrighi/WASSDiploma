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
    public partial class Frm_Tramites_x_Persona : Form
    {
        public Frm_Tramites_x_Persona()
        {
            InitializeComponent();
        }

        private void Frm_Tramites_x_Persona_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_Tramites_x_Persona.Tramites_x_Persona' Puede moverla o quitarla según sea necesario.
            this.Tramites_x_PersonaTableAdapter.Fill(this.DS_Tramites_x_Persona.Tramites_x_Persona);

            this.reportViewer1.RefreshReport();
        }


    }
}
