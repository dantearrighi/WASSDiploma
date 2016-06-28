namespace WASSTD.Reportes
{
    partial class FrmReportes
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
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_CrearReporte = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_TxEstado = new System.Windows.Forms.RadioButton();
            this.rbTVencidos = new System.Windows.Forms.RadioButton();
            this.rbTxPersona = new System.Windows.Forms.RadioButton();
            this.rbTxTipo = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar.Location = new System.Drawing.Point(280, 191);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 40);
            this.btn_cerrar.TabIndex = 5;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // btn_CrearReporte
            // 
            this.btn_CrearReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CrearReporte.Location = new System.Drawing.Point(172, 191);
            this.btn_CrearReporte.Name = "btn_CrearReporte";
            this.btn_CrearReporte.Size = new System.Drawing.Size(102, 40);
            this.btn_CrearReporte.TabIndex = 6;
            this.btn_CrearReporte.Text = "Crear reporte";
            this.btn_CrearReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CrearReporte.UseVisualStyleBackColor = true;
            this.btn_CrearReporte.Click += new System.EventHandler(this.btn_CrearReporte_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btn_CrearReporte);
            this.groupBox1.Controls.Add(this.btn_cerrar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 238);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione un reporte";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton7);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Location = new System.Drawing.Point(192, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 143);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personas";
            // 
            // radioButton7
            // 
            this.radioButton7.Location = new System.Drawing.Point(6, 93);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(137, 24);
            this.radioButton7.TabIndex = 3;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Datos incompletos";
            this.radioButton7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.Location = new System.Drawing.Point(6, 33);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(137, 24);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Deudores";
            this.radioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.Location = new System.Drawing.Point(6, 63);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(137, 24);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Datos incompletos";
            this.radioButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_TxEstado);
            this.groupBox2.Controls.Add(this.rbTVencidos);
            this.groupBox2.Controls.Add(this.rbTxPersona);
            this.groupBox2.Controls.Add(this.rbTxTipo);
            this.groupBox2.Location = new System.Drawing.Point(6, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 143);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trámites";
            // 
            // rb_TxEstado
            // 
            this.rb_TxEstado.Location = new System.Drawing.Point(6, 49);
            this.rb_TxEstado.Name = "rb_TxEstado";
            this.rb_TxEstado.Size = new System.Drawing.Size(137, 24);
            this.rb_TxEstado.TabIndex = 1;
            this.rb_TxEstado.TabStop = true;
            this.rb_TxEstado.Text = "Trámites por estado";
            this.rb_TxEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_TxEstado.UseVisualStyleBackColor = true;
            // 
            // rbTVencidos
            // 
            this.rbTVencidos.Location = new System.Drawing.Point(6, 79);
            this.rbTVencidos.Name = "rbTVencidos";
            this.rbTVencidos.Size = new System.Drawing.Size(137, 24);
            this.rbTVencidos.TabIndex = 2;
            this.rbTVencidos.TabStop = true;
            this.rbTVencidos.Text = "Trámites vencidos";
            this.rbTVencidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbTVencidos.UseVisualStyleBackColor = true;
            // 
            // rbTxPersona
            // 
            this.rbTxPersona.Location = new System.Drawing.Point(6, 109);
            this.rbTxPersona.Name = "rbTxPersona";
            this.rbTxPersona.Size = new System.Drawing.Size(137, 24);
            this.rbTxPersona.TabIndex = 0;
            this.rbTxPersona.TabStop = true;
            this.rbTxPersona.Text = "Trámites por Persona";
            this.rbTxPersona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbTxPersona.UseVisualStyleBackColor = true;
            // 
            // rbTxTipo
            // 
            this.rbTxTipo.Location = new System.Drawing.Point(6, 19);
            this.rbTxTipo.Name = "rbTxTipo";
            this.rbTxTipo.Size = new System.Drawing.Size(137, 24);
            this.rbTxTipo.TabIndex = 0;
            this.rbTxTipo.TabStop = true;
            this.rbTxTipo.Text = "Trámites por tipo";
            this.rbTxTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbTxTipo.UseVisualStyleBackColor = true;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 263);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_CrearReporte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_TxEstado;
        private System.Windows.Forms.RadioButton rbTVencidos;
        private System.Windows.Forms.RadioButton rbTxPersona;
        private System.Windows.Forms.RadioButton rbTxTipo;
    }
}