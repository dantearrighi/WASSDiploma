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
    public partial class FrmTarea : Form
    {
        // Declaron las variables que voy a utilizar en el formulario
        string modo;
        Controladora.cTarea cTarea;

        Modelo_Entidades.Tarea oTarea;

        // Hago públio el formulario para poder llamarlo desde otros
        public FrmTarea(string fModo, Modelo_Entidades.Tarea miTarea)
        {
            InitializeComponent();

            cTarea = Controladora.cTarea.ObtenerInstancia();

            modo = fModo;
            oTarea = miTarea;

            if (modo != "Alta")
            {
                if (modo == "Consulta")
                {
                    ArmaLista();
                }
            }
        }

        // Armo la lista
        private void ArmaLista()
        {
            txt_descripcion.Enabled = false;
            btn_guardar.Enabled = false;
            btn_cancelar.Text = "Cerrar";
        }
        
        // Al cargar el formulario
        private void FrmTarea_Load(object sender, EventArgs e)
        {
            if (modo == "Alta")
            {
                return;
            }

            else
            {
                txt_descripcion.Text = oTarea.descripcion;
            }
        }

        // Al hacer click en cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (ValidarObligatorios() == true)
            {
                try
                {
                    oTarea.descripcion = txt_descripcion.Text;

                    if (modo == "Alta")
                    {
                        cTarea.AgregarTarea(oTarea);
                    }

                    else
                    {
                        cTarea.ModificarTarea(oTarea);
                    }

                    this.DialogResult = DialogResult.OK;
                }

                catch (Exception Exc)
                {
                    MessageBox.Show(Exc.InnerException.Message.ToString());
                }
            }

            else
            {
                this.Show();
            }
        }

        // Valido los datos del grupo
        private bool ValidarObligatorios()
        {
            if (cTarea.ValidarTarea(txt_descripcion.Text) == false)
            {
                MessageBox.Show("Debe ingresar una descipción para el grupo ya que existe otro grupo con el mismo nombre");
                return false;
            }

            if (string.IsNullOrEmpty(txt_descripcion.Text))
            {
                MessageBox.Show("Debe ingresar una descipción para la tarea");
                return false;
            }

            return true;
        }
    }
}
