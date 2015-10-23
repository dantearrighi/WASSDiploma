using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GCI
{
    public partial class FrmRecuperarClave : Form
    {
        // Declaración de variables del formualario
        private static FrmRecuperarClave Instancia;
        Modelo_Entidades.Usuario oUsuario;
        Controladora.cUsuario cUsuario;

        // Aplico patrón singleton al formulario
        public static FrmRecuperarClave ObtenerInstancia()
        {
            if (Instancia == null || Instancia.IsDisposed == true)
                Instancia = new FrmRecuperarClave();
            return Instancia;
        }

        // Colo el formulario como privado
        private FrmRecuperarClave()
        {
            cUsuario = Controladora.cUsuario.ObtenerInstancia();
            InitializeComponent();
        }

        // Valido los datos
        public bool ValidarDatos()
        {
            oUsuario = cUsuario.ObtenerUsuario(this.txt_nombredeusuario.Text);
            if (string.IsNullOrEmpty(this.txt_nombredeusuario.Text))
            {
                this.txt_email.Focus();
                MessageBox.Show("Primero debe escribir el nombre de usuario.", "Faltan Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(this.txt_email.Text))
            {
                this.txt_email.Focus();
                MessageBox.Show("Primero debe escribir el E-Mail del usuario.", "Faltan Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.txt_email.Text != oUsuario.email)
            {
                this.txt_email.Focus();
                MessageBox.Show("El e-mail no pertenece al usuario introducido", "Faltan Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string expresionregular = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            if (!(Regex.IsMatch(this.txt_email.Text, expresionregular))) //si el mail no concuerda con la expresion regular
            {
                this.txt_email.Focus();
                MessageBox.Show("El E-Mail ingresado tiene un formato incorrecto.", "Faltan Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // Cuando le doy click a cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cuando le doy click a aceptar
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                oUsuario = cUsuario.ObtenerUsuario(this.txt_nombredeusuario.Text);
                if (oUsuario != null)
                {
                    if (oUsuario.estado != false)
                    {
                        try
                        {
                            cUsuario.ResetearClave(oUsuario, txt_email.Text);
                            MessageBox.Show("Contraseña reseteada con éxito.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }

                        catch (System.Data.EntitySqlException ex)
                        {
                            MessageBox.Show("No se ha podido resetear la contraseña: " + ex.InnerException.Message + ".", "Error de base de datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Datos Inválidos - Usuario Inactivo.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("Datos Inválidos - Usuario Inexistente.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
    }
}
