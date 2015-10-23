namespace WASSTD
{
    partial class FrmPlanesTitulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlanesTitulo));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lb_plan = new System.Windows.Forms.Label();
            this.txt_año = new System.Windows.Forms.TextBox();
            this.tab_planes = new System.Windows.Forms.TabControl();
            this.tab_datos = new System.Windows.Forms.TabPage();
            this.lb_descripcionplan = new System.Windows.Forms.Label();
            this.txt_plan_descripcion = new System.Windows.Forms.RichTextBox();
            this.txt_ordenanzaconsejo = new System.Windows.Forms.TextBox();
            this.lb_ordenanzaconsejo = new System.Windows.Forms.Label();
            this.tab_incumbencias = new System.Windows.Forms.TabPage();
            this.lb_descripcionincumbencia = new System.Windows.Forms.Label();
            this.txt_incumbencia = new System.Windows.Forms.RichTextBox();
            this.tab_planes.SuspendLayout();
            this.tab_datos.SuspendLayout();
            this.tab_incumbencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::WASSTD.Properties.Resources.cancel_icon_16;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(540, 504);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 35);
            this.btn_cancelar.TabIndex = 54;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::WASSTD.Properties.Resources.save_icon_16;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(459, 504);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 35);
            this.btn_guardar.TabIndex = 53;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lb_plan
            // 
            this.lb_plan.Image = global::WASSTD.Properties.Resources.bookmark_1_icon_16;
            this.lb_plan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_plan.Location = new System.Drawing.Point(6, 3);
            this.lb_plan.Name = "lb_plan";
            this.lb_plan.Size = new System.Drawing.Size(152, 35);
            this.lb_plan.TabIndex = 49;
            this.lb_plan.Text = "Plan:";
            this.lb_plan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_año
            // 
            this.txt_año.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_año.Location = new System.Drawing.Point(229, 11);
            this.txt_año.Name = "txt_año";
            this.txt_año.Size = new System.Drawing.Size(360, 20);
            this.txt_año.TabIndex = 55;
            // 
            // tab_planes
            // 
            this.tab_planes.Controls.Add(this.tab_datos);
            this.tab_planes.Controls.Add(this.tab_incumbencias);
            this.tab_planes.Location = new System.Drawing.Point(12, 12);
            this.tab_planes.Name = "tab_planes";
            this.tab_planes.SelectedIndex = 0;
            this.tab_planes.Size = new System.Drawing.Size(603, 486);
            this.tab_planes.TabIndex = 56;
            // 
            // tab_datos
            // 
            this.tab_datos.BackgroundImage = global::WASSTD.Properties.Resources.Fondo_Final;
            this.tab_datos.Controls.Add(this.lb_descripcionplan);
            this.tab_datos.Controls.Add(this.txt_plan_descripcion);
            this.tab_datos.Controls.Add(this.txt_ordenanzaconsejo);
            this.tab_datos.Controls.Add(this.lb_ordenanzaconsejo);
            this.tab_datos.Controls.Add(this.lb_plan);
            this.tab_datos.Controls.Add(this.txt_año);
            this.tab_datos.Location = new System.Drawing.Point(4, 22);
            this.tab_datos.Name = "tab_datos";
            this.tab_datos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_datos.Size = new System.Drawing.Size(595, 460);
            this.tab_datos.TabIndex = 0;
            this.tab_datos.Text = "Datos";
            this.tab_datos.UseVisualStyleBackColor = true;
            // 
            // lb_descripcionplan
            // 
            this.lb_descripcionplan.Image = global::WASSTD.Properties.Resources.book_icon_16;
            this.lb_descripcionplan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_descripcionplan.Location = new System.Drawing.Point(6, 83);
            this.lb_descripcionplan.Name = "lb_descripcionplan";
            this.lb_descripcionplan.Size = new System.Drawing.Size(152, 35);
            this.lb_descripcionplan.TabIndex = 59;
            this.lb_descripcionplan.Text = "Descripción del plan:";
            this.lb_descripcionplan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_plan_descripcion
            // 
            this.txt_plan_descripcion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_plan_descripcion.Location = new System.Drawing.Point(9, 118);
            this.txt_plan_descripcion.Name = "txt_plan_descripcion";
            this.txt_plan_descripcion.Size = new System.Drawing.Size(580, 336);
            this.txt_plan_descripcion.TabIndex = 58;
            this.txt_plan_descripcion.Text = "";
            // 
            // txt_ordenanzaconsejo
            // 
            this.txt_ordenanzaconsejo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_ordenanzaconsejo.Location = new System.Drawing.Point(229, 50);
            this.txt_ordenanzaconsejo.Name = "txt_ordenanzaconsejo";
            this.txt_ordenanzaconsejo.Size = new System.Drawing.Size(360, 20);
            this.txt_ordenanzaconsejo.TabIndex = 57;
            // 
            // lb_ordenanzaconsejo
            // 
            this.lb_ordenanzaconsejo.Image = global::WASSTD.Properties.Resources.bookmark_2_icon_16;
            this.lb_ordenanzaconsejo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_ordenanzaconsejo.Location = new System.Drawing.Point(6, 42);
            this.lb_ordenanzaconsejo.Name = "lb_ordenanzaconsejo";
            this.lb_ordenanzaconsejo.Size = new System.Drawing.Size(152, 35);
            this.lb_ordenanzaconsejo.TabIndex = 56;
            this.lb_ordenanzaconsejo.Text = "Ordenanza de aprobación:";
            this.lb_ordenanzaconsejo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tab_incumbencias
            // 
            this.tab_incumbencias.BackgroundImage = global::WASSTD.Properties.Resources.Fondo_Final;
            this.tab_incumbencias.Controls.Add(this.lb_descripcionincumbencia);
            this.tab_incumbencias.Controls.Add(this.txt_incumbencia);
            this.tab_incumbencias.Location = new System.Drawing.Point(4, 22);
            this.tab_incumbencias.Name = "tab_incumbencias";
            this.tab_incumbencias.Padding = new System.Windows.Forms.Padding(3);
            this.tab_incumbencias.Size = new System.Drawing.Size(595, 460);
            this.tab_incumbencias.TabIndex = 1;
            this.tab_incumbencias.Text = "Incumbencia";
            this.tab_incumbencias.UseVisualStyleBackColor = true;
            // 
            // lb_descripcionincumbencia
            // 
            this.lb_descripcionincumbencia.Image = global::WASSTD.Properties.Resources.book_icon_16;
            this.lb_descripcionincumbencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_descripcionincumbencia.Location = new System.Drawing.Point(6, 3);
            this.lb_descripcionincumbencia.Name = "lb_descripcionincumbencia";
            this.lb_descripcionincumbencia.Size = new System.Drawing.Size(184, 35);
            this.lb_descripcionincumbencia.TabIndex = 35;
            this.lb_descripcionincumbencia.Text = "Descripción de la incumbencia:";
            this.lb_descripcionincumbencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_incumbencia
            // 
            this.txt_incumbencia.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_incumbencia.Location = new System.Drawing.Point(9, 49);
            this.txt_incumbencia.Name = "txt_incumbencia";
            this.txt_incumbencia.Size = new System.Drawing.Size(580, 405);
            this.txt_incumbencia.TabIndex = 34;
            this.txt_incumbencia.Text = "";
            // 
            // FrmPlanesTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WASSTD.Properties.Resources.Fondo_Final;
            this.ClientSize = new System.Drawing.Size(619, 542);
            this.Controls.Add(this.tab_planes);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPlanesTitulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plan del Título";
            this.Load += new System.EventHandler(this.FrmPlanesTitulo_Load);
            this.tab_planes.ResumeLayout(false);
            this.tab_datos.ResumeLayout(false);
            this.tab_datos.PerformLayout();
            this.tab_incumbencias.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lb_plan;
        private System.Windows.Forms.TextBox txt_año;
        private System.Windows.Forms.TabControl tab_planes;
        private System.Windows.Forms.TabPage tab_datos;
        private System.Windows.Forms.TabPage tab_incumbencias;
        private System.Windows.Forms.TextBox txt_ordenanzaconsejo;
        private System.Windows.Forms.Label lb_ordenanzaconsejo;
        private System.Windows.Forms.Label lb_descripcionincumbencia;
        private System.Windows.Forms.RichTextBox txt_incumbencia;
        private System.Windows.Forms.Label lb_descripcionplan;
        private System.Windows.Forms.RichTextBox txt_plan_descripcion;
    }
}