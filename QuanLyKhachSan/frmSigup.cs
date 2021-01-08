using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmSigup : Form
    {
        public frmSigup()
        {
            InitializeComponent();
            Show_CodeAccount();
        }
        frmMessageBox fr = new frmMessageBox();
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbEmail_Enter(object sender, EventArgs e)
        {
            String fname = txbEmail.Text;
            if (fname.Equals("abc@gmail.com"))
            {
                txbEmail.Text = "";
                txbEmail.ForeColor = Color.Black;
            }
        }

        private void txbEmail_Leave(object sender, EventArgs e)
        {
            String fname = txbEmail.Text;
            if (fname.ToLower().Trim().Equals("abc@gmail.com") || fname.Equals(""))
            {
                txbEmail.Text = "abc@gmail.com";
                txbEmail.ForeColor = Color.Silver;
            }
        }

        private void txbName_Enter(object sender, EventArgs e)
        {
            String fname = txbName.Text;
            if (fname.Equals("Nguyễn Văn A"))
            {
                txbName.Text = "";
                txbName.ForeColor = Color.Black;
            }
        }

        private void txbName_Leave(object sender, EventArgs e)
        {
            String fname = txbName.Text;
            if (fname.ToLower().Trim().Equals("Nguyễn Văn A") || fname.Equals(""))
            {
                txbName.Text = "Nguyễn Văn A";
                txbName.ForeColor = Color.Silver;
            }
        }

        private void txbNumPhone_Enter(object sender, EventArgs e)
        {
            String fname = txbNumPhone.Text;
            if (fname.Equals("0912345678"))
            {
                txbNumPhone.Text = "";
                txbNumPhone.ForeColor = Color.Black;
            }
        }

        private void txbNumPhone_Leave(object sender, EventArgs e)
        {
            String fname = txbNumPhone.Text;
            if (fname.ToLower().Trim().Equals("0912345678") || fname.Equals(""))
            {
                txbNumPhone.Text = "0912345678";
                txbNumPhone.ForeColor = Color.Silver;
            }
        }

        private void txbSex_Enter(object sender, EventArgs e)
        {
            String fname = txbSex.Text;
            if (fname.Equals("Nam/Nữ"))
            {
                txbSex.Text = "";
                txbSex.ForeColor = Color.Black;
            }
        }

        private void txbSex_Leave(object sender, EventArgs e)
        {
            String fname = txbSex.Text;
            if (fname.ToLower().Trim().Equals("Nam/Nữ") || fname.Equals(""))
            {
                txbSex.Text = "Nam/Nữ";
                txbSex.ForeColor = Color.Silver;
            }
        }

        private void txbAddress_Enter(object sender, EventArgs e)
        {
            String fname = txbAddress.Text;
            if (fname.Equals("số 1, P. 10 - Quận 1 - TP.HCM"))
            {
                txbAddress.Text = "";
                txbAddress.ForeColor = Color.Black;
            }
        }

        private void txbAddress_Leave(object sender, EventArgs e)
        {
            String fname = txbAddress.Text;
            if (fname.ToLower().Trim().Equals("số 1, P. 10 - Quận 1 - TP.HCM") || fname.Equals(""))
            {
                txbAddress.Text = "số 1, P. 10 - Quận 1 - TP.HCM";
                txbAddress.ForeColor = Color.Silver;
            }
        }
        private void txbPassword_Enter(object sender, EventArgs e)
        {
            String fpassword = txbPassword.Text;
            if (fpassword.Equals("Password"))
            {
                txbPassword.Text = "";
                txbPassword.UseSystemPasswordChar = true;
                txbPassword.ForeColor = Color.Black;
            }
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            String fpassword = txbPassword.Text;
            if (fpassword.ToLower().Trim().Equals("Password") || fpassword.Equals(""))
            {
                txbPassword.Text = "Password";
                txbPassword.UseSystemPasswordChar = false;
                txbPassword.ForeColor = Color.Silver;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Load Mã Tài Khoản tự động tăng lên.
        void Show_CodeAccount()
        {
            txbCode.Text = RegisterDAO.Instance.Load_CodeAccount();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txbEmail.Text == "abc@gmail.com" || txbName.Text == "Nguyễn Văn A" || txbNumPhone.Text == "0912345678"
                || txbSex.Text == "Nam/Nữ" || txbAddress.Text == "số 1, P. 10 - Quận 1 - TP.HCM")
            {
                lbNotification.Visible = true;
                lbNotification.Text = "Need to Enter Full Information!";
                lbNotification.ForeColor = Color.Red;

            }
            else if(dtptDOB.Value.ToString("MM/dd/yyyy") == "1/1/1900")
            {
                lbNotification.Visible = true;
                lbNotification.Text = "Not selected a date of birth!";
                lbNotification.ForeColor = Color.Red;
            }
            else if (lbEmail.ForeColor == Color.Red || lbNumphone.ForeColor == Color.Red || lbSex.ForeColor == Color.Red || lbPassword.ForeColor == Color.Red)
            {
                lbNotification.Visible = true;
                lbNotification.Text = "Could Not Be Verified!";
                lbNotification.ForeColor = Color.Red;
            }
            else
            {
                if (RegisterDAO.Instance.Check_Email(txbEmail.Text) == false)
                {
                    lbEmail.ForeColor = Color.Red;
                    plEmail.BackColor = Color.Red;
                    lbNotification.Visible = true;
                    lbNotification.Text = "Email Exists, Please Enter Again!";
                    lbNotification.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    try
                    {
                        RegisterDAO.Instance.Insert_Account(txbCode.Text, txbEmail.Text, txbPassword.Text);
                        RegisterDAO.Instance.Insert_NhanVien(txbCode.Text, txbName.Text, txbNumPhone.Text, txbSex.Text, txbAddress.Text, DateTime.Parse(dtptDOB.Value.ToString("MM/dd/yyyy")));
                        MessageBoxSuccess ms = new MessageBoxSuccess();
                        ms.ShowDialog();
                        this.Close();
                    }
                    catch
                    {
                        frmMessageBox.text = "Error Occurred At DataBase!";
                        fr.ShowDialog();
                    }
                }
            }
        }
        
        private void txbEmail_TextChanged(object sender, EventArgs e)
        {
            if (txbEmail.Text == "")
            {
                lbEmail.ForeColor = Color.FromArgb(94, 148, 255);
                plEmail.BackColor = Color.FromArgb(94, 148, 255);
                lbNotification.Visible = false;
            }
            else if (txbEmail.Text == "@gmail.com")
            {
                lbEmail.ForeColor = Color.Red;
                plEmail.BackColor = Color.Red;
            }
            else if (txbEmail.Text.EndsWith("@gmail.com"))
            {
                lbEmail.ForeColor = Color.FromArgb(94, 148, 255);
                plEmail.BackColor = Color.FromArgb(94, 148, 255);
                lbNotification.Visible = false;
            }
            else
            {
                lbEmail.ForeColor = Color.Red;
                plEmail.BackColor = Color.Red;
            }

        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        private void txbNumPhone_TextChanged(object sender, EventArgs e)
        {
            if (txbNumPhone.Text == "")
            {
                lbNumphone.ForeColor = Color.FromArgb(94, 148, 255);
                plNumphone.BackColor = Color.FromArgb(94, 148, 255);
            }
            else if (IsNumber(txbNumPhone.Text) == false)
            {
                lbNumphone.ForeColor = Color.Red;
                plNumphone.BackColor = Color.Red;
            }
            else if (IsNumber(txbNumPhone.Text) == true && txbNumPhone.Text.Length == 10 || txbNumPhone.Text.Length == 9 || txbNumPhone.Text.Length == 11)
            {
                lbNumphone.ForeColor = Color.FromArgb(94, 148, 255);
                plNumphone.BackColor = Color.FromArgb(94, 148, 255);
            }
            else
            {
                lbNumphone.ForeColor = Color.Red;
                plNumphone.BackColor = Color.Red;
            }
        }

        private void txbSex_TextChanged(object sender, EventArgs e)
        {
            if (txbSex.Text == "")
            {
                lbSex.ForeColor = Color.FromArgb(94, 148, 255);
                plSex.BackColor = Color.FromArgb(94, 148, 255);
            }
            else if (txbSex.Text.EndsWith("Nam"))
            {
                lbSex.ForeColor = Color.FromArgb(94, 148, 255);
                plSex.BackColor = Color.FromArgb(94, 148, 255);
            }
            else if (txbSex.Text.EndsWith("Nữ"))
            {
                lbSex.ForeColor = Color.FromArgb(94, 148, 255);
                plSex.BackColor = Color.FromArgb(94, 148, 255);
            }
            else
            {
                lbSex.ForeColor = Color.Red;
                plSex.BackColor = Color.Red;
            }
        }

        private void cbPass_OnChange(object sender, EventArgs e)
        {
            if(cbPass.Checked == true)
            {
                txbPassword.UseSystemPasswordChar = false;
            }
            else if (cbPass.Checked == false && txbPassword.Text == "Password")
            {
                txbPassword.Text = "Password";
                txbPassword.UseSystemPasswordChar = false;
                txbPassword.ForeColor = Color.Silver;
            }
            else
            {
                txbPassword.UseSystemPasswordChar = true;
            }
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked == true)
            {
                txbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txbPassword.UseSystemPasswordChar = true;
            }
            if (txbPassword.Text == "" || txbPassword.Text == "Password")
            {
                lbPassword.ForeColor = Color.FromArgb(94, 148, 255);
                plPassword.BackColor = Color.FromArgb(94, 148, 255);
            }
            else if(txbPassword.Text.Length < 10)
            {
                lbPassword.ForeColor = Color.Red;
                plPassword.BackColor = Color.Red;
            }
            else
            {
                lbPassword.ForeColor = Color.FromArgb(94, 148, 255);
                plPassword.BackColor = Color.FromArgb(94, 148, 255);
              
            }
        }

        private void txbNumPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
