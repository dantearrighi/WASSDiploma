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
    public partial class FrmTitulo : Form
    {
        // Declaron las variables que voy a utilizar en el formulario
        string modo;
        Controladora.cTitulo cTitulo;
        Controladora.cUniversidad cUniversidad;
        Controladora.cJurisdiccion cJurisdiccion;
        Controladora.cModalidad cModalidad;
        Controladora.cNivel cNivel;
        Controladora.cEspecialidad cEspecialidad;
        Controladora.cPlan cPlan;
        Controladora.cMatricula cMatricula;
        Controladora.cLegajo_Academico cLegajo_Academico;

        Modelo_Entidades.Titulo oTitulo;
        Modelo_Entidades.Plan oPlan;
        Modelo_Entidades.Legajo_Academico oLegajo_Academico;

        BindingSource BsPlanes;

        FrmPlanesTitulo FormPlanesTitulo;

        // Hago públio el formulario para poder llamarlo desde otros
        public FrmTitulo(string fModo, Modelo_Entidades.Titulo miTitulo)
        {
            InitializeComponent();

            // Declaro las controladoras a utilizar en el formulario
            cTitulo = Controladora.cTitulo.ObtenerInstancia();
            cUniversidad = Controladora.cUniversidad.ObtenerInstancia();
            cJurisdiccion = Controladora.cJurisdiccion.ObtenerInstancia();
            cModalidad = Controladora.cModalidad.ObtenerInstancia();
            cNivel = Controladora.cNivel.ObtenerInstancia();
            cEspecialidad = Controladora.cEspecialidad.ObtenerInstancia();
            cPlan = Controladora.cPlan.ObtenerInstancia();
            cMatricula = Controladora.cMatricula.ObtenerInstancia();
            cLegajo_Academico = Controladora.cLegajo_Academico.ObtenerInstancia();

            modo = fModo;
            oTitulo = miTitulo;

            if (modo != "Alta")
            {
                if (modo == "Consulta")
                {
                    grp_acciones.Enabled = false;
                    btn_guardar.Enabled = false;
                    btn_cancelar.Text = "Cerrar";
                }                
            }
        }

        // Al cargar el formulario
        private void FrmTitulo_Load(object sender, EventArgs e)
        {
            // Instancio el binding source
            BsPlanes = new BindingSource();
            //Luego lo lleno con los datos de la grilla
            BsPlanes.DataSource = dgv_planes;

            cmb_universidad.DataSource = cUniversidad.ObtenerUniversidades();
            cmb_universidad.DisplayMember = "descripcion";
            cmb_universidad.SelectedItem = null;

            cmb_jurisdiccion.DataSource = cJurisdiccion.ObtenerJurisdicciones();
            cmb_jurisdiccion.DisplayMember = "descripcion";
            cmb_jurisdiccion.SelectedItem = null;

            cmb_modalidad.DataSource = cModalidad.ObtenerModalidades();
            cmb_modalidad.DisplayMember = "descripcion";
            cmb_modalidad.SelectedItem = null;

            cmb_nivel.DataSource = cNivel.ObtenerNiveles();
            cmb_nivel.DisplayMember = "descripcion";
            cmb_nivel.SelectedItem = null;

            cmb_especialidades.DataSource = cEspecialidad.ObtenerEspecialidades();
            cmb_especialidades.DisplayMember = "descripcion";
            cmb_especialidades.SelectedItem = null;

            ArmaPlanes();

            CargaDatos(oTitulo);
        }        

        // Al hacer click en guardar
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (ValidarObligatorios() == true)
            {
                //try
                //{
                    // Datos del titulo
                    oTitulo.Universidad = (Modelo_Entidades.Universidad)cmb_universidad.SelectedItem;
                    oTitulo.descripcion = txt_titulo.Text;
                    oTitulo.ley_aprobacion = txt_leyaprobacion.Text;
                    oTitulo.res_coneau = txt_coneau.Text;
                    oTitulo.Jurisdiccion = (Modelo_Entidades.Jurisdiccion)cmb_jurisdiccion.SelectedItem;
                    oTitulo.Modalidad = (Modelo_Entidades.Modalidad)cmb_modalidad.SelectedItem;
                    oTitulo.Nivel = (Modelo_Entidades.Nivel)cmb_nivel.SelectedItem;
                    oTitulo.validez = txt_terminovalidez.Text;
                    oTitulo.aprobacion_cie = txt_aprobacioncie.Text;

                    oTitulo.Especialidad = (Modelo_Entidades.Especialidad)cmb_especialidades.SelectedItem;

                    if (modo == "Alta")
                    {
                        cTitulo.AgregarTitulo(oTitulo);
                        MessageBox.Show("El título se ha agregado correctamente");
                    }

                    else
                    {
                        cTitulo.ModificarTitulo(oTitulo);
                        MessageBox.Show("El título se ha modificado correctamente");
                    }   
                    

                    this.DialogResult = DialogResult.OK;
                //}

                //catch (Exception Exc)
                //{
                //    MessageBox.Show(Exc.InnerException.Message.ToString());
                //}
            }

            else
            {
                this.Show();
            }
        }

        // Valido los datos del grupo
        private bool ValidarObligatorios()
        {
            if (cmb_universidad.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar una universidad para el título");
                return false;
            }

            if (string.IsNullOrEmpty(txt_titulo.Text))
            {
                MessageBox.Show("Debe ingresar una descipción para el título");
                return false;
            }

            if (string.IsNullOrEmpty(txt_leyaprobacion.Text))
            {
                MessageBox.Show("Debe ingresar una ley de aprobación para el título");
                return false;
            }

            if (string.IsNullOrEmpty(txt_coneau.Text))
            {
                MessageBox.Show("El título se cargará sin una resolucuión por parte de la CONEAU");
            }

            if (cmb_jurisdiccion.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar una jurisdicción para el título");
                return false;
            }

            if (cmb_modalidad.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar una modalidad para el título");
                return false;
            }

            if (cmb_nivel.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar un nivel para el título");
                return false;
            }

            if (string.IsNullOrEmpty(txt_terminovalidez.Text))
            {
                MessageBox.Show("El título se cargará sin un término de validez");
            }

            if (string.IsNullOrEmpty(txt_aprobacioncie.Text))
            {
                MessageBox.Show("Debe ingresar una instancia en la que el título se aprobó en el Colegio");
                return false;
            }

            if (cmb_especialidades.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar una especialidad para el título");
                return false;
            }

            if (cTitulo.ValidarTitulo(txt_titulo.Text) == false)
            {
                if (oTitulo.descripcion != txt_titulo.Text)
                {
                    MessageBox.Show("Ya existe un título como el ingresado");
                    return false;
                }
            }
            
            return true;
        }

        // Al hacer click en cancelar
        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        // Cuando le doy click a agregar
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FormPlanesTitulo = new FrmPlanesTitulo("Alta", new Modelo_Entidades.Plan());
            DialogResult dr = FormPlanesTitulo.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // Traigo lo elegido por el usuario
                oPlan = FormPlanesTitulo.PlanElegido;

                // Creo el legajo 
                oLegajo_Academico = new Modelo_Entidades.Legajo_Academico();
                oLegajo_Academico.Plan = oPlan;
                //oLegajo_Academico.Titulo = oTitulo;

                oTitulo.Legajos_Academicos.Add(oLegajo_Academico);

                 MessageBox.Show("El plan se ha cargado carrectamente. aparecera en la grilla una vez que la vuelva a abrir.");          

                ArmaPlanes();
            }
        }

        // Cuando le doy click a modificar
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            oPlan = (Modelo_Entidades.Plan)dgv_planes.CurrentRow.DataBoundItem;

            FormPlanesTitulo = new FrmPlanesTitulo("Modificar", oPlan);
            DialogResult dr = FormPlanesTitulo.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // Traigo lo modificado p1or el usuario
                Modelo_Entidades.Plan miPlan = FormPlanesTitulo.PlanElegido;
                // Agrego el legajo academico
                oTitulo.Legajos_Academicos.Equals(oLegajo_Academico);
                oPlan.Legajos_Academicos.Equals(oLegajo_Academico);

                oLegajo_Academico = cLegajo_Academico.BuscarLegajoPorTityPlan(oTitulo, miPlan);
                // Le asigno al legajo el titulo y el plan
                oLegajo_Academico.Titulo = oTitulo;
                oLegajo_Academico.Plan = miPlan;



                ArmaPlanes();
            }
        }

        // Armo la lista de los planes
        private void ArmaPlanes()
        {
            // Limpio la grilla
            dgv_planes.DataSource = null;
            // LLeno el binding con los datos que traigo de las entidades
            BsPlanes.DataSource = cLegajo_Academico.BuscarPlanesPorTit(oTitulo);
            // Asigno el binding a la grilla
            dgv_planes.DataSource = BsPlanes;
            dgv_planes.Columns[0].Visible = false;
            dgv_planes.Columns[1].HeaderText = "Plan";
            dgv_planes.Columns[2].HeaderText = "Ordenanza";
            dgv_planes.Columns[3].Visible = false;
            dgv_planes.Columns[4].Visible = false;
            dgv_planes.Columns[5].Visible = false;
        }

        // Cuando le doy click a eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {            
            oPlan = (Modelo_Entidades.Plan)dgv_planes.CurrentRow.DataBoundItem;
            oTitulo = cTitulo.ObtenerTituloPorDesc(txt_titulo.Text);
            Modelo_Entidades.Legajo_Academico oLegajo_Academico = cLegajo_Academico.BuscarLegajoPorTityPlan(oTitulo, oPlan);

            // Saco el plan de los legajos academicos de ese titulo
            DialogResult Rta = MessageBox.Show("¿Confirma la desvinculación del plan con el título?", "Baja", MessageBoxButtons.YesNo);
            if (Rta == DialogResult.Yes)
            {
                if (oLegajo_Academico.Matriculas.Count != 0)
                {
                    MessageBox.Show("No puede eliminar al título ya que existen profesionales asociados a el.");
                }

                else
                {
                    cLegajo_Academico.BajaLegajo(oLegajo_Academico);
                    MessageBox.Show("El plan y el título fueron eliminados de su respectivo legajo");
                    ArmaPlanes();
                }
            }

            else
            {
                return;
            }
        }

        // Cargo los datos en los controles correspondientes
        private void CargaDatos(Modelo_Entidades.Titulo oTitulo)
        {
            // Sección de los datos del título
            cmb_universidad.SelectedItem = oTitulo.Universidad;
            txt_titulo.Text = oTitulo.descripcion;
            txt_leyaprobacion.Text = oTitulo.ley_aprobacion;
            txt_coneau.Text = oTitulo.res_coneau;
            cmb_jurisdiccion.SelectedItem = oTitulo.Jurisdiccion;
            cmb_modalidad.SelectedItem = oTitulo.Modalidad;
            cmb_nivel.SelectedItem = oTitulo.Nivel;
            txt_terminovalidez.Text = oTitulo.validez;
            txt_aprobacioncie.Text = oTitulo.aprobacion_cie;

            cmb_especialidades.SelectedItem = oTitulo.Especialidad;

            // Cambio la etiqueta que lleva la grilla de planes para saber de que estoy hablando
            lb_planes.Text = "Planes del título:" + txt_titulo.Text;
        }
    }
}
