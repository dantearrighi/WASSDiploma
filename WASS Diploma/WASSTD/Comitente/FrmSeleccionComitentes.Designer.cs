namespace WASSTD
{
    partial class FrmSeleccionComitentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeleccionComitentes));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.lb_comitente = new System.Windows.Forms.Label();
            this.txt_nya_comitente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::WASSTD.Properties.Resources.cancel_icon_16;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(422, 415);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 35);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Image = global::WASSTD.Properties.Resources.checkmark_icon_16;
            this.btn_seleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_seleccionar.Location = new System.Drawing.Point(324, 415);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(92, 35);
            this.btn_seleccionar.TabIndex = 8;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click_1);
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToAddRows = false;
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_datos.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(15, 49);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            this.dgv_datos.Size = new System.Drawing.Size(481, 354);
            this.dgv_datos.TabIndex = 7;
            // 
            // lb_comitente
            // 
            this.lb_comitente.BackColor = System.Drawing.Color.Transparent;
            this.lb_comitente.Image = global::WASSTD.Properties.Resources.contact_card_icon_16;
            this.lb_comitente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_comitente.Location = new System.Drawing.Point(12, 6);
            this.lb_comitente.Name = "lb_comitente";
            this.lb_comitente.Size = new System.Drawing.Size(96, 35);
            this.lb_comitente.TabIndex = 6;
            this.lb_comitente.Text = "Comitente:";
            this.lb_comitente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_nya_comitente
            // 
            this.txt_nya_comitente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nya_comitente.Location = new System.Drawing.Point(129, 14);
            this.txt_nya_comitente.Name = "txt_nya_comitente";
            this.txt_nya_comitente.Size = new System.Drawing.Size(367, 20);
            this.txt_nya_comitente.TabIndex = 5;
            this.txt_nya_comitente.TextChanged += new System.EventHandler(this.txt_nya_comitente_TextChanged_1);
            // 
            // FrmSeleccionComitentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WASSTD.Properties.Resources.Fondo_Final;
            this.ClientSize = new System.Drawing.Size(509, 462);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.lb_comitente);
            this.Controls.Add(this.txt_nya_comitente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSeleccionComitentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion de Comitentes";
            this.Load += new System.EventHandler(this.FrmSeleccionComitentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.Label lb_comitente;
        private System.Windows.Forms.TextBox txt_nya_comitente;
    }
}