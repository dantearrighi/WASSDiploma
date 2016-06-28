namespace WASSTD.Reportes
{
    partial class Frm_Tramites_x_Persona
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
            this.DS_Tramites_x_Persona = new WASSTD.Reportes.DS_Tramites_x_Persona();
            this.Tramites_x_PersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tramites_x_PersonaTableAdapter = new WASSTD.Reportes.DS_Tramites_x_PersonaTableAdapters.Tramites_x_PersonaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Tramites_x_Persona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tramites_x_PersonaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Tramites_x_Persona";
            reportDataSource1.Value = this.Tramites_x_PersonaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WASSTD.Reportes.Tramites_x_Persona.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(624, 420);
            this.reportViewer1.TabIndex = 0;
            // 
            // DS_Tramites_x_Persona
            // 
            this.DS_Tramites_x_Persona.DataSetName = "DS_Tramites_x_Persona";
            this.DS_Tramites_x_Persona.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tramites_x_PersonaBindingSource
            // 
            this.Tramites_x_PersonaBindingSource.DataMember = "Tramites_x_Persona";
            this.Tramites_x_PersonaBindingSource.DataSource = this.DS_Tramites_x_Persona;
            // 
            // Tramites_x_PersonaTableAdapter
            // 
            this.Tramites_x_PersonaTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Tramites_x_Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 420);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Tramites_x_Persona";
            this.Text = "Frm_Tramites_x_Persona";
            this.Load += new System.EventHandler(this.Frm_Tramites_x_Persona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Tramites_x_Persona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tramites_x_PersonaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tramites_x_PersonaBindingSource;
        private DS_Tramites_x_Persona DS_Tramites_x_Persona;
        private DS_Tramites_x_PersonaTableAdapters.Tramites_x_PersonaTableAdapter Tramites_x_PersonaTableAdapter;
    }
}