using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmThongTinCaNhan : Form
    {
        public frmThongTinCaNhan()
        {
            InitializeComponent();
        }
        string _email = "";
        public frmThongTinCaNhan(string email) : this()
        {
            _email = email;
            txbEmail.Text = email;
        }




        void LoadData()
        {
            DataTable data = HomepageDAO.Instance.Load_Infor(txbEmail.Text);

            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Database Empty!", "Error Provider!");
            }
            else
            {
                lbEmployeeCode.Text = data.Rows[0]["MaNV"].ToString();
                txbNumPhone.Text = data.Rows[0]["SDT"].ToString();
                txbFullname.Text = data.Rows[0]["TenNV"].ToString();
                cbSex.Text = data.Rows[0]["GTinh"].ToString();
                txbAddress.Text = data.Rows[0]["DiaChi"].ToString();
                DateTime date = DateTime.Parse(data.Rows[0]["NgSinh"].ToString());
                dtpDOB.Value = date;
                picAvatar.Image = HomepageDAO.Instance.ByteArrayToImage(txbEmail.Text);
            }

        }

        void OpenControl()
        {
            txbEmail.Enabled = true;
            txbNumPhone.Enabled = true;
            txbFullname.Enabled = true;
            cbSex.Enabled = true;
            dtpDOB.Enabled = true;
            txbAddress.Enabled = true;
        }
        void ClosedControl()
        {
            txbEmail.Enabled = false;
            txbNumPhone.Enabled = false;
            txbFullname.Enabled = false;
            cbSex.Enabled = false;
            dtpDOB.Enabled = false;
            txbAddress.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            btnSaveAll.Visible = true;
            OpenControl();
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            if (txbEmail.Text == "")
            {
                plEmail.BackColor = Color.Red;
                lbError.Visible = true;
                lbError.Text = "Email cannot be left blank!";
            }
            else if (HomepageDAO.Instance.Check_Email(txbEmail.Text, _email) == false)
            {
                plEmail.BackColor = Color.Red;
                lbError.Visible = true;
                lbError.Text = "Email already exists!Please re-enter your email!";
            }
            else if (lbError.Visible == true)
            {
                return;
            }
            else
            {
                MessageBoxSuccess ms = new MessageBoxSuccess();
                HomepageDAO.Instance.Update_InforEmployee(lbEmployeeCode.Text, txbEmail.Text, txbFullname.Text, txbNumPhone.Text, cbSex.Text, txbAddress.Text, DateTime.Parse(dtpDOB.Value.ToString("MM/dd/yyyy")));
                frmHomePage.Email = txbEmail.Text;
                ms.ShowDialog();
                btnUpdate.Visible = true;
                btnSaveAll.Visible = false;
                ClosedControl();
                plEmail.BackColor = Color.DeepSkyBlue;
                lbError.Visible = false;
            }

        }

        private void frmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                ofdFileDialog.ShowDialog();
                ofdFileDialog.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
                string file = ofdFileDialog.FileName;
                Image myImage = Image.FromFile(file);
                picAvatar.Image = myImage;
                if (string.IsNullOrEmpty(file))
                    return;

            }
            catch
            {
                frmMessageBox fr = new frmMessageBox();
                frmMessageBox.text = "Error: The System is not working !";
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            HomepageDAO.Instance.InsertImage_Employee(picAvatar.Image, lbEmployeeCode.Text);
            MessageBoxSuccess ms = new MessageBoxSuccess();
            ms.ShowDialog();
        }

        private void txbNumPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {
            if(txbEmail.Text == "")
            {
                plEmail.BackColor = Color.Red;
                lbError.Visible = true;
                lbError.Text = "Email cannot be left blank!";
            }
            else if (txbEmail.Text == "@gmail.com")
            {
                plEmail.BackColor = Color.Red;
                lbError.Visible = true;
                lbError.Text = "Invalid email!";
            }
            else if (txbEmail.Text.EndsWith("@gmail.com") == false)
            {
                plEmail.BackColor = Color.Red;
                lbError.Visible = true;
                lbError.Text = "Email invalidate!";
            }
            else
            {
                plEmail.BackColor = Color.DeepSkyBlue;
                lbError.Visible = false;
            }
        }
    }
}
