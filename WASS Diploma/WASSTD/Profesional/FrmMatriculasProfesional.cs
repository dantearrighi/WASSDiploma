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
    public partial class FrmMatriculas : Form
    {
        // Declaro las controladoras a usar
        Controladora.cUniversidad cUniversidad;
        Controladora.cTitulo cTitulo;
        Controladora.cPlan cPlan;
        Controladora.cVerificacion cVerificacion;
        Controladora.cMatricula cMatricula;
        Controladora.cLegajo_Academico cLegajo_Academico;

        Modelo_Entidades.Universidad oUniversidad;
        Modelo_Entidades.Titulo oTitulo;
        Modelo_Entidades.Plan oPlan;        
        Modelo_Entidades.Matricula oMatricula;
        Modelo_Entidades.Legajo_Academico oLegajo_Academico;
        Modelo_Entidades.Profesional oProfesional;
        string modo;

        // Declaro como publico al constructor
        public FrmMatriculas(string fmodo, Modelo_Entidades.Matricula fMatricula, Modelo_Entidades.Profesional fProfesional)
        {
            InitializeComponent();

            // Creo las controladoras a usar en el formulario
            cUniversidad = Controladora.cUniversidad.ObtenerInstancia();
            cTitulo = Controladora.cTitulo.ObtenerInstancia();
            cPlan = Controladora.cPlan.ObtenerInstancia();
            cVerificacion = Controladora.cVerificacion.ObtenerInstancia();
            cMatricula = Controladora.cMatricula.ObtenerInstancia();
            cLegajo_Academico = Controladora.cLegajo_Academico.ObtenerInstancia();

            modo = fmodo;
            oMatricula = fMatricula;
            oLegajo_Academico = fMatricula.Legajo_Academico;
            oProfesional = fProfesional;

            if (modo != "Alta")
            {
                cmb_universidad.SelectedItem = oLegajo_Academico.Titulo.Universidad;
                cmb_titulos.SelectedItem = oLegajo_Academico.Titulo;
                cmb_planes.SelectedItem = oLegajo_Academico.Plan;

                if (oMatricula.certificado == true)
                {
                    rbtn_certificado.Checked = true;
                }

                else
                {
                    rbtn_diploma.Checked = true;
                }

                txt_fechadoc.Text = oMatricula.fecha_doc.ToString();

                if (oMatricula.incumbencia == true)
                {
                    chk_incumbencias.Checked = true;
                }

                else
                {
                    chk_incumbencias.Checked = false;
                }

                if (oMatricula.plan == true)
                {
                    chk_plan.Checked = true;
                }

                else
                {
                    chk_plan.Checked = false;
                }

                if (oMatricula.analitico == true)
                {
                    chk_analitico.Checked = true;
                }

                else
                {
                    chk_analitico.Checked = false;
                }
            }

            else
            {
                oLegajo_Academico = new Modelo_Entidades.Legajo_Academico();
            }
        }

        // Cuando carga el formulario
        private void FrmTitulosProfesional_Load(object sender, EventArgs e)
        {
            cmb_universidad.DataSource = cUniversidad.ObtenerUniversidades();
            cmb_universidad.DisplayMember = "descripcion";

                if (modo == "Alta")
                {
                    cmb_universidad.SelectedItem = null;

                    cmb_titulos.SelectedItem = null;

                    cmb_planes.SelectedItem = null;
                }  
        }

        // Cuando le doy click a guardar
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Validardatos())
            {
                oLegajo_Academico.Titulo = (Modelo_Entidades.Titulo)cmb_titulos.SelectedItem;
                oLegajo_Academico.Plan = (Modelo_Entidades.Plan)cmb_planes.SelectedItem;

                oMatricula.Legajo_Academico = oLegajo_Academico;

                if (rbtn_certificado.Checked == true)
                {
                    oMatricula.certificado = true;
                }

                else
                {
                    oMatricula.certificado = false;
                }

                oMatricula.fecha_doc = Convert.ToDateTime(txt_fechadoc.Text);

                if (chk_incumbencias.Checked == true)
                {
                    oMatricula.incumbencia = true;
                }

                else
                {
                    oMatricula.incumbencia = false;
                }

                if (chk_plan.Checked == true)
                {
                    oMatricula.plan = true;
                }

                else
                {
                    oMatricula.plan = false;
                }

                if (chk_analitico.Checked == true)
                {
                    oMatricula.analitico = true;
                }

                else
                {
                    oMatricula.analitico = false;
                }

                // Finalmente, agrego al profesional
                oMatricula.Profesional = oProfesional;

                int id = (cMatricula.ObtenerUltimoId()).id + 1;
                string digito = cVerificacion.AddCheckDigit(id.ToString());

                if (modo == "Alta")
                {                    
                    if (oProfesional.CtaCte == null)
                    {
                        switch (oProfesional.Matriculas.Count)
                        {
                            case 1:
                                break;
                            case 2: id = id + 1;
                                break;
                            case 3: id = id + 2;
                                break;
                            case 4: id = id + 3;
                                break;
                        }
                            
                    switch (id.ToString().Length)
                        {
                        case 1: oMatricula.icie = "2-" + "000" + id.ToString() + "-" + digito;
                            break;
                        case 2: oMatricula.icie = "2-" + "00" + id.ToString() + "-" + digito;
                            break;
                        case 3: oMatricula.icie = "2-" + "0" + id.ToString() + "-" + digito;
                            break;
                        case 4: oMatricula.icie = "2-" + id.ToString() + "-" + digito;
                            break;
                        }
                    }

                    else
                    {
                        switch (id.ToString().Length)
                        {
                            case 1: oMatricula.icie = "2-" + "000" + id.ToString() + "-" + digito;
                                break;
                            case 2: oMatricula.icie = "2-" + "00" + id.ToString() + "-" + digito;
                                break;
                            case 3: oMatricula.icie = "2-" + "0" + id.ToString() + "-" + digito;
                                break;
                            case 4: oMatricula.icie = "2-" + id.ToString() + "-" + digito;
                                break;
                        }

                        cMatricula.Alta(oMatricula);
                    }
                }

                else
                {
                    cMatricula.Modificacion(oMatricula);
                }
                
                this.DialogResult = DialogResult.OK;
            }
        }

        // Valido los datos ingresados
        private bool Validardatos()
        {
            if (cmb_universidad.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar una universidad");
                return false;
            }

            if (cmb_titulos.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar un título");
                return false;
            }

            if (cmb_planes.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar un plan");
                return false;
            }

            if (rbtn_certificado.Checked == false && rbtn_diploma.Checked == false)
            {
                MessageBox.Show("Debe ingresar un tipo de documentación para del Profesional");
                return false;
            }

            if (string.IsNullOrEmpty(txt_fechadoc.Text))
            {
                MessageBox.Show("Debe ingresar la fecha del documento presentado por el profesional");
                return false;
            }

            if (chk_incumbencias.Checked == false || chk_plan.Checked == false || chk_analitico.Checked == false)
            {
                MessageBox.Show("El profesional no cumple con todos los requisitos de matriculación.", "¡ATENCIÓN!");
                return false;
            }

            if ((cLegajo_Academico.ObtenerSiElProfTieneTit(oProfesional, ((Modelo_Entidades.Titulo)cmb_titulos.SelectedItem).id , ((Modelo_Entidades.Universidad)cmb_universidad.SelectedItem).id))  == false)
            {
                MessageBox.Show("El profesional ya posee ese título.", "¡ATENCIÓN!");
                return false;
            }

            return true;
        }

        // Cuando le doy click a cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Pongo como publico un metodo que me devuelva la matricula
        public Modelo_Entidades.Matricula MatriculaElegida
        {
            get { return oMatricula; }
        }

        // Cuando cambia el combo de planes
        private void cmb_planes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            oPlan = (Modelo_Entidades.Plan)cmb_planes.SelectedItem;
        }

        // Cuando cambia el formulario de universidades
        private void cmb_universidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            oUniversidad = (Modelo_Entidades.Universidad)cmb_universidad.SelectedItem;
            if (oUniversidad != null)
            {
                cmb_titulos.DataSource = cTitulo.BuscarTitulosPorUni(oUniversidad);
                cmb_titulos.DisplayMember = "descripcion";
            }
        }

        // Una vez que cambió el combo de universidades, cuando cambia el combo de títulos, elijo el plan de ese título
        private void cmb_titulos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            oTitulo = (Modelo_Entidades.Titulo)cmb_titulos.SelectedItem;

            if (oTitulo != null)
            {
                cmb_planes.DataSource = cLegajo_Academico.BuscarPlanesPorTit(oTitulo);
                cmb_planes.DisplayMember = "año";
            }
        }
    }
}
