namespace GCI
{
    partial class FrmProfesionales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfesionales));
            this.lb_nya_profesional = new System.Windows.Forms.Label();
            this.lb_dni = new System.Windows.Forms.Label();
            this.lb_num_matricula = new System.Windows.Forms.Label();
            this.txt_nya_profesional = new System.Windows.Forms.TextBox();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.txt_dni = new System.Windows.Forms.MaskedTextBox();
            this.txt_num_matricula = new System.Windows.Forms.MaskedTextBox();
            this.botonera1 = new GCI.Botonera1();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_nya_profesional
            // 
            this.lb_nya_profesional.BackColor = System.Drawing.Color.Transparent;
            this.lb_nya_profesional.Image = global::GCI.Properties.Resources.user_icon_16;
            this.lb_nya_profesional.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_nya_profesional.Location = new System.Drawing.Point(13, -2);
            this.lb_nya_profesional.Name = "lb_nya_profesional";
            this.lb_nya_profesional.Size = new System.Drawing.Size(220, 35);
            this.lb_nya_profesional.TabIndex = 0;
            this.lb_nya_profesional.Text = "Nombre y Apellido del Profesional:";
            this.lb_nya_profesional.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_dni
            // 
            this.lb_dni.BackColor = System.Drawing.Color.Transparent;
            this.lb_dni.Image = global::GCI.Properties.Resources.contact_card_icon_16;
            this.lb_dni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_dni.Location = new System.Drawing.Point(13, 24);
            this.lb_dni.Name = "lb_dni";
            this.lb_dni.Size = new System.Drawing.Size(220, 35);
            this.lb_dni.TabIndex = 1;
            this.lb_dni.Text = "Nº de documento del Profesional:";
            this.lb_dni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_num_matricula
            // 
            this.lb_num_matricula.BackColor = System.Drawing.Color.Transparent;
            this.lb_num_matricula.Image = global::GCI.Properties.Resources.page_layout_icon_16;
            this.lb_num_matricula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_num_matricula.Location = new System.Drawing.Point(13, 50);
            this.lb_num_matricula.Name = "lb_num_matricula";
            this.lb_num_matricula.Size = new System.Drawing.Size(220, 35);
            this.lb_num_matricula.TabIndex = 2;
            this.lb_num_matricula.Text = "Número de matrícula del Profesional:";
            this.lb_num_matricula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_nya_profesional
            // 
            this.txt_nya_profesional.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nya_profesional.Location = new System.Drawing.Point(239, 6);
            this.txt_nya_profesional.Name = "txt_nya_profesional";
            this.txt_nya_profesional.Size = new System.Drawing.Size(262, 20);
            this.txt_nya_profesional.TabIndex = 3;
            this.txt_nya_profesional.TextChanged += new System.EventHandler(this.txt_nya_profesional_TextChanged);
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToAddRows = false;
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_datos.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(16, 93);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            this.dgv_datos.Size = new System.Drawing.Size(485, 320);
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
            // txt_num_matricula
            // 
            this.txt_num_matricula.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_num_matricula.Location = new System.Drawing.Point(239, 58);
            this.txt_num_matricula.Name = "txt_num_matricula";
            this.txt_num_matricula.Size = new System.Drawing.Size(262, 20);
            this.txt_num_matricula.TabIndex = 10;
            this.txt_num_matricula.TextChanged += new System.EventHandler(this.txt_num_matricula_TextChanged);
            // 
            // botonera1
            // 
            this.botonera1.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.botonera1.Location = new System.Drawing.Point(16, 419);
            this.botonera1.Name = "botonera1";
            this.botonera1.Size = new System.Drawing.Size(486, 42);
            this.botonera1.TabIndex = 8;
            this.botonera1.Click_Alta += new GCI.Eventos_Botonera(this.botonera1_Click_Alta);
            this.botonera1.Click_Modificacion += new GCI.Eventos_Botonera(this.botonera1_Click_Modificacion);
            this.botonera1.Click_Consulta += new GCI.Eventos_Botonera(this.botonera1_Click_Consulta);
            this.botonera1.Click_Cerrar += new GCI.Eventos_Botonera(this.botonera1_Click_Cerrar);
            // 
            // FrmProfesionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.ClientSize = new System.Drawing.Size(509, 462);
            this.Controls.Add(this.txt_num_matricula);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.botonera1);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.txt_nya_profesional);
            this.Controls.Add(this.lb_num_matricula);
            this.Controls.Add(this.lb_dni);
            this.Controls.Add(this.lb_nya_profesional);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProfesionales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Profesionales";
            this.Load += new System.EventHandler(this.FrmProfesionales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nya_profesional;
        private System.Windows.Forms.Label lb_dni;
        private System.Windows.Forms.Label lb_num_matricula;
        private System.Windows.Forms.TextBox txt_nya_profesional;
        private System.Windows.Forms.DataGridView dgv_datos;
        private Botonera1 botonera1;
        private System.Windows.Forms.MaskedTextBox txt_dni;
        private System.Windows.Forms.MaskedTextBox txt_num_matricula;
    }
}