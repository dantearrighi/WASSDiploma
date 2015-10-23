namespace WASSTD
{
    partial class FrmPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfil));
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.tab_datos = new System.Windows.Forms.TabPage();
            this.cmb_formularios = new System.Windows.Forms.ComboBox();
            this.cmb_permisos = new System.Windows.Forms.ComboBox();
            this.lb_formulario = new System.Windows.Forms.Label();
            this.lb_permiso = new System.Windows.Forms.Label();
            this.lb_grupo = new System.Windows.Forms.Label();
            this.cmb_grupos = new System.Windows.Forms.ComboBox();
            this.tab_perfiles = new System.Windows.Forms.TabControl();
            this.tab_datos.SuspendLayout();
            this.tab_perfiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::WASSTD.Properties.Resources.save_icon_16;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(399, 207);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 35);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::WASSTD.Properties.Resources.cancel_icon_16;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(480, 207);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 35);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // tab_datos
            // 
            this.tab_datos.BackColor = System.Drawing.SystemColors.Control;
            this.tab_datos.Controls.Add(this.cmb_formularios);
            this.tab_datos.Controls.Add(this.cmb_permisos);
            this.tab_datos.Controls.Add(this.lb_formulario);
            this.tab_datos.Controls.Add(this.lb_permiso);
            this.tab_datos.Controls.Add(this.lb_grupo);
            this.tab_datos.Controls.Add(this.cmb_grupos);
            this.tab_datos.Location = new System.Drawing.Point(4, 22);
            this.tab_datos.Name = "tab_datos";
            this.tab_datos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_datos.Size = new System.Drawing.Size(534, 152);
            this.tab_datos.TabIndex = 0;
            this.tab_datos.Text = "Datos";
            // 
            // cmb_formularios
            // 
            this.cmb_formularios.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_formularios.FormattingEnabled = true;
            this.cmb_formularios.Location = new System.Drawing.Point(134, 60);
            this.cmb_formularios.Name = "cmb_formularios";
            this.cmb_formularios.Size = new System.Drawing.Size(196, 21);
            this.cmb_formularios.TabIndex = 5;
            // 
            // cmb_permisos
            // 
            this.cmb_permisos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_permisos.FormattingEnabled = true;
            this.cmb_permisos.Location = new System.Drawing.Point(134, 98);
            this.cmb_permisos.Name = "cmb_permisos";
            this.cmb_permisos.Size = new System.Drawing.Size(196, 21);
            this.cmb_permisos.TabIndex = 4;
            // 
            // lb_formulario
            // 
            this.lb_formulario.Image = global::WASSTD.Properties.Resources.notepad_icon_16;
            this.lb_formulario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_formulario.Location = new System.Drawing.Point(7, 49);
            this.lb_formulario.Name = "lb_formulario";
            this.lb_formulario.Size = new System.Drawing.Size(87, 35);
            this.lb_formulario.TabIndex = 3;
            this.lb_formulario.Text = "Formulario:";
            this.lb_formulario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_permiso
            // 
            this.lb_permiso.Image = global::WASSTD.Properties.Resources.eye_inv_icon_16;
            this.lb_permiso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_permiso.Location = new System.Drawing.Point(7, 90);
            this.lb_permiso.Name = "lb_permiso";
            this.lb_permiso.Size = new System.Drawing.Size(87, 35);
            this.lb_permiso.TabIndex = 2;
            this.lb_permiso.Text = "Permiso:";
            this.lb_permiso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_grupo
            // 
            this.lb_grupo.Image = global::WASSTD.Properties.Resources.users_icon_16;
            this.lb_grupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_grupo.Location = new System.Drawing.Point(7, 13);
            this.lb_grupo.Name = "lb_grupo";
            this.lb_grupo.Size = new System.Drawing.Size(87, 35);
            this.lb_grupo.TabIndex = 1;
            this.lb_grupo.Text = "Grupo:";
            this.lb_grupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_grupos
            // 
            this.cmb_grupos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_grupos.FormattingEnabled = true;
            this.cmb_grupos.Location = new System.Drawing.Point(134, 21);
            this.cmb_grupos.Name = "cmb_grupos";
            this.cmb_grupos.Size = new System.Drawing.Size(196, 21);
            this.cmb_grupos.TabIndex = 0;
            // 
            // tab_perfiles
            // 
            this.tab_perfiles.Controls.Add(this.tab_datos);
            this.tab_perfiles.Location = new System.Drawing.Point(13, 13);
            this.tab_perfiles.Name = "tab_perfiles";
            this.tab_perfiles.SelectedIndex = 0;
            this.tab_perfiles.Size = new System.Drawing.Size(542, 178);
            this.tab_perfiles.TabIndex = 0;
            // 
            // FrmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 247);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.tab_perfiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.FrmPerfil_Load);
            this.tab_datos.ResumeLayout(false);
            this.tab_perfiles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TabPage tab_datos;
        private System.Windows.Forms.TabControl tab_perfiles;
        private System.Windows.Forms.Label lb_formulario;
        private System.Windows.Forms.Label lb_permiso;
        private System.Windows.Forms.Label lb_grupo;
        private System.Windows.Forms.ComboBox cmb_grupos;
        private System.Windows.Forms.ComboBox cmb_formularios;
        private System.Windows.Forms.ComboBox cmb_permisos;
    }
}