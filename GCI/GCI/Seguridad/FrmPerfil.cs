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
    public partial class FrmPerfil : Form
    {
        // Declaron las variables que voy a utilizar en el formulario
        string modo;
        Controladora.cGrupo cGrupo;
        Controladora.cPerfil cPerfil;
        Controladora.cFormulario cFormulario;
        Controladora.cPermiso cPermiso;
        Modelo_Entidades.Perfil oPerfil;

        public FrmPerfil(string fModo, Modelo_Entidades.Perfil miPerfil)
        {
            InitializeComponent();
            cGrupo = Controladora.cGrupo.ObtenerInstancia();
            cPerfil = Controladora.cPerfil.ObtenerInstancia();
            cPermiso = Controladora.cPermiso.ObtenerInstancia();
            cFormulario = Controladora.cFormulario.ObtenerInstancia();

            modo = fModo;
            oPerfil = miPerfil;
            
            if (modo == "Consulta")
                {
                    btn_guardar.Enabled = false;
                    cmb_grupos.Enabled = false;
                    cmb_permisos.Enabled = false;
                    cmb_formularios.Enabled = false;
                    btn_cancelar.Text = "Cerrar";
                }

            CargaDatos();
        }

        // Al cargar el formulario, cargo todos los comboboxs
        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            if (modo != "Alta")
            {
                cmb_grupos.SelectedItem = oPerfil.Grupo;
                cmb_formularios.SelectedItem = oPerfil.Formulario;
                cmb_permisos.SelectedItem = oPerfil.Permiso;
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
                oPerfil.Grupo = (Modelo_Entidades.Grupo)cmb_grupos.SelectedItem;
                oPerfil.Formulario = (Modelo_Entidades.Formulario)cmb_formularios.SelectedItem;
                oPerfil.Permiso = (Modelo_Entidades.Permiso)cmb_permisos.SelectedItem;

                try
                {
                    if (modo == "Alta")
                    {
                        oPerfil.Grupo = (Modelo_Entidades.Grupo)cmb_grupos.SelectedItem;
                        oPerfil.Formulario = (Modelo_Entidades.Formulario)cmb_formularios.SelectedItem;
                        oPerfil.Permiso = (Modelo_Entidades.Permiso)cmb_permisos.SelectedItem;
                        cPerfil.AltaPerfil(oPerfil);
                    }

                    else
                    {
                        cPerfil.ModificarPerfil(oPerfil);
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

        // Valido los datos del perfil
        private bool ValidarObligatorios()
        {
            if (cmb_grupos.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar un grupo");
                return false;
            }

            if (cmb_formularios.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar un formulario");
                return false;
            }

            if (cmb_permisos.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar un permiso");
                return false;
            }

            if (cPerfil.ValidarPerfil((Modelo_Entidades.Grupo)cmb_grupos.SelectedItem, (Modelo_Entidades.Formulario)cmb_formularios.SelectedItem, (Modelo_Entidades.Permiso)cmb_permisos.SelectedItem) == false)
            {
                MessageBox.Show("El perfil ya existe, ingrese otros parámetros");
                return false;
            }

            return true;
        }

        // Cargo los datos en los controles correspondientes
        private void CargaDatos()
        {
            cmb_grupos.DataSource = cGrupo.ObtenerGrupos();
            cmb_grupos.DisplayMember = "descripcion";
            cmb_grupos.SelectedItem = null;
            cmb_formularios.DataSource = cFormulario.ObtenerFormularios();
            cmb_formularios.DisplayMember = "nombredemuestra";
            cmb_formularios.SelectedItem = null;
            cmb_permisos.DataSource = cPermiso.ObtenerPermisos();
            cmb_permisos.DisplayMember = "descripcion";
            cmb_permisos.SelectedItem = null;
        }
    }
}
