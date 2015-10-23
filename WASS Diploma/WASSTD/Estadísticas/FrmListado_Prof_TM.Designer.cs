namespace WASSTD
{
    partial class FrmListado_Prof_TM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListado_Prof_TM));
            this.ProfesionalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Listados_Prof_TM = new WASSTD.Listados_Prof_TM();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProfesionalesTableAdapter = new WASSTD.Listados_Prof_TMTableAdapters.ProfesionalesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesionalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listados_Prof_TM)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfesionalesBindingSource
            // 
            this.ProfesionalesBindingSource.DataMember = "Profesionales";
            this.ProfesionalesBindingSource.DataSource = this.Listados_Prof_TM;
            // 
            // Listados_Prof_TM
            // 
            this.Listados_Prof_TM.DataSetName = "Listados_Prof_TM";
            this.Listados_Prof_TM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Prof_Por_TM";
            reportDataSource1.Value = this.ProfesionalesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WASSTD.Estadísticas.Profesionales_Por_TM.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(569, 522);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProfesionalesTableAdapter
            // 
            this.ProfesionalesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmListado_Prof_TM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 522);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListado_Prof_TM";
            this.Text = "Listado por tipo de matrícula";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmListado_Prof_TM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfesionalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listados_Prof_TM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProfesionalesBindingSource;
        private Listados_Prof_TM Listados_Prof_TM;
        private Listados_Prof_TMTableAdapters.ProfesionalesTableAdapter ProfesionalesTableAdapter;


    }
}