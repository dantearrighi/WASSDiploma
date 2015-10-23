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
    public partial class FrmPlanesTitulo : Form
    {
        // Declaro las controladoras a usar
        Controladora.cPlan cPlan;
        Controladora.cLegajo_Academico cLegajo_Academico;
        string modo;

        Modelo_Entidades.Plan oPlan;

        // Declaro como publico al constructor
        public FrmPlanesTitulo(string fmodo, Modelo_Entidades.Plan miPlan)
        {
            InitializeComponent();
            cPlan = Controladora.cPlan.ObtenerInstancia();
            cLegajo_Academico = Controladora.cLegajo_Academico.ObtenerInstancia();
            modo = fmodo;
            oPlan = miPlan;
        }

        // Valido los datos ingresados
        private bool Validardatos()
        {
            if (txt_año.Text == null)
            {
                MessageBox.Show("Debe ingresar un año para el plan");
                return false;
            }

            if (txt_ordenanzaconsejo.Text == null)
            {
                MessageBox.Show("Debe ingresar una ordenanza para el título");
                return false;
            }

            if (txt_plan_descripcion.Text == null)
            {
                MessageBox.Show("Debe ingresar una descripción para el plan");
                return false;
            }

            if (txt_incumbencia.Text == null)
            {
                MessageBox.Show("Debe ingresar una incumbencia para el plan del título");
                return false;
            }

            if (cLegajo_Academico.ValidarPlandelTitulo(txt_año.Text) == false)
            {
                if (oPlan.año != txt_año.Text)
                {
                    MessageBox.Show("Ya existe un plan como el ingresado");
                    return false;
                }
            }

            return true;
        }

        // Cuando le doy click a guardar
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Validardatos())
            {
                //try
                //{
                    oPlan.año = txt_año.Text;
                    oPlan.ordenanza = txt_ordenanzaconsejo.Text;
                    oPlan.descripcion = txt_plan_descripcion.Text;
                    oPlan.incumbencia = txt_incumbencia.Text;

                    if (modo == "Alta")
                    {
                        cPlan.AgregarPlan(oPlan);
                    }

                    else
                    {
                        cPlan.ModificarPlan(oPlan);
                    }

                    this.DialogResult = DialogResult.OK;
                //}

                //catch (Exception Exc)
                //{
                //    MessageBox.Show(Exc.InnerException.Message.ToString());
                //}
            }
        }

        // Cuando le doy click a cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Pongo como publico un metodo que me devuelva el plan
        public Modelo_Entidades.Plan PlanElegido
        {
            get { return oPlan; }
        }

        // Cuando carga el formulario
        private void FrmPlanesTitulo_Load(object sender, EventArgs e)
        {
            ArmaLista();
        }

        private void ArmaLista()
        {
            if (modo != "Alta")
            {
                txt_año.Text = oPlan.año;
                txt_ordenanzaconsejo.Text = oPlan.ordenanza;
                txt_plan_descripcion.Text = oPlan.descripcion;
                txt_incumbencia.Text = oPlan.incumbencia;
            }
        }
    }
}
