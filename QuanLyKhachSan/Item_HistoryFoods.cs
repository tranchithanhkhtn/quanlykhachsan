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
    public partial class Item_HistoryFoods : UserControl
    {
        public Item_HistoryFoods()
        {
            InitializeComponent();
        }

        private string namecustomer;

        public string NameCustomer
        {
            get { return namecustomer; }
            set { namecustomer = value; lbNameCustomer.Text = value; }
        }

        private string amount;

        public string Amount
        {
            get { return amount; }
            set { amount = value; lbAmount.Text = value; }
        }

        private string unitprice;

        public string UnitPrice
        {
            get { return unitprice; }
            set { unitprice = value; String.Format("{0:0,0}",lbPrice.Text = value); }
        }

        private string totalprice;

        public string TotalPrice
        {
            get { return totalprice; }
            set { totalprice = value; String.Format("{0:0,0}", lbTotalPrice.Text = value); }
        }
    }
}
