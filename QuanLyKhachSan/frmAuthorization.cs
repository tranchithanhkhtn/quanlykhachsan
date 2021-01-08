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
    public partial class frmAuthorization : Form
    {
        frmMessageBox fr = new frmMessageBox();
        MessageBoxSuccess ms = new MessageBoxSuccess();
        
        public frmAuthorization()
        {
            InitializeComponent();
            dtgvAccountList.AutoGenerateColumns = false;
            dtgvAccountList.DataSource = AccountListDAO.Instance.Load_Data();
        }

        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Refresh()
        {
            dtgvAccountList.AutoGenerateColumns = false;
            dtgvAccountList.DataSource = AccountListDAO.Instance.Load_Data();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgvAccountList.Rows.Count == 0)
            {
                frmMessageBox fr = new frmMessageBox();
                frmMessageBox.text = "Error: Empty database!";
                fr.ShowDialog();
            }
            else
            {
                int index = dtgvAccountList.CurrentRow.Index;
                frmMessageNotification frm = new frmMessageNotification();
                frmMessageNotification.text = "Do you want to delete?";
                frm.Show();
                frm.ptClose.Click += (o, ev) =>
                {
                    frm.Close();
                };
                frm.btnConfirm.Click += (o, ev) =>
                {
                    try
                    {
                        AccountListDAO.Instance.Delete_Account(dtgvAccountList.Rows[index].Cells[0].Value.ToString());
                        dtgvAccountList.AutoGenerateColumns = false;
                        dtgvAccountList.DataSource = AccountListDAO.Instance.Load_Data();
                        frm.Close();
                        ms.ShowDialog();
                    }
                    catch
                    {
                        frmMessageBox fr = new frmMessageBox();
                        frmMessageBox.text = "Error: Empty database!";
                        fr.ShowDialog();
                        frm.Close();
                    }
                };
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtgvAccountList.Rows.Count == 0)
            {
                frmMessageBox fr = new frmMessageBox();
                frmMessageBox.text = "Error: Empty database!";
                fr.ShowDialog();
            }
            else
            {
                int index = dtgvAccountList.CurrentRow.Index;
                frmUpdateAccount fr = new frmUpdateAccount(dtgvAccountList.Rows[index].Cells["MaNV"].Value.ToString(), dtgvAccountList.Rows[index].Cells["TenTK"].Value.ToString(),
                                        dtgvAccountList.Rows[index].Cells["TenNV"].Value.ToString(), dtgvAccountList.Rows[index].Cells["SDT"].Value.ToString(),
                                         dtgvAccountList.Rows[index].Cells["GTinh"].Value.ToString(), dtgvAccountList.Rows[index].Cells["DiaChi"].Value.ToString(), dtgvAccountList.Rows[index].Cells["LoaiTK"].Value.ToString() , DateTime.Parse(dtgvAccountList.Rows[index].Cells["NgSinh"].Value.ToString()));

                fr.Show();
                fr.btnUpdate.Click += (or, er) =>
                {
                    this.Refresh();
                };
            }

        }

        private void txbSeacrh_TextChanged(object sender, EventArgs e)
        {
            dtgvAccountList.AutoGenerateColumns = false;
            dtgvAccountList.DataSource = AccountListDAO.Instance.Search_Accoutn(txbSeacrh.Text);
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            int index = dtgvAccountList.CurrentRow.Index;
            if (AccountListDAO.Instance.Reset_Pass(dtgvAccountList.Rows[index].Cells["MaNV"].Value.ToString()) == true)
            {
                ms.ShowDialog();
            }
            else
            {
                frmMessageBox fr = new frmMessageBox();
                frmMessageBox.text = "Error: Reset password failed!";
                fr.ShowDialog();
            }
        }
    }
}
