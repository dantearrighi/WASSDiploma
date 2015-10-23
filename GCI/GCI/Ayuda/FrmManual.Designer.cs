namespace GCI
{
    partial class FrmManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManual));
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.btn_link = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nombre.Location = new System.Drawing.Point(194, 17);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(310, 20);
            this.txt_nombre.TabIndex = 55;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // lb_nombre
            // 
            this.lb_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lb_nombre.Image = global::GCI.Properties.Resources.youtube_icon_16;
            this.lb_nombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_nombre.Location = new System.Drawing.Point(12, 9);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(104, 35);
            this.lb_nombre.TabIndex = 54;
            this.lb_nombre.Text = "Nombre del video:";
            this.lb_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToAddRows = false;
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_datos.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(15, 61);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            this.dgv_datos.Size = new System.Drawing.Size(489, 348);
            this.dgv_datos.TabIndex = 56;
            // 
            // btn_link
            // 
            this.btn_link.Image = global::GCI.Properties.Resources.reload_icon_16;
            this.btn_link.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_link.Location = new System.Drawing.Point(420, 415);
            this.btn_link.Name = "btn_link";
            this.btn_link.Size = new System.Drawing.Size(84, 35);
            this.btn_link.TabIndex = 61;
            this.btn_link.Text = "Ver video";
            this.btn_link.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_link.UseVisualStyleBackColor = true;
            this.btn_link.Click += new System.EventHandler(this.btn_link_Click);
            // 
            // FrmManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.ClientSize = new System.Drawing.Size(509, 462);
            this.Controls.Add(this.btn_link);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lb_nombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual de usuario";
            this.Load += new System.EventHandler(this.FrmManual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.Button btn_link;
    }
}