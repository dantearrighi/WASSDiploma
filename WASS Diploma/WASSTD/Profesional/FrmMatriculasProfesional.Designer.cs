namespace WASSTD
{
    partial class FrmMatriculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMatriculas));
            this.lb_universidad = new System.Windows.Forms.Label();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.lb_plan = new System.Windows.Forms.Label();
            this.cmb_universidad = new System.Windows.Forms.ComboBox();
            this.cmb_titulos = new System.Windows.Forms.ComboBox();
            this.cmb_planes = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.grp_requisitos = new System.Windows.Forms.GroupBox();
            this.txt_fechadoc = new System.Windows.Forms.MaskedTextBox();
            this.grp_documento = new System.Windows.Forms.GroupBox();
            this.rbtn_certificado = new System.Windows.Forms.RadioButton();
            this.rbtn_diploma = new System.Windows.Forms.RadioButton();
            this.chk_analitico = new System.Windows.Forms.CheckBox();
            this.chk_plan = new System.Windows.Forms.CheckBox();
            this.chk_incumbencias = new System.Windows.Forms.CheckBox();
            this.lb_fecha = new System.Windows.Forms.Label();
            this.grp_requisitos.SuspendLayout();
            this.grp_documento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_universidad
            // 
            this.lb_universidad.BackColor = System.Drawing.Color.Transparent;
            this.lb_universidad.Image = global::WASSTD.Properties.Resources.bookmark_1_icon_16;
            this.lb_universidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_universidad.Location = new System.Drawing.Point(12, -2);
            this.lb_universidad.Name = "lb_universidad";
            this.lb_universidad.Size = new System.Drawing.Size(144, 35);
            this.lb_universidad.TabIndex = 17;
            this.lb_universidad.Text = "Universidad:";
            this.lb_universidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_titulo
            // 
            this.lb_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lb_titulo.Image = global::WASSTD.Properties.Resources.cert_icon_16;
            this.lb_titulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_titulo.Location = new System.Drawing.Point(12, 24);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(144, 35);
            this.lb_titulo.TabIndex = 16;
            this.lb_titulo.Text = "Título:";
            this.lb_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_plan
            // 
            this.lb_plan.BackColor = System.Drawing.Color.Transparent;
            this.lb_plan.Image = global::WASSTD.Properties.Resources.book_icon_161;
            this.lb_plan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_plan.Location = new System.Drawing.Point(12, 51);
            this.lb_plan.Name = "lb_plan";
            this.lb_plan.Size = new System.Drawing.Size(144, 35);
            this.lb_plan.TabIndex = 27;
            this.lb_plan.Text = "Plan:";
            this.lb_plan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_universidad
            // 
            this.cmb_universidad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_universidad.FormattingEnabled = true;
            this.cmb_universidad.Location = new System.Drawing.Point(186, 6);
            this.cmb_universidad.Name = "cmb_universidad";
            this.cmb_universidad.Size = new System.Drawing.Size(436, 21);
            this.cmb_universidad.TabIndex = 42;
            this.cmb_universidad.SelectionChangeCommitted += new System.EventHandler(this.cmb_universidad_SelectionChangeCommitted);
            // 
            // cmb_titulos
            // 
            this.cmb_titulos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_titulos.FormattingEnabled = true;
            this.cmb_titulos.Location = new System.Drawing.Point(186, 32);
            this.cmb_titulos.Name = "cmb_titulos";
            this.cmb_titulos.Size = new System.Drawing.Size(436, 21);
            this.cmb_titulos.TabIndex = 43;
            this.cmb_titulos.SelectionChangeCommitted += new System.EventHandler(this.cmb_titulos_SelectionChangeCommitted);
            // 
            // cmb_planes
            // 
            this.cmb_planes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_planes.FormattingEnabled = true;
            this.cmb_planes.Location = new System.Drawing.Point(186, 59);
            this.cmb_planes.Name = "cmb_planes";
            this.cmb_planes.Size = new System.Drawing.Size(436, 21);
            this.cmb_planes.TabIndex = 44;
            this.cmb_planes.SelectionChangeCommitted += new System.EventHandler(this.cmb_planes_SelectionChangeCommitted);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::WASSTD.Properties.Resources.save_icon_16;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(468, 181);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 35);
            this.btn_guardar.TabIndex = 45;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::WASSTD.Properties.Resources.cancel_icon_16;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(547, 181);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 35);
            this.btn_cancelar.TabIndex = 46;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // grp_requisitos
            // 
            this.grp_requisitos.BackColor = System.Drawing.Color.Transparent;
            this.grp_requisitos.Controls.Add(this.txt_fechadoc);
            this.grp_requisitos.Controls.Add(this.grp_documento);
            this.grp_requisitos.Controls.Add(this.chk_analitico);
            this.grp_requisitos.Controls.Add(this.chk_plan);
            this.grp_requisitos.Controls.Add(this.chk_incumbencias);
            this.grp_requisitos.Controls.Add(this.lb_fecha);
            this.grp_requisitos.Location = new System.Drawing.Point(15, 95);
            this.grp_requisitos.Name = "grp_requisitos";
            this.grp_requisitos.Size = new System.Drawing.Size(607, 80);
            this.grp_requisitos.TabIndex = 47;
            this.grp_requisitos.TabStop = false;
            this.grp_requisitos.Text = "Requisitos para la inscripción";
            // 
            // txt_fechadoc
            // 
            this.txt_fechadoc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_fechadoc.Location = new System.Drawing.Point(440, 18);
            this.txt_fechadoc.Mask = "00/00/0000";
            this.txt_fechadoc.Name = "txt_fechadoc";
            this.txt_fechadoc.Size = new System.Drawing.Size(123, 20);
            this.txt_fechadoc.TabIndex = 19;
            this.txt_fechadoc.ValidatingType = typeof(System.DateTime);
            // 
            // grp_documento
            // 
            this.grp_documento.Controls.Add(this.rbtn_certificado);
            this.grp_documento.Controls.Add(this.rbtn_diploma);
            this.grp_documento.Location = new System.Drawing.Point(9, 9);
            this.grp_documento.Name = "grp_documento";
            this.grp_documento.Size = new System.Drawing.Size(200, 39);
            this.grp_documento.TabIndex = 6;
            this.grp_documento.TabStop = false;
            // 
            // rbtn_certificado
            // 
            this.rbtn_certificado.AutoSize = true;
            this.rbtn_certificado.Location = new System.Drawing.Point(9, 10);
            this.rbtn_certificado.Name = "rbtn_certificado";
            this.rbtn_certificado.Size = new System.Drawing.Size(75, 17);
            this.rbtn_certificado.TabIndex = 14;
            this.rbtn_certificado.TabStop = true;
            this.rbtn_certificado.Text = "Certificado";
            this.rbtn_certificado.UseVisualStyleBackColor = true;
            // 
            // rbtn_diploma
            // 
            this.rbtn_diploma.AutoSize = true;
            this.rbtn_diploma.Location = new System.Drawing.Point(119, 10);
            this.rbtn_diploma.Name = "rbtn_diploma";
            this.rbtn_diploma.Size = new System.Drawing.Size(63, 17);
            this.rbtn_diploma.TabIndex = 15;
            this.rbtn_diploma.TabStop = true;
            this.rbtn_diploma.Text = "Diploma";
            this.rbtn_diploma.UseVisualStyleBackColor = true;
            // 
            // chk_analitico
            // 
            this.chk_analitico.AutoSize = true;
            this.chk_analitico.Location = new System.Drawing.Point(243, 57);
            this.chk_analitico.Name = "chk_analitico";
            this.chk_analitico.Size = new System.Drawing.Size(120, 17);
            this.chk_analitico.TabIndex = 18;
            this.chk_analitico.Text = "Certificado analítico";
            this.chk_analitico.UseVisualStyleBackColor = true;
            // 
            // chk_plan
            // 
            this.chk_plan.AutoSize = true;
            this.chk_plan.Location = new System.Drawing.Point(117, 57);
            this.chk_plan.Name = "chk_plan";
            this.chk_plan.Size = new System.Drawing.Size(99, 17);
            this.chk_plan.TabIndex = 17;
            this.chk_plan.Text = "Plan de estudio";
            this.chk_plan.UseVisualStyleBackColor = true;
            // 
            // chk_incumbencias
            // 
            this.chk_incumbencias.AutoSize = true;
            this.chk_incumbencias.Location = new System.Drawing.Point(9, 57);
            this.chk_incumbencias.Name = "chk_incumbencias";
            this.chk_incumbencias.Size = new System.Drawing.Size(92, 17);
            this.chk_incumbencias.TabIndex = 16;
            this.chk_incumbencias.Text = "Incumbencias";
            this.chk_incumbencias.UseVisualStyleBackColor = true;
            // 
            // lb_fecha
            // 
            this.lb_fecha.Image = global::WASSTD.Properties.Resources.calendar_1_icon_16;
            this.lb_fecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_fecha.Location = new System.Drawing.Point(268, 10);
            this.lb_fecha.Name = "lb_fecha";
            this.lb_fecha.Size = new System.Drawing.Size(157, 35);
            this.lb_fecha.TabIndex = 12;
            this.lb_fecha.Text = "Fecha del documento:";
            this.lb_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmMatriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WASSTD.Properties.Resources.Fondo_Final;
            this.ClientSize = new System.Drawing.Size(634, 236);
            this.Controls.Add(this.grp_requisitos);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.cmb_planes);
            this.Controls.Add(this.cmb_titulos);
            this.Controls.Add(this.cmb_universidad);
            this.Controls.Add(this.lb_plan);
            this.Controls.Add(this.lb_universidad);
            this.Controls.Add(this.lb_titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMatriculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrículas del Profesional";
            this.Load += new System.EventHandler(this.FrmTitulosProfesional_Load);
            this.grp_requisitos.ResumeLayout(false);
            this.grp_requisitos.PerformLayout();
            this.grp_documento.ResumeLayout(false);
            this.grp_documento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_universidad;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Label lb_plan;
        private System.Windows.Forms.ComboBox cmb_universidad;
        private System.Windows.Forms.ComboBox cmb_titulos;
        private System.Windows.Forms.ComboBox cmb_planes;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox grp_requisitos;
        private System.Windows.Forms.MaskedTextBox txt_fechadoc;
        private System.Windows.Forms.GroupBox grp_documento;
        private System.Windows.Forms.RadioButton rbtn_certificado;
        private System.Windows.Forms.RadioButton rbtn_diploma;
        private System.Windows.Forms.CheckBox chk_analitico;
        private System.Windows.Forms.CheckBox chk_plan;
        private System.Windows.Forms.CheckBox chk_incumbencias;
        private System.Windows.Forms.Label lb_fecha;
    }
}