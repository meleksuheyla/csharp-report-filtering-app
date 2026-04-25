namespace SORU2
{
    partial class Form2
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
            this.bilgiler3DataSet1 = new SORU2.bilgiler3DataSet1();
            this.Tablo1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tablo1TableAdapter = new SORU2.bilgiler3DataSet1TableAdapters.Tablo1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bilgiler3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Tablo1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SORU2.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(464, 417);
            this.reportViewer1.TabIndex = 0;
            // 
            // bilgiler3DataSet1
            // 
            this.bilgiler3DataSet1.DataSetName = "bilgiler3DataSet1";
            this.bilgiler3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tablo1BindingSource
            // 
            this.Tablo1BindingSource.DataMember = "Tablo1";
            this.Tablo1BindingSource.DataSource = this.bilgiler3DataSet1;
            // 
            // Tablo1TableAdapter
            // 
            this.Tablo1TableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 417);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bilgiler3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tablo1BindingSource;
        private bilgiler3DataSet1 bilgiler3DataSet1;
        private bilgiler3DataSet1TableAdapters.Tablo1TableAdapter Tablo1TableAdapter;
    }
}