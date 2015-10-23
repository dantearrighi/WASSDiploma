using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista_Web
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        Controladora.cComision cComision;
        Modelo_Entidades.Comision oComision;
        string id_comision;
        string accion;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Instancio las controladoras
            cComision = Controladora.cComision.ObtenerInstancia();
            accion = Request.QueryString["parametro2"];

            if(!(Page.IsPostBack))
            {
            // Según la accion habilito o deshabilito los controles
                switch (accion)
                {
                    case "Modificar":
                        //Recibo el id de la comision
                        id_comision = Request.QueryString["parametro1"];                    
                        // Busco la comisión
                        oComision = cComision.ObtenerComision(Convert.ToInt32(id_comision));
                        // Asigno las variables a los controles
                        lb_comision.Text = oComision.descripcion;
                        txt_nombre.Text = oComision.descripcion;
                        txt_dinero_asignado.Text = oComision.dinero_asignado.ToString();
                        txt_dinero_gastado.Text = oComision.dinero_gastado.ToString();
                        break;

                    case "Consultar":
                        //Recibo el id de la comision
                        id_comision = Request.QueryString["parametro1"];
                        // Busco la comisión
                        oComision = cComision.ObtenerComision(Convert.ToInt32(id_comision));
                        // Asigno las variables a los controles
                        lb_comision.Text = oComision.descripcion;
                        txt_nombre.Text = oComision.descripcion;
                        txt_dinero_asignado.Text = oComision.dinero_asignado.ToString();
                        txt_dinero_gastado.Text = oComision.dinero_gastado.ToString();
                        // Deshabilito los controles
                        txt_nombre.Enabled = false;
                        txt_dinero_asignado.Enabled = false;
                        txt_dinero_gastado.Enabled = false;
                        break;

                    case "Alta":
                        // Asigno las variables a los controles
                        lb_comision.Visible = false;
                        break;
                }
            }

            else
            {
                if (ValidarObligatorios() == true)
                {
                    if (accion == "Alta")
                    {
                        oComision = new Modelo_Entidades.Comision();
                        oComision.descripcion = txt_nombre.Text;
                        oComision.dinero_asignado = Convert.ToDecimal(txt_dinero_asignado.Text);
                        oComision.dinero_gastado = Convert.ToDecimal(txt_dinero_gastado.Text);
                        cComision.AgregarComision(oComision);
                        //Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alertMessage", "alert('La comisión se ha cargado correctamente')", true);                                  
                    }

                    if (accion == "Modificar")
                    {
                        id_comision = Request.QueryString["parametro1"];
                        oComision = cComision.ObtenerComision(Convert.ToInt32(id_comision));
                        oComision.descripcion = txt_nombre.Text;
                        oComision.dinero_asignado = Convert.ToDecimal(txt_dinero_asignado.Text);
                        oComision.dinero_gastado = Convert.ToDecimal(txt_dinero_gastado.Text);
                        cComision.ModificarComision(oComision);
                    }
                }

                Response.Redirect("~/Comisiones/Tablero Comisiones.aspx");   
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

            if (string.IsNullOrEmpty(txt_dinero_asignado.Text))
            {
                return false;
            }

            if (string.IsNullOrEmpty(txt_dinero_gastado.Text))
            {
                return false;
            }

            return true;
        }
    }
}