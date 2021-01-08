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
    public partial class frmMessageNotification : Form
    {
        public frmMessageNotification()
        {
            InitializeComponent();
        }
        public static string text;
        private void frmMessageNotification_Load(object sender, EventArgs e)
        {
            lbText.Text = text;
        }

        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
