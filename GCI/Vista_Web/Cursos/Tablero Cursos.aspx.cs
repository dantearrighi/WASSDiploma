using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Vista_Web
{
    public partial class Formulario_web12 : System.Web.UI.Page
    {
        // Declaro las variables a utilizar en el formulario
        Controladora.cCurso cCurso;
        Controladora.cClase cClase;
        Controladora.cAsistencia cAsistencia;
        Controladora.cComision cComision;

        Modelo_Entidades.Curso oCurso;
        Modelo_Entidades.Comision oComi;
        string comision_id;
        string curso_id;
        string accion;

        protected void Page_Load(object sender, EventArgs e)
        {
            cCurso = Controladora.cCurso.ObtenerInstancia();
            cClase = Controladora.cClase.ObtenerInstancia();
            cAsistencia = Controladora.cAsistencia.ObtenerInstancia();
            cComision = Controladora.cComision.ObtenerInstancia();

            lb_mensaje.Visible = false;
            comision_id = Request.QueryString["parametro1"];
            oComi = cComision.ObtenerComision(Convert.ToInt32(comision_id));
            lb_comision.Text = oComi.descripcion;
            accion = Request.QueryString["parametro2"];

            gv_cursos.DataSource = cCurso.ObtenerCursoPorComision(Convert.ToInt32(comision_id));
            gv_cursos.DataBind();

            for (int i = 0; gv_cursos.Rows.Count > i; i++)
            {
                double asistentes = (Convert.ToInt32(gv_cursos.Rows[i].Cells[2].Text));
                double objetivo = (Convert.ToInt32(gv_cursos.Rows[i].Cells[4].Text));
                double resultado = (asistentes * 100) / objetivo;

                if (resultado > 75)
                {
                    gv_cursos.Rows[i].Cells[0].BackColor = Color.LightGreen;
                    gv_cursos.Rows[i].Cells[1].BackColor = Color.LightGreen;
                    gv_cursos.Rows[i].Cells[2].BackColor = Color.LightGreen;
                    gv_cursos.Rows[i].Cells[3].BackColor = Color.LightGreen;
                    gv_cursos.Rows[i].Cells[4].BackColor = Color.LightGreen;
                    gv_cursos.Rows[i].Cells[5].BackColor = Color.LightGreen;
                    gv_cursos.Rows[i].Cells[6].BackColor = Color.LightGreen;
                    gv_cursos.Rows[i].Cells[7].BackColor = Color.LightGreen;
                }

                if (50 <= resultado && resultado <= 75)
                {
                    gv_cursos.Rows[i].Cells[0].BackColor = Color.Yellow;
                    gv_cursos.Rows[i].Cells[1].BackColor = Color.Yellow;
                    gv_cursos.Rows[i].Cells[2].BackColor = Color.Yellow;
                    gv_cursos.Rows[i].Cells[3].BackColor = Color.Yellow;
                    gv_cursos.Rows[i].Cells[4].BackColor = Color.Yellow;
                    gv_cursos.Rows[i].Cells[5].BackColor = Color.Yellow;
                    gv_cursos.Rows[i].Cells[6].BackColor = Color.Yellow;
                    gv_cursos.Rows[i].Cells[7].BackColor = Color.Yellow;
                }

                if (resultado < 50)
                {
                    gv_cursos.Rows[i].Cells[0].BackColor = Color.LightCoral;
                    gv_cursos.Rows[i].Cells[1].BackColor = Color.LightCoral;
                    gv_cursos.Rows[i].Cells[2].BackColor = Color.LightCoral;
                    gv_cursos.Rows[i].Cells[3].BackColor = Color.LightCoral;
                    gv_cursos.Rows[i].Cells[4].BackColor = Color.LightCoral;
                    gv_cursos.Rows[i].Cells[5].BackColor = Color.LightCoral;
                    gv_cursos.Rows[i].Cells[6].BackColor = Color.LightCoral;
                    gv_cursos.Rows[i].Cells[7].BackColor = Color.LightCoral;
                }
            }

            if (accion != "Curso")
            {
                gv_cursos.HeaderRow.Cells[0].Text = "Selección";
                gv_cursos.HeaderRow.Cells[1].Text = "ID";
                gv_cursos.HeaderRow.Cells[2].Text = "Inscriptos";
                gv_cursos.HeaderRow.Cells[3].Text = "Cupo";
                gv_cursos.HeaderRow.Cells[4].Text = "Objetivo";
                gv_cursos.HeaderRow.Cells[5].Text = "¿Es arancelado?";
                gv_cursos.HeaderRow.Cells[6].Text = "Costo";
                gv_cursos.HeaderRow.Cells[7].Text = "Descripción";
            }
        }
        protected void gv_cursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            gv_cursos.SelectedRow.Cells[0].BackColor = Color.LightGray;
            gv_cursos.SelectedRow.Cells[1].BackColor = Color.LightGray;
            gv_cursos.SelectedRow.Cells[2].BackColor = Color.LightGray;
            gv_cursos.SelectedRow.Cells[3].BackColor = Color.LightGray;
            gv_cursos.SelectedRow.Cells[4].BackColor = Color.LightGray;
            gv_cursos.SelectedRow.Cells[5].BackColor = Color.LightGray;
            gv_cursos.SelectedRow.Cells[6].BackColor = Color.LightGray;
            gv_cursos.SelectedRow.Cells[7].BackColor = Color.LightGray;
        }

        protected void btn_alta_Click(object sender, EventArgs e)
        {
            accion = "Alta";
            Response.Redirect("~/Cursos/Cursos.aspx?&parametro1=" + curso_id + "&parametro2=" + accion + "&parametro3=" + comision_id);
        }

        protected void btn_baja_Click(object sender, EventArgs e)
        {
            if (gv_cursos.SelectedRow != null)
            {
                curso_id = gv_cursos.SelectedRow.Cells[1].Text;
                oCurso = cCurso.ObtenerCurso(Convert.ToInt32(curso_id));
                foreach (Modelo_Entidades.Clase oClase in cClase.ObtenerClasesPorCurso(oCurso.id))
                {
                    foreach (Modelo_Entidades.Asistencia oAsistencia in cAsistencia.ObtenerAsistenciasPorCurso(Convert.ToInt32(oCurso.id)))
                    {
                        cAsistencia.EliminarAsistencia(oAsistencia);
                    }

                    cClase.EliminarClase(oClase);
                }
                cCurso.EliminarCurso(oCurso);
                Response.Redirect("~/Cursos/Tablero Cursos.aspx?&parametro1=" + comision_id);
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UNA CURSO";
            }
        }

        protected void btn_modificar_Click(object sender, EventArgs e)
        {
            if (gv_cursos.SelectedRow != null)
            {
                curso_id = gv_cursos.SelectedRow.Cells[1].Text;
                accion = "Modificar";
                Response.Redirect("~/Cursos/Cursos.aspx?&parametro1=" + curso_id + "&parametro2=" + accion + "&parametro3=" + comision_id);
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UNA CURSO";
            }
        }

        protected void btn_consulta_Click(object sender, EventArgs e)
        {
            if (gv_cursos.SelectedRow != null)
            {
                curso_id = gv_cursos.SelectedRow.Cells[1].Text;
                accion = "Consultar";
                Response.Redirect("~/Cursos/Cursos.aspx?&parametro1=" + curso_id + "&parametro2=" + accion + "&parametro3=" + comision_id);
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UNA CURSO";
            }
        }

        protected void btn_inscribir_profesional_Click(object sender, EventArgs e)
        {
            if (gv_cursos.SelectedRow != null)
            {
                curso_id = gv_cursos.SelectedRow.Cells[1].Text;
                accion = "Inscripcion";
                Response.Redirect("~/Profesionales/Seleccion profesionales.aspx?&parametro1=" + curso_id + "&parametro2=" + accion + "&parametro3=" + comision_id);
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UNA CURSO";
            }
        }

        protected void btn_asistencias_Click(object sender, EventArgs e)
        {
            if (gv_cursos.SelectedRow != null)
            {
                curso_id = gv_cursos.SelectedRow.Cells[1].Text;
                accion = "Asistencia";
                Response.Redirect("~/Profesionales/Seleccion profesionales.aspx?&parametro1=" + curso_id + "&parametro2=" + accion + "&parametro3=" + comision_id);
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UNA CURSO";
            }
        }

        protected void btn_clase_Click(object sender, EventArgs e)
        {
            if (gv_cursos.SelectedRow != null)
            {
                curso_id = gv_cursos.SelectedRow.Cells[1].Text;
                accion = "Ver";
                Response.Redirect("~/Clases/Tablero Clases.aspx?&parametro1=" + curso_id + "&parametro2=" + accion + "&parametro3=" + comision_id);
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UNA CURSO";
            }
        }

        protected void btn_desinscribir_profesional_Click(object sender, EventArgs e)
        {
            if (gv_cursos.SelectedRow != null)
            {
                curso_id = gv_cursos.SelectedRow.Cells[1].Text;
                accion = "Desinscripcion";
                Response.Redirect("~/Profesionales/Seleccion profesionales.aspx?&parametro1=" + curso_id + "&parametro2=" + accion + "&parametro3=" + comision_id);
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UNA CURSO";
            }
        }

        protected void btn_inscriptos_Click(object sender, EventArgs e)
        {
            if (gv_cursos.SelectedRow != null)
            {
                curso_id = gv_cursos.SelectedRow.Cells[1].Text;
                accion = "Ver";
                Response.Redirect("~/Profesionales/Seleccion profesionales.aspx?&parametro1=" + curso_id + "&parametro2=" + accion + "&parametro3=" + comision_id);
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UNA CURSO";
            }
        }
    }
}