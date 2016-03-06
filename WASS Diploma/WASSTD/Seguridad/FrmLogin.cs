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
       
        Modelo_Entidades.Usuario oUsuario;
        
        Controladora.Seguridad.cCU_GestionarUsuarios cCu_GestionarUsuarios;
        Controladora.Seguridad.cCU_Login cCU_Login;
        Controladora.Seguridad.cAdministrarSeguridad cAdministrarSeguridad;
        
        
        
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
            
          
            cCu_GestionarUsuarios = Controladora.Seguridad.cCU_GestionarUsuarios.ObtenerInstancia();
            cCU_Login = Controladora.Seguridad.cCU_Login.ObtenerInstancia();
            cAdministrarSeguridad = Controladora.Seguridad.cAdministrarSeguridad.ObtenerInstancia();
          
        }

        // Al hacer click en cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        // Al hacer click en ingresar
        private void btn_ingresar_Click(object sender, EventArgs e)
        {          
            // Ingreso al sistema mediante un TryCatch 
            try
            {
                if (cAdministrarSeguridad.ValidarObligatoriosLogin(txt_nombredeusuario.Text, txt_contraseña.Text))
                {
                    oUsuario = cAdministrarSeguridad.Login(txt_nombredeusuario.Text,  cAdministrarSeguridad.Encriptar(txt_contraseña.Text));
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.MostrarErrorCamposObligatorios();
                }
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
        private void MostrarErrorCamposObligatorios()
        {
            if (txt_nombredeusuario.Text == "" || txt_contraseña.Text =="")
            {
                MessageBox.Show("Falta ingresar algun dato obligatorio. Verifique y vuelva a intentar", "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            
        }

    }
}
