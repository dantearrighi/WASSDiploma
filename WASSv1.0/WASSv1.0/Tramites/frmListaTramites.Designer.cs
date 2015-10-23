namespace WASSv1._0.Tramites
{
    partial class frmListaTramites
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaTramites));
            this.dgvListaTramites = new System.Windows.Forms.DataGridView();
            this.btnImportar = new System.Windows.Forms.Button();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.rbDni = new System.Windows.Forms.RadioButton();
            this.rbApellido = new System.Windows.Forms.RadioButton();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnImportarDETALLESTramites = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevoTramite = new System.Windows.Forms.Button();
            this.lblCantTramites = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTramites)).BeginInit();
            this.gbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaTramites
            // 
            this.dgvListaTramites.AllowUserToAddRows = false;
            this.dgvListaTramites.AllowUserToDeleteRows = false;
            this.dgvListaTramites.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaTramites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaTramites.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaTramites.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaTramites.Location = new System.Drawing.Point(12, 76);
            this.dgvListaTramites.MultiSelect = false;
            this.dgvListaTramites.Name = "dgvListaTramites";
            this.dgvListaTramites.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvListaTramites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaTramites.ShowEditingIcon = false;
            this.dgvListaTramites.Size = new System.Drawing.Size(1308, 369);
            this.dgvListaTramites.TabIndex = 0;
            this.dgvListaTramites.TabStop = false;
            this.dgvListaTramites.DoubleClick += new System.EventHandler(this.dgvListaTramites_DoubleClick);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(945, 26);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(120, 39);
            this.btnImportar.TabIndex = 6;
            this.btnImportar.Text = "2. Importar Trámites";
            this.btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Visible = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.radioButton1);
            this.gbFiltro.Controls.Add(this.rbDni);
            this.gbFiltro.Controls.Add(this.rbApellido);
            this.gbFiltro.Controls.Add(this.txtFiltro);
            this.gbFiltro.Location = new System.Drawing.Point(12, 12);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(404, 58);
            this.gbFiltro.TabIndex = 0;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Buscar";
            // 
            // rbDni
            // 
            this.rbDni.AutoSize = true;
            this.rbDni.Location = new System.Drawing.Point(278, 25);
            this.rbDni.Name = "rbDni";
            this.rbDni.Size = new System.Drawing.Size(71, 17);
            this.rbDni.TabIndex = 2;
            this.rbDni.Text = "DNI-CUIL";
            this.rbDni.UseVisualStyleBackColor = true;
            // 
            // rbApellido
            // 
            this.rbApellido.AutoSize = true;
            this.rbApellido.Checked = true;
            this.rbApellido.Location = new System.Drawing.Point(195, 25);
            this.rbApellido.Name = "rbApellido";
            this.rbApellido.Size = new System.Drawing.Size(77, 17);
            this.rbApellido.TabIndex = 1;
            this.rbApellido.TabStop = true;
            this.rbApellido.Text = "APELLIDO";
            this.rbApellido.UseVisualStyleBackColor = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(6, 24);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(183, 20);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnImportarDETALLESTramites
            // 
            this.btnImportarDETALLESTramites.Location = new System.Drawing.Point(1071, 26);
            this.btnImportarDETALLESTramites.Name = "btnImportarDETALLESTramites";
            this.btnImportarDETALLESTramites.Size = new System.Drawing.Size(120, 39);
            this.btnImportarDETALLESTramites.TabIndex = 7;
            this.btnImportarDETALLESTramites.Text = "3. Importar Detalles Tramites";
            this.btnImportarDETALLESTramites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportarDETALLESTramites.UseVisualStyleBackColor = true;
            this.btnImportarDETALLESTramites.Visible = false;
            this.btnImportarDETALLESTramites.Click += new System.EventHandler(this.btnImportarDETALLESTramites_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Image = global::WASSv1._0.Properties.Resources.forward32;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.Location = new System.Drawing.Point(819, 26);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(120, 39);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "1. Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Visible = false;
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::WASSv1._0.Properties.Resources.Excel;
            this.btnExcel.Location = new System.Drawing.Point(693, 26);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(120, 39);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Image = global::WASSv1._0.Properties.Resources.close_24;
            this.btnCerrar.Location = new System.Drawing.Point(1195, 26);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 39);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::WASSv1._0.Properties.Resources.document_32;
            this.btnModificar.Location = new System.Drawing.Point(567, 26);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 39);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Ver / Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevoTramite
            // 
            this.btnNuevoTramite.Image = global::WASSv1._0.Properties.Resources.document_add_32;
            this.btnNuevoTramite.Location = new System.Drawing.Point(441, 26);
            this.btnNuevoTramite.Name = "btnNuevoTramite";
            this.btnNuevoTramite.Size = new System.Drawing.Size(120, 39);
            this.btnNuevoTramite.TabIndex = 1;
            this.btnNuevoTramite.Text = "Nuevo Trámite";
            this.btnNuevoTramite.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevoTramite.UseVisualStyleBackColor = true;
            this.btnNuevoTramite.Click += new System.EventHandler(this.btnNuevoTramite_Click);
            // 
            // lblCantTramites
            // 
            this.lblCantTramites.AutoSize = true;
            this.lblCantTramites.Location = new System.Drawing.Point(1211, 450);
            this.lblCantTramites.Name = "lblCantTramites";
            this.lblCantTramites.Size = new System.Drawing.Size(35, 13);
            this.lblCantTramites.TabIndex = 10;
            this.lblCantTramites.Text = "label1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(355, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(36, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "ID";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // frmListaTramites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 472);
            this.Controls.Add(this.lblCantTramites);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnImportarDETALLESTramites);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevoTramite);
            this.Controls.Add(this.dgvListaTramites);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaTramites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Trámites";
            this.Load += new System.EventHandler(this.frmListaTramites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTramites)).EndInit();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.RadioButton rbDni;
        private System.Windows.Forms.RadioButton rbApellido;
        private System.Windows.Forms.TextBox txtFiltro;
        public System.Windows.Forms.Button btnImportarDETALLESTramites;
        public System.Windows.Forms.Button btnImportar;
        public System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnExportar;
        public System.Windows.Forms.Button btnNuevoTramite;
        public System.Windows.Forms.DataGridView dgvListaTramites;
        private System.Windows.Forms.Label lblCantTramites;
        private System.Windows.Forms.RadioButton radioButton1;

    }
}