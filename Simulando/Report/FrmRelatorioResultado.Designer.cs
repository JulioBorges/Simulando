namespace Simulando.Report
{
    partial class FrmRelatorioResultado
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorioResultado));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QuestaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.QuestaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.QuestaoBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.resultadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Simulando.Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(588, 354);
            this.reportViewer1.TabIndex = 0;
            // 
            // QuestaoBindingSource
            // 
            this.QuestaoBindingSource.DataSource = typeof(Simulando.Classes.Questao);
            // 
            // resultadoBindingSource
            // 
            this.resultadoBindingSource.DataSource = typeof(Simulando.Classes.Resultado);
            // 
            // FrmRelatorioResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 354);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRelatorioResultado";
            this.Text = "Resultado de Prova";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRelatorioResultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuestaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource QuestaoBindingSource;
        private System.Windows.Forms.BindingSource resultadoBindingSource;
    }
}