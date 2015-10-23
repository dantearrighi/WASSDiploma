namespace GCI
{
    partial class FrmImprimirBoleta_Prof
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImprimirBoleta_Prof));
            this.MovimientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Boleta_Prof = new GCI.Boleta_Prof();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MovimientosTableAdapter = new GCI.Boleta_ProfTableAdapters.MovimientosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boleta_Prof)).BeginInit();
            this.SuspendLayout();
            // 
            // MovimientosBindingSource
            // 
            this.MovimientosBindingSource.DataMember = "Movimientos";
            this.MovimientosBindingSource.DataSource = this.Boleta_Prof;
            // 
            // Boleta_Prof
            // 
            this.Boleta_Prof.DataSetName = "Boleta_Prof";
            this.Boleta_Prof.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Boleta_Prof";
            reportDataSource1.Value = this.MovimientosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GCI.Cuotas.Boleta_Prof.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(569, 522);
            this.reportViewer1.TabIndex = 0;
            // 
            // MovimientosTableAdapter
            // 
            this.MovimientosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmImprimirBoleta_Prof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 522);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmImprimirBoleta_Prof";
            this.Text = "Reimpresion de boletas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmImprimirBoleta_Prof_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MovimientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boleta_Prof)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MovimientosBindingSource;
        private Boleta_Prof Boleta_Prof;
        private Boleta_ProfTableAdapters.MovimientosTableAdapter MovimientosTableAdapter;
    }
}