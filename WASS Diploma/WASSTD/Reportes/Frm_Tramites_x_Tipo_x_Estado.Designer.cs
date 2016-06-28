namespace WASSTD.Reportes
{
    partial class Frm_Tramites_x_Tipo_x_Estado
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Tramites_x_Estado = new WASSTD.Reportes.Tramites_x_Estado();
            this.Tramites_x_Tipo_x_EstadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tramites_x_Tipo_x_EstadosTableAdapter = new WASSTD.Reportes.Tramites_x_EstadoTableAdapters.Tramites_x_Tipo_x_EstadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Tramites_x_Estado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tramites_x_Tipo_x_EstadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Tramites_x_Tipo_x_Estado";
            reportDataSource1.Value = this.Tramites_x_Tipo_x_EstadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WASSTD.Reportes.Tramites_x_Tipo_x_Estado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(759, 503);
            this.reportViewer1.TabIndex = 0;
            // 
            // Tramites_x_Estado
            // 
            this.Tramites_x_Estado.DataSetName = "Tramites_x_Estado";
            this.Tramites_x_Estado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tramites_x_Tipo_x_EstadosBindingSource
            // 
            this.Tramites_x_Tipo_x_EstadosBindingSource.DataMember = "Tramites_x_Tipo_x_Estados";
            this.Tramites_x_Tipo_x_EstadosBindingSource.DataSource = this.Tramites_x_Estado;
            // 
            // Tramites_x_Tipo_x_EstadosTableAdapter
            // 
            this.Tramites_x_Tipo_x_EstadosTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Tramites_x_Tipo_x_Estado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 503);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Tramites_x_Tipo_x_Estado";
            this.Text = "Frm_Tramites_x_Tipo_x_Estado";
            this.Load += new System.EventHandler(this.Frm_Tramites_x_Tipo_x_Estado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tramites_x_Estado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tramites_x_Tipo_x_EstadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tramites_x_Tipo_x_EstadosBindingSource;
        private Tramites_x_Estado Tramites_x_Estado;
        private Tramites_x_EstadoTableAdapters.Tramites_x_Tipo_x_EstadosTableAdapter Tramites_x_Tipo_x_EstadosTableAdapter;
    }
}