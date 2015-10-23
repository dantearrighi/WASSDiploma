namespace GCI
{
    partial class FrmRecibos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecibos));
            this.chk_matriculado = new System.Windows.Forms.CheckBox();
            this.lb_profesional = new System.Windows.Forms.Label();
            this.btn_cobrar_cuotas = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.lb_total = new System.Windows.Forms.Label();
            this.txt_profesional = new System.Windows.Forms.TextBox();
            this.gb_conceptos = new System.Windows.Forms.GroupBox();
            this.btn_cobrar_expediente = new System.Windows.Forms.Button();
            this.dgv_factura = new System.Windows.Forms.DataGridView();
            this.gb_conceptos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_factura)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_matriculado
            // 
            this.chk_matriculado.AutoSize = true;
            this.chk_matriculado.BackColor = System.Drawing.Color.Transparent;
            this.chk_matriculado.Location = new System.Drawing.Point(12, 100);
            this.chk_matriculado.Name = "chk_matriculado";
            this.chk_matriculado.Size = new System.Drawing.Size(81, 17);
            this.chk_matriculado.TabIndex = 0;
            this.chk_matriculado.Text = "Matriculado";
            this.chk_matriculado.UseVisualStyleBackColor = false;
            this.chk_matriculado.CheckedChanged += new System.EventHandler(this.chk_matriculado_CheckedChanged);
            // 
            // lb_profesional
            // 
            this.lb_profesional.BackColor = System.Drawing.Color.Transparent;
            this.lb_profesional.Image = global::GCI.Properties.Resources.user_icon_16;
            this.lb_profesional.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_profesional.Location = new System.Drawing.Point(100, 90);
            this.lb_profesional.Name = "lb_profesional";
            this.lb_profesional.Size = new System.Drawing.Size(94, 35);
            this.lb_profesional.TabIndex = 1;
            this.lb_profesional.Text = "Profesional:";
            this.lb_profesional.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_cobrar_cuotas
            // 
            this.btn_cobrar_cuotas.Image = global::GCI.Properties.Resources.wallet_icon_16;
            this.btn_cobrar_cuotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cobrar_cuotas.Location = new System.Drawing.Point(4, 19);
            this.btn_cobrar_cuotas.Name = "btn_cobrar_cuotas";
            this.btn_cobrar_cuotas.Size = new System.Drawing.Size(107, 35);
            this.btn_cobrar_cuotas.TabIndex = 2;
            this.btn_cobrar_cuotas.Text = "Cobrar cuotas";
            this.btn_cobrar_cuotas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cobrar_cuotas.UseVisualStyleBackColor = true;
            this.btn_cobrar_cuotas.Click += new System.EventHandler(this.btn_cobrar_cuotas_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Image = global::GCI.Properties.Resources.print_icon_16;
            this.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_imprimir.Location = new System.Drawing.Point(93, 475);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(115, 35);
            this.btn_imprimir.TabIndex = 6;
            this.btn_imprimir.Text = "Cobrar e imprimir";
            this.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::GCI.Properties.Resources.cancel_icon_16;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(12, 475);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 35);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_total.Location = new System.Drawing.Point(430, 491);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(119, 20);
            this.txt_total.TabIndex = 3;
            // 
            // lb_total
            // 
            this.lb_total.BackColor = System.Drawing.Color.Transparent;
            this.lb_total.Image = global::GCI.Properties.Resources.money_icon_16;
            this.lb_total.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_total.Location = new System.Drawing.Point(363, 482);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(61, 35);
            this.lb_total.TabIndex = 2;
            this.lb_total.Text = "Total:";
            this.lb_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_profesional
            // 
            this.txt_profesional.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_profesional.Location = new System.Drawing.Point(200, 98);
            this.txt_profesional.Name = "txt_profesional";
            this.txt_profesional.Size = new System.Drawing.Size(347, 20);
            this.txt_profesional.TabIndex = 4;
            // 
            // gb_conceptos
            // 
            this.gb_conceptos.BackColor = System.Drawing.Color.Transparent;
            this.gb_conceptos.Controls.Add(this.btn_cobrar_expediente);
            this.gb_conceptos.Controls.Add(this.btn_cobrar_cuotas);
            this.gb_conceptos.Location = new System.Drawing.Point(13, 16);
            this.gb_conceptos.Name = "gb_conceptos";
            this.gb_conceptos.Size = new System.Drawing.Size(534, 71);
            this.gb_conceptos.TabIndex = 5;
            this.gb_conceptos.TabStop = false;
            this.gb_conceptos.Text = "Conceptos";
            // 
            // btn_cobrar_expediente
            // 
            this.btn_cobrar_expediente.Image = global::GCI.Properties.Resources.wallet_icon_16;
            this.btn_cobrar_expediente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cobrar_expediente.Location = new System.Drawing.Point(117, 19);
            this.btn_cobrar_expediente.Name = "btn_cobrar_expediente";
            this.btn_cobrar_expediente.Size = new System.Drawing.Size(126, 35);
            this.btn_cobrar_expediente.TabIndex = 3;
            this.btn_cobrar_expediente.Text = "Cobrar expediente";
            this.btn_cobrar_expediente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cobrar_expediente.UseVisualStyleBackColor = true;
            this.btn_cobrar_expediente.Click += new System.EventHandler(this.btn_cobrar_expediente_Click);
            // 
            // dgv_factura
            // 
            this.dgv_factura.AllowUserToAddRows = false;
            this.dgv_factura.AllowUserToDeleteRows = false;
            this.dgv_factura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_factura.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgv_factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_factura.Location = new System.Drawing.Point(13, 128);
            this.dgv_factura.Name = "dgv_factura";
            this.dgv_factura.ReadOnly = true;
            this.dgv_factura.Size = new System.Drawing.Size(534, 341);
            this.dgv_factura.TabIndex = 6;
            // 
            // FrmRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.ClientSize = new System.Drawing.Size(569, 522);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.dgv_factura);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.gb_conceptos);
            this.Controls.Add(this.txt_profesional);
            this.Controls.Add(this.lb_profesional);
            this.Controls.Add(this.chk_matriculado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRecibos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Recibos";
            this.Load += new System.EventHandler(this.FrmRecibos_Load);
            this.gb_conceptos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_factura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_matriculado;
        private System.Windows.Forms.Label lb_profesional;
        private System.Windows.Forms.Button btn_cobrar_cuotas;
        private System.Windows.Forms.TextBox txt_profesional;
        private System.Windows.Forms.GroupBox gb_conceptos;
        private System.Windows.Forms.Button btn_cobrar_expediente;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DataGridView dgv_factura;
    }
}