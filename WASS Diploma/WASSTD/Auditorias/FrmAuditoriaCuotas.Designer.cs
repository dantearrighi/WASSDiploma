namespace WASSTD
{
    partial class FrmAuditoriaCuotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuditoriaCuotas));
            this.btn_nuevaconsulta = new System.Windows.Forms.Button();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lb_cuota = new System.Windows.Forms.Label();
            this.lb_nombreapellido = new System.Windows.Forms.Label();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.lb_pofesional_dni = new System.Windows.Forms.Label();
            this.txt_cuota = new System.Windows.Forms.TextBox();
            this.txt_dni_profesional = new System.Windows.Forms.MaskedTextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_nuevaconsulta
            // 
            this.btn_nuevaconsulta.Image = global::WASSTD.Properties.Resources.reload_icon_16;
            this.btn_nuevaconsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevaconsulta.Location = new System.Drawing.Point(380, 94);
            this.btn_nuevaconsulta.Name = "btn_nuevaconsulta";
            this.btn_nuevaconsulta.Size = new System.Drawing.Size(120, 35);
            this.btn_nuevaconsulta.TabIndex = 60;
            this.btn_nuevaconsulta.Text = "Nueva Consulta";
            this.btn_nuevaconsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nuevaconsulta.UseVisualStyleBackColor = true;
            this.btn_nuevaconsulta.Click += new System.EventHandler(this.btn_nuevaconsulta_Click);
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Image = global::WASSTD.Properties.Resources.filter_icon_16;
            this.btn_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filtrar.Location = new System.Drawing.Point(310, 94);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(64, 35);
            this.btn_filtrar.TabIndex = 59;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_usuario.Location = new System.Drawing.Point(190, 16);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(310, 20);
            this.txt_usuario.TabIndex = 53;
            // 
            // lb_cuota
            // 
            this.lb_cuota.BackColor = System.Drawing.Color.Transparent;
            this.lb_cuota.Image = global::WASSTD.Properties.Resources.wrench_plus_2_icon_16;
            this.lb_cuota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_cuota.Location = new System.Drawing.Point(8, 60);
            this.lb_cuota.Name = "lb_cuota";
            this.lb_cuota.Size = new System.Drawing.Size(146, 35);
            this.lb_cuota.TabIndex = 52;
            this.lb_cuota.Text = "Descripcion de la cuota:";
            this.lb_cuota.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_nombreapellido
            // 
            this.lb_nombreapellido.BackColor = System.Drawing.Color.Transparent;
            this.lb_nombreapellido.Image = global::WASSTD.Properties.Resources.user_icon_16;
            this.lb_nombreapellido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_nombreapellido.Location = new System.Drawing.Point(8, 8);
            this.lb_nombreapellido.Name = "lb_nombreapellido";
            this.lb_nombreapellido.Size = new System.Drawing.Size(176, 35);
            this.lb_nombreapellido.TabIndex = 51;
            this.lb_nombreapellido.Text = "Nombre y Apellido del Usuario:";
            this.lb_nombreapellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToAddRows = false;
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_datos.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(12, 145);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            this.dgv_datos.Size = new System.Drawing.Size(488, 305);
            this.dgv_datos.TabIndex = 50;
            // 
            // lb_pofesional_dni
            // 
            this.lb_pofesional_dni.BackColor = System.Drawing.Color.Transparent;
            this.lb_pofesional_dni.Image = global::WASSTD.Properties.Resources.user_icon_16;
            this.lb_pofesional_dni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_pofesional_dni.Location = new System.Drawing.Point(8, 34);
            this.lb_pofesional_dni.Name = "lb_pofesional_dni";
            this.lb_pofesional_dni.Size = new System.Drawing.Size(126, 35);
            this.lb_pofesional_dni.TabIndex = 61;
            this.lb_pofesional_dni.Text = "DNI del Profesional:";
            this.lb_pofesional_dni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_cuota
            // 
            this.txt_cuota.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_cuota.Location = new System.Drawing.Point(190, 68);
            this.txt_cuota.Name = "txt_cuota";
            this.txt_cuota.Size = new System.Drawing.Size(310, 20);
            this.txt_cuota.TabIndex = 63;
            // 
            // txt_dni_profesional
            // 
            this.txt_dni_profesional.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_dni_profesional.Location = new System.Drawing.Point(190, 43);
            this.txt_dni_profesional.Mask = "99999999";
            this.txt_dni_profesional.Name = "txt_dni_profesional";
            this.txt_dni_profesional.Size = new System.Drawing.Size(310, 20);
            this.txt_dni_profesional.TabIndex = 64;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::WASSTD.Properties.Resources.cancel_icon_16;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(229, 94);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 35);
            this.btn_cancelar.TabIndex = 65;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // FrmAuditoriaCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WASSTD.Properties.Resources.Fondo_Final;
            this.ClientSize = new System.Drawing.Size(509, 462);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_dni_profesional);
            this.Controls.Add(this.txt_cuota);
            this.Controls.Add(this.lb_pofesional_dni);
            this.Controls.Add(this.btn_nuevaconsulta);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lb_cuota);
            this.Controls.Add(this.lb_nombreapellido);
            this.Controls.Add(this.dgv_datos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAuditoriaCuotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Auditorias de las cuotas";
            this.Load += new System.EventHandler(this.FrmAuditoriaCuotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nuevaconsulta;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lb_cuota;
        private System.Windows.Forms.Label lb_nombreapellido;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.Label lb_pofesional_dni;
        private System.Windows.Forms.TextBox txt_cuota;
        private System.Windows.Forms.MaskedTextBox txt_dni_profesional;
        private System.Windows.Forms.Button btn_cancelar;
    }
}