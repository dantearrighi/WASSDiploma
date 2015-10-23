namespace WASSv1._0.Tramites
{
    partial class frmTramiteABM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTramiteABM));
            this.label10 = new System.Windows.Forms.Label();
            this.txtUltimoMovFecha = new System.Windows.Forms.TextBox();
            this.txtDerivadoA = new System.Windows.Forms.TextBox();
            this.txtEnviadoPor = new System.Windows.Forms.TextBox();
            this.txtTipoTramite = new System.Windows.Forms.TextBox();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbDetallesTramite = new System.Windows.Forms.GroupBox();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.btnAddDetalleLong = new System.Windows.Forms.Button();
            this.btnGuardarNuevoDetalle = new System.Windows.Forms.Button();
            this.lblDescriNueva = new System.Windows.Forms.Label();
            this.txtDescripcionNueva = new System.Windows.Forms.TextBox();
            this.dgvDetallesTramite = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.lblBuscarCli = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnBuscarCli = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDNICUIL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDTramite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImprimirReporte = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRegistrarPagoIngresado = new System.Windows.Forms.Button();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.btnAñadirPago = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.lblPagConcepto = new System.Windows.Forms.Label();
            this.txtPagoValor = new System.Windows.Forms.TextBox();
            this.txtPagoDetalle = new System.Windows.Forms.TextBox();
            this.lblPagMonto = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbDetallesTramite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesTramite)).BeginInit();
            this.gbCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(427, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Ultimo Movimiento: ";
            // 
            // txtUltimoMovFecha
            // 
            this.txtUltimoMovFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUltimoMovFecha.Location = new System.Drawing.Point(529, 52);
            this.txtUltimoMovFecha.Name = "txtUltimoMovFecha";
            this.txtUltimoMovFecha.Size = new System.Drawing.Size(130, 20);
            this.txtUltimoMovFecha.TabIndex = 27;
            this.txtUltimoMovFecha.TabStop = false;
            // 
            // txtDerivadoA
            // 
            this.txtDerivadoA.Location = new System.Drawing.Point(128, 73);
            this.txtDerivadoA.MaxLength = 49;
            this.txtDerivadoA.Name = "txtDerivadoA";
            this.txtDerivadoA.Size = new System.Drawing.Size(180, 20);
            this.txtDerivadoA.TabIndex = 2;
            // 
            // txtEnviadoPor
            // 
            this.txtEnviadoPor.Location = new System.Drawing.Point(128, 47);
            this.txtEnviadoPor.MaxLength = 49;
            this.txtEnviadoPor.Name = "txtEnviadoPor";
            this.txtEnviadoPor.Size = new System.Drawing.Size(180, 20);
            this.txtEnviadoPor.TabIndex = 1;
            // 
            // txtTipoTramite
            // 
            this.txtTipoTramite.Location = new System.Drawing.Point(128, 21);
            this.txtTipoTramite.MaxLength = 99;
            this.txtTipoTramite.Name = "txtTipoTramite";
            this.txtTipoTramite.Size = new System.Drawing.Size(180, 20);
            this.txtTipoTramite.TabIndex = 0;
            // 
            // txtDetalles
            // 
            this.txtDetalles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetalles.Location = new System.Drawing.Point(58, 26);
            this.txtDetalles.MaxLength = 299;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(601, 20);
            this.txtDetalles.TabIndex = 0;
            this.txtDetalles.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Apoderado:";
            // 
            // gbDetallesTramite
            // 
            this.gbDetallesTramite.Controls.Add(this.btnEliminarDetalle);
            this.gbDetallesTramite.Controls.Add(this.txtUltimoMovFecha);
            this.gbDetallesTramite.Controls.Add(this.btnAddDetalleLong);
            this.gbDetallesTramite.Controls.Add(this.label10);
            this.gbDetallesTramite.Controls.Add(this.btnGuardarNuevoDetalle);
            this.gbDetallesTramite.Controls.Add(this.lblDescriNueva);
            this.gbDetallesTramite.Controls.Add(this.txtDescripcionNueva);
            this.gbDetallesTramite.Controls.Add(this.dgvDetallesTramite);
            this.gbDetallesTramite.Controls.Add(this.txtDetalles);
            this.gbDetallesTramite.Controls.Add(this.label5);
            this.gbDetallesTramite.Location = new System.Drawing.Point(12, 125);
            this.gbDetallesTramite.Name = "gbDetallesTramite";
            this.gbDetallesTramite.Size = new System.Drawing.Size(698, 304);
            this.gbDetallesTramite.TabIndex = 2;
            this.gbDetallesTramite.TabStop = false;
            this.gbDetallesTramite.Text = "Detalles";
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.Image = global::WASSv1._0.Properties.Resources.delete_16;
            this.btnEliminarDetalle.Location = new System.Drawing.Point(6, 270);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(107, 28);
            this.btnEliminarDetalle.TabIndex = 36;
            this.btnEliminarDetalle.Text = "Eliminar detalle";
            this.btnEliminarDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnEliminarDetalle, "No funciona");
            this.btnEliminarDetalle.UseVisualStyleBackColor = true;
            this.btnEliminarDetalle.Click += new System.EventHandler(this.btnEliminarDetalle_Click);
            // 
            // btnAddDetalleLong
            // 
            this.btnAddDetalleLong.Image = global::WASSv1._0.Properties.Resources.Add_24x24;
            this.btnAddDetalleLong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDetalleLong.Location = new System.Drawing.Point(6, 82);
            this.btnAddDetalleLong.Name = "btnAddDetalleLong";
            this.btnAddDetalleLong.Size = new System.Drawing.Size(686, 33);
            this.btnAddDetalleLong.TabIndex = 1;
            this.btnAddDetalleLong.Text = "Agregar detalles";
            this.btnAddDetalleLong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDetalleLong.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddDetalleLong.UseVisualStyleBackColor = true;
            this.btnAddDetalleLong.Click += new System.EventHandler(this.btnAddDetalleLong_Click);
            // 
            // btnGuardarNuevoDetalle
            // 
            this.btnGuardarNuevoDetalle.Image = global::WASSv1._0.Properties.Resources.Add_16x16;
            this.btnGuardarNuevoDetalle.Location = new System.Drawing.Point(613, 82);
            this.btnGuardarNuevoDetalle.Name = "btnGuardarNuevoDetalle";
            this.btnGuardarNuevoDetalle.Size = new System.Drawing.Size(67, 33);
            this.btnGuardarNuevoDetalle.TabIndex = 2;
            this.btnGuardarNuevoDetalle.Text = "Añadir";
            this.btnGuardarNuevoDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarNuevoDetalle.UseVisualStyleBackColor = true;
            this.btnGuardarNuevoDetalle.Click += new System.EventHandler(this.btnGuardarNuevoDetalle_Click);
            // 
            // lblDescriNueva
            // 
            this.lblDescriNueva.AutoSize = true;
            this.lblDescriNueva.Location = new System.Drawing.Point(9, 28);
            this.lblDescriNueva.Name = "lblDescriNueva";
            this.lblDescriNueva.Size = new System.Drawing.Size(43, 13);
            this.lblDescriNueva.TabIndex = 33;
            this.lblDescriNueva.Text = "Estado:";
            // 
            // txtDescripcionNueva
            // 
            this.txtDescripcionNueva.Location = new System.Drawing.Point(110, 84);
            this.txtDescripcionNueva.MaxLength = 299;
            this.txtDescripcionNueva.Name = "txtDescripcionNueva";
            this.txtDescripcionNueva.Size = new System.Drawing.Size(501, 20);
            this.txtDescripcionNueva.TabIndex = 1;
            // 
            // dgvDetallesTramite
            // 
            this.dgvDetallesTramite.AllowUserToAddRows = false;
            this.dgvDetallesTramite.AllowUserToDeleteRows = false;
            this.dgvDetallesTramite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesTramite.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDetallesTramite.Location = new System.Drawing.Point(6, 121);
            this.dgvDetallesTramite.Name = "dgvDetallesTramite";
            this.dgvDetallesTramite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetallesTramite.Size = new System.Drawing.Size(686, 147);
            this.dgvDetallesTramite.TabIndex = 0;
            this.dgvDetallesTramite.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Nuevo estado:";
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.lblBuscarCli);
            this.gbCliente.Controls.Add(this.label7);
            this.gbCliente.Controls.Add(this.txtApellido);
            this.gbCliente.Controls.Add(this.btnBuscarCli);
            this.gbCliente.Controls.Add(this.txtNombre);
            this.gbCliente.Controls.Add(this.label6);
            this.gbCliente.Controls.Add(this.txtDNICUIL);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Location = new System.Drawing.Point(12, 10);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(304, 101);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // lblBuscarCli
            // 
            this.lblBuscarCli.AutoSize = true;
            this.lblBuscarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCli.Location = new System.Drawing.Point(246, 75);
            this.lblBuscarCli.Name = "lblBuscarCli";
            this.lblBuscarCli.Size = new System.Drawing.Size(45, 13);
            this.lblBuscarCli.TabIndex = 15;
            this.lblBuscarCli.Text = "Buscar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(81, 44);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(162, 20);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.TabStop = false;
            // 
            // btnBuscarCli
            // 
            this.btnBuscarCli.Image = global::WASSv1._0.Properties.Resources.Search_16x16;
            this.btnBuscarCli.Location = new System.Drawing.Point(249, 43);
            this.btnBuscarCli.Name = "btnBuscarCli";
            this.btnBuscarCli.Size = new System.Drawing.Size(42, 33);
            this.btnBuscarCli.TabIndex = 3;
            this.btnBuscarCli.UseVisualStyleBackColor = true;
            this.btnBuscarCli.Click += new System.EventHandler(this.btnBuscarCli_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nombre:";
            // 
            // txtDNICUIL
            // 
            this.txtDNICUIL.Location = new System.Drawing.Point(81, 18);
            this.txtDNICUIL.MaxLength = 25;
            this.txtDNICUIL.Name = "txtDNICUIL";
            this.txtDNICUIL.Size = new System.Drawing.Size(210, 20);
            this.txtDNICUIL.TabIndex = 0;
            this.txtDNICUIL.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI - CUIL:";
            // 
            // txtIDTramite
            // 
            this.txtIDTramite.Location = new System.Drawing.Point(480, 7);
            this.txtIDTramite.Name = "txtIDTramite";
            this.txtIDTramite.Size = new System.Drawing.Size(86, 20);
            this.txtIDTramite.TabIndex = 5;
            this.txtIDTramite.TabStop = false;
            this.txtIDTramite.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enviado por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de Trámite:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Trámite:";
            this.label1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImprimirReporte);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Location = new System.Drawing.Point(517, 437);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 163);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnImprimirReporte
            // 
            this.btnImprimirReporte.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnImprimirReporte.Image = global::WASSv1._0.Properties.Resources.document_32;
            this.btnImprimirReporte.Location = new System.Drawing.Point(40, 63);
            this.btnImprimirReporte.Name = "btnImprimirReporte";
            this.btnImprimirReporte.Size = new System.Drawing.Size(114, 38);
            this.btnImprimirReporte.TabIndex = 1;
            this.btnImprimirReporte.Text = "Crear Informe";
            this.btnImprimirReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnImprimirReporte.UseVisualStyleBackColor = true;
            this.btnImprimirReporte.Click += new System.EventHandler(this.btnImprimirReporte_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancelar.Image = global::WASSv1._0.Properties.Resources.close_24;
            this.btnCancelar.Location = new System.Drawing.Point(40, 109);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 38);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.Image = global::WASSv1._0.Properties.Resources.Check_24x24;
            this.btnGuardar.Location = new System.Drawing.Point(40, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 38);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRegistrarPagoIngresado);
            this.groupBox2.Controls.Add(this.dgvPagos);
            this.groupBox2.Controls.Add(this.btnAñadirPago);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.lblFechaPago);
            this.groupBox2.Controls.Add(this.lblPagConcepto);
            this.groupBox2.Controls.Add(this.txtPagoValor);
            this.groupBox2.Controls.Add(this.txtPagoDetalle);
            this.groupBox2.Controls.Add(this.lblPagMonto);
            this.groupBox2.Location = new System.Drawing.Point(12, 437);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 163);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historial de Pagos";
            // 
            // btnRegistrarPagoIngresado
            // 
            this.btnRegistrarPagoIngresado.Image = global::WASSv1._0.Properties.Resources.Add_16x16;
            this.btnRegistrarPagoIngresado.Location = new System.Drawing.Point(417, 127);
            this.btnRegistrarPagoIngresado.Name = "btnRegistrarPagoIngresado";
            this.btnRegistrarPagoIngresado.Size = new System.Drawing.Size(41, 31);
            this.btnRegistrarPagoIngresado.TabIndex = 3;
            this.btnRegistrarPagoIngresado.UseVisualStyleBackColor = true;
            this.btnRegistrarPagoIngresado.Click += new System.EventHandler(this.btnRegistrarPagoIngresado_Click);
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPagos.Location = new System.Drawing.Point(6, 19);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.Size = new System.Drawing.Size(452, 99);
            this.dgvPagos.TabIndex = 0;
            this.dgvPagos.TabStop = false;
            // 
            // btnAñadirPago
            // 
            this.btnAñadirPago.Image = global::WASSv1._0.Properties.Resources.Add_16x16;
            this.btnAñadirPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadirPago.Location = new System.Drawing.Point(6, 126);
            this.btnAñadirPago.Name = "btnAñadirPago";
            this.btnAñadirPago.Size = new System.Drawing.Size(452, 33);
            this.btnAñadirPago.TabIndex = 0;
            this.btnAñadirPago.Text = "Añadir pago";
            this.btnAñadirPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadirPago.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAñadirPago.UseVisualStyleBackColor = true;
            this.btnAñadirPago.Click += new System.EventHandler(this.btnAñadirPago_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Visible = false;
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Location = new System.Drawing.Point(8, 123);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(40, 13);
            this.lblFechaPago.TabIndex = 37;
            this.lblFechaPago.Text = "Fecha:";
            this.lblFechaPago.Visible = false;
            // 
            // lblPagConcepto
            // 
            this.lblPagConcepto.AutoSize = true;
            this.lblPagConcepto.Location = new System.Drawing.Point(280, 123);
            this.lblPagConcepto.Name = "lblPagConcepto";
            this.lblPagConcepto.Size = new System.Drawing.Size(60, 13);
            this.lblPagConcepto.TabIndex = 36;
            this.lblPagConcepto.Text = "Comentario";
            this.lblPagConcepto.Visible = false;
            // 
            // txtPagoValor
            // 
            this.txtPagoValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPagoValor.Location = new System.Drawing.Point(214, 139);
            this.txtPagoValor.MaxLength = 6;
            this.txtPagoValor.Name = "txtPagoValor";
            this.txtPagoValor.Size = new System.Drawing.Size(53, 20);
            this.txtPagoValor.TabIndex = 1;
            this.txtPagoValor.Visible = false;
            // 
            // txtPagoDetalle
            // 
            this.txtPagoDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPagoDetalle.Location = new System.Drawing.Point(273, 139);
            this.txtPagoDetalle.MaxLength = 149;
            this.txtPagoDetalle.Name = "txtPagoDetalle";
            this.txtPagoDetalle.Size = new System.Drawing.Size(135, 20);
            this.txtPagoDetalle.TabIndex = 2;
            this.txtPagoDetalle.Visible = false;
            // 
            // lblPagMonto
            // 
            this.lblPagMonto.AutoSize = true;
            this.lblPagMonto.Location = new System.Drawing.Point(215, 123);
            this.lblPagMonto.Name = "lblPagMonto";
            this.lblPagMonto.Size = new System.Drawing.Size(40, 13);
            this.lblPagMonto.TabIndex = 16;
            this.lblPagMonto.Text = "Monto:";
            this.lblPagMonto.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDerivadoA);
            this.groupBox3.Controls.Add(this.txtEnviadoPor);
            this.groupBox3.Controls.Add(this.txtTipoTramite);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(359, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 101);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Observaciones";
            // 
            // frmTramiteABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(718, 608);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.gbDetallesTramite);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDTramite);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTramiteABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTramiteABM";
            this.Load += new System.EventHandler(this.frmTramiteABM_Load);
            this.gbDetallesTramite.ResumeLayout(false);
            this.gbDetallesTramite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesTramite)).EndInit();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbDetallesTramite;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscarCli;
        public System.Windows.Forms.TextBox txtDerivadoA;
        public System.Windows.Forms.TextBox txtEnviadoPor;
        public System.Windows.Forms.TextBox txtTipoTramite;
        public System.Windows.Forms.TextBox txtDNICUIL;
        public System.Windows.Forms.TextBox txtIDTramite;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtDetalles;
        public System.Windows.Forms.DataGridView dgvDetallesTramite;
        public System.Windows.Forms.TextBox txtUltimoMovFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblBuscarCli;
        private System.Windows.Forms.Button btnImprimirReporte;
        public System.Windows.Forms.TextBox txtDescripcionNueva;
        private System.Windows.Forms.Label lblDescriNueva;
        private System.Windows.Forms.Button btnAddDetalleLong;
        private System.Windows.Forms.Button btnGuardarNuevoDetalle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAñadirPago;
        public System.Windows.Forms.TextBox txtPagoValor;
        public System.Windows.Forms.TextBox txtPagoDetalle;
        private System.Windows.Forms.Label lblPagMonto;
        private System.Windows.Forms.Label lblPagConcepto;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegistrarPagoIngresado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminarDetalle;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}