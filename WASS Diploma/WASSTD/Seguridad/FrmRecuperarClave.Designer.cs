namespace WASSTD
{
    partial class FrmRecuperarClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecuperarClave));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_nombredeusuario = new System.Windows.Forms.TextBox();
            this.lb_nombredeusuario = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::WASSTD.Properties.Resources.cancel_icon_16;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(224, 72);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 35);
            this.btn_cancelar.TabIndex = 14;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Image = global::WASSTD.Properties.Resources.checkmark_icon_16;
            this.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_aceptar.Location = new System.Drawing.Point(143, 72);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 35);
            this.btn_aceptar.TabIndex = 13;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_nombredeusuario
            // 
            this.txt_nombredeusuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nombredeusuario.Location = new System.Drawing.Point(143, 14);
            this.txt_nombredeusuario.Name = "txt_nombredeusuario";
            this.txt_nombredeusuario.Size = new System.Drawing.Size(156, 20);
            this.txt_nombredeusuario.TabIndex = 11;
            // 
            // lb_nombredeusuario
            // 
            this.lb_nombredeusuario.BackColor = System.Drawing.Color.Transparent;
            this.lb_nombredeusuario.Image = global::WASSTD.Properties.Resources.user_icon_16;
            this.lb_nombredeusuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_nombredeusuario.Location = new System.Drawing.Point(12, 6);
            this.lb_nombredeusuario.Name = "lb_nombredeusuario";
            this.lb_nombredeusuario.Size = new System.Drawing.Size(125, 35);
            this.lb_nombredeusuario.TabIndex = 9;
            this.lb_nombredeusuario.Text = "Nombre de Usuario:";
            this.lb_nombredeusuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_email.Location = new System.Drawing.Point(143, 45);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(156, 20);
            this.txt_email.TabIndex = 12;
            // 
            // lb_email
            // 
            this.lb_email.BackColor = System.Drawing.Color.Transparent;
            this.lb_email.Image = global::WASSTD.Properties.Resources.mail_2_icon_16;
            this.lb_email.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_email.Location = new System.Drawing.Point(12, 37);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(125, 35);
            this.lb_email.TabIndex = 10;
            this.lb_email.Text = "E-Mail:";
            this.lb_email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmRecuperarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 119);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_nombredeusuario);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_nombredeusuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRecuperarClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRecuperarClave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txt_nombredeusuario;
        private System.Windows.Forms.Label lb_nombredeusuario;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lb_email;
    }
}