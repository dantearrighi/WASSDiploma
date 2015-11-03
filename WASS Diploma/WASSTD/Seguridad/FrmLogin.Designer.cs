namespace WASSTD
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lb_nombredeusuario = new System.Windows.Forms.Label();
            this.lb_contraseña = new System.Windows.Forms.Label();
            this.txt_nombredeusuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_resetear = new System.Windows.Forms.Button();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_nombredeusuario
            // 
            this.lb_nombredeusuario.BackColor = System.Drawing.Color.Transparent;
            this.lb_nombredeusuario.Image = global::WASSTD.Properties.Resources.user_icon_16;
            this.lb_nombredeusuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_nombredeusuario.Location = new System.Drawing.Point(12, 9);
            this.lb_nombredeusuario.Name = "lb_nombredeusuario";
            this.lb_nombredeusuario.Size = new System.Drawing.Size(126, 35);
            this.lb_nombredeusuario.TabIndex = 0;
            this.lb_nombredeusuario.Text = "Nombre de Usuario:";
            this.lb_nombredeusuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_contraseña
            // 
            this.lb_contraseña.BackColor = System.Drawing.Color.Transparent;
            this.lb_contraseña.Image = global::WASSTD.Properties.Resources.key_icon_16;
            this.lb_contraseña.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_contraseña.Location = new System.Drawing.Point(12, 48);
            this.lb_contraseña.Name = "lb_contraseña";
            this.lb_contraseña.Size = new System.Drawing.Size(92, 35);
            this.lb_contraseña.TabIndex = 1;
            this.lb_contraseña.Text = "Contraseña:";
            this.lb_contraseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_nombredeusuario
            // 
            this.txt_nombredeusuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nombredeusuario.Location = new System.Drawing.Point(144, 17);
            this.txt_nombredeusuario.Name = "txt_nombredeusuario";
            this.txt_nombredeusuario.Size = new System.Drawing.Size(176, 20);
            this.txt_nombredeusuario.TabIndex = 2;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_contraseña.Location = new System.Drawing.Point(144, 56);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '*';
            this.txt_contraseña.Size = new System.Drawing.Size(179, 20);
            this.txt_contraseña.TabIndex = 3;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::WASSTD.Properties.Resources.cancel_icon_16;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(248, 99);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 35);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_resetear
            // 
            this.btn_resetear.Image = global::WASSTD.Properties.Resources.key_icon_16;
            this.btn_resetear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_resetear.Location = new System.Drawing.Point(100, 99);
            this.btn_resetear.Name = "btn_resetear";
            this.btn_resetear.Size = new System.Drawing.Size(142, 35);
            this.btn_resetear.TabIndex = 8;
            this.btn_resetear.Text = "Resetear Contraseña";
            this.btn_resetear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_resetear.UseVisualStyleBackColor = true;
            this.btn_resetear.Click += new System.EventHandler(this.btn_resetear_Click);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Image = global::WASSTD.Properties.Resources.arrow_bottom_icon_16;
            this.btn_ingresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ingresar.Location = new System.Drawing.Point(15, 99);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(75, 35);
            this.btn_ingresar.TabIndex = 6;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(329, 147);
            this.Controls.Add(this.btn_resetear);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_nombredeusuario);
            this.Controls.Add(this.lb_contraseña);
            this.Controls.Add(this.lb_nombredeusuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nombredeusuario;
        private System.Windows.Forms.Label lb_contraseña;
        private System.Windows.Forms.TextBox txt_nombredeusuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_resetear;
    }
}