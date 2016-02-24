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
    public partial class FrmCambiarClave : Form
    {
        Modelo_Entidades.Usuario oUsuario;
        Controladora.Seguridad.cCU_GestionarUsuarios cCU_GestionarUsuarios;

        Controladora.cUsuario cUsuario;

        // Cuando inicializo el formulario
        public FrmCambiarClave(Modelo_Entidades.Usuario fUsuario)
        {
            InitializeComponent();
            oUsuario = fUsuario;
            cUsuario = Controladora.cUsuario.ObtenerInstancia();
            cCU_GestionarUsuarios = Controladora.Seguridad.cCU_GestionarUsuarios.ObtenerInstancia();
        }

        // Cuando carga el formulario
        private void FrmCambiarClave_Load(object sender, EventArgs e)
        {
            lb_usuario_escrito.Text = oUsuario.nombre_apellido;
        }

        // Cuando le doy click a "Cancelar"
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cuando le doy click a "Guardar"
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cCU_GestionarUsuarios.CambiarContraseña(Controladora.cEncriptacion.Encriptar(txt_nuevacontraseña.Text), Controladora.cEncriptacion.Encriptar(txt_repetircontraseña.Text), Controladora.cEncriptacion.Encriptar(txt_contraseña_actual.Text), oUsuario))
                {
                    MessageBox.Show("La contraseña se ha modificado con éxito.");
                    this.Close();
                }
                else
                {
                    //MessageBox.Show("Las contraseñas no coinciden o la clave actual es incorrecta. Verifique y vuelva a intentarlo.");
                    this.Show();
                }
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message, "Cambiar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            
            /*if (ValidarObligatorios() == true)
            {

                try
                {
                    oUsuario.clave = Controladora.cEncriptacion.Encriptar(txt_nuevacontraseña.Text); 
                    cUsuario.Modificacion(oUsuario);
                    MessageBox.Show("La contraseña se ha modificado con éxito");
                    this.Close();
                }

                catch (Exception Exc)
                {
                    MessageBox.Show(Exc.InnerException.Message.ToString());
                }

            }

            else
            {
                this.Show();
            }*/
        
        }

        // Creo un método interno para validar los datos
        private bool ValidarObligatorios()
        {
            if (string.IsNullOrEmpty(txt_nuevacontraseña.Text) || string.IsNullOrEmpty(txt_repetircontraseña.Text) || string.IsNullOrEmpty(txt_contraseña_actual.Text) || txt_nuevacontraseña.Text != txt_repetircontraseña.Text)
            {
                MessageBox.Show("Debe ingresar una contraseña, ya que o no las ha ingresado, o no coinciden");
                return false;
            }
            else if (Controladora.cEncriptacion.Encriptar(txt_contraseña_actual.Text) != oUsuario.clave)
            {
                    MessageBox.Show("La contraseña actual es incorrecta, por favor introduscula nuevamente");
                    return false;
            }

            return true;
        }
    }
}
