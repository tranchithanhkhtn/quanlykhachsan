using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class Item_Food : UserControl
    {
        public Item_Food()
        {
            InitializeComponent();
        }

        public static int tempt;
        private string namefood;

        public string NameFood
        {
            get { return namefood; }
            set { namefood = value; lbNameFood.Text = value; }
        }

        private string dongia;

        public string DonGia
        {
            get { return dongia; }
            set { dongia = value; lbMoney.Text = value; }
        }

        private string soluong;

        public string SoLuong
        {
            get { return soluong; }
            set { soluong = value; lbCountFood.Text = value; }
        }

        private Image hinhanh;
        public Image Hinhanh
        {
            get { return hinhanh; }
            set { hinhanh = value; pt_Image.Image = value; }
        }


        private void Item_Food_Load(object sender, EventArgs e)
        {
            plBG.BackColor = Color.FromArgb(100, Color.Black);
        }
    }
}
