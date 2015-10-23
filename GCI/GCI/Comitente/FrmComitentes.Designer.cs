namespace GCI
{
    partial class FrmComitentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComitentes));
            this.lb_nombre = new System.Windows.Forms.Label();
            this.txt_comitente = new System.Windows.Forms.TextBox();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.botonera1 = new GCI.Botonera1();
            this.btn_nuevaconsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_nombre
            // 
            this.lb_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lb_nombre.Image = global::GCI.Properties.Resources.user_icon_16;
            this.lb_nombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_nombre.Location = new System.Drawing.Point(10, 7);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(144, 35);
            this.lb_nombre.TabIndex = 9;
            this.lb_nombre.Text = "Nombre del comitente:";
            this.lb_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_comitente
            // 
            this.txt_comitente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_comitente.Location = new System.Drawing.Point(160, 15);
            this.txt_comitente.Name = "txt_comitente";
            this.txt_comitente.Size = new System.Drawing.Size(203, 20);
            this.txt_comitente.TabIndex = 8;
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Image = global::GCI.Properties.Resources.filter_icon_16;
            this.btn_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filtrar.Location = new System.Drawing.Point(378, 7);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(119, 35);
            this.btn_filtrar.TabIndex = 7;
            this.btn_filtrar.Text = "Filtrar Datos";
            this.btn_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToAddRows = false;
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_datos.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgv_datos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(10, 97);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            this.dgv_datos.Size = new System.Drawing.Size(488, 302);
            this.dgv_datos.TabIndex = 6;
            // 
            // botonera1
            // 
            this.botonera1.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.botonera1.Location = new System.Drawing.Point(10, 418);
            this.botonera1.Name = "botonera1";
            this.botonera1.Size = new System.Drawing.Size(488, 38);
            this.botonera1.TabIndex = 5;
            this.botonera1.Click_Alta += new GCI.Eventos_Botonera(this.botonera1_Click_Alta);
            this.botonera1.Click_Baja += new GCI.Eventos_Botonera(this.botonera1_Click_Baja);
            this.botonera1.Click_Modificacion += new GCI.Eventos_Botonera(this.botonera1_Click_Modificacion);
            this.botonera1.Click_Consulta += new GCI.Eventos_Botonera(this.botonera1_Click_Consulta);
            this.botonera1.Click_Cerrar += new GCI.Eventos_Botonera(this.botonera1_Click_Cerrar);
            // 
            // btn_nuevaconsulta
            // 
            this.btn_nuevaconsulta.Image = global::GCI.Properties.Resources.reload_icon_16;
            this.btn_nuevaconsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevaconsulta.Location = new System.Drawing.Point(378, 48);
            this.btn_nuevaconsulta.Name = "btn_nuevaconsulta";
            this.btn_nuevaconsulta.Size = new System.Drawing.Size(120, 35);
            this.btn_nuevaconsulta.TabIndex = 51;
            this.btn_nuevaconsulta.Text = "Nueva Consulta";
            this.btn_nuevaconsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nuevaconsulta.UseVisualStyleBackColor = true;
            this.btn_nuevaconsulta.Click += new System.EventHandler(this.btn_nuevaconsulta_Click);
            // 
            // FrmComitentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.ClientSize = new System.Drawing.Size(509, 462);
            this.Controls.Add(this.btn_nuevaconsulta);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.txt_comitente);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.botonera1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmComitentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Comitentes";
            this.Load += new System.EventHandler(this.FrmComitentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.TextBox txt_comitente;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.DataGridView dgv_datos;
        private Botonera1 botonera1;
        private System.Windows.Forms.Button btn_nuevaconsulta;
    }
}