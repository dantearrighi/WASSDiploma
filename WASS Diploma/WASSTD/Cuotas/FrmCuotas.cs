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
    public partial class FrmCuotas : Form
    {
        // Declaro las variables que voy a utilizar en el formulario
        private static FrmCuotas instancia;
        Modelo_Entidades.Alterador oAlterador;        
        string desc;
        Modelo_Entidades.Usuario miUsuario;

        // Declaro las controladoras a usar
        Controladora.cProfesional cProfesional;
        Controladora.cAlterador cAlterador;
        Controladora.cCuota cCuota;
        Controladora.cTipo_Movimiento cTipo_Movimiento;
        Controladora.cMovimiento cMovimiento;
        Controladora.cEstado cEstado;
        Controladora.cCtaCte cCtaCte;
        Controladora.cTipo_Matricula cTipo_Matricula;
        Controladora.cAuditoria cAuditoria;

        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmCuotas ObtenerInstancia(Modelo_Entidades.Usuario oUsuario)
        {
            if (instancia == null)
            {
                instancia = new FrmCuotas(oUsuario);
            }

            if (instancia.IsDisposed)
            {
                instancia = new FrmCuotas(oUsuario);
            }

            return instancia;
        }

        // Cuando se inicializa el formualrio
        public FrmCuotas(Modelo_Entidades.Usuario oUsuario)
        {
            InitializeComponent();

            miUsuario = oUsuario;

            cProfesional = Controladora.cProfesional.ObtenerInstancia();
            cAlterador = Controladora.cAlterador.ObtenerInstancia();
            cCuota = Controladora.cCuota.ObtenerInstancia();
            cTipo_Movimiento = Controladora.cTipo_Movimiento.ObtenerInstancia();
            cMovimiento = Controladora.cMovimiento.ObtenerInstancia();
            cEstado = Controladora.cEstado.ObtenerInstancia();
            cCtaCte = Controladora.cCtaCte.ObtenerInstancia();
            cTipo_Matricula = Controladora.cTipo_Matricula.ObtenerInstancia();
            cAuditoria = Controladora.cAuditoria.ObtenerInstancia();
        }

        // Cuando carga el formulario
        private void FrmCuotas_Load(object sender, EventArgs e)
        {
            oAlterador = cAlterador.ObtenerAlterador();
            nud_año.Minimum = 2013;
            nud_año.Maximum = 2020;
            nud_año_corrimiento.Minimum = 2013;
            nud_año_corrimiento.Maximum = 2020;
            nud_cuontas_numeros.Minimum = 1;
            nud_cuontas_numeros.Maximum = 6;
            txt_porcentaje.Text = oAlterador.porcentaje_recargo.ToString();
            txt_dias_gracias.Text = oAlterador.dias_gracias.ToString();
            txt_valor_bimensual.Text = oAlterador.valor_cuota.ToString();
            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;
            Arma_Lista();
        }

        // Armo los listados necesarios
        private void Arma_Lista()
        {           
            txt_porcentaje.Enabled = false;
            txt_dias_gracias.Enabled = false;
            txt_valor_bimensual.Enabled = false;
            nud_cuontas_numeros.Enabled = false;

            cmb_tipo_matricula.DataSource = cTipo_Matricula.ObtenerTiposMatriculas();
            cmb_tipo_matricula.DisplayMember = "descripcion";

        }

        // Cuando le doy click a "Editar"
        private void btn_editar_Click(object sender, EventArgs e)
        {
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
            txt_porcentaje.Enabled = true;
            txt_dias_gracias.Enabled = true;
            txt_valor_bimensual.Enabled = true;
        }

        // Cuando le doy click a "Cancelar"
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cuando le doy click a "Guardar"
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (ValidarObligatorios())
            {
                oAlterador.porcentaje_recargo = Convert.ToDouble(txt_porcentaje.Text);
                oAlterador.dias_gracias = Convert.ToInt32(txt_dias_gracias.Text);
                oAlterador.valor_cuota = Convert.ToDouble(txt_valor_bimensual.Text);
                cAlterador.Modificacion(oAlterador);
                MessageBox.Show("El valor se ha actualizado correctamente");
                this.Close();
            }
        }

        // Cuando cambia el radio button bimensual
        private void rbtn_bimensual_CheckedChanged(object sender, EventArgs e)
        {
            nud_cuontas_numeros.Enabled = true;
        }

        // Cuando cambia el radio button anual
        private void rbtn_anual_CheckedChanged(object sender, EventArgs e)
        {
            nud_cuontas_numeros.Enabled = false;
        }

        // Cuando le doy click a generar la cuota
        private void btn_generar_Click(object sender, EventArgs e)
        {
            FrmImprimirBoleta FormularioImpresionBoleta;
            Modelo_Entidades.CtaCte oCtaCte;
            Modelo_Entidades.Boleta oBoleta;
            Modelo_Entidades.Movimiento oMovimiento;
            Modelo_Entidades.Anual oAnual;
            Modelo_Entidades.Bimensual oBimensual;

            Modelo_Entidades.Auditoria_Cuota oLog_Cuota;

            if (ValidarDatos())
            {
                string tipo_de_cuota = cmb_tipo_matricula.SelectedItem.ToString();

                #region Generación de cuota anual
                if (rbtn_anual.Checked == true) // genero la anual y la 1º
                {
                    switch (tipo_de_cuota)
                    {
                        case ("Normal"):

                            foreach (Modelo_Entidades.Profesional oProfesional in cProfesional.ObtenerProfesionalesNormales())
                            {
                                oCtaCte = oProfesional.CtaCte;
                                oBoleta = new Modelo_Entidades.Boleta();
                                oMovimiento = new Modelo_Entidades.Movimiento();
                                oAnual = new Modelo_Entidades.Anual();
                                oLog_Cuota = new Modelo_Entidades.Auditoria_Cuota();

                                oMovimiento.fecha = DateTime.Now;
                                oMovimiento.importe = Math.Round(cCuota.ObtenerValor_Tipo_Couta(oAnual).Valor(), 2);
                                oMovimiento.descripcion = "Cuota anual año " + nud_año.Value.ToString();
                                oAnual.descripcion = "Cuota anual año " + nud_año.Value.ToString();
                                oAnual.estado = false;
                                oAnual.Profesional = oProfesional;
                                cCuota.AgregarCuota(oAnual);

                                #region Audito la cuota                                
                                oLog_Cuota.estado = false;
                                oLog_Cuota.descripcion = "Cuota anual año " + nud_año.Value.ToString();
                                oLog_Cuota.Profesional_dni = oProfesional.dni;
                                oLog_Cuota.usuario = miUsuario.nombre_apellido;
                                oLog_Cuota.fecha = DateTime.Now;
                                oLog_Cuota.accion = "Agregado de cuota anual al profesional " + oProfesional.nombre_apellido;
                                cAuditoria.AuditarCuota(oLog_Cuota);
                                #endregion

                                oMovimiento.CtaCte = oProfesional.CtaCte;
                                oMovimiento.Tipo_Movimiento = cTipo_Movimiento.ObtenerMov_Deudor();
                                oMovimiento.Comprobante = oBoleta;

                                cMovimiento.Alta(oMovimiento);

                                oProfesional.CtaCte.Movimientos.Add(oMovimiento);

                                oCtaCte.saldo = oCtaCte.saldo - Convert.ToDecimal(oMovimiento.importe);
                                cCtaCte.Modificacion(oCtaCte);
                            }
                            
                            FormularioImpresionBoleta = new FrmImprimirBoleta(cCuota.ObtenerCuotas().First().id, cCuota.ObtenerCuotas().Last().id, "Cuota anual año " + nud_año.Value.ToString(), 1);
                            DialogResult DrLogin = FormularioImpresionBoleta.ShowDialog();  

                            break;

                        case ("Relación de Dependencia"):

                            foreach (Modelo_Entidades.Profesional oProfesional in cProfesional.ObtenerProfesionalesEnRelacionDeDependencia())
                            {
                                oCtaCte = oProfesional.CtaCte;
                                oBoleta = new Modelo_Entidades.Boleta();
                                oMovimiento = new Modelo_Entidades.Movimiento();
                                oAnual = new Modelo_Entidades.Anual();
                                oLog_Cuota = new Modelo_Entidades.Auditoria_Cuota();

                                oMovimiento.fecha = DateTime.Now;
                                oMovimiento.importe = Math.Round(cCuota.ObtenerValor_Tipo_Couta(oAnual).Valor() * 0.7, 2); // EL PORCENTAJE ESTÁ HARKODEADO, DE TODAS FORMAS ESE ES EL VALOR QUE ANUALMENTE EL COLEGIO DISPONE
                                oMovimiento.descripcion = "Cuota anual año " + nud_año.Value.ToString();
                                oAnual.descripcion = "Cuota anual año " + nud_año.Value.ToString();
                                oAnual.estado = false;
                                oAnual.Profesional = oProfesional;
                                cCuota.AgregarCuota(oAnual);

                                #region Audito la cuota
                                oLog_Cuota.estado = false;
                                oLog_Cuota.descripcion = "Cuota anual año " + nud_año.Value.ToString();
                                oLog_Cuota.Profesional_dni = oProfesional.dni;
                                oLog_Cuota.usuario = miUsuario.nombre_apellido;
                                oLog_Cuota.fecha = DateTime.Now;
                                oLog_Cuota.accion = "Agregado de cuota anual al profesional " + oProfesional.nombre_apellido;
                                cAuditoria.AuditarCuota(oLog_Cuota);
                                #endregion

                                oMovimiento.CtaCte = oProfesional.CtaCte;
                                oMovimiento.Tipo_Movimiento = cTipo_Movimiento.ObtenerMov_Deudor();
                                oMovimiento.Comprobante = oBoleta;

                                cMovimiento.Alta(oMovimiento);

                                oProfesional.CtaCte.Movimientos.Add(oMovimiento);

                                oCtaCte.saldo = oCtaCte.saldo - Convert.ToDecimal(oMovimiento.importe);
                                cCtaCte.Modificacion(oCtaCte);
                            }

                            FormularioImpresionBoleta = new FrmImprimirBoleta(cCuota.ObtenerCuotas().First().id, cCuota.ObtenerCuotas().Last().id, "anual", 2);
                            DialogResult DrLogin1 = FormularioImpresionBoleta.ShowDialog();

                            break;

                        case ("Reciprocidad de Matrícula"):

                            foreach (Modelo_Entidades.Profesional oProfesional in cProfesional.ObtenerProfesionalesEnReciprocidadDeMatricula())
                            {
                                oCtaCte = oProfesional.CtaCte;
                                oBoleta = new Modelo_Entidades.Boleta();
                                oMovimiento = new Modelo_Entidades.Movimiento();
                                oAnual = new Modelo_Entidades.Anual();
                                oLog_Cuota = new Modelo_Entidades.Auditoria_Cuota();

                                oMovimiento.fecha = DateTime.Now;
                                oMovimiento.importe = Math.Round(cCuota.ObtenerValor_Tipo_Couta(oAnual).Valor(), 2);
                                oMovimiento.descripcion = "Cuota anual año " + nud_año.Value.ToString();
                                oAnual.descripcion = "Cuota anual año " + nud_año.Value.ToString();
                                oAnual.estado = false;
                                oAnual.Profesional = oProfesional;
                                cCuota.AgregarCuota(oAnual);

                                #region Audito la cuota
                                oLog_Cuota.estado = false;
                                oLog_Cuota.descripcion = "Cuota anual año " + nud_año.Value.ToString();
                                oLog_Cuota.Profesional_dni = oProfesional.dni;
                                oLog_Cuota.usuario = miUsuario.nombre_apellido;
                                oLog_Cuota.fecha = DateTime.Now;
                                oLog_Cuota.accion = "Agregado de cuota anual al profesional " + oProfesional.nombre_apellido;
                                cAuditoria.AuditarCuota(oLog_Cuota);
                                #endregion

                                oMovimiento.CtaCte = oProfesional.CtaCte;
                                oMovimiento.Tipo_Movimiento = cTipo_Movimiento.ObtenerMov_Deudor();
                                oMovimiento.Comprobante = oBoleta;

                                cMovimiento.Alta(oMovimiento);

                                oProfesional.CtaCte.Movimientos.Add(oMovimiento);

                                oCtaCte.saldo = oCtaCte.saldo - Convert.ToDecimal(oMovimiento.importe);
                                cCtaCte.Modificacion(oCtaCte);
                            }

                            FormularioImpresionBoleta = new FrmImprimirBoleta(cCuota.ObtenerCuotas().First().id, cCuota.ObtenerCuotas().Last().id, "anual", 3);
                            DialogResult DrLogin2 = FormularioImpresionBoleta.ShowDialog();

                            break;
                    }
                }
                #endregion            

                #region Generación de cuota bimensual
                if (rbtn_bimensual.Checked == true)
                {
                    switch (tipo_de_cuota)
                    {
                        case ("Normal"):

                            foreach (Modelo_Entidades.Profesional oProfesional in cProfesional.ObtenerProfesionalesNormales())
                            {
                                oCtaCte = oProfesional.CtaCte;
                                oBoleta = new Modelo_Entidades.Boleta();
                                oMovimiento = new Modelo_Entidades.Movimiento();
                                oBimensual = new Modelo_Entidades.Bimensual();
                                oLog_Cuota = new Modelo_Entidades.Auditoria_Cuota();
                            
                                if (cCuota.ObtenerSiElProfPago(oProfesional, "Cuota " + nud_cuontas_numeros.Value.ToString() + "/" + nud_año.Value.ToString(), nud_año.Value.ToString()) == false)
                                {
                                    oMovimiento.importe = Math.Round(cCuota.ObtenerValor_Tipo_Couta(oBimensual).Valor(), 2);
                                    oMovimiento.descripcion = "Cuota " + nud_cuontas_numeros.Value.ToString() + "/" + nud_año.Value.ToString();
                                    oBimensual.descripcion = "Cuota " + nud_cuontas_numeros.Value.ToString() + "/" + nud_año.Value.ToString();
                                    oBimensual.estado = false;
                                    oBimensual.Profesional = oProfesional;
                                    cCuota.AgregarCuota(oBimensual);

                                    #region Audito la cuota
                                    oLog_Cuota.estado = false;
                                    oLog_Cuota.descripcion = "Cuota " + nud_cuontas_numeros.Value.ToString() + "/" + nud_año.Value.ToString();
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
                                    cCtaCte.Modificacion(oCtaCte);
                                } 
                            }

                            FormularioImpresionBoleta = new FrmImprimirBoleta(cCuota.ObtenerCuotas().First().id, cCuota.ObtenerCuotas().Last().id, "/", 1);
                            DialogResult DrLogin = FormularioImpresionBoleta.ShowDialog();
                            
                            break;                     

                        case ("Relación de Dependencia"):

                            foreach (Modelo_Entidades.Profesional oProfesional in cProfesional.ObtenerProfesionalesEnRelacionDeDependencia())
                            {
                                // Esto verifica si el profesional pagó la anual, no la genere las cuotas bimensuales y el que esté en relación de dependencia, la 5° y 6° cuota no las pague
                                if (cCuota.ObtenerSiElProfPago(oProfesional, "Cuota " + nud_cuontas_numeros.Value.ToString() + "/" + nud_año.Value.ToString(), nud_año.Value.ToString()) == false)
                                {
                                    oCtaCte = oProfesional.CtaCte;
                                    oBoleta = new Modelo_Entidades.Boleta();
                                    oMovimiento = new Modelo_Entidades.Movimiento();
                                    oBimensual = new Modelo_Entidades.Bimensual();
                                    oLog_Cuota = new Modelo_Entidades.Auditoria_Cuota();

                                    if (nud_cuontas_numeros.Value.ToString() != "5" || nud_cuontas_numeros.Value.ToString() != "6") 
                                    {
                                        oMovimiento.importe = Math.Round(cCuota.ObtenerValor_Tipo_Couta(oBimensual).Valor(), 2);
                                        oMovimiento.descripcion = "Cuota " + nud_cuontas_numeros.Value.ToString() + "/" + nud_año.Value.ToString();
                                        oBimensual.descripcion = "Cuota " + nud_cuontas_numeros.Value.ToString() + "/" + nud_año.Value.ToString();
                                        oBimensual.estado = false;
                                        oBimensual.Profesional = oProfesional;
                                        cCuota.AgregarCuota(oBimensual);

                                        #region Audito la cuota
                                        oLog_Cuota.estado = false;
                                        oLog_Cuota.descripcion = "Cuota " + nud_cuontas_numeros.Value.ToString() + "/" + nud_año.Value.ToString();
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
                                        cCtaCte.Modificacion(oCtaCte);
                                    }
                                } 
                            }

                            FormularioImpresionBoleta = new FrmImprimirBoleta(cCuota.ObtenerCuotas().First().id, cCuota.ObtenerCuotas().Last().id, "/", 2);
                            DialogResult DrLogin1 = FormularioImpresionBoleta.ShowDialog();
                            break;

                        case ("Reciprocidad de Matrícula"):

                            foreach (Modelo_Entidades.Profesional oProfesional in cProfesional.ObtenerProfesionalesEnReciprocidadDeMatricula())
                            {
                                // Esto verifica si el profesional pagó la anual, no la genere las cuotas bimensuales y el que esté en relación de dependencia, la 5° y 6° cuota no las pague
                                if (cCuota.ObtenerSiElProfPago(oProfesional, "Cuota " + nud_cuontas_numeros.Value.ToString() + "/" + nud_año.Value.ToString(), nud_año.Value.ToString()) == false)
                                {
                                    oCtaCte = oProfesional.CtaCte;
                                    oBoleta = new Modelo_Entidades.Boleta();
                                    oMovimiento = new Modelo_Entidades.Movimiento();
                                    oBimensual = new Modelo_Entidades.Bimensual();
                                    oLog_Cuota = new Modelo_Entidades.Auditoria_Cuota();

                                    if (nud_cuontas_numeros.Value.ToString() != "5" || nud_cuontas_numeros.Value.ToString() != "6")
                                    {
                                        oMovimiento.importe = Math.Round(cCuota.ObtenerValor_Tipo_Couta(oBimensual).Valor(), 2);
                                        oMovimiento.descripcion = "Cuota " + nud_cuontas_numeros.Value.ToString() + "/" + nud_año.Value.ToString();
                                        oBimensual.descripcion = "Cuota " + nud_cuontas_numeros.Value.ToString() + "/" + nud_año.Value.ToString();
                                        oBimensual.estado = false;
                                        oBimensual.Profesional = oProfesional;
                                        cCuota.AgregarCuota(oBimensual);

                                        #region Audito la cuota
                                        oLog_Cuota.estado = false;
                                        oLog_Cuota.descripcion = "Cuota " + nud_cuontas_numeros.Value.ToString() + "/" + nud_año.Value.ToString();
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
                                        cCtaCte.Modificacion(oCtaCte);
                                    }
                                }
                            }
                            
                            FormularioImpresionBoleta = new FrmImprimirBoleta(cCuota.ObtenerCuotas().First().id, cCuota.ObtenerCuotas().Last().id, "/", 3);
                            DialogResult DrLogin2 = FormularioImpresionBoleta.ShowDialog();
                            break;
                    }                             
                }
            # endregion

            }

            this.Close();
        }

        // Valido los datos
        private bool ValidarDatos()
        {          
            // Obtención del nombre de la cuota
            if (rbtn_anual.Checked == true)
            {
                desc = "Cuota anual año " + nud_año.Value.ToString();
            }

            if (rbtn_bimensual.Checked == true)
            {
                desc = "Cuota " + nud_cuontas_numeros.Value.ToString() + "/" + nud_año.Value.ToString();
            }

            // Validaciones
            if (nud_año.Value == 0)
            {
                MessageBox.Show("Debe ingresar el año para la cuota");
                return false;
            }

            if (rbtn_anual.Checked == false && rbtn_bimensual.Checked == false)
            {
                MessageBox.Show("Debe seleccionar al menos un tipo de cuota");
                return false;
            }

            if (rbtn_bimensual.Checked == true && nud_cuontas_numeros.Value == 0)
            {
                MessageBox.Show("Debe ingresar el número de la cuota");
                return false;
            }

            string tipo_de_cuota = cmb_tipo_matricula.SelectedItem.ToString();
            switch (tipo_de_cuota)
            {
                case ("Normal"):
                    if (cMovimiento.BuscarCuotaNormalGenerada(desc) == true)
                    {
                        MessageBox.Show("La cuota ya fue generada, por favor seleccione otra cuota");
                        return false;
                    }

                    break;

                case ("Relación de Dependencia"):
                    if (cMovimiento.BuscarCuotaEnRelGenerada(desc) == true)
                    {
                        MessageBox.Show("La cuota ya fue generada, por favor seleccione otra cuota");
                        return false;
                    }

                    break;

                case ("Reciprocidad de Matrícula"):
                    if (cMovimiento.BuscarCuotaEnReciprocidadGenerada(desc) == true)
                    {
                        MessageBox.Show("La cuota ya fue generada, por favor seleccione otra cuota");
                        return false;
                    }

                    break;
            }
            
            return true;
        }

        // valido datos
        private bool ValidarObligatorios()
        {
            if (string.IsNullOrEmpty(txt_porcentaje.Text))
            {
                MessageBox.Show("Debe ingresar el porcentaje");
                return false;
            }

            if (string.IsNullOrEmpty(txt_dias_gracias.Text))
            {
                MessageBox.Show("Debe ingresar los días de gracia");
                return false;
            }

            if (string.IsNullOrEmpty(txt_valor_bimensual.Text))
            {
                MessageBox.Show("Debe ingresar el valor de la cuota");
                return false;
            }
            return true;
        }

        // Cuando le doy click a "Corrimiento anual"
        private void btn_corrimiento_Click(object sender, EventArgs e)
        {
            foreach (Modelo_Entidades.Profesional oProfesional in cProfesional.ObtenerProfesionales())
            {
                // Si no pagó la 1º o la anual (= false), lo inhabilito 
                if (cCuota.ObtenerSiElProfPago(oProfesional,("Cuota " + "1" + "/" + nud_año_corrimiento.Value.ToString()), nud_año.Value.ToString()) == false)
                {
                    oProfesional.Estado = cEstado.ObtenerEstadoNoHabilitado();
                    cProfesional.Modificacion(oProfesional);
                }
            }

            MessageBox.Show("El corrimiento se ha efectuado correctamente");
        }
    }
}
