using QuanLyKhachSan.DAO;
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
    public partial class frmRevenue : Form
    {
        public frmRevenue()
        {
            InitializeComponent();
        }

        public static int status = 0;
        void Load_ChartRental()
        {
            DataTable dt = TransactionInvoiceDAO.Instance.Revenue_RentalSlip();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.chartRental.Series["SL Phiếu Thuê"].Points.AddXY(dt.Rows[i]["MaPhong"], dt.Rows[i]["SL Phiếu Thuê"]);
            }
        }

        void Load_ChartReturn()
        {
            DataTable dt = TransactionInvoiceDAO.Instance.Revenue_ReturnSlip();
            for (int i = 0; i < 12; i++)
            {
                for (int j = i; j < dt.Rows.Count; j++)
                {
                    this.chartRental.Series["Tháng"].Points.AddXY(dt.Rows[j]["Thang"], dt.Rows[j]["TongTien"]);

                }
                this.chartRental.Series["Tháng"].Points.AddXY(i, 0);
            }
        }



        private void frmRevenue_Load(object sender, EventArgs e)
        {
            if (status == 0)
            {
                Load_ChartRental();
            }
            if (status == 1)
            {
                Load_ChartReturn();
            }
        }
    }
}
