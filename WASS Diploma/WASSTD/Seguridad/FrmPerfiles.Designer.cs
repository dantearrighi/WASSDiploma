namespace WASSTD
{
    partial class FrmPerfiles
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfiles));
            this.cmb_formularios = new System.Windows.Forms.ComboBox();
            this.cmb_permisos = new System.Windows.Forms.ComboBox();
            this.lb_formulario = new System.Windows.Forms.Label();
            this.lb_permiso = new System.Windows.Forms.Label();
            this.lb_grupo = new System.Windows.Forms.Label();
            this.cmb_grupos = new System.Windows.Forms.ComboBox();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.btn_nuevaconsulta = new System.Windows.Forms.Button();
            this.botonera1 = new WASSTD.Botonera1();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_formularios
            // 
            this.cmb_formularios.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_formularios.FormattingEnabled = true;
            this.cmb_formularios.Location = new System.Drawing.Point(139, 45);
            this.cmb_formularios.Name = "cmb_formularios";
            this.cmb_formularios.Size = new System.Drawing.Size(196, 21);
            this.cmb_formularios.TabIndex = 11;
            // 
            // cmb_permisos
            // 
            this.cmb_permisos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_permisos.FormattingEnabled = true;
            this.cmb_permisos.Location = new System.Drawing.Point(139, 83);
            this.cmb_permisos.Name = "cmb_permisos";
            this.cmb_permisos.Size = new System.Drawing.Size(196, 21);
            this.cmb_permisos.TabIndex = 10;
            // 
            // lb_formulario
            // 
            this.lb_formulario.BackColor = System.Drawing.Color.Transparent;
            this.lb_formulario.Image = global::WASSTD.Properties.Resources.notepad_icon_16;
            this.lb_formulario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_formulario.Location = new System.Drawing.Point(9, 37);
            this.lb_formulario.Name = "lb_formulario";
            this.lb_formulario.Size = new System.Drawing.Size(93, 35);
            this.lb_formulario.TabIndex = 9;
            this.lb_formulario.Text = "Formulario:";
            this.lb_formulario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_permiso
            // 
            this.lb_permiso.BackColor = System.Drawing.Color.Transparent;
            this.lb_permiso.Image = global::WASSTD.Properties.Resources.eye_inv_icon_16;
            this.lb_permiso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_permiso.Location = new System.Drawing.Point(9, 75);
            this.lb_permiso.Name = "lb_permiso";
            this.lb_permiso.Size = new System.Drawing.Size(93, 35);
            this.lb_permiso.TabIndex = 8;
            this.lb_permiso.Text = "Permiso:";
            this.lb_permiso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_grupo
            // 
            this.lb_grupo.BackColor = System.Drawing.Color.Transparent;
            this.lb_grupo.Image = global::WASSTD.Properties.Resources.users_icon_16;
            this.lb_grupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_grupo.Location = new System.Drawing.Point(9, 4);
            this.lb_grupo.Name = "lb_grupo";
            this.lb_grupo.Size = new System.Drawing.Size(93, 35);
            this.lb_grupo.TabIndex = 7;
            this.lb_grupo.Text = "Grupo:";
            this.lb_grupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_grupos
            // 
            this.cmb_grupos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_grupos.FormattingEnabled = true;
            this.cmb_grupos.Location = new System.Drawing.Point(139, 12);
            this.cmb_grupos.Name = "cmb_grupos";
            this.cmb_grupos.Size = new System.Drawing.Size(196, 21);
            this.cmb_grupos.TabIndex = 6;
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Image = global::WASSTD.Properties.Resources.filter_icon_16;
            this.btn_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filtrar.Location = new System.Drawing.Point(385, 4);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(120, 35);
            this.btn_filtrar.TabIndex = 12;
            this.btn_filtrar.Text = "Filtrar Datos";
            this.btn_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click_1);
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToAddRows = false;
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_datos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(15, 124);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            this.dgv_datos.Size = new System.Drawing.Size(485, 250);
            this.dgv_datos.TabIndex = 13;
            // 
            // btn_nuevaconsulta
            // 
            this.btn_nuevaconsulta.Image = global::WASSTD.Properties.Resources.reload_icon_16;
            this.btn_nuevaconsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevaconsulta.Location = new System.Drawing.Point(385, 45);
            this.btn_nuevaconsulta.Name = "btn_nuevaconsulta";
            this.btn_nuevaconsulta.Size = new System.Drawing.Size(120, 35);
            this.btn_nuevaconsulta.TabIndex = 14;
            this.btn_nuevaconsulta.Text = "Nueva Consulta";
            this.btn_nuevaconsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nuevaconsulta.UseVisualStyleBackColor = true;
            this.btn_nuevaconsulta.Click += new System.EventHandler(this.btn_nuevaconsulta_Click);
            // 
            // botonera1
            // 
            this.botonera1.Location = new System.Drawing.Point(15, 395);
            this.botonera1.Name = "botonera1";
            this.botonera1.Size = new System.Drawing.Size(488, 44);
            this.botonera1.TabIndex = 0;
            this.botonera1.Click_Alta += new WASSTD.Eventos_Botonera(this.botonera1_Click_Alta);
            this.botonera1.Click_Baja += new WASSTD.Eventos_Botonera(this.botonera1_Click_Baja);
            this.botonera1.Click_Modificacion += new WASSTD.Eventos_Botonera(this.botonera1_Click_Modificacion);
            this.botonera1.Click_Consulta += new WASSTD.Eventos_Botonera(this.botonera1_Click_Consulta);
            this.botonera1.Click_Cerrar += new WASSTD.Eventos_Botonera(this.botonera1_Click_Cerrar);
            // 
            // perfilBindingSource
            // 
            this.perfilBindingSource.DataSource = typeof(Modelo_Entidades.Perfil);
            // 
            // FrmPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 462);
            this.Controls.Add(this.btn_nuevaconsulta);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.cmb_formularios);
            this.Controls.Add(this.cmb_permisos);
            this.Controls.Add(this.lb_formulario);
            this.Controls.Add(this.lb_permiso);
            this.Controls.Add(this.lb_grupo);
            this.Controls.Add(this.cmb_grupos);
            this.Controls.Add(this.botonera1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPerfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Perfiles";
            this.Activated += new System.EventHandler(this.FrmPerfiles_Activated);
            this.Load += new System.EventHandler(this.FrmPerfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Botonera1 botonera1;
        private System.Windows.Forms.ComboBox cmb_formularios;
        private System.Windows.Forms.ComboBox cmb_permisos;
        private System.Windows.Forms.Label lb_formulario;
        private System.Windows.Forms.Label lb_permiso;
        private System.Windows.Forms.Label lb_grupo;
        private System.Windows.Forms.ComboBox cmb_grupos;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.Button btn_nuevaconsulta;
        private System.Windows.Forms.BindingSource perfilBindingSource;
    }
}