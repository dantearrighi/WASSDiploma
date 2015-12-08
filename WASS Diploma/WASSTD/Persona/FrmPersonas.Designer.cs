namespace WASSTD
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
            this.txt_nya_Persona = new System.Windows.Forms.TextBox();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.txt_dni = new System.Windows.Forms.MaskedTextBox();
            this.lb_dni = new System.Windows.Forms.Label();
            this.lb_nya_Persona = new System.Windows.Forms.Label();
            this.botonera1 = new WASSTD.Botonera1();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nya_Persona
            // 
            this.txt_nya_Persona.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nya_Persona.Location = new System.Drawing.Point(239, 6);
            this.txt_nya_Persona.Name = "txt_nya_Persona";
            this.txt_nya_Persona.Size = new System.Drawing.Size(262, 20);
            this.txt_nya_Persona.TabIndex = 3;
            this.txt_nya_Persona.TextChanged += new System.EventHandler(this.txt_nya_Persona_TextChanged);
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToAddRows = false;
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_datos.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(16, 93);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            this.dgv_datos.Size = new System.Drawing.Size(841, 320);
            this.dgv_datos.TabIndex = 7;
            // 
            // txt_dni
            // 
            this.txt_dni.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_dni.Location = new System.Drawing.Point(239, 32);
            this.txt_dni.Mask = "99999999";
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(263, 20);
            this.txt_dni.TabIndex = 9;
            this.txt_dni.TextChanged += new System.EventHandler(this.txt_dni_TextChanged);
            // 
            // lb_dni
            // 
            this.lb_dni.BackColor = System.Drawing.Color.Transparent;
            this.lb_dni.Image = global::WASSTD.Properties.Resources.contact_card_icon_16;
            this.lb_dni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_dni.Location = new System.Drawing.Point(13, 24);
            this.lb_dni.Name = "lb_dni";
            this.lb_dni.Size = new System.Drawing.Size(220, 35);
            this.lb_dni.TabIndex = 1;
            this.lb_dni.Text = "Nº de documento del Persona:";
            this.lb_dni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_nya_Persona
            // 
            this.lb_nya_Persona.BackColor = System.Drawing.Color.Transparent;
            this.lb_nya_Persona.Image = global::WASSTD.Properties.Resources.user_icon_16;
            this.lb_nya_Persona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_nya_Persona.Location = new System.Drawing.Point(13, -2);
            this.lb_nya_Persona.Name = "lb_nya_Persona";
            this.lb_nya_Persona.Size = new System.Drawing.Size(220, 35);
            this.lb_nya_Persona.TabIndex = 0;
            this.lb_nya_Persona.Text = "Nombre y Apellido del Persona:";
            this.lb_nya_Persona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // botonera1
            // 
            this.botonera1.Location = new System.Drawing.Point(16, 419);
            this.botonera1.Name = "botonera1";
            this.botonera1.Size = new System.Drawing.Size(486, 42);
            this.botonera1.TabIndex = 8;
            this.botonera1.Click_Alta += new WASSTD.Eventos_Botonera(this.botonera1_Click_Alta);
            this.botonera1.Click_Modificacion += new WASSTD.Eventos_Botonera(this.botonera1_Click_Modificacion);
            this.botonera1.Click_Consulta += new WASSTD.Eventos_Botonera(this.botonera1_Click_Consulta);
            this.botonera1.Click_Cerrar += new WASSTD.Eventos_Botonera(this.botonera1_Click_Cerrar);
            // 
            // FrmPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 462);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.botonera1);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.txt_nya_Persona);
            this.Controls.Add(this.lb_dni);
            this.Controls.Add(this.lb_nya_Persona);
            this.Name = "FrmPersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Personas";
            this.Load += new System.EventHandler(this.FrmPersonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txt_nya_Persona_TextChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lb_nya_Persona;
        private System.Windows.Forms.Label lb_dni;
        private System.Windows.Forms.TextBox txt_nya_Persona;
        private System.Windows.Forms.DataGridView dgv_datos;
        private Botonera1 botonera1;
        private System.Windows.Forms.MaskedTextBox txt_dni;
    }
}