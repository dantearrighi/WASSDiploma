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
    public partial class FrmProfesionales : Form
    {
        // Declaro las variables que voy a utilizar en el formulario
        private static FrmProfesionales instancia;
        Controladora.cProfesional cProfesional;
        FrmProfesional FormProfesional;
        BindingSource BsProfesionales;
        Modelo_Entidades.Usuario miUsuario;

        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmProfesionales ObtenerInstancia(Modelo_Entidades.Usuario oUsuario)
        {
            if (instancia == null)
            {
                instancia = new FrmProfesionales(oUsuario);
            }

            if (instancia.IsDisposed)
            {
                instancia = new FrmProfesionales(oUsuario);
            }

            return instancia;
        }

        // Establezco como privado al constructor
        private FrmProfesionales(Modelo_Entidades.Usuario oUsuario)
        {
            InitializeComponent();
            cProfesional = Controladora.cProfesional.ObtenerInstancia();
            botonera1.ArmaPerfil(oUsuario, "FrmProfesionales");
            miUsuario = oUsuario;
        }

        // Cuando carga el formulario
        private void FrmProfesionales_Load(object sender, EventArgs e)
        {            
            Arma_Lista();
        }

        // Armo la lista de la grilla de datos
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
            dgv_datos.Columns[17].HeaderText = "Estado";
            dgv_datos.Columns[18].Visible = false;
            dgv_datos.Columns[19].HeaderText = "Tipo de Matricula";
            dgv_datos.Columns[20].Visible = false;
            dgv_datos.Columns[21].Visible = false;
            dgv_datos.Columns[22].Visible = false;
        }

        // Al hacer click en "Agregar"
        private void botonera1_Click_Alta(object sender, EventArgs e)
        {
            FormProfesional = new FrmProfesional("Alta", new Modelo_Entidades.Profesional(), miUsuario);
            DialogResult dr = FormProfesional.ShowDialog();
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

            FormProfesional = new FrmProfesional("Modifica", (Modelo_Entidades.Profesional)dgv_datos.CurrentRow.DataBoundItem, miUsuario);
            DialogResult dr = FormProfesional.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Arma_Lista();
            }
        }

        // Al hacer click en "Ver Detalles"
        private void botonera1_Click_Consulta(object sender, EventArgs e)
        {
            if (dgv_datos.CurrentRow == null)
            {
                return;
            }

            FormProfesional = new FrmProfesional("Consulta", (Modelo_Entidades.Profesional)dgv_datos.CurrentRow.DataBoundItem, miUsuario);
            DialogResult dr = FormProfesional.ShowDialog();
        }

        // Al hacer click en "Cerrar"
        private void botonera1_Click_Cerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        // Al cambiar el texto en el número de matrícula
        private void txt_num_matricula_TextChanged(object sender, EventArgs e)
        {
            BsProfesionales.DataSource = cProfesional.FiltrarPorICIE(txt_num_matricula.Text);
            dgv_datos.DataSource = BsProfesionales;
        }

        // Al cambiar el texto en el dni
        private void txt_dni_TextChanged(object sender, EventArgs e)
        {
            BsProfesionales.DataSource = cProfesional.FiltrarPorDNI(txt_dni.Text);
            dgv_datos.DataSource = BsProfesionales;
        }

        // Al cambiar el texto en el nombre y apellido del profesional
        private void txt_nya_profesional_TextChanged(object sender, EventArgs e)
        {
            BsProfesionales.DataSource = cProfesional.FiltrarPorNyA(txt_nya_profesional.Text);
            dgv_datos.DataSource = BsProfesionales;
        }

    }
}
