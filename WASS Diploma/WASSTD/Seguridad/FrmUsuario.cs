using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WASSTD
{
    public partial class FrmUsuario : Form
    {
        // Declaro las variables que voy a utilizar en el formulario.
        string modo;
        Controladora.cUsuario cUsuario;
        Controladora.cGrupo cGrupo;
        Modelo_Entidades.Usuario oUsuario;
        bool checkearA;

        // Declaro como publico al constructor
        public FrmUsuario(string fModo, Modelo_Entidades.Usuario miUsuario)
        {
            InitializeComponent();
            cUsuario = Controladora.cUsuario.ObtenerInstancia();
            cGrupo = Controladora.cGrupo.ObtenerInstancia();
            modo = fModo;
            oUsuario = miUsuario;

            if (modo != "Alta")
            {
                txt_nombreapellido.Text = oUsuario.nombre_apellido;
                txt_email.Text = oUsuario.email;
                txt_nombreusuario.Text = oUsuario.usuario;
                chk_estado.Checked = oUsuario.estado;

                if (modo == "Consulta")
                {
                    txt_nombreapellido.Enabled = false;
                    txt_nombreusuario.Enabled = false;
                    txt_email.Enabled = false;
                    txt_nuevacontraseña.Enabled = false;
                    txt_repetircontraseña.Enabled = false;
                    txt_contraseña_actual.Enabled = false;
                    btn_guardar.Enabled = false;
                    btn_cancelar.Text = "Cerrar";
                    chk_estado.Enabled = false;
                    chklstbox_grupos.Enabled = false;
                }

                else
                {
                    chk_estado.Enabled = true;
                    
                }
            }

            else
            {
                txt_contraseña_actual.Enabled = false;
            }            
        }

        // Cuando cargo el formulario
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CargaDatos();
            checkearA = false;
            for (int i = 0; i < chklstbox_grupos.Items.Count; i++)
            {
                Modelo_Entidades.Grupo oGrupo = (Modelo_Entidades.Grupo)chklstbox_grupos.Items[i];
                foreach (Modelo_Entidades.Grupo miGrupo in oUsuario.Grupos.ToList())
                {
                    if (oGrupo.id == miGrupo.id)
                    {
                        chklstbox_grupos.SetItemChecked(i, true);
                    }
                }
            }

            checkearA = true;
            lb_checkusuario.Visible = false;
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
                    oUsuario.nombre_apellido = txt_nombreapellido.Text;
                    oUsuario.email = txt_email.Text;
                    oUsuario.usuario = txt_nombreusuario.Text;
                    oUsuario.estado = chk_estado.Checked;

                    if (modo == "Alta")
                    {
                       // oUsuario.clave = Controladora.cEncriptacion.Encriptar(txt_nuevacontraseña.Text);
                        oUsuario.clave = "UsuarioSinClave";
                        cUsuario.Alta(oUsuario);
                        cUsuario.ResetearClave(oUsuario, oUsuario.email);
                    }

                    else
                    {
                        oUsuario.clave = Controladora.cEncriptacion.Encriptar(txt_nuevacontraseña.Text);
                        cUsuario.Modificacion(oUsuario);
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

        // Agrego o desagrego grupos al usuario
        private void chklstbox_grupos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkearA == false) return;
            Modelo_Entidades.Grupo oGrupo = (Modelo_Entidades.Grupo)chklstbox_grupos.SelectedItem;
            if (e.NewValue == CheckState.Checked)
            {
                oUsuario.Grupos.Add(oGrupo);
            }
            else
            {
                oUsuario.Grupos.Remove(oGrupo);
            }
        }

        // Valido los datos del usuario
        private bool ValidarObligatorios()
        {
            if (string.IsNullOrEmpty(txt_nombreapellido.Text))
            {
                MessageBox.Show("Debe ingresar el nombre y apellido del usuario");
                return false;
            }

            if (string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Debe ingresar el e-mail del usuario");
                return false;
            }

            string expresionregular = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            if (!(Regex.IsMatch(this.txt_email.Text, expresionregular))) //si el mail no concuerda con la expresion regular
            {
                this.txt_email.Focus();
                MessageBox.Show("El E-Mail ingresado tiene un formato incorrecto.", "Faltan Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txt_nombreusuario.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de usuario");
                return false;
            }

            if (cUsuario.ValidarUsuario(txt_nombreusuario.Text) == false)
            {
                if (oUsuario.usuario != txt_nombreusuario.Text)
                {
                    MessageBox.Show("Debe ingresar otro usuario ya que el nombre no se encuentra disponible");
                    return false;
                }
            }
            /*
            if (string.IsNullOrEmpty(txt_nuevacontraseña.Text) || string.IsNullOrEmpty(txt_repetircontraseña.Text) || string.IsNullOrEmpty(txt_nuevacontraseña.Text))
            {
                if (modo != "Alta")
                {
                    if (string.IsNullOrEmpty(txt_nuevacontraseña.Text) && string.IsNullOrEmpty(txt_repetircontraseña.Text) && string.IsNullOrEmpty(txt_nuevacontraseña.Text))
                    {
                        return true;
                    }

                    else if (Controladora.cEncriptacion.Encriptar(txt_contraseña_actual.Text) != oUsuario.clave || string.IsNullOrEmpty(txt_contraseña_actual.Text))
                    {
                        MessageBox.Show("La contraseña actual es incorrecta, por favor introduscula nuevamente");
                        return false;
                    }
                }

                else
                {
                    // Se da solo cuando el modo es alta
                    MessageBox.Show("Debe ingresar una contraseña, ya que o no las ha ingresado, o no coinciden");
                    return false;
                }
            }

            if (modo != "Alta")
            {
                if (Controladora.cEncriptacion.Encriptar(txt_contraseña_actual.Text) != oUsuario.clave || string.IsNullOrEmpty(txt_contraseña_actual.Text) || txt_nuevacontraseña.Text != txt_repetircontraseña.Text)
                {
                    MessageBox.Show("La contraseña actual es incorrecta o las claves no coinciden, por favor introdusca los datos nuevamente");
                    return false;
                }
            }
            */

            if (this.chklstbox_grupos.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe elegir al menos un grupo para el usuario");
                return false;
            }

            return true;
        }

        // Cargo los datos en los controles correspondientes
        private void CargaDatos()
        {
            chklstbox_grupos.DataSource = null;
            chklstbox_grupos.DataSource = cGrupo.ObtenerGrupos();
            chklstbox_grupos.DisplayMember = "descripcion";
        }
    }
}
