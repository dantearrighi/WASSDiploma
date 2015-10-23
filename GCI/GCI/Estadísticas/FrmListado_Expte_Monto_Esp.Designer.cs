﻿namespace GCI
{
    partial class FrmListado_Expte_Monto_Esp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListado_Expte_Monto_Esp));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Listado_Exptes_Monto_Esp = new GCI.Listado_Exptes_Monto_Esp();
            this.MovimientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MovimientosTableAdapter = new GCI.Listado_Exptes_Monto_EspTableAdapters.MovimientosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Listado_Exptes_Monto_Esp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Exptes_Por_Monto_Esp";
            reportDataSource1.Value = this.MovimientosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GCI.Estadísticas.Expedientes_Por_Monto_Esp.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(569, 522);
            this.reportViewer1.TabIndex = 0;
            // 
            // Listado_Exptes_Monto_Esp
            // 
            this.Listado_Exptes_Monto_Esp.DataSetName = "Listado_Exptes_Monto_Esp";
            this.Listado_Exptes_Monto_Esp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MovimientosBindingSource
            // 
            this.MovimientosBindingSource.DataMember = "Movimientos";
            this.MovimientosBindingSource.DataSource = this.Listado_Exptes_Monto_Esp;
            // 
            // MovimientosTableAdapter
            // 
            this.MovimientosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmListado_Expte_Monto_Esp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.ClientSize = new System.Drawing.Size(569, 522);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListado_Expte_Monto_Esp";
            this.Text = "Listado de montos de expedientes por especialidad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmListado_Expte_Monto_Esp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Listado_Exptes_Monto_Esp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MovimientosBindingSource;
        private Listado_Exptes_Monto_Esp Listado_Exptes_Monto_Esp;
        private Listado_Exptes_Monto_EspTableAdapters.MovimientosTableAdapter MovimientosTableAdapter;
    }
}