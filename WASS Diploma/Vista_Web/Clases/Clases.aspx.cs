using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista_Web
{
    public partial class Formulario_web19 : System.Web.UI.Page
    {
       
        Controladora.cClase cClase;
        string clase_id;
        string curso_id;
        string accion;
        Modelo_Entidades.Clase oClase;
 

        protected void Page_Load(object sender, EventArgs e)
        {
            // Instancio las controladoras
            clase_id = Request.QueryString["parametro1"];
            accion = Request.QueryString["parametro2"];
            curso_id = Request.QueryString["parametro3"];

           
            cClase = Controladora.cClase.ObtenerInstancia();

            if (!(Page.IsPostBack)) // Lo que esta aca carga cuando solamente carga la página
            {                
                if (accion != "Alta")
                {
                    

                    // Busco el surso y la clase
                   
                    oClase = cClase.ObtenerClase(Convert.ToInt32(clase_id));

                    // Asigno las variables a los controles

                    if (accion == "Consultar")
                    {
                        // Deshabilito los controles
                        txt_fecha.Enabled = false;
                    }

                    txt_fecha.Text = oClase.fecha.ToShortDateString();
                }                
            }

            else
            {
                if (ValidarObligatorios() == true)
                {
                    if (accion == "Alta")
                    {
                        curso_id = Request.QueryString["parametro3"];
                        oClase = new Modelo_Entidades.Clase();
                        oClase.fecha = Convert.ToDateTime(txt_fecha.Text);
                        oCurso = cCurso.ObtenerCurso(Convert.ToInt32(curso_id));
                        oClase.Curso = oCurso;                        
                        cClase.AgregarClase(oClase);                        
                    }

                    if (accion == "Modificar")
                    {
                        clase_id = Request.QueryString["parametro1"];
                        oClase = cClase.ObtenerClase(Convert.ToInt32(clase_id));
                        oClase.fecha = Convert.ToDateTime(txt_fecha.Text);
                        cClase.ModificarClase(oClase);
                    }
                }

                Response.Redirect("~/Clases/Tablero Clases.aspx?parametro1=" + curso_id);
            }
        }

        // Valido los datos del usuario
        private bool ValidarObligatorios()
        {
            if (txt_fecha.Text == "")
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
            curso_id = Request.QueryString["parametro3"];
            accion = "Volver";
            Response.Redirect("~/Clases/Tablero Clases.aspx?parametro1=" + curso_id + "&parametro2=" + accion);
        }
    }
}