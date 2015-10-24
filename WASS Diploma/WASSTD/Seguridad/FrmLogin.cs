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
    public partial class FrmLogin : Form
    {
        // Declaro las variables a utilizar en el formualario
        Controladora.cUsuario cUsuario;
        Modelo_Entidades.Usuario oUsuario;
        Controladora.cGrupo cGrupo;

        // Necesito devolver el usuario que consegui en el Login
        public Modelo_Entidades.Usuario UsuarioLogin
        {
            get { return oUsuario; }
        }
     
        // Declaro como publico al constructor
        public FrmLogin()
        {
            InitializeComponent();
            // Creo una controladora de usuario para trabajarla durante el formulario
            cUsuario = Controladora.cUsuario.ObtenerInstancia();
            cGrupo = Controladora.cGrupo.ObtenerInstancia();
        }

        // Al hacer click en cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        // Al hacer click en ingresar
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            ValidarObligatorios();

            // Ingreso al sistema mediante un TryCatch - Controladora.cEncriptacion.Encriptar(txt_contraseña.Text)
            try
            {
                oUsuario = cUsuario.Login(txt_nombredeusuario.Text, Controladora.cEncriptacion.Encriptar(txt_contraseña.Text));
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message, "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        // Cuando le doy click a resetear la clave
        private void btn_resetear_Click(object sender, EventArgs e)
        {
            FrmRecuperarClave.ObtenerInstancia().ShowDialog();
        }

        // Valido los datos obligatorios
        private void ValidarObligatorios()
        {
            if (txt_nombredeusuario.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre del usuario");
            }

            if (txt_contraseña.Text == "")
            {
                MessageBox.Show("Debe ingresar la contraseña del usuario");
            }
        }
    }
}
