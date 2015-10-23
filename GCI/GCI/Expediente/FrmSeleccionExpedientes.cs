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
    public partial class FrmSeleccionExpedientes : Form
    {
        private static FrmSeleccionExpedientes instancia;

        // Declaro las controladoras a usar
        Controladora.cExpediente cExpediente;
        Modelo_Entidades.Profesional miProfesional;

        // Declaro los Binding source a usar
        BindingSource BsExpedientes;

        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmSeleccionExpedientes ObtenerInstancia(Modelo_Entidades.Profesional oProfesional)
        {
            if (instancia == null)
            {
                instancia = new FrmSeleccionExpedientes(oProfesional);
            }

            if (instancia.IsDisposed)
            {
                instancia = new FrmSeleccionExpedientes(oProfesional);
            }

            return instancia;
        }

        // Cuando se incializa el formulario
        public FrmSeleccionExpedientes(Modelo_Entidades.Profesional oProfesional)
        {
            InitializeComponent();
            cExpediente = Controladora.cExpediente.ObtenerInstancia();
            miProfesional = oProfesional;
        }

        // Cuando carga el formulario
        private void FrmSeleccionExpedientes_Load(object sender, EventArgs e)
        {
            Arma_Lista();
        }

        // Método privado para armar el datagridview
        private void Arma_Lista()
        {
            // Instancio el binding source
            BsExpedientes = new BindingSource();
            //Luego lo lleno con los datos de la grilla
            BsExpedientes.DataSource = dgv_datos;

            // Limpio la grilla
            dgv_datos.DataSource = null;
            // LLeno el binding con los datos que traigo de las entidades
            BsExpedientes.DataSource = cExpediente.BuscarExpedientesAprobados(miProfesional);
            // Asigno el binding a la grilla
            dgv_datos.DataSource = BsExpedientes;
            dgv_datos.Columns[0].HeaderText = "Número";
            dgv_datos.Columns[1].HeaderText = "Estado";
            dgv_datos.Columns[2].Visible = false;
            dgv_datos.Columns[3].Visible = false;
            dgv_datos.Columns[4].Visible = false;
            dgv_datos.Columns[5].Visible = false;
            dgv_datos.Columns[6].Visible = false;
            dgv_datos.Columns[7].Visible = false;
            dgv_datos.Columns[8].Visible = false;
            dgv_datos.Columns[9].Visible = false;
        }        

        // Cuando le doy click a filtrar
        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            BsExpedientes.DataSource = cExpediente.BuscarExpedientePorNumero(Convert.ToInt32(txt_numero.Text));
            dgv_datos.DataSource = BsExpedientes;
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
                MessageBox.Show("Debe seleccionar al menos 1 expediente");
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

        // Necesito devolver el expediente que consegui en el Login
        public Modelo_Entidades.Expediente ExpedienteElegido
        {
            get { return (Modelo_Entidades.Expediente)dgv_datos.CurrentRow.DataBoundItem; }
        }

    }
}
