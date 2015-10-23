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
    public partial class FrmTareas : Form
    {
        // Declaro las variables que voy a utilizar en el formulario
        private static FrmTareas instancia;
        Controladora.cTarea cTarea;
        FrmTarea FormTarea;
        BindingSource BsTareas;

        Modelo_Entidades.Tarea oTarea;

        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmTareas ObtenerInstancia(Modelo_Entidades.Usuario oUsuario)
        {
            if (instancia == null)
            {
                instancia = new FrmTareas(oUsuario);
            }

            if (instancia.IsDisposed)
            {
                instancia = new FrmTareas(oUsuario);
            }

            return instancia;
        }

        // Declaro al constructor como privado
        private FrmTareas(Modelo_Entidades.Usuario oUsuario)
        {
            InitializeComponent();
            cTarea = Controladora.cTarea.ObtenerInstancia();
            botonera1.ArmaPerfil(oUsuario, "FrmTareas");
        }
        
        // Cuando carga el formulario
        private void FrmTareas_Load(object sender, EventArgs e)
        {
            Arma_Lista();
        }

        // Armo la lista de la grilla de datos
        private void Arma_Lista()
        {
            BsTareas = new BindingSource();

            // Limpio la grilla
            dgv_datos.DataSource = null;
            // LLeno el binding con los datos que traigo de las entidades
            BsTareas.DataSource = cTarea.ObtenerTareas().OrderBy(x => x.descripcion).ToList();
            // Asigno el binding a la grilla
            dgv_datos.DataSource = BsTareas;
            // Edito las columnas de la grilla
            dgv_datos.Columns[0].HeaderText = "Identificador";
            dgv_datos.Columns[1].HeaderText = "Razón Social";                            
        }

        // Al hacer click en "Agregar"
        private void botonera1_Click_Alta(object sender, EventArgs e)
        {
            FormTarea = new FrmTarea ("Alta", new Modelo_Entidades.Tarea());
            DialogResult dr = FormTarea.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Arma_Lista();
            }
        }

        // Al hacer click en "Eliminar"
        private void botonera1_Click_Baja(object sender, EventArgs e)
        {
            oTarea = (Modelo_Entidades.Tarea)dgv_datos.CurrentRow.DataBoundItem;
            try
            {
                DialogResult Rta = MessageBox.Show("¿Confirma la eliminación de la tarea?", "Baja", MessageBoxButtons.YesNo);
                if (Rta == DialogResult.Yes)
                {
                    if (oTarea.Expedientes.Count != 0)
                    {
                        MessageBox.Show("No se puede eliminar la tarea debido a que existen expedientes vinculados a ella");
                        return;
                    }

                    else
                    {
                        cTarea.EliminarTarea(oTarea);
                        MessageBox.Show("La tarea fue eliminada");
                        Arma_Lista();
                    }
                }

                else
                {
                    return;
                }
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message.ToString());
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

            FormTarea = new FrmTarea("Consulta", (Modelo_Entidades.Tarea)dgv_datos.CurrentRow.DataBoundItem);
            DialogResult dr = FormTarea.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Arma_Lista();
            }
        }

        // Al hacer click en "Modificar"
        private void botonera1_Click_Modificacion(object sender, EventArgs e)
        {
            if (dgv_datos.CurrentRow == null)
            {
                return;
            }

            FormTarea = new FrmTarea("Modifica", (Modelo_Entidades.Tarea)dgv_datos.CurrentRow.DataBoundItem);
            DialogResult dr = FormTarea.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Arma_Lista();
            }
        }

        // Al hacer click en el botón filtrar
        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            BsTareas.DataSource = cTarea.FiltrarPorDesc(txt_tarea.Text);
            dgv_datos.DataSource = BsTareas;
            // Edito las columnas de la grilla
            dgv_datos.Columns[0].HeaderText = "Identificador";
            dgv_datos.Columns[1].HeaderText = "Descripción";
        }

        private void btn_nuevaconsulta_Click(object sender, EventArgs e)
        {
            Arma_Lista();
        }
    }
}
