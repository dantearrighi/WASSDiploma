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
    public partial class FrmComitente : Form
    {
        // Declaron las variables que voy a utilizar en el formulario
        string modo;
        Controladora.cComitente cComitente;

        Modelo_Entidades.Comitente oComitente;

        // Hago públio el formulario para poder llamarlo desde otros
        public FrmComitente(string fModo, Modelo_Entidades.Comitente miComitente)
        {
            InitializeComponent();
            cComitente = Controladora.cComitente.ObtenerInstancia();

            modo = fModo;
            oComitente = miComitente;

            if (modo != "Alta")
            {
                if (modo == "Consulta")
                {
                    ArmaLista();
                }
            }
        }

        // Al cargar el formulario
        private void FrmComitente_Load(object sender, EventArgs e)
        {
            if (modo == "Alta")
            {
                return;
            }

            else
            {
                txt_razon_social.Text = oComitente.razon_social;
            }
            
        }
        
        // Al hacer click en cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        // Al hacer click en guardar
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (ValidarObligatorios() == true)
            {
                try
                {
                    oComitente.razon_social = txt_razon_social.Text;

                    if (modo == "Alta")
                    {
                        cComitente.AgregarComitente(oComitente);
                    }

                    else
                    {
                        cComitente.ModificarComitente(oComitente);
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
            if (cComitente.ValidarComitente(txt_razon_social.Text) == false)
            {
                MessageBox.Show("Debe ingresar una razón social para el comitente, dado que existe un comitente con el msimo nombre");
                return false;
            }

            if (string.IsNullOrEmpty(txt_razon_social.Text))
            {
                MessageBox.Show("Debe ingresar una descipción para el comitente");
                return false;
            }

            return true;
        }

        // Armo la lista
        private void ArmaLista()
        {
            txt_razon_social.Enabled = false;
            btn_guardar.Enabled = false;
            btn_cancelar.Text = "Cerrar";
        }
    }
}
