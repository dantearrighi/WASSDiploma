namespace WASSTD.Ayuda
{
    partial class FrmManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManual));
            this.pdfmanual = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.pdfmanual)).BeginInit();
            this.SuspendLayout();
            // 
            // pdfmanual
            // 
            this.pdfmanual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfmanual.Enabled = true;
            this.pdfmanual.Location = new System.Drawing.Point(12, 72);
            this.pdfmanual.Name = "pdfmanual";
            this.pdfmanual.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfmanual.OcxState")));
            this.pdfmanual.Size = new System.Drawing.Size(718, 479);
            this.pdfmanual.TabIndex = 0;
            // 
            // FrmManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 563);
            this.Controls.Add(this.pdfmanual);
            this.Name = "FrmManual";
            this.Text = "Manual";
            this.Load += new System.EventHandler(this.Manual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pdfmanual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF pdfmanual;
    }
}