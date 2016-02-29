using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
namespace WASSTD
{
    public partial class FrmSeleccionPersonas : Form
    {
        // Declaro las variables que voy a utilizar en el formulario
        private static FrmSeleccionPersonas instancia;
        private Usuarios miUsuario;

        // Declaro las controladoras a usar
        Controladora.cCU_GestionarPersonas cCU_GestionarPersonas;

        // Necesito devolver la persona que seleccione
        public Personas PersonaElegida
        {
            get { return (Personas)dgv_datos.CurrentRow.DataBoundItem; }
        }

        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmSeleccionPersonas ObtenerInstancia(Usuarios oUsuario)
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
        public FrmSeleccionPersonas(Usuarios oUsuario)
        {
            InitializeComponent();
            cCU_GestionarPersonas = Controladora.cCU_GestionarPersonas.ObtenerInstancia();
            miUsuario = oUsuario;
        }

        // Cuando carga el formulario
        private void FrmSeleccionPersonas_Load(object sender, EventArgs e)
        {
            Arma_Lista();
        }

        // Método privado para armar el datagridview
        private void Arma_Lista()
        {
            // Limpio la grilla
            dgv_datos.DataSource = null;
           
            // LLeno la grilla
            dgv_datos.DataSource = cCU_GestionarPersonas.ObtenerPersonas();

            FormatearVista();
        }


        //Doy formato a la grilla al cargarle datos
        private void FormatearVista()
        {
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
         /*   dgv_datos.Columns[15].Visible = false;
            dgv_datos.Columns[16].Visible = false;
            dgv_datos.Columns[17].Visible = false;
            dgv_datos.Columns[18].Visible = false;
            dgv_datos.Columns[19].Visible = false;
            dgv_datos.Columns[20].Visible = false;
            dgv_datos.Columns[21].Visible = false;
            dgv_datos.Columns[22].Visible = false;*/
        }

        // FILTRAR por nombre y apellido
        private void txt_nya_Persona_TextChanged(object sender, EventArgs e)
        {
            dgv_datos.DataSource = cCU_GestionarPersonas.FiltrarPorNyA(txt_nya_Persona.Text);
            FormatearVista();
        }

        // CLICK Cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // CLICK Seleccionar persona
        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (dgv_datos.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Debe seleccionar una Persona");
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


        // CLICK AÑADIR PERSONA 
        private void btnAñadirPersona_Click(object sender, EventArgs e)
        {
            FrmPersona formAlta = new FrmPersona("Alta", new Personas(), miUsuario);
            if(DialogResult.OK == formAlta.ShowDialog())
            Arma_Lista();
        }

       

    }
}
