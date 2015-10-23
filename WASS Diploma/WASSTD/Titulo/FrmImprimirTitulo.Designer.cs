namespace WASSTD
{
    partial class FrmImprimirTitulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImprimirTitulo));
            this.ProfesionalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Titulos = new WASSTD.Titulos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProfesionalesTableAdapter = new WASSTD.TitulosTableAdapters.ProfesionalesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesionalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Titulos)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfesionalesBindingSource
            // 
            this.ProfesionalesBindingSource.DataMember = "Profesionales";
            this.ProfesionalesBindingSource.DataSource = this.Titulos;
            // 
            // Titulos
            // 
            this.Titulos.DataSetName = "Titulos";
            this.Titulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Titulos";
            reportDataSource1.Value = this.ProfesionalesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WASSTD.Titulo.Titulos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(569, 522);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProfesionalesTableAdapter
            // 
            this.ProfesionalesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmImprimirTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 522);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmImprimirTitulo";
            this.Text = "Impresión de Titulo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmImprimirTitulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfesionalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Titulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProfesionalesBindingSource;
        private Titulos Titulos;
        private TitulosTableAdapters.ProfesionalesTableAdapter ProfesionalesTableAdapter;
    }
}