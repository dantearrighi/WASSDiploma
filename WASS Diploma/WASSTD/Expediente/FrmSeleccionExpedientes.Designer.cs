namespace WASSTD
{
    partial class FrmSeleccionExpedientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeleccionExpedientes));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.lb_expediente = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.MaskedTextBox();
            this.btn_filtrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::WASSTD.Properties.Resources.cancel_icon_16;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(318, 420);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 35);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Image = global::WASSTD.Properties.Resources.round_checkmark_icon_16;
            this.btn_seleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_seleccionar.Location = new System.Drawing.Point(399, 420);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(96, 35);
            this.btn_seleccionar.TabIndex = 8;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToAddRows = false;
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_datos.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(14, 50);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            this.dgv_datos.Size = new System.Drawing.Size(481, 358);
            this.dgv_datos.TabIndex = 7;
            // 
            // lb_expediente
            // 
            this.lb_expediente.BackColor = System.Drawing.Color.Transparent;
            this.lb_expediente.Image = global::WASSTD.Properties.Resources.contact_card_icon_16;
            this.lb_expediente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_expediente.Location = new System.Drawing.Point(14, 7);
            this.lb_expediente.Name = "lb_expediente";
            this.lb_expediente.Size = new System.Drawing.Size(144, 35);
            this.lb_expediente.TabIndex = 6;
            this.lb_expediente.Text = "Numero del expediente:";
            this.lb_expediente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_numero
            // 
            this.txt_numero.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_numero.Location = new System.Drawing.Point(179, 15);
            this.txt_numero.Mask = "99999";
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(120, 20);
            this.txt_numero.TabIndex = 10;
            this.txt_numero.ValidatingType = typeof(int);
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Image = global::WASSTD.Properties.Resources.filter_icon_16;
            this.btn_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filtrar.Location = new System.Drawing.Point(318, 7);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(75, 35);
            this.btn_filtrar.TabIndex = 11;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // FrmSeleccionExpedientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WASSTD.Properties.Resources.Fondo_Final;
            this.ClientSize = new System.Drawing.Size(509, 462);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.lb_expediente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSeleccionExpedientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSeleccionExpedientes";
            this.Load += new System.EventHandler(this.FrmSeleccionExpedientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.Label lb_expediente;
        private System.Windows.Forms.MaskedTextBox txt_numero;
        private System.Windows.Forms.Button btn_filtrar;
    }
}