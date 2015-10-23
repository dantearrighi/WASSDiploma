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
    public partial class FrmAuditorias : Form
    {
        // Declaro las variables que voy a utilizar en el formulario
        private static FrmAuditorias instancia;
        Controladora.cUsuario cUsuario;
        Controladora.cGrupo cGrupo;
        Controladora.cAuditoria cAuditoria;
        FrmAuditoria FormAuditoria;
        BindingSource BsAuditorias;

        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmAuditorias ObtenerInstancia(Modelo_Entidades.Usuario oUsuario)
        {
            if (instancia == null)
            {
                instancia = new FrmAuditorias(oUsuario);
            }

            if (instancia.IsDisposed)
            {
                instancia = new FrmAuditorias(oUsuario);
            }

            return instancia;
        }
        
        // Establezco como privado al constructor
        private FrmAuditorias(Modelo_Entidades.Usuario oUsuario)
        {
            InitializeComponent();
            cUsuario = Controladora.cUsuario.ObtenerInstancia();
            cGrupo = Controladora.cGrupo.ObtenerInstancia();
            cAuditoria = Controladora.cAuditoria.ObtenerInstancia();
            botonera1.ArmaPerfil(oUsuario, "FrmAuditorias");
        }

        // Cuando carga el formulario
        private void FrmAuditorias_Load(object sender, EventArgs e)
        {
            Arma_Lista();
        }

        // Armo la lista de la grilla de datos
        private void Arma_Lista()
        {
            botonera1.Hide(); // escondo la botonera ya que no tiene sentido que muestre el formulario de Auditoria
            // Instancio el binding source
            BsAuditorias = new BindingSource();
            //Luego lo lleno con los datos de la grilla
            BsAuditorias.DataSource = dgv_datos;

            cmb_acciones.DataSource = cAuditoria.ObtenerAcciones();
            cmb_acciones.SelectedItem = null;
            cmb_acciones.DisplayMember = "descripcion";

            // Limpio la grilla
            dgv_datos.DataSource = null;
            // LLeno el binding con los datos que traigo de las entidades
            BsAuditorias.DataSource = cAuditoria.ObtenerAuditorias();
            // Asigno el binding a la grilla
            dgv_datos.DataSource = BsAuditorias;
            dgv_datos.Columns[0].HeaderText = "Identificador";
            dgv_datos.Columns[1].HeaderText = "Nombre y Apellido del Usuario";
            dgv_datos.Columns[2].HeaderText = "Fecha";
            dgv_datos.Columns[3].HeaderText = "Acción";
        }

        // Al hacer click en "Formatear" (que se convirtió del "Agregar" tradicional...)
        private void botonera1_Click_Alta(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Está seguro que desea borrar la tabla de auditorias?", "Formato", MessageBoxButtons.YesNo);
            if (rta == DialogResult.Yes)
            {
                cAuditoria.FormatearAuditorias();
                Arma_Lista();
            }
        }

        // Al hacer click en "Eliminar"
        private void botonera1_Click_Baja(object sender, EventArgs e)
        {
            if (dgv_datos.CurrentRow == null)
                return;

            try
            {
                Modelo_Entidades.Auditoria_Log oAud = (Modelo_Entidades.Auditoria_Log)dgv_datos.CurrentRow.DataBoundItem;
                cAuditoria.BajaAuditoria(oAud);
                MessageBox.Show("Se ha eliminado el registro");
                Arma_Lista();
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.InnerException.ToString());
            }
        }

        // Al hacer click en "Cerrar"
        private void botonera1_Click_Cerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        // Al hacer click en "Ver detalles"
        private void botonera1_Click_Consulta(object sender, EventArgs e)
        {
            if (dgv_datos.CurrentRow == null)
            {
                return;
            }

            FormAuditoria = new FrmAuditoria((Modelo_Entidades.Auditoria_Log)dgv_datos.CurrentRow.DataBoundItem);
            DialogResult dr = FormAuditoria.ShowDialog();
        }

        // Al hacer click en "Filtrar"
        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            string nya;
            string VarCombo_accion;
            string fecha_desde;
            string fecha_hasta;

            if (txt_usuario.Text == "")
            {
                nya = "0";
            }

            else
            {
                nya = txt_usuario.Text;
            }

            if (cmb_acciones.SelectedValue == null)
            {
                VarCombo_accion = "0";
            }

            else
            {
                VarCombo_accion = cmb_acciones.SelectedValue.ToString();
            }

            if (dtp_fechadesde.Value == null)
            {
                fecha_desde = "0";
            }

            else
            {
                fecha_desde = dtp_fechadesde.Value.ToString();
            }

            if (dtp_fechahasta.Value == null)
            {
                fecha_hasta = "0";
            }

            else
            {
                fecha_hasta = dtp_fechahasta.Value.ToString();
            }

            BsAuditorias.DataSource = cAuditoria.FiltrarAuditorias(nya, VarCombo_accion, fecha_desde, fecha_hasta);
            dgv_datos.DataSource = BsAuditorias;
            dgv_datos.Columns[0].HeaderText = "Identificador";
            dgv_datos.Columns[1].HeaderText = "Nombre y Apellido del Usuario";
            dgv_datos.Columns[2].HeaderText = "Fecha";
            dgv_datos.Columns[3].HeaderText = "Acción";
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
