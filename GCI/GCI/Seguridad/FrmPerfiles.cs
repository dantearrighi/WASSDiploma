using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;

namespace GCI
{
    public partial class FrmPerfiles : Form
    {
        // Declaro las variables que voy a utilizar en el formulario
        private static FrmPerfiles instancia;
        Controladora.cPerfil cPerfil;
        Controladora.cGrupo cGrupo;
        Controladora.cPermiso cPermiso;
        Controladora.cFormulario cFormulario;
        FrmPerfil FormPerfil;
        Modelo_Entidades.Usuario miUsuario;
        BindingSource BsPerfiles;

        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmPerfiles ObtenerInstancia(Modelo_Entidades.Usuario oUsuario)
        {
            if (instancia == null)
            {
                instancia = new FrmPerfiles(oUsuario);
            }

            if (instancia.IsDisposed)
            {
                instancia = new FrmPerfiles(oUsuario);
            }

            return instancia;
        }

        // Declaro al constructor como privado
        private FrmPerfiles(Modelo_Entidades.Usuario oUsuario)
        {
            InitializeComponent();
            miUsuario = oUsuario;
            cPerfil = Controladora.cPerfil.ObtenerInstancia();
            cGrupo = Controladora.cGrupo.ObtenerInstancia();
            cPermiso = Controladora.cPermiso.ObtenerInstancia();
            cFormulario = Controladora.cFormulario.ObtenerInstancia();
            botonera1.ArmaPerfil(oUsuario, "FrmPerfiles");
        }

        // Cuando carga el formulario
        private void FrmPerfiles_Load(object sender, EventArgs e)
        {
            Arma_Lista();
        }

        // Armo la lista de la grilla de datos
        private void Arma_Lista()
        {
            // Instancio el binding source
            BsPerfiles = new BindingSource();
            //Luego lo lleno con los datos de la grilla
            BsPerfiles.DataSource = dgv_datos;
            
            cmb_grupos.DataSource = cGrupo.ObtenerGrupos();
            cmb_grupos.DisplayMember = "descripcion";           
            cmb_grupos.SelectedItem = null;
            cmb_grupos.SelectedText = "Todos";
            cmb_permisos.DataSource = cPermiso.ObtenerPermisos();
            cmb_permisos.DisplayMember = "descripcion";
            cmb_permisos.SelectedItem = null;
            cmb_permisos.SelectedText = "Todos";
            cmb_formularios.DataSource = cFormulario.ObtenerFormularios();
            cmb_formularios.DisplayMember = "nombredemuestra";
            cmb_formularios.SelectedItem = null;
            cmb_formularios.SelectedText = "Todos";

            // Limpio la grilla
            dgv_datos.DataSource = null;
            // LLeno el binding con los datos que traigo de las entidades
            BsPerfiles.DataSource = cPerfil.ObtenerPerfiles();
            // Asigno el binding a la grilla
            dgv_datos.DataSource = BsPerfiles;
            dgv_datos.Columns[0].HeaderText = "Identificador";
            dgv_datos.Columns[1].HeaderText = "Grupo";
            dgv_datos.Columns[2].HeaderText = "Permiso";
            dgv_datos.Columns[3].HeaderText = "Formulario";
        }

        // Al hacer click en "Agregar"
        private void botonera1_Click_Alta(object sender, EventArgs e)
        {
            FormPerfil = new FrmPerfil("Alta", new Modelo_Entidades.Perfil());
            DialogResult dr = FormPerfil.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Arma_Lista();
            }
        }

        // Al hacer click en "Eliminar"
        private void botonera1_Click_Baja(object sender, EventArgs e)
        {
            if (dgv_datos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un perfil para eliminar.");
                return;
            }

            try
            {
                DialogResult Rta = MessageBox.Show("¿Confirma la eliminación del perfil?", "Baja", MessageBoxButtons.YesNo);
                if (Rta == DialogResult.Yes)
                {
                    Modelo_Entidades.Perfil oPer = (Modelo_Entidades.Perfil)dgv_datos.CurrentRow.DataBoundItem;
                    cPerfil.BajaPerfil(oPer);
                    MessageBox.Show("El Perfil fue eliminado");
                    Arma_Lista();
                }

                else
                {
                    return;
                }
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.InnerException.ToString());
            }
        }

        // Al hacer click en "Cerrar"
        private void botonera1_Click_Cerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        // Al hacer click en "Ver detalles"
        private void botonera1_Click_Consulta(object sender, EventArgs e)
        {
            if (dgv_datos.CurrentRow == null)
            {
                return;
            }

            FormPerfil = new FrmPerfil("Consulta", (Modelo_Entidades.Perfil)dgv_datos.CurrentRow.DataBoundItem);
            DialogResult dr = FormPerfil.ShowDialog();
        }

        // Al hacer click en "Modificar"
        private void botonera1_Click_Modificacion(object sender, EventArgs e)
        {
            if (dgv_datos.CurrentRow == null)
            {
                return;
            }

            FormPerfil = new FrmPerfil("Modifica", (Modelo_Entidades.Perfil)dgv_datos.CurrentRow.DataBoundItem);
            DialogResult dr = FormPerfil.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Arma_Lista();
            }
        }

        // Al hacer click en filtrar
        private void btn_filtrar_Click_1(object sender, EventArgs e)
        {
            string VarCombo_Grupo;
            string VarCombo_Formulario;
            string VarCombo_Permiso;

            if (cmb_grupos.SelectedValue == null)
            {
                VarCombo_Grupo = "0";
            }

            else
            {
                VarCombo_Grupo = cmb_grupos.SelectedValue.ToString();
            }

            if (cmb_formularios.SelectedValue == null)
            {
                VarCombo_Formulario = "0";
            }

            else
            {
                VarCombo_Formulario = cmb_formularios.SelectedValue.ToString();
            }

            if (cmb_permisos.SelectedValue == null)
            {
                VarCombo_Permiso = "0";
            }

            else
            {
                VarCombo_Permiso = cmb_permisos.SelectedValue.ToString();
            }

            BsPerfiles.DataSource = cPerfil.FiltrarPerfiles(VarCombo_Grupo, VarCombo_Formulario, VarCombo_Permiso);
            dgv_datos.DataSource = BsPerfiles;

            dgv_datos.Columns[0].HeaderText = "Identificador";
            dgv_datos.Columns[1].HeaderText = "Descripción del Grupo";
            dgv_datos.Columns[0].HeaderText = "Identificador";
            dgv_datos.Columns[1].HeaderText = "Grupo";
            dgv_datos.Columns[2].HeaderText = "Permiso";
            dgv_datos.Columns[3].HeaderText = "Formulario";
        }

        // Establece los valores para una nueva consulta
        private void btn_nuevaconsulta_Click(object sender, EventArgs e)
        {
            Arma_Lista();
        }

        // Cuando está activo actualizo los permisos
        private void FrmPerfiles_Activated(object sender, EventArgs e)
        {
            botonera1.ArmaPerfil(miUsuario, "FrmPerfiles");
        }
    }
}
