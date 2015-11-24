
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WASSTD
{
    public partial class FrmPersona : Form
    {
        // Declaro las variables que voy a utilizar en el formulario.
        string modo;

        // Declaro las controladoras a utilizar en el formulario
        Controladora.cPersona cPersona;
        Controladora.cGrupo cGrupo;
        Controladora.cTipo_Documento cTipo_Documento;
        Controladora.cProvincia cProvincia;
        Controladora.cLocalidad cLocalidad;
        Controladora.cEstado cEstado;
        Controladora.cVerificacion cVerificacion;
   
        Controladora.cMovimiento cMovimiento;
        Controladora.cCtaCte cCtaCte;
        
        Controladora.cTipo_Movimiento cTipo_Movimiento;
        Controladora.cAuditoria cAuditoria;

        // Declaro las entidades
        Modelo_Entidades.Persona oPersona;
       
        Modelo_Entidades.Direccion oDireccion;
        Modelo_Entidades.Direccion oDireccionE;
        //Modelo_Entidades.CtaCte oCtaCte;
        Modelo_Entidades.Usuario miUsuario;
        

        List<Modelo_Entidades.Movimiento> ListaMovimientos = new List<Modelo_Entidades.Movimiento>();

        
        

        

        // Declaro como publico al constructor
        public FrmPersona(string fModo, Modelo_Entidades.Persona miPersona, Modelo_Entidades.Usuario oUsuario)
        {
            InitializeComponent();

            // Inicializo a las controladoras
            cPersona = Controladora.cPersona.ObtenerInstancia();
            cGrupo = Controladora.cGrupo.ObtenerInstancia();
            cTipo_Documento = Controladora.cTipo_Documento.ObtenerInstancia();
            cProvincia = Controladora.cProvincia.ObtenerInstancia();
            cLocalidad = Controladora.cLocalidad.ObtenerInstancia();
            cEstado = Controladora.cEstado.ObtenerInstancia();
            
            cVerificacion = Controladora.cVerificacion.ObtenerInstancia();
            cMovimiento = Controladora.cMovimiento.ObtenerInstancia();
            cCtaCte = Controladora.cCtaCte.ObtenerInstancia();
          
            cTipo_Movimiento = Controladora.cTipo_Movimiento.ObtenerInstancia();
            cAuditoria = Controladora.cAuditoria.ObtenerInstancia();

            modo = fModo;
            oPersona = miPersona;
            miUsuario = oUsuario;
        }

        // Al cargar el formulario
        private void FrmPersona_Load(object sender, EventArgs e)
        {
            

            // Controles asociados a los datos del Persona que contienen listas
            cmb_tiposdoc.DataSource = cTipo_Documento.ObtenerTipos_Documentos();
            cmb_tiposdoc.DisplayMember = "descripcion";
            cmb_tiposdoc.SelectedItem = null;

            cmb_provincias.DataSource = cProvincia.ObtenerProvincias();
            cmb_provincias.DisplayMember = "descripcion";
            cmb_provincias.SelectedItem = null;

            cmb_localidades.DataSource = cLocalidad.ObtenerLocalidades();
            cmb_localidades.DisplayMember = "descripcion";
            cmb_localidades.SelectedItem = null;

            
          

          

            
           
           

            if (modo != "Alta")
            {
                // Inhabilito el DNI
                txt_numero.Enabled = false;

                ArmaFormulario(oPersona);
           

                if (modo == "Consulta")
                {
                   
                    btn_guardar.Enabled = false;
                    btn_cancelar.Text = "Cerrar";
                  
                }
            }

            else
            {
                txt_numero.Enabled = true;
               
            }
        }

        // Al hacer click en cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        // Al hacer click en guardar
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (ValidarObligatorios() == true)
            {
                try
                {
                    #region Datos personales de la Persona
                oPersona.Tipo_Documento = (Modelo_Entidades.Tipo_Documento)cmb_tiposdoc.SelectedItem;
                oPersona.dni = Convert.ToInt32(txt_numero.Text);
                oPersona.nombre_apellido = txt_nombreapellido.Text;
                oPersona.observaciones = txt_observaciones.Text;
          //      oPersona.fecha_nacimiento = Convert.ToDateTime(txt_fechanacimiento.Text);

                if (rbtn_masculino.Checked == true)
                {
                    oPersona.sexo = "Masculino";
                }

                else
                {
                    oPersona.sexo = "Femenino";
                }

                if (modo == "Alta")
                {
                    oDireccion = new Modelo_Entidades.Direccion();
                    oDireccion.direccion = txt_direccion.Text;
                    oDireccion.Localidad = (Modelo_Entidades.Localidad)cmb_localidades.SelectedItem;
                    oPersona.Direcciones.Add(oDireccion);

                    oDireccionE = new Modelo_Entidades.Direccion();
                    oDireccionE.direccion = txt_direccion.Text;
                    oDireccionE.Localidad = (Modelo_Entidades.Localidad)cmb_localidades.SelectedItem;
                    oPersona.Direcciones.Add(oDireccionE);
                }

                else
                {
                    oDireccion = oPersona.Direcciones.ElementAt(0);
                    oDireccion.Localidad = (Modelo_Entidades.Localidad)cmb_localidades.SelectedItem;
                    oDireccion.direccion = txt_direccion.Text;
                    oPersona.Direcciones.ElementAt(0).Equals(oDireccion);

                    
                }
                    
                oPersona.telefono = txt_telfijo.Text;
                oPersona.celular = txt_celular.Text;
                oPersona.email1 = txt_emailpricipal.Text;
                oPersona.Estado = cEstado.ObtenerEstadoHabilitado();
              
                #endregion

                   

                    #region Contabilidad del Persona

             /*   if (modo == "Alta")
                {
                    // Doy de alta a la cta cte
                    Modelo_Entidades.CtaCte oCtaCte = new Modelo_Entidades.CtaCte();
                    oCtaCte.saldo = 0;
                    oCtaCte.Persona = oPersona.CtaCte.Movimientos;
                    oPersona.CtaCte = oCtaCte;
                }
                    */
                #endregion

             

                    if (modo == "Alta")
                    {
                        cPersona.Alta(oPersona);                    

                       

                        MessageBox.Show("La Persona se ha agregado correctamente");
                    }

                    else
                    {
                        cPersona.Modificacion(oPersona);
                        MessageBox.Show("La Persona se ha modificado correctamente");
                    }               

                    this.DialogResult = DialogResult.OK;

                    }

                catch (Exception Exc)
                {
                    MessageBox.Show(Exc.Message.ToString());
                }
            }
        }

        // Valido los datos del Persona
        private bool ValidarObligatorios()
        {
            #region Datos personales
            if (cmb_tiposdoc.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar un tipo de documento para el Persona");
                return false;
            }

            if (string.IsNullOrEmpty(txt_numero.Text))
            {
                MessageBox.Show("Debe ingresar el número de DNI del Persona");
                return false;
            }

            // Valido que no exista un Persona con un DNI igual
            if (cPersona.ValidarPersona(Convert.ToInt32(txt_numero.Text)) == false)
            {
                if (oPersona.dni != Convert.ToInt32(txt_numero.Text))
                {
                    MessageBox.Show("Ya existe un Persona con el DNI introducido");
                    return false;
                }
            }

            if (string.IsNullOrEmpty(txt_nombreapellido.Text))
            {
                MessageBox.Show("Debe ingresar el nombre y apellido del Persona");
                return false;
            }

            if (Regex.IsMatch(txt_nombreapellido.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("El nombre y el apellido solo pueden contener letras");
                return false;
            }

            if (string.IsNullOrEmpty(txt_fechanacimiento.Text))
            {
                MessageBox.Show("Debe ingresar la fecha de nacimiento del Persona");
                return false;
            }

            if (rbtn_femenino.Checked == false && rbtn_masculino.Checked == false)
            {
                MessageBox.Show("Debe ingresar un tipo de género para del Persona");
                return false;
            }

            if (cmb_provincias.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar la provincia donde reside el Persona");
                return false;
            }

            if (cmb_localidades.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar la provincia donde reside el Persona");
                return false;
            }

            if (string.IsNullOrEmpty(txt_direccion.Text))
            {
                MessageBox.Show("Debe ingresar la dirección de la Persona");
                return false;
            }

          

            if (cmb_localidades.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar la localidad de envío de la boleta del Persona");
                return false;
            }

           

            if (string.IsNullOrEmpty(txt_telfijo.Text) || string.IsNullOrEmpty(txt_celular.Text))
            {
                MessageBox.Show("Debe ingresar al menos un número de contacto telefónico para comunicarse con el Persona");
                return false;
            }

            if (string.IsNullOrEmpty(txt_emailpricipal.Text))
            {

                MessageBox.Show("Debe ingresar un correo electrónico de contacto para comunicarse con el Persona");
                return false;
            }

            string expresionregular = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            if (!(Regex.IsMatch(this.txt_emailpricipal.Text, expresionregular))) //si el mail no concuerda con la expresion regular
            {
                this.txt_emailpricipal.Focus();
                MessageBox.Show("El E-Mail ingresado tiene un formato incorrecto.", "Faltan Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            #endregion

         
            return true;
        }

        // Cuando el usuario le da click al check box de la misma dirección de envío (para no tener que volver a cargar)
        private void chk_mismolugar_CheckedChanged(object sender, EventArgs e)
        {
            if ((Modelo_Entidades.Localidad)cmb_localidades.SelectedItem == null)
            {
                return;
            }

           
        }

        // Al dejar un valor en el combo de localidades, se llena el código postal
        

        // Al dejar un valor en el combo de localidades, se llena el código postal
        private void cmb_localidades_Leave(object sender, EventArgs e)
        {
            Modelo_Entidades.Localidad oLocalidad = (Modelo_Entidades.Localidad)cmb_localidades.SelectedItem;
            if ((Modelo_Entidades.Localidad)cmb_localidades.SelectedItem == null)
            {
                return;
            }
            else
            {
                txt_cp.Text = oLocalidad.cp.ToString();
            }
            
        }

        // Al cerrar el formulario
        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // Al dejar un valor en el combo de provincias, se llena el combo de localidades de esa provincia
        private void cmb_provincias_Leave(object sender, EventArgs e)
        {
            Modelo_Entidades.Provincia oProvincia = (Modelo_Entidades.Provincia)cmb_provincias.SelectedItem;
            if (oProvincia == null)
            {
                return;
            }

            else
            {
                cmb_localidades.DataSource = oProvincia.Localidades;
                cmb_localidades.DisplayMember = "descripcion";
                cmb_localidades.SelectedItem = null;
            }
        }

        // Al dejar un valor en el combo de provincias, se llena el combo de localidades de esa provincia
        

       


        // Armo el formulario (si no es una alta)
        private void ArmaFormulario(Modelo_Entidades.Persona oPersona)
        {
            // Sección de datos del Persona
           

            txt_numero.Text = oPersona.dni.ToString();
            txt_nombreapellido.Text = oPersona.nombre_apellido;
          //  txt_fechanacimiento.Text = oPersona.fecha_nacimiento.ToString();

            if (oPersona.sexo == "Masculino")
            {
                rbtn_masculino.Checked = true;
            }

            else
            {
                rbtn_femenino.Checked = true;
            }

            txt_direccion.Text = oPersona.Direcciones.ElementAt(0).direccion;
            txt_cp.Text = oPersona.Direcciones.ElementAt(0).Localidad.cp.ToString();
        
            txt_cp.Text = oPersona.Direcciones.ElementAt(1).Localidad.cp.ToString();

            cmb_tiposdoc.SelectedItem = oPersona.Tipo_Documento;

            cmb_provincias.SelectedItem = oPersona.Direcciones.ElementAt(0).Localidad.Provincia;
            cmb_localidades.SelectedItem = oPersona.Direcciones.ElementAt(0).Localidad;
           

            txt_telfijo.Text = oPersona.telefono.ToString();
            txt_celular.Text = oPersona.celular.ToString();
            txt_emailpricipal.Text = oPersona.email1;
           

            

            // Sección de las observaciones del Persona
           
            txt_observaciones.Text = oPersona.observaciones;
        }

        

       

        // Cuando le doy click a "Asentar baja"
        private void btn_baja_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro de que desea suspender al Persona?", "Susoensión del Persona", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                 
                    MessageBox.Show("La suspensión se ha efectuado correctamente");
                
            }

            else if (dialogResult == DialogResult.No)
            {
                return;
            }          
        }

        private void tab_datos_Click(object sender, EventArgs e)
        {

        }

      

        
     
    }
}
