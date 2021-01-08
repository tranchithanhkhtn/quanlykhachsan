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
    public partial class frmRentList : Form
    {
        public frmRentList()
        {
            InitializeComponent();
            dtgvRentList.DataSource = RentListDAO.Instance.Load_Data();
        }
        private void frmRentList_Load(object sender, EventArgs e)
        {
            dtgvRentList.DataSource = RentListDAO.Instance.Load_Data();
            try
            {
                for (int i = 0; i < dtgvRentList.Rows.Count; i++)
                {
                    DateTime ngaythue = Convert.ToDateTime(dtgvRentList.Rows[i].Cells["NgayThue"].Value);
                    DateTime ngaytra = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy"));
                    TimeSpan Time = ngaytra - ngaythue;
                    int condition = Time.Days;
                    if (condition > Int32.Parse(dtgvRentList.Rows[i].Cells["SoNgayThue"].Value.ToString()))
                    {
                        this.dtgvRentList.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
            catch
            {
                frmMessageBox fr = new frmMessageBox();
                frmMessageBox.text = "Database Empty!";
                fr.ShowDialog();
            }
            
          
        }
        public static string name = "";
        private void rdIdentityCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rdIdentityCard.Checked == true)
            {
                lbIdentityCard.ForeColor = Color.DodgerBlue;
                txbSearch.PlaceholderText = "Search by Identity Card";
                txbSearch.Enabled = true;
            }
            else
            {
                lbIdentityCard.ForeColor = Color.FromArgb(117, 117, 117);
                txbSearch.PlaceholderText = "Search here";
            }
        }

        private void rdName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdName.Checked == true)
            {
                lbName.ForeColor = Color.DodgerBlue;
                txbSearch.PlaceholderText = "Search by Customer Name";
                txbSearch.Enabled = true;
            }
            else
            {
                lbName.ForeColor = Color.FromArgb(117, 117, 117);
                txbSearch.PlaceholderText = "Search here";
            }
        }

        private void dtgvRentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if(rowIndex >= 0)
            {
                DateTime ngaythue = Convert.ToDateTime(dtgvRentList.Rows[rowIndex].Cells["NgayThue"].Value);
                DateTime ngaytra = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy"));
                TimeSpan Time = ngaytra - ngaythue;
                int condition = Time.Days;
                if (condition > Int32.Parse(dtgvRentList.Rows[rowIndex].Cells["SoNgayThue"].Value.ToString()))
                {
                    this.dtgvRentList.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
                if (dtgvRentList.Columns[e.ColumnIndex].Name == "BillPayment")
                {
                    frmPayRentList fr = new frmPayRentList(dtgvRentList.Rows[rowIndex].Cells["MaKH"].Value.ToString(), dtgvRentList.Rows[rowIndex].Cells["TenKH"].Value.ToString(),
                       dtgvRentList.Rows[rowIndex].Cells["SoCMND"].Value.ToString(), dtgvRentList.Rows[rowIndex].Cells["MaPhong"].Value.ToString(),
                       dtgvRentList.Rows[rowIndex].Cells["NgayThue"].Value.ToString(), Int32.Parse(dtgvRentList.Rows[rowIndex].Cells["SoNgayThue"].Value.ToString()), name);
                    fr.Show();
                    fr.FormClosing += (or, er) =>
                    {

                        this.dtgvRentList.DataSource = RentListDAO.Instance.Load_Data();
                    };
                }
                if (dtgvRentList.Columns[e.ColumnIndex].Name == "ExtendMore")
                {
                    if (condition >= Int32.Parse(dtgvRentList.Rows[rowIndex].Cells["SoNgayThue"].Value.ToString()))
                    {
                        frmExtendMore fr = new frmExtendMore(dtgvRentList.Rows[rowIndex].Cells["MaKH"].Value.ToString(), dtgvRentList.Rows[rowIndex].Cells["TenKH"].Value.ToString(), dtgvRentList.Rows[rowIndex].Cells["SoCMND"].Value.ToString(),
                           dtgvRentList.Rows[rowIndex].Cells["MaPhong"].Value.ToString());
                        fr.ShowDialog();
                    }
                    else
                    {
                        frmMessageBox fr = new frmMessageBox();
                        frmMessageBox.text = "You are not eligible for further extension! Please check again";
                        fr.ShowDialog();
                    }
                }
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            if(rdIdentityCard.Checked == true)
            {
                dtgvRentList.DataSource = RentListDAO.Instance.Load_CustomerCode(txbSearch.Text);
                if(dtgvRentList.Rows.Count == 0)
                {
                    dtgvRentList.Enabled = false;
                }
                else
                {
                    dtgvRentList.Enabled = true;
                }
            }
            else if (rdName.Checked == true)
            {
                dtgvRentList.DataSource = RentListDAO.Instance.Load_CustomerName(txbSearch.Text);
                if (dtgvRentList.Rows.Count == 0)
                {
                    dtgvRentList.Enabled = false;
                }
                else
                {
                    dtgvRentList.Enabled = true;
                }
            }
        }
        
    }
}
