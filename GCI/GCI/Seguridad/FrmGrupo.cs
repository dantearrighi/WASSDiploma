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
    public partial class FrmGrupo : Form
    {
        // Declaron las variables que voy a utilizar en el formulario
        string modo;
        Controladora.cGrupo cGrupo;
        Controladora.cPerfil cPerfil;
        Controladora.cFormulario cFormulario;
        Controladora.cUsuario cUsuario;
        Controladora.cPermiso cPermiso;
        Modelo_Entidades.Grupo oGrupo;
        Modelo_Entidades.Formulario oFormulario;
        bool checkearA = false;

        // Hago públio el formulario para poder llamarlo desde otros
        public FrmGrupo(string fModo, Modelo_Entidades.Grupo miGrupo)
        {
            InitializeComponent();
            cGrupo = Controladora.cGrupo.ObtenerInstancia();
            cPerfil = Controladora.cPerfil.ObtenerInstancia();
            cFormulario = Controladora.cFormulario.ObtenerInstancia();
            cUsuario = Controladora.cUsuario.ObtenerInstancia();
            cPermiso = Controladora.cPermiso.ObtenerInstancia();

            modo = fModo;
            oGrupo = miGrupo;

            if (modo != "Alta")
            {
                if (modo == "Consulta")
                {
                    txt_descripcion.Enabled = false;
                    chklstbox_usuarios.Enabled = false;
                    btn_guardar.Enabled = false;
                    btn_cancelar.Text = "Cerrar";
                }

                txt_descripcion.Text = oGrupo.descripcion;
                chklstbox_permisos.Enabled = false; 
            }

            else
            {
                this.tabs_grupos.TabPages.Remove(tab_permiso);
            }
        }

        // Al cargar el formulario
        private void FrmGrupo_Load(object sender, EventArgs e)
        {
            cmb_formularios.DataSource = cFormulario.ObtenerFormularios();         
            cmb_formularios.DisplayMember = "nombredemuestra";
            

            oFormulario = (Modelo_Entidades.Formulario)cmb_formularios.SelectedItem;

            chklstbox_usuarios.DataSource = cUsuario.ObtenerUsuarios();
            chklstbox_usuarios.DisplayMember = "nombre_apellido";

            checkearA = false;
            for (int i = 0; i < chklstbox_usuarios.Items.Count; i++)
            {
                Modelo_Entidades.Usuario oUsuario = (Modelo_Entidades.Usuario)chklstbox_usuarios.Items[i];
                foreach (Modelo_Entidades.Usuario miUsuario in oGrupo.Usuarios)
                {
                    if (oUsuario.id == miUsuario.id)
                    {
                        chklstbox_usuarios.SetItemChecked(i, true);
                    }
                }
            }

            checkearA = true;

            if (modo == "Alta")
            {
                return;
            }

            else
            {
                chklstbox_permisos.DataSource = cPerfil.ObtenerPermisos(oGrupo.id, oFormulario.descripcion);
                chklstbox_permisos.DisplayMember = "descripcion";
            }

            for (int i = 0; i < chklstbox_permisos.Items.Count; i++)
            {
                Modelo_Entidades.Permiso oPermiso = (Modelo_Entidades.Permiso)chklstbox_permisos.Items[i];
                foreach (Modelo_Entidades.Permiso miPermiso in cPerfil.ObtenerPermisos(oGrupo.id, oFormulario.descripcion))
                {
                    chklstbox_permisos.SetItemChecked(i, true);
                }
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
                    oGrupo.descripcion = txt_descripcion.Text;

                    if (modo == "Alta")
                    {
                        cGrupo.AgregarGrupo(oGrupo);
                    }

                    else
                    {
                        cGrupo.ModificarGrupo(oGrupo);
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

        // Cuando cambia el formulario
        private void cmb_formularios_ItemCheck(object sender, EventArgs e)
        {
            oFormulario = (Modelo_Entidades.Formulario)cmb_formularios.SelectedItem;
            chklstbox_permisos.DataSource = cPerfil.ObtenerPermisos(oGrupo.id, oFormulario.descripcion);
            chklstbox_permisos.DisplayMember = "descripcion";

            for (int i = 0; i < chklstbox_permisos.Items.Count; i++)
            {
                Modelo_Entidades.Permiso oPermiso = (Modelo_Entidades.Permiso)chklstbox_permisos.Items[i];
                foreach (Modelo_Entidades.Permiso miPermiso in cPerfil.ObtenerPermisos(oGrupo.id, oFormulario.descripcion))
                {
                    chklstbox_permisos.SetItemChecked(i, true);
                }
            }
        }

        // Agrega o desagrega usuarios a un grupo
        private void chklstbox_usuarios_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkearA == false) return;

            Modelo_Entidades.Usuario oUsuario = (Modelo_Entidades.Usuario)chklstbox_usuarios.SelectedItem;
            if (e.NewValue == CheckState.Checked)
            {
                oGrupo.Usuarios.Add(oUsuario);
            }
            else
            {
                oGrupo.Usuarios.Remove(oUsuario);
            }
        }

        // Valido los datos del grupo
        private bool ValidarObligatorios()
        {
            if (cGrupo.ValidarGrupo(txt_descripcion.Text) == false)
            {
                if (oGrupo.descripcion != txt_descripcion.Text)
                {
                    MessageBox.Show("Debe ingresar una descipción para el grupo ya que existe otro grupo con el mismo nombre");
                    return false;
                }
            }

            if (string.IsNullOrEmpty(txt_descripcion.Text))
            {
                MessageBox.Show("Debe ingresar una descipción para el grupo ya sea o por que no la ha ingresado o por que ya existe otro grupo con el nombre ingresado");
                return false;
            }

            return true;
        }

        // Cargo los datos en los controles correspondientes
        private void CargaDatos()
        {
            cmb_formularios.DataSource = cFormulario.ObtenerFormularios();
            chklstbox_usuarios.DataSource = cUsuario.ObtenerUsuarios();
        }
    }
}
