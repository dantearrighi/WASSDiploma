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
    public partial class FrmSeleccionCuotas : Form
    {
        // Declaro las variables que voy a utilizar en el formulario
        private static FrmSeleccionCuotas instancia;

        Modelo_Entidades.Profesional miProfesional;
        Modelo_Entidades.Movimiento oMovimiento;

        //bool checkearA;
        List<Modelo_Entidades.Cuota> ListadoCuotas = new List<Modelo_Entidades.Cuota>();
        List<Modelo_Entidades.Movimiento> ListadoMovimientos = new List<Modelo_Entidades.Movimiento>();

        // Declaro las controladoras a usar
        Controladora.cMovimiento cMovimiento;
        Controladora.cCtaCte cCtaCte;
        Controladora.cCuota cCuota;

        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmSeleccionCuotas ObtenerInstancia(Modelo_Entidades.Profesional oProfesional)
        {
            if (instancia == null)
            {
                instancia = new FrmSeleccionCuotas(oProfesional);
            }

            if (instancia.IsDisposed)
            {
                instancia = new FrmSeleccionCuotas(oProfesional);
            }

            return instancia;
        }

        // Constructor del formulario
        public FrmSeleccionCuotas(Modelo_Entidades.Profesional oProfesional)
        {
            InitializeComponent();
            // Inicializo las controladoras
            cMovimiento = Controladora.cMovimiento.ObtenerInstancia();
            cCtaCte = Controladora.cCtaCte.ObtenerInstancia();
            cCuota = Controladora.cCuota.ObtenerInstancia();
            miProfesional = oProfesional;
        }

        // Cuando carga el formualario
        private void FrmSeleccionCuotas_Load(object sender, EventArgs e)
        {
            if (miProfesional != null)
            {
                ArmaLista();
            }

        }

        // Agrego o desagrego cuotas al profesional, para luego cobrarlas
        private void chk_cuotas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Lo 1º que hago, es agregar o no las cuotas a la lista
            Modelo_Entidades.Cuota oCuot = (Modelo_Entidades.Cuota)chk_cuotas.SelectedItem;
            if (e.NewValue == CheckState.Checked)
            {
                ListadoCuotas.Add(oCuot);
            }

            else
            {
                ListadoCuotas.Remove(oCuot);
            }
        }

        // Pongo como pública la lista de movimientos
        public List<Modelo_Entidades.Movimiento> ListaMovimientos
        {
            get { return ListadoMovimientos; }
        }

        // Pongo como pública la lista de cuotas
        public List<Modelo_Entidades.Cuota> ListaCuotas
        {
            get { return ListadoCuotas; }
        }

        // Cuando le doy click a "Aceptar"
        private void btn_aceptar_Click(object sender, EventArgs e)
        {            
            if (chk_intereses.Checked == true)
            {
                foreach (Modelo_Entidades.Cuota oCuota in ListadoCuotas)
                {
                    oMovimiento = cMovimiento.BuscarMovimientoPorCuotaYProf(oCuota.descripcion, miProfesional.CtaCte.id);
                    TimeSpan dif = DateTime.Now - oMovimiento.fecha;
                    oMovimiento.importe = cCuota.ObtenerValor_Couta_Interes(cCuota.ObtenerValor_Tipo_Couta((oCuota)), dif.Days);
                    ListadoMovimientos.Add(oMovimiento);
                }
            }

            else
            {
                foreach (Modelo_Entidades.Cuota oCuota in ListadoCuotas)
                {
                    oMovimiento = cMovimiento.BuscarMovimientoPorCuotaYProf(oCuota.descripcion, miProfesional.CtaCte.id);
                    ListadoMovimientos.Add(oMovimiento);
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        // Cuando le doy click a "Cancelar"
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cuando le doy click a "Calcular"
        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double suma = 0;

            if (chk_intereses.Checked == true)
            {
                foreach (Modelo_Entidades.Cuota oCuota in ListadoCuotas)
                {                    
                    oMovimiento = cMovimiento.BuscarMovimientoPorCuotaYProf(oCuota.descripcion, miProfesional.CtaCte.id);
                    TimeSpan dif = DateTime.Now - oMovimiento.fecha;
                    oMovimiento.importe = cCuota.ObtenerValor_Couta_Interes(cCuota.ObtenerValor_Tipo_Couta((oCuota)), dif.Days);
                    suma = oMovimiento.importe + suma;
                }
            }

            else
            {
                foreach (Modelo_Entidades.Cuota oCuota in ListadoCuotas)
                {
                    oMovimiento = cMovimiento.BuscarMovimientoPorCuotaYProf(oCuota.descripcion, miProfesional.CtaCte.id);
                    //oMovimiento.importe = cCuota.ObtenerValor_Tipo_Couta(oCuota).Valor();
                    suma = oMovimiento.importe + suma;
                }
            }

            txt_total.Text = suma.ToString();
        }

        // Armo la lista
        private void ArmaLista()
        {
            chk_cuotas.DataSource = null;
            chk_cuotas.DataSource = cCuota.BuscarCuotasImpagasPorProfesional(miProfesional.dni);
            chk_cuotas.DisplayMember = "descripcion";
        }
    }
}
