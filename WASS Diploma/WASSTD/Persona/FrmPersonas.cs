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
    public partial class FrmPersonas : Form
    {
        // Declaro las variables que voy a utilizar en el formulario
        private static FrmPersonas instancia;
        Controladora.cPersona cPersona;
        FrmPersona FormPersona;
        BindingSource BsPersonas;
        Modelo_Entidades.Usuario miUsuario;

        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmPersonas ObtenerInstancia(Modelo_Entidades.Usuario oUsuario)
        {
            if (instancia == null)
            {
                instancia = new FrmPersonas(oUsuario);
            }

            if (instancia.IsDisposed)
            {
                instancia = new FrmPersonas(oUsuario);
            }

            return instancia;
        }

        // Establezco como privado al constructor
        private FrmPersonas(Modelo_Entidades.Usuario oUsuario)
        {
            InitializeComponent();
            cPersona = Controladora.cPersona.ObtenerInstancia();
            botonera1.ArmaPerfil(oUsuario, "FrmPersonas");
            miUsuario = oUsuario;
        }

        // Cuando carga el formulario
        private void FrmPersonas_Load(object sender, EventArgs e)
        {            
            Arma_Lista();
        }

        // Armo la lista de la grilla de datos
        private void Arma_Lista()
        {
            // Instancio el binding source
            BsPersonas = new BindingSource();
            //Luego lo lleno con los datos de la grilla
            BsPersonas.DataSource = dgv_datos;

            // Limpio la grilla
            dgv_datos.DataSource = null;
            // LLeno el binding con los datos que traigo de las entidades
            BsPersonas.DataSource = cPersona.ObtenerPersonas();
            // Asigno el binding a la grilla
            dgv_datos.DataSource = BsPersonas;
            dgv_datos.Columns[0].HeaderText = "DNI";
            dgv_datos.Columns[1].HeaderText = "Nombre y Apellido";
            dgv_datos.Columns[2].Visible = false;
            dgv_datos.Columns[3].HeaderText = "Fijo";
            dgv_datos.Columns[4].HeaderText= "Celular";
            dgv_datos.Columns[5].HeaderText = "Email";
            dgv_datos.Columns[6].Visible = false;
            dgv_datos.Columns[7].Visible = false;
            dgv_datos.Columns[8].Visible = false;
            dgv_datos.Columns[9].Visible = false;
            dgv_datos.Columns[10].Visible = false;
            dgv_datos.Columns[11].Visible = false;
            dgv_datos.Columns[12].Visible = false;
            dgv_datos.Columns[13].Visible = false;
            dgv_datos.Columns[14].Visible = false; // Tipo Persona
            
           
        }

        // Al hacer click en "Agregar"
        private void botonera1_Click_Alta(object sender, EventArgs e)
        {
            FormPersona = new FrmPersona("Alta", new Modelo_Entidades.Persona(), miUsuario);
            DialogResult dr = FormPersona.ShowDialog();
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

            FormPersona = new FrmPersona("Modifica", (Modelo_Entidades.Persona)dgv_datos.CurrentRow.DataBoundItem, miUsuario);
            DialogResult dr = FormPersona.ShowDialog();
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

            FormPersona = new FrmPersona("Consulta", (Modelo_Entidades.Persona)dgv_datos.CurrentRow.DataBoundItem, miUsuario);
            DialogResult dr = FormPersona.ShowDialog();
        }

        // Al hacer click en "Cerrar"
        private void botonera1_Click_Cerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        

        // Al cambiar el texto en el dni
        private void txt_dni_TextChanged(object sender, EventArgs e)
        {
            //BsPersonas.DataSource = cPersona.FiltrarPorDNI(txt_dni.Text);
           // dgv_datos.DataSource = BsPersonas;
        }

        

    }
}
