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
    public partial class frmQuanLyPhongKS : Form
    {
        public frmQuanLyPhongKS()
        {
            InitializeComponent();

        }

        frmMessageBox fr = new frmMessageBox();
        List<QLKS> list = new List<QLKS>();
        List<Image> imagelist = new List<Image>();
        private int imageNumber = 0;

        private void LoadNextImage()
        {
            try
            {
                if (imageNumber == 4)
                {
                    imageNumber = 0;
                }
                ptImageroom.Image = imagelist[imageNumber];
                ptImageroom.SizeMode = PictureBoxSizeMode.StretchImage;
                imageNumber++;
            }
            catch
            {
                return;
            }
          
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
        private void frmQuanLyPhongKS_Load(object sender, EventArgs e)
        {
            dtgvListRoom.AutoGenerateColumns = false;
            dtgvListRoom.DataSource = QLKS_DAO.Instance.LoadData();
            lbRoomNum.DataBindings.Clear();
            lbRoomNum.DataBindings.Add("Text", dtgvListRoom.DataSource, "MaPhong");
            lbTypeRoom.DataBindings.Clear();
            lbTypeRoom.DataBindings.Add("Text", dtgvListRoom.DataSource, "LoaiPhong");
            lbUnitPrice.DataBindings.Clear();
            lbUnitPrice.DataBindings.Add("Text", dtgvListRoom.DataSource, "DonGia");
            lbStatus.DataBindings.Clear();
            lbStatus.DataBindings.Add("Text", dtgvListRoom.DataSource, "TinhTrang");
            lbinfoRoom.DataBindings.Clear();
            lbinfoRoom.DataBindings.Add("Text", dtgvListRoom.DataSource, "ThongTin");
        }
       
        private void cbTyperoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbSeacrh.Text = "";
            if (cbStatus.Text == "")
            {
                dtgvListRoom.AutoGenerateColumns = false;
                dtgvListRoom.DataSource = QLKS_DAO.Instance.Load_TypeRoom(cbTyperoom.Text);
                lbRoomNum.DataBindings.Clear();
                lbRoomNum.DataBindings.Add("Text", dtgvListRoom.DataSource, "MaPhong");
                lbTypeRoom.DataBindings.Clear();
                lbTypeRoom.DataBindings.Add("Text", dtgvListRoom.DataSource, "LoaiPhong");
                lbUnitPrice.DataBindings.Clear();
                lbUnitPrice.DataBindings.Add("Text", dtgvListRoom.DataSource, "DonGia");
                lbStatus.DataBindings.Clear();
                lbStatus.DataBindings.Add("Text", dtgvListRoom.DataSource, "TinhTrang");
                lbinfoRoom.DataBindings.Clear();
                lbinfoRoom.DataBindings.Add("Text", dtgvListRoom.DataSource, "ThongTin");
            }
            else
            {
                dtgvListRoom.AutoGenerateColumns = false;
                dtgvListRoom.DataSource = QLKS_DAO.Instance.Load_Type_Status(cbTyperoom.Text, cbStatus.Text);
                lbRoomNum.DataBindings.Clear();
                lbRoomNum.DataBindings.Add("Text", dtgvListRoom.DataSource, "MaPhong");
                lbTypeRoom.DataBindings.Clear();
                lbTypeRoom.DataBindings.Add("Text", dtgvListRoom.DataSource, "LoaiPhong");
                lbUnitPrice.DataBindings.Clear();
                lbUnitPrice.DataBindings.Add("Text", dtgvListRoom.DataSource, "DonGia");
                lbStatus.DataBindings.Clear();
                lbStatus.DataBindings.Add("Text", dtgvListRoom.DataSource, "TinhTrang");
                lbinfoRoom.DataBindings.Clear();
                lbinfoRoom.DataBindings.Add("Text", dtgvListRoom.DataSource, "ThongTin");
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbSeacrh.Text = "";
            if (cbTyperoom.Text == "")
            {
                dtgvListRoom.AutoGenerateColumns = false;
                dtgvListRoom.DataSource = QLKS_DAO.Instance.Load_Status(cbStatus.Text);
                lbRoomNum.DataBindings.Clear();
                lbRoomNum.DataBindings.Add("Text", dtgvListRoom.DataSource, "MaPhong");
                lbTypeRoom.DataBindings.Clear();
                lbTypeRoom.DataBindings.Add("Text", dtgvListRoom.DataSource, "LoaiPhong");
                lbUnitPrice.DataBindings.Clear();
                lbUnitPrice.DataBindings.Add("Text", dtgvListRoom.DataSource, "DonGia");
                lbStatus.DataBindings.Clear();
                lbStatus.DataBindings.Add("Text", dtgvListRoom.DataSource, "TinhTrang");
                lbinfoRoom.DataBindings.Clear();
                lbinfoRoom.DataBindings.Add("Text", dtgvListRoom.DataSource, "ThongTin");
            }
            else
            {
                dtgvListRoom.AutoGenerateColumns = false;
                dtgvListRoom.DataSource = QLKS_DAO.Instance.Load_Type_Status(cbTyperoom.Text, cbStatus.Text);
                lbRoomNum.DataBindings.Clear();
                lbRoomNum.DataBindings.Add("Text", dtgvListRoom.DataSource, "MaPhong");
                lbTypeRoom.DataBindings.Clear();
                lbTypeRoom.DataBindings.Add("Text", dtgvListRoom.DataSource, "LoaiPhong");
                lbUnitPrice.DataBindings.Clear();
                lbUnitPrice.DataBindings.Add("Text", dtgvListRoom.DataSource, "DonGia");
                lbStatus.DataBindings.Clear();
                lbStatus.DataBindings.Add("Text", dtgvListRoom.DataSource, "TinhTrang");
                lbinfoRoom.DataBindings.Clear();
                lbinfoRoom.DataBindings.Add("Text", dtgvListRoom.DataSource, "ThongTin");
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
        private void lbRoomNum_TextChanged(object sender, EventArgs e)
        {
            imagelist.Clear();
            try
            {
                list = QLKS_DAO.Instance.Load_RoomCode(lbRoomNum.Text);
                foreach (QLKS item in list)
                {
                    imagelist.Add(LoadImage(item.Hinh1));
                    imagelist.Add(LoadImage(item.Hinh2));
                    imagelist.Add(LoadImage(item.Hinh3));
                    imagelist.Add(LoadImage(item.Hinh4));
                }
            }
            catch
            {
                MessageBox.Show("Chưa có hình");
            }
          
        }

        private void txbSeacrh_TextChanged(object sender, EventArgs e)
        {
            dtgvListRoom.AutoGenerateColumns = false;
            dtgvListRoom.DataSource = QLKS_DAO.Instance.Load_RoomCode(txbSeacrh.Text);
            lbRoomNum.DataBindings.Clear();
            lbRoomNum.DataBindings.Add("Text", dtgvListRoom.DataSource, "MaPhong");
            lbTypeRoom.DataBindings.Clear();
            lbTypeRoom.DataBindings.Add("Text", dtgvListRoom.DataSource, "LoaiPhong");
            lbUnitPrice.DataBindings.Clear();
            lbUnitPrice.DataBindings.Add("Text", dtgvListRoom.DataSource, "DonGia");
            lbStatus.DataBindings.Clear();
            lbStatus.DataBindings.Add("Text", dtgvListRoom.DataSource, "TinhTrang");
            lbinfoRoom.DataBindings.Clear();
            lbinfoRoom.DataBindings.Add("Text", dtgvListRoom.DataSource, "ThongTin");
        }

        private void atmAddRoom_Click(object sender, EventArgs e)
        {
            if(lbStatus.Text == "Chưa Thuê")
            {
                frmBillRentRoom fr = new frmBillRentRoom(lbRoomNum.Text, lbTypeRoom.Text, lbUnitPrice.Text);
                fr.Show();
                fr.btnRent.Click += (or, er) =>
                {
                    dtgvListRoom.AutoGenerateColumns = false;
                    dtgvListRoom.DataSource = QLKS_DAO.Instance.LoadData();
                };
            }
            else
            {
                frmMessageBox.text = "Room has been rented!";
                fr.ShowDialog();
            }
        }

        private void dtgvListRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbRoomNum.DataBindings.Clear();
            lbRoomNum.DataBindings.Add("Text", dtgvListRoom.DataSource, "MaPhong");
            lbTypeRoom.DataBindings.Clear();
            lbTypeRoom.DataBindings.Add("Text", dtgvListRoom.DataSource, "LoaiPhong");
            lbUnitPrice.DataBindings.Clear();
            lbUnitPrice.DataBindings.Add("Text", dtgvListRoom.DataSource, "DonGia");
            lbStatus.DataBindings.Clear();
            lbStatus.DataBindings.Add("Text", dtgvListRoom.DataSource, "TinhTrang");
            lbinfoRoom.DataBindings.Clear();
            lbinfoRoom.DataBindings.Add("Text", dtgvListRoom.DataSource, "ThongTin");
        }
        
    }
}
