using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista_Web
{
    public partial class Formulario_web14 : System.Web.UI.Page
    {
        Controladora.cDocente cDocente;
        Modelo_Entidades.Docente oDocente;
        string id_Docente;
        string accion;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Instancio las controladoras
            cDocente = Controladora.cDocente.ObtenerInstancia();
            accion = Request.QueryString["parametro2"];

            if(!(Page.IsPostBack))
            {
            // Según la accion habilito o deshabilito los controles
                switch (accion)
                {
                    case "Modificar":
                        //Recibo el id de la Docente
                        id_Docente = Request.QueryString["parametro1"];                    
                        // Busco la comisión
                        oDocente = cDocente.ObtenerDocente(Convert.ToInt32(id_Docente));
                        // Asigno las variables a los controles
                        lb_docente.Text = oDocente.nombre_apellido;
                        txt_nombre.Text = oDocente.nombre_apellido;
                        break;

                    case "Consultar":
                        //Recibo el id de la Docente
                        id_Docente = Request.QueryString["parametro1"];
                        // Busco la comisión
                        oDocente = cDocente.ObtenerDocente(Convert.ToInt32(id_Docente));
                        // Asigno las variables a los controles
                        lb_docente.Text = oDocente.nombre_apellido;
                        txt_nombre.Text = oDocente.nombre_apellido;
                        // Deshabilito los controles
                        txt_nombre.Enabled = false;
                        break;

                    case "Alta":
                        // Asigno las variables a los controles
                        lb_docente.Visible = false;
                        break;
                }
            }

            else
            {
                if (ValidarObligatorios() == true)
                {
                    if (accion == "Alta")
                    {
                        oDocente = new Modelo_Entidades.Docente();
                        oDocente.nombre_apellido = txt_nombre.Text;
                        cDocente.AgregarDocente(oDocente);
                    }

                    if (accion == "Modificar")
                    {
                        id_Docente = Request.QueryString["parametro1"];
                        oDocente = cDocente.ObtenerDocente(Convert.ToInt32(id_Docente));
                        oDocente.nombre_apellido = txt_nombre.Text;
                        cDocente.ModificarDocente(oDocente);
                    }
                }
            }
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        // Valido los datos del usuario
        private bool ValidarObligatorios()
        {
            if (string.IsNullOrEmpty(txt_nombre.Text))
            {
                return false;
            }

            return true;
        }
    }
}