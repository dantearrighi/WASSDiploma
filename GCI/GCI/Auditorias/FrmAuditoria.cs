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
    public partial class FrmAuditoria : Form
    {
        // Hago públio el formulario para poder llamarlo desde otros
        public FrmAuditoria(Modelo_Entidades.Auditoria_Log oAuditoria)
        {
            InitializeComponent();
            txt_usuario.Text = oAuditoria.usuario;
            txt_fecha.Text = oAuditoria.fecha.ToString();
            txt_accion.Text = oAuditoria.accion;
        }

        // Al hacer click en "ok"
        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Al cargar el formulario
        private void FrmAuditoria_Load(object sender, EventArgs e)
        {
            grp_datos_principales.Enabled = false;
        }
    }
}
