namespace Sisconcad
{
    partial class FormFichas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Sisconcad.DataSet();
            this.reportViewerFicha = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerConsulta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pacientesTableAdapter = new Sisconcad.DataSetTableAdapters.PacientesTableAdapter();
            this.dataSet2 = new Sisconcad.DataSet2();
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultasTableAdapter = new Sisconcad.DataSet2TableAdapters.ConsultasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerFicha
            // 
            reportDataSource4.Name = "DataSet";
            reportDataSource4.Value = this.pacientesBindingSource;
            this.reportViewerFicha.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewerFicha.LocalReport.ReportEmbeddedResource = "Sisconcad.Ficha.rdlc";
            this.reportViewerFicha.Location = new System.Drawing.Point(0, 0);
            this.reportViewerFicha.Name = "reportViewerFicha";
            this.reportViewerFicha.Size = new System.Drawing.Size(763, 977);
            this.reportViewerFicha.TabIndex = 0;
            // 
            // reportViewerConsulta
            // 
            reportDataSource5.Name = "DataSetPacientes";
            reportDataSource5.Value = this.pacientesBindingSource;
            reportDataSource6.Name = "DataSetConsultas";
            reportDataSource6.Value = this.dataSet2BindingSource;
            this.reportViewerConsulta.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewerConsulta.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewerConsulta.LocalReport.ReportEmbeddedResource = "Sisconcad.FichaCompleta.rdlc";
            this.reportViewerConsulta.Location = new System.Drawing.Point(0, 0);
            this.reportViewerConsulta.Name = "reportViewerConsulta";
            this.reportViewerConsulta.Size = new System.Drawing.Size(751, 977);
            this.reportViewerConsulta.TabIndex = 1;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet2BindingSource
            // 
            this.dataSet2BindingSource.DataMember = "Consultas";
            this.dataSet2BindingSource.DataSource = this.dataSet2;
            // 
            // consultasTableAdapter
            // 
            this.consultasTableAdapter.ClearBeforeFill = true;
            // 
            // FormFichas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 977);
            this.Controls.Add(this.reportViewerConsulta);
            this.Controls.Add(this.reportViewerFicha);
            this.Name = "FormFichas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fichas";
            this.Load += new System.EventHandler(this.Fichas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerFicha;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private DataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerConsulta;
        private System.Windows.Forms.BindingSource dataSet2BindingSource;
        private DataSet2 dataSet2;
        private DataSet2TableAdapters.ConsultasTableAdapter consultasTableAdapter;
    }
}