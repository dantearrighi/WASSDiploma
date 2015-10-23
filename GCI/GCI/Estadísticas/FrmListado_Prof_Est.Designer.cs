namespace GCI
{
    partial class FrmListado_Prof_Est
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListado_Prof_Est));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Listados_Profesionales = new GCI.Listados_Profesionales();
            this.ProfesionalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProfesionalesTableAdapter = new GCI.Listados_ProfesionalesTableAdapters.ProfesionalesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Listados_Profesionales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesionalesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProfesionalesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GCI.Estadísticas.Profesionales_Por_Estado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(569, 522);
            this.reportViewer1.TabIndex = 0;
            // 
            // Listados_Profesionales
            // 
            this.Listados_Profesionales.DataSetName = "Listados_Profesionales";
            this.Listados_Profesionales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProfesionalesBindingSource
            // 
            this.ProfesionalesBindingSource.DataMember = "Profesionales";
            this.ProfesionalesBindingSource.DataSource = this.Listados_Profesionales;
            // 
            // ProfesionalesTableAdapter
            // 
            this.ProfesionalesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmListado_Prof_Est
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 522);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListado_Prof_Est";
            this.Text = "Listado por estado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmListado_Prof_Est_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Listados_Profesionales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesionalesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProfesionalesBindingSource;
        private Listados_Profesionales Listados_Profesionales;
        private Listados_ProfesionalesTableAdapters.ProfesionalesTableAdapter ProfesionalesTableAdapter;
    }
}