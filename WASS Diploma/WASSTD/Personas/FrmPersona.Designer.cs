namespace WASSTD.Personas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fechanacimiento = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_fechanacimiento = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_celular = new System.Windows.Forms.MaskedTextBox();
            this.txt_telfijo = new System.Windows.Forms.MaskedTextBox();
            this.lb_celular = new System.Windows.Forms.Label();
            this.lb_telfijo = new System.Windows.Forms.Label();
            this.txt_emailpricipal = new System.Windows.Forms.TextBox();
            this.lb_emailprincipal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_direccionres = new System.Windows.Forms.GroupBox();
            this.txt_cp = new System.Windows.Forms.TextBox();
            this.lb_codigopostal = new System.Windows.Forms.Label();
            this.lb_localidad = new System.Windows.Forms.Label();
            this.cmb_localidades = new System.Windows.Forms.ComboBox();
            this.cmb_provincias = new System.Windows.Forms.ComboBox();
            this.lb_provincia = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lb_direccion = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.MaskedTextBox();
            this.cmb_tiposdoc = new System.Windows.Forms.ComboBox();
            this.lb_tipodoc = new System.Windows.Forms.Label();
            this.lb_numero = new System.Windows.Forms.Label();
            this.txt_nombreapellido = new System.Windows.Forms.TextBox();
            this.lb_nombreapellido = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grp_direccionres.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::WASSTD.Properties.Resources.save_icon_16;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(397, 380);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 35);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::WASSTD.Properties.Resources.cancel_icon_16;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(478, 380);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 35);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_fechanacimiento);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lb_fechanacimiento);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.grp_direccionres);
            this.groupBox1.Controls.Add(this.txt_numero);
            this.groupBox1.Controls.Add(this.cmb_tiposdoc);
            this.groupBox1.Controls.Add(this.lb_tipodoc);
            this.groupBox1.Controls.Add(this.lb_numero);
            this.groupBox1.Controls.Add(this.txt_nombreapellido);
            this.groupBox1.Controls.Add(this.lb_nombreapellido);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 361);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos personales";
            // 
            // label3
            // 
            this.label3.Image = global::WASSTD.Properties.Resources.contact_card_icon_16;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(290, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 28);
            this.label3.TabIndex = 69;
            this.label3.Text = "Edad:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.Image = global::WASSTD.Properties.Resources.users_icon_16;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(20, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 35);
            this.label2.TabIndex = 67;
            this.label2.Text = "Tipo de Persona:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_fechanacimiento
            // 
            this.txt_fechanacimiento.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_fechanacimiento.Location = new System.Drawing.Point(158, 78);
            this.txt_fechanacimiento.Mask = "00/00/0000";
            this.txt_fechanacimiento.Name = "txt_fechanacimiento";
            this.txt_fechanacimiento.Size = new System.Drawing.Size(121, 20);
            this.txt_fechanacimiento.TabIndex = 52;
            this.txt_fechanacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(158, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 48;
            // 
            // lb_fechanacimiento
            // 
            this.lb_fechanacimiento.Image = global::WASSTD.Properties.Resources.calendar_1_icon_16;
            this.lb_fechanacimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_fechanacimiento.Location = new System.Drawing.Point(20, 70);
            this.lb_fechanacimiento.Name = "lb_fechanacimiento";
            this.lb_fechanacimiento.Size = new System.Drawing.Size(132, 35);
            this.lb_fechanacimiento.TabIndex = 51;
            this.lb_fechanacimiento.Text = "Fecha de Nacimiento:";
            this.lb_fechanacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_celular);
            this.groupBox2.Controls.Add(this.txt_telfijo);
            this.groupBox2.Controls.Add(this.lb_celular);
            this.groupBox2.Controls.Add(this.lb_telfijo);
            this.groupBox2.Controls.Add(this.txt_emailpricipal);
            this.groupBox2.Controls.Add(this.lb_emailprincipal);
            this.groupBox2.Location = new System.Drawing.Point(6, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 99);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de contacto";
            // 
            // txt_celular
            // 
            this.txt_celular.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_celular.Location = new System.Drawing.Point(349, 33);
            this.txt_celular.Mask = "9999999999999";
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(143, 20);
            this.txt_celular.TabIndex = 65;
            // 
            // txt_telfijo
            // 
            this.txt_telfijo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_telfijo.Location = new System.Drawing.Point(124, 35);
            this.txt_telfijo.Mask = "99999999999";
            this.txt_telfijo.Name = "txt_telfijo";
            this.txt_telfijo.Size = new System.Drawing.Size(100, 20);
            this.txt_telfijo.TabIndex = 64;
            // 
            // lb_celular
            // 
            this.lb_celular.Image = global::WASSTD.Properties.Resources.phone_icon_16;
            this.lb_celular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_celular.Location = new System.Drawing.Point(275, 25);
            this.lb_celular.Name = "lb_celular";
            this.lb_celular.Size = new System.Drawing.Size(68, 35);
            this.lb_celular.TabIndex = 63;
            this.lb_celular.Text = "Celular:";
            this.lb_celular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_telfijo
            // 
            this.lb_telfijo.Image = global::WASSTD.Properties.Resources.phone_2_icon_16;
            this.lb_telfijo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_telfijo.Location = new System.Drawing.Point(14, 27);
            this.lb_telfijo.Name = "lb_telfijo";
            this.lb_telfijo.Size = new System.Drawing.Size(90, 35);
            this.lb_telfijo.TabIndex = 62;
            this.lb_telfijo.Text = "Teléfono Fijo:";
            this.lb_telfijo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_emailpricipal
            // 
            this.txt_emailpricipal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_emailpricipal.Location = new System.Drawing.Point(124, 61);
            this.txt_emailpricipal.Name = "txt_emailpricipal";
            this.txt_emailpricipal.Size = new System.Drawing.Size(368, 20);
            this.txt_emailpricipal.TabIndex = 61;
            // 
            // lb_emailprincipal
            // 
            this.lb_emailprincipal.Image = global::WASSTD.Properties.Resources.mail_2_icon_16;
            this.lb_emailprincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_emailprincipal.Location = new System.Drawing.Point(14, 53);
            this.lb_emailprincipal.Name = "lb_emailprincipal";
            this.lb_emailprincipal.Size = new System.Drawing.Size(104, 35);
            this.lb_emailprincipal.TabIndex = 60;
            this.lb_emailprincipal.Text = "E-Mail principal:";
            this.lb_emailprincipal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Image = global::WASSTD.Properties.Resources.key_icon_16;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(21, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 35);
            this.label1.TabIndex = 47;
            this.label1.Text = "Clave Fiscal:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.grp_direccionres.Location = new System.Drawing.Point(6, 160);
            this.grp_direccionres.Name = "grp_direccionres";
            this.grp_direccionres.Size = new System.Drawing.Size(527, 89);
            this.grp_direccionres.TabIndex = 59;
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
            this.lb_codigopostal.Location = new System.Drawing.Point(357, 43);
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
            // 
            // cmb_provincias
            // 
            this.cmb_provincias.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_provincias.FormattingEnabled = true;
            this.cmb_provincias.Location = new System.Drawing.Point(110, 19);
            this.cmb_provincias.Name = "cmb_provincias";
            this.cmb_provincias.Size = new System.Drawing.Size(121, 21);
            this.cmb_provincias.TabIndex = 42;
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
            // txt_numero
            // 
            this.txt_numero.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_numero.Location = new System.Drawing.Point(373, 52);
            this.txt_numero.Mask = "99999999";
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(153, 20);
            this.txt_numero.TabIndex = 58;
            // 
            // cmb_tiposdoc
            // 
            this.cmb_tiposdoc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_tiposdoc.FormattingEnabled = true;
            this.cmb_tiposdoc.Location = new System.Drawing.Point(158, 51);
            this.cmb_tiposdoc.Name = "cmb_tiposdoc";
            this.cmb_tiposdoc.Size = new System.Drawing.Size(121, 21);
            this.cmb_tiposdoc.TabIndex = 57;
            // 
            // lb_tipodoc
            // 
            this.lb_tipodoc.Image = global::WASSTD.Properties.Resources.book_icon_16;
            this.lb_tipodoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_tipodoc.Location = new System.Drawing.Point(20, 43);
            this.lb_tipodoc.Name = "lb_tipodoc";
            this.lb_tipodoc.Size = new System.Drawing.Size(132, 35);
            this.lb_tipodoc.TabIndex = 56;
            this.lb_tipodoc.Text = "Tipo de Documento:";
            this.lb_tipodoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_numero
            // 
            this.lb_numero.Image = global::WASSTD.Properties.Resources.page_layout_icon_16;
            this.lb_numero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_numero.Location = new System.Drawing.Point(290, 44);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(74, 35);
            this.lb_numero.TabIndex = 55;
            this.lb_numero.Text = "Número:";
            this.lb_numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_nombreapellido
            // 
            this.txt_nombreapellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nombreapellido.Location = new System.Drawing.Point(158, 104);
            this.txt_nombreapellido.Name = "txt_nombreapellido";
            this.txt_nombreapellido.Size = new System.Drawing.Size(368, 20);
            this.txt_nombreapellido.TabIndex = 54;
            // 
            // lb_nombreapellido
            // 
            this.lb_nombreapellido.Image = global::WASSTD.Properties.Resources.contact_card_icon_16;
            this.lb_nombreapellido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_nombreapellido.Location = new System.Drawing.Point(20, 96);
            this.lb_nombreapellido.Name = "lb_nombreapellido";
            this.lb_nombreapellido.Size = new System.Drawing.Size(132, 35);
            this.lb_nombreapellido.TabIndex = 53;
            this.lb_nombreapellido.Text = "Nombre y Apellido:";
            this.lb_nombreapellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 424);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Persona";
            this.Load += new System.EventHandler(this.FrmPersona_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grp_direccionres.ResumeLayout(false);
            this.grp_direccionres.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txt_numero;
        private System.Windows.Forms.ComboBox cmb_tiposdoc;
        private System.Windows.Forms.Label lb_tipodoc;
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.TextBox txt_nombreapellido;
        private System.Windows.Forms.Label lb_nombreapellido;
        private System.Windows.Forms.GroupBox grp_direccionres;
        private System.Windows.Forms.TextBox txt_cp;
        private System.Windows.Forms.Label lb_codigopostal;
        private System.Windows.Forms.Label lb_localidad;
        private System.Windows.Forms.ComboBox cmb_localidades;
        private System.Windows.Forms.ComboBox cmb_provincias;
        private System.Windows.Forms.Label lb_provincia;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lb_direccion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txt_celular;
        private System.Windows.Forms.MaskedTextBox txt_telfijo;
        private System.Windows.Forms.Label lb_celular;
        private System.Windows.Forms.Label lb_telfijo;
        private System.Windows.Forms.TextBox txt_emailpricipal;
        private System.Windows.Forms.Label lb_emailprincipal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_fechanacimiento;
        private System.Windows.Forms.Label lb_fechanacimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}