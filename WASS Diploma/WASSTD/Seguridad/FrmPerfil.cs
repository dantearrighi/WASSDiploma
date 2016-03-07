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
    public partial class FrmPerfil : Form
    {
        // Declaron las variables que voy a utilizar en el formulario
        string modo;
  
        
        Controladora.cFormulario cFormulario;
        Controladora.cPermiso cPermiso;
        Modelo_Entidades.Perfil oPerfil;
        Controladora.Seguridad.cCU_GestionarGrupos cCU_GestionarGrupos;

        Controladora.Seguridad.cCU_GestionarPerfiles cCU_GestionarPerfiles;

        public FrmPerfil(string fModo, Modelo_Entidades.Perfil miPerfil)
        {
            InitializeComponent();
          
           
            cPermiso = Controladora.cPermiso.ObtenerInstancia();
            cFormulario = Controladora.cFormulario.ObtenerInstancia();
            cCU_GestionarPerfiles = Controladora.Seguridad.cCU_GestionarPerfiles.ObtenerInstancia();
            cCU_GestionarGrupos = Controladora.Seguridad.cCU_GestionarGrupos.ObtenerInstancia();

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
                

                try
                {
                    if (modo == "Alta")
                    {
                        oPerfil = new Modelo_Entidades.Perfil();
                        oPerfil.Grupo = (Modelo_Entidades.Grupo)cmb_grupos.SelectedItem;
                        oPerfil.Formulario = (Modelo_Entidades.Formulario)cmb_formularios.SelectedItem;
                        oPerfil.Permiso = (Modelo_Entidades.Permiso)cmb_permisos.SelectedItem;
                        cCU_GestionarPerfiles.AltaPerfil(oPerfil);
                    }

                    else
                    {
                        Modelo_Entidades.Perfil oPerfilModificado = new Modelo_Entidades.Perfil();
                        oPerfilModificado.Grupo = (Modelo_Entidades.Grupo)cmb_grupos.SelectedItem;
                        oPerfilModificado.Formulario = (Modelo_Entidades.Formulario)cmb_formularios.SelectedItem;
                        oPerfilModificado.Permiso = (Modelo_Entidades.Permiso)cmb_permisos.SelectedItem;

                        cCU_GestionarPerfiles.ModificarPerfil(oPerfil,oPerfilModificado);
                    }

                    this.DialogResult = DialogResult.OK;
                }

                catch (Exception Exc)
                {
                    MessageBox.Show(Exc.Message.ToString(), "Gestionar Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            //Esta validacion corresponde al CU Alta Perfil y al CU Modificar Perfil. Se deja implementado en CU Gestionar Perfiles antes de Alta y de Modificacion
           /*   if (cCU_GestionarPerfiles.ValidarPerfil((Modelo_Entidades.Grupo)cmb_grupos.SelectedItem, (Modelo_Entidades.Formulario)cmb_formularios.SelectedItem, (Modelo_Entidades.Permiso)cmb_permisos.SelectedItem) == false)
            {
                MessageBox.Show("El perfil ya existe, ingrese otros parámetros","Gestionar perfiles", MessageBoxButtons.OK,MessageBoxIcon.Warning); 
                return false;
            }*/

            return true;
        }

        // Cargo los datos en los controles correspondientes
        private void CargaDatos()
        {
            cmb_grupos.DataSource = cCU_GestionarGrupos.ObtenerGrupos();
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
