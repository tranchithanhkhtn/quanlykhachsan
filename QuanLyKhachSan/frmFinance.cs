using QuanLyKhachSan.DTO;
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
    public partial class frmFinance : Form
    {
        public frmFinance()
        {
            InitializeComponent();
        }

        private void frmFinance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyKhachSanDataSet.USP_DOANHTHU_DATHUE' table. You can move, or remove it, as needed.
            this.USP_DOANHTHU_DATHUETableAdapter.Fill(this.QuanLyKhachSanDataSet.USP_DOANHTHU_DATHUE, DateTime.Parse(dtpFromDate.Value.ToString("yyyy-MM-dd")), DateTime.Parse(dtpToDay.Value.ToString("yyyy-MM-dd")));

            this.reportViewer1.RefreshReport();
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            this.USP_DOANHTHU_DATHUETableAdapter.Fill(this.QuanLyKhachSanDataSet.USP_DOANHTHU_DATHUE, DateTime.Parse(dtpFromDate.Value.ToString("yyyy-MM-dd")), DateTime.Parse(dtpToDay.Value.ToString("yyyy-MM-dd")));

            this.reportViewer1.RefreshReport();
        }
    }
}
