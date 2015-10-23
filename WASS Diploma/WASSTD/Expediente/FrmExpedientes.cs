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
    public partial class FrmExpedientes : Form
    {
        // Declaro las variables que voy a utilizar en el formulario
        private static FrmExpedientes instancia;
        //string desc_obra;

        // Declaro las controladoras a usar
        Controladora.cUsuario cUsuario;
        Controladora.cTipo_Movimiento cTipo_Movimiento;
        Controladora.cMovimiento cMovimiento;
        Controladora.cTarea cTarea;
        Controladora.cProfesional cProfesional;
        Controladora.cExpediente cExpediente;

        FrmExpediente FormExpediente;

        Modelo_Entidades.Usuario miUsuario;

        BindingSource BsExpedientes;

        private FrmExpedientes(Modelo_Entidades.Usuario oUsuario)
        {
            InitializeComponent();
            miUsuario = oUsuario;

            // Inicializo a las controladoras
            cUsuario = Controladora.cUsuario.ObtenerInstancia();
            cMovimiento = Controladora.cMovimiento.ObtenerInstancia();
            cTipo_Movimiento = Controladora.cTipo_Movimiento.ObtenerInstancia();
            cTarea = Controladora.cTarea.ObtenerInstancia();
            cProfesional = Controladora.cProfesional.ObtenerInstancia();
            cExpediente = Controladora.cExpediente.ObtenerInstancia();

            botonera1.ArmaPerfil(miUsuario, "FrmExpedientes");
        }

        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmExpedientes ObtenerInstancia(Modelo_Entidades.Usuario oUsuario)
        {
            if (instancia == null)
            {
                instancia = new FrmExpedientes(oUsuario);
            }

            if (instancia.IsDisposed)
            {
                instancia = new FrmExpedientes(oUsuario);
            }

            return instancia;
        }

        // Cuando carga el formulario
        private void FrmExpedientes_Load(object sender, EventArgs e)
        {
            lb_nuevo_expediente.Visible = false;
            cmb_nuevo_expediente.Visible = false;
            Arma_Lista();
        }

        // Armo la lista de la grilla de datos
        private void Arma_Lista()
        {
            // Instancio el binding source
            BsExpedientes = new BindingSource();
            //Luego lo lleno con los datos de la grilla
            BsExpedientes.DataSource = dgv_datos;

            cmb_obra.Items.Clear();
            cmb_obra.Items.Add("Todas");
            cmb_obra.Items.Add("Obras de Ingenieria");
            cmb_obra.Items.Add("Fuerza Electromotriz");
            cmb_obra.Items.Add("Honorario Mínimo");
            cmb_obra.SelectedItem = cmb_obra.Items[0];    
   
            if (cmb_descripcion_tarea.Text != "Todas")
            {
                cmb_descripcion_tarea.Text = "Todas";
            }

            cmb_nuevo_expediente.Items.Clear();
            cmb_nuevo_expediente.Items.Add("Obras de Ingenieria");
            cmb_nuevo_expediente.Items.Add("Fuerza Electromotriz");
            cmb_nuevo_expediente.Items.Add("Honorario Mínimo");
            cmb_nuevo_expediente.SelectedItem = null;

            // Limpio la grilla
            dgv_datos.DataSource = null;
            // LLeno el binding con los datos que traigo de las entidades
            BsExpedientes.DataSource = cExpediente.ObtenerExpedientes().OrderBy(x => x.numero).ToList();
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

            // Finalmente limpio los txts
            txt_nya_comitente.Text = "";
            txt_profesional.Text = "";

        }

        // Al hacer click en "filtrar"
        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            string VarCombo_Obras;
            string VarCombo_Tareas;
            string nya_profesional;
            string nya_comitente;

            if (cmb_obra.SelectedItem == null)
            {
                VarCombo_Obras = "0";
            }

            else
            {
                VarCombo_Obras = cmb_obra.SelectedItem.ToString();
            }

            if (cmb_descripcion_tarea.SelectedItem == null)
            {
                VarCombo_Tareas = "0";
            }

            else
            {
                VarCombo_Tareas = ((Modelo_Entidades.Tarea)cmb_descripcion_tarea.SelectedItem).descripcion;
            }

            if (txt_profesional.Text == "")
            {
                nya_profesional = "0";
            }

            else
            {
                Modelo_Entidades.Profesional oProf = cProfesional.ObtenerProfesional(Convert.ToInt32(txt_profesional.Text));

                if (oProf != null)
                {
                    nya_profesional = txt_profesional.Text;
                }

                else
                {
                    nya_profesional = "0";
                    MessageBox.Show("El profesional no registra ningún expediente");
                }
            }

            if (txt_nya_comitente.Text == "")
            {
                nya_comitente = "0";
            }

            else
            {
                nya_comitente = txt_nya_comitente.Text;
            }

            BsExpedientes.DataSource = cExpediente.FiltrarExpedientes(nya_profesional, nya_comitente, VarCombo_Obras, VarCombo_Tareas);
            dgv_datos.DataSource = BsExpedientes;

            dgv_datos.Columns[0].HeaderText = "Número";
            dgv_datos.Columns[1].HeaderText = "Estado";
            dgv_datos.Columns[2].Visible = false;
            dgv_datos.Columns[3].Visible = false;
            dgv_datos.Columns[4].HeaderText = "Aportes definitivos";
            dgv_datos.Columns[5].Visible = false;
            dgv_datos.Columns[6].Visible = false;
            dgv_datos.Columns[7].Visible = false;
            dgv_datos.Columns[8].Visible = false;
            dgv_datos.Columns[9].Visible = false;
        }

        // Al hacer click en "Agregar"
        private void botonera1_Click_Alta_1(object sender, EventArgs e)
        {
            // Colocar un combobox con los 3 tipos de expedientes, en base a lo que eliga se va a crear el nuevo expediente
            lb_nuevo_expediente.Visible = true;
            cmb_nuevo_expediente.Visible = true;
        }

        // Al hacer click en "Cerrar"
        private void botonera1_Click_Cerrar_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // Al hacer click en "Ver detalles"
        private void botonera1_Click_Consulta_1(object sender, EventArgs e)
        {
            if (dgv_datos.CurrentRow == null)
            {
                return;
            }

            string eleccion = dgv_datos.CurrentRow.DataBoundItem.GetType().ToString();

            switch (eleccion)
            {
                case ("Modelo_Entidades.OI"):
                    FormExpediente = new FrmExpediente("Consulta", (Modelo_Entidades.OI)dgv_datos.CurrentRow.DataBoundItem, miUsuario);
                    DialogResult dr_1 = FormExpediente.ShowDialog();
                    if (dr_1 == DialogResult.OK)
                    {
                        Arma_Lista();
                    }
                    break;

                case ("Modelo_Entidades.FE"):
                    FormExpediente = new FrmExpediente("Consulta", (Modelo_Entidades.FE)dgv_datos.CurrentRow.DataBoundItem, miUsuario);
                    DialogResult dr_2 = FormExpediente.ShowDialog();
                    if (dr_2 == DialogResult.OK)
                    {
                        Arma_Lista();
                    }
                    break;

                case ("Modelo_Entidades.HM"):
                    FormExpediente = new FrmExpediente("Consulta", (Modelo_Entidades.HM)dgv_datos.CurrentRow.DataBoundItem, miUsuario);
                    DialogResult dr_3 = FormExpediente.ShowDialog();
                    if (dr_3 == DialogResult.OK)
                    {
                        Arma_Lista();
                    }
                    break;
            }
        }

        // Al hacer click en "Modificar"
        private void botonera1_Click_Modificacion_1(object sender, EventArgs e)
        {
            if (dgv_datos.CurrentRow == null)
            {
                return;
            }

            string eleccion = dgv_datos.CurrentRow.DataBoundItem.GetType().ToString();

            switch (eleccion)
            {
                case ("Modelo_Entidades.OI"):
                    FormExpediente = new FrmExpediente("Modifica", (Modelo_Entidades.OI)dgv_datos.CurrentRow.DataBoundItem, miUsuario);
                    DialogResult dr_1 = FormExpediente.ShowDialog();
                    if (dr_1 == DialogResult.OK)
                    {
                        Arma_Lista();
                    }
                    break;

                case ("Modelo_Entidades.FE"):
                    FormExpediente = new FrmExpediente("Modifica", (Modelo_Entidades.FE)dgv_datos.CurrentRow.DataBoundItem, miUsuario);
                    DialogResult dr_2 = FormExpediente.ShowDialog();
                    if (dr_2 == DialogResult.OK)
                    {
                        Arma_Lista();
                    }
                    break;

                case ("Modelo_Entidades.HM"):
                    FormExpediente = new FrmExpediente("Modifica", (Modelo_Entidades.HM)dgv_datos.CurrentRow.DataBoundItem, miUsuario);
                    DialogResult dr_3 = FormExpediente.ShowDialog();
                    if (dr_3 == DialogResult.OK)
                    {
                        Arma_Lista();
                    }
                    break;
            }
        }

        // Cuando cambia el combo del nuevo expediente
        private void cmb_nuevo_expediente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string eleccion = cmb_nuevo_expediente.SelectedItem.ToString();

            switch (eleccion)
            {
                case ("Obras de Ingenieria"):
                    FormExpediente = new FrmExpediente("Alta", new Modelo_Entidades.OI(), miUsuario);
                    DialogResult dr_1 = FormExpediente.ShowDialog();
                    if (dr_1 == DialogResult.OK)
                    {
                        Arma_Lista();
                    }
                    break;

                case ("Fuerza Electromotriz"):
                    FormExpediente = new FrmExpediente("Alta", new Modelo_Entidades.FE(), miUsuario);
                    DialogResult dr_2 = FormExpediente.ShowDialog();
                    if (dr_2 == DialogResult.OK)
                    {
                        Arma_Lista();
                    }
                    break;

                case ("Honorario Mínimo"):
                    FormExpediente = new FrmExpediente("Alta", new Modelo_Entidades.HM(), miUsuario);
                    DialogResult dr_3 = FormExpediente.ShowDialog();
                    if (dr_3 == DialogResult.OK)
                    {
                        Arma_Lista();
                    }
                    break;
            }

            Arma_Lista();
        }

        // Cuando cambia el combo de la obra
        private void cmb_obra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_obra.SelectedItem != null)
            {
                cmb_descripcion_tarea.DataSource = cTarea.BuscarTareasPorObra(cmb_obra.SelectedItem.ToString());
                cmb_descripcion_tarea.DisplayMember = "descripcion";
            }

            else
            {
                cmb_descripcion_tarea.Items.Clear();
                cmb_descripcion_tarea.Items.Add("Todas");
                cmb_descripcion_tarea.SelectedItem = cmb_obra.Items[0];
            }
        }

        // Cuando le doy click a "Nueva consulta"
        private void btn_nuevaconsulta_Click(object sender, EventArgs e)
        {
            Arma_Lista();
        }
    }
}
