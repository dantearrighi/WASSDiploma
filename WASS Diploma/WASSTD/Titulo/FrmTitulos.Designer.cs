namespace WASSTD
{
    partial class FrmTitulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTitulos));
            this.lb_universidad = new System.Windows.Forms.Label();
            this.lb_especialidad = new System.Windows.Forms.Label();
            this.cmb_universidad = new System.Windows.Forms.ComboBox();
            this.cmb_especialidades = new System.Windows.Forms.ComboBox();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.btn_nuevaconsulta = new System.Windows.Forms.Button();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.botonera1 = new WASSTD.Botonera1();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_universidad
            // 
            this.lb_universidad.BackColor = System.Drawing.Color.Transparent;
            this.lb_universidad.Image = global::WASSTD.Properties.Resources.bookmark_2_icon_16;
            this.lb_universidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_universidad.Location = new System.Drawing.Point(12, 9);
            this.lb_universidad.Name = "lb_universidad";
            this.lb_universidad.Size = new System.Drawing.Size(93, 35);
            this.lb_universidad.TabIndex = 16;
            this.lb_universidad.Text = "Universidad:";
            this.lb_universidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_especialidad
            // 
            this.lb_especialidad.BackColor = System.Drawing.Color.Transparent;
            this.lb_especialidad.Image = global::WASSTD.Properties.Resources.box_icon_16;
            this.lb_especialidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_especialidad.Location = new System.Drawing.Point(12, 45);
            this.lb_especialidad.Name = "lb_especialidad";
            this.lb_especialidad.Size = new System.Drawing.Size(93, 35);
            this.lb_especialidad.TabIndex = 31;
            this.lb_especialidad.Text = "Especialidad:";
            this.lb_especialidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_universidad
            // 
            this.cmb_universidad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_universidad.FormattingEnabled = true;
            this.cmb_universidad.Location = new System.Drawing.Point(111, 17);
            this.cmb_universidad.Name = "cmb_universidad";
            this.cmb_universidad.Size = new System.Drawing.Size(296, 21);
            this.cmb_universidad.TabIndex = 42;
            // 
            // cmb_especialidades
            // 
            this.cmb_especialidades.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_especialidades.FormattingEnabled = true;
            this.cmb_especialidades.Location = new System.Drawing.Point(111, 53);
            this.cmb_especialidades.Name = "cmb_especialidades";
            this.cmb_especialidades.Size = new System.Drawing.Size(296, 21);
            this.cmb_especialidades.TabIndex = 43;
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToAddRows = false;
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_datos.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(15, 90);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            this.dgv_datos.Size = new System.Drawing.Size(544, 312);
            this.dgv_datos.TabIndex = 44;
            // 
            // btn_nuevaconsulta
            // 
            this.btn_nuevaconsulta.Image = global::WASSTD.Properties.Resources.reload_icon_16;
            this.btn_nuevaconsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevaconsulta.Location = new System.Drawing.Point(437, 45);
            this.btn_nuevaconsulta.Name = "btn_nuevaconsulta";
            this.btn_nuevaconsulta.Size = new System.Drawing.Size(120, 35);
            this.btn_nuevaconsulta.TabIndex = 47;
            this.btn_nuevaconsulta.Text = "Nueva Consulta";
            this.btn_nuevaconsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nuevaconsulta.UseVisualStyleBackColor = true;
            this.btn_nuevaconsulta.Click += new System.EventHandler(this.btn_nuevaconsulta_Click);
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Image = global::WASSTD.Properties.Resources.filter_icon_16;
            this.btn_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filtrar.Location = new System.Drawing.Point(437, 4);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(120, 35);
            this.btn_filtrar.TabIndex = 46;
            this.btn_filtrar.Text = "Filtrar Datos";
            this.btn_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // botonera1
            // 
            this.botonera1.BackgroundImage = global::WASSTD.Properties.Resources.Fondo_Final;
            this.botonera1.Location = new System.Drawing.Point(15, 408);
            this.botonera1.Name = "botonera1";
            this.botonera1.Size = new System.Drawing.Size(542, 43);
            this.botonera1.TabIndex = 45;
            this.botonera1.Click_Alta += new WASSTD.Eventos_Botonera(this.botonera1_Click_Alta);
            this.botonera1.Click_Baja += new WASSTD.Eventos_Botonera(this.botonera1_Click_Baja);
            this.botonera1.Click_Modificacion += new WASSTD.Eventos_Botonera(this.botonera1_Click_Modificacion);
            this.botonera1.Click_Consulta += new WASSTD.Eventos_Botonera(this.botonera1_Click_Consulta);
            this.botonera1.Click_Cerrar += new WASSTD.Eventos_Botonera(this.botonera1_Click_Cerrar);
            // 
            // FrmTitulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WASSTD.Properties.Resources.Fondo_Final;
            this.ClientSize = new System.Drawing.Size(569, 462);
            this.Controls.Add(this.btn_nuevaconsulta);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.botonera1);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.cmb_especialidades);
            this.Controls.Add(this.cmb_universidad);
            this.Controls.Add(this.lb_especialidad);
            this.Controls.Add(this.lb_universidad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTitulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Titulos";
            this.Load += new System.EventHandler(this.FrmTitulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_universidad;
        private System.Windows.Forms.Label lb_especialidad;
        private System.Windows.Forms.ComboBox cmb_universidad;
        private System.Windows.Forms.ComboBox cmb_especialidades;
        private System.Windows.Forms.DataGridView dgv_datos;
        private Botonera1 botonera1;
        private System.Windows.Forms.Button btn_nuevaconsulta;
        private System.Windows.Forms.Button btn_filtrar;
    }
}