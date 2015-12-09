namespace WASSTD.Tramites
{
    partial class FrmTramites
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
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.dniColu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_dni = new System.Windows.Forms.MaskedTextBox();
            this.txt_nya_Persona = new System.Windows.Forms.TextBox();
            this.lb_dni = new System.Windows.Forms.Label();
            this.lb_nya_Persona = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_RecargarLista = new System.Windows.Forms.Button();
            this.txt_NroDeTramite = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.botonera1 = new WASSTD.Botonera1();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_datos
            // 
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dniColu});
            this.dgv_datos.Location = new System.Drawing.Point(12, 185);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.Size = new System.Drawing.Size(1576, 545);
            this.dgv_datos.TabIndex = 0;
            // 
            // dniColu
            // 
            this.dniColu.HeaderText = "Documento";
            this.dniColu.Name = "dniColu";
            // 
            // txt_dni
            // 
            this.txt_dni.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_dni.Location = new System.Drawing.Point(240, 43);
            this.txt_dni.Mask = "99999999";
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(262, 20);
            this.txt_dni.TabIndex = 13;
            this.txt_dni.TextChanged += new System.EventHandler(this.txt_dni_TextChanged);
            // 
            // txt_nya_Persona
            // 
            this.txt_nya_Persona.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nya_Persona.Location = new System.Drawing.Point(240, 17);
            this.txt_nya_Persona.Name = "txt_nya_Persona";
            this.txt_nya_Persona.Size = new System.Drawing.Size(262, 20);
            this.txt_nya_Persona.TabIndex = 12;
            this.txt_nya_Persona.TextChanged += new System.EventHandler(this.txt_nya_Persona_TextChanged);
            // 
            // lb_dni
            // 
            this.lb_dni.BackColor = System.Drawing.Color.Transparent;
            this.lb_dni.Image = global::WASSTD.Properties.Resources.contact_card_icon_16;
            this.lb_dni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_dni.Location = new System.Drawing.Point(14, 35);
            this.lb_dni.Name = "lb_dni";
            this.lb_dni.Size = new System.Drawing.Size(220, 35);
            this.lb_dni.TabIndex = 11;
            this.lb_dni.Text = "Nº de documento de la Persona:";
            this.lb_dni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_nya_Persona
            // 
            this.lb_nya_Persona.BackColor = System.Drawing.Color.Transparent;
            this.lb_nya_Persona.Image = global::WASSTD.Properties.Resources.user_icon_16;
            this.lb_nya_Persona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_nya_Persona.Location = new System.Drawing.Point(14, 9);
            this.lb_nya_Persona.Name = "lb_nya_Persona";
            this.lb_nya_Persona.Size = new System.Drawing.Size(220, 35);
            this.lb_nya_Persona.TabIndex = 10;
            this.lb_nya_Persona.Text = "Nombre y Apellido de la Persona:";
            this.lb_nya_Persona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_RecargarLista);
            this.groupBox1.Controls.Add(this.txt_NroDeTramite);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_dni);
            this.groupBox1.Controls.Add(this.txt_nya_Persona);
            this.groupBox1.Controls.Add(this.lb_dni);
            this.groupBox1.Controls.Add(this.lb_nya_Persona);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 148);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar tramites";
            // 
            // btn_RecargarLista
            // 
            this.btn_RecargarLista.Image = global::WASSTD.Properties.Resources.reload_icon_16;
            this.btn_RecargarLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RecargarLista.Location = new System.Drawing.Point(408, 107);
            this.btn_RecargarLista.Name = "btn_RecargarLista";
            this.btn_RecargarLista.Size = new System.Drawing.Size(104, 35);
            this.btn_RecargarLista.TabIndex = 16;
            this.btn_RecargarLista.Text = "Mostrar todos";
            this.btn_RecargarLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RecargarLista.UseVisualStyleBackColor = true;
            this.btn_RecargarLista.Click += new System.EventHandler(this.btn_RecargarLista_Click);
            // 
            // txt_NroDeTramite
            // 
            this.txt_NroDeTramite.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_NroDeTramite.Location = new System.Drawing.Point(240, 69);
            this.txt_NroDeTramite.Mask = "99999999";
            this.txt_NroDeTramite.Name = "txt_NroDeTramite";
            this.txt_NroDeTramite.Size = new System.Drawing.Size(262, 20);
            this.txt_NroDeTramite.TabIndex = 15;
            this.txt_NroDeTramite.TextChanged += new System.EventHandler(this.txt_NroDeTramite_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::WASSTD.Properties.Resources.notepad_icon_16;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(14, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 35);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nº de Trámite:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(557, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 148);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = global::WASSTD.Properties.Resources.notepad_icon_16;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 35);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cantidad de Trámites:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Image = global::WASSTD.Properties.Resources.checkbox_checked_icon_16;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(285, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 35);
            this.label3.TabIndex = 18;
            this.label3.Text = "Jubilaciones:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Image = global::WASSTD.Properties.Resources.user_icon_16;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 35);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cantidad de Personas:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Image = global::WASSTD.Properties.Resources.checkbox_checked_icon_16;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(285, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 35);
            this.label5.TabIndex = 20;
            this.label5.Text = "Pensiones:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Image = global::WASSTD.Properties.Resources.checkbox_checked_icon_16;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(285, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 35);
            this.label6.TabIndex = 21;
            this.label6.Text = "Reajustes:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Image = global::WASSTD.Properties.Resources.checkbox_checked_icon_16;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(285, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 35);
            this.label7.TabIndex = 22;
            this.label7.Text = "Reco:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Image = global::WASSTD.Properties.Resources.on_off_icon_16;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(6, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 35);
            this.label8.TabIndex = 23;
            this.label8.Text = "Activos:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Image = global::WASSTD.Properties.Resources.checkmark_icon_16;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(6, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 35);
            this.label9.TabIndex = 24;
            this.label9.Text = "Finalizados:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(1004, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 16;
            // 
            // botonera1
            // 
            this.botonera1.Location = new System.Drawing.Point(12, 745);
            this.botonera1.Name = "botonera1";
            this.botonera1.Size = new System.Drawing.Size(1576, 45);
            this.botonera1.TabIndex = 1;
            this.botonera1.Click_Alta += new WASSTD.Eventos_Botonera(this.botonera1_Click_Alta);
            this.botonera1.Click_Modificacion += new WASSTD.Eventos_Botonera(this.botonera1_Click_Modificacion);
            this.botonera1.Click_Consulta += new WASSTD.Eventos_Botonera(this.botonera1_Click_Consulta);
            this.botonera1.Click_Cerrar += new WASSTD.Eventos_Botonera(this.botonera1_Click_Cerrar);
            // 
            // FrmTramites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 802);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botonera1);
            this.Controls.Add(this.dgv_datos);
            this.Name = "FrmTramites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Tramites";
            this.Load += new System.EventHandler(this.FrmTramites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_datos;
        private Botonera1 botonera1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniColu;
        private System.Windows.Forms.MaskedTextBox txt_dni;
        private System.Windows.Forms.TextBox txt_nya_Persona;
        private System.Windows.Forms.Label lb_dni;
        private System.Windows.Forms.Label lb_nya_Persona;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txt_NroDeTramite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_RecargarLista;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}