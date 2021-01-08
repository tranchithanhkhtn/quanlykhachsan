using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmBackupRestore : Form
    {
        SqlConnection con = new SqlConnection(QuanLyKhachSan.Properties.Settings.Default.QuanLyKhachSanConnectionString);
        public frmBackupRestore()
        {
            InitializeComponent();
        }

        private void ptClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdBackUp_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBackUp.Checked == true)
            {
                lblocation.Visible = true;
                txbBackupName.Visible = true;
                plbk.Visible = true;
                btnBackup.Visible = true;
                btnBrowseBK.Visible = true;
            }
            else
            {
                lblocation.Visible = false;
                txbBackupName.Visible = false;
                plbk.Visible = false;
                btnBackup.Visible = false;
                btnBrowseBK.Visible = false;
            }
        }

        private void rdRestore_CheckedChanged(object sender, EventArgs e)
        {
            if (rdRestore.Checked == true)
            {
                lbbkpath.Visible = true;
                txbRestoreName.Visible = true;
                plbkpath.Visible = true;
                btnBrowseST.Visible = true;
                btnRestore.Visible = true;
            }
            else
            {
                lbbkpath.Visible = false;
                txbRestoreName.Visible = false;
                plbkpath.Visible = false;
                btnBrowseST.Visible = false;
                btnRestore.Visible = false;
            }
        }

        private void btnBrowseBK_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txbBackupName.Text = dlg.SelectedPath;
                btnBackup.Enabled = true;
            }
        }

        frmMessageBox fr = new frmMessageBox();
        MessageBoxSuccess ms = new MessageBoxSuccess();
        private void btnBackup_Click(object sender, EventArgs e)
        {
            string data = con.Database.ToString();
            try
            {
                if (txbBackupName.Text == string.Empty)
                {
                    frmMessageBox.text = "Please enter backup file location!";
                    fr.ShowDialog();
                }
                else
                {
                    string cmd = "BACKUP DATABASE [" + data + "] TO DISK='" + txbBackupName.Text + "\\" + "Database" + "-" + DateTime.Now.ToString("MM-dd-yyyy--HH-mm-ss") + ".bak'";
                    using (SqlCommand command = new SqlCommand(cmd, con))
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBoxSuccess ms = new MessageBoxSuccess();
                        ms.ShowDialog();
                        btnBackup.Enabled = false;
                        btnBrowseBK.Enabled = true;
                        txbBackupName.Text = "";
                    }
                }
            }
            catch
            {

            }
        }

        private void btnBrowseST_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txbRestoreName.Text = dlg.FileName;
                btnRestore.Enabled = true;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string data = con.Database.ToString();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            try
            {
                string sqlstmt2 = string.Format("ALTER DATABASE [" + data + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand bu2 = new SqlCommand(sqlstmt2, con);
                bu2.ExecuteNonQuery();

                string sqlstmt3 = "USE MASTER RESTORE DATABASE [" + data + "] FROM DISK='" + txbRestoreName.Text + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlstmt3, con);
                bu3.ExecuteNonQuery();

                string sqlstmt4 = string.Format("ALTER DATABASE [" + data + "] SET MULTI_USER");
                SqlCommand bu4 = new SqlCommand(sqlstmt4, con);
                bu4.ExecuteNonQuery();

                ms.ShowDialog();
                btnRestore.Enabled = false;
                btnBrowseST.Enabled = true;
                txbRestoreName.Text = "";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
