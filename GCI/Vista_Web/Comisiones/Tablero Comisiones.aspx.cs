using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Vista_Web
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        // Declaro las variables a utilizar en el formulario
        Controladora.cComision cComision;
        Controladora.cAsistencia cAsistencia;
        Controladora.cCurso cCurso;
        Controladora.cClase cClase;
        Modelo_Entidades.Comision oComision;
        string comision_id;
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

                cComision = Controladora.cComision.ObtenerInstancia();
                cAsistencia = Controladora.cAsistencia.ObtenerInstancia();
                cCurso = Controladora.cCurso.ObtenerInstancia();
                cClase = Controladora.cClase.ObtenerInstancia();
                gv_comisiones.DataSource = cComision.ObtenerComisiones();
                gv_comisiones.DataBind();

                for (int i = 0; gv_comisiones.Rows.Count > i; i++)
                {
                    double total = (Convert.ToDouble(gv_comisiones.Rows[i].Cells[3].Text));
                    double gastado = (Convert.ToDouble(gv_comisiones.Rows[i].Cells[4].Text));
                    double resultado = (gastado * 100) / total;

                    if (resultado > 75)
                    {
                        gv_comisiones.Rows[i].Cells[0].BackColor = Color.LightCoral;
                        gv_comisiones.Rows[i].Cells[1].BackColor = Color.LightCoral;
                        gv_comisiones.Rows[i].Cells[2].BackColor = Color.LightCoral;
                        gv_comisiones.Rows[i].Cells[3].BackColor = Color.LightCoral;
                        gv_comisiones.Rows[i].Cells[4].BackColor = Color.LightCoral;
                    }

                    if (50 <= resultado && resultado <= 75)
                    {
                        gv_comisiones.Rows[i].Cells[0].BackColor = Color.Yellow;
                        gv_comisiones.Rows[i].Cells[1].BackColor = Color.Yellow;
                        gv_comisiones.Rows[i].Cells[2].BackColor = Color.Yellow;
                        gv_comisiones.Rows[i].Cells[3].BackColor = Color.Yellow;
                        gv_comisiones.Rows[i].Cells[4].BackColor = Color.Yellow;
                    }

                    if (resultado < 50)
                    {
                        gv_comisiones.Rows[i].Cells[0].BackColor = Color.LightGreen;
                        gv_comisiones.Rows[i].Cells[1].BackColor = Color.LightGreen;
                        gv_comisiones.Rows[i].Cells[2].BackColor = Color.LightGreen;
                        gv_comisiones.Rows[i].Cells[3].BackColor = Color.LightGreen;
                        gv_comisiones.Rows[i].Cells[4].BackColor = Color.LightGreen;
                    }
                }

                gv_comisiones.HeaderRow.Cells[0].Text = "Selección";
                gv_comisiones.HeaderRow.Cells[1].Text = "ID";
                gv_comisiones.HeaderRow.Cells[2].Text = "Comisión";
                gv_comisiones.HeaderRow.Cells[3].Text = "Dinero asignado";
                gv_comisiones.HeaderRow.Cells[4].Text = "Dinero gastado";

                lb_total.Text = "$ " + cComision.ObtenerTotalComisiones().ToString();
            }
        }

        protected void btn_modificar_Click(object sender, EventArgs e)
        {
            if (gv_comisiones.SelectedRow != null)
            {
                comision_id = gv_comisiones.SelectedRow.Cells[1].Text;
                accion = "Modificar";
                Response.Redirect("~/Comisiones/Comisiones.aspx?parametro1=" + comision_id + "&parametro2=" + accion);
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UNA COMISIÓN";
            }
        }

        protected void btn_baja_Click(object sender, EventArgs e)
        {
            if (gv_comisiones.SelectedRow != null)
            {
                comision_id = gv_comisiones.SelectedRow.Cells[1].Text;
                oComision = cComision.ObtenerComision(Convert.ToInt32(comision_id));
                foreach (Modelo_Entidades.Curso oCurso in cCurso.ObtenerCursoPorComision(oComision.id))
                {
                    foreach (Modelo_Entidades.Clase oClase in cClase.ObtenerClasesPorCurso(oCurso.id))
                    {
                        foreach (Modelo_Entidades.Asistencia oAsistencia in cAsistencia.ObtenerAsistenciasPorCurso(Convert.ToInt32(oCurso.id)))
                        {
                            cAsistencia.EliminarAsistencia(oAsistencia);
                        }

                        cClase.EliminarClase(oClase);
                    }

                    cCurso.EliminarCurso(oCurso);
                }
                cComision.EliminarComision(oComision);
                Response.Redirect("~/Comisiones/Tablero Comisiones.aspx");
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UNA COMISIÓN";
            }
        }

        protected void btn_consulta_Click(object sender, EventArgs e)
        {
            if (gv_comisiones.SelectedRow != null)
            {
                comision_id = gv_comisiones.SelectedRow.Cells[1].Text;
                accion = "Consultar";
                Response.Redirect("~/Comisiones/Comisiones.aspx?parametro1=" + comision_id + "&parametro2=" + accion);
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UNA COMISIÓN";
            }
        }

        protected void btn_alta_Click(object sender, EventArgs e)
        {
            accion = "Alta";
            Response.Redirect("~/Comisiones/Comisiones.aspx?parametro2=" + accion);
        }

        protected void btn_cursos_Click(object sender, EventArgs e)
        {
            if (gv_comisiones.SelectedRow != null)
            {
                comision_id = gv_comisiones.SelectedRow.Cells[1].Text;
                accion = "Curso";
                Response.Redirect("~/Cursos/Tablero Cursos.aspx?parametro1=" + comision_id + "&parametro2=" + accion);
            }

            else
            {
                lb_mensaje.Visible = true;
                lb_mensaje.Text = "DEBE SELECCIONAR UNA COMISIÓN";
            }
        }

        protected void gv_comisiones_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[1].Visible = false;
        }

        protected void gv_comisiones_SelectedIndexChanged1(object sender, EventArgs e)
        {
            gv_comisiones.SelectedRow.Cells[0].BackColor = Color.LightGray;
            gv_comisiones.SelectedRow.Cells[1].BackColor = Color.LightGray;
            gv_comisiones.SelectedRow.Cells[2].BackColor = Color.LightGray;
            gv_comisiones.SelectedRow.Cells[3].BackColor = Color.LightGray;
            gv_comisiones.SelectedRow.Cells[4].BackColor = Color.LightGray;   
        }
    }
}