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
    public partial class frmListCustomer : Form
    {
        public frmListCustomer()
        {
            InitializeComponent();
        }

        private void frmListCustomer_Load(object sender, EventArgs e)
        {
            dtgvListCustomer.AutoGenerateColumns = false;
            dtgvListCustomer.DataSource = HomepageDAO.Instance.Load_Customers();
            lbCustomerID.DataBindings.Clear();
            lbCustomerID.DataBindings.Add("Text", dtgvListCustomer.DataSource, "MaKH");
            lbFullName.DataBindings.Clear();
            lbFullName.DataBindings.Add("Text", dtgvListCustomer.DataSource, "TenKH");
            lbIdentityCard.DataBindings.Clear();
            lbIdentityCard.DataBindings.Add("Text", dtgvListCustomer.DataSource, "SoCMND");
            lbDayofBirth.DataBindings.Clear();
            lbDayofBirth.DataBindings.Add("Text", dtgvListCustomer.DataSource, "NgSinh");
            lbAddress.DataBindings.Clear();
            lbAddress.DataBindings.Add("Text", dtgvListCustomer.DataSource, "DiaChiTT");
        }

        private void dtgvListCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbCustomerID.DataBindings.Clear();
            lbCustomerID.DataBindings.Add("Text", dtgvListCustomer.DataSource, "MaKH");
            lbFullName.DataBindings.Clear();
            lbFullName.DataBindings.Add("Text", dtgvListCustomer.DataSource, "TenKH");
            lbIdentityCard.DataBindings.Clear();
            lbIdentityCard.DataBindings.Add("Text", dtgvListCustomer.DataSource, "SoCMND");
            lbDayofBirth.DataBindings.Clear();
            lbDayofBirth.DataBindings.Add("Text", dtgvListCustomer.DataSource, "NgSinh");
            lbAddress.DataBindings.Clear();
            lbAddress.DataBindings.Add("Text", dtgvListCustomer.DataSource, "DiaChiTT");
        }

        private void txbSeacrh_TextChanged(object sender, EventArgs e)
        {
            dtgvListCustomer.AutoGenerateColumns = false;
            dtgvListCustomer.DataSource = HomepageDAO.Instance.Search_Customers(txbSeacrh.Text);
            lbCustomerID.DataBindings.Clear();
            lbCustomerID.DataBindings.Add("Text", dtgvListCustomer.DataSource, "MaKH");
            lbFullName.DataBindings.Clear();
            lbFullName.DataBindings.Add("Text", dtgvListCustomer.DataSource, "TenKH");
            lbIdentityCard.DataBindings.Clear();
            lbIdentityCard.DataBindings.Add("Text", dtgvListCustomer.DataSource, "SoCMND");
            lbDayofBirth.DataBindings.Clear();
            lbDayofBirth.DataBindings.Add("Text", dtgvListCustomer.DataSource, "NgSinh");
            lbAddress.DataBindings.Clear();
            lbAddress.DataBindings.Add("Text", dtgvListCustomer.DataSource, "DiaChiTT");
        }
    }
}
