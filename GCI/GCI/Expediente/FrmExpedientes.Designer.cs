namespace GCI
{
    partial class FrmExpedientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpedientes));
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.txt_nya_comitente = new System.Windows.Forms.TextBox();
            this.lb_tarea = new System.Windows.Forms.Label();
            this.lb_obra = new System.Windows.Forms.Label();
            this.lb_nya_comitente = new System.Windows.Forms.Label();
            this.cmb_obra = new System.Windows.Forms.ComboBox();
            this.grp_tareas = new System.Windows.Forms.GroupBox();
            this.cmb_descripcion_tarea = new System.Windows.Forms.ComboBox();
            this.btn_nuevaconsulta = new System.Windows.Forms.Button();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.lb_dni_profesional = new System.Windows.Forms.Label();
            this.cmb_nuevo_expediente = new System.Windows.Forms.ComboBox();
            this.lb_nuevo_expediente = new System.Windows.Forms.Label();
            this.botonera1 = new GCI.Botonera1();
            this.txt_profesional = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.grp_tareas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToAddRows = false;
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_datos.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(12, 152);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            this.dgv_datos.Size = new System.Drawing.Size(485, 268);
            this.dgv_datos.TabIndex = 1;
            // 
            // txt_nya_comitente
            // 
            this.txt_nya_comitente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nya_comitente.Location = new System.Drawing.Point(223, 32);
            this.txt_nya_comitente.Name = "txt_nya_comitente";
            this.txt_nya_comitente.Size = new System.Drawing.Size(277, 20);
            this.txt_nya_comitente.TabIndex = 9;
            // 
            // lb_tarea
            // 
            this.lb_tarea.Image = global::GCI.Properties.Resources.wrench_plus_icon_16;
            this.lb_tarea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_tarea.Location = new System.Drawing.Point(6, 42);
            this.lb_tarea.Name = "lb_tarea";
            this.lb_tarea.Size = new System.Drawing.Size(88, 35);
            this.lb_tarea.TabIndex = 8;
            this.lb_tarea.Text = "Tarea:";
            this.lb_tarea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_obra
            // 
            this.lb_obra.Image = global::GCI.Properties.Resources.wrench_plus_2_icon_16;
            this.lb_obra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_obra.Location = new System.Drawing.Point(6, 10);
            this.lb_obra.Name = "lb_obra";
            this.lb_obra.Size = new System.Drawing.Size(88, 35);
            this.lb_obra.TabIndex = 7;
            this.lb_obra.Text = "Obra:";
            this.lb_obra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_nya_comitente
            // 
            this.lb_nya_comitente.BackColor = System.Drawing.Color.Transparent;
            this.lb_nya_comitente.Image = global::GCI.Properties.Resources.contact_card_icon_16;
            this.lb_nya_comitente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_nya_comitente.Location = new System.Drawing.Point(21, 24);
            this.lb_nya_comitente.Name = "lb_nya_comitente";
            this.lb_nya_comitente.Size = new System.Drawing.Size(196, 35);
            this.lb_nya_comitente.TabIndex = 6;
            this.lb_nya_comitente.Text = "Razón Social del comitente:";
            this.lb_nya_comitente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_obra
            // 
            this.cmb_obra.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_obra.FormattingEnabled = true;
            this.cmb_obra.Location = new System.Drawing.Point(112, 13);
            this.cmb_obra.Name = "cmb_obra";
            this.cmb_obra.Size = new System.Drawing.Size(225, 21);
            this.cmb_obra.TabIndex = 12;
            this.cmb_obra.SelectedIndexChanged += new System.EventHandler(this.cmb_obra_SelectedIndexChanged);
            // 
            // grp_tareas
            // 
            this.grp_tareas.BackColor = System.Drawing.Color.Transparent;
            this.grp_tareas.Controls.Add(this.cmb_descripcion_tarea);
            this.grp_tareas.Controls.Add(this.lb_obra);
            this.grp_tareas.Controls.Add(this.cmb_obra);
            this.grp_tareas.Controls.Add(this.lb_tarea);
            this.grp_tareas.Location = new System.Drawing.Point(15, 58);
            this.grp_tareas.Name = "grp_tareas";
            this.grp_tareas.Size = new System.Drawing.Size(343, 88);
            this.grp_tareas.TabIndex = 13;
            this.grp_tareas.TabStop = false;
            this.grp_tareas.Text = "Tareas";
            // 
            // cmb_descripcion_tarea
            // 
            this.cmb_descripcion_tarea.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_descripcion_tarea.FormattingEnabled = true;
            this.cmb_descripcion_tarea.Location = new System.Drawing.Point(110, 50);
            this.cmb_descripcion_tarea.Name = "cmb_descripcion_tarea";
            this.cmb_descripcion_tarea.Size = new System.Drawing.Size(227, 21);
            this.cmb_descripcion_tarea.TabIndex = 13;
            // 
            // btn_nuevaconsulta
            // 
            this.btn_nuevaconsulta.Image = global::GCI.Properties.Resources.reload_icon_16;
            this.btn_nuevaconsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevaconsulta.Location = new System.Drawing.Point(380, 106);
            this.btn_nuevaconsulta.Name = "btn_nuevaconsulta";
            this.btn_nuevaconsulta.Size = new System.Drawing.Size(120, 35);
            this.btn_nuevaconsulta.TabIndex = 49;
            this.btn_nuevaconsulta.Text = "Nueva Consulta";
            this.btn_nuevaconsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nuevaconsulta.UseVisualStyleBackColor = true;
            this.btn_nuevaconsulta.Click += new System.EventHandler(this.btn_nuevaconsulta_Click);
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Image = global::GCI.Properties.Resources.filter_icon_16;
            this.btn_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filtrar.Location = new System.Drawing.Point(380, 65);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(120, 35);
            this.btn_filtrar.TabIndex = 48;
            this.btn_filtrar.Text = "Filtrar Datos";
            this.btn_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // lb_dni_profesional
            // 
            this.lb_dni_profesional.BackColor = System.Drawing.Color.Transparent;
            this.lb_dni_profesional.Image = global::GCI.Properties.Resources.page_layout_icon_16;
            this.lb_dni_profesional.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_dni_profesional.Location = new System.Drawing.Point(21, -2);
            this.lb_dni_profesional.Name = "lb_dni_profesional";
            this.lb_dni_profesional.Size = new System.Drawing.Size(196, 35);
            this.lb_dni_profesional.TabIndex = 50;
            this.lb_dni_profesional.Text = "DNI del profesional:";
            this.lb_dni_profesional.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_nuevo_expediente
            // 
            this.cmb_nuevo_expediente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_nuevo_expediente.FormattingEnabled = true;
            this.cmb_nuevo_expediente.Location = new System.Drawing.Point(233, 434);
            this.cmb_nuevo_expediente.Name = "cmb_nuevo_expediente";
            this.cmb_nuevo_expediente.Size = new System.Drawing.Size(264, 21);
            this.cmb_nuevo_expediente.TabIndex = 52;
            this.cmb_nuevo_expediente.SelectedIndexChanged += new System.EventHandler(this.cmb_nuevo_expediente_SelectedIndexChanged);
            // 
            // lb_nuevo_expediente
            // 
            this.lb_nuevo_expediente.BackColor = System.Drawing.Color.Transparent;
            this.lb_nuevo_expediente.Image = global::GCI.Properties.Resources.wrench_icon_16;
            this.lb_nuevo_expediente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_nuevo_expediente.Location = new System.Drawing.Point(12, 426);
            this.lb_nuevo_expediente.Name = "lb_nuevo_expediente";
            this.lb_nuevo_expediente.Size = new System.Drawing.Size(205, 35);
            this.lb_nuevo_expediente.TabIndex = 53;
            this.lb_nuevo_expediente.Text = "Seleccione el tipo de expediente:";
            this.lb_nuevo_expediente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // botonera1
            // 
            this.botonera1.BackColor = System.Drawing.Color.Transparent;
            this.botonera1.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.botonera1.Location = new System.Drawing.Point(12, 468);
            this.botonera1.Name = "botonera1";
            this.botonera1.Size = new System.Drawing.Size(488, 42);
            this.botonera1.TabIndex = 0;
            this.botonera1.Click_Alta += new GCI.Eventos_Botonera(this.botonera1_Click_Alta_1);
            this.botonera1.Click_Modificacion += new GCI.Eventos_Botonera(this.botonera1_Click_Modificacion_1);
            this.botonera1.Click_Consulta += new GCI.Eventos_Botonera(this.botonera1_Click_Consulta_1);
            this.botonera1.Click_Cerrar += new GCI.Eventos_Botonera(this.botonera1_Click_Cerrar_1);
            // 
            // txt_profesional
            // 
            this.txt_profesional.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_profesional.Location = new System.Drawing.Point(223, 6);
            this.txt_profesional.Mask = "99999999";
            this.txt_profesional.Name = "txt_profesional";
            this.txt_profesional.Size = new System.Drawing.Size(277, 20);
            this.txt_profesional.TabIndex = 54;
            // 
            // FrmExpedientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.ClientSize = new System.Drawing.Size(509, 522);
            this.Controls.Add(this.txt_profesional);
            this.Controls.Add(this.lb_nuevo_expediente);
            this.Controls.Add(this.cmb_nuevo_expediente);
            this.Controls.Add(this.lb_dni_profesional);
            this.Controls.Add(this.btn_nuevaconsulta);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.grp_tareas);
            this.Controls.Add(this.txt_nya_comitente);
            this.Controls.Add(this.lb_nya_comitente);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.botonera1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmExpedientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Expedientes";
            this.Load += new System.EventHandler(this.FrmExpedientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.grp_tareas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Botonera1 botonera1;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.TextBox txt_nya_comitente;
        private System.Windows.Forms.Label lb_tarea;
        private System.Windows.Forms.Label lb_obra;
        private System.Windows.Forms.Label lb_nya_comitente;
        private System.Windows.Forms.ComboBox cmb_obra;
        private System.Windows.Forms.GroupBox grp_tareas;
        private System.Windows.Forms.ComboBox cmb_descripcion_tarea;
        private System.Windows.Forms.Button btn_nuevaconsulta;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.Label lb_dni_profesional;
        private System.Windows.Forms.ComboBox cmb_nuevo_expediente;
        private System.Windows.Forms.Label lb_nuevo_expediente;
        private System.Windows.Forms.MaskedTextBox txt_profesional;
    }
}