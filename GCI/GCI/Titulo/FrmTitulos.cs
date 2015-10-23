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
    public partial class FrmTitulos : Form
    {
        // Declaro las variables que voy a utilizar en el formulario
        private static FrmTitulos instancia;

        // Declaro las controladoras a usar
        Controladora.cUsuario cUsuario;
        Controladora.cUniversidad cUniversidad;
        Controladora.cEspecialidad cEspecialidad;
        Controladora.cTitulo cTitulo;
        Controladora.cLegajo_Academico cLegajo_Academico;
        
        FrmTitulo FormTitulo;
        Modelo_Entidades.Usuario miUsuario;
        BindingSource BsTitulos;

        private FrmTitulos(Modelo_Entidades.Usuario oUsuario)
        {
            InitializeComponent();
            miUsuario = oUsuario;

            // Inicializo a las controladoras
            cUsuario = Controladora.cUsuario.ObtenerInstancia();
            cUniversidad = Controladora.cUniversidad.ObtenerInstancia();
            cEspecialidad = Controladora.cEspecialidad.ObtenerInstancia();
            cTitulo = Controladora.cTitulo.ObtenerInstancia();
            cLegajo_Academico = Controladora.cLegajo_Academico.ObtenerInstancia();

            botonera1.ArmaPerfil(miUsuario, "FrmTitulos");
        }

        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmTitulos ObtenerInstancia(Modelo_Entidades.Usuario oUsuario)
        {
            if (instancia == null)
            {
                instancia = new FrmTitulos(oUsuario);
            }

            if (instancia.IsDisposed)
            {
                instancia = new FrmTitulos(oUsuario);
            }

            return instancia;
        }

        // Cuando carga el formulario
        private void FrmTitulos_Load(object sender, EventArgs e)
        {
            Arma_Lista();
        }      
        
        // Armo la lista de la grilla de datos
        private void Arma_Lista()
        {
            // Instancio el binding source
            BsTitulos = new BindingSource();
            //Luego lo lleno con los datos de la grilla
            BsTitulos.DataSource = dgv_datos;

            cmb_universidad.DataSource = cUniversidad.ObtenerUniversidades();
            cmb_universidad.DisplayMember = "descripcion";
            cmb_universidad.SelectedItem = null;
            cmb_universidad.SelectedText = "Todos";

            cmb_especialidades.DataSource = cEspecialidad.ObtenerEspecialidades();
            cmb_especialidades.DisplayMember = "descripcion";
            cmb_especialidades.SelectedItem = null;
            cmb_especialidades.SelectedText = "Todos";

            // Limpio la grilla
            dgv_datos.DataSource = null;
            // LLeno el binding con los datos que traigo de las entidades
            BsTitulos.DataSource = cTitulo.ObtenerTitulos();
            // Asigno el binding a la grilla
            dgv_datos.DataSource = BsTitulos;

            dgv_datos.Columns[0].Visible = false;
            dgv_datos.Columns[1].HeaderText = "Descripción";
            dgv_datos.Columns[2].Visible = false;
            dgv_datos.Columns[3].Visible = false;
            dgv_datos.Columns[4].Visible = false;
            dgv_datos.Columns[5].HeaderText = "Aprobación en CIE";
            dgv_datos.Columns[6].Visible = false;
            dgv_datos.Columns[7].Visible = false;
            dgv_datos.Columns[8].Visible = false;
            dgv_datos.Columns[9].Visible = false;
            dgv_datos.Columns[10].HeaderText = "Universidad";
            dgv_datos.Columns[11].Visible = false;
        }

        // Al hacer click en "Agregar"
        private void botonera1_Click_Alta(object sender, EventArgs e)
        {
            FormTitulo = new FrmTitulo("Alta", new Modelo_Entidades.Titulo());
            DialogResult dr = FormTitulo.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Arma_Lista();
            }
        }

        // Al hacer click en "Eliminar"
        private void botonera1_Click_Baja(object sender, EventArgs e)
        {
            if (ValidarObligatorios())
            {

                try
                {
                    DialogResult Rta = MessageBox.Show("¿Confirma la eliminación del título?", "Baja", MessageBoxButtons.YesNo);
                    if (Rta == DialogResult.Yes)
                    {
                        Modelo_Entidades.Titulo oTit = (Modelo_Entidades.Titulo)dgv_datos.CurrentRow.DataBoundItem;
                        cTitulo.EliminarTitulo(oTit);
                        MessageBox.Show("El titulo fue eliminado");
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

            FormTitulo = new FrmTitulo("Consulta", (Modelo_Entidades.Titulo)dgv_datos.CurrentRow.DataBoundItem);
            DialogResult dr = FormTitulo.ShowDialog();
        }

        // Al hacer click en "Modificar"
        private void botonera1_Click_Modificacion(object sender, EventArgs e)
        {
            if (dgv_datos.CurrentRow == null)
            {
                return;
            }

            FormTitulo = new FrmTitulo("Modifica", (Modelo_Entidades.Titulo)dgv_datos.CurrentRow.DataBoundItem);
            DialogResult dr = FormTitulo.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Arma_Lista();
            }
        }

        // Al hacer click en filtrar
        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            string VarCombo_Universidad;
            string VarCombo_Especialidad;

            if (cmb_universidad.SelectedValue == null)
            {
                VarCombo_Universidad = "0";
            }

            else
            {
                VarCombo_Universidad = cmb_universidad.SelectedValue.ToString();
            }

            if (cmb_especialidades.SelectedValue == null)
            {
                VarCombo_Especialidad = "0";
            }

            else
            {
                VarCombo_Especialidad = cmb_especialidades.SelectedValue.ToString();
            }

            BsTitulos.DataSource = cTitulo.FiltrarTitulos(VarCombo_Universidad, VarCombo_Especialidad);
            dgv_datos.DataSource = BsTitulos;

            dgv_datos.Columns[0].Visible = false;
            dgv_datos.Columns[1].HeaderText = "Descripción";
            dgv_datos.Columns[2].Visible = false;
            dgv_datos.Columns[3].Visible = false;
            dgv_datos.Columns[4].Visible = false;
            dgv_datos.Columns[5].HeaderText = "Aprobación en CIE";
            dgv_datos.Columns[6].Visible = false;
            dgv_datos.Columns[7].Visible = false;
            dgv_datos.Columns[8].Visible = false;
            dgv_datos.Columns[9].Visible = false;
            dgv_datos.Columns[10].HeaderText = "Universidad";
            dgv_datos.Columns[11].Visible = false;
        }

        // Al hacer click en "Nueva Consulta"
        private void btn_nuevaconsulta_Click(object sender, EventArgs e)
        {
            Arma_Lista();
        }

        // Valido los datos
        private bool ValidarObligatorios()
        {
            if (dgv_datos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un titulo para eliminar.");
                return false;
            }

            if (cLegajo_Academico.ValidarPlanesdelTitulo((Modelo_Entidades.Titulo)dgv_datos.CurrentRow.DataBoundItem) == true)
            {
                MessageBox.Show("Debe desvincular al título de sus planes antes de eliminarlo.");
                return false;
            }

            return true;
        }
    }
}
