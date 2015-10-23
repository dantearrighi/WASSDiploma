namespace GCI
{
    partial class FrmImprimirCertificado_I
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImprimirCertificado_I));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Certificado_Prof_I = new GCI.Certificado_Prof_I();
            this.ProfesionalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProfesionalesTableAdapter = new GCI.Certificado_Prof_ITableAdapters.ProfesionalesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Certificado_Prof_I)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesionalesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Incumbencias";
            reportDataSource1.Value = this.ProfesionalesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GCI.Profesional.Certificado_Incumbencias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(569, 522);
            this.reportViewer1.TabIndex = 0;
            // 
            // Certificado_Prof_I
            // 
            this.Certificado_Prof_I.DataSetName = "Certificado_Prof_I";
            this.Certificado_Prof_I.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProfesionalesBindingSource
            // 
            this.ProfesionalesBindingSource.DataMember = "Profesionales";
            this.ProfesionalesBindingSource.DataSource = this.Certificado_Prof_I;
            // 
            // ProfesionalesTableAdapter
            // 
            this.ProfesionalesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmImprimirCertificado_I
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 522);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmImprimirCertificado_I";
            this.Text = "Impresión de certificado profesional";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmImprimirCertificado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Certificado_Prof_I)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesionalesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProfesionalesBindingSource;
        private Certificado_Prof_I Certificado_Prof_I;
        private Certificado_Prof_ITableAdapters.ProfesionalesTableAdapter ProfesionalesTableAdapter;

    }
}