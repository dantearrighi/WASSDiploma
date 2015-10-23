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
    public partial class FrmAuditoriaCuotas : Form
    {
        // Declaro las variables que voy a utilizar en el formulario
        private static FrmAuditoriaCuotas instancia;
        Controladora.cAuditoria cAuditoria;
        BindingSource BsAuditorias;
        Modelo_Entidades.Usuario miUsuario;

        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmAuditoriaCuotas ObtenerInstancia(Modelo_Entidades.Usuario oUsuario)
        {
            if (instancia == null)
            {
                instancia = new FrmAuditoriaCuotas(oUsuario);
            }

            if (instancia.IsDisposed)
            {
                instancia = new FrmAuditoriaCuotas(oUsuario);
            }

            return instancia;
        }

        // Establezco como privado al constructor
        private FrmAuditoriaCuotas(Modelo_Entidades.Usuario oUsuario)
        {
            InitializeComponent();
            cAuditoria = Controladora.cAuditoria.ObtenerInstancia();
            miUsuario = oUsuario;
        }

        // Cuando carga el formulario
        private void FrmAuditoriaCuotas_Load(object sender, EventArgs e)
        {
            Arma_Lista();
        }

        // Armo la lista de la grilla de datos
        private void Arma_Lista()
        {
            // Instancio el binding source
            BsAuditorias = new BindingSource();
            //Luego lo lleno con los datos de la grilla
            BsAuditorias.DataSource = dgv_datos;

            // Limpio la grilla
            dgv_datos.DataSource = null;
            // LLeno el binding con los datos que traigo de las entidades
            BsAuditorias.DataSource = cAuditoria.ObtenerAuditoriasCuotas();
            // Asigno el binding a la grilla
            dgv_datos.DataSource = BsAuditorias;
            dgv_datos.Columns[0].Visible = false;
            dgv_datos.Columns[1].Visible = false;
            dgv_datos.Columns[2].HeaderText = "Descripción";
            dgv_datos.Columns[3].HeaderText = "DNI del profesional";
            dgv_datos.Columns[4].HeaderText = "Usuario";
            dgv_datos.Columns[5].Visible = false;
            dgv_datos.Columns[6].HeaderText = "Acción";
        }

        // Al hacer click en "Filtrar"
        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            string nya;
            string dni;
            string cuota;

            if (txt_usuario.Text == "")
            {
                nya = "0";
            }

            else
            {
                nya = txt_usuario.Text;
            }

            if (txt_dni_profesional.Text == null)
            {
                dni = "0";
            }

            else
            {
                dni = txt_dni_profesional.Text;
            }

            if (txt_cuota.Text == null)
            {
                cuota = "0";
            }

            else
            {
                cuota = txt_cuota.Text;
            }

            BsAuditorias.DataSource = cAuditoria.FiltrarAuditoriasCuotas(nya, dni, cuota);
            dgv_datos.DataSource = BsAuditorias;
            dgv_datos.Columns[0].Visible = false;
            dgv_datos.Columns[1].Visible = false;
            dgv_datos.Columns[2].HeaderText = "Descripción";
            dgv_datos.Columns[3].HeaderText = "DNI del profesional";
            dgv_datos.Columns[4].HeaderText = "Usuario";
            dgv_datos.Columns[5].Visible = false;
            dgv_datos.Columns[6].HeaderText = "Acción";
        }

        // Al hacer click en "Nueva consulta"
        private void btn_nuevaconsulta_Click(object sender, EventArgs e)
        {
            Arma_Lista();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
