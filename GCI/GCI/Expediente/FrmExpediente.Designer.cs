namespace GCI
{
    partial class FrmExpediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpediente));
            this.lb_numero_expediente = new System.Windows.Forms.Label();
            this.lb_estado = new System.Windows.Forms.Label();
            this.lb_estado_expediente = new System.Windows.Forms.Label();
            this.gb_cabezera = new System.Windows.Forms.GroupBox();
            this.lb_numero_expte = new System.Windows.Forms.Label();
            this.lb_tipo_expediente = new System.Windows.Forms.Label();
            this.lb_tarea_OI = new System.Windows.Forms.Label();
            this.txt_comitente = new System.Windows.Forms.TextBox();
            this.gb_liquidacion_OI = new System.Windows.Forms.GroupBox();
            this.dgv_liquidaciones_OI = new System.Windows.Forms.DataGridView();
            this.gb_fechas = new System.Windows.Forms.GroupBox();
            this.dtp_fecha_pago = new System.Windows.Forms.DateTimePicker();
            this.lb_fecha_pago = new System.Windows.Forms.Label();
            this.dtp_fecha_devolución = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_recepcion = new System.Windows.Forms.DateTimePicker();
            this.lb_fecha_recepcion = new System.Windows.Forms.Label();
            this.lb_fecha_aprobación = new System.Windows.Forms.Label();
            this.lb_fecha_devolución = new System.Windows.Forms.Label();
            this.dtp_fecha_aprobacion = new System.Windows.Forms.DateTimePicker();
            this.gb_totales = new System.Windows.Forms.GroupBox();
            this.txt_total_aportes = new System.Windows.Forms.TextBox();
            this.lb_total_aportes = new System.Windows.Forms.Label();
            this.txt_aportes_a_caja = new System.Windows.Forms.TextBox();
            this.lb_aportes_a_caja = new System.Windows.Forms.Label();
            this.txt_aportes_al_cie = new System.Windows.Forms.TextBox();
            this.lb_aporte_al_cie = new System.Windows.Forms.Label();
            this.txt_total_a_liquidar = new System.Windows.Forms.TextBox();
            this.lb_total_a_liquidar = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.grp_acciones = new System.Windows.Forms.GroupBox();
            this.btn_liquidar = new System.Windows.Forms.Button();
            this.gb_profesionales = new System.Windows.Forms.GroupBox();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dgv_profesionales = new System.Windows.Forms.DataGridView();
            this.nud_monto_obra_OI = new System.Windows.Forms.NumericUpDown();
            this.tab_expedientes = new System.Windows.Forms.TabControl();
            this.tb_datos = new System.Windows.Forms.TabPage();
            this.gb_comitente = new System.Windows.Forms.GroupBox();
            this.btn_seleccionar_comitente = new System.Windows.Forms.Button();
            this.tb_OI = new System.Windows.Forms.TabPage();
            this.chk_aportes = new System.Windows.Forms.CheckBox();
            this.gb_tareas_a_liquidar = new System.Windows.Forms.GroupBox();
            this.chk_direccion_de_la_obra = new System.Windows.Forms.CheckBox();
            this.chk_representacion_tecnica = new System.Windows.Forms.CheckBox();
            this.chk_trámites = new System.Windows.Forms.CheckBox();
            this.chk_administracion = new System.Windows.Forms.CheckBox();
            this.chk_conduccion_tecnica = new System.Windows.Forms.CheckBox();
            this.chk_proyecto = new System.Windows.Forms.CheckBox();
            this.chk_proyecto_sin_anteproyecto = new System.Windows.Forms.CheckBox();
            this.chk_anteproyecto = new System.Windows.Forms.CheckBox();
            this.cmb_tareas_OI = new System.Windows.Forms.ComboBox();
            this.lb_monto_obra = new System.Windows.Forms.Label();
            this.tb_FE = new System.Windows.Forms.TabPage();
            this.cmb_tareas_fe = new System.Windows.Forms.ComboBox();
            this.lb_tareas_fe = new System.Windows.Forms.Label();
            this.gb_liquidacion_FE = new System.Windows.Forms.GroupBox();
            this.dgv_liquidaciones_FE = new System.Windows.Forms.DataGridView();
            this.gb_datos_liquidacion_FE = new System.Windows.Forms.GroupBox();
            this.lb_num_motores_FE = new System.Windows.Forms.Label();
            this.nud_num_motores_FE = new System.Windows.Forms.NumericUpDown();
            this.lb_num_bocas_FE = new System.Windows.Forms.Label();
            this.nud_num_bocas_FE = new System.Windows.Forms.NumericUpDown();
            this.lb_num_hp_FE = new System.Windows.Forms.Label();
            this.nud_num_hp_FE = new System.Windows.Forms.NumericUpDown();
            this.gb_dias_FE = new System.Windows.Forms.GroupBox();
            this.lb_dias_campo_FE = new System.Windows.Forms.Label();
            this.lb_dias_gabinete_FE = new System.Windows.Forms.Label();
            this.nud_dias_gabinete_FE = new System.Windows.Forms.NumericUpDown();
            this.nud_dias_campo_FE = new System.Windows.Forms.NumericUpDown();
            this.tab_HM = new System.Windows.Forms.TabPage();
            this.cmb_tareas_hm = new System.Windows.Forms.ComboBox();
            this.lb_tarea_hm = new System.Windows.Forms.Label();
            this.gb_liquidacion_HM = new System.Windows.Forms.GroupBox();
            this.dgv_liquidaciones_HM = new System.Windows.Forms.DataGridView();
            this.gb_dias_HM = new System.Windows.Forms.GroupBox();
            this.lb_dias_campo_HM = new System.Windows.Forms.Label();
            this.lb_dias_gabinete_HM = new System.Windows.Forms.Label();
            this.nud_dias_gabinete_HM = new System.Windows.Forms.NumericUpDown();
            this.nud_dias_campo_HM = new System.Windows.Forms.NumericUpDown();
            this.gb_cabezera.SuspendLayout();
            this.gb_liquidacion_OI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liquidaciones_OI)).BeginInit();
            this.gb_fechas.SuspendLayout();
            this.gb_totales.SuspendLayout();
            this.grp_acciones.SuspendLayout();
            this.gb_profesionales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_profesionales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_monto_obra_OI)).BeginInit();
            this.tab_expedientes.SuspendLayout();
            this.tb_datos.SuspendLayout();
            this.gb_comitente.SuspendLayout();
            this.tb_OI.SuspendLayout();
            this.gb_tareas_a_liquidar.SuspendLayout();
            this.tb_FE.SuspendLayout();
            this.gb_liquidacion_FE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liquidaciones_FE)).BeginInit();
            this.gb_datos_liquidacion_FE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_num_motores_FE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_num_bocas_FE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_num_hp_FE)).BeginInit();
            this.gb_dias_FE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dias_gabinete_FE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dias_campo_FE)).BeginInit();
            this.tab_HM.SuspendLayout();
            this.gb_liquidacion_HM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liquidaciones_HM)).BeginInit();
            this.gb_dias_HM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dias_gabinete_HM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dias_campo_HM)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_numero_expediente
            // 
            this.lb_numero_expediente.AutoSize = true;
            this.lb_numero_expediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numero_expediente.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_numero_expediente.Location = new System.Drawing.Point(112, 16);
            this.lb_numero_expediente.Name = "lb_numero_expediente";
            this.lb_numero_expediente.Size = new System.Drawing.Size(85, 24);
            this.lb_numero_expediente.TabIndex = 0;
            this.lb_numero_expediente.Text = "Nº Expte";
            // 
            // lb_estado
            // 
            this.lb_estado.Image = global::GCI.Properties.Resources.chart_bar_icon_16;
            this.lb_estado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_estado.Location = new System.Drawing.Point(736, 13);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(79, 35);
            this.lb_estado.TabIndex = 1;
            this.lb_estado.Text = "Estado:";
            this.lb_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_estado_expediente
            // 
            this.lb_estado_expediente.AutoSize = true;
            this.lb_estado_expediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_estado_expediente.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_estado_expediente.Location = new System.Drawing.Point(875, 16);
            this.lb_estado_expediente.Name = "lb_estado_expediente";
            this.lb_estado_expediente.Size = new System.Drawing.Size(68, 24);
            this.lb_estado_expediente.TabIndex = 2;
            this.lb_estado_expediente.Text = "Estado";
            // 
            // gb_cabezera
            // 
            this.gb_cabezera.BackColor = System.Drawing.Color.Transparent;
            this.gb_cabezera.Controls.Add(this.lb_numero_expte);
            this.gb_cabezera.Controls.Add(this.lb_tipo_expediente);
            this.gb_cabezera.Controls.Add(this.lb_numero_expediente);
            this.gb_cabezera.Controls.Add(this.lb_estado);
            this.gb_cabezera.Controls.Add(this.lb_estado_expediente);
            this.gb_cabezera.Location = new System.Drawing.Point(17, 1);
            this.gb_cabezera.Name = "gb_cabezera";
            this.gb_cabezera.Size = new System.Drawing.Size(968, 56);
            this.gb_cabezera.TabIndex = 3;
            this.gb_cabezera.TabStop = false;
            this.gb_cabezera.Text = "Cabezara";
            // 
            // lb_numero_expte
            // 
            this.lb_numero_expte.Image = global::GCI.Properties.Resources.page_layout_icon_16;
            this.lb_numero_expte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_numero_expte.Location = new System.Drawing.Point(7, 13);
            this.lb_numero_expte.Name = "lb_numero_expte";
            this.lb_numero_expte.Size = new System.Drawing.Size(73, 35);
            this.lb_numero_expte.TabIndex = 4;
            this.lb_numero_expte.Text = "Numero:";
            this.lb_numero_expte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_tipo_expediente
            // 
            this.lb_tipo_expediente.AutoSize = true;
            this.lb_tipo_expediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tipo_expediente.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_tipo_expediente.Location = new System.Drawing.Point(419, 13);
            this.lb_tipo_expediente.Name = "lb_tipo_expediente";
            this.lb_tipo_expediente.Size = new System.Drawing.Size(155, 24);
            this.lb_tipo_expediente.TabIndex = 3;
            this.lb_tipo_expediente.Text = "Tipo_Expediente";
            // 
            // lb_tarea_OI
            // 
            this.lb_tarea_OI.Image = global::GCI.Properties.Resources.wrench_plus_2_icon_16;
            this.lb_tarea_OI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_tarea_OI.Location = new System.Drawing.Point(292, 7);
            this.lb_tarea_OI.Name = "lb_tarea_OI";
            this.lb_tarea_OI.Size = new System.Drawing.Size(72, 35);
            this.lb_tarea_OI.TabIndex = 16;
            this.lb_tarea_OI.Text = "Tarea:";
            this.lb_tarea_OI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_comitente
            // 
            this.txt_comitente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_comitente.Location = new System.Drawing.Point(6, 24);
            this.txt_comitente.Name = "txt_comitente";
            this.txt_comitente.Size = new System.Drawing.Size(475, 20);
            this.txt_comitente.TabIndex = 11;
            // 
            // gb_liquidacion_OI
            // 
            this.gb_liquidacion_OI.Controls.Add(this.dgv_liquidaciones_OI);
            this.gb_liquidacion_OI.Location = new System.Drawing.Point(6, 41);
            this.gb_liquidacion_OI.Name = "gb_liquidacion_OI";
            this.gb_liquidacion_OI.Size = new System.Drawing.Size(698, 177);
            this.gb_liquidacion_OI.TabIndex = 11;
            this.gb_liquidacion_OI.TabStop = false;
            this.gb_liquidacion_OI.Text = "Liquidación";
            // 
            // dgv_liquidaciones_OI
            // 
            this.dgv_liquidaciones_OI.AllowUserToAddRows = false;
            this.dgv_liquidaciones_OI.AllowUserToDeleteRows = false;
            this.dgv_liquidaciones_OI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_liquidaciones_OI.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgv_liquidaciones_OI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_liquidaciones_OI.Location = new System.Drawing.Point(10, 19);
            this.dgv_liquidaciones_OI.Name = "dgv_liquidaciones_OI";
            this.dgv_liquidaciones_OI.ReadOnly = true;
            this.dgv_liquidaciones_OI.Size = new System.Drawing.Size(678, 139);
            this.dgv_liquidaciones_OI.TabIndex = 0;
            // 
            // gb_fechas
            // 
            this.gb_fechas.Controls.Add(this.dtp_fecha_pago);
            this.gb_fechas.Controls.Add(this.lb_fecha_pago);
            this.gb_fechas.Controls.Add(this.dtp_fecha_devolución);
            this.gb_fechas.Controls.Add(this.dtp_fecha_recepcion);
            this.gb_fechas.Controls.Add(this.lb_fecha_recepcion);
            this.gb_fechas.Controls.Add(this.lb_fecha_aprobación);
            this.gb_fechas.Controls.Add(this.lb_fecha_devolución);
            this.gb_fechas.Controls.Add(this.dtp_fecha_aprobacion);
            this.gb_fechas.Location = new System.Drawing.Point(657, 6);
            this.gb_fechas.Name = "gb_fechas";
            this.gb_fechas.Size = new System.Drawing.Size(297, 227);
            this.gb_fechas.TabIndex = 12;
            this.gb_fechas.TabStop = false;
            this.gb_fechas.Text = "Fechas";
            // 
            // dtp_fecha_pago
            // 
            this.dtp_fecha_pago.Location = new System.Drawing.Point(12, 144);
            this.dtp_fecha_pago.Name = "dtp_fecha_pago";
            this.dtp_fecha_pago.ShowCheckBox = true;
            this.dtp_fecha_pago.Size = new System.Drawing.Size(276, 20);
            this.dtp_fecha_pago.TabIndex = 7;
            this.dtp_fecha_pago.Value = new System.DateTime(2013, 1, 30, 12, 54, 48, 0);
            // 
            // lb_fecha_pago
            // 
            this.lb_fecha_pago.Image = global::GCI.Properties.Resources.wallet_icon_16;
            this.lb_fecha_pago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_fecha_pago.Location = new System.Drawing.Point(9, 121);
            this.lb_fecha_pago.Name = "lb_fecha_pago";
            this.lb_fecha_pago.Size = new System.Drawing.Size(107, 20);
            this.lb_fecha_pago.TabIndex = 6;
            this.lb_fecha_pago.Text = "Pago:";
            this.lb_fecha_pago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_fecha_devolución
            // 
            this.dtp_fecha_devolución.Location = new System.Drawing.Point(12, 191);
            this.dtp_fecha_devolución.Name = "dtp_fecha_devolución";
            this.dtp_fecha_devolución.ShowCheckBox = true;
            this.dtp_fecha_devolución.Size = new System.Drawing.Size(276, 20);
            this.dtp_fecha_devolución.TabIndex = 5;
            this.dtp_fecha_devolución.Value = new System.DateTime(2013, 1, 30, 12, 54, 48, 0);
            this.dtp_fecha_devolución.ValueChanged += new System.EventHandler(this.dtp_fecha_devolución_ValueChanged);
            // 
            // dtp_fecha_recepcion
            // 
            this.dtp_fecha_recepcion.Location = new System.Drawing.Point(12, 47);
            this.dtp_fecha_recepcion.Name = "dtp_fecha_recepcion";
            this.dtp_fecha_recepcion.ShowCheckBox = true;
            this.dtp_fecha_recepcion.Size = new System.Drawing.Size(276, 20);
            this.dtp_fecha_recepcion.TabIndex = 1;
            this.dtp_fecha_recepcion.Value = new System.DateTime(2013, 1, 30, 12, 54, 33, 0);
            // 
            // lb_fecha_recepcion
            // 
            this.lb_fecha_recepcion.Image = global::GCI.Properties.Resources.arrow_bottom_icon_161;
            this.lb_fecha_recepcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_fecha_recepcion.Location = new System.Drawing.Point(9, 16);
            this.lb_fecha_recepcion.Name = "lb_fecha_recepcion";
            this.lb_fecha_recepcion.Size = new System.Drawing.Size(107, 20);
            this.lb_fecha_recepcion.TabIndex = 0;
            this.lb_fecha_recepcion.Text = "Recepción:";
            this.lb_fecha_recepcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_fecha_aprobación
            // 
            this.lb_fecha_aprobación.Image = global::GCI.Properties.Resources.checkmark_icon_16;
            this.lb_fecha_aprobación.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_fecha_aprobación.Location = new System.Drawing.Point(9, 75);
            this.lb_fecha_aprobación.Name = "lb_fecha_aprobación";
            this.lb_fecha_aprobación.Size = new System.Drawing.Size(107, 20);
            this.lb_fecha_aprobación.TabIndex = 2;
            this.lb_fecha_aprobación.Text = "Aprobación:";
            this.lb_fecha_aprobación.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_fecha_devolución
            // 
            this.lb_fecha_devolución.Image = global::GCI.Properties.Resources.arrow_right_icon_16;
            this.lb_fecha_devolución.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_fecha_devolución.Location = new System.Drawing.Point(9, 168);
            this.lb_fecha_devolución.Name = "lb_fecha_devolución";
            this.lb_fecha_devolución.Size = new System.Drawing.Size(107, 20);
            this.lb_fecha_devolución.TabIndex = 4;
            this.lb_fecha_devolución.Text = "Devolución:";
            this.lb_fecha_devolución.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_fecha_aprobacion
            // 
            this.dtp_fecha_aprobacion.Location = new System.Drawing.Point(12, 98);
            this.dtp_fecha_aprobacion.Name = "dtp_fecha_aprobacion";
            this.dtp_fecha_aprobacion.ShowCheckBox = true;
            this.dtp_fecha_aprobacion.Size = new System.Drawing.Size(276, 20);
            this.dtp_fecha_aprobacion.TabIndex = 3;
            this.dtp_fecha_aprobacion.Value = new System.DateTime(2013, 1, 30, 12, 54, 41, 0);
            this.dtp_fecha_aprobacion.ValueChanged += new System.EventHandler(this.dtp_fecha_aprobacion_ValueChanged);
            // 
            // gb_totales
            // 
            this.gb_totales.BackColor = System.Drawing.Color.Transparent;
            this.gb_totales.Controls.Add(this.txt_total_aportes);
            this.gb_totales.Controls.Add(this.lb_total_aportes);
            this.gb_totales.Controls.Add(this.txt_aportes_a_caja);
            this.gb_totales.Controls.Add(this.lb_aportes_a_caja);
            this.gb_totales.Controls.Add(this.txt_aportes_al_cie);
            this.gb_totales.Controls.Add(this.lb_aporte_al_cie);
            this.gb_totales.Controls.Add(this.txt_total_a_liquidar);
            this.gb_totales.Controls.Add(this.lb_total_a_liquidar);
            this.gb_totales.Location = new System.Drawing.Point(17, 334);
            this.gb_totales.Name = "gb_totales";
            this.gb_totales.Size = new System.Drawing.Size(968, 52);
            this.gb_totales.TabIndex = 22;
            this.gb_totales.TabStop = false;
            this.gb_totales.Text = "Totales";
            // 
            // txt_total_aportes
            // 
            this.txt_total_aportes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_total_aportes.Location = new System.Drawing.Point(856, 19);
            this.txt_total_aportes.Name = "txt_total_aportes";
            this.txt_total_aportes.Size = new System.Drawing.Size(106, 20);
            this.txt_total_aportes.TabIndex = 29;
            // 
            // lb_total_aportes
            // 
            this.lb_total_aportes.Image = ((System.Drawing.Image)(resources.GetObject("lb_total_aportes.Image")));
            this.lb_total_aportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_total_aportes.Location = new System.Drawing.Point(736, 11);
            this.lb_total_aportes.Name = "lb_total_aportes";
            this.lb_total_aportes.Size = new System.Drawing.Size(114, 35);
            this.lb_total_aportes.TabIndex = 28;
            this.lb_total_aportes.Text = "Total de aportes:";
            this.lb_total_aportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_aportes_a_caja
            // 
            this.txt_aportes_a_caja.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_aportes_a_caja.Location = new System.Drawing.Point(615, 19);
            this.txt_aportes_a_caja.Name = "txt_aportes_a_caja";
            this.txt_aportes_a_caja.Size = new System.Drawing.Size(106, 20);
            this.txt_aportes_a_caja.TabIndex = 27;
            // 
            // lb_aportes_a_caja
            // 
            this.lb_aportes_a_caja.Image = ((System.Drawing.Image)(resources.GetObject("lb_aportes_a_caja.Image")));
            this.lb_aportes_a_caja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_aportes_a_caja.Location = new System.Drawing.Point(476, 11);
            this.lb_aportes_a_caja.Name = "lb_aportes_a_caja";
            this.lb_aportes_a_caja.Size = new System.Drawing.Size(133, 35);
            this.lb_aportes_a_caja.TabIndex = 26;
            this.lb_aportes_a_caja.Text = "Aportes al a la Caja:";
            this.lb_aportes_a_caja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_aportes_al_cie
            // 
            this.txt_aportes_al_cie.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_aportes_al_cie.Location = new System.Drawing.Point(362, 19);
            this.txt_aportes_al_cie.Name = "txt_aportes_al_cie";
            this.txt_aportes_al_cie.Size = new System.Drawing.Size(108, 20);
            this.txt_aportes_al_cie.TabIndex = 25;
            // 
            // lb_aporte_al_cie
            // 
            this.lb_aporte_al_cie.Image = ((System.Drawing.Image)(resources.GetObject("lb_aporte_al_cie.Image")));
            this.lb_aporte_al_cie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_aporte_al_cie.Location = new System.Drawing.Point(233, 11);
            this.lb_aporte_al_cie.Name = "lb_aporte_al_cie";
            this.lb_aporte_al_cie.Size = new System.Drawing.Size(123, 35);
            this.lb_aporte_al_cie.TabIndex = 24;
            this.lb_aporte_al_cie.Text = "Aportes al Colegio:";
            this.lb_aporte_al_cie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_total_a_liquidar
            // 
            this.txt_total_a_liquidar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_total_a_liquidar.Location = new System.Drawing.Point(116, 19);
            this.txt_total_a_liquidar.Name = "txt_total_a_liquidar";
            this.txt_total_a_liquidar.Size = new System.Drawing.Size(111, 20);
            this.txt_total_a_liquidar.TabIndex = 23;
            // 
            // lb_total_a_liquidar
            // 
            this.lb_total_a_liquidar.Image = ((System.Drawing.Image)(resources.GetObject("lb_total_a_liquidar.Image")));
            this.lb_total_a_liquidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_total_a_liquidar.Location = new System.Drawing.Point(7, 11);
            this.lb_total_a_liquidar.Name = "lb_total_a_liquidar";
            this.lb_total_a_liquidar.Size = new System.Drawing.Size(103, 35);
            this.lb_total_a_liquidar.TabIndex = 22;
            this.lb_total_a_liquidar.Text = "Total a liquidar:";
            this.lb_total_a_liquidar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::GCI.Properties.Resources.cancel_icon_16;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(887, 10);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 35);
            this.btn_cancelar.TabIndex = 23;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::GCI.Properties.Resources.save_icon_16;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(806, 10);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 35);
            this.btn_guardar.TabIndex = 24;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // grp_acciones
            // 
            this.grp_acciones.BackColor = System.Drawing.Color.Transparent;
            this.grp_acciones.Controls.Add(this.btn_guardar);
            this.grp_acciones.Controls.Add(this.btn_liquidar);
            this.grp_acciones.Controls.Add(this.btn_cancelar);
            this.grp_acciones.Location = new System.Drawing.Point(17, 392);
            this.grp_acciones.Name = "grp_acciones";
            this.grp_acciones.Size = new System.Drawing.Size(968, 58);
            this.grp_acciones.TabIndex = 27;
            this.grp_acciones.TabStop = false;
            this.grp_acciones.Text = "Acciones";
            // 
            // btn_liquidar
            // 
            this.btn_liquidar.BackColor = System.Drawing.Color.Transparent;
            this.btn_liquidar.Image = global::GCI.Properties.Resources.money_icon_16;
            this.btn_liquidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_liquidar.Location = new System.Drawing.Point(717, 10);
            this.btn_liquidar.Name = "btn_liquidar";
            this.btn_liquidar.Size = new System.Drawing.Size(83, 35);
            this.btn_liquidar.TabIndex = 0;
            this.btn_liquidar.Text = "Liquidar";
            this.btn_liquidar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_liquidar.UseVisualStyleBackColor = false;
            this.btn_liquidar.Click += new System.EventHandler(this.btn_liquidar_Click);
            // 
            // gb_profesionales
            // 
            this.gb_profesionales.Controls.Add(this.btn_quitar);
            this.gb_profesionales.Controls.Add(this.btn_agregar);
            this.gb_profesionales.Controls.Add(this.dgv_profesionales);
            this.gb_profesionales.Location = new System.Drawing.Point(16, 6);
            this.gb_profesionales.Name = "gb_profesionales";
            this.gb_profesionales.Size = new System.Drawing.Size(635, 161);
            this.gb_profesionales.TabIndex = 28;
            this.gb_profesionales.TabStop = false;
            this.gb_profesionales.Text = "Profesionales";
            // 
            // btn_quitar
            // 
            this.btn_quitar.Image = global::GCI.Properties.Resources.doc_delete_icon_16;
            this.btn_quitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quitar.Location = new System.Drawing.Point(554, 60);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(75, 35);
            this.btn_quitar.TabIndex = 2;
            this.btn_quitar.Text = "Quitar";
            this.btn_quitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Image = global::GCI.Properties.Resources.doc_new_icon_16;
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.Location = new System.Drawing.Point(554, 19);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 35);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dgv_profesionales
            // 
            this.dgv_profesionales.AllowUserToAddRows = false;
            this.dgv_profesionales.AllowUserToDeleteRows = false;
            this.dgv_profesionales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_profesionales.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgv_profesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_profesionales.Location = new System.Drawing.Point(10, 19);
            this.dgv_profesionales.Name = "dgv_profesionales";
            this.dgv_profesionales.ReadOnly = true;
            this.dgv_profesionales.Size = new System.Drawing.Size(538, 126);
            this.dgv_profesionales.TabIndex = 0;
            // 
            // nud_monto_obra_OI
            // 
            this.nud_monto_obra_OI.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nud_monto_obra_OI.Location = new System.Drawing.Point(112, 15);
            this.nud_monto_obra_OI.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.nud_monto_obra_OI.Name = "nud_monto_obra_OI";
            this.nud_monto_obra_OI.Size = new System.Drawing.Size(164, 20);
            this.nud_monto_obra_OI.TabIndex = 16;
            // 
            // tab_expedientes
            // 
            this.tab_expedientes.Controls.Add(this.tb_datos);
            this.tab_expedientes.Controls.Add(this.tb_OI);
            this.tab_expedientes.Controls.Add(this.tb_FE);
            this.tab_expedientes.Controls.Add(this.tab_HM);
            this.tab_expedientes.Location = new System.Drawing.Point(17, 63);
            this.tab_expedientes.Name = "tab_expedientes";
            this.tab_expedientes.SelectedIndex = 0;
            this.tab_expedientes.Size = new System.Drawing.Size(966, 265);
            this.tab_expedientes.TabIndex = 30;
            // 
            // tb_datos
            // 
            this.tb_datos.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.tb_datos.Controls.Add(this.gb_comitente);
            this.tb_datos.Controls.Add(this.gb_fechas);
            this.tb_datos.Controls.Add(this.gb_profesionales);
            this.tb_datos.Location = new System.Drawing.Point(4, 22);
            this.tb_datos.Name = "tb_datos";
            this.tb_datos.Padding = new System.Windows.Forms.Padding(3);
            this.tb_datos.Size = new System.Drawing.Size(958, 239);
            this.tb_datos.TabIndex = 0;
            this.tb_datos.Text = "Datos principales";
            this.tb_datos.UseVisualStyleBackColor = true;
            // 
            // gb_comitente
            // 
            this.gb_comitente.Controls.Add(this.btn_seleccionar_comitente);
            this.gb_comitente.Controls.Add(this.txt_comitente);
            this.gb_comitente.Location = new System.Drawing.Point(16, 176);
            this.gb_comitente.Name = "gb_comitente";
            this.gb_comitente.Size = new System.Drawing.Size(635, 57);
            this.gb_comitente.TabIndex = 31;
            this.gb_comitente.TabStop = false;
            this.gb_comitente.Text = "Comitente";
            // 
            // btn_seleccionar_comitente
            // 
            this.btn_seleccionar_comitente.Image = global::GCI.Properties.Resources.checkbox_checked_icon_16;
            this.btn_seleccionar_comitente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_seleccionar_comitente.Location = new System.Drawing.Point(487, 16);
            this.btn_seleccionar_comitente.Name = "btn_seleccionar_comitente";
            this.btn_seleccionar_comitente.Size = new System.Drawing.Size(142, 35);
            this.btn_seleccionar_comitente.TabIndex = 4;
            this.btn_seleccionar_comitente.Text = "Seleccionar comitente";
            this.btn_seleccionar_comitente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_seleccionar_comitente.UseVisualStyleBackColor = true;
            this.btn_seleccionar_comitente.Click += new System.EventHandler(this.btn_seleccionar_comitente_Click);
            // 
            // tb_OI
            // 
            this.tb_OI.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.tb_OI.Controls.Add(this.chk_aportes);
            this.tb_OI.Controls.Add(this.gb_tareas_a_liquidar);
            this.tb_OI.Controls.Add(this.cmb_tareas_OI);
            this.tb_OI.Controls.Add(this.lb_monto_obra);
            this.tb_OI.Controls.Add(this.lb_tarea_OI);
            this.tb_OI.Controls.Add(this.gb_liquidacion_OI);
            this.tb_OI.Controls.Add(this.nud_monto_obra_OI);
            this.tb_OI.Location = new System.Drawing.Point(4, 22);
            this.tb_OI.Name = "tb_OI";
            this.tb_OI.Padding = new System.Windows.Forms.Padding(3);
            this.tb_OI.Size = new System.Drawing.Size(958, 239);
            this.tb_OI.TabIndex = 1;
            this.tb_OI.Text = "Obras de Ingenieria";
            this.tb_OI.UseVisualStyleBackColor = true;
            // 
            // chk_aportes
            // 
            this.chk_aportes.AutoSize = true;
            this.chk_aportes.Location = new System.Drawing.Point(582, 17);
            this.chk_aportes.Name = "chk_aportes";
            this.chk_aportes.Size = new System.Drawing.Size(112, 17);
            this.chk_aportes.TabIndex = 33;
            this.chk_aportes.Text = "Aportes definitivos";
            this.chk_aportes.UseVisualStyleBackColor = true;
            // 
            // gb_tareas_a_liquidar
            // 
            this.gb_tareas_a_liquidar.Controls.Add(this.chk_direccion_de_la_obra);
            this.gb_tareas_a_liquidar.Controls.Add(this.chk_representacion_tecnica);
            this.gb_tareas_a_liquidar.Controls.Add(this.chk_trámites);
            this.gb_tareas_a_liquidar.Controls.Add(this.chk_administracion);
            this.gb_tareas_a_liquidar.Controls.Add(this.chk_conduccion_tecnica);
            this.gb_tareas_a_liquidar.Controls.Add(this.chk_proyecto);
            this.gb_tareas_a_liquidar.Controls.Add(this.chk_proyecto_sin_anteproyecto);
            this.gb_tareas_a_liquidar.Controls.Add(this.chk_anteproyecto);
            this.gb_tareas_a_liquidar.Location = new System.Drawing.Point(710, 15);
            this.gb_tareas_a_liquidar.Name = "gb_tareas_a_liquidar";
            this.gb_tareas_a_liquidar.Size = new System.Drawing.Size(229, 203);
            this.gb_tareas_a_liquidar.TabIndex = 28;
            this.gb_tareas_a_liquidar.TabStop = false;
            this.gb_tareas_a_liquidar.Text = "Tareas a liquidar";
            // 
            // chk_direccion_de_la_obra
            // 
            this.chk_direccion_de_la_obra.AutoSize = true;
            this.chk_direccion_de_la_obra.Location = new System.Drawing.Point(7, 181);
            this.chk_direccion_de_la_obra.Name = "chk_direccion_de_la_obra";
            this.chk_direccion_de_la_obra.Size = new System.Drawing.Size(121, 17);
            this.chk_direccion_de_la_obra.TabIndex = 7;
            this.chk_direccion_de_la_obra.Text = "Dirección de la obra";
            this.chk_direccion_de_la_obra.UseVisualStyleBackColor = true;
            // 
            // chk_representacion_tecnica
            // 
            this.chk_representacion_tecnica.AutoSize = true;
            this.chk_representacion_tecnica.Location = new System.Drawing.Point(7, 158);
            this.chk_representacion_tecnica.Name = "chk_representacion_tecnica";
            this.chk_representacion_tecnica.Size = new System.Drawing.Size(189, 17);
            this.chk_representacion_tecnica.TabIndex = 6;
            this.chk_representacion_tecnica.Text = "Representación técnica de la obra";
            this.chk_representacion_tecnica.UseVisualStyleBackColor = true;
            // 
            // chk_trámites
            // 
            this.chk_trámites.AutoSize = true;
            this.chk_trámites.Location = new System.Drawing.Point(7, 135);
            this.chk_trámites.Name = "chk_trámites";
            this.chk_trámites.Size = new System.Drawing.Size(66, 17);
            this.chk_trámites.TabIndex = 5;
            this.chk_trámites.Text = "Trámites";
            this.chk_trámites.UseVisualStyleBackColor = true;
            // 
            // chk_administracion
            // 
            this.chk_administracion.AutoSize = true;
            this.chk_administracion.Location = new System.Drawing.Point(7, 112);
            this.chk_administracion.Name = "chk_administracion";
            this.chk_administracion.Size = new System.Drawing.Size(199, 17);
            this.chk_administracion.TabIndex = 4;
            this.chk_administracion.Text = "Administración a cargo del comitente";
            this.chk_administracion.UseVisualStyleBackColor = true;
            // 
            // chk_conduccion_tecnica
            // 
            this.chk_conduccion_tecnica.AutoSize = true;
            this.chk_conduccion_tecnica.Location = new System.Drawing.Point(7, 89);
            this.chk_conduccion_tecnica.Name = "chk_conduccion_tecnica";
            this.chk_conduccion_tecnica.Size = new System.Drawing.Size(171, 17);
            this.chk_conduccion_tecnica.TabIndex = 3;
            this.chk_conduccion_tecnica.Text = "Conducción técnica de la obra";
            this.chk_conduccion_tecnica.UseVisualStyleBackColor = true;
            // 
            // chk_proyecto
            // 
            this.chk_proyecto.AutoSize = true;
            this.chk_proyecto.Location = new System.Drawing.Point(7, 66);
            this.chk_proyecto.Name = "chk_proyecto";
            this.chk_proyecto.Size = new System.Drawing.Size(118, 17);
            this.chk_proyecto.TabIndex = 2;
            this.chk_proyecto.Text = "Proyecto de la obra";
            this.chk_proyecto.UseVisualStyleBackColor = true;
            // 
            // chk_proyecto_sin_anteproyecto
            // 
            this.chk_proyecto_sin_anteproyecto.AutoSize = true;
            this.chk_proyecto_sin_anteproyecto.Location = new System.Drawing.Point(7, 43);
            this.chk_proyecto_sin_anteproyecto.Name = "chk_proyecto_sin_anteproyecto";
            this.chk_proyecto_sin_anteproyecto.Size = new System.Drawing.Size(149, 17);
            this.chk_proyecto_sin_anteproyecto.TabIndex = 1;
            this.chk_proyecto_sin_anteproyecto.Text = "Proyecto sin anteproyecto";
            this.chk_proyecto_sin_anteproyecto.UseVisualStyleBackColor = true;
            // 
            // chk_anteproyecto
            // 
            this.chk_anteproyecto.AutoSize = true;
            this.chk_anteproyecto.Location = new System.Drawing.Point(7, 20);
            this.chk_anteproyecto.Name = "chk_anteproyecto";
            this.chk_anteproyecto.Size = new System.Drawing.Size(89, 17);
            this.chk_anteproyecto.TabIndex = 0;
            this.chk_anteproyecto.Text = "Anteproyecto";
            this.chk_anteproyecto.UseVisualStyleBackColor = true;
            // 
            // cmb_tareas_OI
            // 
            this.cmb_tareas_OI.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_tareas_OI.FormattingEnabled = true;
            this.cmb_tareas_OI.Location = new System.Drawing.Point(381, 14);
            this.cmb_tareas_OI.Name = "cmb_tareas_OI";
            this.cmb_tareas_OI.Size = new System.Drawing.Size(189, 21);
            this.cmb_tareas_OI.TabIndex = 17;
            this.cmb_tareas_OI.SelectedIndexChanged += new System.EventHandler(this.cmb_tareas_OI_SelectedIndexChanged);
            // 
            // lb_monto_obra
            // 
            this.lb_monto_obra.Image = global::GCI.Properties.Resources.money_icon_16;
            this.lb_monto_obra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_monto_obra.Location = new System.Drawing.Point(6, 7);
            this.lb_monto_obra.Name = "lb_monto_obra";
            this.lb_monto_obra.Size = new System.Drawing.Size(100, 35);
            this.lb_monto_obra.TabIndex = 12;
            this.lb_monto_obra.Text = "Monto de Obra";
            this.lb_monto_obra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_FE
            // 
            this.tb_FE.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.tb_FE.Controls.Add(this.cmb_tareas_fe);
            this.tb_FE.Controls.Add(this.lb_tareas_fe);
            this.tb_FE.Controls.Add(this.gb_liquidacion_FE);
            this.tb_FE.Controls.Add(this.gb_datos_liquidacion_FE);
            this.tb_FE.Controls.Add(this.gb_dias_FE);
            this.tb_FE.Location = new System.Drawing.Point(4, 22);
            this.tb_FE.Name = "tb_FE";
            this.tb_FE.Padding = new System.Windows.Forms.Padding(3);
            this.tb_FE.Size = new System.Drawing.Size(958, 239);
            this.tb_FE.TabIndex = 2;
            this.tb_FE.Text = "Fuerza Electromotriz";
            this.tb_FE.UseVisualStyleBackColor = true;
            // 
            // cmb_tareas_fe
            // 
            this.cmb_tareas_fe.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_tareas_fe.FormattingEnabled = true;
            this.cmb_tareas_fe.Location = new System.Drawing.Point(110, 24);
            this.cmb_tareas_fe.Name = "cmb_tareas_fe";
            this.cmb_tareas_fe.Size = new System.Drawing.Size(189, 21);
            this.cmb_tareas_fe.TabIndex = 28;
            this.cmb_tareas_fe.SelectedIndexChanged += new System.EventHandler(this.cmb_tareas_fe_SelectedIndexChanged);
            // 
            // lb_tareas_fe
            // 
            this.lb_tareas_fe.Image = global::GCI.Properties.Resources.wrench_plus_2_icon_16;
            this.lb_tareas_fe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_tareas_fe.Location = new System.Drawing.Point(21, 17);
            this.lb_tareas_fe.Name = "lb_tareas_fe";
            this.lb_tareas_fe.Size = new System.Drawing.Size(72, 35);
            this.lb_tareas_fe.TabIndex = 27;
            this.lb_tareas_fe.Text = "Tarea:";
            this.lb_tareas_fe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gb_liquidacion_FE
            // 
            this.gb_liquidacion_FE.Controls.Add(this.dgv_liquidaciones_FE);
            this.gb_liquidacion_FE.Location = new System.Drawing.Point(18, 75);
            this.gb_liquidacion_FE.Name = "gb_liquidacion_FE";
            this.gb_liquidacion_FE.Size = new System.Drawing.Size(581, 152);
            this.gb_liquidacion_FE.TabIndex = 23;
            this.gb_liquidacion_FE.TabStop = false;
            this.gb_liquidacion_FE.Text = "Liquidación";
            // 
            // dgv_liquidaciones_FE
            // 
            this.dgv_liquidaciones_FE.AllowUserToAddRows = false;
            this.dgv_liquidaciones_FE.AllowUserToDeleteRows = false;
            this.dgv_liquidaciones_FE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_liquidaciones_FE.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgv_liquidaciones_FE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_liquidaciones_FE.Location = new System.Drawing.Point(6, 18);
            this.dgv_liquidaciones_FE.Name = "dgv_liquidaciones_FE";
            this.dgv_liquidaciones_FE.ReadOnly = true;
            this.dgv_liquidaciones_FE.Size = new System.Drawing.Size(554, 124);
            this.dgv_liquidaciones_FE.TabIndex = 0;
            // 
            // gb_datos_liquidacion_FE
            // 
            this.gb_datos_liquidacion_FE.Controls.Add(this.lb_num_motores_FE);
            this.gb_datos_liquidacion_FE.Controls.Add(this.nud_num_motores_FE);
            this.gb_datos_liquidacion_FE.Controls.Add(this.lb_num_bocas_FE);
            this.gb_datos_liquidacion_FE.Controls.Add(this.nud_num_bocas_FE);
            this.gb_datos_liquidacion_FE.Controls.Add(this.lb_num_hp_FE);
            this.gb_datos_liquidacion_FE.Controls.Add(this.nud_num_hp_FE);
            this.gb_datos_liquidacion_FE.Location = new System.Drawing.Point(622, 96);
            this.gb_datos_liquidacion_FE.Name = "gb_datos_liquidacion_FE";
            this.gb_datos_liquidacion_FE.Size = new System.Drawing.Size(330, 131);
            this.gb_datos_liquidacion_FE.TabIndex = 22;
            this.gb_datos_liquidacion_FE.TabStop = false;
            this.gb_datos_liquidacion_FE.Text = "Datos para la liquidación";
            // 
            // lb_num_motores_FE
            // 
            this.lb_num_motores_FE.Image = ((System.Drawing.Image)(resources.GetObject("lb_num_motores_FE.Image")));
            this.lb_num_motores_FE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_num_motores_FE.Location = new System.Drawing.Point(9, 92);
            this.lb_num_motores_FE.Name = "lb_num_motores_FE";
            this.lb_num_motores_FE.Size = new System.Drawing.Size(198, 35);
            this.lb_num_motores_FE.TabIndex = 23;
            this.lb_num_motores_FE.Text = "Número de motores:";
            this.lb_num_motores_FE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nud_num_motores_FE
            // 
            this.nud_num_motores_FE.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nud_num_motores_FE.Location = new System.Drawing.Point(258, 101);
            this.nud_num_motores_FE.Name = "nud_num_motores_FE";
            this.nud_num_motores_FE.Size = new System.Drawing.Size(59, 20);
            this.nud_num_motores_FE.TabIndex = 24;
            this.nud_num_motores_FE.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb_num_bocas_FE
            // 
            this.lb_num_bocas_FE.Image = ((System.Drawing.Image)(resources.GetObject("lb_num_bocas_FE.Image")));
            this.lb_num_bocas_FE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_num_bocas_FE.Location = new System.Drawing.Point(10, 51);
            this.lb_num_bocas_FE.Name = "lb_num_bocas_FE";
            this.lb_num_bocas_FE.Size = new System.Drawing.Size(197, 35);
            this.lb_num_bocas_FE.TabIndex = 21;
            this.lb_num_bocas_FE.Text = "Número de bocas de iluminación:";
            this.lb_num_bocas_FE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nud_num_bocas_FE
            // 
            this.nud_num_bocas_FE.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nud_num_bocas_FE.Location = new System.Drawing.Point(258, 60);
            this.nud_num_bocas_FE.Name = "nud_num_bocas_FE";
            this.nud_num_bocas_FE.Size = new System.Drawing.Size(59, 20);
            this.nud_num_bocas_FE.TabIndex = 22;
            this.nud_num_bocas_FE.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb_num_hp_FE
            // 
            this.lb_num_hp_FE.Image = ((System.Drawing.Image)(resources.GetObject("lb_num_hp_FE.Image")));
            this.lb_num_hp_FE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_num_hp_FE.Location = new System.Drawing.Point(9, 16);
            this.lb_num_hp_FE.Name = "lb_num_hp_FE";
            this.lb_num_hp_FE.Size = new System.Drawing.Size(198, 35);
            this.lb_num_hp_FE.TabIndex = 19;
            this.lb_num_hp_FE.Text = "Número de HP instalados:";
            this.lb_num_hp_FE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nud_num_hp_FE
            // 
            this.nud_num_hp_FE.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nud_num_hp_FE.Location = new System.Drawing.Point(258, 25);
            this.nud_num_hp_FE.Name = "nud_num_hp_FE";
            this.nud_num_hp_FE.Size = new System.Drawing.Size(59, 20);
            this.nud_num_hp_FE.TabIndex = 20;
            this.nud_num_hp_FE.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gb_dias_FE
            // 
            this.gb_dias_FE.Controls.Add(this.lb_dias_campo_FE);
            this.gb_dias_FE.Controls.Add(this.lb_dias_gabinete_FE);
            this.gb_dias_FE.Controls.Add(this.nud_dias_gabinete_FE);
            this.gb_dias_FE.Controls.Add(this.nud_dias_campo_FE);
            this.gb_dias_FE.Location = new System.Drawing.Point(622, 17);
            this.gb_dias_FE.Name = "gb_dias_FE";
            this.gb_dias_FE.Size = new System.Drawing.Size(330, 58);
            this.gb_dias_FE.TabIndex = 21;
            this.gb_dias_FE.TabStop = false;
            this.gb_dias_FE.Text = "Días";
            // 
            // lb_dias_campo_FE
            // 
            this.lb_dias_campo_FE.Image = ((System.Drawing.Image)(resources.GetObject("lb_dias_campo_FE.Image")));
            this.lb_dias_campo_FE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_dias_campo_FE.Location = new System.Drawing.Point(6, 16);
            this.lb_dias_campo_FE.Name = "lb_dias_campo_FE";
            this.lb_dias_campo_FE.Size = new System.Drawing.Size(102, 35);
            this.lb_dias_campo_FE.TabIndex = 17;
            this.lb_dias_campo_FE.Text = "Días de campo:";
            this.lb_dias_campo_FE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_dias_gabinete_FE
            // 
            this.lb_dias_gabinete_FE.Image = ((System.Drawing.Image)(resources.GetObject("lb_dias_gabinete_FE.Image")));
            this.lb_dias_gabinete_FE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_dias_gabinete_FE.Location = new System.Drawing.Point(160, 16);
            this.lb_dias_gabinete_FE.Name = "lb_dias_gabinete_FE";
            this.lb_dias_gabinete_FE.Size = new System.Drawing.Size(119, 35);
            this.lb_dias_gabinete_FE.TabIndex = 19;
            this.lb_dias_gabinete_FE.Text = "Días de gabinete:";
            this.lb_dias_gabinete_FE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nud_dias_gabinete_FE
            // 
            this.nud_dias_gabinete_FE.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nud_dias_gabinete_FE.Location = new System.Drawing.Point(285, 25);
            this.nud_dias_gabinete_FE.Name = "nud_dias_gabinete_FE";
            this.nud_dias_gabinete_FE.Size = new System.Drawing.Size(39, 20);
            this.nud_dias_gabinete_FE.TabIndex = 20;
            this.nud_dias_gabinete_FE.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_dias_campo_FE
            // 
            this.nud_dias_campo_FE.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nud_dias_campo_FE.Location = new System.Drawing.Point(114, 25);
            this.nud_dias_campo_FE.Name = "nud_dias_campo_FE";
            this.nud_dias_campo_FE.Size = new System.Drawing.Size(40, 20);
            this.nud_dias_campo_FE.TabIndex = 18;
            this.nud_dias_campo_FE.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tab_HM
            // 
            this.tab_HM.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.tab_HM.Controls.Add(this.cmb_tareas_hm);
            this.tab_HM.Controls.Add(this.lb_tarea_hm);
            this.tab_HM.Controls.Add(this.gb_liquidacion_HM);
            this.tab_HM.Controls.Add(this.gb_dias_HM);
            this.tab_HM.Location = new System.Drawing.Point(4, 22);
            this.tab_HM.Name = "tab_HM";
            this.tab_HM.Padding = new System.Windows.Forms.Padding(3);
            this.tab_HM.Size = new System.Drawing.Size(958, 239);
            this.tab_HM.TabIndex = 3;
            this.tab_HM.Text = "Honorario Mínimo";
            this.tab_HM.UseVisualStyleBackColor = true;
            // 
            // cmb_tareas_hm
            // 
            this.cmb_tareas_hm.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_tareas_hm.FormattingEnabled = true;
            this.cmb_tareas_hm.Location = new System.Drawing.Point(752, 32);
            this.cmb_tareas_hm.Name = "cmb_tareas_hm";
            this.cmb_tareas_hm.Size = new System.Drawing.Size(189, 21);
            this.cmb_tareas_hm.TabIndex = 26;
            this.cmb_tareas_hm.SelectedIndexChanged += new System.EventHandler(this.cmb_tareas_hm_SelectedIndexChanged);
            // 
            // lb_tarea_hm
            // 
            this.lb_tarea_hm.Image = global::GCI.Properties.Resources.wrench_plus_2_icon_16;
            this.lb_tarea_hm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_tarea_hm.Location = new System.Drawing.Point(663, 25);
            this.lb_tarea_hm.Name = "lb_tarea_hm";
            this.lb_tarea_hm.Size = new System.Drawing.Size(72, 35);
            this.lb_tarea_hm.TabIndex = 25;
            this.lb_tarea_hm.Text = "Tarea:";
            this.lb_tarea_hm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gb_liquidacion_HM
            // 
            this.gb_liquidacion_HM.Controls.Add(this.dgv_liquidaciones_HM);
            this.gb_liquidacion_HM.Location = new System.Drawing.Point(6, 6);
            this.gb_liquidacion_HM.Name = "gb_liquidacion_HM";
            this.gb_liquidacion_HM.Size = new System.Drawing.Size(645, 216);
            this.gb_liquidacion_HM.TabIndex = 24;
            this.gb_liquidacion_HM.TabStop = false;
            this.gb_liquidacion_HM.Text = "Liquidación";
            // 
            // dgv_liquidaciones_HM
            // 
            this.dgv_liquidaciones_HM.AllowUserToAddRows = false;
            this.dgv_liquidaciones_HM.AllowUserToDeleteRows = false;
            this.dgv_liquidaciones_HM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_liquidaciones_HM.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgv_liquidaciones_HM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_liquidaciones_HM.Location = new System.Drawing.Point(13, 19);
            this.dgv_liquidaciones_HM.Name = "dgv_liquidaciones_HM";
            this.dgv_liquidaciones_HM.ReadOnly = true;
            this.dgv_liquidaciones_HM.Size = new System.Drawing.Size(610, 179);
            this.dgv_liquidaciones_HM.TabIndex = 0;
            // 
            // gb_dias_HM
            // 
            this.gb_dias_HM.Controls.Add(this.lb_dias_campo_HM);
            this.gb_dias_HM.Controls.Add(this.lb_dias_gabinete_HM);
            this.gb_dias_HM.Controls.Add(this.nud_dias_gabinete_HM);
            this.gb_dias_HM.Controls.Add(this.nud_dias_campo_HM);
            this.gb_dias_HM.Location = new System.Drawing.Point(657, 74);
            this.gb_dias_HM.Name = "gb_dias_HM";
            this.gb_dias_HM.Size = new System.Drawing.Size(282, 148);
            this.gb_dias_HM.TabIndex = 22;
            this.gb_dias_HM.TabStop = false;
            this.gb_dias_HM.Text = "Días";
            // 
            // lb_dias_campo_HM
            // 
            this.lb_dias_campo_HM.Image = ((System.Drawing.Image)(resources.GetObject("lb_dias_campo_HM.Image")));
            this.lb_dias_campo_HM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_dias_campo_HM.Location = new System.Drawing.Point(6, 16);
            this.lb_dias_campo_HM.Name = "lb_dias_campo_HM";
            this.lb_dias_campo_HM.Size = new System.Drawing.Size(133, 35);
            this.lb_dias_campo_HM.TabIndex = 17;
            this.lb_dias_campo_HM.Text = "Días de campo:";
            this.lb_dias_campo_HM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_dias_gabinete_HM
            // 
            this.lb_dias_gabinete_HM.Image = ((System.Drawing.Image)(resources.GetObject("lb_dias_gabinete_HM.Image")));
            this.lb_dias_gabinete_HM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_dias_gabinete_HM.Location = new System.Drawing.Point(6, 60);
            this.lb_dias_gabinete_HM.Name = "lb_dias_gabinete_HM";
            this.lb_dias_gabinete_HM.Size = new System.Drawing.Size(133, 35);
            this.lb_dias_gabinete_HM.TabIndex = 19;
            this.lb_dias_gabinete_HM.Text = "Días de gabinete:";
            this.lb_dias_gabinete_HM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nud_dias_gabinete_HM
            // 
            this.nud_dias_gabinete_HM.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nud_dias_gabinete_HM.Location = new System.Drawing.Point(215, 69);
            this.nud_dias_gabinete_HM.Name = "nud_dias_gabinete_HM";
            this.nud_dias_gabinete_HM.Size = new System.Drawing.Size(59, 20);
            this.nud_dias_gabinete_HM.TabIndex = 20;
            this.nud_dias_gabinete_HM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_dias_campo_HM
            // 
            this.nud_dias_campo_HM.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nud_dias_campo_HM.Location = new System.Drawing.Point(215, 25);
            this.nud_dias_campo_HM.Name = "nud_dias_campo_HM";
            this.nud_dias_campo_HM.Size = new System.Drawing.Size(59, 20);
            this.nud_dias_campo_HM.TabIndex = 18;
            this.nud_dias_campo_HM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.ClientSize = new System.Drawing.Size(1008, 462);
            this.Controls.Add(this.tab_expedientes);
            this.Controls.Add(this.grp_acciones);
            this.Controls.Add(this.gb_cabezera);
            this.Controls.Add(this.gb_totales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmExpediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expediente";
            this.Load += new System.EventHandler(this.FrmExpediente_Load);
            this.gb_cabezera.ResumeLayout(false);
            this.gb_cabezera.PerformLayout();
            this.gb_liquidacion_OI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liquidaciones_OI)).EndInit();
            this.gb_fechas.ResumeLayout(false);
            this.gb_totales.ResumeLayout(false);
            this.gb_totales.PerformLayout();
            this.grp_acciones.ResumeLayout(false);
            this.gb_profesionales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_profesionales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_monto_obra_OI)).EndInit();
            this.tab_expedientes.ResumeLayout(false);
            this.tb_datos.ResumeLayout(false);
            this.gb_comitente.ResumeLayout(false);
            this.gb_comitente.PerformLayout();
            this.tb_OI.ResumeLayout(false);
            this.tb_OI.PerformLayout();
            this.gb_tareas_a_liquidar.ResumeLayout(false);
            this.gb_tareas_a_liquidar.PerformLayout();
            this.tb_FE.ResumeLayout(false);
            this.gb_liquidacion_FE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liquidaciones_FE)).EndInit();
            this.gb_datos_liquidacion_FE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_num_motores_FE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_num_bocas_FE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_num_hp_FE)).EndInit();
            this.gb_dias_FE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_dias_gabinete_FE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dias_campo_FE)).EndInit();
            this.tab_HM.ResumeLayout(false);
            this.gb_liquidacion_HM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liquidaciones_HM)).EndInit();
            this.gb_dias_HM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_dias_gabinete_HM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dias_campo_HM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_numero_expediente;
        private System.Windows.Forms.Label lb_estado;
        private System.Windows.Forms.Label lb_estado_expediente;
        private System.Windows.Forms.GroupBox gb_cabezera;
        private System.Windows.Forms.Label lb_tarea_OI;
        private System.Windows.Forms.TextBox txt_comitente;
        private System.Windows.Forms.GroupBox gb_liquidacion_OI;
        private System.Windows.Forms.DataGridView dgv_liquidaciones_OI;
        private System.Windows.Forms.GroupBox gb_fechas;
        private System.Windows.Forms.DateTimePicker dtp_fecha_aprobacion;
        private System.Windows.Forms.Label lb_fecha_aprobación;
        private System.Windows.Forms.DateTimePicker dtp_fecha_recepcion;
        private System.Windows.Forms.Label lb_fecha_recepcion;
        private System.Windows.Forms.DateTimePicker dtp_fecha_devolución;
        private System.Windows.Forms.Label lb_fecha_devolución;
        private System.Windows.Forms.GroupBox gb_totales;
        private System.Windows.Forms.TextBox txt_aportes_a_caja;
        private System.Windows.Forms.Label lb_aportes_a_caja;
        private System.Windows.Forms.TextBox txt_aportes_al_cie;
        private System.Windows.Forms.Label lb_aporte_al_cie;
        private System.Windows.Forms.TextBox txt_total_a_liquidar;
        private System.Windows.Forms.Label lb_total_a_liquidar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox grp_acciones;
        private System.Windows.Forms.Button btn_liquidar;
        private System.Windows.Forms.GroupBox gb_profesionales;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dgv_profesionales;
        private System.Windows.Forms.Label lb_tipo_expediente;
        private System.Windows.Forms.NumericUpDown nud_monto_obra_OI;
        private System.Windows.Forms.TabControl tab_expedientes;
        private System.Windows.Forms.TabPage tb_datos;
        private System.Windows.Forms.TabPage tb_OI;
        private System.Windows.Forms.Label lb_monto_obra;
        private System.Windows.Forms.ComboBox cmb_tareas_OI;
        private System.Windows.Forms.Button btn_seleccionar_comitente;
        private System.Windows.Forms.TabPage tb_FE;
        private System.Windows.Forms.Label lb_dias_campo_FE;
        private System.Windows.Forms.NumericUpDown nud_dias_campo_FE;
        private System.Windows.Forms.Label lb_dias_gabinete_FE;
        private System.Windows.Forms.NumericUpDown nud_dias_gabinete_FE;
        private System.Windows.Forms.GroupBox gb_datos_liquidacion_FE;
        private System.Windows.Forms.GroupBox gb_dias_FE;
        private System.Windows.Forms.GroupBox gb_liquidacion_FE;
        private System.Windows.Forms.DataGridView dgv_liquidaciones_FE;
        private System.Windows.Forms.Label lb_num_motores_FE;
        private System.Windows.Forms.NumericUpDown nud_num_motores_FE;
        private System.Windows.Forms.Label lb_num_bocas_FE;
        private System.Windows.Forms.NumericUpDown nud_num_bocas_FE;
        private System.Windows.Forms.Label lb_num_hp_FE;
        private System.Windows.Forms.NumericUpDown nud_num_hp_FE;
        private System.Windows.Forms.TabPage tab_HM;
        private System.Windows.Forms.GroupBox gb_dias_HM;
        private System.Windows.Forms.Label lb_dias_campo_HM;
        private System.Windows.Forms.Label lb_dias_gabinete_HM;
        private System.Windows.Forms.NumericUpDown nud_dias_gabinete_HM;
        private System.Windows.Forms.NumericUpDown nud_dias_campo_HM;
        private System.Windows.Forms.GroupBox gb_liquidacion_HM;
        private System.Windows.Forms.DataGridView dgv_liquidaciones_HM;
        private System.Windows.Forms.GroupBox gb_comitente;
        private System.Windows.Forms.GroupBox gb_tareas_a_liquidar;
        private System.Windows.Forms.CheckBox chk_direccion_de_la_obra;
        private System.Windows.Forms.CheckBox chk_representacion_tecnica;
        private System.Windows.Forms.CheckBox chk_trámites;
        private System.Windows.Forms.CheckBox chk_administracion;
        private System.Windows.Forms.CheckBox chk_conduccion_tecnica;
        private System.Windows.Forms.CheckBox chk_proyecto;
        private System.Windows.Forms.CheckBox chk_proyecto_sin_anteproyecto;
        private System.Windows.Forms.CheckBox chk_anteproyecto;
        private System.Windows.Forms.TextBox txt_total_aportes;
        private System.Windows.Forms.Label lb_total_aportes;
        private System.Windows.Forms.Label lb_numero_expte;
        private System.Windows.Forms.CheckBox chk_aportes;
        private System.Windows.Forms.DateTimePicker dtp_fecha_pago;
        private System.Windows.Forms.Label lb_fecha_pago;
        private System.Windows.Forms.ComboBox cmb_tareas_hm;
        private System.Windows.Forms.Label lb_tarea_hm;
        private System.Windows.Forms.ComboBox cmb_tareas_fe;
        private System.Windows.Forms.Label lb_tareas_fe;
    }
}