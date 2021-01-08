namespace QuanLyKhachSan
{
    partial class frmBillRoom
    {
        ///
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillRoom));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.ptClose = new System.Windows.Forms.PictureBox();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quanLyKhachSanDataSet11 = new QuanLyKhachSan.QuanLyKhachSanDataSet1();
            this.QuanLyKhachSanDataSet1 = new QuanLyKhachSan.QuanLyKhachSanDataSet1();
            this.USP_HOADON_FOODSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_HOADON_FOODSTableAdapter = new QuanLyKhachSan.QuanLyKhachSanDataSet1TableAdapters.USP_HOADON_FOODSTableAdapter();
            this.USP_HOADON_GIAHANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_HOADON_GIAHANTableAdapter = new QuanLyKhachSan.QuanLyKhachSanDataSet1TableAdapters.USP_HOADON_GIAHANTableAdapter();
            this.USP_HOADON_KHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_HOADON_KHACHHANGTableAdapter = new QuanLyKhachSan.QuanLyKhachSanDataSet1TableAdapters.USP_HOADON_KHACHHANGTableAdapter();
            this.USP_HOADON_PHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_HOADON_PHONGTableAdapter = new QuanLyKhachSan.QuanLyKhachSanDataSet1TableAdapters.USP_HOADON_PHONGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyKhachSanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_HOADON_FOODSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_HOADON_GIAHANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_HOADON_KHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_HOADON_PHONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 5);
            this.panel1.TabIndex = 49;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 7;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.Gray;
            // 
            // ptClose
            // 
            this.ptClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ptClose.Image = ((System.Drawing.Image)(resources.GetObject("ptClose.Image")));
            this.ptClose.Location = new System.Drawing.Point(643, 8);
            this.ptClose.Name = "ptClose";
            this.ptClose.Size = new System.Drawing.Size(30, 30);
            this.ptClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptClose.TabIndex = 50;
            this.ptClose.TabStop = false;
            this.ptClose.Click += new System.EventHandler(this.ptClose_Click);
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet_HoaDon_Foods";
            reportDataSource1.Value = this.USP_HOADON_FOODSBindingSource;
            reportDataSource2.Name = "DataSet_HoaDon_GiaHan";
            reportDataSource2.Value = this.USP_HOADON_GIAHANBindingSource;
            reportDataSource3.Name = "DataSet_HoaDon_KH";
            reportDataSource3.Value = this.USP_HOADON_KHACHHANGBindingSource;
            reportDataSource4.Name = "DataSet_HoaDon_Phong";
            reportDataSource4.Value = this.USP_HOADON_PHONGBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "QuanLyKhachSan.HoaDonThanhToan.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 44);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(679, 771);
            this.reportViewer.TabIndex = 51;
            // 
            // quanLyKhachSanDataSet11
            // 
            this.quanLyKhachSanDataSet11.DataSetName = "QuanLyKhachSanDataSet1";
            this.quanLyKhachSanDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // QuanLyKhachSanDataSet1
            // 
            this.QuanLyKhachSanDataSet1.DataSetName = "QuanLyKhachSanDataSet1";
            this.QuanLyKhachSanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_HOADON_FOODSBindingSource
            // 
            this.USP_HOADON_FOODSBindingSource.DataMember = "USP_HOADON_FOODS";
            this.USP_HOADON_FOODSBindingSource.DataSource = this.QuanLyKhachSanDataSet1;
            // 
            // USP_HOADON_FOODSTableAdapter
            // 
            this.USP_HOADON_FOODSTableAdapter.ClearBeforeFill = true;
            // 
            // USP_HOADON_GIAHANBindingSource
            // 
            this.USP_HOADON_GIAHANBindingSource.DataMember = "USP_HOADON_GIAHAN";
            this.USP_HOADON_GIAHANBindingSource.DataSource = this.QuanLyKhachSanDataSet1;
            // 
            // USP_HOADON_GIAHANTableAdapter
            // 
            this.USP_HOADON_GIAHANTableAdapter.ClearBeforeFill = true;
            // 
            // USP_HOADON_KHACHHANGBindingSource
            // 
            this.USP_HOADON_KHACHHANGBindingSource.DataMember = "USP_HOADON_KHACHHANG";
            this.USP_HOADON_KHACHHANGBindingSource.DataSource = this.QuanLyKhachSanDataSet1;
            // 
            // USP_HOADON_KHACHHANGTableAdapter
            // 
            this.USP_HOADON_KHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // USP_HOADON_PHONGBindingSource
            // 
            this.USP_HOADON_PHONGBindingSource.DataMember = "USP_HOADON_PHONG";
            this.USP_HOADON_PHONGBindingSource.DataSource = this.QuanLyKhachSanDataSet1;
            // 
            // USP_HOADON_PHONGTableAdapter
            // 
            this.USP_HOADON_PHONGTableAdapter.ClearBeforeFill = true;
            // 
            // frmBillRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 815);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.ptClose);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBillRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn Thanh Toán";
            this.Load += new System.EventHandler(this.frmBillRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyKhachSanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_HOADON_FOODSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_HOADON_GIAHANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_HOADON_KHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_HOADON_PHONGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.PictureBox ptClose;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private QuanLyKhachSanDataSet1 quanLyKhachSanDataSet11;
        private System.Windows.Forms.BindingSource USP_HOADON_FOODSBindingSource;
        private QuanLyKhachSanDataSet1 QuanLyKhachSanDataSet1;
        private System.Windows.Forms.BindingSource USP_HOADON_GIAHANBindingSource;
        private System.Windows.Forms.BindingSource USP_HOADON_KHACHHANGBindingSource;
        private System.Windows.Forms.BindingSource USP_HOADON_PHONGBindingSource;
        private QuanLyKhachSanDataSet1TableAdapters.USP_HOADON_FOODSTableAdapter USP_HOADON_FOODSTableAdapter;
        private QuanLyKhachSanDataSet1TableAdapters.USP_HOADON_GIAHANTableAdapter USP_HOADON_GIAHANTableAdapter;
        private QuanLyKhachSanDataSet1TableAdapters.USP_HOADON_KHACHHANGTableAdapter USP_HOADON_KHACHHANGTableAdapter;
        private QuanLyKhachSanDataSet1TableAdapters.USP_HOADON_PHONGTableAdapter USP_HOADON_PHONGTableAdapter;
    }
}
