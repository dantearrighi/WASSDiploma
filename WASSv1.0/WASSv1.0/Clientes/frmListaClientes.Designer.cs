namespace WASSv1._0.Clientes
{
    partial class frmListaClientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaClientes));
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.rbDNICUIL = new System.Windows.Forms.RadioButton();
            this.rbApellido = new System.Windows.Forms.RadioButton();
            this.dgvListadoClientes = new System.Windows.Forms.DataGridView();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnElimClie = new System.Windows.Forms.Button();
            this.btnSeleccionarCli = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.txtFiltro);
            this.gbFiltro.Controls.Add(this.rbDNICUIL);
            this.gbFiltro.Controls.Add(this.rbApellido);
            this.gbFiltro.Location = new System.Drawing.Point(12, 12);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(372, 59);
            this.gbFiltro.TabIndex = 0;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Buscar por";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(6, 27);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(271, 20);
            this.txtFiltro.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtFiltro, "Ingrese Apellido, DNI o CUIL para buscar");
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // rbDNICUIL
            // 
            this.rbDNICUIL.AutoSize = true;
            this.rbDNICUIL.Location = new System.Drawing.Point(283, 36);
            this.rbDNICUIL.Name = "rbDNICUIL";
            this.rbDNICUIL.Size = new System.Drawing.Size(77, 17);
            this.rbDNICUIL.TabIndex = 2;
            this.rbDNICUIL.Text = "DNI - CUIL";
            this.rbDNICUIL.UseVisualStyleBackColor = true;
            // 
            // rbApellido
            // 
            this.rbApellido.AutoSize = true;
            this.rbApellido.Checked = true;
            this.rbApellido.Location = new System.Drawing.Point(283, 16);
            this.rbApellido.Name = "rbApellido";
            this.rbApellido.Size = new System.Drawing.Size(62, 17);
            this.rbApellido.TabIndex = 1;
            this.rbApellido.TabStop = true;
            this.rbApellido.Text = "Apellido";
            this.rbApellido.UseVisualStyleBackColor = true;
            // 
            // dgvListadoClientes
            // 
            this.dgvListadoClientes.AllowUserToAddRows = false;
            this.dgvListadoClientes.AllowUserToDeleteRows = false;
            this.dgvListadoClientes.AllowUserToOrderColumns = true;
            this.dgvListadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoClientes.Location = new System.Drawing.Point(12, 77);
            this.dgvListadoClientes.Name = "dgvListadoClientes";
            this.dgvListadoClientes.ReadOnly = true;
            this.dgvListadoClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoClientes.ShowEditingIcon = false;
            this.dgvListadoClientes.Size = new System.Drawing.Size(757, 365);
            this.dgvListadoClientes.TabIndex = 7;
            this.dgvListadoClientes.TabStop = false;
            this.dgvListadoClientes.DoubleClick += new System.EventHandler(this.dgvListadoClientes_DoubleClick);
            // 
            // btnExportar
            // 
            this.btnExportar.Image = global::WASSv1._0.Properties.Resources.forward32;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.Location = new System.Drawing.Point(786, 119);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(118, 39);
            this.btnExportar.TabIndex = 17;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnExportar, "Crea un documento de excel con los datos de la grilla");
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::WASSv1._0.Properties.Resources.Excel;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.Location = new System.Drawing.Point(786, 29);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(117, 39);
            this.btnExcel.TabIndex = 16;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnExcel, "En construcción");
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnElimClie
            // 
            this.btnElimClie.Image = global::WASSv1._0.Properties.Resources.Delete_24x24;
            this.btnElimClie.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnElimClie.Location = new System.Drawing.Point(642, 29);
            this.btnElimClie.Name = "btnElimClie";
            this.btnElimClie.Size = new System.Drawing.Size(117, 39);
            this.btnElimClie.TabIndex = 3;
            this.btnElimClie.Text = "Eliminar";
            this.btnElimClie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElimClie.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnElimClie, "Elimina el Cliente seleccionado");
            this.btnElimClie.UseVisualStyleBackColor = true;
            this.btnElimClie.Click += new System.EventHandler(this.btnElimClie_Click);
            // 
            // btnSeleccionarCli
            // 
            this.btnSeleccionarCli.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSeleccionarCli.Image = global::WASSv1._0.Properties.Resources.go_into32;
            this.btnSeleccionarCli.Location = new System.Drawing.Point(786, 29);
            this.btnSeleccionarCli.Name = "btnSeleccionarCli";
            this.btnSeleccionarCli.Size = new System.Drawing.Size(117, 39);
            this.btnSeleccionarCli.TabIndex = 14;
            this.btnSeleccionarCli.Text = "Seleccionar ";
            this.btnSeleccionarCli.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSeleccionarCli.UseVisualStyleBackColor = true;
            this.btnSeleccionarCli.Visible = false;
            this.btnSeleccionarCli.Click += new System.EventHandler(this.btnSeleccionarCli_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Image = global::WASSv1._0.Properties.Resources.back32;
            this.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportar.Location = new System.Drawing.Point(786, 74);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(118, 39);
            this.btnImportar.TabIndex = 12;
            this.btnImportar.Text = "Importar ";
            this.btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnImportar, "En Construcción");
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Image = global::WASSv1._0.Properties.Resources.close_24;
            this.btnCerrar.Location = new System.Drawing.Point(786, 406);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(117, 39);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnCerrar, "Cerrar Listado de Clientes");
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::WASSv1._0.Properties.Resources.document_32;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.Location = new System.Drawing.Point(519, 29);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 39);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnModificar, "Modifica el Cliente seleccionado");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Image = global::WASSv1._0.Properties.Resources.folder_add_32;
            this.btnAgregarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCliente.Location = new System.Drawing.Point(396, 29);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(117, 39);
            this.btnAgregarCliente.TabIndex = 1;
            this.btnAgregarCliente.Text = "Nuevo Cliente";
            this.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnAgregarCliente, "Registra un nuevo Cliente");
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // frmListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 459);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnElimClie);
            this.Controls.Add(this.btnSeleccionarCli);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.dgvListadoClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Clientes";
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.RadioButton rbDNICUIL;
        private System.Windows.Forms.RadioButton rbApellido;
        public System.Windows.Forms.DataGridView dgvListadoClientes;
        public System.Windows.Forms.Button btnImportar;
        public System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnAgregarCliente;
        public System.Windows.Forms.Button btnSeleccionarCli;
        public System.Windows.Forms.Button btnElimClie;
        public System.Windows.Forms.Button btnExcel;
        public System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}