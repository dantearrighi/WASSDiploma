using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo_Entidades;

namespace WASSTD
{
    public partial class FrmTramite : Form
    {
        // Declaro las variables que voy a utilizar en el formulario.
        string modo;

        // Declaro las controladoras a utilizar en el formulario
        Controladora.cTramite cTramite;
        Controladora.cGrupo cGrupo;
        Controladora.cPersona cPersona;
        Controladora.cDetalles_Tramite cDetalles_Tramite;
        Controladora.cAuditoria cAuditoria;
        Controladora.cTipo_Tramite cTipo_Tramite;
        Controladora.cCU_GestionarTramites cCU_GestionarTramites;

        // Declaro las entidades
        Modelo_Entidades.Persona oPersona;
        Modelo_Entidades.Tramite oTramite;
        Modelo_Entidades.Usuario miUsuario;
        Modelo_Entidades.Detalles_Tramite oDetalles_Tramite;
        Modelo_Entidades.WASSTDEntidades oModelo_Entidades;

        FrmSeleccionPersonas formSeleccionarPersona;


        // Declaro como publico al constructor
        public FrmTramite(string fModo, Modelo_Entidades.Tramite miTramite, Modelo_Entidades.Usuario oUsuario)
        {

            InitializeComponent();

            // Inicializo a las controladoras
            cPersona = Controladora.cPersona.ObtenerInstancia();
            cGrupo = Controladora.cGrupo.ObtenerInstancia();
            cAuditoria = Controladora.cAuditoria.ObtenerInstancia();
            cTramite = Controladora.cTramite.ObtenerInstancia();
            cDetalles_Tramite = Controladora.cDetalles_Tramite.ObtenerInstancia();
            cTipo_Tramite = Controladora.cTipo_Tramite.ObtenerInstancia();
            cCU_GestionarTramites = Controladora.cCU_GestionarTramites.ObtenerInstancia();

            modo = fModo;
            oTramite = miTramite;
            miUsuario = oUsuario;
        }


        // Al Cargar el formulario                                             FALTA CONFIGURAR UN POCO MAS ESTE COMPORTAMIENTO, que hace si es alta, si es modificación o lo que sea
        private void FrmTramite_Load(object sender, EventArgs e)
        {
            if (modo != "Alta")
            {
                // Inhabilito controles
                btn_seleccionarPersona.Visible = false;
                lbl_DebeSeleccionar.Visible = false;
                
                
                ArmaFormulario(oTramite);
                // MODO CONSULTA
                if (modo == "Consulta")
                {
                    btn_guardar.Enabled = false;
                    btn_RealizarCalculo.Enabled = false;
                    btn_seleccionarPersona.Visible = false;
                    lbl_DebeSeleccionar.Visible = false;
                    lbl_Finalizado.Visible = false; //Esto solo para sacar screenshot
                    btn_AñadirDetalle.Enabled = false;
                    btn_CrearInforme.Enabled = false;
                    btn_NotificarCliente.Enabled = false;
                    btn_RecordatorioVanina.Enabled = false;
                    btn_VerCalculosAnteriores.Enabled = false;
                }
            }
            else
            {
                //MODO ALTA 
                btn_seleccionarPersona.Visible = true;
                lbl_DebeSeleccionar.Visible = true;
                txt_fecha_Alta.Text = DateTime.Today.ToString();
                cmb_tipos_tramites.DataSource = cTipo_Tramite.ObtenerTipos_Tramites();
                cmb_tipos_tramites.DisplayMember = "descripcion";
                cmb_tipos_tramites.Text = "SELECCIONAR";
                txt_Fecha_Del_Detalle.Text = DateTime.Now.ToShortDateString();

                //OCULTO
                txt_Ultimo_Movimiento.Text = DateTime.Today.ToString();
                btn_AñadirDetalle.Enabled = false;
                txt_Fecha_Del_Detalle.Visible = false;
                lbl_Fecha_Del_Detalle.Visible = false;
                txt_Ultimo_Movimiento.Visible = false;
                lbl_UltimoMovimiento.Visible = false;
                btn_RealizarCalculo.Enabled = false;
                btn_CrearInforme.Enabled = false;
                btn_NotificarCliente.Enabled = false;
                btn_RealizarCalculo.Enabled = false;
                btn_RecordatorioVanina.Enabled = false;
                btn_VerCalculosAnteriores.Enabled = false;
                lbl_Finalizado.Visible = false;
                lbl_Activo.Visible = false;
            }

            //Mostrar estado                               
            if (oTramite.estado == "Activo")
            {
                lbl_Finalizado.Visible = false;
                lbl_Activo.Visible = true;
            }
            else if (oTramite.estado == "Finalizado")
            {
                lbl_Finalizado.Visible = true;
                lbl_Activo.Visible = false;
            }
            else
            {
                lbl_Finalizado.Visible = false;
                lbl_Activo.Visible = false;
            }
            
    
        }


        // Armo el formulario (si no es una alta)
        private void ArmaFormulario(Modelo_Entidades.Tramite oTramite)
        {
            // Sección de datos de la Persona y el Tramite
            lbl_ClaveFiscal.Text = oTramite.Persona.clave_fiscal.ToString();
            lbl_NombreyApellido.Text = oTramite.Persona.nombre_apellido;
            lbl_FechaNacimiento.Text = oTramite.Persona.fecha_nacimiento.ToShortDateString();
            lbl_NumeroDoc.Text = oTramite.Persona.dni.ToString();
            lbl_TipoPersona.Text = oTramite.Persona.Tipo_Persona.descripcion;
            lbl_TipoDocumento.Text = oTramite.Persona.Tipo_Documento.descripcion;
            lbl_DebeSeleccionar.Visible = true;
            
            // Calcular edad
            Controladora.Persona.Age edad = Controladora.Persona.Age.CalcularEdad(lbl_FechaNacimiento.Text);
            
            // Muestro la edad en el label
            this.lbl_Edad.Text = edad.Years.ToString() + " años, " + edad.Months.ToString() + " meses," + edad.Days.ToString() + " días.";

            // Sexo
            if (oTramite.Persona.sexo == "Masculino")
            {
                lbl_Sexo.Text = "Masculino";
            }

            else
            {
                lbl_Sexo.Text = "Femenino";
            }

            //                                                                                              SEGUI MODIFICANDO ACA PARA DARLE FORMA A LA VISTA
            dgv_datos_detalles.DataSource = cDetalles_Tramite.Obtener_Detalles_Tramites(oTramite.Id);
            dgv_datos_detalles.Columns[4].Visible = false;
            dgv_datos_detalles.Columns[1].Width = 460;
        }


        //CLICK en Añadir detalle
        private void btn_AñadirDetalle_Click(object sender, EventArgs e)
        {
            oDetalles_Tramite.descripcion = txt_Descripcion.Text;
            
            //Utilio la clase AGE y el metodo Calcular Edad para convertir el texto de la fecha del detalle en DateTime
            Controladora.Persona.Age ObtenerFechaDetalle = Controladora.Persona.Age.CalcularEdad(txt_Fecha_Del_Detalle.Text);
            DateTime fechaDetalle = new DateTime(ObtenerFechaDetalle.Years, ObtenerFechaDetalle.Months, ObtenerFechaDetalle.Days);
            oDetalles_Tramite.fecha_desde = fechaDetalle;





            /*
            if (ValidarObligatorios() == true)
            {
                try
                {
                    oTramite.
                   

                    oPersona.Tipo_Documento = (Modelo_Entidades.Tipo_Documento)cmb_tiposdoc.SelectedItem;
                    oPersona.dni = Convert.ToInt32(txt_numero.Text);
                    oPersona.nombre_apellido = txt_nombreapellido.Text;
                    oPersona.observaciones = txt_observaciones.Text;
                    oPersona.Tipo_Persona = (Modelo_Entidades.Tipo_Persona)cmb_TipoPersona.SelectedItem;
                    oPersona.fecha_nacimiento = Convert.ToDateTime(txt_fechanacimiento.Text);

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
                    oPersona.clave_fiscal = txt_ClaveFiscal.Text;

                



               



                    if (modo == "Alta")
                    {
                        cPersona.Alta(oPersona);



                        MessageBox.Show("La persona se ha registrado correctamente");
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
            */
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // CLICK Seleccionar Persona
        private void btn_seleccionarPersona_Click(object sender, EventArgs e)
        {
            formSeleccionarPersona = FrmSeleccionPersonas.ObtenerInstancia(miUsuario);
            if (DialogResult.OK == formSeleccionarPersona.ShowDialog())
            {
                oPersona = formSeleccionarPersona.PersonaElegida;

                lbl_TipoDocumento.Text = oPersona.Tipo_Documento.descripcion;
                lbl_ClaveFiscal.Text = oPersona.clave_fiscal;
                lbl_FechaNacimiento.Text = oPersona.fecha_nacimiento.ToShortDateString();
                lbl_NombreyApellido.Text = oPersona.nombre_apellido;
                lbl_NumeroDoc.Text = oPersona.dni.ToString();
                lbl_Sexo.Text = oPersona.sexo;
                lbl_TipoPersona.Text = oPersona.Tipo_Persona.descripcion;
                
                //Calculo la edad
                Controladora.Persona.Age edad = Controladora.Persona.Age.CalcularEdad(oPersona.fecha_nacimiento.ToShortDateString());

                // Muestro la edad en el label
                this.lbl_Edad.Text = edad.Years.ToString() + " años, " + edad.Months.ToString() + " meses," + edad.Days.ToString() + " días.";

                
                //OCULTO EL MENSAJE DEBE SELECCIONAR PERSONA
                lbl_DebeSeleccionar.Visible = false;
                
            }

        }


        //CLICK GUARDAR (PASO 3 CU ALTA TRAMITE)
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            GuardarTramite();
            
        }
        
        // GUARDAR TRAMITE (PASO 4 CU ALTA TRAMITE)
        private void GuardarTramite()
        {
            try
            {
                /* *****************************************************
               * 
               * ACA LE ASIGNO TODOS LOS VALORES
               * CORRESPONDIENTES AL TRAMITE...
               * VOY MAPEANDO ENTRE LA INTERFAZ Y EL OBJETO oTramite
               * *******************************************************/
              

                //ASIGNO TODOS LOS VALORES INGRESADO POR EL USUARIO, al objeto oTramite

                //Detalles del tramite (SOLO FUNCIONA PARA ALTA PORQUE TIENE UN DETALLE... resolver como hacerlo para modificacion o cuando se agregan mas detalles
                if (modo == "Alta")
                {
                    //AGREGO DETALLE SI ES MODO **********  A L T A 
                    Modelo_Entidades.Detalles_Tramite detalleNuevo = new Modelo_Entidades.Detalles_Tramite();
                    detalleNuevo.descripcion = txt_Descripcion.Text;
                    detalleNuevo.fecha_desde = Convert.ToDateTime(txt_Fecha_Del_Detalle.Text);

                    //Agrego el detalle al tramite
                    oTramite.Detalles_Tramite.Add(detalleNuevo);
                }
                else
                {
                    //AGREGO DETALLE(S) SI ES MODO ********* M O D I F I C A C I O N Y AGREGUE VARIOS
                    //ACA VA EL CODIGO PARA AGREGAR LOS DETALLES AL TRAMITE CUANDO SE MODIFICA, YA QUE EN EL ALTA SOLO SE PERMITE AÑADIR UN SOLO DETALLE
                }

                //NOSE SI ESTO HAY Q HACERLO O NO... creo que no
                //detalleNuevo.TramiteId = oTramite.Id;

                //Valido que se haya seleccionado una persona a la cual cargarle el tramite

                if (oPersona != null)
                {
                    oTramite.Persona = this.oPersona;
                }

                //ASIGNO TIPO DE TRAMITE
                foreach (Tipo_Tramite tt in cTipo_Tramite.ObtenerTipos_Tramites())
                {
                    if (tt == cmb_tipos_tramites.SelectedValue)
                    {
                        oTramite.Tipo_Tramite = tt;
                    }
                }




                //VALIDO OBLIGATORIOS (PASO 4)
                if (cCU_GestionarTramites.cCU_AltaTramite.ValidarObligatorios(oTramite))
                {
                    oTramite.estado = "Activo";
                    //LO REGISTRO EN EL SISTEMA (PASO 5)
                    cCU_GestionarTramites.cCU_AltaTramite.AltaTramite(oTramite);

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }


            }
            catch (Exception Exc)
            {
                throw new Exception(Exc.Message);
            }
        }


        
    }
}
