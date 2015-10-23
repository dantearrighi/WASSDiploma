namespace WASSTD
{
    partial class FrmListado_Mat_Esp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListado_Mat_Esp));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Listados_Mat_Esp = new WASSTD.Listados_Mat_Esp();
            this.ProfesionalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProfesionalesTableAdapter = new WASSTD.Listados_Mat_EspTableAdapters.ProfesionalesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Listados_Mat_Esp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesionalesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Mat_Por_Esp";
            reportDataSource1.Value = this.ProfesionalesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WASSTD.Estadísticas.Matriculas_Por_Esp.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(569, 522);
            this.reportViewer1.TabIndex = 0;
            // 
            // Listados_Mat_Esp
            // 
            this.Listados_Mat_Esp.DataSetName = "Listados_Mat_Esp";
            this.Listados_Mat_Esp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProfesionalesBindingSource
            // 
            this.ProfesionalesBindingSource.DataMember = "Profesionales";
            this.ProfesionalesBindingSource.DataSource = this.Listados_Mat_Esp;
            // 
            // ProfesionalesTableAdapter
            // 
            this.ProfesionalesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmListado_Mat_Esp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 522);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListado_Mat_Esp";
            this.Text = "Listado por especialidad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmListado_Mat_Esp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Listados_Mat_Esp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesionalesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProfesionalesBindingSource;
        private Listados_Mat_Esp Listados_Mat_Esp;
        private Listados_Mat_EspTableAdapters.ProfesionalesTableAdapter ProfesionalesTableAdapter;
    }
}