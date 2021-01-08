using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyKhachSan
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        frmMessageBox fr = new frmMessageBox();
        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {
                Application.Exit();
            }
        }
        private void txbUserName_Enter(object sender, EventArgs e)
        {
            String fname = txbUserName.Text;
            if (fname.Equals("Email"))
            {
                txbUserName.Text = "";
                txbUserName.ForeColor = Color.Black;
            }
        }

        private void txbUserName_Leave(object sender, EventArgs e)
        {
            String fname = txbUserName.Text;
            if (fname.ToLower().Trim().Equals("Email") || fname.Equals(""))
            {
                txbUserName.Text = "Email";
                txbUserName.ForeColor = Color.Gray;
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
                txbPassword.ForeColor = Color.Gray;
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            txbUserName.Text = "Email";
            txbPassword.Text = "Password";
            txbPassword.ForeColor = Color.Gray;
            txbUserName.ForeColor = Color.Gray;
            txbPassword.UseSystemPasswordChar = false;
            frmSigup f = new frmSigup();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            lbNote.Visible = false;
            
        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {
            if (txbUserName.Text == "" || txbUserName.Text == "Email")
            {
                plUsername.BackColor = Color.FromArgb(94, 148, 255);
                lbNote.Visible = false;
            }
            else if (RegisterDAO.Instance.Check_Email(txbUserName.Text) == false)
            {
                plUsername.BackColor = Color.FromArgb(94, 148, 255);
                lbNote.Visible = false;
            }
            else
            {
                lbNote.Visible = false;
                plUsername.BackColor = Color.Red;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbUserName.Text == "Email" || txbUserName.Text == "" || txbPassword.Text == "" || txbPassword.Text == "Password") 
            {
                lbNote.Visible = true;
                lbNote.Text = "Email or Password cannot be empty!";
                lbNote.ForeColor = Color.Red;
            }
            else if (plUsername.BackColor == Color.Red)
            {
                lbNote.Visible = true;
                lbNote.Text = "Email does not exist, please check again!";
                lbNote.ForeColor = Color.Red;
            }
            else
            {
                //try
                //{
                    if (RegisterDAO.Instance.Check_Login(txbUserName.Text, txbPassword.Text) == false)
                    {
                        plPass.BackColor = Color.Red;
                        txbPassword.Text = "Password";
                        txbPassword.UseSystemPasswordChar = false;
                        txbPassword.ForeColor = Color.Gray;
                        if (plPass.BackColor == Color.Red)
                        {
                            lbNote.Visible = true;
                            lbNote.Text = "Password is Wrong!";
                            lbNote.ForeColor = Color.Red;
                        }
                        else
                        {
                            lbNote.Visible = false;
                        }
                    }
                    else
                    {
                        frmHomePage f = new frmHomePage();
                        frmHomePage.Email = txbUserName.Text;
                        this.Hide();
                        f.ShowDialog();
                        lbNote.Visible = false;
                    }
                //}
                //catch
                //{
                //    frmMessageBox.text = "Error Occurred At DataBase!";
                //    fr.ShowDialog();
                //}
                
            }
        }

       
    }
}
