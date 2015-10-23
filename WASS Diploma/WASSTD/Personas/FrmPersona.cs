using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WASSTD.Personas
{
    public partial class FrmPersona : Form
    {
        // Declaro las variables que voy a utilizar en el formulario.
        string modo;

        // Declaro las controladoras a utilizar en el formulario
        Controladora.cPersona cPersona;
        Controladora.cTipo_Documento cTipo_Documento;
        Controladora.cProvincia cProvincia;
        Controladora.cLocalidad cLocalidad;
        Controladora.cEstado cEstado;

        Controladora.cMovimiento cMovimiento;
        Controladora.cCtaCte cCtaCte;
        Controladora.cTipo_Movimiento cTipo_Movimiento;


        // Declaro las entidades
        Modelo_Entidades.Persona oPersona;

        Modelo_Entidades.Direccion oDireccion;
        Modelo_Entidades.CtaCte oCtaCte;
        Modelo_Entidades.Usuario miUsuario;


        List<Modelo_Entidades.Movimiento> ListaMovimientos = new List<Modelo_Entidades.Movimiento>();

        

        // Declaro publico al constructor
        public FrmPersona(string fModo, Modelo_Entidades.Persona miPersona, Modelo_Entidades.Usuario oUsuario)
        {
            InitializeComponent();

            // Inicializo a las controladoras
            cPersona = Controladora.cPersona.ObtenerInstancia();
            cTipo_Documento = Controladora.cTipo_Documento.ObtenerInstancia();
            cProvincia = Controladora.cProvincia.ObtenerInstancia();
            cLocalidad = Controladora.cLocalidad.ObtenerInstancia();
            cEstado = Controladora.cEstado.ObtenerInstancia();
            cMovimiento = Controladora.cMovimiento.ObtenerInstancia();
            cCtaCte = Controladora.cCtaCte.ObtenerInstancia();
            
            cTipo_Movimiento = Controladora.cTipo_Movimiento.ObtenerInstancia();
            
            modo = fModo;
            oPersona = miPersona;
            miUsuario = oUsuario;

        }


        // Al cargar el formulario
        private void FrmPersona_Load(object sender, EventArgs e)
        {
           

            // Controles asociados a los datos de la persona que contienen listas
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

        // Armo el formulario (si no es una alta)
        private void ArmaFormulario(Modelo_Entidades.Persona oPersona)
        {
            // Sección de datos de la persona
            
            txt_numero.Text = oPersona.dni_cuil.ToString();
            txt_nombreapellido.Text = oPersona.apellido_nombre;
           // txt_fechanacimiento.Text = (Modelo_Entidades.Cliente)oPersona.fecha_nacimiento.ToString();



            txt_direccion.Text = oPersona.Direcciones.ElementAt(0).direccion;
            txt_cp.Text = oPersona.Direcciones.ElementAt(0).Localidad.cp.ToString();
            txt_cp.Text = oPersona.Direcciones.ElementAt(1).Localidad.cp.ToString();

            cmb_tiposdoc.SelectedItem = oPersona.Tipo_Documento;

            cmb_provincias.SelectedItem = oPersona.Direcciones.ElementAt(0).Localidad.Provincia;
            cmb_localidades.SelectedItem = oPersona.Direcciones.ElementAt(0).Localidad;



            txt_telfijo.Text = oPersona.nrotelfijo.ToString();
            txt_celular.Text = oPersona.nrotelcelu.ToString();
            txt_emailpricipal.Text = oPersona.email;
            

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (ValidarObligatorios() == true)
            {
                try
                {
                    #region Datos personales de la persona
                    oPersona.Tipo_Documento = (Modelo_Entidades.Tipo_Documento)cmb_tiposdoc.SelectedItem;
                    oPersona.dni_cuil = Convert.ToInt32(txt_numero.Text);
                    oPersona.apellido_nombre= txt_nombreapellido.Text;
                    //oPersona.fecha_nacimiento = Convert.ToDateTime(txt_fechanacimiento.Text);

                    

                    if (modo == "Alta")
                    {
                        oDireccion = new Modelo_Entidades.Direccion();
                        oDireccion.direccion = txt_direccion.Text;
                        oDireccion.Localidad = (Modelo_Entidades.Localidad)cmb_localidades.SelectedItem;
                        oPersona.Direcciones.Add(oDireccion);

                      
                    }

                    else
                    {
                        oDireccion = oPersona.Direcciones.ElementAt(0);
                        oDireccion.Localidad = (Modelo_Entidades.Localidad)cmb_localidades.SelectedItem;
                        oDireccion.direccion = txt_direccion.Text;
                        oPersona.Direcciones.ElementAt(0).Equals(oDireccion);

                        
                    }

                    oPersona.nrotelfijo = Convert.ToInt32(txt_telfijo.Text);
                    oPersona.nrotelcelu = Convert.ToInt32(txt_celular.Text);
                    oPersona.email = txt_emailpricipal.Text;
                    
                    #endregion

                

                    if (modo == "Alta")
                    {
                        cPersona.Alta(oPersona);

                        
                        cCtaCte.Modificacion(oCtaCte);

                        MessageBox.Show("La persona se ha agregado correctamente");
                    }

                    else
                    {
                        cPersona.Modificacion(oPersona);
                        MessageBox.Show("La persona se ha modificado correctamente");
                    }

                    this.DialogResult = DialogResult.OK;

                }

                catch (Exception Exc)
                {
                    MessageBox.Show(Exc.Message.ToString());
                }
            }
        }

        // Valido los datos de la persona
        private bool ValidarObligatorios()
        {
            #region Datos personales
            if (cmb_tiposdoc.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar un tipo de documento");
                return false;
            }

            if (string.IsNullOrEmpty(txt_numero.Text))
            {
                MessageBox.Show("Debe ingresar el número de DNI o CUIL");
                return false;
            }

            // Valido que no exista una persona con DNI igual
            if (cPersona.ValidarPersona(Convert.ToInt32(txt_numero.Text)) == false)
            {
                if (oPersona.dni_cuil != Convert.ToInt32(txt_numero.Text))
                {
                    MessageBox.Show("Ya existe una Persona con el DNI ingresado");
                    return false;
                }
            }

            if (string.IsNullOrEmpty(txt_nombreapellido.Text))
            {
                MessageBox.Show("Debe ingresar el nombre y apellido");
                return false;
            }

            if (Regex.IsMatch(txt_nombreapellido.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("El nombre y el apellido solo pueden contener letras");
                return false;
            }

            
            if (cmb_provincias.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar la provincia de residencia");
                return false;
            }

            if (cmb_localidades.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar la localidad de residencia");
                return false;
            }

           

            if (string.IsNullOrEmpty(txt_telfijo.Text) && string.IsNullOrEmpty(txt_celular.Text))
            {
                MessageBox.Show("Debe ingresar al menos un número de contacto telefónico");
                return false;
            }

            if (string.IsNullOrEmpty(txt_emailpricipal.Text))
            {

                MessageBox.Show("Debe ingresar un correo electrónico de contacto");
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

    
    }
}
