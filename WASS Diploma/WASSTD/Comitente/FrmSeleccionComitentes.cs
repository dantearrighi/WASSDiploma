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
    public partial class FrmSeleccionComitentes : Form
    {
        // Declaro las variables que voy a utilizar en el formulario
        private static FrmSeleccionComitentes instancia;

        // Declaro las controladoras a usar
        Controladora.cComitente cComitente;

        // Declaro los Binding source a usar
        BindingSource BsComitentes;

        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmSeleccionComitentes ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FrmSeleccionComitentes();
            }

            if (instancia.IsDisposed)
            {
                instancia = new FrmSeleccionComitentes();
            }

            return instancia;
        }

        // Cuando se incializa el formulario
        public FrmSeleccionComitentes()
        {
            InitializeComponent();
            cComitente = Controladora.cComitente.ObtenerInstancia();
        }

        // Cuando carga el formulario
        private void FrmSeleccionComitentes_Load(object sender, EventArgs e)
        {
            Arma_Lista();
        }

        // Método privado para armar el datagridview
        private void Arma_Lista()
        {
            // Instancio el binding source
            BsComitentes = new BindingSource();
            //Luego lo lleno con los datos de la grilla
            BsComitentes.DataSource = dgv_datos;

            // Limpio la grilla
            dgv_datos.DataSource = null;
            // LLeno el binding con los datos que traigo de las entidades
            BsComitentes.DataSource = cComitente.ObtenerComitentes();
            // Asigno el binding a la grilla
            dgv_datos.DataSource = BsComitentes;
            dgv_datos.Columns[0].Visible = false;
            dgv_datos.Columns[1].HeaderText = "Nombre y Apellido";
            dgv_datos.Columns[2].Visible = false;
        }

        // Necesito devolver el usuario que seleccione
        public Modelo_Entidades.Comitente ComitenteElegido
        {
            get { return (Modelo_Entidades.Comitente)dgv_datos.CurrentRow.DataBoundItem; }
        }

        // Cuando le doy click a cancelar
        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cuando le doy click a "Seleccionar"
        private void btn_seleccionar_Click_1(object sender, EventArgs e)
        {
            if (dgv_datos.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Debe seleccionar al menos 1 Comitente");
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

        // Cuando cambio el texto en el txt del Comitente
        private void txt_nya_comitente_TextChanged_1(object sender, EventArgs e)
        {
            BsComitentes.DataSource = cComitente.FiltrarPorNyA(txt_nya_comitente.Text);
            dgv_datos.DataSource = BsComitentes;
        }
    }
}
