namespace GCI
{
    partial class FrmAuditorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuditorias));
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.cmb_acciones = new System.Windows.Forms.ComboBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lb_accion = new System.Windows.Forms.Label();
            this.lb_nombreapellido = new System.Windows.Forms.Label();
            this.dtp_fechadesde = new System.Windows.Forms.DateTimePicker();
            this.lb_fechadesde = new System.Windows.Forms.Label();
            this.dtp_fechahasta = new System.Windows.Forms.DateTimePicker();
            this.lb_fechahasta = new System.Windows.Forms.Label();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.botonera1 = new GCI.Botonera1();
            this.btn_nuevaconsulta = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToAddRows = false;
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_datos.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(12, 164);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            this.dgv_datos.Size = new System.Drawing.Size(488, 223);
            this.dgv_datos.TabIndex = 1;
            // 
            // cmb_acciones
            // 
            this.cmb_acciones.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_acciones.FormattingEnabled = true;
            this.cmb_acciones.Location = new System.Drawing.Point(190, 40);
            this.cmb_acciones.Name = "cmb_acciones";
            this.cmb_acciones.Size = new System.Drawing.Size(164, 21);
            this.cmb_acciones.TabIndex = 11;
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_usuario.Location = new System.Drawing.Point(190, 12);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(310, 20);
            this.txt_usuario.TabIndex = 10;
            // 
            // lb_accion
            // 
            this.lb_accion.BackColor = System.Drawing.Color.Transparent;
            this.lb_accion.Image = global::GCI.Properties.Resources.wrench_plus_2_icon_16;
            this.lb_accion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_accion.Location = new System.Drawing.Point(9, 40);
            this.lb_accion.Name = "lb_accion";
            this.lb_accion.Size = new System.Drawing.Size(68, 35);
            this.lb_accion.TabIndex = 9;
            this.lb_accion.Text = "Acción:";
            this.lb_accion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_nombreapellido
            // 
            this.lb_nombreapellido.BackColor = System.Drawing.Color.Transparent;
            this.lb_nombreapellido.Image = global::GCI.Properties.Resources.user_icon_16;
            this.lb_nombreapellido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_nombreapellido.Location = new System.Drawing.Point(8, 4);
            this.lb_nombreapellido.Name = "lb_nombreapellido";
            this.lb_nombreapellido.Size = new System.Drawing.Size(176, 35);
            this.lb_nombreapellido.TabIndex = 8;
            this.lb_nombreapellido.Text = "Nombre y Apellido del Usuario:";
            this.lb_nombreapellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_fechadesde
            // 
            this.dtp_fechadesde.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtp_fechadesde.Location = new System.Drawing.Point(130, 86);
            this.dtp_fechadesde.Name = "dtp_fechadesde";
            this.dtp_fechadesde.Size = new System.Drawing.Size(224, 20);
            this.dtp_fechadesde.TabIndex = 12;
            this.dtp_fechadesde.Value = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            // 
            // lb_fechadesde
            // 
            this.lb_fechadesde.BackColor = System.Drawing.Color.Transparent;
            this.lb_fechadesde.Image = ((System.Drawing.Image)(resources.GetObject("lb_fechadesde.Image")));
            this.lb_fechadesde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_fechadesde.Location = new System.Drawing.Point(9, 81);
            this.lb_fechadesde.Name = "lb_fechadesde";
            this.lb_fechadesde.Size = new System.Drawing.Size(100, 35);
            this.lb_fechadesde.TabIndex = 13;
            this.lb_fechadesde.Text = "Fecha Desde:";
            this.lb_fechadesde.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_fechahasta
            // 
            this.dtp_fechahasta.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtp_fechahasta.Location = new System.Drawing.Point(130, 119);
            this.dtp_fechahasta.Name = "dtp_fechahasta";
            this.dtp_fechahasta.Size = new System.Drawing.Size(224, 20);
            this.dtp_fechahasta.TabIndex = 14;
            this.dtp_fechahasta.Value = new System.DateTime(2012, 8, 22, 23, 32, 11, 0);
            // 
            // lb_fechahasta
            // 
            this.lb_fechahasta.BackColor = System.Drawing.Color.Transparent;
            this.lb_fechahasta.Image = ((System.Drawing.Image)(resources.GetObject("lb_fechahasta.Image")));
            this.lb_fechahasta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_fechahasta.Location = new System.Drawing.Point(8, 109);
            this.lb_fechahasta.Name = "lb_fechahasta";
            this.lb_fechahasta.Size = new System.Drawing.Size(101, 35);
            this.lb_fechahasta.TabIndex = 15;
            this.lb_fechahasta.Text = "Fecha Hasta:";
            this.lb_fechahasta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Image = global::GCI.Properties.Resources.filter_icon_16;
            this.btn_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filtrar.Location = new System.Drawing.Point(380, 40);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(120, 35);
            this.btn_filtrar.TabIndex = 16;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // botonera1
            // 
            this.botonera1.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.botonera1.Location = new System.Drawing.Point(9, 404);
            this.botonera1.Name = "botonera1";
            this.botonera1.Size = new System.Drawing.Size(488, 46);
            this.botonera1.TabIndex = 0;
            this.botonera1.Click_Alta += new GCI.Eventos_Botonera(this.botonera1_Click_Alta);
            this.botonera1.Click_Baja += new GCI.Eventos_Botonera(this.botonera1_Click_Baja);
            this.botonera1.Click_Consulta += new GCI.Eventos_Botonera(this.botonera1_Click_Consulta);
            this.botonera1.Click_Cerrar += new GCI.Eventos_Botonera(this.botonera1_Click_Cerrar);
            // 
            // btn_nuevaconsulta
            // 
            this.btn_nuevaconsulta.Image = global::GCI.Properties.Resources.reload_icon_16;
            this.btn_nuevaconsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevaconsulta.Location = new System.Drawing.Point(380, 81);
            this.btn_nuevaconsulta.Name = "btn_nuevaconsulta";
            this.btn_nuevaconsulta.Size = new System.Drawing.Size(120, 35);
            this.btn_nuevaconsulta.TabIndex = 48;
            this.btn_nuevaconsulta.Text = "Nueva Consulta";
            this.btn_nuevaconsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nuevaconsulta.UseVisualStyleBackColor = true;
            this.btn_nuevaconsulta.Click += new System.EventHandler(this.btn_nuevaconsulta_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::GCI.Properties.Resources.cancel_icon_16;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(380, 119);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(120, 35);
            this.btn_cancelar.TabIndex = 49;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // FrmAuditorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.ClientSize = new System.Drawing.Size(509, 462);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_nuevaconsulta);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.lb_fechahasta);
            this.Controls.Add(this.dtp_fechahasta);
            this.Controls.Add(this.lb_fechadesde);
            this.Controls.Add(this.dtp_fechadesde);
            this.Controls.Add(this.cmb_acciones);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lb_accion);
            this.Controls.Add(this.lb_nombreapellido);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.botonera1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAuditorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Auditorias";
            this.Load += new System.EventHandler(this.FrmAuditorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Botonera1 botonera1;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.ComboBox cmb_acciones;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lb_accion;
        private System.Windows.Forms.Label lb_nombreapellido;
        private System.Windows.Forms.DateTimePicker dtp_fechadesde;
        private System.Windows.Forms.Label lb_fechadesde;
        private System.Windows.Forms.DateTimePicker dtp_fechahasta;
        private System.Windows.Forms.Label lb_fechahasta;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.Button btn_nuevaconsulta;
        private System.Windows.Forms.Button btn_cancelar;
    }
}