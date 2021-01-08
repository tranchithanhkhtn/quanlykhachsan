using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class TransactionInvoice
    {
        public TransactionInvoice(string mapt, string maphong, string ngaythue, int songaythue,  string socmnd, string tenkh)
        {
            this.MaPT = mapt;
            this.MaPhong = maphong;
            this.NgayThue = ngaythue;
            this.SoNgayThue = songaythue;
            this.SoCMND = socmnd;
            this.TenKH = tenkh;
        }
        public TransactionInvoice(DataRow row)
        {
            this.MaPT = row["MaPT"].ToString();
            this.MaPhong = row["MaPhong"].ToString();
            this.NgayThue = row["NgayThue"].ToString();
            this.SoNgayThue = (int)row["SoNgayThue"];
            this.SoCMND = row["SoCMND"].ToString();
            this.TenKH = row["TenKH"].ToString();
        }

        private string maPT;
        private string maPhong;
        private string ngayThue;
        private int soNgayThue;
        private string soCMND;
        private string tenKH;

        public string MaPT { get => maPT; set => maPT = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string NgayThue { get => ngayThue; set => ngayThue = value; }
        public int SoNgayThue { get => soNgayThue; set => soNgayThue = value; }
        public string SoCMND { get => soCMND; set => soCMND = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
    }
}
