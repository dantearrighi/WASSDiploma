namespace GCI
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.lb_nombreapellido = new System.Windows.Forms.Label();
            this.lb_grupo = new System.Windows.Forms.Label();
            this.txt_nombreapellido = new System.Windows.Forms.TextBox();
            this.cmb_grupos = new System.Windows.Forms.ComboBox();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.botonera1 = new GCI.Botonera1();
            this.btn_nuevaconsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToAddRows = false;
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_datos.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_datos.ColumnHeadersHeight = 25;
            this.dgv_datos.Location = new System.Drawing.Point(12, 125);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            this.dgv_datos.Size = new System.Drawing.Size(488, 285);
            this.dgv_datos.TabIndex = 1;
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Image = global::GCI.Properties.Resources.filter_icon_16;
            this.btn_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filtrar.Location = new System.Drawing.Point(380, 12);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(120, 35);
            this.btn_filtrar.TabIndex = 2;
            this.btn_filtrar.Text = "Filtrar Datos";
            this.btn_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // lb_nombreapellido
            // 
            this.lb_nombreapellido.BackColor = System.Drawing.Color.Transparent;
            this.lb_nombreapellido.Image = global::GCI.Properties.Resources.user_icon_16;
            this.lb_nombreapellido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_nombreapellido.Location = new System.Drawing.Point(12, 14);
            this.lb_nombreapellido.Name = "lb_nombreapellido";
            this.lb_nombreapellido.Size = new System.Drawing.Size(129, 35);
            this.lb_nombreapellido.TabIndex = 3;
            this.lb_nombreapellido.Text = "Nombre y Apellido:";
            this.lb_nombreapellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_grupo
            // 
            this.lb_grupo.BackColor = System.Drawing.Color.Transparent;
            this.lb_grupo.Image = global::GCI.Properties.Resources.users_icon_16;
            this.lb_grupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_grupo.Location = new System.Drawing.Point(12, 55);
            this.lb_grupo.Name = "lb_grupo";
            this.lb_grupo.Size = new System.Drawing.Size(129, 35);
            this.lb_grupo.TabIndex = 4;
            this.lb_grupo.Text = "Grupo:";
            this.lb_grupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_nombreapellido
            // 
            this.txt_nombreapellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nombreapellido.Location = new System.Drawing.Point(159, 22);
            this.txt_nombreapellido.Name = "txt_nombreapellido";
            this.txt_nombreapellido.Size = new System.Drawing.Size(205, 20);
            this.txt_nombreapellido.TabIndex = 6;
            // 
            // cmb_grupos
            // 
            this.cmb_grupos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_grupos.FormattingEnabled = true;
            this.cmb_grupos.Location = new System.Drawing.Point(159, 61);
            this.cmb_grupos.Name = "cmb_grupos";
            this.cmb_grupos.Size = new System.Drawing.Size(205, 21);
            this.cmb_grupos.TabIndex = 7;
            // 
            // chk_estado
            // 
            this.chk_estado.BackColor = System.Drawing.Color.Transparent;
            this.chk_estado.Image = global::GCI.Properties.Resources.chart_bar_icon_16;
            this.chk_estado.Location = new System.Drawing.Point(245, 88);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(119, 35);
            this.chk_estado.TabIndex = 8;
            this.chk_estado.Text = "Activo";
            this.chk_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_estado.UseVisualStyleBackColor = false;
            // 
            // botonera1
            // 
            this.botonera1.Location = new System.Drawing.Point(0, 416);
            this.botonera1.Name = "botonera1";
            this.botonera1.Size = new System.Drawing.Size(500, 45);
            this.botonera1.TabIndex = 0;
            this.botonera1.Click_Alta += new GCI.Eventos_Botonera(this.botonera1_Click_Alta);
            this.botonera1.Click_Baja += new GCI.Eventos_Botonera(this.botonera1_Click_Baja);
            this.botonera1.Click_Modificacion += new GCI.Eventos_Botonera(this.botonera1_Click_Modificacion);
            this.botonera1.Click_Consulta += new GCI.Eventos_Botonera(this.botonera1_Click_Consulta);
            this.botonera1.Click_Cerrar += new GCI.Eventos_Botonera(this.botonera1_Click_Cerrar);
            // 
            // btn_nuevaconsulta
            // 
            this.btn_nuevaconsulta.Image = global::GCI.Properties.Resources.reload_icon_16;
            this.btn_nuevaconsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevaconsulta.Location = new System.Drawing.Point(380, 53);
            this.btn_nuevaconsulta.Name = "btn_nuevaconsulta";
            this.btn_nuevaconsulta.Size = new System.Drawing.Size(120, 35);
            this.btn_nuevaconsulta.TabIndex = 15;
            this.btn_nuevaconsulta.Text = "Nueva Consulta";
            this.btn_nuevaconsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nuevaconsulta.UseVisualStyleBackColor = true;
            this.btn_nuevaconsulta.Click += new System.EventHandler(this.btn_nuevaconsulta_Click);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(504, 472);
            this.Controls.Add(this.btn_nuevaconsulta);
            this.Controls.Add(this.chk_estado);
            this.Controls.Add(this.cmb_grupos);
            this.Controls.Add(this.txt_nombreapellido);
            this.Controls.Add(this.lb_grupo);
            this.Controls.Add(this.lb_nombreapellido);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.botonera1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Gestion de Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Botonera1 botonera1;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.Label lb_nombreapellido;
        private System.Windows.Forms.Label lb_grupo;
        private System.Windows.Forms.TextBox txt_nombreapellido;
        private System.Windows.Forms.ComboBox cmb_grupos;
        private System.Windows.Forms.CheckBox chk_estado;
        private System.Windows.Forms.Button btn_nuevaconsulta;
    }
}