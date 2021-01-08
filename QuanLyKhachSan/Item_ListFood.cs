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
    public partial class Item_ListFood : UserControl
    {
        public Item_ListFood()
        {
            InitializeComponent();
           
        }
        public static string total;
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

        private int nmCount;

        public int SoLuong
        {
            get { return nmCount; }
            set { nmCount = value; lbCount.Text = value.ToString(); }
        }

        public string tongtien;

        public string TongTien
        {
            get { return tongtien; }
            set { tongtien = value; lbTotalMoney.Text = value; }
        }

        private string loai;

        public string LoaiFood
        {
            get { return loai; }
            set { loai = value; lbType.Text = value; }
        }


        private void Item_ListFood_Load(object sender, EventArgs e)
        {
            lbTotalMoney.Text = lbMoney.Text;
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            btnMinus.Enabled = true;
            lbCount.Text = (Int32.Parse(lbCount.Text) + 1).ToString();
            lbTotalMoney.Text = (Int32.Parse(lbCount.Text) * Int32.Parse(lbMoney.Text)).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if(Int32.Parse(lbCount.Text) <= 1)
            {
                btnMinus.Enabled = false;
            }
            else
            {
                lbCount.Text = (Int32.Parse(lbCount.Text) - 1).ToString();
                lbTotalMoney.Text = (Int32.Parse(lbCount.Text) * Int32.Parse(lbMoney.Text)).ToString();
            }
        }

        private void lbCount_TextChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(lbCount.Text) == 1)
            {
                btnMinus.Enabled = false;
            }
            else
            {
                btnMinus.Enabled = true;
            }
        }
    }
}
