using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyKhachSan
{
    public partial class frmBillRoom : Form
    {
        public frmBillRoom()
        {
            InitializeComponent();
        }
        string MaKH, MaPt, Status, Discount, TenNV;
        int NumofDay , Total;
        public frmBillRoom(string makh, string mapt, string status, int numofday, int total, string discount, string tennv) : this()
        {
            MaKH = makh;
            MaPt = mapt;
            Status = status;
            NumofDay = numofday;
            Total = total;
            Discount = discount;
            TenNV = tennv;
        }

        private void frmBillRoom_Load(object sender, EventArgs e)
        {
            ReportParameter rpt1 = new ReportParameter("Status", Status);
            ReportParameter rpt2 = new ReportParameter("NumofDay", NumofDay.ToString());
            ReportParameter rpt3 = new ReportParameter("Totalprice", Total.ToString());
            ReportParameter rpt4 = new ReportParameter("Discount", Discount);
            ReportParameter rpt5 = new ReportParameter("NameEmployee", TenNV);
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpt1, rpt2, rpt3, rpt4, rpt5 });
            this.reportViewer.RefreshReport();

            // TODO: This line of code loads data into the 'QuanLyKhachSanDataSet1.USP_HOADON_FOODS' table. You can move, or remove it, as needed.
            this.USP_HOADON_FOODSTableAdapter.Fill(this.QuanLyKhachSanDataSet1.USP_HOADON_FOODS, MaKH);
            // TODO: This line of code loads data into the 'QuanLyKhachSanDataSet1.USP_HOADON_GIAHAN' table. You can move, or remove it, as needed.
            this.USP_HOADON_GIAHANTableAdapter.Fill(this.QuanLyKhachSanDataSet1.USP_HOADON_GIAHAN, MaPt);
            // TODO: This line of code loads data into the 'QuanLyKhachSanDataSet1.USP_HOADON_KHACHHANG' table. You can move, or remove it, as needed.
            this.USP_HOADON_KHACHHANGTableAdapter.Fill(this.QuanLyKhachSanDataSet1.USP_HOADON_KHACHHANG, MaKH);
            // TODO: This line of code loads data into the 'QuanLyKhachSanDataSet1.USP_HOADON_PHONG' table. You can move, or remove it, as needed.
            this.USP_HOADON_PHONGTableAdapter.Fill(this.QuanLyKhachSanDataSet1.USP_HOADON_PHONG, MaPt);

           
            this.reportViewer.RefreshReport();
        }

        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
