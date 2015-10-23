using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Vista_Web
{
    public partial class Formulario_web17 : System.Web.UI.Page
    {
        Controladora.cProfesional cProfesional;
        Controladora.cAsistencia cAsistencia;
        Controladora.cClase cClase;
        Controladora.cCurso cCurso;

        string comision_id;
        string curso_id;
        string accion;
        string prof_dni;

        Modelo_Entidades.Profesional oProfesional;
        Modelo_Entidades.Asistencia oAsistencia;
        Modelo_Entidades.Curso oCurso;
        Modelo_Entidades.Clase oClase;

        protected void Page_Load(object sender, EventArgs e)
        {
            lb_mensaje.Visible = false;
            lb_inscripcion.Visible = false;
            lb_curso.Visible = false;
            lb_profesionales_inscriptos.Visible = false;

            curso_id = Request.QueryString["parametro1"];
            accion = Request.QueryString["parametro2"];
            comision_id = Request.QueryString["parametro3"];

            cProfesional = Controladora.cProfesional.ObtenerInstancia();
            cAsistencia = Controladora.cAsistencia.ObtenerInstancia();
            cClase = Controladora.cClase.ObtenerInstancia();
            cCurso = Controladora.cCurso.ObtenerInstancia();

            if (accion == "Inscripcion")
            {
                lb_mensaje2.Text = "Aquí puede visualizar si los profesionales se encuentran habilitados (color verde), o No Habilitados o tiene suspendida la matrícula (color rojo)";
                btn_desinscribir.Visible = false;
                btn_asentar_asistencia.Visible = false;
                gv_profesionales.DataSource = cProfesional.ObtenerProfesionales();
                gv_profesionales.DataBind();

                for (int i = 0; gv_profesionales.Rows.Count > i; i++)
                {
                    Modelo_Entidades.Profesional oProf = cProfesional.ObtenerProfesional((Convert.ToInt32(gv_profesionales.Rows[i].Cells[1].Text)));

                    if (oProf.Estado.descripcion == "Habilitado")
                    {
                        gv_profesionales.Rows[i].Cells[0].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[1].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[2].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[3].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[4].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[5].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[6].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[7].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[8].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[9].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[10].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[11].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[12].BackColor = Color.LightGreen;
                    }

                    if (oProf.Estado.descripcion == "No Habilitado" || oProf.Estado.descripcion == "Baja")
                    {
                        gv_profesionales.Rows[i].Cells[0].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[1].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[2].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[3].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[4].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[5].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[6].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[7].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[8].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[9].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[10].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[11].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[12].BackColor = Color.LightCoral;
                    }
                }
            }

            else
            {
                lb_mensaje2.Text = "Aquí puede visualizar si los profesionales han asistido más de un 75% a la clase (color verde), entre un 50 y un 75% (color amarillo) y menos de un 50% (color rojo)";
                lb_profesionales_inscriptos.Visible = true;
                lb_curso.Visible = true;
                oCurso = cCurso.ObtenerCurso(Convert.ToInt32(curso_id));
                lb_curso.Text = oCurso.descripcion;
                oClase = cClase.Obtener1ClasePorCurso(Convert.ToInt32(curso_id));
                gv_profesionales.DataSource = cProfesional.ObtenerProfesionalesPorCurso(oClase.id);
                gv_profesionales.DataBind();

                for (int i = 0; gv_profesionales.Rows.Count > i; i++)
                {
                    Modelo_Entidades.Profesional oProf = cProfesional.ObtenerProfesional((Convert.ToInt32(gv_profesionales.Rows[i].Cells[1].Text)));
                    List<Modelo_Entidades.Asistencia> ListaAsistencias = cAsistencia.ObtenerAsistenciasPorCursoyProfesional(oProf.dni, Convert.ToInt32(curso_id));
                    int asitencias = ListaAsistencias.Count;
                    List<Modelo_Entidades.Clase> ListaClases = cClase.ObtenerClasesPorCurso(Convert.ToInt32(curso_id));
                    int clases = ListaClases.Count;
                    double resultado = (asitencias * 100) / clases;

                    if (resultado >= 75)
                    {
                        gv_profesionales.Rows[i].Cells[0].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[1].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[2].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[3].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[4].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[5].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[6].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[7].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[8].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[9].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[10].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[11].BackColor = Color.LightGreen;
                        gv_profesionales.Rows[i].Cells[12].BackColor = Color.LightGreen;
                    }

                    if (50 <= resultado && resultado < 75)
                    {
                        gv_profesionales.Rows[i].Cells[0].BackColor = Color.Yellow;
                        gv_profesionales.Rows[i].Cells[1].BackColor = Color.Yellow;
                        gv_profesionales.Rows[i].Cells[2].BackColor = Color.Yellow;
                        gv_profesionales.Rows[i].Cells[3].BackColor = Color.Yellow;
                        gv_profesionales.Rows[i].Cells[4].BackColor = Color.Yellow;
                        gv_profesionales.Rows[i].Cells[5].BackColor = Color.Yellow;
                        gv_profesionales.Rows[i].Cells[6].BackColor = Color.Yellow;
                        gv_profesionales.Rows[i].Cells[7].BackColor = Color.Yellow;
                        gv_profesionales.Rows[i].Cells[8].BackColor = Color.Yellow;
                        gv_profesionales.Rows[i].Cells[9].BackColor = Color.Yellow;
                        gv_profesionales.Rows[i].Cells[10].BackColor = Color.Yellow;
                        gv_profesionales.Rows[i].Cells[11].BackColor = Color.Yellow;
                        gv_profesionales.Rows[i].Cells[12].BackColor = Color.Yellow;
                    }

                    if (resultado < 50)
                    {
                        gv_profesionales.Rows[i].Cells[0].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[1].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[2].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[3].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[4].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[5].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[6].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[7].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[8].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[9].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[10].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[11].BackColor = Color.LightCoral;
                        gv_profesionales.Rows[i].Cells[12].BackColor = Color.LightCoral;
                    }
                }

                if (accion == "Asistencia")
                {
                    btn_inscribir.Visible = false;
                    btn_desinscribir.Visible = false;
                }

                if (accion == "Inscripcion")
                {
                    btn_asentar_asistencia.Visible = false;
                    btn_desinscribir.Visible = false;
                }

                if (accion == "Desinscripcion")
                {
                    btn_inscribir.Visible = false;
                    btn_asentar_asistencia.Visible = false;
                }

                if (accion == "Ver" )
                {
                    btn_inscribir.Visible = false;
                    btn_desinscribir.Visible = false;
                    btn_asentar_asistencia.Visible = false;
                }
            }

            gv_profesionales.HeaderRow.Cells[0].Text = "Selección";
            gv_profesionales.HeaderRow.Cells[1].Text = "DNI";
            gv_profesionales.HeaderRow.Cells[2].Text = "Nombre y Apellido";
            gv_profesionales.HeaderRow.Cells[5].Text = "Teléfono";
            gv_profesionales.HeaderRow.Cells[6].Text = "Celular";
            gv_profesionales.HeaderRow.Cells[7].Text = "Email 1";
            gv_profesionales.HeaderRow.Cells[8].Text = "Email 2";
        }

        protected void gv_profesionales_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[3].Visible = false;
            e.Row.Cells[4].Visible = false;
            e.Row.Cells[9].Visible = false;
            e.Row.Cells[10].Visible = false;
            e.Row.Cells[11].Visible = false;
            e.Row.Cells[12].Visible = false;
        }

        protected void btn_inscribir_Click(object sender, EventArgs e)
        {
            if (gv_profesionales.SelectedRow != null)
            {
                prof_dni = gv_profesionales.SelectedRow.Cells[1].Text;
                oProfesional = cProfesional.ObtenerProfesional(Convert.ToInt32(prof_dni));

                // Inscribo al profesional en todas las clases de un curso dado
                foreach (Modelo_Entidades.Clase oClase in cClase.ObtenerClasesPorCurso(Convert.ToInt32(curso_id)))
                {
                    oAsistencia = new Modelo_Entidades.Asistencia();
                    oAsistencia.presente = false;
                    oAsistencia.Profesional = oProfesional;
                    oAsistencia.Clase = oClase;
                    cAsistencia.AgregarAsistencia(oAsistencia);
                }

                curso_id = Request.QueryString["parametro1"];
                oCurso = cCurso.ObtenerCurso(Convert.ToInt32(curso_id));
                oCurso.asistentes = oCurso.asistentes + 1;
                cCurso.ModificarCurso(oCurso);

                lb_inscripcion.Visible = true;
                lb_inscripcion.Text = "El profesional se ha inscripto exitosamente y la inscricion se ha sumado a los asistentes del curso";
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UN PROFESIONAL";
            }
        }

        protected void btn_volver_Click(object sender, EventArgs e)
        {
            comision_id = Request.QueryString["parametro3"];
            Response.Redirect("~/Cursos/Tablero Cursos.aspx?&parametro1=" + comision_id);
        }

        protected void gv_profesionales_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void btn_desinscribir_Click(object sender, EventArgs e)
        {
            if (gv_profesionales.SelectedRow != null)
            {
                prof_dni = gv_profesionales.SelectedRow.Cells[1].Text;
                oProfesional = cProfesional.ObtenerProfesional(Convert.ToInt32(prof_dni));

                foreach (Modelo_Entidades.Clase oClase in cClase.ObtenerClasesPorCurso(Convert.ToInt32(curso_id)))
                {
                    oAsistencia = cAsistencia.ObtenerAsistenciaPorProfyCurso(Convert.ToInt32(prof_dni), Convert.ToInt32(curso_id));
                    cAsistencia.EliminarAsistencia(oAsistencia);
                }

                curso_id = Request.QueryString["parametro1"];
                oCurso = cCurso.ObtenerCurso(Convert.ToInt32(curso_id));
                oCurso.asistentes = oCurso.asistentes - 1;
                cCurso.ModificarCurso(oCurso);

                lb_inscripcion.Visible = true;
                lb_inscripcion.Text = "El profesional se ha desinscripto exitosamente y la desinscricion se ha restado a los asistentes del curso";
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UN PROFESIONAL";
            }
        }

        protected void btn_asentar_asistencia_Click(object sender, EventArgs e)
        {
            if (gv_profesionales.SelectedRow != null)
            {
                prof_dni = gv_profesionales.SelectedRow.Cells[1].Text;
                accion = "Asistencia";
                Response.Redirect("~/Clases/Tablero Clases.aspx?&parametro1=" + curso_id + "&parametro2=" + accion + "&parametro3=" + comision_id + "&parametro4=" + prof_dni);
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UN PROFESIONAL";
            }
        }
    }
}