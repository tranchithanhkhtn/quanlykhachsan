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
    public partial class frmBillRentRoom : Form
    {
        public frmBillRentRoom()
        {
            InitializeComponent();
        }
        frmMessageBox fr = new frmMessageBox();
        MessageBoxSuccess ms = new MessageBoxSuccess();
        
        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txbNumofDay_Enter(object sender, EventArgs e)
        {
            String fname = txbNumofDay.Text;
            if (fname.Equals("Text..."))
            {
                txbNumofDay.Text = "";
                txbNumofDay.ForeColor = Color.Black;
            }
        }

        private void txbNumofDay_Leave(object sender, EventArgs e)
        {
            String fname = txbNumofDay.Text;
            if (fname.ToLower().Trim().Equals("Text...") || fname.Equals(""))
            {
                txbNumofDay.Text = "Text...";
                txbNumofDay.ForeColor = Color.Silver;
            }
        }

        private void txbCard_Enter(object sender, EventArgs e)
        {
            String fname = txbCard.Text;
            if (fname.Equals("CMND hoặc Thẻ Căn Cước"))
            {
                txbCard.Text = "";
                txbCard.ForeColor = Color.Black;
            }
        }

        private void txbCard_Leave(object sender, EventArgs e)
        {
            String fname = txbCard.Text;
            if (fname.ToLower().Trim().Equals("CMND hoặc Thẻ Căn Cước") || fname.Equals(""))
            {
                txbCard.Text = "CMND hoặc Thẻ Căn Cước";
                txbCard.ForeColor = Color.Silver;
            }
        }


        private void txbFullName_Enter(object sender, EventArgs e)
        {
            String fname = txbFullName.Text;
            if (fname.Equals("~Nguyễn Văn A"))
            {
                txbFullName.Text = "";
                txbFullName.ForeColor = Color.Black;
            }
        }

        private void txbFullName_Leave(object sender, EventArgs e)
        {
            String fname = txbFullName.Text;
            if (fname.ToLower().Trim().Equals("~Nguyễn Văn A") || fname.Equals(""))
            {
                txbFullName.Text = "~Nguyễn Văn A";
                txbFullName.ForeColor = Color.Silver;
            }
        }

        private void txbAddress_Enter(object sender, EventArgs e)
        {
            String fname = txbAddress.Text;
            if (fname.Equals("~số 1, P. 10 - Quận 1 - TP.HCM"))
            {
                txbAddress.Text = "";
                txbAddress.ForeColor = Color.Black;
            }
        }

        private void txbAddress_Leave(object sender, EventArgs e)
        {
            String fname = txbAddress.Text;
            if (fname.ToLower().Trim().Equals("~số 1, P. 10 - Quận 1 - TP.HCM") || fname.Equals(""))
            {
                txbAddress.Text = "~số 1, P. 10 - Quận 1 - TP.HCM";
                txbAddress.ForeColor = Color.Silver;
            }
        }

        private void frmBillRentRoom_Load(object sender, EventArgs e)
        {
            lbRentTime.Text = DateTime.Now.ToString("HH") + "g" + DateTime.Now.ToString("mm") + "p";
            lbRentDay.Text = DateTime.Now.ToString("MM/dd/yyyy");
            lbRentCode.Text = BillRentRoomDAO.Instance.Load_CodeRentRoom();
            lbPayDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }
        public frmBillRentRoom(string maphong, string loaiphong, string dongia) : this()
        {
            lbRoomNum.Text = maphong;
            lbTypeRoom.Text = loaiphong;
            lbUnitPrice.Text = String.Format("{0:0,0 VNĐ}", Int32.Parse(dongia));
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txbNumofDay.Text == "Text..." || txbCard.Text == "CMND hoặc Thẻ Căn Cước"
               || txbFullName.Text == "~Nguyễn Văn A" || txbAddress.Text == "~số 1, P. 10 - Quận 1 - TP.HCM")
            {
                frmMessageBox.text = "Need to Enter Full Information!";
                fr.ShowDialog();
            }
            else if (dtpcDateOfBirth.Value == DateTime.Parse("1/1/1900"))
            {
                frmMessageBox.text = "You have not chosen a Date of Birth!";
                fr.ShowDialog();
            }
            else if (dtpcDateOfBirth.Value > DateTime.Now)
            {
                frmMessageBox.text = "Does not exist on this date!";
                fr.ShowDialog();
            }
            else if (plIdentityCard.BackColor == Color.Red)
            {
                frmMessageBox.text = "Something is Wrong!";
                fr.ShowDialog();
            }
            else
            {
                //try
                //{
                    BillRentRoomDAO.Instance.Insert_KHACHHANG(txbCard.Text, txbFullName.Text, dtpcDateOfBirth.Value, txbAddress.Text);
                    BillRentRoomDAO.Instance.Insert_PHIEUTHUE_CT(lbRentCode.Text, txbCard.Text, lbRentTime.Text, DateTime.Parse(lbRentDay.Text), lbRoomNum.Text, Int32.Parse(txbNumofDay.Text), DateTime.Parse(lbPayDate.Text));
                    BillRentRoomDAO.Instance.Update_PHONG(lbRoomNum.Text);
                    this.Close();
                    ms.ShowDialog();
                //}
                //catch
                //{
                //    frmMessageBox.text = "Detect problems in database";
                //    fr.ShowDialog();
                //}
            }
        }

        private void txbCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txbNumofDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txbCard_TextChanged(object sender, EventArgs e)
        {
            if (txbCard.Text.Length == 9 || txbCard.Text.Length == 12
                || txbCard.Text == "" || txbCard.Text == "CMND hoặc Thẻ Căn Cước")
            {

                plIdentityCard.BackColor = Color.FromArgb(94, 148, 255);
                lbError.Visible = false;
            }
            else
            {
                lbError.Visible = true;
                lbError.Text = "Phải 9 hoặc 12 số";
                plIdentityCard.BackColor = Color.Red;
            }
        }

        private void txbNumofDay_TextChanged(object sender, EventArgs e)
        {
            if (txbNumofDay.Text == "Text..." || txbNumofDay.Text == "")
            {
                lbPayDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            }
            else
            {
                lbPayDate.Text = DateTime.Now.AddDays(Int32.Parse(txbNumofDay.Text)).ToString("MM/dd/yyyy");
            }
        }
    }
}
