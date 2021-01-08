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
    public partial class frmExtendMore : Form
    {
        public frmExtendMore()
        {
            InitializeComponent();
        }
        string makhachhang = "";
        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public frmExtendMore(string makh,string hoten, string cmnd, string phongthue) : this()
        {
            makhachhang = makh;
            lbCustomerName.Text = hoten;
            lbIdentityCard.Text = cmnd;
            lbRoomCode.Text = phongthue;

        }

        private void txbCodeRoom_Enter(object sender, EventArgs e)
        {
            String fname = txbNumberDay.Text;
            if (fname.Equals("Enter Number"))
            {
                txbNumberDay.Text = "";
                txbNumberDay.ForeColor = Color.Black;
            }
        }

        private void txbCodeRoom_Leave(object sender, EventArgs e)
        {
            String fname = txbNumberDay.Text;
            if (fname.ToLower().Trim().Equals("Enter Number") || fname.Equals(""))
            {
                txbNumberDay.Text = "Enter Number";
                txbNumberDay.ForeColor = Color.Silver;
            }
        }

        private void txbCodeRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void frmExtendMore_Load(object sender, EventArgs e)
        {
            lbRenewalDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            lbRentCode.Text = PayRentListDAO.Instance.Load_Maphieuthue(makhachhang);
        }

        private void btnRenewal_Click(object sender, EventArgs e)
        {
            if(txbNumberDay.Text == "" || txbNumberDay.Text == "Enter Number")
            {
                frmMessageBox fr = new frmMessageBox();
                frmMessageBox.text = "You have not entered the number of renewal dates";
                fr.ShowDialog();
                plRoomCode.BackColor = Color.Red;
            }
            else
            {
                try
                {
                    PayRentListDAO.Instance.Insert_GIAHAN(lbRentCode.Text, Int32.Parse(txbNumberDay.Text), lbRenewalDate.Text);
                    MessageBoxSuccess ms = new MessageBoxSuccess();
                    this.Close();
                    ms.ShowDialog();
                }
                catch
                {
                    frmMessageBox fr = new frmMessageBox();
                    frmMessageBox.text = "Error SqlDatabase: Trouble in Database!";
                    fr.ShowDialog();
                }

            }
        }

        private void txbNumberDay_TextChanged(object sender, EventArgs e)
        {
            if(txbNumberDay.Text != "")
            {
                plRoomCode.BackColor = Color.FromArgb(94, 148, 255);
            }
        }
    }
}
