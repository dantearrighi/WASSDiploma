namespace GCI
{
    partial class FrmGrupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrupos));
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.txt_grupo = new System.Windows.Forms.TextBox();
            this.lb_nombregrupo = new System.Windows.Forms.Label();
            this.botonera1 = new GCI.Botonera1();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToAddRows = false;
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_datos.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_datos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(12, 40);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            this.dgv_datos.Size = new System.Drawing.Size(488, 353);
            this.dgv_datos.TabIndex = 1;
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Image = global::GCI.Properties.Resources.filter_icon_16;
            this.btn_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filtrar.Location = new System.Drawing.Point(404, 1);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(95, 35);
            this.btn_filtrar.TabIndex = 2;
            this.btn_filtrar.Text = "Filtrar Datos";
            this.btn_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // txt_grupo
            // 
            this.txt_grupo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_grupo.Location = new System.Drawing.Point(145, 9);
            this.txt_grupo.Name = "txt_grupo";
            this.txt_grupo.Size = new System.Drawing.Size(242, 20);
            this.txt_grupo.TabIndex = 3;
            // 
            // lb_nombregrupo
            // 
            this.lb_nombregrupo.BackColor = System.Drawing.Color.Transparent;
            this.lb_nombregrupo.Image = global::GCI.Properties.Resources.users_icon_16;
            this.lb_nombregrupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_nombregrupo.Location = new System.Drawing.Point(12, 1);
            this.lb_nombregrupo.Name = "lb_nombregrupo";
            this.lb_nombregrupo.Size = new System.Drawing.Size(127, 35);
            this.lb_nombregrupo.TabIndex = 4;
            this.lb_nombregrupo.Text = "Nombre del Grupo:";
            this.lb_nombregrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // botonera1
            // 
            this.botonera1.Location = new System.Drawing.Point(12, 412);
            this.botonera1.Name = "botonera1";
            this.botonera1.Size = new System.Drawing.Size(488, 38);
            this.botonera1.TabIndex = 0;
            this.botonera1.Click_Alta += new GCI.Eventos_Botonera(this.botonera1_Click_Alta);
            this.botonera1.Click_Baja += new GCI.Eventos_Botonera(this.botonera1_Click_Baja);
            this.botonera1.Click_Modificacion += new GCI.Eventos_Botonera(this.botonera1_Click_Modificacion);
            this.botonera1.Click_Consulta += new GCI.Eventos_Botonera(this.botonera1_Click_Consulta);
            this.botonera1.Click_Cerrar += new GCI.Eventos_Botonera(this.botonera1_Click_Cerrar);
            // 
            // FrmGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 462);
            this.Controls.Add(this.lb_nombregrupo);
            this.Controls.Add(this.txt_grupo);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.botonera1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGrupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Grupos";
            this.Load += new System.EventHandler(this.FrmGrupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Botonera1 botonera1;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.TextBox txt_grupo;
        private System.Windows.Forms.Label lb_nombregrupo;
    }
}