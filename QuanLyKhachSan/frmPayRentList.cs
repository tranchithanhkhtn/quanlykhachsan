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
    public partial class frmPayRentList : Form
    {
        public frmPayRentList()
        {
            InitializeComponent();
        }
        string makhachhang = "";
        double dongiatemp = 0;
        double totaltemp = 0;
        public frmPayRentList(string makh, string hoten, string cmnd, string phongthue, string ngaythue, int songaythue, string tennv) : this()
        {
            makhachhang = makh;
            lbCustomerName.Text = hoten;
            lbIdentityCard.Text = cmnd;
            lbRoomCode.Text = phongthue;
            lbRentDate.Text = ngaythue;
            lbNumofRentdate.Text = songaythue.ToString();
            lbNameEmployee.Text = tennv;
        }

        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPayRentList_Load(object sender, EventArgs e)
        {
            lbRentCode.Text = PayRentListDAO.Instance.Load_Maphieuthue(makhachhang);
            lbUnitPrice.Text = String.Format("{0:0,0 VND/Day}", Int32.Parse(PayRentListDAO.Instance.Load_DonGia(lbRoomCode.Text)));
            dongiatemp = Int32.Parse(PayRentListDAO.Instance.Load_DonGia(lbRoomCode.Text));
            lbTypeRoom.Text = PayRentListDAO.Instance.Load_LoaiPhong(lbRoomCode.Text);
            lbRenewalDate.Text = PayRentListDAO.Instance.Load_NgayGH(lbRentCode.Text);
            lbNumofDaysRenew.Text = PayRentListDAO.Instance.Load_SoNgayGH(lbRentCode.Text).ToString();
            DateTime ngaythue = Convert.ToDateTime(lbRentDate.Text);
            DateTime ngaytra = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy"));
            TimeSpan Time = ngaytra - ngaythue;
            lbdateNum.Text = Time.Days.ToString();
            if (Int32.Parse(lbdateNum.Text) > 0 && Int32.Parse(lbdateNum.Text) < Int32.Parse(lbNumofRentdate.Text) + Int32.Parse(lbNumofDaysRenew.Text))
            {
                lbStatus.Text = "Trả Trước " + (Int32.Parse(lbNumofRentdate.Text) + Int32.Parse(lbNumofDaysRenew.Text) - Int32.Parse(lbdateNum.Text)) + " ngày";
            }
            else if (Int32.Parse(lbdateNum.Text) == 0)
            {
                lbStatus.Text = "Đúng hạn";
            }
            else
            {
                lbStatus.Text = "Trả trễ " + (Int32.Parse(lbdateNum.Text) - Int32.Parse(lbNumofRentdate.Text)) + " ngày";
            }
            lbTotalPayment.Text = (Int32.Parse(lbdateNum.Text) * dongiatemp).ToString();
            lbTotalPayment.Text = String.Format("{0:0,0 VND}", Int32.Parse(lbTotalPayment.Text));
            totaltemp = (Int32.Parse(lbdateNum.Text) * dongiatemp);
            cbDiscount.Text = "No Discount";
        }
        private void cbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDiscount.Text == "VIP")
            {
                lbDiscount.Text = "17%";
            }
            else if (cbDiscount.Text == "Holiday")
            {
                lbDiscount.Text = "9%";

            }
            else if (cbDiscount.Text == "Special Day")
            {
                lbDiscount.Text = "10%";
            }
            else if (cbDiscount.Text == "Coupons")
            {
                lbDiscount.Text = "5%";
            }
            else
            {
                lbDiscount.Text = "0%";
            }
        }

        private void lbDiscount_TextChanged(object sender, EventArgs e)
        {
            if (lbDiscount.Text == "0%")
            {
                totaltemp = Int32.Parse(lbdateNum.Text) * dongiatemp;
                lbTotalPayment.Text = String.Format("{0:0,0 VND}", totaltemp);
            }
            if (lbDiscount.Text == "17%")
            {
                totaltemp = (Int32.Parse(lbdateNum.Text) * dongiatemp) - ((Int32.Parse(lbdateNum.Text) * dongiatemp) * 0.17);
                lbTotalPayment.Text = String.Format("{0:0,0 VND}", totaltemp);
            }
            if (lbDiscount.Text == "9%")
            {
                totaltemp = (Int32.Parse(lbdateNum.Text) * dongiatemp) - ((Int32.Parse(lbdateNum.Text) * dongiatemp) * 0.09);
                lbTotalPayment.Text = String.Format("{0:0,0 VND}", totaltemp);
            }
            if (lbDiscount.Text == "10%")
            {
                totaltemp = (Int32.Parse(lbdateNum.Text) * dongiatemp) - ((Int32.Parse(lbdateNum.Text) * dongiatemp) * 0.1);
                lbTotalPayment.Text = String.Format("{0:0,0 VND}", totaltemp);
            }
            if (lbDiscount.Text == "5%")
            {
                totaltemp = (Int32.Parse(lbdateNum.Text) * dongiatemp) - ((Int32.Parse(lbdateNum.Text) * dongiatemp) * 0.05);
                lbTotalPayment.Text = String.Format("{0:0,0 VND}", totaltemp);
            }
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            frmBillRoom fr = new frmBillRoom(makhachhang, lbRentCode.Text, lbStatus.Text, Int32.Parse(lbdateNum.Text), Convert.ToInt32(totaltemp), cbDiscount.Text, lbNameEmployee.Text);
            fr.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmMessageNotification frm = new frmMessageNotification();
            frmMessageNotification.text = "Do you want to Payment Room?";
            frm.Show();
            frm.ptClose.Click += (o, ev) =>
            {
                frm.Close();
            };
            frm.btnConfirm.Click += (o, ev) =>
            {
                try
                {
                    PayRentListDAO.Instance.Insert_PHIEUTRA_CTPT(lbRentCode.Text, DateTime.Now.ToString("MM/dd/yyyy"), lbRoomCode.Text, lbdateNum.Text, totaltemp.ToString(), cbDiscount.Text);
                    PayRentListDAO.Instance.Update_Status_PHONG(lbRoomCode.Text);
                    this.Close();
                    frm.Close();
                    MessageBoxSuccess ms = new MessageBoxSuccess();
                    ms.ShowDialog();
                }
                catch
                {
                    frmMessageBox fr = new frmMessageBox();
                    frmMessageBox.text = "Error SqlData: Trouble in database";
                    frm.Close();
                    fr.ShowDialog();
                }

            };
        }
    }
}
