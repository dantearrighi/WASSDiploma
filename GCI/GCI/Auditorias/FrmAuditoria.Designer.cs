namespace GCI
{
    partial class FrmAuditoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuditoria));
            this.tabs_auditorias = new System.Windows.Forms.TabControl();
            this.tab_datos = new System.Windows.Forms.TabPage();
            this.grp_datos_principales = new System.Windows.Forms.GroupBox();
            this.txt_accion = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lb_accion = new System.Windows.Forms.Label();
            this.lb_fecha = new System.Windows.Forms.Label();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_fecha = new System.Windows.Forms.MaskedTextBox();
            this.tabs_auditorias.SuspendLayout();
            this.tab_datos.SuspendLayout();
            this.grp_datos_principales.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs_auditorias
            // 
            this.tabs_auditorias.Controls.Add(this.tab_datos);
            this.tabs_auditorias.Location = new System.Drawing.Point(13, 13);
            this.tabs_auditorias.Name = "tabs_auditorias";
            this.tabs_auditorias.SelectedIndex = 0;
            this.tabs_auditorias.Size = new System.Drawing.Size(542, 187);
            this.tabs_auditorias.TabIndex = 0;
            // 
            // tab_datos
            // 
            this.tab_datos.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.tab_datos.Controls.Add(this.grp_datos_principales);
            this.tab_datos.Location = new System.Drawing.Point(4, 22);
            this.tab_datos.Name = "tab_datos";
            this.tab_datos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_datos.Size = new System.Drawing.Size(534, 161);
            this.tab_datos.TabIndex = 0;
            this.tab_datos.Text = "Datos";
            this.tab_datos.UseVisualStyleBackColor = true;
            // 
            // grp_datos_principales
            // 
            this.grp_datos_principales.Controls.Add(this.txt_fecha);
            this.grp_datos_principales.Controls.Add(this.txt_accion);
            this.grp_datos_principales.Controls.Add(this.txt_usuario);
            this.grp_datos_principales.Controls.Add(this.lb_accion);
            this.grp_datos_principales.Controls.Add(this.lb_fecha);
            this.grp_datos_principales.Controls.Add(this.lb_usuario);
            this.grp_datos_principales.Location = new System.Drawing.Point(6, 6);
            this.grp_datos_principales.Name = "grp_datos_principales";
            this.grp_datos_principales.Size = new System.Drawing.Size(522, 149);
            this.grp_datos_principales.TabIndex = 0;
            this.grp_datos_principales.TabStop = false;
            this.grp_datos_principales.Text = "Datos principales";
            // 
            // txt_accion
            // 
            this.txt_accion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_accion.Location = new System.Drawing.Point(205, 88);
            this.txt_accion.Name = "txt_accion";
            this.txt_accion.Size = new System.Drawing.Size(299, 20);
            this.txt_accion.TabIndex = 11;
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_usuario.Location = new System.Drawing.Point(205, 24);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(299, 20);
            this.txt_usuario.TabIndex = 9;
            // 
            // lb_accion
            // 
            this.lb_accion.Image = global::GCI.Properties.Resources.wrench_plus_2_icon_16;
            this.lb_accion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_accion.Location = new System.Drawing.Point(6, 80);
            this.lb_accion.Name = "lb_accion";
            this.lb_accion.Size = new System.Drawing.Size(76, 35);
            this.lb_accion.TabIndex = 8;
            this.lb_accion.Text = "Acción:";
            this.lb_accion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_fecha
            // 
            this.lb_fecha.Image = global::GCI.Properties.Resources.calendar_1_icon_16;
            this.lb_fecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_fecha.Location = new System.Drawing.Point(6, 47);
            this.lb_fecha.Name = "lb_fecha";
            this.lb_fecha.Size = new System.Drawing.Size(76, 35);
            this.lb_fecha.TabIndex = 7;
            this.lb_fecha.Text = "Fecha:";
            this.lb_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_usuario
            // 
            this.lb_usuario.Image = global::GCI.Properties.Resources.user_icon_16;
            this.lb_usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_usuario.Location = new System.Drawing.Point(6, 16);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(186, 35);
            this.lb_usuario.TabIndex = 6;
            this.lb_usuario.Text = "Nombre y Apellido del Usuario:";
            this.lb_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_ok
            // 
            this.btn_ok.Image = global::GCI.Properties.Resources.cancel_icon_16;
            this.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ok.Location = new System.Drawing.Point(482, 206);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 35);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "Cerrar";
            this.btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_fecha
            // 
            this.txt_fecha.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_fecha.Location = new System.Drawing.Point(205, 55);
            this.txt_fecha.Mask = "00/00/0000";
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(299, 20);
            this.txt_fecha.TabIndex = 12;
            this.txt_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // FrmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.ClientSize = new System.Drawing.Size(569, 247);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tabs_auditorias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auditoria";
            this.Load += new System.EventHandler(this.FrmAuditoria_Load);
            this.tabs_auditorias.ResumeLayout(false);
            this.tab_datos.ResumeLayout(false);
            this.grp_datos_principales.ResumeLayout(false);
            this.grp_datos_principales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs_auditorias;
        private System.Windows.Forms.TabPage tab_datos;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.GroupBox grp_datos_principales;
        private System.Windows.Forms.TextBox txt_accion;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lb_accion;
        private System.Windows.Forms.Label lb_fecha;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.MaskedTextBox txt_fecha;
    }
}