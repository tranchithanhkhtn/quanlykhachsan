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
    public partial class frmTransactiInvoice : Form
    {
        public frmTransactiInvoice()
        {
            InitializeComponent();
        }

        void LoadData_RentalSlip()
        {
            dtgvBill.DataSource = TransactionInvoiceDAO.Instance.Load_PhieuThue();
        }

        void LoadData_ReturnSlip()
        {
            dtgvBill.DataSource = TransactionInvoiceDAO.Instance.Load_PhieuTra();
        }

        void Search_RentalSlip()
        {
            dtgvBill.DataSource = TransactionInvoiceDAO.Instance.Search_PhieuThue(txbSeacrh.Text);
        }
        void Search_ReturnSlip()
        {
            dtgvBill.DataSource = TransactionInvoiceDAO.Instance.Search_PhieuTra(txbSeacrh.Text);
        }
        private void frmTransactiInvoice_Load(object sender, EventArgs e)
        {
            rdtRentalSlip.Checked = true;
            LoadData_RentalSlip();
        }

        private void rdtReturnSlip_CheckedChanged(object sender, EventArgs e)
        {
            if(rdtReturnSlip.Checked == true)
            {
                LoadData_ReturnSlip();
            }
            else
            {
                LoadData_RentalSlip();
            }
        }

        private void txbSeacrh_TextChanged(object sender, EventArgs e)
        {
            if(rdtRentalSlip.Checked == true)
            {
                Search_RentalSlip();
            }
            else if(rdtReturnSlip.Checked == true)
            {
                Search_ReturnSlip();
            }
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            frmRevenue fr = new frmRevenue();
            if(rdtReturnSlip.Checked == true)
            {
                frmRevenue.status = 1;
            }
            else
            {
                frmRevenue.status = 0;
            }
            fr.ShowDialog();
        }
    }
}
