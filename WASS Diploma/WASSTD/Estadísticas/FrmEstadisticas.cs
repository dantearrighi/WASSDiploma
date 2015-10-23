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
    public partial class FrmEstadisticas : Form
    {
        // Declaro las variables que voy a utilizar en el formulario
        private static FrmEstadisticas instancia;
        Controladora.cEspecialidad cEspecialidad;
        Controladora.cEstado cEstado;
        Controladora.cTipo_Matricula cTipo_Matricula;
        Controladora.cLocalidad cLocalidad;
        FrmListado_Prof_Est FormListadoPorEstado;
        FrmListado_Prof_TM FormListadoPorTM;
        FrmListado_Mat_Esp FormListadoPorEsp;
        FrmListado_Tit_Uni FormListadoPorUni;
        FrmListado_Tit_Esp FormListadoTitPorEsp;
        FrmListado_Cuotas_Esp FormListadoCuotasPorEsp;
        FrmListado_Cuotas_Desc FormListadoCuotasPorDesc;
        FrmListado_Expte_Esp FormListadoExptesPorEsp;
        FrmListado_Expte_Monto_Esp FormListadoExptesPorMontoEsp;
        FrmListado_Expte_Obra FormListadoExptesPorObra;

        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmEstadisticas ObtenerInstancia(Modelo_Entidades.Usuario oUsuario)
        {
            if (instancia == null)
            {
                instancia = new FrmEstadisticas(oUsuario);
            }

            if (instancia.IsDisposed)
            {
                instancia = new FrmEstadisticas(oUsuario);
            }

            return instancia;
        }

        // Establezco como privado al constructor
        private FrmEstadisticas(Modelo_Entidades.Usuario oUsuario)
        {
            InitializeComponent();
            cEspecialidad = Controladora.cEspecialidad.ObtenerInstancia();
            cEstado = Controladora.cEstado.ObtenerInstancia();
            cTipo_Matricula = Controladora.cTipo_Matricula.ObtenerInstancia();
            cLocalidad = Controladora.cLocalidad.ObtenerInstancia();
        }

        // Cuando le doy click a emitir listado de los profesionales
        private void btn_emitir_listado_prof_Click(object sender, EventArgs e)
        {
            if (rbtn_estado.Checked == true)
            {
                FormListadoPorEstado = new FrmListado_Prof_Est(dtp_fechadesde.Value, dtp_fechahasta.Value);
                DialogResult DrLogin = FormListadoPorEstado.ShowDialog();  
            }

            if (rbtn_tipo_mat.Checked == true)
            {
                FormListadoPorTM = new FrmListado_Prof_TM(dtp_fechadesde.Value, dtp_fechahasta.Value);
                DialogResult DrLogin = FormListadoPorTM.ShowDialog();  
            }

            if (rbtn_esp.Checked == true)
            {
                FormListadoPorEsp = new FrmListado_Mat_Esp(dtp_fechadesde.Value, dtp_fechahasta.Value);
                DialogResult DrLogin = FormListadoPorEsp.ShowDialog();
            }

            if (rbtn_universidad.Checked == true)
            {
                FormListadoPorUni = new FrmListado_Tit_Uni();
                DialogResult DrLogin = FormListadoPorUni.ShowDialog();
            }

            if (rbtn_tit_esp.Checked == true)
            {
                FormListadoTitPorEsp = new FrmListado_Tit_Esp();
                DialogResult DrLogin = FormListadoTitPorEsp.ShowDialog();
            }

            if (rbtn_cuotas_esp.Checked == true)
            {
                FormListadoCuotasPorEsp = new FrmListado_Cuotas_Esp(dtp_fechadesde.Value, dtp_fechahasta.Value);
                DialogResult DrLogin = FormListadoCuotasPorEsp.ShowDialog();
            }

            if (rbtn_cuotas_desc.Checked == true)
            {
                FormListadoCuotasPorDesc = new  FrmListado_Cuotas_Desc(dtp_fechadesde.Value, dtp_fechahasta.Value);
                DialogResult DrLogin = FormListadoCuotasPorDesc.ShowDialog();
            }

            if (rbtn_exp_esp.Checked == true)
            {
                FormListadoExptesPorEsp = new FrmListado_Expte_Esp(dtp_fechadesde.Value, dtp_fechahasta.Value);
                DialogResult DrLogin = FormListadoExptesPorEsp.ShowDialog();
            }

            if (rbtn_expte_monto_esp.Checked == true)
            {
                FormListadoExptesPorMontoEsp = new FrmListado_Expte_Monto_Esp(dtp_fechadesde.Value, dtp_fechahasta.Value);
                DialogResult DrLogin = FormListadoExptesPorMontoEsp.ShowDialog();
            }

            if (rbtn_exp_tarea.Checked == true)
            {
                FormListadoExptesPorObra = new FrmListado_Expte_Obra(dtp_fechadesde.Value, dtp_fechahasta.Value);
                DialogResult DrLogin = FormListadoExptesPorObra.ShowDialog();
            }
        }

        // Cunado carga el formulario
        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            dtp_fechadesde.Value = Convert.ToDateTime("01/01/2012");
            dtp_fechahasta.Value = DateTime.Now;
        }

        // Al hacer click en "Cancelar"
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }      
    }
}
