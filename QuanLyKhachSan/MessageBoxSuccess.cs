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
    public partial class MessageBoxSuccess : Form
    {
        public MessageBoxSuccess()
        {
            InitializeComponent();
        }

        private void MessageBoxSuccess_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < 1; i++)
            {
                timer.Stop();
                this.Close();
            }
        }
    }
}
