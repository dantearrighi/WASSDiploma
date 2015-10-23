
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GCI
{
    public partial class FrmProfesional : Form
    {
        // Declaro las variables que voy a utilizar en el formulario.
        string modo;

        // Declaro las controladoras a utilizar en el formulario
        Controladora.cProfesional cProfesional;
        Controladora.cGrupo cGrupo;
        Controladora.cTipo_Documento cTipo_Documento;
        Controladora.cProvincia cProvincia;
        Controladora.cLocalidad cLocalidad;
        Controladora.cEstado cEstado;
        Controladora.cTipo_Matricula cTipo_Matricula;
        Controladora.cColegio cColegio;
        Controladora.cTitulo cTitulo;
        Controladora.cTipo_Certificado cTipo_Certificado;
        Controladora.cVerificacion cVerificacion;
        Controladora.cMatricula cMatricula;
        Controladora.cMovimiento cMovimiento;
        Controladora.cCtaCte cCtaCte;
        Controladora.cCuota cCuota;
        Controladora.cExpediente cExpediente;
        Controladora.cTipo_Movimiento cTipo_Movimiento;
        Controladora.cAuditoria cAuditoria;

        // Declaro las entidades
        Modelo_Entidades.Profesional oProfesional;
        Modelo_Entidades.Matricula oMatricula;
        Modelo_Entidades.Direccion oDireccion;
        Modelo_Entidades.Direccion oDireccionE;
        Modelo_Entidades.CtaCte oCtaCte;
        Modelo_Entidades.Usuario miUsuario;
        Modelo_Entidades.Auditoria_Cuota oLog_Cuota;

        List<Modelo_Entidades.Movimiento> ListaMovimientos = new List<Modelo_Entidades.Movimiento>();

        // Declaro los binding sources
        BindingSource BsHistoriales;
        BindingSource BsMatriculas;
        BindingSource BsDeudas;
        BindingSource BsCreditos;
        BindingSource BsExpedientes;

        FrmMatriculas FormTituloProfesional;

        // Declaro como publico al constructor
        public FrmProfesional(string fModo, Modelo_Entidades.Profesional miProfesional, Modelo_Entidades.Usuario oUsuario)
        {
            InitializeComponent();

            // Inicializo a las controladoras
            cProfesional = Controladora.cProfesional.ObtenerInstancia();
            cGrupo = Controladora.cGrupo.ObtenerInstancia();
            cTipo_Documento = Controladora.cTipo_Documento.ObtenerInstancia();
            cProvincia = Controladora.cProvincia.ObtenerInstancia();
            cLocalidad = Controladora.cLocalidad.ObtenerInstancia();
            cEstado = Controladora.cEstado.ObtenerInstancia();
            cTipo_Matricula = Controladora.cTipo_Matricula.ObtenerInstancia();
            cColegio = Controladora.cColegio.ObtenerInstancia();
            cTitulo = Controladora.cTitulo.ObtenerInstancia();
            cTipo_Certificado = Controladora.cTipo_Certificado.ObtenerInstancia();
            cMatricula = Controladora.cMatricula.ObtenerInstancia();
            cVerificacion = Controladora.cVerificacion.ObtenerInstancia();
            cMovimiento = Controladora.cMovimiento.ObtenerInstancia();
            cCtaCte = Controladora.cCtaCte.ObtenerInstancia();
            cCuota = Controladora.cCuota.ObtenerInstancia();
            cExpediente = Controladora.cExpediente.ObtenerInstancia();
            cTipo_Movimiento = Controladora.cTipo_Movimiento.ObtenerInstancia();
            cAuditoria = Controladora.cAuditoria.ObtenerInstancia();

            modo = fModo;
            oProfesional = miProfesional;
            miUsuario = oUsuario;
        }

        // Al cargar el formulario
        private void FrmProfesional_Load(object sender, EventArgs e)
        {
            // Inicializo los bindingsources
            BsHistoriales = new BindingSource();
            BsHistoriales.DataSource = dgv_historial;
            BsMatriculas = new BindingSource();
            BsMatriculas.DataSource = dgv_matriculas;
            BsDeudas = new BindingSource();
            BsDeudas.DataSource = dgv_deudas;
            BsCreditos = new BindingSource();
            BsCreditos.DataSource = dgv_creditos;
            BsExpedientes = new BindingSource();
            BsExpedientes.DataSource = dgv_expedeintes;

            // Controles asociados a los datos del profesional que contienen listas
            cmb_tiposdoc.DataSource = cTipo_Documento.ObtenerTipos_Documentos();
            cmb_tiposdoc.DisplayMember = "descripcion";
            cmb_tiposdoc.SelectedItem = null;

            cmb_provincias.DataSource = cProvincia.ObtenerProvincias();
            cmb_provincias.DisplayMember = "descripcion";
            cmb_provincias.SelectedItem = null;

            cmb_localidades.DataSource = cLocalidad.ObtenerLocalidades();
            cmb_localidades.DisplayMember = "descripcion";
            cmb_localidades.SelectedItem = null;

            cmb_provinciasE.DataSource = cProvincia.ObtenerProvincias();
            cmb_provinciasE.DisplayMember = "descripcion";
            cmb_provinciasE.SelectedItem = null;

            cmb_localidadesE.DataSource = cLocalidad.ObtenerLocalidades();
            cmb_localidadesE.DisplayMember = "descripcion";
            cmb_localidadesE.SelectedItem = null;

            // Controles asociados a la matrícula del profesional que contienen listas            

            cmb_tipomatricula.DataSource = cTipo_Matricula.ObtenerTiposMatriculas();
            cmb_tipomatricula.DisplayMember = "descripcion";
            //cmb_tipomatricula.SelectedItem = null;

            cmb_colegios.DataSource = cColegio.ObtenerColegios();
            cmb_colegios.DisplayMember = "descripcion";
            cmb_colegios.SelectedItem = null;

            // Limpio la grilla
            dgv_historial.DataSource = null;
            // LLeno el binding con los datos que traigo de las entidades
            BsHistoriales.DataSource = oProfesional.Historiales;
            // Asigno el binding a la grilla
            dgv_historial.DataSource = BsHistoriales;
            dgv_historial.Columns[0].Visible = false;
            dgv_historial.Columns[1].HeaderText = "Estado";
            dgv_historial.Columns[2].HeaderText = "Fecha";
            dgv_historial.Columns[3].HeaderText = "Tipo de Matrícula";
            dgv_historial.Columns[4].HeaderText = "Observaciones";
            dgv_historial.Columns[5].Visible = false;

            txt_observaciones_historial.Enabled = false;

            //Controles asociados a la contabilidad del profesional
            
            // Limpio la grilla
            dgv_deudas.DataSource = null;
            // LLeno el binding con los datos que traigo de las entidades
            BsDeudas.DataSource = cCuota.BuscarCuotasImpagasPorProfesional(oProfesional.dni);
            // Asigno el binding a la grilla
            dgv_deudas.DataSource = BsDeudas;
            dgv_deudas.Columns[0].Visible = false;
            dgv_deudas.Columns[1].Visible = false;
            dgv_deudas.Columns[2].HeaderText = "Cuota adeudada";
            dgv_deudas.Columns[3].Visible = false;

            // Limpio la grilla
            dgv_creditos.DataSource = null;
            // LLeno el binding con los datos que traigo de las entidades
            BsCreditos.DataSource = cCuota.BuscarCuotasPagasPorProfesional(oProfesional.dni);
            // Asigno el binding a la grilla
            dgv_creditos.DataSource = BsCreditos;
            dgv_creditos.Columns[0].Visible = false;
            dgv_creditos.Columns[1].Visible = false;
            dgv_creditos.Columns[2].HeaderText = "Cuota paga";
            dgv_creditos.Columns[3].Visible = false;

            // Controles asociados a los expedientes de los profesionales - cExpediente.BuscarExpedientePorProfesional(oProfesional);
            dgv_expedeintes.DataSource = null;
            BsExpedientes.DataSource = oProfesional.Expedientes;
            dgv_expedeintes.DataSource = BsExpedientes;
            dgv_expedeintes.Columns[0].HeaderText = "Número";
            dgv_expedeintes.Columns[1].HeaderText = "Estado";
            dgv_expedeintes.Columns[2].Visible = false;
            dgv_expedeintes.Columns[3].Visible = false;
            dgv_expedeintes.Columns[4].Visible = false;
            dgv_expedeintes.Columns[5].Visible = false;
            dgv_expedeintes.Columns[6].Visible = false;
            dgv_expedeintes.Columns[7].Visible = false;
            dgv_expedeintes.Columns[8].HeaderText = "Comitente";
            dgv_expedeintes.Columns[9].HeaderText = "Tarea";
            
            // Controles asociados a los certificados del profesional que contienen listas
            cmb_titulo_certhabilitacion.DataSource = oProfesional.Matriculas;
            cmb_titulo_certhabilitacion.DisplayMember = "Titulo";
            cmb_titulo_certhabilitacion.SelectedItem = null;

            cmb_tipocertificado.DataSource = cTipo_Certificado.ObtenerTiposCertificados();
            cmb_tipocertificado.DisplayMember = "descripcion";
            cmb_tipocertificado.SelectedItem = null;

            // Controles asociados a las observaciones del profesional que contienen listas           
            cmb_tituloamostrar.DataSource = oProfesional.Matriculas;
            cmb_tituloamostrar.DisplayMember = "Titulo";
            //cmb_tituloamostrar.SelectedItem = null;

            // Invalido controles que no se pueden editar
            txt_universidad.Enabled = false;
            txt_titulo.Enabled = false;
            txt_plan.Enabled = false;
            txt_matricula.Enabled = false;
            grp_reciprocidad.Enabled = false;
            grp_relaciondedependencia.Enabled = false;

            if (modo != "Alta")
            {
                // Inhabilito el DNI
                txt_numero.Enabled = false;

                ArmaFormulario(oProfesional);
                ArmaMatriculas();

                if (modo == "Consulta")
                {
                    btn_baja.Enabled = false;
                    btn_guardar.Enabled = false;
                    btn_cancelar.Text = "Cerrar";
                    btn_agregar.Enabled = false;
                    btn_modificar.Enabled = false;
                    chk_mismolugar.Enabled = false;
                }
            }

            else
            {
                txt_numero.Enabled = true;
                lb_estado_def.Text = "Recién matriculado";
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
                    #region Datos personales del profesional
                oProfesional.Tipo_Documento = (Modelo_Entidades.Tipo_Documento)cmb_tiposdoc.SelectedItem;
                oProfesional.dni = Convert.ToInt32(txt_numero.Text);
                oProfesional.nombre_apellido = txt_nombreapellido.Text;
                oProfesional.fecha_nacimiento = Convert.ToDateTime(txt_fechanacimiento.Text);

                if (rbtn_masculino.Checked == true)
                {
                    oProfesional.sexo = "Masculino";
                }

                else
                {
                    oProfesional.sexo = "Femenino";
                }

                if (modo == "Alta")
                {
                    oDireccion = new Modelo_Entidades.Direccion();
                    oDireccion.direccion = txt_direccion.Text;
                    oDireccion.Localidad = (Modelo_Entidades.Localidad)cmb_localidades.SelectedItem;
                    oProfesional.Direcciones.Add(oDireccion);

                    oDireccionE = new Modelo_Entidades.Direccion();
                    oDireccionE.direccion = txt_direccion.Text;
                    oDireccionE.Localidad = (Modelo_Entidades.Localidad)cmb_localidades.SelectedItem;
                    oProfesional.Direcciones.Add(oDireccionE);
                }

                else
                {
                    oDireccion = oProfesional.Direcciones.ElementAt(0);
                    oDireccion.Localidad = (Modelo_Entidades.Localidad)cmb_localidades.SelectedItem;
                    oDireccion.direccion = txt_direccion.Text;
                    oProfesional.Direcciones.ElementAt(0).Equals(oDireccion);

                    oDireccionE = oProfesional.Direcciones.ElementAt(1);
                    oDireccionE.Localidad = (Modelo_Entidades.Localidad)cmb_localidadesE.SelectedItem;
                    oDireccionE.direccion = txt_direccionE.Text;
                    oProfesional.Direcciones.ElementAt(1).Equals(oDireccionE);
                }

                oProfesional.telefono = Convert.ToInt32(txt_telfijo.Text);
                oProfesional.celular = Convert.ToInt32(txt_celular.Text);
                oProfesional.email1 = txt_emailpricipal.Text;
                oProfesional.email2 = txt_emailalternativo.Text;
                #endregion

                    #region Matrícula del profesional
                
                oProfesional.Tipo_Matricula = (Modelo_Entidades.Tipo_Matricula)cmb_tipomatricula.SelectedItem;

                if (oProfesional.Tipo_Matricula.descripcion == "Relación de Dependencia")
                {
                    oProfesional.lugar_trabajo = txt_lugartrabajo.Text;
                }

                if (oProfesional.Tipo_Matricula.descripcion == "Reciprocidad de Matrícula")
                {
                    oProfesional.Colegio = (Modelo_Entidades.Colegio)cmb_colegios.SelectedItem;
                    oProfesional.convenio_año = Convert.ToInt32(txt_año.Text);
                }

                if (modo == "Alta")
                {
                    // Cuando se matricula, le pongo el estado no habilitado. Se va a habilitar cuando pague.
                    oProfesional.Estado = cEstado.ObtenerEstadoNoHabilitado();
                    // Doy de alta el 1º historial
                    Modelo_Entidades.Historial oHistorial = new Modelo_Entidades.Historial();
                    oHistorial.estado = (cEstado.ObtenerEstadoHabilitado()).descripcion;
                    oHistorial.tipo_matricula = ((Modelo_Entidades.Tipo_Matricula)cmb_tipomatricula.SelectedItem).descripcion;
                    oHistorial.fecha = DateTime.Now;
                    oHistorial.observaciones = "Alta en el CIE del profesional";
                    oProfesional.Historiales.Add(oHistorial);
                }
                #endregion

                    #region Contabilidad del profesional

                if (modo == "Alta")
                {
                    // Doy de alta a la cta cte
                    Modelo_Entidades.CtaCte oCtaCte = new Modelo_Entidades.CtaCte();
                    oCtaCte.saldo = 0;
                    oCtaCte.Profesional = oProfesional;
                    oProfesional.CtaCte = oCtaCte;
                }

                #endregion

                    #region Observaciones del profesional
                oProfesional.observaciones = txt_observaciones.Text;
                oProfesional.titulo_a_mostrar = cmb_tituloamostrar.SelectedValue.ToString();
                #endregion

                    #region Títulos del profesional

                #endregion

                    if (modo == "Alta")
                    {
                        cProfesional.Alta(oProfesional);                    

                        int mes = DateTime.Now.Month;
                        if (mes == 1 || mes == 2)
                        {
                            GeneraCuotaAnual(oProfesional);
                            GeneraCuotaBimensual(oProfesional, mes);
                        }

                        else
                        {
                            GeneraCuotaBimensual(oProfesional, mes);
                        }

                        cCtaCte.Modificacion(oCtaCte);

                        MessageBox.Show("El profesional se ha agregado correctamente");
                    }

                    else
                    {
                        cProfesional.Modificacion(oProfesional);
                        MessageBox.Show("El profesional se ha modificado correctamente");
                    }               

                    this.DialogResult = DialogResult.OK;

                    }

                catch (Exception Exc)
                {
                    MessageBox.Show(Exc.Message.ToString());
                }
            }
        }

        // Valido los datos del Profesional
        private bool ValidarObligatorios()
        {
            #region Datos personales
            if (cmb_tiposdoc.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar un tipo de documento para el Profesional");
                return false;
            }

            if (string.IsNullOrEmpty(txt_numero.Text))
            {
                MessageBox.Show("Debe ingresar el número de DNI del Profesional");
                return false;
            }

            // Valido que no exista un profesional con un DNI igual
            if (cProfesional.ValidarProfesional(Convert.ToInt32(txt_numero.Text)) == false)
            {
                if (oProfesional.dni != Convert.ToInt32(txt_numero.Text))
                {
                    MessageBox.Show("Ya existe un Profesional con el DNI introducido");
                    return false;
                }
            }

            if (string.IsNullOrEmpty(txt_nombreapellido.Text))
            {
                MessageBox.Show("Debe ingresar el nombre y apellido del Profesional");
                return false;
            }

            if (Regex.IsMatch(txt_nombreapellido.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("El nombre y el apellido solo pueden contener letras");
                return false;
            }

            if (string.IsNullOrEmpty(txt_fechanacimiento.Text))
            {
                MessageBox.Show("Debe ingresar la fecha de nacimiento del Profesional");
                return false;
            }

            if (rbtn_femenino.Checked == false && rbtn_masculino.Checked == false)
            {
                MessageBox.Show("Debe ingresar un tipo de género para del Profesional");
                return false;
            }

            if (cmb_provincias.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar la provincia donde reside el Profesional");
                return false;
            }

            if (cmb_localidades.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar la provincia donde reside el Profesional");
                return false;
            }

            if (string.IsNullOrEmpty(txt_direccion.Text))
            {
                MessageBox.Show("Debe ingresar la dirección del Profesional");
                return false;
            }

            if (cmb_provinciasE.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar la provincia de envío de la boleta del Profesional");
                return false;
            }

            if (cmb_localidades.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar la localidad de envío de la boleta del Profesional");
                return false;
            }

            if (string.IsNullOrEmpty(txt_direccionE.Text))
            {
                MessageBox.Show("Debe ingresar la dirección de envío de la matrícula del Profesional");
                return false;
            }

            if (string.IsNullOrEmpty(txt_telfijo.Text) || string.IsNullOrEmpty(txt_celular.Text))
            {
                MessageBox.Show("Debe ingresar al menos un número de contacto telefónico para comunicarse con el Profesional");
                return false;
            }

            if (string.IsNullOrEmpty(txt_emailpricipal.Text))
            {

                MessageBox.Show("Debe ingresar un correo electrónico de contacto para comunicarse con el Profesional");
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

            #region Datos referidos a la matrícula del profesional
            if (cmb_tipomatricula.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar un tipo de matrícula para el Profesional");
                return false;
            }

            if (cmb_tipomatricula.SelectedText == "Relación de dependencia" && string.IsNullOrEmpty(txt_lugartrabajo.Text))
            {
                MessageBox.Show("Debe proporcionar el lugar de trabajo del profesional en relación de dependencia");
                return false;
            }

            if (cmb_tipomatricula.SelectedText == "Convenio" && string.IsNullOrEmpty(txt_año.Text))
            {
                MessageBox.Show("Debe proporcionar el año de habilitación del profesional en el Colegio con el cual se estableció el convenio");
                return false;
            }
            #endregion            

            #region datos del título
            
            if (dgv_matriculas.DataSource == null)
            {
                MessageBox.Show("Debe agregar al menos un título Profesional");
                return false;
            }
            #endregion

            #region Datos referidos a la matrícula del profesional
            if (txt_observaciones_historial.Enabled == true)
            {
                if (string.IsNullOrEmpty(txt_observaciones_historial.Text))
                {
                    MessageBox.Show("No ha ingresado ninguna observación por el cambio de estado o por el cambio de tipo de matrícula del profesional.", "¡ATENCIÓN!");
                    return false;
                }

                if (oProfesional.Historiales.Count != 0)
                {
                    TimeSpan dif = oProfesional.Historiales.ToList().Last().fecha - DateTime.Now;
                    if (dif.Days > -365)
                    {
                        MessageBox.Show("No puede cambiar el tipo de matrícula del profesional si no ha pasado al menos 1 año");
                        return false;
                    }

                    else
                    {
                        Modelo_Entidades.Historial oHistorial = new Modelo_Entidades.Historial();
                        oHistorial.estado = oProfesional.Estado.descripcion;
                        oHistorial.tipo_matricula = cmb_tipomatricula.SelectedValue.ToString();
                        oHistorial.fecha = DateTime.Now;
                        //Habilito las observaciones del historial
                        oHistorial.observaciones = txt_observaciones_historial.Text;
                        oProfesional.Historiales.Add(oHistorial);
                    }
                }
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

            if (chk_mismolugar.Checked == true)
            {
                cmb_provinciasE.SelectedItem = cmb_provincias.SelectedItem;
                cmb_localidadesE.SelectedItem = cmb_localidades.SelectedItem;
                txt_direccionE.Text = txt_direccion.Text;
                txt_cpE.Text = ((Modelo_Entidades.Localidad)cmb_localidades.SelectedItem).cp.ToString();
            }

            if (chk_mismolugar.Checked == false)
            {
                cmb_provinciasE.DataSource = cProvincia.ObtenerProvincias();
                cmb_provinciasE.DisplayMember = "descripcion";
                cmb_provinciasE.SelectedItem = null;
            }
        }

        // Al dejar un valor en el combo de localidades, se llena el código postal
        private void cmb_localidadesE_Leave(object sender, EventArgs e)
        {
            Modelo_Entidades.Localidad oLocalidad = (Modelo_Entidades.Localidad)cmb_localidadesE.SelectedItem;
            if ((Modelo_Entidades.Localidad)cmb_localidadesE.SelectedItem == null)
            {
                return;
            }
            else
            {
                txt_cpE.Text = oLocalidad.cp.ToString();
            }            
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

        // Al dejar un valor en el combo de provincias, se llena el combo de localidades de esa provincia
        private void cmb_provinciasE_Leave(object sender, EventArgs e)
        {
            Modelo_Entidades.Provincia oProvincia = (Modelo_Entidades.Provincia)cmb_provinciasE.SelectedItem;
            if (oProvincia == null)
            {
                return;
            }

            else
            {
                cmb_localidadesE.DataSource = cLocalidad.ObtenerLocalidades();
                cmb_localidadesE.DisplayMember = "descripcion";
                cmb_localidadesE.SelectedItem = null;
            }
        }

        // Al hacer click en agregar matriculas
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FormTituloProfesional = new FrmMatriculas("Alta", oMatricula = new Modelo_Entidades.Matricula(), oProfesional);
            DialogResult dr = FormTituloProfesional.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // Traigo a la matrícula del formulario con todos sus atributos
                oMatricula = FormTituloProfesional.MatriculaElegida;

                // Asigno la matrícula al profesional traida desde el otro formulario
                
                oProfesional.Matriculas.Add(oMatricula);

                //MessageBox.Show("La matrícula se agregó correctamente. Si desea agregar una nueva matrícula, guarde los cambios del profesional e ingrese nuevamente");

                ArmaMatriculas();          
            }
        }

        // Armo la grilla de matriculas del profesional
        private void ArmaMatriculas()
        {
            // Limpio la grilla
            dgv_matriculas.DataSource = null;
            // LLeno el binding con los datos que traigo de las entidades
            BsMatriculas.DataSource = oProfesional.Matriculas;
            // Asigno el binding a la grilla
            dgv_matriculas.DataSource = BsMatriculas;
            dgv_matriculas.Columns[0].Visible = false;
            dgv_matriculas.Columns[1].HeaderText = "ICIE";
            dgv_matriculas.Columns[2].Visible = false;
            dgv_matriculas.Columns[3].Visible = false;
            dgv_matriculas.Columns[4].Visible = false;
            dgv_matriculas.Columns[5].Visible = false;
            dgv_matriculas.Columns[6].Visible = false;
            dgv_matriculas.Columns[7].Visible = false;
            dgv_matriculas.Columns[8].Visible = false;
            // Inhabilito el cuadro de texto de las observaciones y el de lugar de trabajo ya que solo se va a habilitar cuando cambie el tipo de matrícula en el combo
            txt_observaciones_historial.Enabled = false;
            //txt_lugartrabajo.Enabled = false;
        }

        // Armo los datos de la matricula seleccionada para el profesional
        private void ArmaTxtsMatriculas()
        {
            if (((Modelo_Entidades.Matricula)dgv_matriculas.CurrentRow.DataBoundItem == null))
            {
                return;
            }

            else
            {
                oMatricula = (Modelo_Entidades.Matricula)dgv_matriculas.CurrentRow.DataBoundItem;

                txt_matricula.Text = oMatricula.icie;
                txt_universidad.Text = oMatricula.Legajo_Academico.Titulo.Universidad.descripcion;
                txt_titulo.Text = oMatricula.Legajo_Academico.Titulo.descripcion;
                lb_ley.Text = oMatricula.Legajo_Academico.Titulo.ley_aprobacion;
                txt_plan.Text = oMatricula.Legajo_Academico.Plan.año;
                lb_descespecialidad.Text = oMatricula.Legajo_Academico.Titulo.Especialidad.ToString();
                lb_ordenanzaconsejo.Text = oMatricula.Legajo_Academico.Plan.ordenanza;
            }
        }

        // Cuando dejo el combo de los tipos de matrícula
        private void cmb_tipomatricula_Leave(object sender, EventArgs e)
        {
            string tipo_matricula = ((Modelo_Entidades.Tipo_Matricula)cmb_tipomatricula.SelectedItem).descripcion;
            if (tipo_matricula == null)
            {
                return;
            }

            if (tipo_matricula == "Relación de Dependencia")
            {
                grp_relaciondedependencia.Enabled = true;
            }

            else
            {
                grp_relaciondedependencia.Enabled = false;
            }

            if (tipo_matricula == "Reciprocidad de Matrícula")
            {
                grp_reciprocidad.Enabled = true;
            }

            else
            {
                grp_reciprocidad.Enabled = false;
            }
        }

        // Al hacer click en modificar matriculas
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (((Modelo_Entidades.Matricula)dgv_matriculas.CurrentRow.DataBoundItem == null))
            {
                return;
            }

            else 
            {
                FormTituloProfesional = new FrmMatriculas("Modificar", (Modelo_Entidades.Matricula)dgv_matriculas.CurrentRow.DataBoundItem, oProfesional);
                DialogResult dr = FormTituloProfesional.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    // Asigno la matrícula al profesional traida desde el otro formulario
                    oProfesional.Matriculas.Equals(FormTituloProfesional.MatriculaElegida);
                    cProfesional.Modificacion(oProfesional);

                    ArmaTxtsMatriculas();
                    ArmaMatriculas();
                }
            }
        }

        // Armo el formulario (si no es una alta)
        private void ArmaFormulario(Modelo_Entidades.Profesional oProfesional)
        {
            // Sección de datos del profesional
            lb_estado_def.Text = oProfesional.Estado.descripcion;

            txt_numero.Text = oProfesional.dni.ToString();
            txt_nombreapellido.Text = oProfesional.nombre_apellido;
            txt_fechanacimiento.Text = oProfesional.fecha_nacimiento.ToString();

            if (oProfesional.sexo == "Masculino")
            {
                rbtn_masculino.Checked = true;
            }

            else
            {
                rbtn_femenino.Checked = true;
            }

            txt_direccion.Text = oProfesional.Direcciones.ElementAt(0).direccion;
            txt_cp.Text = oProfesional.Direcciones.ElementAt(0).Localidad.cp.ToString();
            txt_direccionE.Text = oProfesional.Direcciones.ElementAt(1).direccion;
            txt_cp.Text = oProfesional.Direcciones.ElementAt(1).Localidad.cp.ToString();

            cmb_tiposdoc.SelectedItem = oProfesional.Tipo_Documento;

            cmb_provincias.SelectedItem = oProfesional.Direcciones.ElementAt(0).Localidad.Provincia;
            cmb_localidades.SelectedItem = oProfesional.Direcciones.ElementAt(0).Localidad;
            cmb_provinciasE.SelectedItem = oProfesional.Direcciones.ElementAt(1).Localidad.Provincia;
            cmb_localidadesE.SelectedItem = oProfesional.Direcciones.ElementAt(1).Localidad;

            if (oProfesional.Direcciones.ElementAt(0).Localidad.Provincia == oProfesional.Direcciones.ElementAt(1).Localidad.Provincia && oProfesional.Direcciones.ElementAt(0).Localidad == oProfesional.Direcciones.ElementAt(1).Localidad && oProfesional.Direcciones.ElementAt(0).direccion == oProfesional.Direcciones.ElementAt(1).direccion)
            {
                chk_mismolugar.Checked = true;
            }

            else
            {
                chk_mismolugar.Checked = false;
            }

            txt_telfijo.Text = oProfesional.telefono.ToString();
            txt_celular.Text = oProfesional.celular.ToString();
            txt_emailpricipal.Text = oProfesional.email1;
            txt_emailalternativo.Text = oProfesional.email2;

            // Sección de datos de la matrícula del profesional
            cmb_tipomatricula.SelectedItem = oProfesional.Tipo_Matricula;

            switch (oProfesional.Tipo_Matricula.descripcion)
            {
                case ("Relación de Dependencia"):
                    {
                        txt_lugartrabajo.Text = oProfesional.lugar_trabajo;
                        break;
                    }

                case ("Convenio"):
                    {
                        cmb_colegios.SelectedItem = oProfesional.Colegio;
                        txt_año.Text = oProfesional.convenio_año.ToString();                        
                        break;
                    }
            }

            // Sección de las observaciones del profesional
            lb_titulo_que_se_muestra.Text = oProfesional.titulo_a_mostrar;
            txt_observaciones.Text = oProfesional.observaciones;
        }

        // Cuando le doy click a ver detalles
        private void btn_ver_detalle_Click(object sender, EventArgs e)
        {
            ArmaTxtsMatriculas();
            ArmaMatriculas();
        }

        // Cuando cambia el tipo de matrícula
        private void cmb_tipomatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tipomatricula.SelectedValue.ToString() == "Relación de Dependencia")
            {
                grp_relaciondedependencia.Enabled = true;

                if (modo != "Alta")
                {
                    txt_observaciones_historial.Enabled = true;
                }                                
            }

            else if (cmb_tipomatricula.SelectedValue.ToString() == "Reciprocidad de Matrícula")
            {
                grp_reciprocidad.Enabled = true;
                if (modo != "Alta")
                {
                    txt_observaciones_historial.Enabled = true;
                }
            }

            else
            {
                txt_observaciones_historial.Enabled = false;
            }
        }

        // Cuando le doy click a "Asentar baja"
        private void btn_baja_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro de que desea suspender al profesional?", "Susoensión del profesional", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                TimeSpan dif = oProfesional.Historiales.ToList().Last().fecha - DateTime.Now;
                if (dif.Days > -365)
                {
                    MessageBox.Show("No puede cambiar el estado del profesional si no ha pasado al menos 1 año");
                }

                else
                {
                    Modelo_Entidades.Historial oHistorial = new Modelo_Entidades.Historial();
                    oHistorial.estado = cEstado.ObtenerEstadoBaja().descripcion;
                    oProfesional.Estado = cEstado.ObtenerEstadoBaja();
                    oHistorial.fecha = DateTime.Now;
                    oHistorial.tipo_matricula = oProfesional.Tipo_Matricula.descripcion;
                    //Habilito las observaciones del historial
                    oHistorial.observaciones = "Baja voluntaria";
                    oProfesional.Historiales.Add(oHistorial);
                    MessageBox.Show("La suspensión se ha efectuado correctamente");
                }
            }

            else if (dialogResult == DialogResult.No)
            {
                return;
            }          
        }

        // Cuando le doy click a imprimir una matrícula
        private void btn_imprimirtitulo_Click(object sender, EventArgs e)
        {
            if (((Modelo_Entidades.Matricula)dgv_matriculas.CurrentRow.DataBoundItem == null))
            {
                MessageBox.Show("Debe seleccionar un título para imprimir");
            }

            else
            {
                oMatricula = (Modelo_Entidades.Matricula)dgv_matriculas.CurrentRow.DataBoundItem;
            }

            FrmImprimirTitulo FormularioImpresionTítulo = new FrmImprimirTitulo(oProfesional.dni,oProfesional.Direcciones.First().id, oMatricula.icie);
            DialogResult DrLogin = FormularioImpresionTítulo.ShowDialog();

            if (DrLogin != DialogResult.OK)
            {
                return;
            }
        }

        // Cuando le doy click a reimprimir boletas
        private void btn_imprimirboletas_Click(object sender, EventArgs e)
        {
            foreach (Modelo_Entidades.Movimiento oMov in cMovimiento.ObtenerMovimientos())
            {
                foreach (Modelo_Entidades.Cuota oCuota in cCuota.BuscarCuotasImpagasPorProfesional(oProfesional.dni))
                {
                    if (oMov.CtaCte.id == oCuota.Profesional.CtaCte.id)
                    {
                        ListaMovimientos.Add(oMov);
                    }
                }
            }

            if (ListaMovimientos.Count == 0) // Si no hay movimientos no tengo que imprimirle
            {
                MessageBox.Show("El profesional no adeuda ninguna cuota");
            }

            else
            {
                FrmImprimirBoleta_Prof FormImprimirBoletaProf = new FrmImprimirBoleta_Prof(cCuota.ObtenerCuotas().Last().id, cCuota.ObtenerCuotas().First().id, "cuota", oProfesional.dni, oProfesional.Tipo_Matricula.id);
                DialogResult DrLogin = FormImprimirBoletaProf.ShowDialog();
            }
        }

        // Cuando le doy click a imprimir certificados
        private void btn_imprimircertificadoH_Click(object sender, EventArgs e)
        {
            if (cmb_tipocertificado.Text == "" || cmb_titulo_certhabilitacion.Text == "")
            {
                MessageBox.Show("Debe seleccionar una matrícula y un tipo de certificado para realizar la impresión");
            }

            else
            {
                if (oProfesional.Estado.descripcion == "No Habilitado" || oProfesional.Estado.descripcion == "Baja")
                {
                    MessageBox.Show("El profesional no se encuentra habilitado para la emisión del certificado");
                }

                else
                {
                    if (cmb_tipocertificado.Text == "Habilitación")
                    {
                        FrmImprimirCertificado FormImprimirCertificado = new FrmImprimirCertificado(cmb_titulo_certhabilitacion.Text);
                        DialogResult DrLogin = FormImprimirCertificado.ShowDialog();
                    }

                    else
                    {
                        FrmImprimirCertificado_I FormImprimirCertificado_I = new FrmImprimirCertificado_I(cmb_titulo_certhabilitacion.Text);
                        DialogResult DrLogin = FormImprimirCertificado_I.ShowDialog();
                    }
                }
            }
        }

        // Genero la cuota anual para un nuevo profesional
        private void GeneraCuotaAnual(Modelo_Entidades.Profesional oProfesional)
        {
            oCtaCte = oProfesional.CtaCte;
            Modelo_Entidades.Boleta oBoleta = new Modelo_Entidades.Boleta();
            Modelo_Entidades.Movimiento oMovimiento = new Modelo_Entidades.Movimiento();
            oLog_Cuota = new Modelo_Entidades.Auditoria_Cuota();

            oMovimiento.fecha = DateTime.Now;

            Modelo_Entidades.Anual oAnual = new Modelo_Entidades.Anual();
            if (oProfesional.Tipo_Matricula.descripcion == "Relación de Dependencia")
            {
                oMovimiento.importe = Math.Round(cCuota.ObtenerValor_Tipo_Couta(oAnual).Valor() * 0.7, 2); // EL PORCENTAJE ESTÁ HARKODEADO, DE TODAS FORMAS ESE ES EL VALOR QUE ANUALMENTE EL COLEGIO DISPONE
            }

            else
            {
                oMovimiento.importe = Math.Round(cCuota.ObtenerValor_Tipo_Couta(oAnual).Valor(), 2);
            }

            oMovimiento.descripcion = "Cuota anual año " + DateTime.Now.Year.ToString();
            oAnual.descripcion = "Cuota anual año " + DateTime.Now.Year.ToString();
            oAnual.estado = false;
            oAnual.Profesional = oProfesional;
            cCuota.AgregarCuota(oAnual);

            #region Audito la cuota
            oLog_Cuota.estado = false;
            oLog_Cuota.descripcion = "Cuota anual año " + DateTime.Now.Year.ToString();
            oLog_Cuota.Profesional_dni = oProfesional.dni;
            oLog_Cuota.usuario = miUsuario.nombre_apellido;
            oLog_Cuota.fecha = DateTime.Now;
            oLog_Cuota.accion = "Agregado de cuota anual al profesional " + oProfesional.nombre_apellido;
            cAuditoria.AuditarCuota(oLog_Cuota);
            #endregion

            oMovimiento.fecha = DateTime.Now;
            oMovimiento.CtaCte = oProfesional.CtaCte;
            oMovimiento.Tipo_Movimiento = cTipo_Movimiento.ObtenerMov_Deudor();
            oMovimiento.Comprobante = oBoleta;

            cMovimiento.Alta(oMovimiento);

            oProfesional.CtaCte.Movimientos.Add(oMovimiento);
                        
            oCtaCte.saldo = oCtaCte.saldo - Convert.ToDecimal(oMovimiento.importe);

            cCtaCte.Modificacion(oCtaCte);  
        }

        // Genero la cuota bimensual para un nuevo profesional
        private void GeneraCuotaBimensual(Modelo_Entidades.Profesional oProfesional, int mes)
        {
            int numero = mes;
            switch (numero)
            {
                case 1:
                    numero = 1;
                    break;
                case 2:
                    numero = 1;
                    break;
                case 3:
                    numero = 2;
                    break;
                case 4:
                    numero = 2;
                    break;
                case 5:
                    numero = 3;
                    break;
                case 6:
                    numero = 3;
                    break;
                case 7:
                    numero = 4;
                    break;
                case 8:
                    numero = 4;
                    break;
                case 9:
                    numero = 5;
                    break;
                case 10:
                    numero = 5;
                    break;
                case 11:
                    numero = 6;
                    break;
                case 12:
                    numero = 6;
                    break;            
            }

            oCtaCte = oProfesional.CtaCte;
            Modelo_Entidades.Boleta oBoleta = new Modelo_Entidades.Boleta();
            Modelo_Entidades.Movimiento oMovimiento = new Modelo_Entidades.Movimiento();
            oLog_Cuota = new Modelo_Entidades.Auditoria_Cuota();

            oMovimiento.fecha = DateTime.Now;

            Modelo_Entidades.Bimensual oBimensual = new Modelo_Entidades.Bimensual();
            // Esto verifica si el profesional pagó la anual, no la genere las cuotas bimensuales y el que esté en relación de dependencia, la 5° y 6° cuota no las pague

            oMovimiento.importe = Math.Round(cCuota.ObtenerValor_Tipo_Couta(oBimensual).Valor(), 2);
            oMovimiento.descripcion = "Cuota " + numero.ToString() + "/" + DateTime.Now.Year.ToString();
            oBimensual.descripcion = "Cuota " + numero.ToString() + "/" + DateTime.Now.Year.ToString();
            oBimensual.estado = false;
            oBimensual.Profesional = oProfesional;
            cCuota.AgregarCuota(oBimensual);

            #region Audito la cuota
            oLog_Cuota.estado = false;
            oLog_Cuota.descripcion = "Cuota " + numero.ToString() + "/" + DateTime.Now.Year.ToString();
            oLog_Cuota.Profesional_dni = oProfesional.dni;
            oLog_Cuota.usuario = miUsuario.nombre_apellido;
            oLog_Cuota.fecha = DateTime.Now;
            oLog_Cuota.accion = "Agregado de cuota bimensual al profesional " + oProfesional.nombre_apellido;
            cAuditoria.AuditarCuota(oLog_Cuota);
            #endregion

            oMovimiento.fecha = DateTime.Now;
            oMovimiento.CtaCte = oProfesional.CtaCte;
            oMovimiento.Tipo_Movimiento = cTipo_Movimiento.ObtenerMov_Deudor();
            oMovimiento.Comprobante = oBoleta;

            cMovimiento.Alta(oMovimiento);

            oProfesional.CtaCte.Movimientos.Add(oMovimiento);

            oCtaCte.saldo = oCtaCte.saldo - Convert.ToDecimal(oMovimiento.importe);
        }
    }
}
