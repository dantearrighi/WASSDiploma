namespace GCI
{
    partial class FrmEstadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadisticas));
            this.rbtn_tipo_mat = new System.Windows.Forms.RadioButton();
            this.rbtn_estado = new System.Windows.Forms.RadioButton();
            this.rbtn_esp = new System.Windows.Forms.RadioButton();
            this.rbtn_tit_esp = new System.Windows.Forms.RadioButton();
            this.rbtn_universidad = new System.Windows.Forms.RadioButton();
            this.btn_emitir_listado_prof = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lb_fechahasta = new System.Windows.Forms.Label();
            this.dtp_fechahasta = new System.Windows.Forms.DateTimePicker();
            this.lb_fechadesde = new System.Windows.Forms.Label();
            this.dtp_fechadesde = new System.Windows.Forms.DateTimePicker();
            this.rbtn_cuotas_esp = new System.Windows.Forms.RadioButton();
            this.rbtn_cuotas_desc = new System.Windows.Forms.RadioButton();
            this.rbtn_exp_esp = new System.Windows.Forms.RadioButton();
            this.rbtn_expte_monto_esp = new System.Windows.Forms.RadioButton();
            this.rbtn_exp_tarea = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbtn_tipo_mat
            // 
            this.rbtn_tipo_mat.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_tipo_mat.Image = global::GCI.Properties.Resources.box_icon_16;
            this.rbtn_tipo_mat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtn_tipo_mat.Location = new System.Drawing.Point(19, 108);
            this.rbtn_tipo_mat.Name = "rbtn_tipo_mat";
            this.rbtn_tipo_mat.Size = new System.Drawing.Size(220, 35);
            this.rbtn_tipo_mat.TabIndex = 61;
            this.rbtn_tipo_mat.TabStop = true;
            this.rbtn_tipo_mat.Text = "Profesionales por tipo de matrícula";
            this.rbtn_tipo_mat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtn_tipo_mat.UseVisualStyleBackColor = false;
            // 
            // rbtn_estado
            // 
            this.rbtn_estado.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_estado.Image = global::GCI.Properties.Resources.box_icon_16;
            this.rbtn_estado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtn_estado.Location = new System.Drawing.Point(19, 76);
            this.rbtn_estado.Name = "rbtn_estado";
            this.rbtn_estado.Size = new System.Drawing.Size(174, 35);
            this.rbtn_estado.TabIndex = 60;
            this.rbtn_estado.TabStop = true;
            this.rbtn_estado.Text = "Profesionales por estado";
            this.rbtn_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtn_estado.UseVisualStyleBackColor = false;
            // 
            // rbtn_esp
            // 
            this.rbtn_esp.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_esp.Image = global::GCI.Properties.Resources.box_icon_16;
            this.rbtn_esp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtn_esp.Location = new System.Drawing.Point(302, 76);
            this.rbtn_esp.Name = "rbtn_esp";
            this.rbtn_esp.Size = new System.Drawing.Size(185, 35);
            this.rbtn_esp.TabIndex = 62;
            this.rbtn_esp.TabStop = true;
            this.rbtn_esp.Text = "Matrículas por especialidad";
            this.rbtn_esp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtn_esp.UseVisualStyleBackColor = false;
            // 
            // rbtn_tit_esp
            // 
            this.rbtn_tit_esp.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_tit_esp.Image = global::GCI.Properties.Resources.box_icon_16;
            this.rbtn_tit_esp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtn_tit_esp.Location = new System.Drawing.Point(19, 137);
            this.rbtn_tit_esp.Name = "rbtn_tit_esp";
            this.rbtn_tit_esp.Size = new System.Drawing.Size(174, 35);
            this.rbtn_tit_esp.TabIndex = 64;
            this.rbtn_tit_esp.TabStop = true;
            this.rbtn_tit_esp.Text = "Títulos por especialidad";
            this.rbtn_tit_esp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtn_tit_esp.UseVisualStyleBackColor = false;
            // 
            // rbtn_universidad
            // 
            this.rbtn_universidad.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_universidad.Image = global::GCI.Properties.Resources.bookmark_1_icon_16;
            this.rbtn_universidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtn_universidad.Location = new System.Drawing.Point(302, 108);
            this.rbtn_universidad.Name = "rbtn_universidad";
            this.rbtn_universidad.Size = new System.Drawing.Size(158, 35);
            this.rbtn_universidad.TabIndex = 63;
            this.rbtn_universidad.TabStop = true;
            this.rbtn_universidad.Text = "Títulos por universidad";
            this.rbtn_universidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtn_universidad.UseVisualStyleBackColor = false;
            // 
            // btn_emitir_listado_prof
            // 
            this.btn_emitir_listado_prof.Image = global::GCI.Properties.Resources.chart_bar_icon_16;
            this.btn_emitir_listado_prof.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_emitir_listado_prof.Location = new System.Drawing.Point(374, 475);
            this.btn_emitir_listado_prof.Name = "btn_emitir_listado_prof";
            this.btn_emitir_listado_prof.Size = new System.Drawing.Size(96, 35);
            this.btn_emitir_listado_prof.TabIndex = 50;
            this.btn_emitir_listado_prof.Text = "Emitir listado";
            this.btn_emitir_listado_prof.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_emitir_listado_prof.UseVisualStyleBackColor = true;
            this.btn_emitir_listado_prof.Click += new System.EventHandler(this.btn_emitir_listado_prof_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::GCI.Properties.Resources.cancel_icon_16;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(476, 475);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(81, 35);
            this.btn_cancelar.TabIndex = 49;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lb_fechahasta
            // 
            this.lb_fechahasta.BackColor = System.Drawing.Color.Transparent;
            this.lb_fechahasta.Image = ((System.Drawing.Image)(resources.GetObject("lb_fechahasta.Image")));
            this.lb_fechahasta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_fechahasta.Location = new System.Drawing.Point(22, 35);
            this.lb_fechahasta.Name = "lb_fechahasta";
            this.lb_fechahasta.Size = new System.Drawing.Size(94, 35);
            this.lb_fechahasta.TabIndex = 19;
            this.lb_fechahasta.Text = "Fecha Hasta:";
            this.lb_fechahasta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_fechahasta
            // 
            this.dtp_fechahasta.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtp_fechahasta.Location = new System.Drawing.Point(179, 40);
            this.dtp_fechahasta.Name = "dtp_fechahasta";
            this.dtp_fechahasta.Size = new System.Drawing.Size(244, 20);
            this.dtp_fechahasta.TabIndex = 18;
            this.dtp_fechahasta.Value = new System.DateTime(2013, 2, 25, 0, 0, 0, 0);
            // 
            // lb_fechadesde
            // 
            this.lb_fechadesde.BackColor = System.Drawing.Color.Transparent;
            this.lb_fechadesde.Image = ((System.Drawing.Image)(resources.GetObject("lb_fechadesde.Image")));
            this.lb_fechadesde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_fechadesde.Location = new System.Drawing.Point(22, 7);
            this.lb_fechadesde.Name = "lb_fechadesde";
            this.lb_fechadesde.Size = new System.Drawing.Size(94, 35);
            this.lb_fechadesde.TabIndex = 17;
            this.lb_fechadesde.Text = "Fecha Desde:";
            this.lb_fechadesde.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_fechadesde
            // 
            this.dtp_fechadesde.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtp_fechadesde.Location = new System.Drawing.Point(179, 12);
            this.dtp_fechadesde.Name = "dtp_fechadesde";
            this.dtp_fechadesde.Size = new System.Drawing.Size(244, 20);
            this.dtp_fechadesde.TabIndex = 16;
            this.dtp_fechadesde.Value = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            // 
            // rbtn_cuotas_esp
            // 
            this.rbtn_cuotas_esp.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_cuotas_esp.Image = global::GCI.Properties.Resources.money_icon_16;
            this.rbtn_cuotas_esp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtn_cuotas_esp.Location = new System.Drawing.Point(302, 137);
            this.rbtn_cuotas_esp.Name = "rbtn_cuotas_esp";
            this.rbtn_cuotas_esp.Size = new System.Drawing.Size(166, 35);
            this.rbtn_cuotas_esp.TabIndex = 65;
            this.rbtn_cuotas_esp.TabStop = true;
            this.rbtn_cuotas_esp.Text = "Cuotas por especialidad";
            this.rbtn_cuotas_esp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtn_cuotas_esp.UseVisualStyleBackColor = false;
            // 
            // rbtn_cuotas_desc
            // 
            this.rbtn_cuotas_desc.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_cuotas_desc.Image = global::GCI.Properties.Resources.money_icon_16;
            this.rbtn_cuotas_desc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtn_cuotas_desc.Location = new System.Drawing.Point(19, 167);
            this.rbtn_cuotas_desc.Name = "rbtn_cuotas_desc";
            this.rbtn_cuotas_desc.Size = new System.Drawing.Size(174, 35);
            this.rbtn_cuotas_desc.TabIndex = 66;
            this.rbtn_cuotas_desc.TabStop = true;
            this.rbtn_cuotas_desc.Text = "Cuotas por descripción";
            this.rbtn_cuotas_desc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtn_cuotas_desc.UseVisualStyleBackColor = false;
            // 
            // rbtn_exp_esp
            // 
            this.rbtn_exp_esp.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_exp_esp.Image = global::GCI.Properties.Resources.notepad_icon_16;
            this.rbtn_exp_esp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtn_exp_esp.Location = new System.Drawing.Point(302, 167);
            this.rbtn_exp_esp.Name = "rbtn_exp_esp";
            this.rbtn_exp_esp.Size = new System.Drawing.Size(191, 35);
            this.rbtn_exp_esp.TabIndex = 67;
            this.rbtn_exp_esp.TabStop = true;
            this.rbtn_exp_esp.Text = "Expedientes por especialidad";
            this.rbtn_exp_esp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtn_exp_esp.UseVisualStyleBackColor = false;
            // 
            // rbtn_expte_monto_esp
            // 
            this.rbtn_expte_monto_esp.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_expte_monto_esp.Image = global::GCI.Properties.Resources.notepad_icon_16;
            this.rbtn_expte_monto_esp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtn_expte_monto_esp.Location = new System.Drawing.Point(19, 194);
            this.rbtn_expte_monto_esp.Name = "rbtn_expte_monto_esp";
            this.rbtn_expte_monto_esp.Size = new System.Drawing.Size(241, 35);
            this.rbtn_expte_monto_esp.TabIndex = 68;
            this.rbtn_expte_monto_esp.TabStop = true;
            this.rbtn_expte_monto_esp.Text = "Montos de expedientes por especialidad";
            this.rbtn_expte_monto_esp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtn_expte_monto_esp.UseVisualStyleBackColor = false;
            // 
            // rbtn_exp_tarea
            // 
            this.rbtn_exp_tarea.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_exp_tarea.Image = global::GCI.Properties.Resources.notepad_icon_16;
            this.rbtn_exp_tarea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtn_exp_tarea.Location = new System.Drawing.Point(302, 194);
            this.rbtn_exp_tarea.Name = "rbtn_exp_tarea";
            this.rbtn_exp_tarea.Size = new System.Drawing.Size(158, 35);
            this.rbtn_exp_tarea.TabIndex = 69;
            this.rbtn_exp_tarea.TabStop = true;
            this.rbtn_exp_tarea.Text = "Expedientes por tarea";
            this.rbtn_exp_tarea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtn_exp_tarea.UseVisualStyleBackColor = false;
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.ClientSize = new System.Drawing.Size(569, 522);
            this.Controls.Add(this.rbtn_exp_tarea);
            this.Controls.Add(this.rbtn_expte_monto_esp);
            this.Controls.Add(this.rbtn_exp_esp);
            this.Controls.Add(this.rbtn_cuotas_desc);
            this.Controls.Add(this.rbtn_cuotas_esp);
            this.Controls.Add(this.rbtn_estado);
            this.Controls.Add(this.dtp_fechadesde);
            this.Controls.Add(this.rbtn_tit_esp);
            this.Controls.Add(this.btn_emitir_listado_prof);
            this.Controls.Add(this.rbtn_tipo_mat);
            this.Controls.Add(this.lb_fechadesde);
            this.Controls.Add(this.rbtn_universidad);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.rbtn_esp);
            this.Controls.Add(this.dtp_fechahasta);
            this.Controls.Add(this.lb_fechahasta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.FrmEstadisticas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_fechahasta;
        private System.Windows.Forms.DateTimePicker dtp_fechahasta;
        private System.Windows.Forms.Label lb_fechadesde;
        private System.Windows.Forms.DateTimePicker dtp_fechadesde;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_emitir_listado_prof;
        private System.Windows.Forms.RadioButton rbtn_tipo_mat;
        private System.Windows.Forms.RadioButton rbtn_estado;
        private System.Windows.Forms.RadioButton rbtn_esp;
        private System.Windows.Forms.RadioButton rbtn_universidad;
        private System.Windows.Forms.RadioButton rbtn_tit_esp;
        private System.Windows.Forms.RadioButton rbtn_cuotas_esp;
        private System.Windows.Forms.RadioButton rbtn_cuotas_desc;
        private System.Windows.Forms.RadioButton rbtn_exp_esp;
        private System.Windows.Forms.RadioButton rbtn_expte_monto_esp;
        private System.Windows.Forms.RadioButton rbtn_exp_tarea;
    }
}