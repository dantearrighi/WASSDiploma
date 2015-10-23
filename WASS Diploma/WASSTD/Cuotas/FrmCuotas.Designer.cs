namespace WASSTD
{
    partial class FrmCuotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCuotas));
            this.lb_porcentaje = new System.Windows.Forms.Label();
            this.txt_porcentaje = new System.Windows.Forms.TextBox();
            this.lb_dias = new System.Windows.Forms.Label();
            this.lb_valorcuota = new System.Windows.Forms.Label();
            this.grp_cuotas = new System.Windows.Forms.GroupBox();
            this.nud_cuontas_numeros = new System.Windows.Forms.NumericUpDown();
            this.rbtn_bimensual = new System.Windows.Forms.RadioButton();
            this.rbtn_anual = new System.Windows.Forms.RadioButton();
            this.nud_año = new System.Windows.Forms.NumericUpDown();
            this.lb_año = new System.Windows.Forms.Label();
            this.lb_cuota_numero = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.grp_modificadores = new System.Windows.Forms.GroupBox();
            this.txt_valor_bimensual = new System.Windows.Forms.MaskedTextBox();
            this.txt_dias_gracias = new System.Windows.Forms.MaskedTextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.grp_corrimiento = new System.Windows.Forms.GroupBox();
            this.nud_año_corrimiento = new System.Windows.Forms.NumericUpDown();
            this.lb_año_corrimiento = new System.Windows.Forms.Label();
            this.btn_corrimiento = new System.Windows.Forms.Button();
            this.lb_tipo_matricula = new System.Windows.Forms.Label();
            this.cmb_tipo_matricula = new System.Windows.Forms.ComboBox();
            this.grp_cuotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cuontas_numeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_año)).BeginInit();
            this.grp_modificadores.SuspendLayout();
            this.grp_corrimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_año_corrimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_porcentaje
            // 
            this.lb_porcentaje.Image = ((System.Drawing.Image)(resources.GetObject("lb_porcentaje.Image")));
            this.lb_porcentaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_porcentaje.Location = new System.Drawing.Point(6, 5);
            this.lb_porcentaje.Name = "lb_porcentaje";
            this.lb_porcentaje.Size = new System.Drawing.Size(254, 35);
            this.lb_porcentaje.TabIndex = 0;
            this.lb_porcentaje.Text = "Porcentaje de recargo (sobre los días de mora):";
            this.lb_porcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_porcentaje
            // 
            this.txt_porcentaje.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_porcentaje.Location = new System.Drawing.Point(266, 13);
            this.txt_porcentaje.Name = "txt_porcentaje";
            this.txt_porcentaje.Size = new System.Drawing.Size(113, 20);
            this.txt_porcentaje.TabIndex = 1;
            // 
            // lb_dias
            // 
            this.lb_dias.Image = global::WASSTD.Properties.Resources.page_layout_icon_16;
            this.lb_dias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_dias.Location = new System.Drawing.Point(6, 31);
            this.lb_dias.Name = "lb_dias";
            this.lb_dias.Size = new System.Drawing.Size(254, 35);
            this.lb_dias.TabIndex = 2;
            this.lb_dias.Text = "Días de gracia (antes del cobro de intereses):";
            this.lb_dias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_valorcuota
            // 
            this.lb_valorcuota.Image = ((System.Drawing.Image)(resources.GetObject("lb_valorcuota.Image")));
            this.lb_valorcuota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_valorcuota.Location = new System.Drawing.Point(6, 68);
            this.lb_valorcuota.Name = "lb_valorcuota";
            this.lb_valorcuota.Size = new System.Drawing.Size(169, 35);
            this.lb_valorcuota.TabIndex = 4;
            this.lb_valorcuota.Text = "Valor Cuota Bimensual:";
            this.lb_valorcuota.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grp_cuotas
            // 
            this.grp_cuotas.BackColor = System.Drawing.Color.Transparent;
            this.grp_cuotas.Controls.Add(this.cmb_tipo_matricula);
            this.grp_cuotas.Controls.Add(this.lb_tipo_matricula);
            this.grp_cuotas.Controls.Add(this.nud_cuontas_numeros);
            this.grp_cuotas.Controls.Add(this.rbtn_bimensual);
            this.grp_cuotas.Controls.Add(this.rbtn_anual);
            this.grp_cuotas.Controls.Add(this.nud_año);
            this.grp_cuotas.Controls.Add(this.lb_año);
            this.grp_cuotas.Controls.Add(this.lb_cuota_numero);
            this.grp_cuotas.Controls.Add(this.btn_generar);
            this.grp_cuotas.Location = new System.Drawing.Point(429, 12);
            this.grp_cuotas.Name = "grp_cuotas";
            this.grp_cuotas.Size = new System.Drawing.Size(243, 223);
            this.grp_cuotas.TabIndex = 6;
            this.grp_cuotas.TabStop = false;
            this.grp_cuotas.Text = "Generar Cuotas";
            // 
            // nud_cuontas_numeros
            // 
            this.nud_cuontas_numeros.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nud_cuontas_numeros.Location = new System.Drawing.Point(57, 58);
            this.nud_cuontas_numeros.Name = "nud_cuontas_numeros";
            this.nud_cuontas_numeros.Size = new System.Drawing.Size(87, 20);
            this.nud_cuontas_numeros.TabIndex = 7;
            // 
            // rbtn_bimensual
            // 
            this.rbtn_bimensual.AutoSize = true;
            this.rbtn_bimensual.Location = new System.Drawing.Point(152, 58);
            this.rbtn_bimensual.Name = "rbtn_bimensual";
            this.rbtn_bimensual.Size = new System.Drawing.Size(73, 17);
            this.rbtn_bimensual.TabIndex = 6;
            this.rbtn_bimensual.TabStop = true;
            this.rbtn_bimensual.Text = "Bimensual";
            this.rbtn_bimensual.UseVisualStyleBackColor = true;
            this.rbtn_bimensual.CheckedChanged += new System.EventHandler(this.rbtn_bimensual_CheckedChanged);
            // 
            // rbtn_anual
            // 
            this.rbtn_anual.AutoSize = true;
            this.rbtn_anual.Location = new System.Drawing.Point(152, 20);
            this.rbtn_anual.Name = "rbtn_anual";
            this.rbtn_anual.Size = new System.Drawing.Size(52, 17);
            this.rbtn_anual.TabIndex = 5;
            this.rbtn_anual.TabStop = true;
            this.rbtn_anual.Text = "Anual";
            this.rbtn_anual.UseVisualStyleBackColor = true;
            this.rbtn_anual.CheckedChanged += new System.EventHandler(this.rbtn_anual_CheckedChanged);
            // 
            // nud_año
            // 
            this.nud_año.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nud_año.Location = new System.Drawing.Point(63, 20);
            this.nud_año.Name = "nud_año";
            this.nud_año.Size = new System.Drawing.Size(81, 20);
            this.nud_año.TabIndex = 4;
            // 
            // lb_año
            // 
            this.lb_año.Image = ((System.Drawing.Image)(resources.GetObject("lb_año.Image")));
            this.lb_año.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_año.Location = new System.Drawing.Point(6, 11);
            this.lb_año.Name = "lb_año";
            this.lb_año.Size = new System.Drawing.Size(51, 35);
            this.lb_año.TabIndex = 3;
            this.lb_año.Text = "Año:";
            this.lb_año.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_cuota_numero
            // 
            this.lb_cuota_numero.Image = global::WASSTD.Properties.Resources.cc_icon_16;
            this.lb_cuota_numero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_cuota_numero.Location = new System.Drawing.Point(6, 50);
            this.lb_cuota_numero.Name = "lb_cuota_numero";
            this.lb_cuota_numero.Size = new System.Drawing.Size(45, 35);
            this.lb_cuota_numero.TabIndex = 2;
            this.lb_cuota_numero.Text = "Nº:";
            this.lb_cuota_numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_generar
            // 
            this.btn_generar.Image = global::WASSTD.Properties.Resources.arrow_bottom_icon_16;
            this.btn_generar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_generar.Location = new System.Drawing.Point(49, 182);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(176, 35);
            this.btn_generar.TabIndex = 0;
            this.btn_generar.Text = "Generar cuota seleccionada";
            this.btn_generar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // grp_modificadores
            // 
            this.grp_modificadores.BackColor = System.Drawing.Color.Transparent;
            this.grp_modificadores.Controls.Add(this.txt_valor_bimensual);
            this.grp_modificadores.Controls.Add(this.txt_dias_gracias);
            this.grp_modificadores.Controls.Add(this.btn_cancelar);
            this.grp_modificadores.Controls.Add(this.btn_guardar);
            this.grp_modificadores.Controls.Add(this.lb_porcentaje);
            this.grp_modificadores.Controls.Add(this.btn_editar);
            this.grp_modificadores.Controls.Add(this.lb_dias);
            this.grp_modificadores.Controls.Add(this.lb_valorcuota);
            this.grp_modificadores.Controls.Add(this.txt_porcentaje);
            this.grp_modificadores.Location = new System.Drawing.Point(12, 12);
            this.grp_modificadores.Name = "grp_modificadores";
            this.grp_modificadores.Size = new System.Drawing.Size(395, 158);
            this.grp_modificadores.TabIndex = 8;
            this.grp_modificadores.TabStop = false;
            this.grp_modificadores.Text = "Modificadores de la cuota";
            // 
            // txt_valor_bimensual
            // 
            this.txt_valor_bimensual.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_valor_bimensual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_valor_bimensual.Location = new System.Drawing.Point(181, 76);
            this.txt_valor_bimensual.Mask = "99999";
            this.txt_valor_bimensual.Name = "txt_valor_bimensual";
            this.txt_valor_bimensual.Size = new System.Drawing.Size(198, 20);
            this.txt_valor_bimensual.TabIndex = 11;
            this.txt_valor_bimensual.ValidatingType = typeof(int);
            // 
            // txt_dias_gracias
            // 
            this.txt_dias_gracias.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_dias_gracias.Location = new System.Drawing.Point(266, 39);
            this.txt_dias_gracias.Mask = "99";
            this.txt_dias_gracias.Name = "txt_dias_gracias";
            this.txt_dias_gracias.Size = new System.Drawing.Size(113, 20);
            this.txt_dias_gracias.TabIndex = 10;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::WASSTD.Properties.Resources.cancel_icon_16;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(294, 115);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 35);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::WASSTD.Properties.Resources.save_icon_16;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(213, 115);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 35);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Image = global::WASSTD.Properties.Resources.doc_edit_icon_16;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar.Location = new System.Drawing.Point(9, 115);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(103, 35);
            this.btn_editar.TabIndex = 7;
            this.btn_editar.Text = "Editar Valores";
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // grp_corrimiento
            // 
            this.grp_corrimiento.BackColor = System.Drawing.Color.Transparent;
            this.grp_corrimiento.Controls.Add(this.nud_año_corrimiento);
            this.grp_corrimiento.Controls.Add(this.lb_año_corrimiento);
            this.grp_corrimiento.Controls.Add(this.btn_corrimiento);
            this.grp_corrimiento.Location = new System.Drawing.Point(12, 176);
            this.grp_corrimiento.Name = "grp_corrimiento";
            this.grp_corrimiento.Size = new System.Drawing.Size(395, 59);
            this.grp_corrimiento.TabIndex = 9;
            this.grp_corrimiento.TabStop = false;
            this.grp_corrimiento.Text = "Habilitación anual";
            // 
            // nud_año_corrimiento
            // 
            this.nud_año_corrimiento.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nud_año_corrimiento.Location = new System.Drawing.Point(68, 22);
            this.nud_año_corrimiento.Name = "nud_año_corrimiento";
            this.nud_año_corrimiento.Size = new System.Drawing.Size(55, 20);
            this.nud_año_corrimiento.TabIndex = 2;
            // 
            // lb_año_corrimiento
            // 
            this.lb_año_corrimiento.Image = ((System.Drawing.Image)(resources.GetObject("lb_año_corrimiento.Image")));
            this.lb_año_corrimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_año_corrimiento.Location = new System.Drawing.Point(6, 13);
            this.lb_año_corrimiento.Name = "lb_año_corrimiento";
            this.lb_año_corrimiento.Size = new System.Drawing.Size(51, 35);
            this.lb_año_corrimiento.TabIndex = 1;
            this.lb_año_corrimiento.Text = "Año:";
            this.lb_año_corrimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_corrimiento
            // 
            this.btn_corrimiento.Image = global::WASSTD.Properties.Resources.arrow_right_icon_16;
            this.btn_corrimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_corrimiento.Location = new System.Drawing.Point(129, 13);
            this.btn_corrimiento.Name = "btn_corrimiento";
            this.btn_corrimiento.Size = new System.Drawing.Size(256, 35);
            this.btn_corrimiento.TabIndex = 0;
            this.btn_corrimiento.Text = "Generar el corrimiento para el año seleccionado";
            this.btn_corrimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_corrimiento.UseVisualStyleBackColor = true;
            this.btn_corrimiento.Click += new System.EventHandler(this.btn_corrimiento_Click);
            // 
            // lb_tipo_matricula
            // 
            this.lb_tipo_matricula.Image = global::WASSTD.Properties.Resources.page_layout_icon_16;
            this.lb_tipo_matricula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_tipo_matricula.Location = new System.Drawing.Point(6, 85);
            this.lb_tipo_matricula.Name = "lb_tipo_matricula";
            this.lb_tipo_matricula.Size = new System.Drawing.Size(116, 35);
            this.lb_tipo_matricula.TabIndex = 8;
            this.lb_tipo_matricula.Text = "Tipo de matrícula:";
            this.lb_tipo_matricula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_tipo_matricula
            // 
            this.cmb_tipo_matricula.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_tipo_matricula.FormattingEnabled = true;
            this.cmb_tipo_matricula.Location = new System.Drawing.Point(9, 129);
            this.cmb_tipo_matricula.Name = "cmb_tipo_matricula";
            this.cmb_tipo_matricula.Size = new System.Drawing.Size(216, 21);
            this.cmb_tipo_matricula.TabIndex = 9;
            // 
            // FrmCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WASSTD.Properties.Resources.Fondo_Final;
            this.ClientSize = new System.Drawing.Size(684, 247);
            this.Controls.Add(this.grp_corrimiento);
            this.Controls.Add(this.grp_modificadores);
            this.Controls.Add(this.grp_cuotas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCuotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Cuotas";
            this.Load += new System.EventHandler(this.FrmCuotas_Load);
            this.grp_cuotas.ResumeLayout(false);
            this.grp_cuotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cuontas_numeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_año)).EndInit();
            this.grp_modificadores.ResumeLayout(false);
            this.grp_modificadores.PerformLayout();
            this.grp_corrimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_año_corrimiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_porcentaje;
        private System.Windows.Forms.TextBox txt_porcentaje;
        private System.Windows.Forms.Label lb_dias;
        private System.Windows.Forms.Label lb_valorcuota;
        private System.Windows.Forms.GroupBox grp_cuotas;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.GroupBox grp_modificadores;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.NumericUpDown nud_año;
        private System.Windows.Forms.Label lb_año;
        private System.Windows.Forms.Label lb_cuota_numero;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.RadioButton rbtn_bimensual;
        private System.Windows.Forms.RadioButton rbtn_anual;
        private System.Windows.Forms.NumericUpDown nud_cuontas_numeros;
        private System.Windows.Forms.GroupBox grp_corrimiento;
        private System.Windows.Forms.NumericUpDown nud_año_corrimiento;
        private System.Windows.Forms.Label lb_año_corrimiento;
        private System.Windows.Forms.Button btn_corrimiento;
        private System.Windows.Forms.MaskedTextBox txt_valor_bimensual;
        private System.Windows.Forms.MaskedTextBox txt_dias_gracias;
        private System.Windows.Forms.ComboBox cmb_tipo_matricula;
        private System.Windows.Forms.Label lb_tipo_matricula;

    }
}