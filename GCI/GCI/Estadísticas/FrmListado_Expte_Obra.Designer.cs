namespace GCI
{
    partial class FrmListado_Expte_Obra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListado_Expte_Obra));
            this.ExpedientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Listados_Expte_Obra = new GCI.Listados_Expte_Obra();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ExpedientesTableAdapter = new GCI.Listados_Expte_ObraTableAdapters.ExpedientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ExpedientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listados_Expte_Obra)).BeginInit();
            this.SuspendLayout();
            // 
            // ExpedientesBindingSource
            // 
            this.ExpedientesBindingSource.DataMember = "Expedientes";
            this.ExpedientesBindingSource.DataSource = this.Listados_Expte_Obra;
            // 
            // Listados_Expte_Obra
            // 
            this.Listados_Expte_Obra.DataSetName = "Listados_Expte_Obra";
            this.Listados_Expte_Obra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Expte_Por_Obra";
            reportDataSource1.Value = this.ExpedientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GCI.Estadísticas.Expedientes_Por_Obra.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(569, 522);
            this.reportViewer1.TabIndex = 0;
            // 
            // ExpedientesTableAdapter
            // 
            this.ExpedientesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmListado_Expte_Obra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.ClientSize = new System.Drawing.Size(569, 522);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListado_Expte_Obra";
            this.Text = "FrmListado_Expte_Obra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmListado_Expte_Obra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExpedientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listados_Expte_Obra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ExpedientesBindingSource;
        private Listados_Expte_Obra Listados_Expte_Obra;
        private Listados_Expte_ObraTableAdapters.ExpedientesTableAdapter ExpedientesTableAdapter;
    }
}