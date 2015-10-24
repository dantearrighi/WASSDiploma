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
    public partial class FrmSeleccionPersonas : Form
    {
        // Declaro las variables que voy a utilizar en el formulario
        private static FrmSeleccionPersonas instancia;

        // Declaro las controladoras a usar
        Controladora.cPersona cPersona;

        // Declaro los Binding source a usar
        BindingSource Bspersonas;

        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmSeleccionPersonas ObtenerInstancia(Modelo_Entidades.Usuario oUsuario)
        {
            if (instancia == null)
            {
                instancia = new FrmSeleccionPersonas(oUsuario);
            }

            if (instancia.IsDisposed)
            {
                instancia = new FrmSeleccionPersonas(oUsuario);
            }

            return instancia;
        }

        // Cuando se incializa el formulario
        public FrmSeleccionPersonas(Modelo_Entidades.Usuario oUsuario)
        {
            InitializeComponent();
            cPersona = Controladora.cPersona.ObtenerInstancia();
        }

        // Cuando carga el formulario
        private void FrmSeleccionPersonas_Load(object sender, EventArgs e)
        {
            Arma_Lista();
        }

        // Método privado para armar el datagridview
        private void Arma_Lista()
        {
            // Instancio el binding source
            Bspersonas = new BindingSource();
            //Luego lo lleno con los datos de la grilla
            Bspersonas.DataSource = dgv_datos;

            // Limpio la grilla
            dgv_datos.DataSource = null;
            // LLeno el binding con los datos que traigo de las entidades
            Bspersonas.DataSource = cPersona.ObtenerPersonas();
            // Asigno el binding a la grilla
            dgv_datos.DataSource = Bspersonas;
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

        // Cuando cambio el texto en el txt de Persona
        private void txt_nya_Persona_TextChanged(object sender, EventArgs e)
        {
            Bspersonas.DataSource = cPersona.FiltrarPorNyA(txt_nya_Persona.Text);
            dgv_datos.DataSource = Bspersonas;
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
                MessageBox.Show("Debe seleccionar al menos 1 Persona");
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
        public Modelo_Entidades.Persona PersonaElegido
        {
            get { return (Modelo_Entidades.Persona)dgv_datos.CurrentRow.DataBoundItem; }
        }

    }
}
