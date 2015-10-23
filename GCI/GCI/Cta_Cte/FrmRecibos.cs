using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GCI
{
    public partial class FrmRecibos : Form
    {
        // Declaro las variables que voy a utilizar en el formulario
        private static FrmRecibos instancia;
        Modelo_Entidades.Usuario miUsuario;
        Modelo_Entidades.Profesional miProfesional;
        Modelo_Entidades.Movimiento oMovimiento;
        Modelo_Entidades.Factura oFactura;
        Modelo_Entidades.Expediente oExpediente;
        Modelo_Entidades.CtaCte oCtaCte;
        FrmSeleccionExpedientes FormularioSeleccionExpediente;
        FrmImprimirRecibo FormularioImpresionRecibo;
        string concepto;

        List<Modelo_Entidades.Movimiento> ListaMovimientos = new List<Modelo_Entidades.Movimiento>();
        List<Modelo_Entidades.Cuota> ListaCuotas = new List<Modelo_Entidades.Cuota>();

        BindingSource BsFactura;           

        // Declaro las controladoras a usar
        Controladora.cTipo_Movimiento cTipo_Movimiento;
        Controladora.cMovimiento cMovimiento;
        Controladora.cProfesional cProfesional;
        Controladora.cEstado cEstado;
        Controladora.cCuota cCuota;
        Controladora.cComprobante cComprobante;
        Controladora.cCtaCte cCtaCte;
        Controladora.cAuditoria cAuditoria;
        
        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmRecibos ObtenerInstancia(Modelo_Entidades.Usuario oUsuario)
        {
            if (instancia == null)
            {
                instancia = new FrmRecibos(oUsuario);
            }

            if (instancia.IsDisposed)
            {
                instancia = new FrmRecibos(oUsuario);
            }

            return instancia;
        }

        // Cuando se inicializa el formualrio
        public FrmRecibos(Modelo_Entidades.Usuario oUsuario)
        {
            InitializeComponent();
            miUsuario = oUsuario;
        }

        // Cuando carga el formulario
        private void FrmRecibos_Load(object sender, EventArgs e)
        {
            BsFactura = new BindingSource();
            BsFactura.DataSource = dgv_factura;

            btn_cobrar_cuotas.Enabled = false;
            btn_cobrar_expediente.Enabled = false;
            btn_imprimir.Enabled = false;

            cTipo_Movimiento = Controladora.cTipo_Movimiento.ObtenerInstancia();
            cMovimiento = Controladora.cMovimiento.ObtenerInstancia();
            cProfesional = Controladora.cProfesional.ObtenerInstancia();
            cEstado = Controladora.cEstado.ObtenerInstancia();
            cCuota = Controladora.cCuota.ObtenerInstancia();
            cComprobante = Controladora.cComprobante.ObtenerInstancia();
            cCtaCte = Controladora.cCtaCte.ObtenerInstancia();
            cAuditoria = Controladora.cAuditoria.ObtenerInstancia();
        }

        // Cuando le doy un check a "Matriculado"
        private void chk_matriculado_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_matriculado.Checked == true)
            {
                // Lo primero que hago es crear un formulario de selccion de profesionales, así que instancio las variables
                FrmSeleccionProfesionales FormularioSeleccionProfesionales = new FrmSeleccionProfesionales(miUsuario);
                DialogResult DrLogin = FormularioSeleccionProfesionales.ShowDialog();

                // Despues pregunto si el formulario dio Ok. En caso de que no, vuelvo
                if (DrLogin != DialogResult.OK)
                {
                    return;
                }

                miProfesional = FormularioSeleccionProfesionales.ProfesionalElegido;
                txt_profesional.Text = miProfesional.nombre_apellido;
                btn_cobrar_cuotas.Enabled = true;
                btn_cobrar_expediente.Enabled = true;

            }

            else
            {
                return;
            }
        }
        
        // Cuando le doy a "Cobrar Cuota"
        private void btn_cobrar_cuotas_Click(object sender, EventArgs e)
        {
            // Lo primero que hago es crear un formulario de selccion de cuotas, así que instancio las variables
            if (dgv_factura.DataSource == null)
            {
                FrmSeleccionCuotas FormularioSeleccionCuotas = new FrmSeleccionCuotas(miProfesional);
                DialogResult DrLogin = FormularioSeleccionCuotas.ShowDialog();

                // Despues pregunto si el formulario dio Ok. En caso de que no, vuelvo
                if (DrLogin != DialogResult.OK)
                {
                    return;
                }

                ListaMovimientos = FormularioSeleccionCuotas.ListaMovimientos;
                ListaCuotas = FormularioSeleccionCuotas.ListaCuotas;

                if (ListaMovimientos == null)
                {
                    MessageBox.Show("Debe ingresar al menos una cuota para cobrar");
                }

                ArmaFactura();
                concepto = "Cuota";
                btn_imprimir.Enabled = true;
            }

            else
            {
                DialogResult result = MessageBox.Show("La factura ya contiene datos, si procede estos se perderan. ¿Desea proceder de todas formas?", "Factura", MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.Yes:
                        FrmSeleccionCuotas FormularioSeleccionCuotas = new FrmSeleccionCuotas(miProfesional);
                        DialogResult DrLogin = FormularioSeleccionCuotas.ShowDialog();

                        // Despues pregunto si el formulario dio Ok. En caso de que no, vuelvo
                        if (DrLogin != DialogResult.OK)
                        {
                            return;
                        }

                        ListaMovimientos = FormularioSeleccionCuotas.ListaMovimientos;
                        ListaCuotas = FormularioSeleccionCuotas.ListaCuotas;

                        if (ListaMovimientos == null)
                        {
                            MessageBox.Show("Debe ingresar al menos una cuota para cobrar");
                        }

                        ArmaFactura();
                        concepto = "Cuota";
                        btn_imprimir.Enabled = true;
                        break;

                    case DialogResult.No:
                        break;
                }
            }

        }

        // Armo la factura en un datagridview
        private void ArmaFactura()
        {
            // Limpio la grilla
            dgv_factura.DataSource = null;
            // LLeno el binding con los datos que traigo de las entidades
            BsFactura.DataSource = ListaMovimientos;
            // Asigno el binding a la grilla
            dgv_factura.DataSource = BsFactura;
            dgv_factura.Columns[0].Visible = false;
            dgv_factura.Columns[1].HeaderText = "Concepto";
            dgv_factura.Columns[2].HeaderText = "Importe";
            dgv_factura.Columns[3].HeaderText = "Fecha de emisión";
            dgv_factura.Columns[4].Visible = false;
            dgv_factura.Columns[5].Visible = false;
            dgv_factura.Columns[6].HeaderText = "Nº de boleta";

            int i = 0;
            double suma = 0;
            while (i < dgv_factura.Rows.Count)
            {
              if (dgv_factura.Rows[i] != null)
              {
                  suma = Convert.ToDouble(dgv_factura.Rows[i].Cells[2].Value) + suma;
              }

              i++;                              
            }

            txt_total.Text = suma.ToString();            
        }

        // Cuando le doy a imprimir, también cobro la matrícula. Por ahora solo la cobra. No se realizó la impresión de la factura
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            switch (concepto)
            {
                case "Cuota": 
                    #region Cobro de cuota
                    oCtaCte = miProfesional.CtaCte;
                    Modelo_Entidades.Auditoria_Cuota oLog_Cuota;

                    if (ListaCuotas.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar al menos 1 cuota para cobrar");
                    }

                    else
                    {
                        foreach (Modelo_Entidades.Cuota oCuo in ListaCuotas)
                        {
                            #region Audito la cuota
                    oLog_Cuota = new Modelo_Entidades.Auditoria_Cuota();
                    oLog_Cuota.estado = false;
                    oLog_Cuota.descripcion = oCuo.descripcion;
                    oLog_Cuota.Profesional_dni = oCuo.Profesional.dni;
                    oLog_Cuota.usuario = miUsuario.nombre_apellido;
                    oLog_Cuota.fecha = DateTime.Now;
                    oLog_Cuota.accion = "Modificación de cuota al profesional " + oCuo.Profesional.nombre_apellido;
                    cAuditoria.AuditarCuota(oLog_Cuota);
                    #endregion

                            oCuo.estado = true;
                        }

                        // 1º Creo un una nueva factura                
                        oFactura = new Modelo_Entidades.Factura();

                        int i = 0;
                        double suma = 0;

                        // 2º Cargo los datos de la factura
                        oFactura.cantidad = 1;
                        oFactura.descripcion = "Pago de cuotas";
                        oFactura.precio_unitario = 1;

                        foreach (Modelo_Entidades.Movimiento oMov in ListaMovimientos) // Acá saldo a cada movimiento que genero la cuota, con otro movimiento igual, pero con distinto tipo y le coloco la misma factura
                        {
                            oMovimiento = new Modelo_Entidades.Movimiento();
                            oMovimiento.fecha = DateTime.Now;
                            oMovimiento.importe = oMov.importe;
                            oMovimiento.descripcion = oMov.descripcion;
                            oMovimiento.CtaCte = miProfesional.CtaCte;
                            oMovimiento.Tipo_Movimiento = cTipo_Movimiento.ObtenerMov_Acreedor();

                            while (i < dgv_factura.Rows.Count)
                            {
                                if (dgv_factura.Rows[i] != null)
                                {
                                    suma = Convert.ToDouble(dgv_factura.Rows[i].Cells[2].Value) + suma;
                                }

                                i++;
                            }

                            oFactura.importe = Convert.ToDecimal(suma);
                            oFactura.total = Convert.ToDecimal(suma);

                            oMovimiento.Comprobante = oFactura;
                            cMovimiento.Alta(oMovimiento);

                            oFactura.Movimientos.Add(oMovimiento);
                            miProfesional.CtaCte.Movimientos.Add(oMovimiento);

                            oCtaCte.saldo = oCtaCte.saldo + Convert.ToDecimal(oMov.importe);
                            //miProfesional.CtaCte.saldo = miProfesional.CtaCte.saldo + Convert.ToDecimal(oMov.importe); // Sumo al saldo, cuando el profesional termina de pagar

                            // Elimino todos los movimientos bimensuales del año que le cobré
                            string año = oMov.descripcion.Substring(oMov.descripcion.Length - Math.Min(4, oMov.descripcion.Length));
                            if (oMov.descripcion.Contains("anual") == true) // Quiere decir que pagó la cuota anual
                            {
                                foreach (Modelo_Entidades.Movimiento oMovi in cMovimiento.ObtenerMovimientos())
                                {
                                    if (oMovi.descripcion.Contains("/") && oMovi.descripcion.Contains(año) && oMovi.CtaCte.id == miProfesional.CtaCte.id) // Pregunto por las cuotas de ese año que pagó
                                    {
                                        //miProfesional.CtaCte.saldo = miProfesional.CtaCte.saldo + Convert.ToDecimal(oMovi.importe); 
                                        Modelo_Entidades.Cuota CuotaAEliminar = cCuota.ObtenerCuota(oMovi.descripcion, miProfesional.dni);

                                        if (CuotaAEliminar != null) // Solo resto cuando elimino la cuota
                                        {
                                            #region Audito la cuota
                                            oLog_Cuota = new Modelo_Entidades.Auditoria_Cuota();
                                            oLog_Cuota.estado = false;
                                            oLog_Cuota.descripcion = CuotaAEliminar.descripcion;
                                            oLog_Cuota.Profesional_dni = CuotaAEliminar.Profesional.dni;
                                            oLog_Cuota.usuario = miUsuario.nombre_apellido;
                                            oLog_Cuota.fecha = DateTime.Now;
                                            oLog_Cuota.accion = "Eliminacíón de cuota bimensual al profesional " + CuotaAEliminar.Profesional.nombre_apellido;
                                            cAuditoria.AuditarCuota(oLog_Cuota);
                                            #endregion

                                            oCtaCte.saldo = oCtaCte.saldo + Convert.ToDecimal(oMovi.importe); // Sumo al saldo, ya que le estoy anulando la cuota
                                            cCuota.EliminarCuota(CuotaAEliminar); // Entonces debo eliminar las cuotas de ese año
                                        }

                                        cCtaCte.Modificacion(oCtaCte);
                                    }
                                }
                            }

                            else
                            {
                                Modelo_Entidades.Cuota CuotaAEliminar = cCuota.ObtenerCuota(("Cuota anual año " + año), miProfesional.dni);

                                if (CuotaAEliminar != null) // Solo resto cuando elimino la cuota
                                {
                                    double valor = (cMovimiento.BuscarMovimientoPorCuotaYProf("Cuota anual año " + año, miProfesional.CtaCte.id).importe);

                                    #region Audito la cuota
                                    oLog_Cuota = new Modelo_Entidades.Auditoria_Cuota();
                                    oLog_Cuota.estado = false;
                                    oLog_Cuota.descripcion = CuotaAEliminar.descripcion;
                                    oLog_Cuota.Profesional_dni = CuotaAEliminar.Profesional.dni;
                                    oLog_Cuota.usuario = miUsuario.nombre_apellido;
                                    oLog_Cuota.fecha = DateTime.Now;
                                    oLog_Cuota.accion = "Eliminacíón de cuota anual al profesional " + CuotaAEliminar.Profesional.nombre_apellido;
                                    cAuditoria.AuditarCuota(oLog_Cuota);
                                    #endregion

                                    oCtaCte.saldo = oCtaCte.saldo + Convert.ToDecimal(valor); // Sumo al saldo, ya que le estoy anulando la cuota
                                    cCuota.EliminarCuota(CuotaAEliminar); // Entonces debo eliminar las cuotas de ese año
                                }

                                cCtaCte.Modificacion(oCtaCte);
                            }
                        }

                        // Después de cobrarle hago la verificación de si 1º no tiene deudas de otros años y 2º si tiene paga la 1º o la cuota anual del año en curso

                        // El mayor es por los intereses. Además se podría colocar que  el saldo debe ser mayor o igual a 0, pero el colegio no lo toma como requisito (&& miProfesional.CtaCte.saldo >= 0)
                        if (((cCuota.ObtenerSiElProfPago(miProfesional, ("Cuota " + "1" + "/" + DateTime.Now.Year.ToString()), DateTime.Now.Year.ToString())) == true))
                        {
                            miProfesional.Estado = cEstado.ObtenerEstadoHabilitado();
                            cProfesional.Modificacion(miProfesional);
                        }

                        txt_total.Text = suma.ToString();

                        FormularioImpresionRecibo = new FrmImprimirRecibo(oFactura.id);
                        DialogResult DrLogin = FormularioImpresionRecibo.ShowDialog();

                        this.Close();
                    }
            #endregion
                    break;
                case "Expediente":
                    #region Cobro de expediente

                    // Cambio el estado del expediente a pagado
                    oExpediente.estado = "Pagado";
                    oExpediente.fecha_pago = DateTime.Now;
                    oCtaCte = miProfesional.CtaCte;

                    // 1º Creo un una nueva factura                
                    oFactura = new Modelo_Entidades.Factura();

                    int i_1 = 0;
                    double suma_1 = 0;

                    // 2º Cargo los datos de la factura
                    oFactura.cantidad = 1;
                    oFactura.descripcion = "Pago de expediente";
                    oFactura.precio_unitario = 1;

                    Modelo_Entidades.Movimiento oMovi_expte = new Modelo_Entidades.Movimiento();
                    oMovi_expte.fecha = DateTime.Now;
                    oMovi_expte.importe = oMovimiento.importe;
                    oMovi_expte.descripcion = "Pago expediente número " + oExpediente.numero;
                    oMovi_expte.CtaCte = miProfesional.CtaCte;
                    oMovi_expte.Tipo_Movimiento = cTipo_Movimiento.ObtenerMov_Acreedor();

                    while (i_1 < dgv_factura.Rows.Count)
                    {
                        if (dgv_factura.Rows[i_1] != null)
                        {
                            suma_1 = Convert.ToDouble(dgv_factura.Rows[i_1].Cells[2].Value) + suma_1;
                        }

                        i_1++;
                    }

                    oFactura.importe = Convert.ToDecimal(suma_1);
                    oFactura.total = Convert.ToDecimal(suma_1);

                    oMovi_expte.Comprobante = oFactura;
                    cMovimiento.Alta(oMovi_expte);

                    oFactura.Movimientos.Add(oMovi_expte);
                    miProfesional.CtaCte.Movimientos.Add(oMovi_expte);

                    oCtaCte.saldo = oCtaCte.saldo + Convert.ToDecimal(oMovi_expte.importe);

                    FormularioImpresionRecibo = new FrmImprimirRecibo(oFactura.id);
                    DialogResult DrLogin_1 = FormularioImpresionRecibo.ShowDialog();

                    this.Close();
                    #endregion
                    break;
            }
        }

        // Cuando cierro el formulario
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cuando le doy a "Cobrar Expediente"
        private void btn_cobrar_expediente_Click(object sender, EventArgs e)
        {
            // Lo primero que hago es crear un formulario de selccion de cuotas, así que instancio las variables
            if (dgv_factura.DataSource == null)
            {
                FormularioSeleccionExpediente = new FrmSeleccionExpedientes (miProfesional);
                DialogResult DrLogin = FormularioSeleccionExpediente.ShowDialog();

                // Despues pregunto si el formulario dio Ok. En caso de que no, vuelvo
                if (DrLogin != DialogResult.OK)
                {
                    return;
                }
            }

            oExpediente = FormularioSeleccionExpediente.ExpedienteElegido;
            // Luego armo la factura del expediente
            ArmaFacturaExpte();
            concepto = "Expediente";
            btn_imprimir.Enabled = true;
        }

        // Armo la factura en un datagridview del expediente
        private void ArmaFacturaExpte()
        {
            // Limpio la grilla
            dgv_factura.DataSource = null;
            // LLeno el binding con los datos que traigo del movimiento deudor que generó el expediente
            oMovimiento = cMovimiento.BuscarMovimientoPorDescExpte(oExpediente.numero);
            oMovimiento.descripcion = "Pago expediente número " + oExpediente.numero;
            BsFactura.DataSource = oMovimiento;
            // Asigno el binding a la grilla
            dgv_factura.DataSource = BsFactura;
            dgv_factura.Columns[0].Visible = false;
            dgv_factura.Columns[1].HeaderText = "Concepto";
            dgv_factura.Columns[2].HeaderText = "Importe";
            dgv_factura.Columns[3].HeaderText = "Fecha de emisión";
            dgv_factura.Columns[4].Visible = false;
            dgv_factura.Columns[5].Visible = false;
            dgv_factura.Columns[6].HeaderText = "Nº de boleta";

            int i = 0;
            double suma = 0;
            while (i < dgv_factura.Rows.Count)
            {
                if (dgv_factura.Rows[i] != null)
                {
                    suma = Convert.ToDouble(dgv_factura.Rows[i].Cells[2].Value) + suma;
                }

                i++;
            }

            txt_total.Text = suma.ToString();
        }
    }
}
