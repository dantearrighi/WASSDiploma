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
    public partial class FrmUsuarios : Form
    {
        // Declaro las variables que voy a utilizar en el formulario
        private static FrmUsuarios instancia;
        Controladora.cUsuario cUsuario;
        Controladora.cGrupo cGrupo;
        FrmUsuario FormUsuario;
        BindingSource BsUsuarios;

        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmUsuarios ObtenerInstancia(Modelo_Entidades.Usuario oUsuario)
        {
            if (instancia == null)
            {
                instancia = new FrmUsuarios(oUsuario);
            }

            if (instancia.IsDisposed)
            {
                instancia = new FrmUsuarios(oUsuario);
            }

            return instancia;
        }
        
        // Establezco como privado al constructor
        private FrmUsuarios(Modelo_Entidades.Usuario oUsuario)
        {
            InitializeComponent();
            cUsuario = Controladora.cUsuario.ObtenerInstancia();
            cGrupo = Controladora.cGrupo.ObtenerInstancia();
            botonera1.ArmaPerfil(oUsuario, "FrmUsuarios");
        }

        // Cuando carga el formulario
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            Arma_Lista();
        }
        
        // Armo la lista de la grilla de datos
        private void Arma_Lista()
        {
            BsUsuarios = new BindingSource();
            BsUsuarios.DataSource = dgv_datos;

            cmb_grupos.DataSource = cGrupo.ObtenerGrupos();
            cmb_grupos.DisplayMember = "descripcion";
            cmb_grupos.SelectedItem = null;

            dgv_datos.DataSource = null;
            BsUsuarios.DataSource = cUsuario.ObtenerUsuarios();
            dgv_datos.DataSource = BsUsuarios;
            dgv_datos.Columns[0].Visible = false;
            dgv_datos.Columns[1].HeaderText = "Nombre y Apellido";
            dgv_datos.Columns[2].Visible = false;
            dgv_datos.Columns[3].HeaderText = "E-Mail";
            dgv_datos.Columns[4].HeaderText = "Estado";
            dgv_datos.Columns[5].HeaderText = "Nombre de Usuario";
            dgv_datos.Columns[6].Visible= false;
        }

        // Al hacer click en "Agregar"
        private void botonera1_Click_Alta(object sender, EventArgs e)
        {
            FormUsuario = new FrmUsuario("Alta", new Modelo_Entidades.Usuario());
            DialogResult dr = FormUsuario.ShowDialog();
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
                MessageBox.Show("Debe seleccionar un usuario para eliminar.");
                return;
            }

            Modelo_Entidades.Usuario oUsua = (Modelo_Entidades.Usuario)dgv_datos.CurrentRow.DataBoundItem;

            if (oUsua.estado == false)
            {
                MessageBox.Show("El usuario ya se encuentra inactivo.");
                return;
            }

            try
            {
                DialogResult Rta = MessageBox.Show("¿Confirma el cambio de estado a inactivo del usuario?", "Baja", MessageBoxButtons.YesNo);
                if (Rta == DialogResult.Yes)
                {
                    Modelo_Entidades.Usuario oUsu = (Modelo_Entidades.Usuario)dgv_datos.CurrentRow.DataBoundItem;
                    oUsu.estado = false;
                    // Nunca se borra un usuario, por eso solo se modifica el estado.
                    cUsuario.Modificacion(oUsu);
                    MessageBox.Show("El usuario fue pasado a inactivo");
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
           
            FormUsuario = new FrmUsuario("Consulta", (Modelo_Entidades.Usuario)dgv_datos.CurrentRow.DataBoundItem);
            DialogResult dr = FormUsuario.ShowDialog();
        }

        // Al hacer click en "Modificar"
        private void botonera1_Click_Modificacion(object sender, EventArgs e)
        {
            if (dgv_datos.CurrentRow == null)
            {
                return;
            }

            FormUsuario = new FrmUsuario("Modifica", (Modelo_Entidades.Usuario)dgv_datos.CurrentRow.DataBoundItem);
            DialogResult dr = FormUsuario.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Arma_Lista();
            }
        }

        // Al hacer click en filtrar
        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            string nombreyapellido;
            string VarCombo_Grupo;
            string activa;

            if (txt_nombreapellido.Text == "")
            {
                nombreyapellido = "0";
            }

            else
            {
                nombreyapellido = txt_nombreapellido.Text;
            }

            if (cmb_grupos.SelectedValue == null)
            {
                VarCombo_Grupo = "0";
            }

            else
            {
                VarCombo_Grupo = cmb_grupos.SelectedValue.ToString();
            }

            if (chk_estado.Checked == true)
            {
                activa = "1";
            }

            else
            {
                activa = "0";
            }

            BsUsuarios.DataSource = cUsuario.FiltrarUsuarios(nombreyapellido, VarCombo_Grupo, activa);
            dgv_datos.DataSource = BsUsuarios;

            dgv_datos.Columns[0].Visible = false;
            dgv_datos.Columns[1].HeaderText = "Nombre y Apellido";
            dgv_datos.Columns[2].Visible = false;
            dgv_datos.Columns[3].HeaderText = "E-Mail";
            dgv_datos.Columns[4].HeaderText = "Estado";
            dgv_datos.Columns[5].HeaderText = "Nombre de Usuario";
            dgv_datos.Columns[6].Visible = false;
        }

        // Al hacer click en nueva consulta
        private void btn_nuevaconsulta_Click(object sender, EventArgs e)
        {
            Arma_Lista();
        }
    }
}
