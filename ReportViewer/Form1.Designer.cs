namespace ReportViewerControlApplication
{
    partial class Form1
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
            this.IncidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new ReportViewerControlApplication.DataSet1();
            this.dataSet11 = new ReportViewerControlApplication.DataSet1();
            this.sql29409_db_10825756_hostedresource_com_sql29409 = new Devart.Data.MySql.MySqlConnection();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cmdFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IncidentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1.Incident)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11.Incident)).BeginInit();
            this.SuspendLayout();
            // 
            // IncidentBindingSource
            // 
            this.IncidentBindingSource.DataMember = "Incident";
            this.IncidentBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            // 
            // Incident
            // 
            this.DataSet1.Incident.Owner = this;
            this.DataSet1.Name = "DataSet1";
            this.DataSet1.Owner = this;
            // 
            // dataSet11
            // 
            this.dataSet11.Connection = this.sql29409_db_10825756_hostedresource_com_sql29409;
            this.dataSet11.DataSetName = "DataSet1";
            // 
            // Incident
            // 
            this.dataSet11.Incident.Owner = this;
            this.dataSet11.Name = "dataSet11";
            this.dataSet11.Owner = this;
            // 
            // sql29409_db_10825756_hostedresource_com_sql29409
            // 
            this.sql29409_db_10825756_hostedresource_com_sql29409.ConnectionString = "User Id=sql29409;Password=Aa3969889!;Host=sql29409.db.10825756.hostedresource.com" +
    ";Database=sql29409;";
            this.sql29409_db_10825756_hostedresource_com_sql29409.Name = "sql29409_db_10825756_hostedresource_com_sql29409";
            this.sql29409_db_10825756_hostedresource_com_sql29409.Owner = this;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.IncidentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportViewerControlApplication.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(759, 340);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(56, 37);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 20);
            this.txtFilter.TabIndex = 1;
            // 
            // cmdFilter
            // 
            this.cmdFilter.Location = new System.Drawing.Point(162, 34);
            this.cmdFilter.Name = "cmdFilter";
            this.cmdFilter.Size = new System.Drawing.Size(75, 23);
            this.cmdFilter.TabIndex = 2;
            this.cmdFilter.Text = "Filter";
            this.cmdFilter.UseVisualStyleBackColor = true;
            this.cmdFilter.Click += new System.EventHandler(this.cmdFilter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 408);
            this.Controls.Add(this.cmdFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IncidentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1.Incident)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11.Incident)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet11;
        private Devart.Data.MySql.MySqlConnection sql29409_db_10825756_hostedresource_com_sql29409;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource IncidentBindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button cmdFilter;
    }
}

