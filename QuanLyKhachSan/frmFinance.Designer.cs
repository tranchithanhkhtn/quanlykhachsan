namespace QuanLyKhachSan
{
    partial class frmFinance
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
            this.USP_DOANHTHU_DATHUEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyKhachSanDataSet = new QuanLyKhachSan.QuanLyKhachSanDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpToDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnStatistical = new Guna.UI2.WinForms.Guna2GradientButton();
            this.USP_DOANHTHU_DATHUETableAdapter = new QuanLyKhachSan.QuanLyKhachSanDataSetTableAdapters.USP_DOANHTHU_DATHUETableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.USP_DOANHTHU_DATHUEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyKhachSanDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // USP_DOANHTHU_DATHUEBindingSource
            // 
            this.USP_DOANHTHU_DATHUEBindingSource.DataMember = "USP_DOANHTHU_DATHUE";
            this.USP_DOANHTHU_DATHUEBindingSource.DataSource = this.QuanLyKhachSanDataSet;
            // 
            // QuanLyKhachSanDataSet
            // 
            this.QuanLyKhachSanDataSet.DataSetName = "QuanLyKhachSanDataSet";
            this.QuanLyKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 5);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro Med", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "From date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro Med", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "To date :";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CheckedState.Parent = this.dtpFromDate;
            this.dtpFromDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.HoverState.Parent = this.dtpFromDate;
            this.dtpFromDate.Location = new System.Drawing.Point(133, 12);
            this.dtpFromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.ShadowDecoration.Parent = this.dtpFromDate;
            this.dtpFromDate.Size = new System.Drawing.Size(187, 36);
            this.dtpFromDate.TabIndex = 4;
            this.dtpFromDate.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // dtpToDay
            // 
            this.dtpToDay.CheckedState.Parent = this.dtpToDay;
            this.dtpToDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpToDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDay.HoverState.Parent = this.dtpToDay;
            this.dtpToDay.Location = new System.Drawing.Point(447, 12);
            this.dtpToDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpToDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpToDay.Name = "dtpToDay";
            this.dtpToDay.ShadowDecoration.Parent = this.dtpToDay;
            this.dtpToDay.Size = new System.Drawing.Size(187, 36);
            this.dtpToDay.TabIndex = 4;
            this.dtpToDay.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // btnStatistical
            // 
            this.btnStatistical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatistical.CheckedState.Parent = this.btnStatistical;
            this.btnStatistical.CustomImages.Parent = this.btnStatistical;
            this.btnStatistical.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStatistical.ForeColor = System.Drawing.Color.White;
            this.btnStatistical.HoverState.Parent = this.btnStatistical;
            this.btnStatistical.Location = new System.Drawing.Point(892, 12);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.ShadowDecoration.Parent = this.btnStatistical;
            this.btnStatistical.Size = new System.Drawing.Size(191, 38);
            this.btnStatistical.TabIndex = 33;
            this.btnStatistical.Text = "STATISTICAL";
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // USP_DOANHTHU_DATHUETableAdapter
            // 
            this.USP_DOANHTHU_DATHUETableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.USP_DOANHTHU_DATHUEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyKhachSan.DoanhThu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 56);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1117, 581);
            this.reportViewer1.TabIndex = 34;
            // 
            // frmFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 649);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnStatistical);
            this.Controls.Add(this.dtpToDay);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFinance";
            this.Text = "frmFinance";
            this.Load += new System.EventHandler(this.frmFinance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USP_DOANHTHU_DATHUEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyKhachSanDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFromDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpToDay;
        private Guna.UI2.WinForms.Guna2GradientButton btnStatistical;
        private System.Windows.Forms.BindingSource USP_DOANHTHU_DATHUEBindingSource;
        private QuanLyKhachSanDataSet QuanLyKhachSanDataSet;
        private QuanLyKhachSanDataSetTableAdapters.USP_DOANHTHU_DATHUETableAdapter USP_DOANHTHU_DATHUETableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}