using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WASSTD
{
    public partial class FrmExpediente : Form
    {
        // Declaron las variables que voy a utilizar en el formulario
        string modo;
        decimal monto_obra;

        Controladora.cExpediente cExpediente;
        Controladora.cLiquidacion cLiquidacion;
        Controladora.cProfesional cProfesional;
        Controladora.cTarea cTarea;
        Controladora.cMovimiento cMovimiento;
        Controladora.cTipo_Movimiento cTipo_Movimiento;
        Controladora.cCtaCte cCtaCte;

        Modelo_Entidades.OI oOI;
        Modelo_Entidades.FE oFE;
        Modelo_Entidades.HM oHM;
        Modelo_Entidades.Comitente oComitente;
        Modelo_Entidades.Usuario oUsuario;
        Modelo_Entidades.Profesional oProfesional;
        Modelo_Entidades.Movimiento oMovimiento;
        Modelo_Entidades.Boleta oBoleta;
        Modelo_Entidades.CtaCte oCtaCte;

        BindingSource BsLiquidaciones_OI;
        BindingSource BsLiquidaciones_FE;
        BindingSource BsLiquidaciones_HM;
        BindingSource BsProfesionales; 

        // Constructor de las "Obras de Ingenieria"
        public FrmExpediente(string fModo, Modelo_Entidades.OI miOI, Modelo_Entidades.Usuario miUsuario)
        {
            InitializeComponent();

            // Declaro las controladoras a utilizar en el formulario
            cExpediente = Controladora.cExpediente.ObtenerInstancia();
            cLiquidacion = Controladora.cLiquidacion.ObtenerInstancia();
            cProfesional = Controladora.cProfesional.ObtenerInstancia();
            cTarea = Controladora.cTarea.ObtenerInstancia();
            cMovimiento = Controladora.cMovimiento.ObtenerInstancia();
            cTipo_Movimiento = Controladora.cTipo_Movimiento.ObtenerInstancia();
            cCtaCte = Controladora.cCtaCte.ObtenerInstancia();

            // Instancio el binding source
            BsLiquidaciones_OI = new BindingSource();
            //Luego lo lleno con los datos de la grilla
            //BsLiquidaciones_OI.DataSource = dgv_liquidaciones_OI;

            modo = fModo;
            oOI = miOI;
            oUsuario = miUsuario;

            lb_tipo_expediente.Text = "Obras de Ingenieria";
        
            tab_expedientes.TabPages.Remove(tab_HM);
            tab_expedientes.TabPages.Remove(tb_FE);

            cmb_tareas_OI.DataSource = cTarea.ObtenerTareas();
            cmb_tareas_OI.DisplayMember = "descripcion";

            if (modo == "Alta")
            {
                lb_numero_expediente.Text = "S/N";
                lb_estado_expediente.Text = "Recibido";
                oOI.estado = "Recibido";

                dtp_fecha_aprobacion.Checked = false;
                dtp_fecha_pago.Checked = false;
                dtp_fecha_devolución.Checked = false;

                // Si el expte es nuevo, lo cargo con la fecha actual
                dtp_fecha_recepcion.Value = DateTime.Now;
            }

            else
            {
                if (modo == "Consulta")
                {
                    InhabilitarControles();

                    gb_liquidacion_OI.Enabled = false;
                    nud_monto_obra_OI.Enabled = false;
                    cmb_tareas_OI.Enabled = false;
                }

                lb_numero_expediente.Text = oOI.numero.ToString();
                lb_estado_expediente.Text = oOI.estado;

                #region Datos del expediente

                lb_numero_expediente.Text = oOI.numero.ToString();
                lb_estado_expediente.Text = oOI.estado;

                dtp_fecha_recepcion.Value = oOI.fecha_recepcion;

                switch (oOI.estado)
                {
                    case ("Recibido"):
                        {
                            dtp_fecha_aprobacion.Checked = false;
                            dtp_fecha_pago.Checked = false;
                            dtp_fecha_devolución.Checked = false;
                            dtp_fecha_recepcion.Value = oOI.fecha_recepcion;
                            break;
                        }

                    case ("Aprobado"):
                        {
                            dtp_fecha_aprobacion.Checked = true;
                            dtp_fecha_pago.Checked = false;
                            dtp_fecha_devolución.Checked = false;
                            dtp_fecha_recepcion.Value = oOI.fecha_recepcion;
                            dtp_fecha_aprobacion.Value = oOI.fecha_aprobacion;
                            break;
                        }

                    case ("Pagado"):
                        {
                            dtp_fecha_aprobacion.Checked = true;
                            dtp_fecha_pago.Checked = true;
                            dtp_fecha_devolución.Checked = false;
                            dtp_fecha_recepcion.Value = oOI.fecha_recepcion;
                            dtp_fecha_aprobacion.Value = oOI.fecha_aprobacion;
                            dtp_fecha_pago.Value = oOI.fecha_pago;
                            break;
                        }

                    case ("Devuelto"):
                        {
                            dtp_fecha_devolución.Checked = true;
                            dtp_fecha_recepcion.Value = oOI.fecha_recepcion;
                            dtp_fecha_aprobacion.Value = oOI.fecha_aprobacion;
                            dtp_fecha_pago.Value = oOI.fecha_pago;
                            dtp_fecha_devolución.Value = oOI.fecha_devolucion;
                            break;
                        }
                }

                txt_comitente.Text = oOI.Comitente.razon_social;
                // Limpio la grilla
                dgv_profesionales.DataSource = null;
                // Asigno el binding a la grilla
                dgv_profesionales.DataSource = oOI.Profesionales;
                ArmaProefesionales();

                #endregion

                #region Datos propios de la OI
                nud_monto_obra_OI.Value = oOI.monto_obra;
                cmb_tareas_OI.SelectedItem = oOI.Tarea;

                // Limpio la grilla
                dgv_liquidaciones_OI.DataSource = null;
                // LLeno el binding con los datos que traigo de las entidades
                BsLiquidaciones_OI.DataSource = oOI.Liquidaciones;
                // Asigno el binding a la grilla
                dgv_liquidaciones_OI.DataSource = BsLiquidaciones_OI;
                dgv_liquidaciones_OI.Columns[0].Visible = false;
                dgv_liquidaciones_OI.Columns[1].HeaderText = "Tarea";
                dgv_liquidaciones_OI.Columns[2].HeaderText = "Cantidad";
                dgv_liquidaciones_OI.Columns[3].HeaderText = "Importe";
                dgv_liquidaciones_OI.Columns[4].Visible = false;

                if (oOI.Liquidaciones.Count != 0)
                {
                    if (oOI.Liquidaciones.ElementAt(0).importe == 0)
                    {
                        chk_anteproyecto.Checked = false;
                    }

                    else
                    {
                        chk_anteproyecto.Checked = true;
                    }

                    if (oOI.Liquidaciones.ElementAt(1).importe == 0)
                    {
                        chk_proyecto_sin_anteproyecto.Checked = false;
                    }

                    else
                    {
                        chk_proyecto_sin_anteproyecto.Checked = true;
                    }

                    if (oOI.Liquidaciones.ElementAt(2).importe == 0)
                    {
                        chk_proyecto.Checked = false;
                    }

                    else
                    {
                        chk_proyecto.Checked = true;
                    }

                    if (oOI.Liquidaciones.ElementAt(3).importe == 0)
                    {
                        chk_conduccion_tecnica.Checked = false;
                    }

                    else
                    {
                        chk_conduccion_tecnica.Checked = true;
                    }

                    if (oOI.Liquidaciones.ElementAt(4).importe == 0)
                    {
                        chk_administracion.Checked = false;
                    }

                    else
                    {
                        chk_administracion.Checked = true;
                    }

                    if (oOI.Liquidaciones.ElementAt(5).importe == 0)
                    {
                        chk_trámites.Checked = false;
                    }

                    else
                    {
                        chk_trámites.Checked = true;
                    }

                    if (oOI.Liquidaciones.ElementAt(6).importe == 0)
                    {
                        chk_representacion_tecnica.Checked = false;
                    }

                    else
                    {
                        chk_representacion_tecnica.Checked = true;
                    }

                    if (oOI.Liquidaciones.ElementAt(7).importe == 0)
                    {
                        chk_direccion_de_la_obra.Checked = false;
                    }

                    else
                    {
                        chk_direccion_de_la_obra.Checked = true;
                    }

                    // Seccion de datos del groupbox "Totales"
                    int i_2 = 0;
                    double suma_2 = 0;
                    while (i_2 < dgv_liquidaciones_OI.Rows.Count)
                    {
                        if (dgv_liquidaciones_OI.Rows[i_2] != null)
                        {
                            suma_2 = Convert.ToDouble(dgv_liquidaciones_OI.Rows[i_2].Cells[3].Value) + suma_2;
                        }

                        i_2++;
                    }

                    txt_total_a_liquidar.Text = suma_2.ToString();
                    txt_aportes_al_cie.Text = ((suma_2) * 0.05).ToString();
                    txt_aportes_a_caja.Text = ((suma_2) * 0.23).ToString();
                    txt_total_aportes.Text = (((suma_2) * 0.05) + ((suma_2) * 0.23)).ToString();
                    InhabilitarTxts();
                }

                dtp_fecha_recepcion.Checked.Equals(true);


                #endregion
            }
        }

        // Constructor de las "Fuerza Electromotriz"
        public FrmExpediente(string fModo, Modelo_Entidades.FE miFE, Modelo_Entidades.Usuario miUsuario)
        {
            InitializeComponent();

            // Declaro las controladoras a utilizar en el formulario
            cExpediente = Controladora.cExpediente.ObtenerInstancia();
            cLiquidacion = Controladora.cLiquidacion.ObtenerInstancia();
            cProfesional = Controladora.cProfesional.ObtenerInstancia();
            cTarea = Controladora.cTarea.ObtenerInstancia();
            cMovimiento = Controladora.cMovimiento.ObtenerInstancia();
            cTipo_Movimiento = Controladora.cTipo_Movimiento.ObtenerInstancia();
            cCtaCte = Controladora.cCtaCte.ObtenerInstancia();

            // Instancio el binding source
            BsLiquidaciones_FE = new BindingSource();
            //Luego lo lleno con los datos de la grilla
            //BsLiquidaciones_FE.DataSource = dgv_liquidaciones_FE;

            modo = fModo;
            oFE = miFE;
            oUsuario = miUsuario;

            lb_tipo_expediente.Text = "Fuerza Electromotriz";

            chk_aportes.Visible = false;

            tab_expedientes.TabPages.Remove(tab_HM);
            tab_expedientes.TabPages.Remove(tb_OI);

            cmb_tareas_fe.DataSource = cTarea.ObtenerTareas();
            cmb_tareas_fe.DisplayMember = "descripcion";

            if (modo == "Alta")
            {
                lb_numero_expediente.Text = "S/N";
                lb_estado_expediente.Text = "Recibido";
                oFE.estado = "Recibido";

                dtp_fecha_aprobacion.Checked = false;
                dtp_fecha_pago.Checked = false;
                dtp_fecha_devolución.Checked = false;

                // Si el expte es nuevo, lo cargo con la fecha actual
                dtp_fecha_recepcion.Value = DateTime.Now;
            }

            else
            {
                if (modo == "Consulta")
                {
                    InhabilitarControles();

                    gb_liquidacion_FE.Enabled = false;
                    gb_dias_FE.Enabled = false;
                    gb_datos_liquidacion_FE.Enabled = false;
                }

                #region Datos del expediente

                lb_numero_expediente.Text = oFE.numero.ToString();
                lb_estado_expediente.Text = oFE.estado;

                dtp_fecha_recepcion.Value = oFE.fecha_recepcion;

                switch (oFE.estado)
                {
                    case ("Recibido"):
                        {
                            dtp_fecha_aprobacion.Checked = false;
                            dtp_fecha_pago.Checked = false;
                            dtp_fecha_devolución.Checked = false;
                            dtp_fecha_recepcion.Value = oFE.fecha_recepcion;
                            break;
                        }

                    case ("Aprobado"):
                        {
                            dtp_fecha_aprobacion.Checked = true;
                            dtp_fecha_pago.Checked = false;
                            dtp_fecha_devolución.Checked = false;
                            dtp_fecha_recepcion.Value = oFE.fecha_recepcion;
                            dtp_fecha_aprobacion.Value = oFE.fecha_aprobacion;
                            break;
                        }

                    case ("Pagado"):
                        {
                            dtp_fecha_aprobacion.Checked = true;
                            dtp_fecha_pago.Checked = true;
                            dtp_fecha_devolución.Checked = false;
                            dtp_fecha_recepcion.Value = oFE.fecha_recepcion;
                            dtp_fecha_aprobacion.Value = oFE.fecha_aprobacion;
                            dtp_fecha_pago.Value = oFE.fecha_pago;
                            break;
                        }

                    case ("Devuelto"):
                        {
                            dtp_fecha_devolución.Checked = true;
                            dtp_fecha_recepcion.Value = oFE.fecha_recepcion;
                            dtp_fecha_aprobacion.Value = oFE.fecha_aprobacion;
                            dtp_fecha_pago.Value = oFE.fecha_pago;
                            dtp_fecha_devolución.Value = oFE.fecha_devolucion;
                            break;
                        }
                }

                txt_comitente.Text = oFE.Comitente.razon_social;
                // Limpio la grilla
                dgv_profesionales.DataSource = null;
                // Asigno el binding a la grilla
                dgv_profesionales.DataSource = oFE.Profesionales;
                ArmaProefesionales();
                #endregion

                #region Datos propios de la OI

                nud_dias_campo_FE.Value = oFE.dias_de_campo;
                nud_dias_gabinete_FE.Value = oFE.dias_de_gabinete;
                nud_num_hp_FE.Value = oFE.hps;
                nud_num_bocas_FE.Value = oFE.bocas;
                nud_num_motores_FE.Value = oFE.motores;

                // Limpio la grilla
                dgv_liquidaciones_FE.DataSource = null;
                // LLeno el binding con los datos que traigo de las entidades
                BsLiquidaciones_FE.DataSource = oFE.Liquidaciones;
                // Asigno el binding a la grilla
                dgv_liquidaciones_FE.DataSource = BsLiquidaciones_FE;
                dgv_liquidaciones_FE.Columns[0].Visible = false;
                dgv_liquidaciones_FE.Columns[1].HeaderText = "Tarea";
                dgv_liquidaciones_FE.Columns[2].HeaderText = "Cantidad";
                dgv_liquidaciones_FE.Columns[3].HeaderText = "Importe";
                dgv_liquidaciones_FE.Columns[4].Visible = false;

                // Seccion de datos del groupbox "Totales"
                int i = 0;
                double suma_2 = 0;
                while (i < dgv_liquidaciones_FE.Rows.Count)
                {
                    if (dgv_liquidaciones_FE.Rows[i] != null)
                    {
                        suma_2 = Convert.ToDouble(dgv_liquidaciones_FE.Rows[i].Cells[3].Value) + suma_2;
                    }

                    i++;
                }

                txt_total_a_liquidar.Text = suma_2.ToString();
                txt_aportes_al_cie.Text = ((suma_2) * 0.05).ToString();
                txt_aportes_a_caja.Text = ((suma_2) * 0.23).ToString();
                txt_total_aportes.Text = (((suma_2) * 0.05) + ((suma_2) * 0.23)).ToString();
                InhabilitarTxts();
                #endregion
            }                
        }

        // Constructor del "Honorario Mínimo"
        public FrmExpediente(string fModo, Modelo_Entidades.HM miHM, Modelo_Entidades.Usuario miUsuario)
        {
            InitializeComponent();

            // Declaro las controladoras a utilizar en el formulario
            cExpediente = Controladora.cExpediente.ObtenerInstancia();
            cLiquidacion = Controladora.cLiquidacion.ObtenerInstancia();
            cProfesional = Controladora.cProfesional.ObtenerInstancia();
            cTarea = Controladora.cTarea.ObtenerInstancia();
            cMovimiento = Controladora.cMovimiento.ObtenerInstancia();
            cTipo_Movimiento = Controladora.cTipo_Movimiento.ObtenerInstancia();
            cCtaCte = Controladora.cCtaCte.ObtenerInstancia();

            // Instancio el binding source
            BsLiquidaciones_HM = new BindingSource();
            //Luego lo lleno con los datos de la grilla
            //BsLiquidaciones_HM.DataSource = dgv_liquidaciones_HM;

            // Instancio el binding source
            BsProfesionales = new BindingSource();
            //Luego lo lleno con los datos de la grilla
            BsProfesionales.DataSource = dgv_profesionales;

            modo = fModo;
            oHM = miHM;
            oUsuario = miUsuario;

            lb_tipo_expediente.Text = "Honorario Mínimo";


            chk_aportes.Visible = false;

            tab_expedientes.TabPages.Remove(tb_FE);
            tab_expedientes.TabPages.Remove(tb_OI);

            cmb_tareas_hm.DataSource = cTarea.ObtenerTareas();
            cmb_tareas_hm.DisplayMember = "descripcion";

            if (modo == "Alta")
            {
                lb_numero_expediente.Text = "S/N";
                lb_estado_expediente.Text = "Recibido";
                oHM.estado = "Recibido";

                dtp_fecha_aprobacion.Checked = false;
                dtp_fecha_pago.Checked = false;
                dtp_fecha_devolución.Checked = false;

                // Si el expte es nuevo, lo cargo con la fecha actual
                dtp_fecha_recepcion.Value = DateTime.Now;
            }

            else
            {
                if (modo == "Consulta")
                {
                    InhabilitarControles();

                    gb_liquidacion_HM.Enabled = false;
                    gb_dias_HM.Enabled = false;
                }

                #region Datos del expediente

                lb_numero_expediente.Text = oHM.numero.ToString();
                lb_estado_expediente.Text = oHM.estado;

                dtp_fecha_recepcion.Value = oHM.fecha_recepcion;

                switch (oHM.estado)
                {
                    case ("Recibido"):
                        {
                            dtp_fecha_aprobacion.Checked = false;
                            dtp_fecha_devolución.Checked = false;
                            dtp_fecha_pago.Checked = false;
                            dtp_fecha_recepcion.Value = oHM.fecha_recepcion;
                            break;
                        }

                    case ("Aprobado"):
                        {
                            dtp_fecha_aprobacion.Checked = true;
                            dtp_fecha_pago.Checked = false;
                            dtp_fecha_devolución.Checked = false;
                            dtp_fecha_recepcion.Value = oHM.fecha_recepcion;
                            dtp_fecha_aprobacion.Value = oHM.fecha_aprobacion;
                            break;
                        }

                    case ("Pagado"):
                        {
                            dtp_fecha_aprobacion.Checked = true;
                            dtp_fecha_pago.Checked = true;
                            dtp_fecha_devolución.Checked = false;
                            dtp_fecha_recepcion.Value = oHM.fecha_recepcion;
                            dtp_fecha_aprobacion.Value = oHM.fecha_aprobacion;
                            dtp_fecha_pago.Value = oHM.fecha_pago;
                            break;
                        }


                    case ("Devuelto"):
                        {
                            dtp_fecha_devolución.Checked = true;
                            dtp_fecha_recepcion.Value = oHM.fecha_recepcion;
                            dtp_fecha_aprobacion.Value = oHM.fecha_aprobacion;
                            dtp_fecha_pago.Value = oHM.fecha_pago;
                            dtp_fecha_devolución.Value = oHM.fecha_devolucion;
                            break;
                        }
                }

                txt_comitente.Text = oHM.Comitente.razon_social;
                // Limpio la grilla
                dgv_profesionales.DataSource = null;
                // Asigno el binding a la grilla
                dgv_profesionales.DataSource = oHM.Profesionales;
                ArmaProefesionales();
                #endregion

                #region Datos propios del HM
                nud_dias_campo_HM.Value = oHM.dias_de_campo;
                nud_dias_gabinete_HM.Value = oHM.dias_de_gabinete;

                // Limpio la grilla
                dgv_liquidaciones_HM.DataSource = null;
                // LLeno el binding con los datos que traigo de las entidades
                BsLiquidaciones_HM.DataSource = oHM.Liquidaciones;
                // Asigno el binding a la grilla
                dgv_liquidaciones_HM.DataSource = BsLiquidaciones_HM;
                dgv_liquidaciones_HM.Columns[0].Visible = false;
                dgv_liquidaciones_HM.Columns[1].HeaderText = "Tarea";
                dgv_liquidaciones_HM.Columns[2].HeaderText = "Cantidad";
                dgv_liquidaciones_HM.Columns[3].HeaderText = "Importe";
                dgv_liquidaciones_HM.Columns[4].Visible = false;

                // Seccion de datos del groupbox "Totales"
                int i_1 = 0;
                double suma_2 = 0;
                while (i_1 < dgv_liquidaciones_HM.Rows.Count)
                {
                    if (dgv_liquidaciones_HM.Rows[i_1] != null)
                    {
                        suma_2 = Convert.ToDouble(dgv_liquidaciones_HM.Rows[i_1].Cells[3].Value) + suma_2;
                    }

                    i_1++;
                }

                txt_total_a_liquidar.Text = suma_2.ToString();
                txt_aportes_al_cie.Text = ((suma_2) * 0.05).ToString();
                txt_aportes_a_caja.Text = ((suma_2) * 0.23).ToString();
                txt_total_aportes.Text = (((suma_2) * 0.05) + ((suma_2) * 0.23)).ToString();
                InhabilitarTxts();
                #endregion
            }
        }

        // Al cargar el formulario
        private void FrmExpediente_Load(object sender, EventArgs e)
        {

        }

        // Armo los profesionales del expediente
        private void ArmaProefesionales()
        {
            // Asigno el binding a la grilla
            dgv_profesionales.Columns[0].HeaderText = "DNI";
            dgv_profesionales.Columns[1].HeaderText = "Nombre y Apellido";
            dgv_profesionales.Columns[2].Visible = false;
            dgv_profesionales.Columns[3].Visible = false;
            dgv_profesionales.Columns[4].Visible = false;
            dgv_profesionales.Columns[5].Visible = false;
            dgv_profesionales.Columns[6].Visible = false;
            dgv_profesionales.Columns[7].Visible = false;
            dgv_profesionales.Columns[8].Visible = false;
            dgv_profesionales.Columns[9].Visible = false;
            dgv_profesionales.Columns[10].Visible = false;
            dgv_profesionales.Columns[11].Visible = false;
            dgv_profesionales.Columns[12].Visible = false;
            dgv_profesionales.Columns[13].Visible = false;
            dgv_profesionales.Columns[14].Visible = false;
            dgv_profesionales.Columns[15].Visible = false;
            dgv_profesionales.Columns[16].Visible = false;
            dgv_profesionales.Columns[17].HeaderText = "Estado";
            dgv_profesionales.Columns[18].Visible = false;
            dgv_profesionales.Columns[19].HeaderText = "Tipo de Matricula";
            dgv_profesionales.Columns[20].Visible = false;
            dgv_profesionales.Columns[21].Visible = false;
            dgv_profesionales.Columns[22].Visible = false;
        }

        // Al hacer click en "Guardar"
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Modelo_Entidades.Expediente oExpediente;

            if (ValidarObligatorios() == true)
            {
                try
                {
                    string eleccion = lb_tipo_expediente.Text;
                    switch (eleccion)
                    {
                    case ("Obras de Ingenieria"):
                        oExpediente = oOI;
                        GuardarExpte(oExpediente);                        
                        break;
                    case ("Fuerza Electromotriz"):
                        oExpediente = oFE;
                        GuardarExpte(oExpediente);    
                        break;
                    case ("Honorario Mínimo"):
                        oExpediente = oHM;
                        GuardarExpte(oExpediente);
                        break;
                    }
                }

                catch (Exception Exc)
                {
                    MessageBox.Show(Exc.Message.ToString());
                }

                this.Close();
            }
        }

        // Para guardar el expediente, genero un métedo
        private void GuardarExpte(Modelo_Entidades.Expediente oExpediente)
        {
            // A los profesionales los guardo cuando armo la lista
            oExpediente.fecha_recepcion = dtp_fecha_recepcion.Value;
            oExpediente.fecha_aprobacion = dtp_fecha_aprobacion.Value;
            oExpediente.fecha_devolucion = dtp_fecha_devolución.Value;         

            if (chk_aportes.Checked == false)
            {
                oExpediente.tipo_aporte = false;
            }

            else
            {
                oExpediente.tipo_aporte = true;
            }

            // Al comitente lo guardo cuando lo termino de elegir
            // A las liquidaciones ya las guardo cuando liquido el expediente

            if (modo == "Alta" && oExpediente.Liquidaciones.Count == 0)
            {
                cExpediente.AgregarExpediente(oExpediente);
            }

            else
            {
                cExpediente.ModificarExpediente(oExpediente);
            }            
        }

        // Valido los datos del expediente
        private bool ValidarObligatorios()
        {
            if (dgv_profesionales.DataSource == null)
            {
                MessageBox.Show("Debe seleccionar al menos un profesional para el expediente");
                return false;
            }

            if (dtp_fecha_recepcion.Value == null)
            {
                MessageBox.Show("Debe ingresar al menos una fecha de recepción para el expediente");
                return false;
            }

            if (string.IsNullOrEmpty(txt_comitente.Text))
            {
                MessageBox.Show("Debe ingresar una comitente para el expediente");
                return false;
            }

            return true;
        }

        // Cuando le doy click a "Liquidar"
        private void btn_liquidar_Click(object sender, EventArgs e)
        {
            string eleccion = lb_tipo_expediente.Text;            

            switch (eleccion)
            {
                #region Liquidación OI
                case ("Obras de Ingenieria"):
                    if (oOI.Comitente == null || oOI.Profesionales == null)
                    {
                        MessageBox.Show("Antes de liquidar el expediente, debe ingresar un comitente y al menos un profesional");
                        return;
                    }

                    else
                    {
                        if (BsLiquidaciones_OI.Count != 0)
                        {
                            DialogResult result = MessageBox.Show("Ya ha realizado la liquidación del expediente. ¿Desea realizarla de nuevo?", "Salir", MessageBoxButtons.YesNoCancel);

                            if (result == DialogResult.Yes)
                            {
                                Liquidar_OI();
                            }
                            else if (result == DialogResult.No)
                            {
                                return;
                            }

                            else if (result == DialogResult.Cancel)
                            {
                                return;
                            }
                        }
                        else
                        {
                            Liquidar_OI();
                        }
                    }
                    break;

                #endregion                

                #region Liquidación FE
                case ("Fuerza Electromotriz"):
                    if (oFE.Comitente == null || oFE.Profesionales == null)
                    {
                        MessageBox.Show("Antes de liquidar el expediente, debe ingresar un comitente y al menos un profesional");
                        return;
                    }

                    else
                    {
                        if (BsLiquidaciones_FE.Count != 0)
                        {
                            DialogResult result1 = MessageBox.Show("Ya ha realizado la liquidación del expediente. ¿Desea realizarla de nuevo?", "Salir", MessageBoxButtons.YesNoCancel);
                            if (result1 == DialogResult.Yes)
                            {
                                Liquidar_FE();
                            }

                            else if (result1 == DialogResult.No)
                            {
                                return;
                            }

                            else if (result1 == DialogResult.Cancel)
                            {
                                return;
                            }
                        }

                        else
                        {
                            Liquidar_FE();
                        }
                    }
                    break;
                #endregion                

                #region Liquidación HM
                case ("Honorario Mínimo"):
                    if (oHM.Comitente == null || oHM.Profesionales == null)
                    {
                        MessageBox.Show("Antes de liquidar el expediente, debe ingresar un comitente y al menos un profesional");
                        return;
                    }

                    else
                    {
                        if (BsLiquidaciones_HM.DataSource != null)
                        {
                            DialogResult result1 = MessageBox.Show("Ya ha realizado la liquidación del expediente. ¿Desea realizarla de nuevo?", "Salir", MessageBoxButtons.YesNoCancel);
                            if (result1 == DialogResult.Yes)
                            {
                                Liquidar_HM();
                            }

                            else if (result1 == DialogResult.No)
                            {
                                return;
                            }

                            else if (result1 == DialogResult.Cancel)
                            {
                                return;
                            }
                        }

                        else
                        {
                            Liquidar_HM();
                        }
                    }
                    break;

                #endregion                
            }
        }

        // Creo un método para inhabilitar los controles para la consulta
        private void InhabilitarControles()
        {
            btn_guardar.Enabled = false;
            btn_liquidar.Enabled = false;
            btn_cancelar.Text = "Cerrar";

            gb_cabezera.Enabled = false;
            gb_totales.Enabled = false;

            gb_profesionales.Enabled = false;
            gb_fechas.Enabled = false;
            gb_comitente.Enabled = false;
        }

        // Cuando le doy click a "Cancelar"
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cuando le doy click a seleccionar comitente
        private void btn_seleccionar_comitente_Click(object sender, EventArgs e)
        {
            string eleccion = lb_tipo_expediente.Text;

            if (txt_comitente.Text != "")
            {
                DialogResult result = MessageBox.Show("Este expediente ya cuenta con un comitente. ¿Desea reemplazarlo?", "Salir", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    // Lo primero que hago es crear un formulario de Login, así que instancio las variables
                    FrmSeleccionComitentes FormularioComitentes = new FrmSeleccionComitentes();
                    DialogResult DrLogin = FormularioComitentes.ShowDialog();

                    // Finalmente, agrego o no el comitente al expediente
                    if (DrLogin != DialogResult.OK)
                    {
                        return;
                    }

                    // Finalmente, agrego el comitente al expediente 
                    oComitente = FormularioComitentes.ComitenteElegido;

                    switch (eleccion)
                    {
                        case ("Obras de Ingenieria"):
                            oOI.Comitente = oComitente;
                            break;
                        case ("Fuerza Electromotriz"):
                            oFE.Comitente = oComitente;
                            break;
                        case ("Honorario Mínimo"):
                            oHM.Comitente = oComitente;
                            break;
                    }
                }

                else if (result == DialogResult.No)
                {
                    return;
                }

                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            else
            {
                // Lo primero que hago es crear un formulario de Login, así que instancio las variables
                FrmSeleccionComitentes FormularioComitentes = new FrmSeleccionComitentes();
                DialogResult DrLogin = FormularioComitentes.ShowDialog();

                // Finalmente, agrego o no el comitente al expediente
                if (DrLogin != DialogResult.OK)
                {
                    return;
                }

                // Finalmente, agrego el comitente al expediente 
                oComitente = FormularioComitentes.ComitenteElegido;

                switch (eleccion)
                {
                    case ("Obras de Ingenieria"):
                        oOI.Comitente = oComitente;
                        break;
                    case ("Fuerza Electromotriz"):
                        oFE.Comitente = oComitente;
                        break;
                    case ("Honorario Mínimo"):
                        oHM.Comitente = oComitente;
                        break;
                }
            }

            // Lo muestro en el textbox
            txt_comitente.Text = oComitente.razon_social;
        }

        // Cuando le doy click a "Agregar"
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string eleccion = lb_tipo_expediente.Text;

            // Lo primero que hago es crear un formulario de Login, así que instancio las variables
            FrmSeleccionProfesionales FormularioProfesionales = new FrmSeleccionProfesionales(oUsuario);
            DialogResult DrLogin = FormularioProfesionales.ShowDialog();

            // Finalmente, agrego o no el comitente al expediente
            if (DrLogin != DialogResult.OK)
            {
                return;
            }

            else
            {
                oProfesional = FormularioProfesionales.ProfesionalElegido;

                if (oProfesional.Estado.descripcion == "No Habilitado" || oProfesional.Estado.descripcion == "Baja")
                {
                    MessageBox.Show("El profesional no se encuentra habilitado para realizar el expediente");
                }

                else
                {
                    switch (eleccion)
                    {
                        case ("Obras de Ingenieria"):
                            oOI.Profesionales.Add(oProfesional);
                            // Limpio la grilla
                            dgv_profesionales.DataSource = null;
                            // Asigno el binding a la grilla
                            dgv_profesionales.DataSource = oOI.Profesionales;
                            ArmaProefesionales();
                            break;
                        case ("Fuerza Electromotriz"):
                            oFE.Profesionales.Add(oProfesional);
                            // Limpio la grilla
                            dgv_profesionales.DataSource = null;
                            // Asigno el binding a la grilla
                            dgv_profesionales.DataSource = oFE.Profesionales;
                            ArmaProefesionales();
                            break;
                        case ("Honorario Mínimo"):
                            oHM.Profesionales.Add(oProfesional);
                            // Limpio la grilla
                            dgv_profesionales.DataSource = null;
                            // Asigno el binding a la grilla
                            dgv_profesionales.DataSource = oHM.Profesionales;
                            ArmaProefesionales();
                            break;
                    }
                }
            }
        }

        // Cuando le doy click a "Quitar"
        private void btn_quitar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea quitar al profesional?", "Expediente", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string eleccion = lb_tipo_expediente.Text;

                // Finalmente, agrego el comitente al expediente 
                oProfesional = (Modelo_Entidades.Profesional)dgv_profesionales.CurrentRow.DataBoundItem;

                switch (eleccion)
                {
                    case ("Obras de Ingenieria"):
                        oOI.Profesionales.Remove(oProfesional);
                        // Limpio la grilla
                        dgv_profesionales.DataSource = null;
                        // Asigno el binding a la grilla
                        dgv_profesionales.DataSource = oOI.Profesionales;
                        ArmaProefesionales();
                        break;
                    case ("Fuerza Electromotriz"):
                        oFE.Profesionales.Remove(oProfesional);
                        // Limpio la grilla
                        dgv_profesionales.DataSource = null;
                        // Asigno el binding a la grilla
                        dgv_profesionales.DataSource = oFE.Profesionales;
                        ArmaProefesionales();
                        break;
                    case ("Honorario Mínimo"):
                        oHM.Profesionales.Remove(oProfesional);
                        // Limpio la grilla
                        dgv_profesionales.DataSource = null;
                        // Asigno el binding a la grilla
                        dgv_profesionales.DataSource = oHM.Profesionales;
                        ArmaProefesionales();
                        break;
                } 
            }

            else
            {
                return;
            }
        }

        // Liquido las OI
        private void Liquidar_OI()
        {
            // Lo 1º que hago es eliminar la liquidación anterior
            foreach (Modelo_Entidades.Liquidacion oLiq in cLiquidacion.ObtenerLiquidaciones())
            {
                if (oOI.numero == oLiq.Expediente.numero)
                {
                    cLiquidacion.EliminarLiquidacion(oLiq);
                }
            }

            #region Liquidación del OI
            // Faltaria validar los datos del OI (con un metodo)
            decimal monto_obra_definitivo = cExpediente.CalcularTotalaLiquidar_OI(nud_monto_obra_OI.Value);
            monto_obra = monto_obra_definitivo;

            if (chk_anteproyecto.Checked == true) // Verifica si esta tildado
            {
                // Liquido el anteproyecto (10%)
                Modelo_Entidades.Liquidacion NuevaLiquidacion_a = new Modelo_Entidades.Liquidacion();
                NuevaLiquidacion_a.tarea = "Anteproyecto";
                NuevaLiquidacion_a.cantidad = 1; // Es siempre 1, ya que existe solo 1 liqudiacion de anteproyecto
                NuevaLiquidacion_a.importe = monto_obra;
                NuevaLiquidacion_a.Expediente = oOI;
                cLiquidacion.AgregarLiquidacion(NuevaLiquidacion_a);
                oOI.Liquidaciones.Add(NuevaLiquidacion_a);
            }

            else
            {
                // Liquido el anteproyecto (10%)
                Modelo_Entidades.Liquidacion NuevaLiquidacion_a = new Modelo_Entidades.Liquidacion();
                NuevaLiquidacion_a.tarea = "Anteproyecto";
                NuevaLiquidacion_a.cantidad = 1; // Es siempre 1, ya que existe solo 1 liqudiacion de anteproyecto
                NuevaLiquidacion_a.importe = 0;
                NuevaLiquidacion_a.Expediente = oOI;
                cLiquidacion.AgregarLiquidacion(NuevaLiquidacion_a);
                oOI.Liquidaciones.Add(NuevaLiquidacion_a);
            }

            if (chk_proyecto_sin_anteproyecto.Checked == true) // Verifica si esta tildado
            {
                // Liquido el proyecto sin el anteproyecto (45%)
                Modelo_Entidades.Liquidacion NuevaLiquidacion_b = new Modelo_Entidades.Liquidacion();
                NuevaLiquidacion_b.tarea = "Proyecto sin anteproyecto";
                NuevaLiquidacion_b.cantidad = 1; // Es siempre 1, ya que existe solo 1 liqudiacion de anteproyecto
                NuevaLiquidacion_b.importe = monto_obra;
                NuevaLiquidacion_b.Expediente = oOI;
                cLiquidacion.AgregarLiquidacion(NuevaLiquidacion_b);
                oOI.Liquidaciones.Add(NuevaLiquidacion_b);
            }

            else
            {
                // Liquido el proyecto sin el anteproyecto (45%)
                Modelo_Entidades.Liquidacion NuevaLiquidacion_b = new Modelo_Entidades.Liquidacion();
                NuevaLiquidacion_b.tarea = "Proyecto sin anteproyecto";
                NuevaLiquidacion_b.cantidad = 1; // Es siempre 1, ya que existe solo 1 liqudiacion de anteproyecto
                NuevaLiquidacion_b.importe = 0;
                NuevaLiquidacion_b.Expediente = oOI;
                cLiquidacion.AgregarLiquidacion(NuevaLiquidacion_b);
                oOI.Liquidaciones.Add(NuevaLiquidacion_b);
            }

            if (chk_proyecto.Checked == true) // Verifica si esta tildado
            {
                // Liquido el proyecto (55%)
                Modelo_Entidades.Liquidacion NuevaLiquidacion_c = new Modelo_Entidades.Liquidacion();
                NuevaLiquidacion_c.tarea = "Proyecto de la obra";
                NuevaLiquidacion_c.cantidad = 1; // Es siempre 1, ya que existe solo 1 liqudiacion de Proyecto de la obra
                NuevaLiquidacion_c.importe = monto_obra;
                NuevaLiquidacion_c.Expediente = oOI;
                cLiquidacion.AgregarLiquidacion(NuevaLiquidacion_c);
                oOI.Liquidaciones.Add(NuevaLiquidacion_c);
            }

            else
            {
                // Liquido el proyecto (55%)
                Modelo_Entidades.Liquidacion NuevaLiquidacion_c = new Modelo_Entidades.Liquidacion();
                NuevaLiquidacion_c.tarea = "Proyecto de la obra";
                NuevaLiquidacion_c.cantidad = 1; // Es siempre 1, ya que existe solo 1 liqudiacion de Proyecto de la obra
                NuevaLiquidacion_c.importe = 0;
                NuevaLiquidacion_c.Expediente = oOI;
                cLiquidacion.AgregarLiquidacion(NuevaLiquidacion_c);
                oOI.Liquidaciones.Add(NuevaLiquidacion_c);
            }

            if (chk_conduccion_tecnica.Checked == true) // Verifica si esta tildado
            {
                // Liquido la conducción técnica (45%)
                Modelo_Entidades.Liquidacion NuevaLiquidacion_d = new Modelo_Entidades.Liquidacion();
                NuevaLiquidacion_d.tarea = "Conducción técnica de la obra";
                NuevaLiquidacion_d.cantidad = 1; // Es siempre 1, ya que existe solo 1 liqudiacion de Conducción técnica de la obra
                NuevaLiquidacion_d.importe = monto_obra;
                NuevaLiquidacion_d.Expediente = oOI;
                cLiquidacion.AgregarLiquidacion(NuevaLiquidacion_d);
                oOI.Liquidaciones.Add(NuevaLiquidacion_d);
            }

            else
            {
                // Liquido la conducción técnica (45%)
                Modelo_Entidades.Liquidacion NuevaLiquidacion_d = new Modelo_Entidades.Liquidacion();
                NuevaLiquidacion_d.tarea = "Conducción técnica de la obra";
                NuevaLiquidacion_d.cantidad = 1; // Es siempre 1, ya que existe solo 1 liqudiacion de Conducción técnica de la obra
                NuevaLiquidacion_d.importe = 0;
                NuevaLiquidacion_d.Expediente = oOI;
                cLiquidacion.AgregarLiquidacion(NuevaLiquidacion_d);
                oOI.Liquidaciones.Add(NuevaLiquidacion_d);
            }

            if (chk_administracion.Checked == true) // Verifica si esta tildado
            {
                // Liquido la Administración a cargo del comitente (13.5%)
                Modelo_Entidades.Liquidacion NuevaLiquidacion_e = new Modelo_Entidades.Liquidacion();
                NuevaLiquidacion_e.tarea = "Administración a cargo del comitente";
                NuevaLiquidacion_e.cantidad = 1; // Es siempre 1, ya que existe solo 1 liqudiacion de Administración a cargo del comitente
                NuevaLiquidacion_e.importe = monto_obra;
                NuevaLiquidacion_e.Expediente = oOI;
                cLiquidacion.AgregarLiquidacion(NuevaLiquidacion_e);
                oOI.Liquidaciones.Add(NuevaLiquidacion_e);
            }

            else
            {
                // Liquido la Administración a cargo del comitente (13.5%)
                Modelo_Entidades.Liquidacion NuevaLiquidacion_e = new Modelo_Entidades.Liquidacion();
                NuevaLiquidacion_e.tarea = "Administración a cargo del comitente";
                NuevaLiquidacion_e.cantidad = 1; // Es siempre 1, ya que existe solo 1 liqudiacion de Administración a cargo del comitente
                NuevaLiquidacion_e.importe = 0;
                NuevaLiquidacion_e.Expediente = oOI;
                cLiquidacion.AgregarLiquidacion(NuevaLiquidacion_e);
                oOI.Liquidaciones.Add(NuevaLiquidacion_e);
            }

            if (chk_trámites.Checked == true) // Verifica si esta tildado
            {
                // Liquido los trámites (0.2%) (es sobre el monto de obra)
                Modelo_Entidades.Liquidacion NuevaLiquidacion_f = new Modelo_Entidades.Liquidacion();
                NuevaLiquidacion_f.tarea = "Trámites";
                NuevaLiquidacion_f.cantidad = 1; // Es siempre 1, ya que existe solo 1 liqudiacion de Trámites
                NuevaLiquidacion_f.importe = nud_monto_obra_OI.Value;
                NuevaLiquidacion_f.Expediente = oOI;
                cLiquidacion.AgregarLiquidacion(NuevaLiquidacion_f);
                oOI.Liquidaciones.Add(NuevaLiquidacion_f);
            }

            else
            {
                // Liquido los trámites (0.2%) (es sobre el monto de obra)
                Modelo_Entidades.Liquidacion NuevaLiquidacion_f = new Modelo_Entidades.Liquidacion();
                NuevaLiquidacion_f.tarea = "Trámites";
                NuevaLiquidacion_f.cantidad = 1; // Es siempre 1, ya que existe solo 1 liqudiacion de Trámites
                NuevaLiquidacion_f.importe = 0;
                NuevaLiquidacion_f.Expediente = oOI;
                cLiquidacion.AgregarLiquidacion(NuevaLiquidacion_f);
                oOI.Liquidaciones.Add(NuevaLiquidacion_f);
            }

            if (chk_representacion_tecnica.Checked == true) // Verifica si esta tildado
            {
                // Liquido la representación técnica de la obra (13.5% + 45%)
                Modelo_Entidades.Liquidacion NuevaLiquidacion_g = new Modelo_Entidades.Liquidacion();
                NuevaLiquidacion_g.tarea = "Representación técnica de la obra";
                NuevaLiquidacion_g.cantidad = 1; // Es siempre 1, ya que existe solo 1 liqudiacion de Representación técnica de la obra
                NuevaLiquidacion_g.importe = monto_obra;
                NuevaLiquidacion_g.Expediente = oOI;
                cLiquidacion.AgregarLiquidacion(NuevaLiquidacion_g);
                oOI.Liquidaciones.Add(NuevaLiquidacion_g);
            }

            else
            {
                // Liquido la representación técnica de la obra (13.5% + 45%)
                Modelo_Entidades.Liquidacion NuevaLiquidacion_g = new Modelo_Entidades.Liquidacion();
                NuevaLiquidacion_g.tarea = "Representación técnica de la obra";
                NuevaLiquidacion_g.cantidad = 1; // Es siempre 1, ya que existe solo 1 liqudiacion de Representación técnica de la obra
                NuevaLiquidacion_g.importe = 0;
                NuevaLiquidacion_g.Expediente = oOI;
                cLiquidacion.AgregarLiquidacion(NuevaLiquidacion_g);
                oOI.Liquidaciones.Add(NuevaLiquidacion_g);
            }

            if (chk_direccion_de_la_obra.Checked == true) // Verifica si esta tildado
            {
                // Liquido la dirección de la obra (45%)
                Modelo_Entidades.Liquidacion NuevaLiquidacion_h = new Modelo_Entidades.Liquidacion();
                NuevaLiquidacion_h.tarea = "Dirección de la obra";
                NuevaLiquidacion_h.cantidad = 1; // Es siempre 1, ya que existe solo 1 liqudiacion de Dirección de la obra
                NuevaLiquidacion_h.importe = monto_obra;
                NuevaLiquidacion_h.Expediente = oOI;
                cLiquidacion.AgregarLiquidacion(NuevaLiquidacion_h);
                oOI.Liquidaciones.Add(NuevaLiquidacion_h);
            }

            else
            {
                // Liquido la dirección de la obra (45%)
                Modelo_Entidades.Liquidacion NuevaLiquidacion_h = new Modelo_Entidades.Liquidacion();
                NuevaLiquidacion_h.tarea = "Dirección de la obra";
                NuevaLiquidacion_h.cantidad = 1; // Es siempre 1, ya que existe solo 1 liqudiacion de Dirección de la obra
                NuevaLiquidacion_h.importe = 0;
                NuevaLiquidacion_h.Expediente = oOI;
                cLiquidacion.AgregarLiquidacion(NuevaLiquidacion_h);
                oOI.Liquidaciones.Add(NuevaLiquidacion_h);
            }
            #endregion

            // Limpio la grilla
            dgv_liquidaciones_OI.DataSource = null;
            // LLeno el binding con los datos que traigo de las entidades
            BsLiquidaciones_OI.DataSource = cExpediente.LiquidarExpediente(oOI);
            // Asigno el binding a la grilla
            dgv_liquidaciones_OI.DataSource = BsLiquidaciones_OI;
            // Asigno el binding a la grilla
            dgv_liquidaciones_OI.Columns[0].Visible = false;
            dgv_liquidaciones_OI.Columns[1].HeaderText = "Tarea";
            dgv_liquidaciones_OI.Columns[2].HeaderText = "Cantidad";
            dgv_liquidaciones_OI.Columns[3].HeaderText = "Importe";
            dgv_liquidaciones_OI.Columns[4].Visible = false;

            int i_2 = 0;
            double suma_2 = 0;
            while (i_2 < dgv_liquidaciones_OI.Rows.Count)
            {
                if (dgv_liquidaciones_OI.Rows[i_2] != null)
                {
                    suma_2 = Convert.ToDouble(dgv_liquidaciones_OI.Rows[i_2].Cells[3].Value) + suma_2;
                }

                i_2++;
            }

            txt_total_a_liquidar.Text = suma_2.ToString();
            txt_aportes_al_cie.Text = ((suma_2) * 0.05).ToString();
            txt_aportes_a_caja.Text = ((suma_2) * 0.23).ToString();
            txt_total_aportes.Text = (((suma_2) * 0.05) + ((suma_2) * 0.23)).ToString();
            InhabilitarTxts();

            #region Agregado del saldo a la cta cte del profesional
            oProfesional = ((Modelo_Entidades.Profesional)dgv_profesionales.CurrentRow.DataBoundItem);
            if (cMovimiento.BuscarMovimientoPorDescExpte(oOI.numero) != null) // quiere decir que está, por lo que se tiene que modificar
            {
                oMovimiento = cMovimiento.BuscarMovimientoPorDescExpte(oOI.numero);

                // Lo 1º es sumar el saldo anterior, para que no se siga restando
                oCtaCte = oProfesional.CtaCte;
                oCtaCte.saldo = oCtaCte.saldo + Convert.ToDecimal(oMovimiento.importe);

                // Luego, hago los 2 cambios que afectan al movimiento
                oMovimiento.fecha = DateTime.Now;
                oMovimiento.importe = ((suma_2) * 0.05);
                //oMovimiento.descripcion = "Débito del expediente número " + oOI.numero.ToString();
                //oMovimiento.CtaCte = oProfesional.CtaCte;
                //oMovimiento.Tipo_Movimiento = cTipo_Movimiento.ObtenerMov_Deudor();
                //oMovimiento.Comprobante = oBoleta;

                cMovimiento.ModificarMovimiento(oMovimiento);
                //oProfesional.CtaCte.Movimientos.Add(oMovimiento);

                oCtaCte.saldo = oCtaCte.saldo - Convert.ToDecimal(((suma_2) * 0.05));
                cCtaCte.Modificacion(oCtaCte);
            }

            else
            {
                oMovimiento = new Modelo_Entidades.Movimiento();
                oBoleta = new Modelo_Entidades.Boleta();

                oMovimiento.fecha = DateTime.Now;
                oMovimiento.importe = ((suma_2) * 0.05);
                oMovimiento.descripcion = "Débito del expediente número " + oOI.numero.ToString();
                oMovimiento.CtaCte = oProfesional.CtaCte;
                oMovimiento.Tipo_Movimiento = cTipo_Movimiento.ObtenerMov_Deudor();
                oMovimiento.Comprobante = oBoleta;

                cMovimiento.Alta(oMovimiento);
                oProfesional.CtaCte.Movimientos.Add(oMovimiento);

                oCtaCte = oProfesional.CtaCte;
                oCtaCte.saldo = oCtaCte.saldo - Convert.ToDecimal(((suma_2) * 0.05));
                cCtaCte.Modificacion(oCtaCte);
            }
            #endregion

        }

        // Liquido las FE
        private void Liquidar_FE()
        {
            decimal coeficiente_k;

            // Lo 1º que hago es eliminar la liquidación anterior
            foreach (Modelo_Entidades.Liquidacion oLiq in cLiquidacion.ObtenerLiquidaciones())
            {
                if (oFE.numero == oLiq.Expediente.numero)
                {
                    cLiquidacion.EliminarLiquidacion(oLiq);
                }
            }

            oFE.dias_de_campo = nud_dias_campo_FE.Value;
            oFE.dias_de_gabinete = nud_dias_campo_FE.Value;
            oFE.hps = nud_num_hp_FE.Value;
            oFE.bocas = nud_num_bocas_FE.Value;
            oFE.motores = nud_num_motores_FE.Value;

            // Hago los calculos necesarios para obtener el monto de obra
            coeficiente_k = cExpediente.CalcularCoeficienteK(oFE.hps, oFE.bocas, oFE.motores);

            #region Liquidación del FE
            // Agrego las liquidaciones para que luego pueda modificar sus valores y luegos ponerlas en el datagridview según sea la solapa

            // Liquidacion con respecto a los dias de campo
            Modelo_Entidades.Liquidacion NuevaLiquidacion_1 = new Modelo_Entidades.Liquidacion();
            NuevaLiquidacion_1.tarea = "Dias de campo liquidados";
            NuevaLiquidacion_1.cantidad = nud_dias_campo_FE.Value;
            NuevaLiquidacion_1.importe = 0.4m; // Esta hardcodeado, pero hay que ponerlo para que lo puedan editar en un cuadro grande con los valores de cada una de las posibles liquidaciones de todas las tareas
            NuevaLiquidacion_1.Expediente = oFE;
            cLiquidacion.AgregarLiquidacion(NuevaLiquidacion_1);
            oFE.Liquidaciones.Add(NuevaLiquidacion_1);

            // Liquidacion con respecto a los dias de gabinete
            Modelo_Entidades.Liquidacion NuevaLiquidacion_2 = new Modelo_Entidades.Liquidacion();
            NuevaLiquidacion_2.tarea = "Dias de campo liquidados";
            NuevaLiquidacion_2.cantidad = nud_dias_gabinete_FE.Value;
            NuevaLiquidacion_2.importe = 0.3m; // Esta hardcodeado, pero hay que ponerlo para que lo puedan editar en un cuadro grande con los valores de cada una de las posibles liquidaciones de todas las tareas
            NuevaLiquidacion_2.Expediente = oFE;
            cLiquidacion.AgregarLiquidacion(NuevaLiquidacion_2);
            oFE.Liquidaciones.Add(NuevaLiquidacion_2);

            // Liquidación con respecto al trabajo en si
            Modelo_Entidades.Liquidacion NuevaLiquidacion_3 = new Modelo_Entidades.Liquidacion();
            NuevaLiquidacion_3.tarea = "Liquidación básica";
            NuevaLiquidacion_3.cantidad = 1; // Es siempre 1, ya que existe solo 1 liqudiacion
            NuevaLiquidacion_3.importe = (oFE.hps * coeficiente_k * 1290) + (oFE.bocas * 290); // Estan hardcodeados, pero hay que ponerlo para que lo puedan editar en un cuadro grande con los valores de cada una de las posibles liquidaciones de todas las tareas
            NuevaLiquidacion_3.Expediente = oFE;
            cLiquidacion.AgregarLiquidacion(NuevaLiquidacion_3);
            oFE.Liquidaciones.Add(NuevaLiquidacion_3);

            // Calculo la estrategia, y la derivo a la liquidación
            dgv_liquidaciones_FE.DataSource = cExpediente.LiquidarExpediente(oFE);

            // Limpio la grilla
            dgv_liquidaciones_FE.DataSource = null;
            // LLeno el binding con los datos que traigo de las entidades
            BsLiquidaciones_FE.DataSource = oFE.Liquidaciones;
            // Asigno el binding a la grilla
            dgv_liquidaciones_FE.DataSource = BsLiquidaciones_FE;
            dgv_liquidaciones_FE.Columns[0].Visible = false;
            dgv_liquidaciones_FE.Columns[1].HeaderText = "Tarea";
            dgv_liquidaciones_FE.Columns[2].HeaderText = "Cantidad";
            dgv_liquidaciones_FE.Columns[3].HeaderText = "Importe";
            dgv_liquidaciones_FE.Columns[4].Visible = false;
            #endregion

            int i = 0;
            double suma = 0;
            while (i < dgv_liquidaciones_FE.Rows.Count)
            {
                if (dgv_liquidaciones_FE.Rows[i] != null)
                {
                    suma = Convert.ToDouble(dgv_liquidaciones_FE.Rows[i].Cells[3].Value) + suma;
                }

                i++;
            }

            txt_total_a_liquidar.Text = suma.ToString();
            txt_aportes_al_cie.Text = ((suma) * 0.05).ToString();
            txt_aportes_a_caja.Text = ((suma) * 0.23).ToString();
            txt_total_aportes.Text = (((suma) * 0.05) + ((suma) * 0.23)).ToString();
            InhabilitarTxts();

            #region Agregado del saldo a la cta cte del profesional
            oProfesional = (Modelo_Entidades.Profesional)dgv_profesionales.CurrentRow.DataBoundItem;
            if (cMovimiento.BuscarMovimientoPorDescExpte(oFE.numero) != null) // quiere decir que está, por lo que se tiene que modificar
            {
                oMovimiento = cMovimiento.BuscarMovimientoPorDescExpte(oFE.numero);

                // Lo 1º es sumar el saldo anterior, para que no se siga restando         
                oCtaCte = oProfesional.CtaCte;
                oCtaCte.saldo = oCtaCte.saldo + Convert.ToDecimal(oMovimiento.importe);

                // Luego, hago los 2 cambios que afectan al movimiento
                oMovimiento.fecha = DateTime.Now;
                oMovimiento.importe = ((suma) * 0.05);
                //oMovimiento.descripcion = "Débito del expediente número " + oFE.numero.ToString();
                //oMovimiento.CtaCte = oProfesional.CtaCte;
                //oMovimiento.Tipo_Movimiento = cTipo_Movimiento.ObtenerMov_Deudor();
                //oMovimiento.Comprobante = oBoleta;

                cMovimiento.ModificarMovimiento(oMovimiento);
                //oProfesional.CtaCte.Movimientos.Add(oMovimiento);

                oCtaCte.saldo = oCtaCte.saldo - Convert.ToDecimal(((suma) * 0.05));
                cCtaCte.Modificacion(oCtaCte);
            }

            else
            {
                oMovimiento = new Modelo_Entidades.Movimiento();
                oBoleta = new Modelo_Entidades.Boleta();

                oMovimiento.fecha = DateTime.Now;
                oMovimiento.importe = ((suma) * 0.05);
                oMovimiento.descripcion = "Débito del expediente número " + oFE.numero.ToString();
                oMovimiento.CtaCte = oProfesional.CtaCte;
                oMovimiento.Tipo_Movimiento = cTipo_Movimiento.ObtenerMov_Deudor();
                oMovimiento.Comprobante = oBoleta;

                cMovimiento.Alta(oMovimiento);
                oProfesional.CtaCte.Movimientos.Add(oMovimiento);

                oCtaCte = oProfesional.CtaCte;
                oCtaCte.saldo = oCtaCte.saldo - Convert.ToDecimal(((suma) * 0.05));
                cCtaCte.Modificacion(oCtaCte);
            }
            #endregion
        }

        // Liquido los HM
        private void Liquidar_HM()
        {
            // Defino las variables propias del HM
            oHM.dias_de_campo = nud_dias_campo_HM.Value;
            oHM.dias_de_gabinete = nud_dias_gabinete_HM.Value;

            // Lo 1º que hago es eliminar la liquidación anterior
            foreach (Modelo_Entidades.Liquidacion oLiq in cLiquidacion.ObtenerLiquidaciones())
            {
                if (oHM.numero == oLiq.Expediente.numero)
                {
                    cLiquidacion.EliminarLiquidacion(oLiq);
                }
            }

            #region Liquidación del HM
            // Agrego las liquidaciones para que luego pueda modificar sus valores y luegos ponerlas en el datagridview según sea la solapa

            Modelo_Entidades.Liquidacion NuevaLiquidacion_4 = new Modelo_Entidades.Liquidacion();
            NuevaLiquidacion_4.tarea = "Dias de campo liquidados";
            NuevaLiquidacion_4.cantidad = nud_dias_campo_HM.Value;
            NuevaLiquidacion_4.importe = 0.7m; // Esta hardcodeado, pero hay que ponerlo para que lo puedan editar en un cuadro grande con los valores de cada una de las posibles liquidaciones de todas las tareas
            NuevaLiquidacion_4.Expediente = oHM;
            cLiquidacion.AgregarLiquidacion(NuevaLiquidacion_4);
            oHM.Liquidaciones.Add(NuevaLiquidacion_4);

            Modelo_Entidades.Liquidacion NuevaLiquidacion_5 = new Modelo_Entidades.Liquidacion();
            NuevaLiquidacion_5.tarea = "Dias de campo liquidados";
            NuevaLiquidacion_5.cantidad = nud_dias_gabinete_HM.Value;
            NuevaLiquidacion_5.importe = 0.3m; // Esta hardcodeado, pero hay que ponerlo para que lo puedan editar en un cuadro grande con los valores de cada una de las posibles liquidaciones de todas las tareas
            NuevaLiquidacion_5.Expediente = oHM;
            cLiquidacion.AgregarLiquidacion(NuevaLiquidacion_5);
            oHM.Liquidaciones.Add(NuevaLiquidacion_5);

            // Calculo la estrategia
            dgv_liquidaciones_HM.DataSource = cExpediente.LiquidarExpediente(oHM);

            // Finalmente muestro la grilla con los datos

            // Limpio la grilla
            dgv_liquidaciones_HM.DataSource = null;
            // LLeno el binding con los datos que traigo de las entidades
            BsLiquidaciones_HM.DataSource = oHM.Liquidaciones;
            // Asigno el binding a la grilla
            dgv_liquidaciones_HM.DataSource = BsLiquidaciones_HM;
            dgv_liquidaciones_HM.Columns[0].Visible = false;
            dgv_liquidaciones_HM.Columns[1].HeaderText = "Tarea";
            dgv_liquidaciones_HM.Columns[2].HeaderText = "Cantidad";
            dgv_liquidaciones_HM.Columns[3].HeaderText = "Importe";
            dgv_liquidaciones_HM.Columns[4].Visible = false;
            #endregion

            int i_1 = 0;
            double suma_1 = 0;
            while (i_1 < dgv_liquidaciones_HM.Rows.Count)
            {
                if (dgv_liquidaciones_HM.Rows[i_1] != null)
                {
                    suma_1 = Convert.ToDouble(dgv_liquidaciones_HM.Rows[i_1].Cells[3].Value) + suma_1;
                }

                i_1++;
            }

            txt_total_a_liquidar.Text = suma_1.ToString();
            txt_aportes_al_cie.Text = ((suma_1) * 0.05).ToString();
            txt_aportes_a_caja.Text = ((suma_1) * 0.23).ToString();
            txt_total_aportes.Text = (((suma_1) * 0.05) + ((suma_1) * 0.23)).ToString();
            InhabilitarTxts();

            #region Agregado del saldo a la cta cte del profesional
            oProfesional = (Modelo_Entidades.Profesional)dgv_profesionales.CurrentRow.DataBoundItem;
            if (cMovimiento.BuscarMovimientoPorDescExpte(oHM.numero) != null) // quiere decir que está, por lo que se tiene que modificar
            {
                oMovimiento = cMovimiento.BuscarMovimientoPorDescExpte(oHM.numero);

                // Lo 1º es sumar el saldo anterior, para que no se siga restando   
                oCtaCte = oProfesional.CtaCte;
                oCtaCte.saldo = oCtaCte.saldo + Convert.ToDecimal(oMovimiento.importe);

                // Luego, hago los 2 cambios que afectan al movimiento
                oMovimiento.fecha = DateTime.Now;
                oMovimiento.importe = ((suma_1) * 0.05);
                //oMovimiento.descripcion = "Débito del expediente número " + oHM.numero.ToString();
                //oMovimiento.CtaCte = oProfesional.CtaCte;
                //oMovimiento.Tipo_Movimiento = cTipo_Movimiento.ObtenerMov_Deudor();
                //oMovimiento.Comprobante = oBoleta;

                cMovimiento.ModificarMovimiento(oMovimiento);
                //oProfesional.CtaCte.Movimientos.Add(oMovimiento);

                oCtaCte.saldo = oCtaCte.saldo - Convert.ToDecimal(((suma_1) * 0.05));
                cCtaCte.Modificacion(oCtaCte);
            }

            else
            {
                oMovimiento = new Modelo_Entidades.Movimiento();
                oBoleta = new Modelo_Entidades.Boleta();

                oMovimiento.fecha = DateTime.Now;
                oMovimiento.importe = ((suma_1) * 0.05);
                oMovimiento.descripcion = "Débito del expediente número " + oHM.numero.ToString();
                oMovimiento.CtaCte = oProfesional.CtaCte;
                oMovimiento.Tipo_Movimiento = cTipo_Movimiento.ObtenerMov_Deudor();
                oMovimiento.Comprobante = oBoleta;

                cMovimiento.Alta(oMovimiento);
                oProfesional.CtaCte.Movimientos.Add(oMovimiento);

                oCtaCte = oProfesional.CtaCte;
                oCtaCte.saldo = oCtaCte.saldo - Convert.ToDecimal(((suma_1) * 0.05));
                cCtaCte.Modificacion(oCtaCte);
            }
            #endregion
        }

        // Cuando cambia el check de aprobado
        private void dtp_fecha_aprobacion_ValueChanged(object sender, EventArgs e)
        {
            string eleccion = lb_tipo_expediente.Text;

            if (dtp_fecha_aprobacion.Checked == true)
            {
                switch (eleccion)
                {
                    case ("Obras de Ingenieria"):
                        oOI.estado = "Aprobado";
                        break;

                    case ("Fuerza Electromotriz"):
                        oFE.estado = "Aprobado";
                        break;

                    case ("Honorario Mínimo"):
                        oHM.estado = "Aprobado";
                        break;
                }
            }

            else
            {
                switch (eleccion)
                {
                    case ("Obras de Ingenieria"):
                        oOI.estado = "Recibido";
                        break;

                    case ("Fuerza Electromotriz"):
                        oFE.estado = "Recibido";
                        break;

                    case ("Honorario Mínimo"):
                        oHM.estado = "Recibido";
                        break;
                }
            }
        }

        // Cuando cambia el check de devuelto
        private void dtp_fecha_devolución_ValueChanged(object sender, EventArgs e)
        {
            string eleccion = lb_tipo_expediente.Text;

            if (dtp_fecha_aprobacion.Checked == true)
            {
                if (dtp_fecha_devolución.Checked == true)
                {
                    switch (eleccion)
                    {
                        case ("Obras de Ingenieria"):
                            oOI.estado = "Devuelto";
                            break;

                        case ("Fuerza Electromotriz"):
                            oFE.estado = "Devuelto";
                            break;

                        case ("Honorario Mínimo"):
                            oHM.estado = "Devuelto";
                            break;
                    }
                }

                else
                {
                    switch (eleccion)
                    {
                        case ("Obras de Ingenieria"):
                            oOI.estado = "Aprobado";
                            break;

                        case ("Fuerza Electromotriz"):
                            oFE.estado = "Aprobado";
                            break;

                        case ("Honorario Mínimo"):
                            oHM.estado = "Aprobado";
                            break;
                    }
                }
            }

            else
            {
                MessageBox.Show("Antes de ingresar la devolución, debe ingresar la fecha de recepción");
            }
        }

        // Inhabilito los txt de las liquidaciones para que no se puedan modificar
        private void InhabilitarTxts()
        {
            txt_total_a_liquidar.Enabled = false;
            txt_aportes_al_cie.Enabled = false;
            txt_aportes_a_caja.Enabled = false;
            txt_total_aportes.Enabled = false;
        }

        // Cuando cambia el combo de tareas (solo de las obras de ingenieria)
        private void cmb_tareas_OI_SelectedIndexChanged(object sender, EventArgs e)
        {
            oOI.Tarea = (Modelo_Entidades.Tarea)cmb_tareas_OI.SelectedItem;
        }

        // Cuando cambia el combo de tareas (solo para el hm)
        private void cmb_tareas_hm_SelectedIndexChanged(object sender, EventArgs e)
        {
            oHM.Tarea = (Modelo_Entidades.Tarea)cmb_tareas_hm.SelectedItem;
        }

        // Cuando cambia el combo de tareas (solo para el fe)
        private void cmb_tareas_fe_SelectedIndexChanged(object sender, EventArgs e)
        {
            oFE.Tarea = (Modelo_Entidades.Tarea)cmb_tareas_fe.SelectedItem;
        }

    }
}
