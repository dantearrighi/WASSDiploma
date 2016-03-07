namespace WASSTD
{
    partial class FrmTramite
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_DebeSeleccionar = new System.Windows.Forms.Label();
            this.btn_seleccionarPersona = new System.Windows.Forms.Button();
            this.lbl_ClaveFiscal = new System.Windows.Forms.Label();
            this.lbl_NombreyApellido = new System.Windows.Forms.Label();
            this.lbl_FechaNacimiento = new System.Windows.Forms.Label();
            this.lbl_TipoDocumento = new System.Windows.Forms.Label();
            this.lbl_TipoPersona = new System.Windows.Forms.Label();
            this.lbl_NumeroDoc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.grp_sexo = new System.Windows.Forms.GroupBox();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.lb_sexo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_tipodoc = new System.Windows.Forms.Label();
            this.lb_fechanacimiento = new System.Windows.Forms.Label();
            this.lb_numero = new System.Windows.Forms.Label();
            this.lb_nombreapellido = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Fecha_Del_Detalle = new System.Windows.Forms.MaskedTextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.lbl_Fecha_Del_Detalle = new System.Windows.Forms.Label();
            this.btn_AñadirDetalle = new System.Windows.Forms.Button();
            this.dgv_datos_detalles = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_CrearInforme = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btn_RealizarCalculo = new System.Windows.Forms.Button();
            this.btn_RecordatorioVanina = new System.Windows.Forms.Button();
            this.btn_VerCalculosAnteriores = new System.Windows.Forms.Button();
            this.btn_NotificarCliente = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_Ultimo_Movimiento = new System.Windows.Forms.MaskedTextBox();
            this.txt_fecha_Alta = new System.Windows.Forms.MaskedTextBox();
            this.cmb_tipos_tramites = new System.Windows.Forms.ComboBox();
            this.txt_nro_tramite = new System.Windows.Forms.TextBox();
            this.lbl_UltimoMovimiento = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbl_Activo = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbl_Finalizado = new System.Windows.Forms.Label();
            this.lbl_DE_BAJA = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grp_sexo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos_detalles)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_DebeSeleccionar);
            this.groupBox1.Controls.Add(this.btn_seleccionarPersona);
            this.groupBox1.Controls.Add(this.lbl_ClaveFiscal);
            this.groupBox1.Controls.Add(this.lbl_NombreyApellido);
            this.groupBox1.Controls.Add(this.lbl_FechaNacimiento);
            this.groupBox1.Controls.Add(this.lbl_TipoDocumento);
            this.groupBox1.Controls.Add(this.lbl_TipoPersona);
            this.groupBox1.Controls.Add(this.lbl_NumeroDoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_Edad);
            this.groupBox1.Controls.Add(this.grp_sexo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb_tipodoc);
            this.groupBox1.Controls.Add(this.lb_fechanacimiento);
            this.groupBox1.Controls.Add(this.lb_numero);
            this.groupBox1.Controls.Add(this.lb_nombreapellido);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // lbl_DebeSeleccionar
            // 
            this.lbl_DebeSeleccionar.AutoSize = true;
            this.lbl_DebeSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DebeSeleccionar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_DebeSeleccionar.Location = new System.Drawing.Point(198, 138);
            this.lbl_DebeSeleccionar.Name = "lbl_DebeSeleccionar";
            this.lbl_DebeSeleccionar.Size = new System.Drawing.Size(223, 13);
            this.lbl_DebeSeleccionar.TabIndex = 65;
            this.lbl_DebeSeleccionar.Text = "DEBE SELECCIONAR UNA PERSONA";
            // 
            // btn_seleccionarPersona
            // 
            this.btn_seleccionarPersona.Image = global::WASSTD.Properties.Resources.user_icon_16;
            this.btn_seleccionarPersona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_seleccionarPersona.Location = new System.Drawing.Point(430, 127);
            this.btn_seleccionarPersona.Name = "btn_seleccionarPersona";
            this.btn_seleccionarPersona.Size = new System.Drawing.Size(73, 35);
            this.btn_seleccionarPersona.TabIndex = 1;
            this.btn_seleccionarPersona.Text = "Buscar";
            this.btn_seleccionarPersona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_seleccionarPersona.UseVisualStyleBackColor = true;
            this.btn_seleccionarPersona.Click += new System.EventHandler(this.btn_seleccionarPersona_Click);
            // 
            // lbl_ClaveFiscal
            // 
            this.lbl_ClaveFiscal.AutoSize = true;
            this.lbl_ClaveFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClaveFiscal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_ClaveFiscal.Location = new System.Drawing.Point(140, 138);
            this.lbl_ClaveFiscal.Name = "lbl_ClaveFiscal";
            this.lbl_ClaveFiscal.Size = new System.Drawing.Size(35, 13);
            this.lbl_ClaveFiscal.TabIndex = 63;
            this.lbl_ClaveFiscal.Text = " ------";
            // 
            // lbl_NombreyApellido
            // 
            this.lbl_NombreyApellido.AutoSize = true;
            this.lbl_NombreyApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreyApellido.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_NombreyApellido.Location = new System.Drawing.Point(140, 115);
            this.lbl_NombreyApellido.Name = "lbl_NombreyApellido";
            this.lbl_NombreyApellido.Size = new System.Drawing.Size(35, 13);
            this.lbl_NombreyApellido.TabIndex = 62;
            this.lbl_NombreyApellido.Text = " ------";
            // 
            // lbl_FechaNacimiento
            // 
            this.lbl_FechaNacimiento.AutoSize = true;
            this.lbl_FechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaNacimiento.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_FechaNacimiento.Location = new System.Drawing.Point(140, 82);
            this.lbl_FechaNacimiento.Name = "lbl_FechaNacimiento";
            this.lbl_FechaNacimiento.Size = new System.Drawing.Size(35, 13);
            this.lbl_FechaNacimiento.TabIndex = 61;
            this.lbl_FechaNacimiento.Text = " ------";
            // 
            // lbl_TipoDocumento
            // 
            this.lbl_TipoDocumento.AutoSize = true;
            this.lbl_TipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoDocumento.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_TipoDocumento.Location = new System.Drawing.Point(140, 52);
            this.lbl_TipoDocumento.Name = "lbl_TipoDocumento";
            this.lbl_TipoDocumento.Size = new System.Drawing.Size(35, 13);
            this.lbl_TipoDocumento.TabIndex = 60;
            this.lbl_TipoDocumento.Text = " ------";
            // 
            // lbl_TipoPersona
            // 
            this.lbl_TipoPersona.AutoSize = true;
            this.lbl_TipoPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoPersona.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_TipoPersona.Location = new System.Drawing.Point(140, 22);
            this.lbl_TipoPersona.Name = "lbl_TipoPersona";
            this.lbl_TipoPersona.Size = new System.Drawing.Size(35, 13);
            this.lbl_TipoPersona.TabIndex = 59;
            this.lbl_TipoPersona.Text = " ------";
            // 
            // lbl_NumeroDoc
            // 
            this.lbl_NumeroDoc.AutoSize = true;
            this.lbl_NumeroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumeroDoc.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_NumeroDoc.Location = new System.Drawing.Point(345, 52);
            this.lbl_NumeroDoc.Name = "lbl_NumeroDoc";
            this.lbl_NumeroDoc.Size = new System.Drawing.Size(35, 13);
            this.lbl_NumeroDoc.TabIndex = 15;
            this.lbl_NumeroDoc.Text = " ------";
            // 
            // label4
            // 
            this.label4.Image = global::WASSTD.Properties.Resources.key_icon_16;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(4, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 35);
            this.label4.TabIndex = 58;
            this.label4.Text = "Clave Fiscal:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Edad.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Edad.Location = new System.Drawing.Point(345, 79);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(35, 13);
            this.lbl_Edad.TabIndex = 57;
            this.lbl_Edad.Text = " ------";
            // 
            // grp_sexo
            // 
            this.grp_sexo.Controls.Add(this.lbl_Sexo);
            this.grp_sexo.Controls.Add(this.lb_sexo);
            this.grp_sexo.Location = new System.Drawing.Point(260, 11);
            this.grp_sexo.Name = "grp_sexo";
            this.grp_sexo.Size = new System.Drawing.Size(243, 36);
            this.grp_sexo.TabIndex = 49;
            this.grp_sexo.TabStop = false;
            // 
            // lbl_Sexo
            // 
            this.lbl_Sexo.AutoSize = true;
            this.lbl_Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sexo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Sexo.Location = new System.Drawing.Point(85, 15);
            this.lbl_Sexo.Name = "lbl_Sexo";
            this.lbl_Sexo.Size = new System.Drawing.Size(35, 13);
            this.lbl_Sexo.TabIndex = 14;
            this.lbl_Sexo.Text = " ------";
            // 
            // lb_sexo
            // 
            this.lb_sexo.Image = global::WASSTD.Properties.Resources.font_strokethrough_icon_16;
            this.lb_sexo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_sexo.Location = new System.Drawing.Point(5, 8);
            this.lb_sexo.Name = "lb_sexo";
            this.lb_sexo.Size = new System.Drawing.Size(73, 26);
            this.lb_sexo.TabIndex = 13;
            this.lb_sexo.Text = "Sexo:";
            this.lb_sexo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Image = global::WASSTD.Properties.Resources.contact_card_icon_16;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(270, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 35);
            this.label2.TabIndex = 56;
            this.label2.Text = "Edad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Image = global::WASSTD.Properties.Resources.users_icon_16;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(2, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 35);
            this.label1.TabIndex = 54;
            this.label1.Text = "Tipo de Persona:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_tipodoc
            // 
            this.lb_tipodoc.Image = global::WASSTD.Properties.Resources.book_icon_16;
            this.lb_tipodoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_tipodoc.Location = new System.Drawing.Point(2, 41);
            this.lb_tipodoc.Name = "lb_tipodoc";
            this.lb_tipodoc.Size = new System.Drawing.Size(132, 35);
            this.lb_tipodoc.TabIndex = 23;
            this.lb_tipodoc.Text = "Tipo de Documento:";
            this.lb_tipodoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_fechanacimiento
            // 
            this.lb_fechanacimiento.Image = global::WASSTD.Properties.Resources.calendar_1_icon_16;
            this.lb_fechanacimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_fechanacimiento.Location = new System.Drawing.Point(2, 71);
            this.lb_fechanacimiento.Name = "lb_fechanacimiento";
            this.lb_fechanacimiento.Size = new System.Drawing.Size(132, 35);
            this.lb_fechanacimiento.TabIndex = 11;
            this.lb_fechanacimiento.Text = "Fecha de Nacimiento:";
            this.lb_fechanacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_numero
            // 
            this.lb_numero.Image = global::WASSTD.Properties.Resources.page_layout_icon_16;
            this.lb_numero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_numero.Location = new System.Drawing.Point(270, 42);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(74, 35);
            this.lb_numero.TabIndex = 9;
            this.lb_numero.Text = "Número:";
            this.lb_numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_nombreapellido
            // 
            this.lb_nombreapellido.Image = global::WASSTD.Properties.Resources.contact_card_icon_16;
            this.lb_nombreapellido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_nombreapellido.Location = new System.Drawing.Point(3, 104);
            this.lb_nombreapellido.Name = "lb_nombreapellido";
            this.lb_nombreapellido.Size = new System.Drawing.Size(132, 35);
            this.lb_nombreapellido.TabIndex = 0;
            this.lb_nombreapellido.Text = "Nombre y Apellido:";
            this.lb_nombreapellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Fecha_Del_Detalle);
            this.groupBox2.Controls.Add(this.txt_Descripcion);
            this.groupBox2.Controls.Add(this.lbl_Fecha_Del_Detalle);
            this.groupBox2.Controls.Add(this.btn_AñadirDetalle);
            this.groupBox2.Controls.Add(this.dgv_datos_detalles);
            this.groupBox2.Location = new System.Drawing.Point(12, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(917, 468);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del trámite";
            // 
            // txt_Fecha_Del_Detalle
            // 
            this.txt_Fecha_Del_Detalle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_Fecha_Del_Detalle.Location = new System.Drawing.Point(127, 48);
            this.txt_Fecha_Del_Detalle.Mask = "00/00/0000";
            this.txt_Fecha_Del_Detalle.Name = "txt_Fecha_Del_Detalle";
            this.txt_Fecha_Del_Detalle.Size = new System.Drawing.Size(100, 20);
            this.txt_Fecha_Del_Detalle.TabIndex = 67;
            this.txt_Fecha_Del_Detalle.ValidatingType = typeof(System.DateTime);
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(7, 22);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.ReadOnly = true;
            this.txt_Descripcion.Size = new System.Drawing.Size(771, 20);
            this.txt_Descripcion.TabIndex = 67;
            this.txt_Descripcion.Text = "Alta";
            // 
            // lbl_Fecha_Del_Detalle
            // 
            this.lbl_Fecha_Del_Detalle.Image = global::WASSTD.Properties.Resources.calendar_1_icon_16;
            this.lbl_Fecha_Del_Detalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Fecha_Del_Detalle.Location = new System.Drawing.Point(6, 40);
            this.lbl_Fecha_Del_Detalle.Name = "lbl_Fecha_Del_Detalle";
            this.lbl_Fecha_Del_Detalle.Size = new System.Drawing.Size(115, 35);
            this.lbl_Fecha_Del_Detalle.TabIndex = 66;
            this.lbl_Fecha_Del_Detalle.Text = "Fecha del detalle:";
            this.lbl_Fecha_Del_Detalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_AñadirDetalle
            // 
            this.btn_AñadirDetalle.Image = global::WASSTD.Properties.Resources.doc_edit_icon_16;
            this.btn_AñadirDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AñadirDetalle.Location = new System.Drawing.Point(784, 19);
            this.btn_AñadirDetalle.Name = "btn_AñadirDetalle";
            this.btn_AñadirDetalle.Size = new System.Drawing.Size(128, 49);
            this.btn_AñadirDetalle.TabIndex = 66;
            this.btn_AñadirDetalle.Text = "Añadir detalle";
            this.btn_AñadirDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AñadirDetalle.UseVisualStyleBackColor = true;
            this.btn_AñadirDetalle.Click += new System.EventHandler(this.btn_AñadirDetalle_Click);
            // 
            // dgv_datos_detalles
            // 
            this.dgv_datos_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos_detalles.Location = new System.Drawing.Point(6, 78);
            this.dgv_datos_detalles.Name = "dgv_datos_detalles";
            this.dgv_datos_detalles.Size = new System.Drawing.Size(904, 384);
            this.dgv_datos_detalles.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.monthCalendar1.Location = new System.Drawing.Point(951, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 66;
            // 
            // btn_CrearInforme
            // 
            this.btn_CrearInforme.Image = global::WASSTD.Properties.Resources.print_icon_16;
            this.btn_CrearInforme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CrearInforme.Location = new System.Drawing.Point(5, 19);
            this.btn_CrearInforme.Name = "btn_CrearInforme";
            this.btn_CrearInforme.Size = new System.Drawing.Size(204, 61);
            this.btn_CrearInforme.TabIndex = 66;
            this.btn_CrearInforme.Text = "Crear Informe";
            this.btn_CrearInforme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CrearInforme.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_guardar);
            this.groupBox3.Controls.Add(this.btnCerrar);
            this.groupBox3.Controls.Add(this.btn_RealizarCalculo);
            this.groupBox3.Controls.Add(this.btn_RecordatorioVanina);
            this.groupBox3.Controls.Add(this.btn_VerCalculosAnteriores);
            this.groupBox3.Controls.Add(this.btn_NotificarCliente);
            this.groupBox3.Controls.Add(this.btn_CrearInforme);
            this.groupBox3.Location = new System.Drawing.Point(934, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 468);
            this.groupBox3.TabIndex = 67;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::WASSTD.Properties.Resources.save_icon_16;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(7, 354);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(204, 61);
            this.btn_guardar.TabIndex = 72;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::WASSTD.Properties.Resources.cancel_icon_16;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.Location = new System.Drawing.Point(5, 426);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(204, 36);
            this.btnCerrar.TabIndex = 71;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btn_RealizarCalculo
            // 
            this.btn_RealizarCalculo.Image = global::WASSTD.Properties.Resources.chart_bar_icon_16;
            this.btn_RealizarCalculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RealizarCalculo.Location = new System.Drawing.Point(5, 86);
            this.btn_RealizarCalculo.Name = "btn_RealizarCalculo";
            this.btn_RealizarCalculo.Size = new System.Drawing.Size(204, 61);
            this.btn_RealizarCalculo.TabIndex = 67;
            this.btn_RealizarCalculo.Text = "Realizar cálculo";
            this.btn_RealizarCalculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RealizarCalculo.UseVisualStyleBackColor = true;
            // 
            // btn_RecordatorioVanina
            // 
            this.btn_RecordatorioVanina.Image = global::WASSTD.Properties.Resources.font_italic_icon_16;
            this.btn_RecordatorioVanina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RecordatorioVanina.Location = new System.Drawing.Point(6, 287);
            this.btn_RecordatorioVanina.Name = "btn_RecordatorioVanina";
            this.btn_RecordatorioVanina.Size = new System.Drawing.Size(204, 61);
            this.btn_RecordatorioVanina.TabIndex = 70;
            this.btn_RecordatorioVanina.Text = "Enviar recordatorio";
            this.btn_RecordatorioVanina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RecordatorioVanina.UseVisualStyleBackColor = true;
            // 
            // btn_VerCalculosAnteriores
            // 
            this.btn_VerCalculosAnteriores.Image = global::WASSTD.Properties.Resources.book_icon_16;
            this.btn_VerCalculosAnteriores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_VerCalculosAnteriores.Location = new System.Drawing.Point(5, 153);
            this.btn_VerCalculosAnteriores.Name = "btn_VerCalculosAnteriores";
            this.btn_VerCalculosAnteriores.Size = new System.Drawing.Size(204, 61);
            this.btn_VerCalculosAnteriores.TabIndex = 69;
            this.btn_VerCalculosAnteriores.Text = "Ver cálculos anteriores";
            this.btn_VerCalculosAnteriores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_VerCalculosAnteriores.UseVisualStyleBackColor = true;
            // 
            // btn_NotificarCliente
            // 
            this.btn_NotificarCliente.Image = global::WASSTD.Properties.Resources.mail_2_icon_161;
            this.btn_NotificarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NotificarCliente.Location = new System.Drawing.Point(5, 220);
            this.btn_NotificarCliente.Name = "btn_NotificarCliente";
            this.btn_NotificarCliente.Size = new System.Drawing.Size(204, 61);
            this.btn_NotificarCliente.TabIndex = 68;
            this.btn_NotificarCliente.Text = "Notificar por Email";
            this.btn_NotificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NotificarCliente.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_DE_BAJA);
            this.groupBox4.Controls.Add(this.txt_Ultimo_Movimiento);
            this.groupBox4.Controls.Add(this.txt_fecha_Alta);
            this.groupBox4.Controls.Add(this.cmb_tipos_tramites);
            this.groupBox4.Controls.Add(this.txt_nro_tramite);
            this.groupBox4.Controls.Add(this.lbl_UltimoMovimiento);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.lbl_Activo);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.lbl_Finalizado);
            this.groupBox4.Location = new System.Drawing.Point(532, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(397, 168);
            this.groupBox4.TabIndex = 66;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Información del trámite";
            // 
            // txt_Ultimo_Movimiento
            // 
            this.txt_Ultimo_Movimiento.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_Ultimo_Movimiento.Location = new System.Drawing.Point(129, 131);
            this.txt_Ultimo_Movimiento.Mask = "00/00/0000";
            this.txt_Ultimo_Movimiento.Name = "txt_Ultimo_Movimiento";
            this.txt_Ultimo_Movimiento.Size = new System.Drawing.Size(100, 20);
            this.txt_Ultimo_Movimiento.TabIndex = 65;
            this.txt_Ultimo_Movimiento.ValidatingType = typeof(System.DateTime);
            // 
            // txt_fecha_Alta
            // 
            this.txt_fecha_Alta.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_fecha_Alta.Location = new System.Drawing.Point(129, 100);
            this.txt_fecha_Alta.Mask = "00/00/0000";
            this.txt_fecha_Alta.Name = "txt_fecha_Alta";
            this.txt_fecha_Alta.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha_Alta.TabIndex = 64;
            this.txt_fecha_Alta.ValidatingType = typeof(System.DateTime);
            // 
            // cmb_tipos_tramites
            // 
            this.cmb_tipos_tramites.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_tipos_tramites.FormattingEnabled = true;
            this.cmb_tipos_tramites.Location = new System.Drawing.Point(128, 64);
            this.cmb_tipos_tramites.Name = "cmb_tipos_tramites";
            this.cmb_tipos_tramites.Size = new System.Drawing.Size(261, 21);
            this.cmb_tipos_tramites.TabIndex = 63;
            // 
            // txt_nro_tramite
            // 
            this.txt_nro_tramite.Location = new System.Drawing.Point(129, 24);
            this.txt_nro_tramite.Name = "txt_nro_tramite";
            this.txt_nro_tramite.Size = new System.Drawing.Size(87, 20);
            this.txt_nro_tramite.TabIndex = 62;
            // 
            // lbl_UltimoMovimiento
            // 
            this.lbl_UltimoMovimiento.Image = global::WASSTD.Properties.Resources.reload_icon_16;
            this.lbl_UltimoMovimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_UltimoMovimiento.Location = new System.Drawing.Point(7, 127);
            this.lbl_UltimoMovimiento.Name = "lbl_UltimoMovimiento";
            this.lbl_UltimoMovimiento.Size = new System.Drawing.Size(115, 35);
            this.lbl_UltimoMovimiento.TabIndex = 60;
            this.lbl_UltimoMovimiento.Text = "Último movimiento:";
            this.lbl_UltimoMovimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Image = global::WASSTD.Properties.Resources.notepad_icon_16;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 35);
            this.label3.TabIndex = 59;
            this.label3.Text = "Nº de Trámite:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Image = global::WASSTD.Properties.Resources.calendar_1_icon_16;
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(6, 92);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(116, 35);
            this.label19.TabIndex = 11;
            this.label19.Text = "Fecha de Alta:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Activo
            // 
            this.lbl_Activo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Activo.ForeColor = System.Drawing.Color.Green;
            this.lbl_Activo.Image = global::WASSTD.Properties.Resources.on_off_icon_16;
            this.lbl_Activo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Activo.Location = new System.Drawing.Point(272, 16);
            this.lbl_Activo.Name = "lbl_Activo";
            this.lbl_Activo.Size = new System.Drawing.Size(117, 35);
            this.lbl_Activo.TabIndex = 9;
            this.lbl_Activo.Text = "ACTIVO";
            this.lbl_Activo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.Image = global::WASSTD.Properties.Resources.book_icon_16;
            this.label21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label21.Location = new System.Drawing.Point(7, 56);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(115, 35);
            this.label21.TabIndex = 0;
            this.label21.Text = "Tipo de Trámite:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Finalizado
            // 
            this.lbl_Finalizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Finalizado.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Finalizado.Image = global::WASSTD.Properties.Resources.on_off_icon_16;
            this.lbl_Finalizado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Finalizado.Location = new System.Drawing.Point(235, 16);
            this.lbl_Finalizado.Name = "lbl_Finalizado";
            this.lbl_Finalizado.Size = new System.Drawing.Size(154, 35);
            this.lbl_Finalizado.TabIndex = 61;
            this.lbl_Finalizado.Text = "FINALIZADO";
            this.lbl_Finalizado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_DE_BAJA
            // 
            this.lbl_DE_BAJA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DE_BAJA.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_DE_BAJA.Image = global::WASSTD.Properties.Resources.on_off_icon_16;
            this.lbl_DE_BAJA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_DE_BAJA.Location = new System.Drawing.Point(272, 16);
            this.lbl_DE_BAJA.Name = "lbl_DE_BAJA";
            this.lbl_DE_BAJA.Size = new System.Drawing.Size(117, 35);
            this.lbl_DE_BAJA.TabIndex = 66;
            this.lbl_DE_BAJA.Text = "DE BAJA";
            this.lbl_DE_BAJA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmTramite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 666);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTramite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trámite";
            this.Load += new System.EventHandler(this.FrmTramite_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_sexo.ResumeLayout(false);
            this.grp_sexo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos_detalles)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.GroupBox grp_sexo;
        private System.Windows.Forms.Label lb_sexo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_tipodoc;
        private System.Windows.Forms.Label lb_fechanacimiento;
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.Label lb_nombreapellido;
        private System.Windows.Forms.Label lbl_Sexo;
        private System.Windows.Forms.Label lbl_ClaveFiscal;
        private System.Windows.Forms.Label lbl_NombreyApellido;
        private System.Windows.Forms.Label lbl_FechaNacimiento;
        private System.Windows.Forms.Label lbl_TipoDocumento;
        private System.Windows.Forms.Label lbl_TipoPersona;
        private System.Windows.Forms.Label lbl_NumeroDoc;
        private System.Windows.Forms.Label lbl_DebeSeleccionar;
        private System.Windows.Forms.Button btn_seleccionarPersona;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_datos_detalles;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Button btn_AñadirDetalle;
        private System.Windows.Forms.Button btn_CrearInforme;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btn_RealizarCalculo;
        private System.Windows.Forms.Button btn_RecordatorioVanina;
        private System.Windows.Forms.Button btn_VerCalculosAnteriores;
        private System.Windows.Forms.Button btn_NotificarCliente;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbl_Activo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Finalizado;
        private System.Windows.Forms.Label lbl_UltimoMovimiento;
        private System.Windows.Forms.TextBox txt_nro_tramite;
        private System.Windows.Forms.ComboBox cmb_tipos_tramites;
        private System.Windows.Forms.MaskedTextBox txt_fecha_Alta;
        private System.Windows.Forms.MaskedTextBox txt_Ultimo_Movimiento;
        private System.Windows.Forms.MaskedTextBox txt_Fecha_Del_Detalle;
        private System.Windows.Forms.Label lbl_Fecha_Del_Detalle;
        private System.Windows.Forms.Label lbl_DE_BAJA;
    }
}