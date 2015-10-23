namespace GCI
{
    partial class FrmImprimirBoleta
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImprimirBoleta));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Boletas = new GCI.Boletas();
            this.CuotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CuotasTableAdapter = new GCI.BoletasTableAdapters.CuotasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Boletas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuotasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Boletas";
            reportDataSource1.Value = this.CuotasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GCI.Cuotas.Boletas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(569, 522);
            this.reportViewer1.TabIndex = 0;
            // 
            // Boletas
            // 
            this.Boletas.DataSetName = "Boletas";
            this.Boletas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CuotasBindingSource
            // 
            this.CuotasBindingSource.DataMember = "Cuotas";
            this.CuotasBindingSource.DataSource = this.Boletas;
            // 
            // CuotasTableAdapter
            // 
            this.CuotasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmImprimirBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 522);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmImprimirBoleta";
            this.Text = "Impresión de boletas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmImprimirBoleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Boletas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuotasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private BoletasTableAdapters.CuotasTableAdapter MovimientosTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CuotasBindingSource;
        private Boletas Boletas;
        private BoletasTableAdapters.CuotasTableAdapter CuotasTableAdapter;
    }
}