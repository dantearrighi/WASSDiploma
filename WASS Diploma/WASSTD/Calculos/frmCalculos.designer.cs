namespace WASSTD
{
    partial class frmCalculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnVetMalvina = new System.Windows.Forms.Button();
            this.btnHaber24241 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnVetMalvina);
            this.groupBox1.Controls.Add(this.btnHaber24241);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 181);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el tipo de cálculo";
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(154, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 73);
            this.button2.TabIndex = 13;
            this.button2.Text = "Otros B";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.button2, "Enviarme correo con formula y datos de ejemplo en Excel para agregar otro cálculo" +
        "");
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnVetMalvina
            // 
            this.btnVetMalvina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVetMalvina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVetMalvina.Location = new System.Drawing.Point(6, 98);
            this.btnVetMalvina.Name = "btnVetMalvina";
            this.btnVetMalvina.Size = new System.Drawing.Size(142, 73);
            this.btnVetMalvina.TabIndex = 12;
            this.btnVetMalvina.Text = "Veterano Malvinas";
            this.btnVetMalvina.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnVetMalvina, "Enviarme correo con formula y datos de ejemplo en Excel para agregar otro cálculo" +
        "");
            this.btnVetMalvina.UseVisualStyleBackColor = true;
            this.btnVetMalvina.Click += new System.EventHandler(this.btnVetMalvina_Click);
            // 
            // btnHaber24241
            // 
            this.btnHaber24241.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHaber24241.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHaber24241.Location = new System.Drawing.Point(6, 19);
            this.btnHaber24241.Name = "btnHaber24241";
            this.btnHaber24241.Size = new System.Drawing.Size(142, 73);
            this.btnHaber24241.TabIndex = 11;
            this.btnHaber24241.Text = "Haber Previsional 24.241";
            this.btnHaber24241.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHaber24241.UseVisualStyleBackColor = true;
            this.btnHaber24241.Click += new System.EventHandler(this.btnHaber24241_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(12, 199);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(326, 37);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmCalculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 242);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculos";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHaber24241;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVetMalvina;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btnCerrar;
    }
}