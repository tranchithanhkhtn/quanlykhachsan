using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
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
    public partial class frmRoomManager : Form
    {
        public frmRoomManager()
        {
            InitializeComponent();
        }
        frmMessageBox fr = new frmMessageBox();
        MessageBoxSuccess ms = new MessageBoxSuccess();
        private void btnImage1_MouseHover(object sender, EventArgs e)
        {
            btnImage1.BackColor = Color.LightGray;
        }

        private void btnImage1_MouseLeave(object sender, EventArgs e)
        {
            btnImage1.BackColor = Color.WhiteSmoke;
        }

        private void btnImage2_MouseHover(object sender, EventArgs e)
        {
            btnImage2.BackColor = Color.LightGray;
        }

        private void btnImage2_MouseLeave(object sender, EventArgs e)
        {
            btnImage2.BackColor = Color.WhiteSmoke;
        }

        private void btnImage3_MouseHover(object sender, EventArgs e)
        {
            btnImage3.BackColor = Color.LightGray;
        }

        private void btnImage3_MouseLeave(object sender, EventArgs e)
        {
            btnImage3.BackColor = Color.WhiteSmoke;
        }

        private void btnImage4_MouseHover(object sender, EventArgs e)
        {
            btnImage4.BackColor = Color.LightGray;
        }

        private void btnImage4_MouseLeave(object sender, EventArgs e)
        {
            btnImage4.BackColor = Color.WhiteSmoke;
        }

        private void txbCodeRoom_Enter(object sender, EventArgs e)
        {
            String fname = txbCodeRoom.Text;
            if (fname.Equals("Enter Code"))
            {
                txbCodeRoom.Text = "";
                txbCodeRoom.ForeColor = Color.Black;
            }
        }

        private void txbCodeRoom_Leave(object sender, EventArgs e)
        {
            String fname = txbCodeRoom.Text;
            if (fname.ToLower().Trim().Equals("Enter Code") || fname.Equals(""))
            {
                txbCodeRoom.Text = "Enter Code";
                txbCodeRoom.ForeColor = Color.Silver;
            }
        }

        private void txbUnitPrice_Leave(object sender, EventArgs e)
        {
            String fname = txbUnitPrice.Text;
            if (fname.ToLower().Trim().Equals("Enter Price") || fname.Equals(""))
            {
                txbUnitPrice.Text = "Enter Price";
                txbUnitPrice.ForeColor = Color.Silver;
            }
        }

        private void txbUnitPrice_Enter(object sender, EventArgs e)
        {
            String fname = txbUnitPrice.Text;
            if (fname.Equals("Enter Price"))
            {
                txbUnitPrice.Text = "";
                txbUnitPrice.ForeColor = Color.Black;
            }
        }

        private void frmRoomManager_Load(object sender, EventArgs e)
        {
            dtgvListRoom.AutoGenerateColumns = false;
            dtgvListRoom.DataSource = RoomManagerDAO.Instance.Load_PHONG();
        }

        private void txbSeacrh_TextChanged(object sender, EventArgs e)
        {
            if (txbSeacrh.Text == "" || txbSeacrh.Text == "Search here")
            {
                dtgvListRoom.AutoGenerateColumns = false;
                dtgvListRoom.DataSource = RoomManagerDAO.Instance.Load_PHONG();
            }
            else
            {
                dtgvListRoom.AutoGenerateColumns = false;
                dtgvListRoom.DataSource = RoomManagerDAO.Instance.Load_RoomCode(txbSeacrh.Text);
            }
        }

        Image LoadImage(byte[] img)
        {
            MemoryStream stream = new MemoryStream();
            stream = new MemoryStream(img);
            if (img == null)
                return null;
            Image imgage = new Bitmap(stream);
            if (imgage == null)
                return null;
            return imgage;
        }

        void XuLyControl_Update()
        {
            if (btnUpdateRoom.Visible == false)
            {
                dtgvListRoom.Enabled = false;
                txbCodeRoom.Enabled = false;

                btnImage1.Visible = false;
                ptDelete1.Visible = true;

                btnImage2.Visible = false;
                ptDelete2.Visible = true;

                btnImage3.Visible = false;
                ptDelete3.Visible = true;

                btnImage4.Visible = false;
                ptDelete4.Visible = true;

                btnAddRoom.Enabled = false;
                btnDeleteRoom.Enabled = false;
                btnUpdate.Visible = true;
            }
            else
            {
                dtgvListRoom.Enabled = true;
                txbCodeRoom.Enabled = true;

                btnImage1.Visible = true;
                ptDelete1.Visible = false;

                btnImage2.Visible = true;
                ptDelete2.Visible = false;

                btnImage3.Visible = true;
                ptDelete3.Visible = false;

                btnImage4.Visible = true;
                ptDelete4.Visible = false;

                btnAddRoom.Enabled = true;
                btnDeleteRoom.Enabled = true;
                btnUpdate.Visible = false;
            }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            if (dtgvListRoom.Rows.Count == 0)
            {
                frmMessageBox fr = new frmMessageBox();
                frmMessageBox.text = "Error: Empty database!";
                fr.ShowDialog();
            }
            else
            {
                txbUnitPrice.ForeColor = Color.Black;
                txbDescribe.ForeColor = Color.Black;
                btnUpdateRoom.Visible = false;
                XuLyControl_Update();
                int index = dtgvListRoom.CurrentRow.Index;
                List<RoomManager> lf = RoomManagerDAO.Instance.Load_RoomCode(dtgvListRoom.Rows[index].Cells[0].Value.ToString());
                foreach (RoomManager item in lf)
                {
                    txbCodeRoom.Text = item.MaPhong;
                    cbTypeRoom.Text = item.LoaiPhong;
                    txbUnitPrice.Text = item.DonGia.ToString();
                    txbDescribe.Text = item.ThongTin;
                    ptImage1.Image = LoadImage(item.Hinh1);
                    ptImage2.Image = LoadImage(item.Hinh2);
                    ptImage3.Image = LoadImage(item.Hinh3);
                    ptImage4.Image = LoadImage(item.Hinh4);
                }
            }
        }

        string filename1 = "";
        string filename2 = "";
        string filename3 = "";
        string filename4 = "";
        private void btnImage1_Click(object sender, EventArgs e)
        {
            try
            {
                btnImage1.Visible = false;
                ptDelete1.Visible = true;
                ofdFileDialog.ShowDialog();
                filename1 = ofdFileDialog.FileName;
                if (string.IsNullOrEmpty(filename1))
                    return;
                Image myImage = Image.FromFile(filename1);
                ptImage1.Image = myImage;
                if (filename1 == filename2 || filename1 == filename3
                || filename1 == filename4)
                {
                    ptImage1.Image = null;
                    btnImage1.Visible = true;
                    ptDelete1.Visible = false;
                    frmMessageBox fr = new frmMessageBox();
                    frmMessageBox.text = "Uploaded photos must not be duplicated";
                    fr.ShowDialog();
                    return;
                }
            }
            catch
            {
                btnImage1.Visible = true;
                ptDelete1.Visible = false;
            }

        }

        private void btnImage2_Click(object sender, EventArgs e)
        {

            try
            {
                btnImage2.Visible = false;
                ptDelete2.Visible = true;
                ofdFileDialog.ShowDialog();
                filename2 = ofdFileDialog.FileName;
                if (string.IsNullOrEmpty(filename2))
                    return;
                Image myImage = Image.FromFile(filename2);
                ptImage2.Image = myImage;
                if (filename2 == filename1 || filename2 == filename3
                || filename2 == filename4)
                {
                    ptImage2.Image = null;
                    btnImage2.Visible = true;
                    ptDelete2.Visible = false;
                    frmMessageBox fr = new frmMessageBox();
                    frmMessageBox.text = "Uploaded photos must not be duplicated";
                    fr.ShowDialog();
                    return;
                }
            }
            catch
            {
                btnImage2.Visible = true;
                ptDelete2.Visible = false;
            }
        }

        private void btnImage3_Click(object sender, EventArgs e)
        {
            try
            {
                btnImage3.Visible = false;
                ptDelete3.Visible = true;
                ofdFileDialog.ShowDialog();
                filename3 = ofdFileDialog.FileName;
                if (string.IsNullOrEmpty(filename3))
                    return;
                Image myImage = Image.FromFile(filename3);
                ptImage3.Image = myImage;
                if (filename3 == filename1 || filename3 == filename2
               || filename3 == filename4)
                {
                    ptImage3.Image = null;
                    btnImage3.Visible = true;
                    ptDelete3.Visible = false;
                    frmMessageBox fr = new frmMessageBox();
                    frmMessageBox.text = "Uploaded photos must not be duplicated";
                    fr.ShowDialog();
                    return;
                }
            }
            catch
            {
                btnImage3.Visible = true;
                ptDelete3.Visible = false;
            }
        }

        private void btnImage4_Click(object sender, EventArgs e)
        {
            try
            {
                btnImage4.Visible = false;
                ptDelete4.Visible = true;
                ofdFileDialog.ShowDialog();
                filename4 = ofdFileDialog.FileName;
                if (string.IsNullOrEmpty(filename4))
                    return;
                Image myImage = Image.FromFile(filename4);
                ptImage4.Image = myImage;
                if (filename4 == filename1 || filename4 == filename2
              || filename4 == filename3)
                {
                    ptImage4.Image = null;
                    btnImage4.Visible = true;
                    ptDelete4.Visible = false;
                    frmMessageBox fr = new frmMessageBox();
                    frmMessageBox.text = "Uploaded photos must not be duplicated";
                    fr.ShowDialog();
                    return;
                }
            }
            catch
            {
                btnImage4.Visible = true;
                ptDelete4.Visible = false;
            }
        }

        private void ptDelete1_Click(object sender, EventArgs e)
        {
            filename1 = "";
            ptImage1.Image = null;
            btnImage1.Visible = true;
            ptDelete1.Visible = false;
        }

        private void ptDelete2_Click(object sender, EventArgs e)
        {
            filename2 = "";
            ptImage2.Image = null;
            btnImage2.Visible = true;
            ptDelete2.Visible = false;
        }

        private void ptDelete3_Click(object sender, EventArgs e)
        {
            filename3 = "";
            ptImage3.Image = null;
            btnImage3.Visible = true;
            ptDelete3.Visible = false;
        }

        private void ptDelete4_Click(object sender, EventArgs e)
        {
            filename4 = "";
            ptImage4.Image = null;
            btnImage4.Visible = true;
            ptDelete4.Visible = false;
        }
        void ClearControl()
        {
            txbCodeRoom.Text = "Enter Code";
            txbCodeRoom.ForeColor = Color.Silver;
            txbDescribe.Text = "Enter Text. . .";
            txbDescribe.ForeColor = Color.Silver;
            cbTypeRoom.Text = null;
            txbUnitPrice.Text = "Enter Price";
            txbUnitPrice.ForeColor = Color.Silver;

            ptImage1.Image = null;
            btnImage1.Visible = true;
            ptDelete1.Visible = false;

            ptImage2.Image = null;
            btnImage2.Visible = true;
            ptDelete2.Visible = false;

            ptImage3.Image = null;
            btnImage3.Visible = true;
            ptDelete3.Visible = false;

            ptImage4.Image = null;
            btnImage4.Visible = true;
            ptDelete4.Visible = false;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (RoomManagerDAO.Instance.Check_Code(txbCodeRoom.Text) == false)
            {
                plRoomCode.BackColor = Color.Red;
                lbNote.Text = "Room code already exists!";
                lbNote.Visible = true;
            }
            else
            {
                plRoomCode.BackColor = Color.FromArgb(94, 148, 255);
                lbNote.Visible = false;
                if (txbCodeRoom.Text == "Code" || cbTypeRoom.Text == "" || txbUnitPrice.Text == "VND"
                   || txbDescribe.Text == "" || ptImage1.Image == null || ptImage2.Image == null
                   || ptImage3.Image == null || ptImage4.Image == null)
                {
                    frmMessageBox.text = "Need to Enter Full Information!";
                    fr.ShowDialog();
                }
                else if (plRoomCode.BackColor == Color.Red)
                {
                    frmMessageBox.text = "Room code already exists!";
                    fr.ShowDialog();
                }
                else
                {
                    RoomManagerDAO.Instance.Insert_PHONG(txbCodeRoom.Text, cbTypeRoom.Text, txbUnitPrice.Text, txbDescribe.Text, ptImage1.Image, ptImage2.Image, ptImage3.Image, ptImage4.Image);
                    dtgvListRoom.AutoGenerateColumns = false;
                    dtgvListRoom.DataSource = RoomManagerDAO.Instance.Load_PHONG();
                    ms.ShowDialog();
                    filename1 = "";
                    filename2 = "";
                    filename3 = "";
                    filename4 = "";
                    ClearControl();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbTypeRoom.Text == "" || txbUnitPrice.Text == "VND"
               || txbDescribe.Text == "" || ptImage1.Image == null || ptImage2.Image == null
               || ptImage3.Image == null || ptImage4.Image == null)
            {
                frmMessageBox.text = "Need to Enter Full Information!";
                fr.ShowDialog();
            }
            else if (plRoomCode.BackColor == Color.Red)
            {
                frmMessageBox.text = "Room code already exists!";
                fr.ShowDialog();
            }
            else
            {
                RoomManagerDAO.Instance.Update_PHONG(txbCodeRoom.Text, cbTypeRoom.Text, txbUnitPrice.Text, txbDescribe.Text, ptImage1.Image, ptImage2.Image, ptImage3.Image, ptImage4.Image);
                btnUpdate.Visible = false;
                btnUpdateRoom.Visible = true;
                XuLyControl_Update();
                dtgvListRoom.AutoGenerateColumns = false;
                dtgvListRoom.DataSource = RoomManagerDAO.Instance.Load_PHONG();
                filename1 = "";
                filename2 = "";
                filename3 = "";
                filename4 = "";
                ClearControl();
                ms.ShowDialog();
            }
        }

        public static string Temp;
        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dtgvListRoom.Rows.Count == 0)
            {
                frmMessageBox fr = new frmMessageBox();
                frmMessageBox.text = "Error: Empty database!";
                fr.ShowDialog();
            }
            else
            {
                int index = dtgvListRoom.CurrentRow.Index;
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
                        if (RoomManagerDAO.Instance.Delete_Phong(dtgvListRoom.Rows[index].Cells[0].Value.ToString()) == true)
                        {
                            dtgvListRoom.AutoGenerateColumns = false;
                            dtgvListRoom.DataSource = RoomManagerDAO.Instance.Load_PHONG();
                            frm.Close();
                            ms.ShowDialog();
                        }
                        else
                        {
                            frmMessageBox fr = new frmMessageBox();
                            frmMessageBox.text = "Error: Empty database!";
                            fr.ShowDialog();
                            frm.Close();
                        }
                    }
                    catch
                    {
                        frmMessageBox fr = new frmMessageBox();
                        frmMessageBox.text = "Can not be deleted because the room has been rented!";
                        fr.ShowDialog();
                        frm.Close();
                    }
                };
            }


        }

        private void txbDescribe_Enter(object sender, EventArgs e)
        {
            String fname = txbDescribe.Text;
            if (fname.Equals("Enter Text. . ."))
            {
                txbDescribe.Text = "";
                txbDescribe.ForeColor = Color.Black;
            }
        }

        private void txbDescribe_Leave(object sender, EventArgs e)
        {
            String fname = txbDescribe.Text;
            if (fname.ToLower().Trim().Equals("Enter Text. . .") || fname.Equals(""))
            {
                txbDescribe.Text = "Enter Text. . .";
                txbDescribe.ForeColor = Color.Silver;
            }
        }

        private void txbUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

       
    }
}
