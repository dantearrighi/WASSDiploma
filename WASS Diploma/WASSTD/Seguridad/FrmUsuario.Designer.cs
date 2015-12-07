namespace WASSTD
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.tab_usuario = new System.Windows.Forms.TabControl();
            this.tab_datos = new System.Windows.Forms.TabPage();
            this.lb_checkusuario = new System.Windows.Forms.Label();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.lb_estado = new System.Windows.Forms.Label();
            this.txt_nombreusuario = new System.Windows.Forms.TextBox();
            this.lbnombreusuario = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.txt_nombreapellido = new System.Windows.Forms.TextBox();
            this.lb_nombreapellido = new System.Windows.Forms.Label();
            this.tab_grupos = new System.Windows.Forms.TabPage();
            this.chklstbox_grupos = new System.Windows.Forms.CheckedListBox();
            this.tab_contraseña = new System.Windows.Forms.TabPage();
            this.txt_contraseña_actual = new System.Windows.Forms.TextBox();
            this.lb_contraseña_actual = new System.Windows.Forms.Label();
            this.txt_repetircontraseña = new System.Windows.Forms.TextBox();
            this.txt_nuevacontraseña = new System.Windows.Forms.TextBox();
            this.lb_repetircontraseña = new System.Windows.Forms.Label();
            this.lb_nuevacontraseña = new System.Windows.Forms.Label();
            this.lb_resetaercontraseña = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.tab_usuario.SuspendLayout();
            this.tab_datos.SuspendLayout();
            this.tab_grupos.SuspendLayout();
            this.tab_contraseña.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_usuario
            // 
            this.tab_usuario.Controls.Add(this.tab_datos);
            this.tab_usuario.Controls.Add(this.tab_grupos);
            this.tab_usuario.Controls.Add(this.tab_contraseña);
            this.tab_usuario.Location = new System.Drawing.Point(1, 8);
            this.tab_usuario.Name = "tab_usuario";
            this.tab_usuario.SelectedIndex = 0;
            this.tab_usuario.Size = new System.Drawing.Size(491, 181);
            this.tab_usuario.TabIndex = 0;
            // 
            // tab_datos
            // 
            this.tab_datos.BackColor = System.Drawing.SystemColors.Control;
            this.tab_datos.Controls.Add(this.lb_checkusuario);
            this.tab_datos.Controls.Add(this.chk_estado);
            this.tab_datos.Controls.Add(this.lb_estado);
            this.tab_datos.Controls.Add(this.txt_nombreusuario);
            this.tab_datos.Controls.Add(this.lbnombreusuario);
            this.tab_datos.Controls.Add(this.txt_email);
            this.tab_datos.Controls.Add(this.lb_email);
            this.tab_datos.Controls.Add(this.txt_nombreapellido);
            this.tab_datos.Controls.Add(this.lb_nombreapellido);
            this.tab_datos.Location = new System.Drawing.Point(4, 22);
            this.tab_datos.Name = "tab_datos";
            this.tab_datos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_datos.Size = new System.Drawing.Size(483, 155);
            this.tab_datos.TabIndex = 0;
            this.tab_datos.Text = "Datos";
            // 
            // lb_checkusuario
            // 
            this.lb_checkusuario.Image = global::WASSTD.Properties.Resources.checkbox_checked_icon_16;
            this.lb_checkusuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_checkusuario.Location = new System.Drawing.Point(338, 117);
            this.lb_checkusuario.Name = "lb_checkusuario";
            this.lb_checkusuario.Size = new System.Drawing.Size(137, 35);
            this.lb_checkusuario.TabIndex = 8;
            this.lb_checkusuario.Text = "Usuario";
            this.lb_checkusuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Location = new System.Drawing.Point(144, 134);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(56, 17);
            this.chk_estado.TabIndex = 7;
            this.chk_estado.Text = "Activo";
            this.chk_estado.UseVisualStyleBackColor = true;
            // 
            // lb_estado
            // 
            this.lb_estado.Image = global::WASSTD.Properties.Resources.chart_bar_icon_16;
            this.lb_estado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_estado.Location = new System.Drawing.Point(16, 124);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(119, 35);
            this.lb_estado.TabIndex = 6;
            this.lb_estado.Text = "Estado:";
            this.lb_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_nombreusuario
            // 
            this.txt_nombreusuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nombreusuario.Location = new System.Drawing.Point(144, 94);
            this.txt_nombreusuario.Name = "txt_nombreusuario";
            this.txt_nombreusuario.Size = new System.Drawing.Size(331, 20);
            this.txt_nombreusuario.TabIndex = 5;
            // 
            // lbnombreusuario
            // 
            this.lbnombreusuario.Image = global::WASSTD.Properties.Resources.user_icon_16;
            this.lbnombreusuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbnombreusuario.Location = new System.Drawing.Point(16, 86);
            this.lbnombreusuario.Name = "lbnombreusuario";
            this.lbnombreusuario.Size = new System.Drawing.Size(119, 35);
            this.lbnombreusuario.TabIndex = 4;
            this.lbnombreusuario.Text = "Nombre de Usuario:";
            this.lbnombreusuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_email.Location = new System.Drawing.Point(144, 59);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(331, 20);
            this.txt_email.TabIndex = 3;
            // 
            // lb_email
            // 
            this.lb_email.Image = global::WASSTD.Properties.Resources.mail_2_icon_16;
            this.lb_email.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_email.Location = new System.Drawing.Point(16, 51);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(119, 35);
            this.lb_email.TabIndex = 2;
            this.lb_email.Text = "E-Mail:";
            this.lb_email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_nombreapellido
            // 
            this.txt_nombreapellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nombreapellido.Location = new System.Drawing.Point(144, 24);
            this.txt_nombreapellido.Name = "txt_nombreapellido";
            this.txt_nombreapellido.Size = new System.Drawing.Size(331, 20);
            this.txt_nombreapellido.TabIndex = 1;
            // 
            // lb_nombreapellido
            // 
            this.lb_nombreapellido.Image = global::WASSTD.Properties.Resources.user_icon_16;
            this.lb_nombreapellido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_nombreapellido.Location = new System.Drawing.Point(16, 16);
            this.lb_nombreapellido.Name = "lb_nombreapellido";
            this.lb_nombreapellido.Size = new System.Drawing.Size(122, 35);
            this.lb_nombreapellido.TabIndex = 0;
            this.lb_nombreapellido.Text = "Nombre y Apellido:";
            this.lb_nombreapellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tab_grupos
            // 
            this.tab_grupos.Controls.Add(this.chklstbox_grupos);
            this.tab_grupos.Location = new System.Drawing.Point(4, 22);
            this.tab_grupos.Name = "tab_grupos";
            this.tab_grupos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_grupos.Size = new System.Drawing.Size(483, 155);
            this.tab_grupos.TabIndex = 1;
            this.tab_grupos.Text = "Grupos";
            this.tab_grupos.UseVisualStyleBackColor = true;
            // 
            // chklstbox_grupos
            // 
            this.chklstbox_grupos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.chklstbox_grupos.FormattingEnabled = true;
            this.chklstbox_grupos.Location = new System.Drawing.Point(7, 7);
            this.chklstbox_grupos.Name = "chklstbox_grupos";
            this.chklstbox_grupos.Size = new System.Drawing.Size(470, 139);
            this.chklstbox_grupos.TabIndex = 0;
            this.chklstbox_grupos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklstbox_grupos_ItemCheck);
            // 
            // tab_contraseña
            // 
            this.tab_contraseña.BackColor = System.Drawing.SystemColors.Control;
            this.tab_contraseña.Controls.Add(this.txt_contraseña_actual);
            this.tab_contraseña.Controls.Add(this.lb_contraseña_actual);
            this.tab_contraseña.Controls.Add(this.txt_repetircontraseña);
            this.tab_contraseña.Controls.Add(this.txt_nuevacontraseña);
            this.tab_contraseña.Controls.Add(this.lb_repetircontraseña);
            this.tab_contraseña.Controls.Add(this.lb_nuevacontraseña);
            this.tab_contraseña.Controls.Add(this.lb_resetaercontraseña);
            this.tab_contraseña.Location = new System.Drawing.Point(4, 22);
            this.tab_contraseña.Name = "tab_contraseña";
            this.tab_contraseña.Size = new System.Drawing.Size(483, 155);
            this.tab_contraseña.TabIndex = 2;
            this.tab_contraseña.Text = "Contraseña";
            // 
            // txt_contraseña_actual
            // 
            this.txt_contraseña_actual.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_contraseña_actual.Location = new System.Drawing.Point(151, 116);
            this.txt_contraseña_actual.Name = "txt_contraseña_actual";
            this.txt_contraseña_actual.PasswordChar = '*';
            this.txt_contraseña_actual.Size = new System.Drawing.Size(319, 20);
            this.txt_contraseña_actual.TabIndex = 6;
            // 
            // lb_contraseña_actual
            // 
            this.lb_contraseña_actual.Image = global::WASSTD.Properties.Resources.key_icon_16;
            this.lb_contraseña_actual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_contraseña_actual.Location = new System.Drawing.Point(15, 108);
            this.lb_contraseña_actual.Name = "lb_contraseña_actual";
            this.lb_contraseña_actual.Size = new System.Drawing.Size(130, 35);
            this.lb_contraseña_actual.TabIndex = 5;
            this.lb_contraseña_actual.Text = "Contraseña actual:";
            this.lb_contraseña_actual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_repetircontraseña
            // 
            this.txt_repetircontraseña.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_repetircontraseña.Location = new System.Drawing.Point(151, 83);
            this.txt_repetircontraseña.Name = "txt_repetircontraseña";
            this.txt_repetircontraseña.PasswordChar = '*';
            this.txt_repetircontraseña.Size = new System.Drawing.Size(319, 20);
            this.txt_repetircontraseña.TabIndex = 4;
            // 
            // txt_nuevacontraseña
            // 
            this.txt_nuevacontraseña.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nuevacontraseña.Location = new System.Drawing.Point(151, 48);
            this.txt_nuevacontraseña.Name = "txt_nuevacontraseña";
            this.txt_nuevacontraseña.PasswordChar = '*';
            this.txt_nuevacontraseña.Size = new System.Drawing.Size(319, 20);
            this.txt_nuevacontraseña.TabIndex = 3;
            // 
            // lb_repetircontraseña
            // 
            this.lb_repetircontraseña.Image = global::WASSTD.Properties.Resources.key_icon_16;
            this.lb_repetircontraseña.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_repetircontraseña.Location = new System.Drawing.Point(12, 75);
            this.lb_repetircontraseña.Name = "lb_repetircontraseña";
            this.lb_repetircontraseña.Size = new System.Drawing.Size(133, 35);
            this.lb_repetircontraseña.TabIndex = 2;
            this.lb_repetircontraseña.Text = "Repetir Contraseña:";
            this.lb_repetircontraseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_nuevacontraseña
            // 
            this.lb_nuevacontraseña.Image = global::WASSTD.Properties.Resources.key_icon_16;
            this.lb_nuevacontraseña.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_nuevacontraseña.Location = new System.Drawing.Point(15, 40);
            this.lb_nuevacontraseña.Name = "lb_nuevacontraseña";
            this.lb_nuevacontraseña.Size = new System.Drawing.Size(130, 35);
            this.lb_nuevacontraseña.TabIndex = 1;
            this.lb_nuevacontraseña.Text = "Nueva Contraseña:";
            this.lb_nuevacontraseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_resetaercontraseña
            // 
            this.lb_resetaercontraseña.Image = global::WASSTD.Properties.Resources.key_icon_16;
            this.lb_resetaercontraseña.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_resetaercontraseña.Location = new System.Drawing.Point(338, 3);
            this.lb_resetaercontraseña.Name = "lb_resetaercontraseña";
            this.lb_resetaercontraseña.Size = new System.Drawing.Size(132, 35);
            this.lb_resetaercontraseña.TabIndex = 0;
            this.lb_resetaercontraseña.Text = "Resetear Contraseña:";
            this.lb_resetaercontraseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::WASSTD.Properties.Resources.cancel_icon_16;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(417, 195);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 35);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::WASSTD.Properties.Resources.save_icon_16;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(336, 195);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 35);
            this.btn_guardar.TabIndex = 2;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 232);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.tab_usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.tab_usuario.ResumeLayout(false);
            this.tab_datos.ResumeLayout(false);
            this.tab_datos.PerformLayout();
            this.tab_grupos.ResumeLayout(false);
            this.tab_contraseña.ResumeLayout(false);
            this.tab_contraseña.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_usuario;
        private System.Windows.Forms.TabPage tab_datos;
        private System.Windows.Forms.Label lb_nombreapellido;
        private System.Windows.Forms.TabPage tab_grupos;
        private System.Windows.Forms.TabPage tab_contraseña;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox txt_nombreapellido;
        private System.Windows.Forms.TextBox txt_nombreusuario;
        private System.Windows.Forms.Label lbnombreusuario;
        private System.Windows.Forms.CheckBox chk_estado;
        private System.Windows.Forms.Label lb_estado;
        private System.Windows.Forms.TextBox txt_repetircontraseña;
        private System.Windows.Forms.TextBox txt_nuevacontraseña;
        private System.Windows.Forms.Label lb_repetircontraseña;
        private System.Windows.Forms.Label lb_nuevacontraseña;
        private System.Windows.Forms.Label lb_resetaercontraseña;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lb_checkusuario;
        private System.Windows.Forms.CheckedListBox chklstbox_grupos;
        private System.Windows.Forms.TextBox txt_contraseña_actual;
        private System.Windows.Forms.Label lb_contraseña_actual;
    }
}