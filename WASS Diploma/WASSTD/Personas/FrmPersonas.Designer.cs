namespace WASSTD.Personas
{
    partial class FrmPersonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonas));
            this.lb_dni = new System.Windows.Forms.Label();
            this.lb_nya_profesional = new System.Windows.Forms.Label();
            this.botonera1 = new WASSTD.Botonera1();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.txt_dni = new System.Windows.Forms.MaskedTextBox();
            this.txt_nya_persona = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_dni
            // 
            this.lb_dni.BackColor = System.Drawing.Color.Transparent;
            this.lb_dni.Image = global::WASSTD.Properties.Resources.contact_card_icon_16;
            this.lb_dni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_dni.Location = new System.Drawing.Point(12, 35);
            this.lb_dni.Name = "lb_dni";
            this.lb_dni.Size = new System.Drawing.Size(156, 35);
            this.lb_dni.TabIndex = 4;
            this.lb_dni.Text = "Nº de documento / CUIL:";
            this.lb_dni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_nya_profesional
            // 
            this.lb_nya_profesional.BackColor = System.Drawing.Color.Transparent;
            this.lb_nya_profesional.Image = global::WASSTD.Properties.Resources.user_icon_16;
            this.lb_nya_profesional.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_nya_profesional.Location = new System.Drawing.Point(12, 9);
            this.lb_nya_profesional.Name = "lb_nya_profesional";
            this.lb_nya_profesional.Size = new System.Drawing.Size(156, 35);
            this.lb_nya_profesional.TabIndex = 3;
            this.lb_nya_profesional.Text = "Nombre y Apellido:";
            this.lb_nya_profesional.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // botonera1
            // 
            this.botonera1.Location = new System.Drawing.Point(12, 408);
            this.botonera1.Name = "botonera1";
            this.botonera1.Size = new System.Drawing.Size(486, 42);
            this.botonera1.TabIndex = 9;
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToAddRows = false;
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_datos.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(12, 82);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            this.dgv_datos.Size = new System.Drawing.Size(485, 320);
            this.dgv_datos.TabIndex = 10;
            // 
            // txt_dni
            // 
            this.txt_dni.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_dni.Location = new System.Drawing.Point(174, 43);
            this.txt_dni.Mask = "99999999";
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(203, 20);
            this.txt_dni.TabIndex = 12;
            // 
            // txt_nya_persona
            // 
            this.txt_nya_persona.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nya_persona.Location = new System.Drawing.Point(174, 17);
            this.txt_nya_persona.Name = "txt_nya_persona";
            this.txt_nya_persona.Size = new System.Drawing.Size(203, 20);
            this.txt_nya_persona.TabIndex = 11;
            // 
            // FrmPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 462);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.txt_nya_persona);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.botonera1);
            this.Controls.Add(this.lb_dni);
            this.Controls.Add(this.lb_nya_profesional);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Personas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_dni;
        private System.Windows.Forms.Label lb_nya_profesional;
        private Botonera1 botonera1;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.MaskedTextBox txt_dni;
        private System.Windows.Forms.TextBox txt_nya_persona;
    }
}