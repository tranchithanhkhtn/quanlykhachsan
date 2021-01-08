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
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
            customizeDesing();
        }
        public static string Email;
        private void customizeDesing()
        {
            plManageSubMenu.Visible = false;
            plSystem.Visible = false;
        }

        private void hideSubMenu()
        {
            if (plManageSubMenu.Visible == true)
                plManageSubMenu.Visible = false;
            if (plSystem.Visible == true)
                plSystem.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            showSubMenu(plManageSubMenu);
        }

        private void btnEmployeeManager_Click(object sender, EventArgs e)
        {
            openMainForm(new frmQuanLyNhanVien());
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openMainForm(Form mainForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = mainForm;
            mainForm.TopLevel = false;
            mainForm.FormBorderStyle = FormBorderStyle.None;
            mainForm.Dock = DockStyle.Fill;
            plMainForm.Controls.Add(mainForm);
            plMainForm.Tag = mainForm;
            mainForm.BringToFront();
            mainForm.Show();
        }
        

        private void btnhotelmanager_Click(object sender, EventArgs e)
        {
            openMainForm(new frmQuanLiKhachSan());
            frmRentList.name = lbName.Text;
            hideSubMenu();
        }

        private void btnSystem_Click(object sender, EventArgs e)
        {
            showSubMenu(plSystem);
        }

        private void btnBackupRestore_Click(object sender, EventArgs e)
        {
            openMainForm(new frmBackupRestore());
            hideSubMenu();
        }

        private void tbnAuthorization_Click(object sender, EventArgs e)
        {
            openMainForm(new frmAuthorization());
            hideSubMenu();
        }

        private void btnOperationsmanagement_Click(object sender, EventArgs e)
        {
            openMainForm(new frmOperationsManagement());
            hideSubMenu();
        }
       

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin fr = new frmLogin();
            fr.Show();
            this.Hide();
        }

        private void frmHomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn đóng ứng dụng không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    Application.Exit();
                }
               
            }
            catch
            {
                Application.Exit();
            }
        }

        private void btnInfor_Click(object sender, EventArgs e)
        {
            frmThongTinCaNhan frm = new frmThongTinCaNhan(Email);
            frm.Show();
            frm.ptClose.Click += (or, er) =>
            {
                frm.Close();
                lbName.Text = HomepageDAO.Instance.Load_NameNV(Email);
            };
        }
        string type_account = "";
        private void frmHomePage_Load(object sender, EventArgs e)
        {
            lbName.Text = HomepageDAO.Instance.Load_NameNV(Email);
            type_account = HomepageDAO.Instance.Type_Account(Email);
            if(type_account == "Nhân Viên")
            {
                btnLogoutAd.Visible = false;
                btnManagerEmployee.Visible = true;
                btnSystem.Visible = false;
                btnManagerEmployee.Enabled = false;
                lbLevel.Text = "Nhân Viên";
            }
            else if (type_account == "Quản Lý")
            {
                btnLogoutAd.Visible = false;
                btnManagerEmployee.Visible = true;
                btnSystem.Visible = false;
                btnManagerEmployee.Enabled = true;
                lbLevel.Text = "Quản Lý";
            }
            else if(type_account == "Admin")
            {
                btnLogoutAd.Visible = true;
                btnUserManagement.Visible = false;
                btnSystem.Visible = true;
                btnManagerEmployee.Enabled = true;
                lbLevel.Text = "Quản Trị Viên";
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePass frm = new frmChangePass(Email);
            frm.ShowDialog();
        }

        private void btnManagerEmployee_Click(object sender, EventArgs e)
        {
            openMainForm(new frmQuanLyNhanVien(Email));
            hideSubMenu();
        }
    }
}
