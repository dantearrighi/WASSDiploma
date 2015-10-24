namespace WASSTD
{
    partial class FrmPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersona));
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.tab_Persona = new System.Windows.Forms.TabControl();
            this.tab_datos = new System.Windows.Forms.TabPage();
            this.txt_celular = new System.Windows.Forms.MaskedTextBox();
            this.txt_numero = new System.Windows.Forms.MaskedTextBox();
            this.txt_telfijo = new System.Windows.Forms.MaskedTextBox();
            this.txt_fechanacimiento = new System.Windows.Forms.MaskedTextBox();
            this.grp_sexo = new System.Windows.Forms.GroupBox();
            this.lb_sexo = new System.Windows.Forms.Label();
            this.rbtn_masculino = new System.Windows.Forms.RadioButton();
            this.rbtn_femenino = new System.Windows.Forms.RadioButton();
            this.lb_emailalternativo = new System.Windows.Forms.Label();
            this.grp_lugardeenvio = new System.Windows.Forms.GroupBox();
            this.txt_cpE = new System.Windows.Forms.TextBox();
            this.lb_cpR = new System.Windows.Forms.Label();
            this.lb_localidadR = new System.Windows.Forms.Label();
            this.cmb_localidadesE = new System.Windows.Forms.ComboBox();
            this.cmb_provinciasE = new System.Windows.Forms.ComboBox();
            this.lb_provinciaR = new System.Windows.Forms.Label();
            this.txt_direccionE = new System.Windows.Forms.TextBox();
            this.lb_direccionR = new System.Windows.Forms.Label();
            this.grp_direccionres = new System.Windows.Forms.GroupBox();
            this.txt_cp = new System.Windows.Forms.TextBox();
            this.lb_codigopostal = new System.Windows.Forms.Label();
            this.lb_localidad = new System.Windows.Forms.Label();
            this.cmb_localidades = new System.Windows.Forms.ComboBox();
            this.cmb_provincias = new System.Windows.Forms.ComboBox();
            this.lb_provincia = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lb_direccion = new System.Windows.Forms.Label();
            this.cmb_tiposdoc = new System.Windows.Forms.ComboBox();
            this.lb_tipodoc = new System.Windows.Forms.Label();
            this.txt_emailalternativo = new System.Windows.Forms.TextBox();
            this.lb_celular = new System.Windows.Forms.Label();
            this.lb_telfijo = new System.Windows.Forms.Label();
            this.lb_fechanacimiento = new System.Windows.Forms.Label();
            this.lb_numero = new System.Windows.Forms.Label();
            this.txt_emailpricipal = new System.Windows.Forms.TextBox();
            this.lb_emailprincipal = new System.Windows.Forms.Label();
            this.txt_nombreapellido = new System.Windows.Forms.TextBox();
            this.lb_nombreapellido = new System.Windows.Forms.Label();
            this.tab_observaciones = new System.Windows.Forms.TabPage();
            this.grp_observaciones = new System.Windows.Forms.GroupBox();
            this.txt_observaciones = new System.Windows.Forms.TextBox();
            this.tab_Persona.SuspendLayout();
            this.tab_datos.SuspendLayout();
            this.grp_sexo.SuspendLayout();
            this.grp_lugardeenvio.SuspendLayout();
            this.grp_direccionres.SuspendLayout();
            this.tab_observaciones.SuspendLayout();
            this.grp_observaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::WASSTD.Properties.Resources.save_icon_16;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(394, 440);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 35);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::WASSTD.Properties.Resources.cancel_icon_16;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(475, 440);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 35);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // tab_Persona
            // 
            this.tab_Persona.Controls.Add(this.tab_datos);
            this.tab_Persona.Controls.Add(this.tab_observaciones);
            this.tab_Persona.Location = new System.Drawing.Point(16, 11);
            this.tab_Persona.Name = "tab_Persona";
            this.tab_Persona.SelectedIndex = 0;
            this.tab_Persona.Size = new System.Drawing.Size(535, 423);
            this.tab_Persona.TabIndex = 3;
            // 
            // tab_datos
            // 
            this.tab_datos.BackgroundImage = global::WASSTD.Properties.Resources.Fondo_Final;
            this.tab_datos.Controls.Add(this.txt_celular);
            this.tab_datos.Controls.Add(this.txt_numero);
            this.tab_datos.Controls.Add(this.txt_telfijo);
            this.tab_datos.Controls.Add(this.txt_fechanacimiento);
            this.tab_datos.Controls.Add(this.grp_sexo);
            this.tab_datos.Controls.Add(this.lb_emailalternativo);
            this.tab_datos.Controls.Add(this.grp_lugardeenvio);
            this.tab_datos.Controls.Add(this.grp_direccionres);
            this.tab_datos.Controls.Add(this.cmb_tiposdoc);
            this.tab_datos.Controls.Add(this.lb_tipodoc);
            this.tab_datos.Controls.Add(this.txt_emailalternativo);
            this.tab_datos.Controls.Add(this.lb_celular);
            this.tab_datos.Controls.Add(this.lb_telfijo);
            this.tab_datos.Controls.Add(this.lb_fechanacimiento);
            this.tab_datos.Controls.Add(this.lb_numero);
            this.tab_datos.Controls.Add(this.txt_emailpricipal);
            this.tab_datos.Controls.Add(this.lb_emailprincipal);
            this.tab_datos.Controls.Add(this.txt_nombreapellido);
            this.tab_datos.Controls.Add(this.lb_nombreapellido);
            this.tab_datos.Location = new System.Drawing.Point(4, 22);
            this.tab_datos.Name = "tab_datos";
            this.tab_datos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_datos.Size = new System.Drawing.Size(527, 397);
            this.tab_datos.TabIndex = 0;
            this.tab_datos.Text = "Datos Personales";
            this.tab_datos.UseVisualStyleBackColor = true;
            // 
            // txt_celular
            // 
            this.txt_celular.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_celular.Location = new System.Drawing.Point(358, 315);
            this.txt_celular.Mask = "9999999999999";
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(154, 20);
            this.txt_celular.TabIndex = 53;
            // 
            // txt_numero
            // 
            this.txt_numero.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_numero.Location = new System.Drawing.Point(359, 12);
            this.txt_numero.Mask = "99999999";
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(153, 20);
            this.txt_numero.TabIndex = 52;
            // 
            // txt_telfijo
            // 
            this.txt_telfijo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_telfijo.Location = new System.Drawing.Point(144, 315);
            this.txt_telfijo.Mask = "99999999999";
            this.txt_telfijo.Name = "txt_telfijo";
            this.txt_telfijo.Size = new System.Drawing.Size(100, 20);
            this.txt_telfijo.TabIndex = 51;
            // 
            // txt_fechanacimiento
            // 
            this.txt_fechanacimiento.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_fechanacimiento.Location = new System.Drawing.Point(144, 77);
            this.txt_fechanacimiento.Mask = "00/00/0000";
            this.txt_fechanacimiento.Name = "txt_fechanacimiento";
            this.txt_fechanacimiento.Size = new System.Drawing.Size(100, 20);
            this.txt_fechanacimiento.TabIndex = 50;
            this.txt_fechanacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // grp_sexo
            // 
            this.grp_sexo.Controls.Add(this.lb_sexo);
            this.grp_sexo.Controls.Add(this.rbtn_masculino);
            this.grp_sexo.Controls.Add(this.rbtn_femenino);
            this.grp_sexo.Location = new System.Drawing.Point(252, 70);
            this.grp_sexo.Name = "grp_sexo";
            this.grp_sexo.Size = new System.Drawing.Size(260, 36);
            this.grp_sexo.TabIndex = 49;
            this.grp_sexo.TabStop = false;
            // 
            // lb_sexo
            // 
            this.lb_sexo.Image = global::WASSTD.Properties.Resources.font_strokethrough_icon_16;
            this.lb_sexo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_sexo.Location = new System.Drawing.Point(6, 5);
            this.lb_sexo.Name = "lb_sexo";
            this.lb_sexo.Size = new System.Drawing.Size(65, 35);
            this.lb_sexo.TabIndex = 13;
            this.lb_sexo.Text = "Sexo:";
            this.lb_sexo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rbtn_masculino
            // 
            this.rbtn_masculino.AutoSize = true;
            this.rbtn_masculino.Location = new System.Drawing.Point(80, 14);
            this.rbtn_masculino.Name = "rbtn_masculino";
            this.rbtn_masculino.Size = new System.Drawing.Size(73, 17);
            this.rbtn_masculino.TabIndex = 6;
            this.rbtn_masculino.TabStop = true;
            this.rbtn_masculino.Text = "Masuclino";
            this.rbtn_masculino.UseVisualStyleBackColor = true;
            // 
            // rbtn_femenino
            // 
            this.rbtn_femenino.AutoSize = true;
            this.rbtn_femenino.Location = new System.Drawing.Point(159, 14);
            this.rbtn_femenino.Name = "rbtn_femenino";
            this.rbtn_femenino.Size = new System.Drawing.Size(71, 17);
            this.rbtn_femenino.TabIndex = 31;
            this.rbtn_femenino.TabStop = true;
            this.rbtn_femenino.Text = "Femenino";
            this.rbtn_femenino.UseVisualStyleBackColor = true;
            // 
            // lb_emailalternativo
            // 
            this.lb_emailalternativo.Image = global::WASSTD.Properties.Resources.mail_icon_16;
            this.lb_emailalternativo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_emailalternativo.Location = new System.Drawing.Point(9, 359);
            this.lb_emailalternativo.Name = "lb_emailalternativo";
            this.lb_emailalternativo.Size = new System.Drawing.Size(118, 35);
            this.lb_emailalternativo.TabIndex = 21;
            this.lb_emailalternativo.Text = "E-Mail alternativo:";
            this.lb_emailalternativo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grp_lugardeenvio
            // 
            this.grp_lugardeenvio.Controls.Add(this.txt_cpE);
            this.grp_lugardeenvio.Controls.Add(this.lb_cpR);
            this.grp_lugardeenvio.Controls.Add(this.lb_localidadR);
            this.grp_lugardeenvio.Controls.Add(this.cmb_localidadesE);
            this.grp_lugardeenvio.Controls.Add(this.cmb_provinciasE);
            this.grp_lugardeenvio.Controls.Add(this.lb_provinciaR);
            this.grp_lugardeenvio.Controls.Add(this.txt_direccionE);
            this.grp_lugardeenvio.Controls.Add(this.lb_direccionR);
            this.grp_lugardeenvio.Location = new System.Drawing.Point(6, 219);
            this.grp_lugardeenvio.Name = "grp_lugardeenvio";
            this.grp_lugardeenvio.Size = new System.Drawing.Size(518, 85);
            this.grp_lugardeenvio.TabIndex = 47;
            this.grp_lugardeenvio.TabStop = false;
            this.grp_lugardeenvio.Text = "Lugar de envío";
            // 
            // txt_cpE
            // 
            this.txt_cpE.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_cpE.Location = new System.Drawing.Point(411, 59);
            this.txt_cpE.Name = "txt_cpE";
            this.txt_cpE.Size = new System.Drawing.Size(95, 20);
            this.txt_cpE.TabIndex = 46;
            // 
            // lb_cpR
            // 
            this.lb_cpR.Image = global::WASSTD.Properties.Resources.cc_icon_16;
            this.lb_cpR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_cpR.Location = new System.Drawing.Point(350, 50);
            this.lb_cpR.Name = "lb_cpR";
            this.lb_cpR.Size = new System.Drawing.Size(47, 35);
            this.lb_cpR.TabIndex = 45;
            this.lb_cpR.Text = "CP:";
            this.lb_cpR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_localidadR
            // 
            this.lb_localidadR.Image = global::WASSTD.Properties.Resources.globe_1_icon_16;
            this.lb_localidadR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_localidadR.Location = new System.Drawing.Point(241, 11);
            this.lb_localidadR.Name = "lb_localidadR";
            this.lb_localidadR.Size = new System.Drawing.Size(76, 35);
            this.lb_localidadR.TabIndex = 44;
            this.lb_localidadR.Text = "Localidad:";
            this.lb_localidadR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_localidadesE
            // 
            this.cmb_localidadesE.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_localidadesE.FormattingEnabled = true;
            this.cmb_localidadesE.Location = new System.Drawing.Point(323, 19);
            this.cmb_localidadesE.Name = "cmb_localidadesE";
            this.cmb_localidadesE.Size = new System.Drawing.Size(183, 21);
            this.cmb_localidadesE.TabIndex = 43;
            this.cmb_localidadesE.Leave += new System.EventHandler(this.cmb_localidadesE_Leave);
            // 
            // cmb_provinciasE
            // 
            this.cmb_provinciasE.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_provinciasE.FormattingEnabled = true;
            this.cmb_provinciasE.Location = new System.Drawing.Point(114, 19);
            this.cmb_provinciasE.Name = "cmb_provinciasE";
            this.cmb_provinciasE.Size = new System.Drawing.Size(121, 21);
            this.cmb_provinciasE.TabIndex = 42;
            this.cmb_provinciasE.Leave += new System.EventHandler(this.cmb_provinciasE_Leave);
            // 
            // lb_provinciaR
            // 
            this.lb_provinciaR.Image = global::WASSTD.Properties.Resources.globe_3_icon_16;
            this.lb_provinciaR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_provinciaR.Location = new System.Drawing.Point(14, 11);
            this.lb_provinciaR.Name = "lb_provinciaR";
            this.lb_provinciaR.Size = new System.Drawing.Size(90, 35);
            this.lb_provinciaR.TabIndex = 41;
            this.lb_provinciaR.Text = "Provincia:";
            this.lb_provinciaR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_direccionE
            // 
            this.txt_direccionE.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_direccionE.Location = new System.Drawing.Point(114, 57);
            this.txt_direccionE.Name = "txt_direccionE";
            this.txt_direccionE.Size = new System.Drawing.Size(229, 20);
            this.txt_direccionE.TabIndex = 40;
            // 
            // lb_direccionR
            // 
            this.lb_direccionR.Image = global::WASSTD.Properties.Resources.globe_2_icon_16;
            this.lb_direccionR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_direccionR.Location = new System.Drawing.Point(13, 49);
            this.lb_direccionR.Name = "lb_direccionR";
            this.lb_direccionR.Size = new System.Drawing.Size(91, 35);
            this.lb_direccionR.TabIndex = 39;
            this.lb_direccionR.Text = "Dirección:";
            this.lb_direccionR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grp_direccionres
            // 
            this.grp_direccionres.Controls.Add(this.txt_cp);
            this.grp_direccionres.Controls.Add(this.lb_codigopostal);
            this.grp_direccionres.Controls.Add(this.lb_localidad);
            this.grp_direccionres.Controls.Add(this.cmb_localidades);
            this.grp_direccionres.Controls.Add(this.cmb_provincias);
            this.grp_direccionres.Controls.Add(this.lb_provincia);
            this.grp_direccionres.Controls.Add(this.txt_direccion);
            this.grp_direccionres.Controls.Add(this.lb_direccion);
            this.grp_direccionres.Location = new System.Drawing.Point(6, 112);
            this.grp_direccionres.Name = "grp_direccionres";
            this.grp_direccionres.Size = new System.Drawing.Size(518, 78);
            this.grp_direccionres.TabIndex = 32;
            this.grp_direccionres.TabStop = false;
            this.grp_direccionres.Text = "Lugar de residencia";
            // 
            // txt_cp
            // 
            this.txt_cp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_cp.Location = new System.Drawing.Point(411, 51);
            this.txt_cp.Name = "txt_cp";
            this.txt_cp.Size = new System.Drawing.Size(95, 20);
            this.txt_cp.TabIndex = 46;
            // 
            // lb_codigopostal
            // 
            this.lb_codigopostal.Image = global::WASSTD.Properties.Resources.cc_icon_16;
            this.lb_codigopostal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_codigopostal.Location = new System.Drawing.Point(349, 43);
            this.lb_codigopostal.Name = "lb_codigopostal";
            this.lb_codigopostal.Size = new System.Drawing.Size(48, 35);
            this.lb_codigopostal.TabIndex = 45;
            this.lb_codigopostal.Text = "CP:";
            this.lb_codigopostal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_localidad
            // 
            this.lb_localidad.Image = global::WASSTD.Properties.Resources.globe_1_icon_16;
            this.lb_localidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_localidad.Location = new System.Drawing.Point(243, 11);
            this.lb_localidad.Name = "lb_localidad";
            this.lb_localidad.Size = new System.Drawing.Size(74, 35);
            this.lb_localidad.TabIndex = 44;
            this.lb_localidad.Text = "Localidad:";
            this.lb_localidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_localidades
            // 
            this.cmb_localidades.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_localidades.FormattingEnabled = true;
            this.cmb_localidades.Location = new System.Drawing.Point(323, 19);
            this.cmb_localidades.Name = "cmb_localidades";
            this.cmb_localidades.Size = new System.Drawing.Size(183, 21);
            this.cmb_localidades.TabIndex = 43;
            this.cmb_localidades.Leave += new System.EventHandler(this.cmb_localidades_Leave);
            // 
            // cmb_provincias
            // 
            this.cmb_provincias.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_provincias.FormattingEnabled = true;
            this.cmb_provincias.Location = new System.Drawing.Point(114, 19);
            this.cmb_provincias.Name = "cmb_provincias";
            this.cmb_provincias.Size = new System.Drawing.Size(121, 21);
            this.cmb_provincias.TabIndex = 42;
            this.cmb_provincias.Leave += new System.EventHandler(this.cmb_provincias_Leave);
            // 
            // lb_provincia
            // 
            this.lb_provincia.Image = global::WASSTD.Properties.Resources.globe_3_icon_16;
            this.lb_provincia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_provincia.Location = new System.Drawing.Point(14, 11);
            this.lb_provincia.Name = "lb_provincia";
            this.lb_provincia.Size = new System.Drawing.Size(90, 35);
            this.lb_provincia.TabIndex = 41;
            this.lb_provincia.Text = "Provincia:";
            this.lb_provincia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_direccion
            // 
            this.txt_direccion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_direccion.Location = new System.Drawing.Point(110, 51);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(233, 20);
            this.txt_direccion.TabIndex = 40;
            // 
            // lb_direccion
            // 
            this.lb_direccion.Image = global::WASSTD.Properties.Resources.globe_2_icon_16;
            this.lb_direccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_direccion.Location = new System.Drawing.Point(14, 43);
            this.lb_direccion.Name = "lb_direccion";
            this.lb_direccion.Size = new System.Drawing.Size(90, 35);
            this.lb_direccion.TabIndex = 39;
            this.lb_direccion.Text = "Dirección:";
            this.lb_direccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_tiposdoc
            // 
            this.cmb_tiposdoc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_tiposdoc.FormattingEnabled = true;
            this.cmb_tiposdoc.Location = new System.Drawing.Point(144, 12);
            this.cmb_tiposdoc.Name = "cmb_tiposdoc";
            this.cmb_tiposdoc.Size = new System.Drawing.Size(121, 21);
            this.cmb_tiposdoc.TabIndex = 24;
            // 
            // lb_tipodoc
            // 
            this.lb_tipodoc.Image = global::WASSTD.Properties.Resources.book_icon_16;
            this.lb_tipodoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_tipodoc.Location = new System.Drawing.Point(6, 4);
            this.lb_tipodoc.Name = "lb_tipodoc";
            this.lb_tipodoc.Size = new System.Drawing.Size(132, 35);
            this.lb_tipodoc.TabIndex = 23;
            this.lb_tipodoc.Text = "Tipo de Documento:";
            this.lb_tipodoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_emailalternativo
            // 
            this.txt_emailalternativo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_emailalternativo.Location = new System.Drawing.Point(144, 367);
            this.txt_emailalternativo.Name = "txt_emailalternativo";
            this.txt_emailalternativo.Size = new System.Drawing.Size(368, 20);
            this.txt_emailalternativo.TabIndex = 22;
            // 
            // lb_celular
            // 
            this.lb_celular.Image = global::WASSTD.Properties.Resources.phone_icon_16;
            this.lb_celular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_celular.Location = new System.Drawing.Point(281, 307);
            this.lb_celular.Name = "lb_celular";
            this.lb_celular.Size = new System.Drawing.Size(68, 35);
            this.lb_celular.TabIndex = 19;
            this.lb_celular.Text = "Celular:";
            this.lb_celular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_telfijo
            // 
            this.lb_telfijo.Image = global::WASSTD.Properties.Resources.phone_2_icon_16;
            this.lb_telfijo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_telfijo.Location = new System.Drawing.Point(12, 307);
            this.lb_telfijo.Name = "lb_telfijo";
            this.lb_telfijo.Size = new System.Drawing.Size(115, 35);
            this.lb_telfijo.TabIndex = 17;
            this.lb_telfijo.Text = "Teléfono Fijo:";
            this.lb_telfijo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_fechanacimiento
            // 
            this.lb_fechanacimiento.Image = global::WASSTD.Properties.Resources.calendar_1_icon_16;
            this.lb_fechanacimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_fechanacimiento.Location = new System.Drawing.Point(6, 69);
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
            this.lb_numero.Location = new System.Drawing.Point(276, 4);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(74, 35);
            this.lb_numero.TabIndex = 9;
            this.lb_numero.Text = "Número:";
            this.lb_numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_emailpricipal
            // 
            this.txt_emailpricipal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_emailpricipal.Location = new System.Drawing.Point(144, 341);
            this.txt_emailpricipal.Name = "txt_emailpricipal";
            this.txt_emailpricipal.Size = new System.Drawing.Size(368, 20);
            this.txt_emailpricipal.TabIndex = 3;
            // 
            // lb_emailprincipal
            // 
            this.lb_emailprincipal.Image = global::WASSTD.Properties.Resources.mail_2_icon_16;
            this.lb_emailprincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_emailprincipal.Location = new System.Drawing.Point(9, 333);
            this.lb_emailprincipal.Name = "lb_emailprincipal";
            this.lb_emailprincipal.Size = new System.Drawing.Size(118, 35);
            this.lb_emailprincipal.TabIndex = 2;
            this.lb_emailprincipal.Text = "E-Mail principal:";
            this.lb_emailprincipal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_nombreapellido
            // 
            this.txt_nombreapellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nombreapellido.Location = new System.Drawing.Point(144, 44);
            this.txt_nombreapellido.Name = "txt_nombreapellido";
            this.txt_nombreapellido.Size = new System.Drawing.Size(368, 20);
            this.txt_nombreapellido.TabIndex = 1;
            // 
            // lb_nombreapellido
            // 
            this.lb_nombreapellido.Image = global::WASSTD.Properties.Resources.contact_card_icon_16;
            this.lb_nombreapellido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_nombreapellido.Location = new System.Drawing.Point(6, 39);
            this.lb_nombreapellido.Name = "lb_nombreapellido";
            this.lb_nombreapellido.Size = new System.Drawing.Size(132, 35);
            this.lb_nombreapellido.TabIndex = 0;
            this.lb_nombreapellido.Text = "Nombre y Apellido:";
            this.lb_nombreapellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tab_observaciones
            // 
            this.tab_observaciones.BackgroundImage = global::WASSTD.Properties.Resources.Fondo_Final;
            this.tab_observaciones.Controls.Add(this.grp_observaciones);
            this.tab_observaciones.Location = new System.Drawing.Point(4, 22);
            this.tab_observaciones.Name = "tab_observaciones";
            this.tab_observaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tab_observaciones.Size = new System.Drawing.Size(527, 397);
            this.tab_observaciones.TabIndex = 6;
            this.tab_observaciones.Text = "Observaciones";
            this.tab_observaciones.UseVisualStyleBackColor = true;
            // 
            // grp_observaciones
            // 
            this.grp_observaciones.Controls.Add(this.txt_observaciones);
            this.grp_observaciones.Location = new System.Drawing.Point(7, 7);
            this.grp_observaciones.Name = "grp_observaciones";
            this.grp_observaciones.Size = new System.Drawing.Size(514, 166);
            this.grp_observaciones.TabIndex = 1;
            this.grp_observaciones.TabStop = false;
            this.grp_observaciones.Text = "Observaciones";
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_observaciones.Location = new System.Drawing.Point(7, 20);
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.Size = new System.Drawing.Size(500, 20);
            this.txt_observaciones.TabIndex = 0;
            // 
            // FrmPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WASSTD.Properties.Resources.Fondo_Final;
            this.ClientSize = new System.Drawing.Size(569, 487);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.tab_Persona);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Persona";
            this.Load += new System.EventHandler(this.FrmPersona_Load);
            this.tab_Persona.ResumeLayout(false);
            this.tab_datos.ResumeLayout(false);
            this.tab_datos.PerformLayout();
            this.grp_sexo.ResumeLayout(false);
            this.grp_sexo.PerformLayout();
            this.grp_lugardeenvio.ResumeLayout(false);
            this.grp_lugardeenvio.PerformLayout();
            this.grp_direccionres.ResumeLayout(false);
            this.grp_direccionres.PerformLayout();
            this.tab_observaciones.ResumeLayout(false);
            this.grp_observaciones.ResumeLayout(false);
            this.grp_observaciones.PerformLayout();
            this.ResumeLayout(false);

        }

        private void btn_modificar_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btn_agregar_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

      

        #endregion

        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TabControl tab_Persona;
        private System.Windows.Forms.TabPage tab_datos;
        private System.Windows.Forms.TextBox txt_emailpricipal;
        private System.Windows.Forms.Label lb_emailprincipal;
        private System.Windows.Forms.TextBox txt_nombreapellido;
        private System.Windows.Forms.Label lb_nombreapellido;
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.Label lb_fechanacimiento;
        private System.Windows.Forms.Label lb_sexo;
        private System.Windows.Forms.Label lb_celular;
        private System.Windows.Forms.Label lb_telfijo;
        private System.Windows.Forms.TextBox txt_emailalternativo;
        private System.Windows.Forms.Label lb_emailalternativo;
        private System.Windows.Forms.ComboBox cmb_tiposdoc;
        private System.Windows.Forms.Label lb_tipodoc;
        private System.Windows.Forms.RadioButton rbtn_femenino;
        private System.Windows.Forms.RadioButton rbtn_masculino;
        private System.Windows.Forms.GroupBox grp_lugardeenvio;
        private System.Windows.Forms.TextBox txt_cpE;
        private System.Windows.Forms.Label lb_cpR;
        private System.Windows.Forms.Label lb_localidadR;
        private System.Windows.Forms.ComboBox cmb_localidadesE;
        private System.Windows.Forms.ComboBox cmb_provinciasE;
        private System.Windows.Forms.Label lb_provinciaR;
        private System.Windows.Forms.TextBox txt_direccionE;
        private System.Windows.Forms.Label lb_direccionR;
        private System.Windows.Forms.GroupBox grp_direccionres;
        private System.Windows.Forms.TextBox txt_cp;
        private System.Windows.Forms.Label lb_codigopostal;
        private System.Windows.Forms.Label lb_localidad;
        private System.Windows.Forms.ComboBox cmb_localidades;
        private System.Windows.Forms.ComboBox cmb_provincias;
        private System.Windows.Forms.Label lb_provincia;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lb_direccion;
        private System.Windows.Forms.TabPage tab_observaciones;
        private System.Windows.Forms.GroupBox grp_observaciones;
        private System.Windows.Forms.TextBox txt_observaciones;
        private System.Windows.Forms.GroupBox grp_sexo;
        private System.Windows.Forms.MaskedTextBox txt_fechanacimiento;
        private System.Windows.Forms.MaskedTextBox txt_telfijo;
        private System.Windows.Forms.MaskedTextBox txt_celular;
        private System.Windows.Forms.MaskedTextBox txt_numero;
    }
}