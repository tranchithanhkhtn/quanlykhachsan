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
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        string _email = "";
        public frmQuanLyNhanVien(string email) : this()
        {
            _email = email;
          
        }
        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dtgvListOfEmployee.AutoGenerateColumns = false;
            dtgvListOfEmployee.DataSource = HomepageDAO.Instance.LoadListEmployee(_email);
            dtgvListOfEmployee.BorderStyle = BorderStyle.None;
            dtgvListOfEmployee.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtgvListOfEmployee.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgvListOfEmployee.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dtgvListOfEmployee.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dtgvListOfEmployee.BackgroundColor = Color.White;

            dtgvListOfEmployee.EnableHeadersVisualStyles = false;
            dtgvListOfEmployee.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgvListOfEmployee.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dtgvListOfEmployee.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
    }
}
