namespace WASSTD
{
    partial class FrmSeleccionCuotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeleccionCuotas));
            this.chk_intereses = new System.Windows.Forms.CheckBox();
            this.lb_cuotas = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.chk_cuotas = new System.Windows.Forms.CheckedListBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chk_intereses
            // 
            this.chk_intereses.AutoSize = true;
            this.chk_intereses.BackColor = System.Drawing.Color.Transparent;
            this.chk_intereses.Location = new System.Drawing.Point(169, 16);
            this.chk_intereses.Name = "chk_intereses";
            this.chk_intereses.Size = new System.Drawing.Size(108, 17);
            this.chk_intereses.TabIndex = 1;
            this.chk_intereses.Text = "Agregar intereses";
            this.chk_intereses.UseVisualStyleBackColor = false;
            // 
            // lb_cuotas
            // 
            this.lb_cuotas.BackColor = System.Drawing.Color.Transparent;
            this.lb_cuotas.Image = global::WASSTD.Properties.Resources.cc_icon_16;
            this.lb_cuotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_cuotas.Location = new System.Drawing.Point(13, 6);
            this.lb_cuotas.Name = "lb_cuotas";
            this.lb_cuotas.Size = new System.Drawing.Size(67, 35);
            this.lb_cuotas.TabIndex = 2;
            this.lb_cuotas.Text = "Cuotas:";
            this.lb_cuotas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_total
            // 
            this.lb_total.BackColor = System.Drawing.Color.Transparent;
            this.lb_total.Image = global::WASSTD.Properties.Resources.money_icon_16;
            this.lb_total.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_total.Location = new System.Drawing.Point(166, 53);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(58, 35);
            this.lb_total.TabIndex = 3;
            this.lb_total.Text = "Total:";
            this.lb_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_total.Location = new System.Drawing.Point(169, 91);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 4;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Image = global::WASSTD.Properties.Resources.checkbox_checked_icon_16;
            this.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_aceptar.Location = new System.Drawing.Point(169, 175);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(100, 35);
            this.btn_aceptar.TabIndex = 5;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::WASSTD.Properties.Resources.cancel_icon_16;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(169, 216);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(100, 35);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // chk_cuotas
            // 
            this.chk_cuotas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.chk_cuotas.FormattingEnabled = true;
            this.chk_cuotas.Location = new System.Drawing.Point(16, 44);
            this.chk_cuotas.Name = "chk_cuotas";
            this.chk_cuotas.Size = new System.Drawing.Size(144, 214);
            this.chk_cuotas.TabIndex = 7;
            this.chk_cuotas.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chk_cuotas_ItemCheck);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Image = global::WASSTD.Properties.Resources.chart_bar_icon_16;
            this.btn_calcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_calcular.Location = new System.Drawing.Point(169, 118);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(100, 35);
            this.btn_calcular.TabIndex = 8;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // FrmSeleccionCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WASSTD.Properties.Resources.Fondo_Final;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.chk_cuotas);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.lb_cuotas);
            this.Controls.Add(this.chk_intereses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSeleccionCuotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección de Cuotas";
            this.Load += new System.EventHandler(this.FrmSeleccionCuotas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_intereses;
        private System.Windows.Forms.Label lb_cuotas;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.CheckedListBox chk_cuotas;
        private System.Windows.Forms.Button btn_calcular;
    }
}