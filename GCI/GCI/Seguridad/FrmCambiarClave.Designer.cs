namespace GCI
{
    partial class FrmCambiarClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCambiarClave));
            this.txt_contraseña_actual = new System.Windows.Forms.TextBox();
            this.lb_contraseña_actual = new System.Windows.Forms.Label();
            this.txt_repetircontraseña = new System.Windows.Forms.TextBox();
            this.txt_nuevacontraseña = new System.Windows.Forms.TextBox();
            this.lb_repetircontraseña = new System.Windows.Forms.Label();
            this.lb_nuevacontraseña = new System.Windows.Forms.Label();
            this.lb_resetaercontraseña = new System.Windows.Forms.Label();
            this.lbnombreusuario = new System.Windows.Forms.Label();
            this.lb_usuario_escrito = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_contraseña_actual
            // 
            this.txt_contraseña_actual.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_contraseña_actual.Location = new System.Drawing.Point(173, 152);
            this.txt_contraseña_actual.Name = "txt_contraseña_actual";
            this.txt_contraseña_actual.PasswordChar = '*';
            this.txt_contraseña_actual.Size = new System.Drawing.Size(319, 20);
            this.txt_contraseña_actual.TabIndex = 13;
            // 
            // lb_contraseña_actual
            // 
            this.lb_contraseña_actual.BackColor = System.Drawing.Color.Transparent;
            this.lb_contraseña_actual.Image = global::GCI.Properties.Resources.key_icon_16;
            this.lb_contraseña_actual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_contraseña_actual.Location = new System.Drawing.Point(37, 144);
            this.lb_contraseña_actual.Name = "lb_contraseña_actual";
            this.lb_contraseña_actual.Size = new System.Drawing.Size(130, 35);
            this.lb_contraseña_actual.TabIndex = 12;
            this.lb_contraseña_actual.Text = "Contraseña actual:";
            this.lb_contraseña_actual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_repetircontraseña
            // 
            this.txt_repetircontraseña.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_repetircontraseña.Location = new System.Drawing.Point(173, 119);
            this.txt_repetircontraseña.Name = "txt_repetircontraseña";
            this.txt_repetircontraseña.PasswordChar = '*';
            this.txt_repetircontraseña.Size = new System.Drawing.Size(319, 20);
            this.txt_repetircontraseña.TabIndex = 11;
            // 
            // txt_nuevacontraseña
            // 
            this.txt_nuevacontraseña.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nuevacontraseña.Location = new System.Drawing.Point(173, 84);
            this.txt_nuevacontraseña.Name = "txt_nuevacontraseña";
            this.txt_nuevacontraseña.PasswordChar = '*';
            this.txt_nuevacontraseña.Size = new System.Drawing.Size(319, 20);
            this.txt_nuevacontraseña.TabIndex = 10;
            // 
            // lb_repetircontraseña
            // 
            this.lb_repetircontraseña.BackColor = System.Drawing.Color.Transparent;
            this.lb_repetircontraseña.Image = global::GCI.Properties.Resources.key_icon_16;
            this.lb_repetircontraseña.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_repetircontraseña.Location = new System.Drawing.Point(34, 111);
            this.lb_repetircontraseña.Name = "lb_repetircontraseña";
            this.lb_repetircontraseña.Size = new System.Drawing.Size(133, 35);
            this.lb_repetircontraseña.TabIndex = 9;
            this.lb_repetircontraseña.Text = "Repetir Contraseña:";
            this.lb_repetircontraseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_nuevacontraseña
            // 
            this.lb_nuevacontraseña.BackColor = System.Drawing.Color.Transparent;
            this.lb_nuevacontraseña.Image = global::GCI.Properties.Resources.key_icon_16;
            this.lb_nuevacontraseña.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_nuevacontraseña.Location = new System.Drawing.Point(37, 76);
            this.lb_nuevacontraseña.Name = "lb_nuevacontraseña";
            this.lb_nuevacontraseña.Size = new System.Drawing.Size(130, 35);
            this.lb_nuevacontraseña.TabIndex = 8;
            this.lb_nuevacontraseña.Text = "Nueva Contraseña:";
            this.lb_nuevacontraseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_resetaercontraseña
            // 
            this.lb_resetaercontraseña.BackColor = System.Drawing.Color.Transparent;
            this.lb_resetaercontraseña.Image = global::GCI.Properties.Resources.key_icon_16;
            this.lb_resetaercontraseña.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_resetaercontraseña.Location = new System.Drawing.Point(360, 36);
            this.lb_resetaercontraseña.Name = "lb_resetaercontraseña";
            this.lb_resetaercontraseña.Size = new System.Drawing.Size(132, 35);
            this.lb_resetaercontraseña.TabIndex = 7;
            this.lb_resetaercontraseña.Text = "Resetear Contraseña:";
            this.lb_resetaercontraseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbnombreusuario
            // 
            this.lbnombreusuario.BackColor = System.Drawing.Color.Transparent;
            this.lbnombreusuario.Image = global::GCI.Properties.Resources.user_icon_16;
            this.lbnombreusuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbnombreusuario.Location = new System.Drawing.Point(34, 9);
            this.lbnombreusuario.Name = "lbnombreusuario";
            this.lbnombreusuario.Size = new System.Drawing.Size(119, 35);
            this.lbnombreusuario.TabIndex = 14;
            this.lbnombreusuario.Text = "Nombre de Usuario:";
            this.lbnombreusuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_usuario_escrito
            // 
            this.lb_usuario_escrito.BackColor = System.Drawing.Color.Transparent;
            this.lb_usuario_escrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuario_escrito.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lb_usuario_escrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_usuario_escrito.Location = new System.Drawing.Point(159, 9);
            this.lb_usuario_escrito.Name = "lb_usuario_escrito";
            this.lb_usuario_escrito.Size = new System.Drawing.Size(156, 35);
            this.lb_usuario_escrito.TabIndex = 15;
            this.lb_usuario_escrito.Text = "Nombre de Usuario:";
            this.lb_usuario_escrito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::GCI.Properties.Resources.save_icon_16;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(335, 185);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 35);
            this.btn_guardar.TabIndex = 17;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::GCI.Properties.Resources.cancel_icon_16;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(416, 185);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 35);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // FrmCambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 232);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lb_usuario_escrito);
            this.Controls.Add(this.lbnombreusuario);
            this.Controls.Add(this.txt_contraseña_actual);
            this.Controls.Add(this.lb_contraseña_actual);
            this.Controls.Add(this.txt_repetircontraseña);
            this.Controls.Add(this.txt_nuevacontraseña);
            this.Controls.Add(this.lb_repetircontraseña);
            this.Controls.Add(this.lb_nuevacontraseña);
            this.Controls.Add(this.lb_resetaercontraseña);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCambiarClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de clave";
            this.Load += new System.EventHandler(this.FrmCambiarClave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_contraseña_actual;
        private System.Windows.Forms.Label lb_contraseña_actual;
        private System.Windows.Forms.TextBox txt_repetircontraseña;
        private System.Windows.Forms.TextBox txt_nuevacontraseña;
        private System.Windows.Forms.Label lb_repetircontraseña;
        private System.Windows.Forms.Label lb_nuevacontraseña;
        private System.Windows.Forms.Label lb_resetaercontraseña;
        private System.Windows.Forms.Label lbnombreusuario;
        private System.Windows.Forms.Label lb_usuario_escrito;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}