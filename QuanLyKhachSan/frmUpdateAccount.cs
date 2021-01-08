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
    public partial class frmUpdateAccount : Form
    {
        public frmUpdateAccount()
        {
            InitializeComponent();
           
        }

        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public frmUpdateAccount(string manv, string email, string hoten, string numphone, string gioitinh, string diachi, string capbac , DateTime ngsinh) : this()
        {
            lbEmployeeCode.Text = manv;
            txbEmail.Text = email;
            txbFullName.Text = hoten;
            txbNumPhone.Text = numphone;
            cbSex.Text = gioitinh;
            txbAddress.Text = diachi;
            cbTypeAccount.Text = capbac;
            dtpkDOB.Value = ngsinh;
        }

        private void txbNumPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {
            if (txbEmail.Text == "")
            {
                plEmail.BackColor = Color.FromArgb(94, 148, 255);
            }
            else if (txbEmail.Text == "@gmail.com")
            {
                plEmail.BackColor = Color.Red;
            }
            else if (txbEmail.Text.EndsWith("@gmail.com"))
            {
                plEmail.BackColor = Color.FromArgb(94, 148, 255);
            }
            else
            {
                plEmail.BackColor = Color.Red;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(plEmail.BackColor == Color.FromArgb(94, 148, 255) || plNumphone.BackColor == Color.FromArgb(94, 148, 255) ||
                txbFullName.Text != "" || txbAddress.Text != "")
            {
                if(cbTypeAccount.Text == "Nhân Viên")
                {
                    MessageBoxSuccess ms = new MessageBoxSuccess();
                    AccountListDAO.Instance.Update_Account(lbEmployeeCode.Text, txbEmail.Text, txbFullName.Text, txbNumPhone.Text, cbSex.Text, txbAddress.Text, cbTypeAccount.Text , dtpkDOB.Value);
                    try
                    {
                        AccountListDAO.Instance.Update_ManagerEmployee(lbEmployeeCode.Text);
                    }
                    catch
                    {
                        return;
                    }
                    this.Close();
                    ms.ShowDialog();
                }
                else if(cbTypeAccount.Text == "Quản Lý")
                {
                    for (int i = 0; i < dtgvCheckManager.Rows.Count; i++)
                    {
                            AccountListDAO.Instance.Update_NV(dtgvCheckManager.Rows[i].Cells["Mã NV"].Value.ToString());
                    }
                    MessageBoxSuccess ms = new MessageBoxSuccess();
                    AccountListDAO.Instance.Update_Account(lbEmployeeCode.Text, txbEmail.Text, txbFullName.Text, txbNumPhone.Text, cbSex.Text, txbAddress.Text, cbTypeAccount.Text, dtpkDOB.Value);
                    for (int i = 0; i < dtgvCheckManager.Rows.Count; i++)
                    {
                        if(Convert.ToBoolean(dtgvCheckManager.Rows[i].Cells["NVQL"].Value) == true)
                        {
                           AccountListDAO.Instance.Update_QuanLyNV(dtgvCheckManager.Rows[i].Cells["Mã NV"].Value.ToString(), lbEmployeeCode.Text);
                        }
                    }
                    this.Close();
                    ms.ShowDialog();
                }
                
            }
        }

        private void txbNumPhone_TextChanged(object sender, EventArgs e)
        {
            if (txbNumPhone.Text == "")
            {
                plNumphone.BackColor = Color.FromArgb(94, 148, 255);
            }
            else if (txbNumPhone.Text.Length == 10 || txbNumPhone.Text.Length == 9 || txbNumPhone.Text.Length == 11)
            {
                plNumphone.BackColor = Color.FromArgb(94, 148, 255);
            }
            else
            {
                plNumphone.BackColor = Color.Red;
            }
        }

        private void cbTypeAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTypeAccount.Text == "Quản Lý")
            {
                btnChoose.Visible = true;
                plQuanLyNV.Visible = true;
            }
            else
            {
                btnChoose.Visible = false;
                plQuanLyNV.Visible = false;
            }
        }

        private void frmUpdateAccount_Load(object sender, EventArgs e)
        {
            dtgvCheckManager.DataSource = AccountListDAO.Instance.Load_Data_NV(lbEmployeeCode.Text);
        }

        private void dtgvCheckManager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                dtgvCheckManager.Rows[e.RowIndex].Cells["NVQL"].Value = true;
            }
        }

        private void frmUpdateAccount_MouseClick(object sender, MouseEventArgs e)
        {
            plQuanLyNV.Visible = false;
            btnChoose.Visible = true;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            plQuanLyNV.Visible = true;
        }
    }
}
