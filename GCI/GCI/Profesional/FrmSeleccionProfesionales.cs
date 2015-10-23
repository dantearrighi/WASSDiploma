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
    public partial class FrmSeleccionProfesionales : Form
    {
        // Declaro las variables que voy a utilizar en el formulario
        private static FrmSeleccionProfesionales instancia;

        // Declaro las controladoras a usar
        Controladora.cProfesional cProfesional;

        // Declaro los Binding source a usar
        BindingSource BsProfesionales;

        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmSeleccionProfesionales ObtenerInstancia(Modelo_Entidades.Usuario oUsuario)
        {
            if (instancia == null)
            {
                instancia = new FrmSeleccionProfesionales(oUsuario);
            }

            if (instancia.IsDisposed)
            {
                instancia = new FrmSeleccionProfesionales(oUsuario);
            }

            return instancia;
        }

        // Cuando se incializa el formulario
        public FrmSeleccionProfesionales(Modelo_Entidades.Usuario oUsuario)
        {
            InitializeComponent();
            cProfesional = Controladora.cProfesional.ObtenerInstancia();
        }

        // Cuando carga el formulario
        private void FrmSeleccionProfesionales_Load(object sender, EventArgs e)
        {
            Arma_Lista();
        }

        // Método privado para armar el datagridview
        private void Arma_Lista()
        {
            // Instancio el binding source
            BsProfesionales = new BindingSource();
            //Luego lo lleno con los datos de la grilla
            BsProfesionales.DataSource = dgv_datos;

            // Limpio la grilla
            dgv_datos.DataSource = null;
            // LLeno el binding con los datos que traigo de las entidades
            BsProfesionales.DataSource = cProfesional.ObtenerProfesionales();
            // Asigno el binding a la grilla
            dgv_datos.DataSource = BsProfesionales;
            dgv_datos.Columns[0].HeaderText = "DNI";
            dgv_datos.Columns[1].HeaderText = "Nombre y Apellido";
            dgv_datos.Columns[2].Visible = false;
            dgv_datos.Columns[3].Visible = false;
            dgv_datos.Columns[4].Visible = false;
            dgv_datos.Columns[5].Visible = false;
            dgv_datos.Columns[6].Visible = false;
            dgv_datos.Columns[7].Visible = false;
            dgv_datos.Columns[8].Visible = false;
            dgv_datos.Columns[9].Visible = false;
            dgv_datos.Columns[10].Visible = false;
            dgv_datos.Columns[11].Visible = false;
            dgv_datos.Columns[12].Visible = false;
            dgv_datos.Columns[13].Visible = false;
            dgv_datos.Columns[14].Visible = false;
            dgv_datos.Columns[15].Visible = false;
            dgv_datos.Columns[16].Visible = false;
            dgv_datos.Columns[17].Visible = false;
            dgv_datos.Columns[18].Visible = false;
            dgv_datos.Columns[19].Visible = false;
            dgv_datos.Columns[20].Visible = false;
            dgv_datos.Columns[21].Visible = false;
            dgv_datos.Columns[22].Visible = false;
        }

        // Cuando cambio el texto en el txt del profesional
        private void txt_nya_profesional_TextChanged(object sender, EventArgs e)
        {
            BsProfesionales.DataSource = cProfesional.FiltrarPorNyA(txt_nya_profesional.Text);
            dgv_datos.DataSource = BsProfesionales;
        }

        // Cuando le doy click a cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cuando le doy click a seleccionar
        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (dgv_datos.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Debe seleccionar al menos 1 profesional");
            }

            // Le mando el ok al otro formulario mediante el dialogresult
            try
            {
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message, "Selección correcta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        // Necesito devolver el usuario que consegui en el Login
        public Modelo_Entidades.Profesional ProfesionalElegido
        {
            get { return (Modelo_Entidades.Profesional)dgv_datos.CurrentRow.DataBoundItem; }
        }

    }
}
