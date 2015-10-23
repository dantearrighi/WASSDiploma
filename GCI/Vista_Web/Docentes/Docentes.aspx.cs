using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Vista_Web
{
    public partial class Formulario_web13 : System.Web.UI.Page
    {
        Controladora.cDocente cDocente;
        Modelo_Entidades.Docente oDocente;
        string docente_id;
        string accion;

        protected void Page_Load(object sender, EventArgs e)
        {
            lb_mensaje.Visible = false;
            if (User.Identity.Name == "")
            {
                Response.Redirect("~/Account/Login.aspx");
            }

            else
            {
                cDocente = Controladora.cDocente.ObtenerInstancia();
                gv_docentes.DataSource = cDocente.ObtenerDocentes();
                gv_docentes.DataBind();

                gv_docentes.HeaderRow.Cells[0].Text = "Seleccionar";
                gv_docentes.HeaderRow.Cells[1].Text = "ID";
                gv_docentes.HeaderRow.Cells[2].Text = "Nombre y apellido";
            }
        }

        protected void btn_alta_Click(object sender, EventArgs e)
        {
            accion = "Alta";
            Response.Redirect("~/Docentes/Docente.aspx?parametro2=" + accion);
        }

        protected void btn_baja_Click(object sender, EventArgs e)
        {
            if (gv_docentes.SelectedRow != null)
            {
                docente_id = gv_docentes.SelectedRow.Cells[1].Text;
                oDocente = cDocente.ObtenerDocente(Convert.ToInt32(docente_id));
                cDocente.EliminarDocente(oDocente);
                Response.Redirect("~/Docentes/Docentes.aspx");
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UN DOCENTE";
            }
        }

        protected void btn_modificar_Click(object sender, EventArgs e)
        {
            if (gv_docentes.SelectedRow != null)
            {
                docente_id = gv_docentes.SelectedRow.Cells[1].Text;
                accion = "Modificar";
                Response.Redirect("~/Docentes/Docente.aspx?parametro1=" + docente_id + "&parametro2=" + accion);
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UN DOCENTE";
            }
        }

        protected void btn_consulta_Click(object sender, EventArgs e)
        {
            if (gv_docentes.SelectedRow != null)
            {
                docente_id = gv_docentes.SelectedRow.Cells[1].Text;
                accion = "Consultar";
                Response.Redirect("~/Docentes/Docente.aspx?parametro1=" + docente_id + "&parametro2=" + accion);
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UN DOCENTE";
            }
        }

        protected void btn_cursos_Click(object sender, EventArgs e)
        {
            if (gv_docentes.SelectedRow != null)
            {
                docente_id = gv_docentes.SelectedRow.Cells[1].Text;
                Response.Redirect("~/Cursos/Tablero Cursos.aspx?parametro1=" + docente_id);
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UN DOCENTE";
            }
        }

        protected void gv_docentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            gv_docentes.SelectedRow.Cells[0].BackColor = Color.LightGray;
            gv_docentes.SelectedRow.Cells[1].BackColor = Color.LightGray;
            gv_docentes.SelectedRow.Cells[2].BackColor = Color.LightGray;
        }
    }
}