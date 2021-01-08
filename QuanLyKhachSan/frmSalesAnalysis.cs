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
    public partial class frmSalesAnalysis : Form
    {
        public frmSalesAnalysis()
        {
            InitializeComponent();
        }

        void Load_Chart()
        {
            DataTable dt = SalesAnalysisDAO.Instance.Revenue_SalesAnalysis();

            for (int j = 0; j < dt.Rows.Count; j++)
            {
                for (int i = 0; i < 24; i++)
                {
                    if (Int32.Parse(dt.Rows[j]["GioThue"].ToString().Substring(0, 2)) == i)
                    {
                        this.chartSalesAnalysis.Series["SL Khách Thuê"].Points.AddXY(Int32.Parse(dt.Rows[j]["GioThue"].ToString().Substring(0, 2)), dt.Rows[j]["Số Lượt Thuê"]);
                    }
                    else
                    {
                        this.chartSalesAnalysis.Series["SL Khách Thuê"].Points.AddXY(i, 0);
                    }
                }
            }
        }

        private void frmSalesAnalysis_Load(object sender, EventArgs e)
        {
            lbDay.Text = DateTime.Now.ToString("dd");
            lbMonth.Text = DateTime.Now.ToString("MM");
            lbYear.Text = DateTime.Now.ToString("yyyy");
            Load_Chart();
        }
    }
}
