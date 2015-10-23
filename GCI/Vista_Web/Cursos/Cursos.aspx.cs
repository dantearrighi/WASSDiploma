using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista_Web
{
    public partial class Formulario_web15 : System.Web.UI.Page
    {
        Controladora.cCurso cCurso;
        Controladora.cDocente cDoncete;
        Controladora.cComision cComision;
        Controladora.cClase cClase;

        Modelo_Entidades.Curso oCurso;
        Modelo_Entidades.Docente oDocente;
        Modelo_Entidades.Comision oComision;

        string id_Curso;
        string id_comision;
        string accion;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Instancio las controladoras
            cCurso = Controladora.cCurso.ObtenerInstancia();
            cDoncete = Controladora.cDocente.ObtenerInstancia();
            cComision = Controladora.cComision.ObtenerInstancia();
            cClase = Controladora.cClase.ObtenerInstancia();

            id_Curso = Request.QueryString["parametro1"];
            accion = Request.QueryString["parametro2"];
            id_comision = Request.QueryString["parametro3"];

            if (!(Page.IsPostBack)) // Lo que esta aca carga cuando solamente carga la página
            {
                ddl_doncentes.DataSource = cDoncete.ObtenerDocentes();
                ddl_doncentes.DataTextField = "nombre_apellido";
                ddl_doncentes.DataBind();

                ddl_comision.DataSource = cComision.ObtenerComisiones();
                ddl_comision.DataTextField = "descripcion";
                ddl_comision.DataBind();

                // Según la accion habilito o deshabilito los controles
                if (accion != "Alta")
                {
                        // Busco la comisión
                        id_Curso = Request.QueryString["parametro1"];
                        oCurso = cCurso.ObtenerCurso(Convert.ToInt32(id_Curso));
                        // Asigno las variables a los controles
                        lb_Curso.Text = oCurso.descripcion;
                        txt_nombre.Text = oCurso.descripcion;
                        txt_objetivo.Text = oCurso.objetivo.ToString();
                        if (oCurso.arancelado == false)
                        {
                            chk_arancelado.Checked = false;
                        }
                        else
                        {
                            chk_arancelado.Checked = true;
                        }
                        txt_costo.Text = oCurso.costo.ToString();
                        ddl_doncentes.SelectedValue = oCurso.Docente.nombre_apellido;
                        ddl_comision.SelectedValue = oCurso.Comision.descripcion;

                    if (accion == "Consultar")
                    {
                        // Deshabilito los controles
                        txt_nombre.Enabled = false;
                        txt_costo.Enabled = false;
                        txt_objetivo.Enabled = false;
                        ddl_comision.Enabled = false;
                        ddl_doncentes.Enabled = false;
                        chk_arancelado.Enabled = false;
                    }
                }

                else
                {
                    lb_Curso.Visible = false;
                }
            }

            else
            {
                if (ValidarObligatorios() == true)
                {
                    oDocente = cDoncete.ObtenerDocentePorNombre(ddl_doncentes.SelectedValue);
                    oComision = cComision.ObtenerComisionPorDesc(ddl_comision.SelectedValue);

                    if (accion == "Alta")
                    {
                        oCurso = new Modelo_Entidades.Curso();
                        oCurso.descripcion = txt_nombre.Text;
                        oCurso.objetivo = Convert.ToInt32(txt_objetivo.Text);
                        oCurso.costo = Convert.ToInt32(txt_costo.Text);
                        oCurso.asistentes = 0;
                        oCurso.cupo = 35;
                        if (chk_arancelado.Checked == false)
                        {
                            oCurso.arancelado = false;
                        }
                        else
                        {
                            oCurso.arancelado = true;
                        }
                        oCurso.Docente = oDocente;
                        oCurso.Comision = oComision;
                        cCurso.AgregarCurso(oCurso);
                        id_comision = Request.QueryString["parametro3"];
                        Response.Redirect("~/Cursos/Tablero Cursos.aspx?&parametro1=" + id_comision);
                    }

                    if (accion == "Modificar")
                    {
                        id_Curso = Request.QueryString["parametro1"];
                        oCurso = cCurso.ObtenerCurso(Convert.ToInt32(id_Curso));
                        oCurso.descripcion = txt_nombre.Text;
                        oCurso.objetivo = Convert.ToInt32(txt_objetivo.Text);
                        oCurso.costo = Convert.ToInt32(txt_costo.Text);
                        if (chk_arancelado.Checked == false)
                        {
                            oCurso.arancelado = false;
                        }
                        else
                        {
                            oCurso.arancelado = true;
                        }
                        oCurso.Docente = oDocente;
                        oCurso.Comision = oComision;
                        cCurso.ModificarCurso(oCurso);
                        id_comision = Request.QueryString["parametro3"];
                        Response.Redirect("~/Cursos/Tablero Cursos.aspx?&parametro1=" + id_comision);
                    }
                }
            }
        }

        // Valido los datos del usuario
        private bool ValidarObligatorios()
        {
            if (string.IsNullOrEmpty(txt_nombre.Text))
            {
                return false;
            }

            if (string.IsNullOrEmpty(txt_objetivo.Text))
            {
                return false;
            }

            if (string.IsNullOrEmpty(txt_costo.Text))
            {
                return false;
            }

            return true;
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        protected void btn_volver_Click(object sender, EventArgs e)
        {
            accion = "Volver";
            id_comision = Request.QueryString["parametro3"];
            Response.Redirect("~/Cursos/Tablero Cursos.aspx?&parametro1=" + id_comision + "&parametro2=" + accion);
        }
    }
}