namespace GCI
{
    partial class FrmGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrupo));
            this.tabs_grupos = new System.Windows.Forms.TabControl();
            this.tab_datos = new System.Windows.Forms.TabPage();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lb_descripcion = new System.Windows.Forms.Label();
            this.tab_permiso = new System.Windows.Forms.TabPage();
            this.chklstbox_permisos = new System.Windows.Forms.CheckedListBox();
            this.cmb_formularios = new System.Windows.Forms.ComboBox();
            this.lb_permisos = new System.Windows.Forms.Label();
            this.lb_formulario = new System.Windows.Forms.Label();
            this.tab_usuarios = new System.Windows.Forms.TabPage();
            this.lb_usuariosgrupo = new System.Windows.Forms.Label();
            this.chklstbox_usuarios = new System.Windows.Forms.CheckedListBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.tabs_grupos.SuspendLayout();
            this.tab_datos.SuspendLayout();
            this.tab_permiso.SuspendLayout();
            this.tab_usuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs_grupos
            // 
            this.tabs_grupos.Controls.Add(this.tab_datos);
            this.tabs_grupos.Controls.Add(this.tab_permiso);
            this.tabs_grupos.Controls.Add(this.tab_usuarios);
            this.tabs_grupos.Location = new System.Drawing.Point(16, 11);
            this.tabs_grupos.Name = "tabs_grupos";
            this.tabs_grupos.SelectedIndex = 0;
            this.tabs_grupos.Size = new System.Drawing.Size(535, 185);
            this.tabs_grupos.TabIndex = 3;
            // 
            // tab_datos
            // 
            this.tab_datos.BackColor = System.Drawing.SystemColors.Control;
            this.tab_datos.Controls.Add(this.txt_descripcion);
            this.tab_datos.Controls.Add(this.lb_descripcion);
            this.tab_datos.Location = new System.Drawing.Point(4, 22);
            this.tab_datos.Name = "tab_datos";
            this.tab_datos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_datos.Size = new System.Drawing.Size(527, 159);
            this.tab_datos.TabIndex = 0;
            this.tab_datos.Text = "Datos";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_descripcion.Location = new System.Drawing.Point(160, 24);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(350, 20);
            this.txt_descripcion.TabIndex = 1;
            // 
            // lb_descripcion
            // 
            this.lb_descripcion.Image = global::GCI.Properties.Resources.users_icon_16;
            this.lb_descripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_descripcion.Location = new System.Drawing.Point(16, 16);
            this.lb_descripcion.Name = "lb_descripcion";
            this.lb_descripcion.Size = new System.Drawing.Size(138, 35);
            this.lb_descripcion.TabIndex = 0;
            this.lb_descripcion.Text = "Descripción del Grupo:";
            this.lb_descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tab_permiso
            // 
            this.tab_permiso.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.tab_permiso.Controls.Add(this.chklstbox_permisos);
            this.tab_permiso.Controls.Add(this.cmb_formularios);
            this.tab_permiso.Controls.Add(this.lb_permisos);
            this.tab_permiso.Controls.Add(this.lb_formulario);
            this.tab_permiso.Location = new System.Drawing.Point(4, 22);
            this.tab_permiso.Name = "tab_permiso";
            this.tab_permiso.Size = new System.Drawing.Size(527, 159);
            this.tab_permiso.TabIndex = 2;
            this.tab_permiso.Text = "Permisos";
            this.tab_permiso.UseVisualStyleBackColor = true;
            // 
            // chklstbox_permisos
            // 
            this.chklstbox_permisos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.chklstbox_permisos.FormattingEnabled = true;
            this.chklstbox_permisos.Location = new System.Drawing.Point(128, 44);
            this.chklstbox_permisos.Name = "chklstbox_permisos";
            this.chklstbox_permisos.Size = new System.Drawing.Size(242, 94);
            this.chklstbox_permisos.TabIndex = 4;
            // 
            // cmb_formularios
            // 
            this.cmb_formularios.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_formularios.FormattingEnabled = true;
            this.cmb_formularios.Location = new System.Drawing.Point(128, 20);
            this.cmb_formularios.Name = "cmb_formularios";
            this.cmb_formularios.Size = new System.Drawing.Size(242, 21);
            this.cmb_formularios.TabIndex = 3;
            this.cmb_formularios.SelectedIndexChanged += new System.EventHandler(this.cmb_formularios_ItemCheck);
            // 
            // lb_permisos
            // 
            this.lb_permisos.Image = global::GCI.Properties.Resources.checkbox_checked_icon_16;
            this.lb_permisos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_permisos.Location = new System.Drawing.Point(14, 58);
            this.lb_permisos.Name = "lb_permisos";
            this.lb_permisos.Size = new System.Drawing.Size(95, 35);
            this.lb_permisos.TabIndex = 2;
            this.lb_permisos.Text = "Permisos:";
            this.lb_permisos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_formulario
            // 
            this.lb_formulario.Image = global::GCI.Properties.Resources.notepad_icon_16;
            this.lb_formulario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_formulario.Location = new System.Drawing.Point(14, 12);
            this.lb_formulario.Name = "lb_formulario";
            this.lb_formulario.Size = new System.Drawing.Size(95, 35);
            this.lb_formulario.TabIndex = 1;
            this.lb_formulario.Text = "Formulario:";
            this.lb_formulario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tab_usuarios
            // 
            this.tab_usuarios.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.tab_usuarios.Controls.Add(this.lb_usuariosgrupo);
            this.tab_usuarios.Controls.Add(this.chklstbox_usuarios);
            this.tab_usuarios.Location = new System.Drawing.Point(4, 22);
            this.tab_usuarios.Name = "tab_usuarios";
            this.tab_usuarios.Size = new System.Drawing.Size(527, 159);
            this.tab_usuarios.TabIndex = 3;
            this.tab_usuarios.Text = "Usuarios";
            this.tab_usuarios.UseVisualStyleBackColor = true;
            // 
            // lb_usuariosgrupo
            // 
            this.lb_usuariosgrupo.Image = global::GCI.Properties.Resources.users_icon_16;
            this.lb_usuariosgrupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_usuariosgrupo.Location = new System.Drawing.Point(13, 7);
            this.lb_usuariosgrupo.Name = "lb_usuariosgrupo";
            this.lb_usuariosgrupo.Size = new System.Drawing.Size(130, 35);
            this.lb_usuariosgrupo.TabIndex = 1;
            this.lb_usuariosgrupo.Text = "Usuarios del Grupo:";
            this.lb_usuariosgrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chklstbox_usuarios
            // 
            this.chklstbox_usuarios.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.chklstbox_usuarios.FormattingEnabled = true;
            this.chklstbox_usuarios.Location = new System.Drawing.Point(16, 45);
            this.chklstbox_usuarios.Name = "chklstbox_usuarios";
            this.chklstbox_usuarios.Size = new System.Drawing.Size(247, 94);
            this.chklstbox_usuarios.TabIndex = 0;
            this.chklstbox_usuarios.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklstbox_usuarios_ItemCheck);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::GCI.Properties.Resources.save_icon_16;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(388, 214);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(78, 31);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::GCI.Properties.Resources.cancel_icon_16;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(472, 214);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(79, 31);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // FrmGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 247);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.tabs_grupos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo";
            this.Load += new System.EventHandler(this.FrmGrupo_Load);
            this.tabs_grupos.ResumeLayout(false);
            this.tab_datos.ResumeLayout(false);
            this.tab_datos.PerformLayout();
            this.tab_permiso.ResumeLayout(false);
            this.tab_usuarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TabControl tabs_grupos;
        private System.Windows.Forms.TabPage tab_datos;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lb_descripcion;
        private System.Windows.Forms.TabPage tab_permiso;
        private System.Windows.Forms.Label lb_permisos;
        private System.Windows.Forms.Label lb_formulario;
        private System.Windows.Forms.CheckedListBox chklstbox_permisos;
        private System.Windows.Forms.ComboBox cmb_formularios;
        private System.Windows.Forms.TabPage tab_usuarios;
        private System.Windows.Forms.Label lb_usuariosgrupo;
        private System.Windows.Forms.CheckedListBox chklstbox_usuarios;
    }
}