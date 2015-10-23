using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Vista_Web
{
    public partial class Formulario_web18 : System.Web.UI.Page
    {
        Controladora.cCurso cCurso;
        Controladora.cClase cClase;
        Controladora.cAsistencia cAsistencia;
        Controladora.cProfesional cProfesional;
        
        string curso_id;
        string clase_id;
        string accion;
        string comision_id;
        string prof_dni;

        Modelo_Entidades.Clase oClase;
        Modelo_Entidades.Asistencia oAsistencia;
        Modelo_Entidades.Curso oCurso;

        protected void Page_Load(object sender, EventArgs e)
        {
            cCurso = Controladora.cCurso.ObtenerInstancia();
            cClase = Controladora.cClase.ObtenerInstancia();
            cAsistencia = Controladora.cAsistencia.ObtenerInstancia();
            cProfesional = Controladora.cProfesional.ObtenerInstancia();

            lb_mensaje.Visible = false;

            curso_id = Request.QueryString["parametro1"];
            oCurso = cCurso.ObtenerCurso(Convert.ToInt32(curso_id));
            lb_curso.Text = oCurso.descripcion;

            accion = Request.QueryString["parametro2"];
            comision_id = Request.QueryString["parametro3"];
            prof_dni = Request.QueryString["parametro4"];


            gv_clases.DataSource = cClase.ObtenerClasesPorCurso(Convert.ToInt32(curso_id));
            gv_clases.DataBind();

            for (int i = 0; gv_clases.Rows.Count > i; i++)
            {
                Modelo_Entidades.Clase oCla = cClase.ObtenerClase((Convert.ToInt32(gv_clases.Rows[i].Cells[1].Text)));
                List<Modelo_Entidades.Asistencia> ListaAsistencias = cAsistencia.ObtenerAsistenciasPorClaseyCurso(oCla.id, Convert.ToInt32(curso_id));
                int asitencias = ListaAsistencias.Count;
                List<Modelo_Entidades.Profesional> ListaInscriptos = cProfesional.ObtenerProfesionalesPorCurso(oCla.id);
                int inscriptos = ListaInscriptos.Count;
                double resultado = (asitencias * 100) / inscriptos;


                if (resultado > 75)
                {
                    gv_clases.Rows[i].Cells[0].BackColor = Color.LightCoral;
                    gv_clases.Rows[i].Cells[1].BackColor = Color.LightCoral;
                    gv_clases.Rows[i].Cells[2].BackColor = Color.LightCoral;
                }

                if (50 <= resultado && resultado <= 75)
                {
                    gv_clases.Rows[i].Cells[0].BackColor = Color.Yellow;
                    gv_clases.Rows[i].Cells[1].BackColor = Color.Yellow;
                    gv_clases.Rows[i].Cells[2].BackColor = Color.Yellow;
                }

                if (resultado < 50)
                {
                    gv_clases.Rows[i].Cells[0].BackColor = Color.LightGreen;
                    gv_clases.Rows[i].Cells[1].BackColor = Color.LightGreen;
                    gv_clases.Rows[i].Cells[2].BackColor = Color.LightGreen;;
                }
            }

            gv_clases.HeaderRow.Cells[0].Text = "Selección";
            gv_clases.HeaderRow.Cells[1].Text = "ID";
            gv_clases.HeaderRow.Cells[2].Text = "Fecha";

            if (accion == "Ver")
            {
                btn_dar_presente.Visible = false;
                btn_dar_ausente.Visible = false;
            }

            if (accion == "Asistencia")
            {             
                btn_alta.Visible = false;
                btn_baja.Visible = false;
                btn_modificar.Visible = false;
                btn_consulta.Visible = false;
            }
        }


        protected void btn_alta_Click(object sender, EventArgs e)
        {
            accion = "Alta";
            Response.Redirect("~/Clases/Clases.aspx?parametro1=" + clase_id + "&parametro2=" + accion + "&parametro3=" + curso_id);
        }

        protected void btn_baja_Click(object sender, EventArgs e)
        {
            if (gv_clases.SelectedRow != null)
            {
                clase_id = gv_clases.SelectedRow.Cells[1].Text;
                oClase = cClase.ObtenerClase(Convert.ToInt32(clase_id));
                // Inscribo al profesional en todas las clases de un curso dado
                foreach (Modelo_Entidades.Asistencia oAsistencia in cAsistencia.ObtenerAsistenciasPorCurso(Convert.ToInt32(curso_id)))
                {
                    cAsistencia.EliminarAsistencia(oAsistencia);
                }
                cClase.EliminarClase(oClase);
                Response.Redirect("~/Clases/Tablero Clases.aspx?parametro1=" + curso_id);
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UNA CLASE";
            }
        }

        protected void btn_modificar_Click(object sender, EventArgs e)
        {
            if (gv_clases.SelectedRow != null)
            {
                clase_id = gv_clases.SelectedRow.Cells[1].Text;
                accion = "Modificar";
                Response.Redirect("~/Clases/Clases.aspx?parametro1=" + clase_id + "&parametro2=" + accion + "&parametro3=" + curso_id);
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UNA CLASE";
            }
        }

        protected void btn_consulta_Click(object sender, EventArgs e)
        {
            if (gv_clases.SelectedRow != null)
            {
                clase_id = gv_clases.SelectedRow.Cells[1].Text;
                accion = "Consultar";
                Response.Redirect("~/Clases/Clases.aspx?parametro1=" + clase_id + "&parametro2=" + accion + "&parametro3=" + curso_id);
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UNA CLASE";
            }
        }

        protected void btn_volver_Click(object sender, EventArgs e)
        {
            comision_id = Request.QueryString["parametro3"];
            Response.Redirect("~/Cursos/Tablero Cursos.aspx?&parametro1=" + comision_id);
        }

        protected void btn_dar_presente_Click(object sender, EventArgs e)
        {
            if (gv_clases.SelectedRow != null)
            {
                clase_id = gv_clases.SelectedRow.Cells[1].Text;
                oAsistencia = cAsistencia.ObtenerAsistenciaPorProfyCurso(Convert.ToInt32(prof_dni), Convert.ToInt32(curso_id));
                oAsistencia.presente = true;
                cAsistencia.ModificarAsistencia(oAsistencia);
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "El profesional ahora esta presente en la clase";
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UNA CLASE";
            }
        }

        protected void btn_dar_ausente_Click(object sender, EventArgs e)
        {
            if (gv_clases.SelectedRow != null)
            {
                clase_id = gv_clases.SelectedRow.Cells[1].Text;
                oAsistencia = cAsistencia.ObtenerAsistenciaPorProfyCurso(Convert.ToInt32(prof_dni), Convert.ToInt32(curso_id));
                oAsistencia.presente = false;
                cAsistencia.ModificarAsistencia(oAsistencia);

                lb_mensaje.Visible = true;
                lb_mensaje.Text = "El profesional ahora no esta presente en la clase";
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UNA CLASE";
            }
        }
    }
}