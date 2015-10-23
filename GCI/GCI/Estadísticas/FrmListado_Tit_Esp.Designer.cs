namespace GCI
{
    partial class FrmListado_Tit_Esp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListado_Tit_Esp));
            this.TitulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Listado_Tit_Esp = new GCI.Listado_Tit_Esp();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TitulosTableAdapter = new GCI.Listado_Tit_EspTableAdapters.TitulosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TitulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listado_Tit_Esp)).BeginInit();
            this.SuspendLayout();
            // 
            // TitulosBindingSource
            // 
            this.TitulosBindingSource.DataMember = "Titulos";
            this.TitulosBindingSource.DataSource = this.Listado_Tit_Esp;
            // 
            // Listado_Tit_Esp
            // 
            this.Listado_Tit_Esp.DataSetName = "Listado_Tit_Esp";
            this.Listado_Tit_Esp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Tit_Por_Esp";
            reportDataSource1.Value = this.TitulosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GCI.Estadísticas.Titulos_Por_Esp.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(569, 522);
            this.reportViewer1.TabIndex = 0;
            // 
            // TitulosTableAdapter
            // 
            this.TitulosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmListado_Tit_Esp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 522);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListado_Tit_Esp";
            this.Text = "Listado por especialidad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmListado_Tit_Esp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TitulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listado_Tit_Esp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TitulosBindingSource;
        private Listado_Tit_Esp Listado_Tit_Esp;
        private Listado_Tit_EspTableAdapters.TitulosTableAdapter TitulosTableAdapter;
    }
}