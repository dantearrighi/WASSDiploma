using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WASSTD.Ayuda
{
    public partial class FrmManual : Form
    {
        Modelo_Entidades.Usuario miUsuario;
        private static FrmManual instancia;


        // Establezco como privado al constructor
        private FrmManual(Modelo_Entidades.Usuario oUsuario)
        {
            InitializeComponent();
            miUsuario = oUsuario;

        }


        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmManual ObtenerInstancia(Modelo_Entidades.Usuario oUsuario)
        {
            if (instancia == null)
            {
                instancia = new FrmManual(oUsuario);
            }

            if (instancia.IsDisposed)
            {
                instancia = new FrmManual(oUsuario);
            }

            return instancia;
        }

        private void Manual_Load(object sender, EventArgs e)
        {

            pdfmanual.src = "D:\\GoogleDrive\\UAI (1)\\3º\\CD TP CAMPO\\Tutoriales\\ManualPDF.pdf";

        }
    }
}
