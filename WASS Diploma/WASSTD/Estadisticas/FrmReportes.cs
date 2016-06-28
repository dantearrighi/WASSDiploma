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
    public partial class FrmReportes : Form
    {

        Modelo_Entidades.Usuario miUsuario;
        private static FrmReportes instancia;
        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmReportes ObtenerInstancia(Modelo_Entidades.Usuario oUsuario)
        {
            if (instancia == null)
            {
                instancia = new FrmReportes(oUsuario);
            }

            if (instancia.IsDisposed)
            {
                instancia = new FrmReportes(oUsuario);
            }

            return instancia;
        }
        public FrmReportes(Modelo_Entidades.Usuario oUsuario)
        {
            InitializeComponent();
            miUsuario = oUsuario;
        }

        private void btn_CrearReporte_Click(object sender, EventArgs e)
        {
            if (rb_TxEstado.Checked)
            {
                Frm_Tramites_x_Tipo_x_Estado formReporte = new Frm_Tramites_x_Tipo_x_Estado();
                formReporte.ShowDialog();
            }
            if (rbTxPersona.Checked)
            {
                Frm_Tramites_x_Persona formReporte = new Frm_Tramites_x_Persona();
                formReporte.ShowDialog();
            }
        }
    }
}
