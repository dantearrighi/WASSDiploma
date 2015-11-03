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
    public partial class FrmRecibos : Form
    {
      /*
       * // Declaro las variables que voy a utilizar en el formulario
        private static FrmRecibos instancia;
        Modelo_Entidades.Usuario miUsuario;
        Modelo_Entidades.Persona miPersona;
        Modelo_Entidades.Movimiento oMovimiento;
        Modelo_Entidades.Factura oFactura;
     
        Modelo_Entidades.CtaCte oCtaCte;
       
        FrmImprimirRecibo FormularioImpresionRecibo;
        string concepto;

        List<Modelo_Entidades.Movimiento> ListaMovimientos = new List<Modelo_Entidades.Movimiento>();
        

        BindingSource BsFactura;           

        // Declaro las controladoras a usar
        Controladora.cTipo_Movimiento cTipo_Movimiento;
        Controladora.cMovimiento cMovimiento;
        Controladora.cPersona cPersona;
        Controladora.cEstado cEstado;
       
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
            cPersona = Controladora.cPersona.ObtenerInstancia();
            cEstado = Controladora.cEstado.ObtenerInstancia();
         
            cComprobante = Controladora.cComprobante.ObtenerInstancia();
            cCtaCte = Controladora.cCtaCte.ObtenerInstancia();
            cAuditoria = Controladora.cAuditoria.ObtenerInstancia();
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

        // Cuando le doy a imprimir No se realizó la impresión de la factura
        private void btn_imprimir_Click(object sender, EventArgs e)
        {/*
            switch (concepto)
            {
                case "Cuota": 
                    #region Cobro de cuota
                    oCtaCte = miPersona.CtaCte;
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
                    oLog_Cuota.Persona_dni = oCuo.Persona.dni;
                    oLog_Cuota.usuario = miUsuario.nombre_apellido;
                    oLog_Cuota.fecha = DateTime.Now;
                    oLog_Cuota.accion = "Modificación de cuota al Persona " + oCuo.Persona.nombre_apellido;
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
                            oMovimiento.CtaCte = miPersona.CtaCte;
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
                            miPersona.CtaCte.Movimientos.Add(oMovimiento);

                            oCtaCte.saldo = oCtaCte.saldo + Convert.ToDecimal(oMov.importe);
                            //miPersona.CtaCte.saldo = miPersona.CtaCte.saldo + Convert.ToDecimal(oMov.importe); // Sumo al saldo, cuando el Persona termina de pagar

                            // Elimino todos los movimientos bimensuales del año que le cobré
                            string año = oMov.descripcion.Substring(oMov.descripcion.Length - Math.Min(4, oMov.descripcion.Length));
                            if (oMov.descripcion.Contains("anual") == true) // Quiere decir que pagó la cuota anual
                            {
                                foreach (Modelo_Entidades.Movimiento oMovi in cMovimiento.ObtenerMovimientos())
                                {
                                    if (oMovi.descripcion.Contains("/") && oMovi.descripcion.Contains(año) && oMovi.CtaCte.id == miPersona.CtaCte.id) // Pregunto por las cuotas de ese año que pagó
                                    {
                                        //miPersona.CtaCte.saldo = miPersona.CtaCte.saldo + Convert.ToDecimal(oMovi.importe); 
                                        Modelo_Entidades.Cuota CuotaAEliminar = cCuota.ObtenerCuota(oMovi.descripcion, miPersona.dni);

                                        if (CuotaAEliminar != null) // Solo resto cuando elimino la cuota
                                        {
                                            #region Audito la cuota
                                            oLog_Cuota = new Modelo_Entidades.Auditoria_Cuota();
                                            oLog_Cuota.estado = false;
                                            oLog_Cuota.descripcion = CuotaAEliminar.descripcion;
                                            oLog_Cuota.Persona_dni = CuotaAEliminar.Persona.dni;
                                            oLog_Cuota.usuario = miUsuario.nombre_apellido;
                                            oLog_Cuota.fecha = DateTime.Now;
                                            oLog_Cuota.accion = "Eliminacíón de cuota bimensual al Persona " + CuotaAEliminar.Persona.nombre_apellido;
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
                                Modelo_Entidades.Cuota CuotaAEliminar = cCuota.ObtenerCuota(("Cuota anual año " + año), miPersona.dni);

                                if (CuotaAEliminar != null) // Solo resto cuando elimino la cuota
                                {
                                    double valor = (cMovimiento.BuscarMovimientoPorCuotaYProf("Cuota anual año " + año, miPersona.CtaCte.id).importe);

                                    #region Audito la cuota
                                    oLog_Cuota = new Modelo_Entidades.Auditoria_Cuota();
                                    oLog_Cuota.estado = false;
                                    oLog_Cuota.descripcion = CuotaAEliminar.descripcion;
                                    oLog_Cuota.Persona_dni = CuotaAEliminar.Persona.dni;
                                    oLog_Cuota.usuario = miUsuario.nombre_apellido;
                                    oLog_Cuota.fecha = DateTime.Now;
                                    oLog_Cuota.accion = "Eliminacíón de cuota anual al Persona " + CuotaAEliminar.Persona.nombre_apellido;
                                    cAuditoria.AuditarCuota(oLog_Cuota);
                                    #endregion

                                    oCtaCte.saldo = oCtaCte.saldo + Convert.ToDecimal(valor); // Sumo al saldo, ya que le estoy anulando la cuota
                                    cCuota.EliminarCuota(CuotaAEliminar); // Entonces debo eliminar las cuotas de ese año
                                }

                                cCtaCte.Modificacion(oCtaCte);
                            }
                        }

                        // Después de cobrarle hago la verificación de si 1º no tiene deudas de otros años y 2º si tiene paga la 1º o la cuota anual del año en curso

                        // El mayor es por los intereses. Además se podría colocar que  el saldo debe ser mayor o igual a 0, pero el colegio no lo toma como requisito (&& miPersona.CtaCte.saldo >= 0)
                        if (((cCuota.ObtenerSiElProfPago(miPersona, ("Cuota " + "1" + "/" + DateTime.Now.Year.ToString()), DateTime.Now.Year.ToString())) == true))
                        {
                            miPersona.Estado = cEstado.ObtenerEstadoHabilitado();
                            cPersona.Modificacion(miPersona);
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
                    oCtaCte = miPersona.CtaCte;

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
                    oMovi_expte.CtaCte = miPersona.CtaCte;
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
                    miPersona.CtaCte.Movimientos.Add(oMovi_expte);

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

     
    */
        
    }
}
