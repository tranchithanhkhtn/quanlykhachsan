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
    public partial class frmOperationsManagement : Form
    {
        public frmOperationsManagement()
        {
            InitializeComponent();
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
            plMain.Controls.Add(mainForm);
            plMain.Tag = mainForm;
            mainForm.BringToFront();
            mainForm.Show();
        }

        private void btnRoomManager_Click(object sender, EventArgs e)
        {
            ptSlider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            ptSlider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            openMainForm(new frmRoomManager());
        }

        private void bfFinance_Click(object sender, EventArgs e)
        {
            ptSlider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            ptSlider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            openMainForm(new frmFinance());
        }

        private void bfFoodList_Click(object sender, EventArgs e)
        {
            ptSlider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            ptSlider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            openMainForm(new frmFoodManager());
        }

        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOperationsManagement_Load(object sender, EventArgs e)
        {
            openMainForm(new frmRoomManager());
        }

        private void bfTransaction_Click(object sender, EventArgs e)
        {
            ptSlider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            ptSlider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            openMainForm(new frmTransactiInvoice());
        }

        private void btnListCustomer_Click(object sender, EventArgs e)
        {
            ptSlider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            ptSlider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            openMainForm(new frmListCustomer());
        }
    }
}
