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
    public partial class FrmGrupos : Form
    {
        // Declaro las variables que voy a utilizar en el formulario
        private static FrmGrupos instancia;
        Controladora.cGrupo cGrupo;
        FrmGrupo FormGrupo;
        BindingSource BsGrupos;

        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmGrupos ObtenerInstancia(Modelo_Entidades.Usuario oUsuario)
        {
            if (instancia == null)
            {
                instancia = new FrmGrupos(oUsuario);
            }

            if (instancia.IsDisposed)
            {
                instancia = new FrmGrupos(oUsuario);
            }

            return instancia;
        }

        // Declaro al constructor como privado
        private FrmGrupos(Modelo_Entidades.Usuario oUsuario)
        {
            InitializeComponent();
            cGrupo = Controladora.cGrupo.ObtenerInstancia();
            botonera1.ArmaPerfil(oUsuario, "FrmGrupos");
        }

        // Cuando carga el formulario
        private void FrmGrupos_Load(object sender, EventArgs e)
        {
            Arma_Lista();
        }

        // Armo la lista de la grilla de datos
        private void Arma_Lista()
        {
            BsGrupos = new BindingSource();
            BsGrupos.DataSource = dgv_datos;

            // Limpio la grilla
            dgv_datos.DataSource = null;
            // LLeno el binding con los datos que traigo de las entidades
            BsGrupos.DataSource = cGrupo.ObtenerGrupos();
            // Asigno el binding a la grilla
            dgv_datos.DataSource = BsGrupos;
            // Edito las columnas de la grilla
            dgv_datos.Columns[0].HeaderText = "Identificador";
            dgv_datos.Columns[1].HeaderText = "Descripción del Grupo";
            dgv_datos.Columns[2].Visible = false;
            dgv_datos.Columns[3].Visible = false;
        }

        // Al hacer click en "Agregar"
        private void botonera1_Click_Alta(object sender, EventArgs e)
        {
            FormGrupo = new FrmGrupo("Alta", new Modelo_Entidades.Grupo());
            DialogResult dr = FormGrupo.ShowDialog();
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
                MessageBox.Show("Debe seleccionar un grupo para eliminar.");
                return;
            }

            try
            {
                DialogResult Rta = MessageBox.Show("¿Confirma la eliminación del grupo?", "Baja", MessageBoxButtons.YesNo);
                if (Rta == DialogResult.Yes)
                {
                    Modelo_Entidades.Grupo oGrup = (Modelo_Entidades.Grupo)dgv_datos.CurrentRow.DataBoundItem;
                    if (cGrupo.ValidarMiembrosGrupo(oGrup) == false)
                    {
                        MessageBox.Show("Para eliminar el grupo, primero debe desasociar a todos sus miembros y eliminar todos sus perfiles");
                        return;
                    }
                    cGrupo.EliminarGrupo(oGrup);
                    MessageBox.Show("El Grupo fue eliminado");
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

            FormGrupo = new FrmGrupo("Consulta", (Modelo_Entidades.Grupo)dgv_datos.CurrentRow.DataBoundItem);
            DialogResult dr = FormGrupo.ShowDialog();
        }

        // Al hacer click en "Modificar"
        private void botonera1_Click_Modificacion(object sender, EventArgs e)
        {
            if (dgv_datos.CurrentRow == null)
            {
                return;
            }

            FormGrupo = new FrmGrupo("Modifica", (Modelo_Entidades.Grupo)dgv_datos.CurrentRow.DataBoundItem);
            DialogResult dr = FormGrupo.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Arma_Lista();
            }
        }

        // Al hacer click en el botón filtrar
        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            BsGrupos.DataSource = cGrupo.FiltrarGrupos(txt_grupo.Text);
            dgv_datos.DataSource = BsGrupos;
            dgv_datos.Columns[0].HeaderText = "Identificador";
            dgv_datos.Columns[1].HeaderText = "Descripción del Grupo";
            dgv_datos.Columns[2].Visible = false;
            dgv_datos.Columns[3].Visible = false;
        }
    }
}
