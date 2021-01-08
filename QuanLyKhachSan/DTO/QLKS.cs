using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class QLKS
    {
        public QLKS(string maphong, string loaiphong, int dongia, string tinhtrang, string thongtin, byte[] hinh1, byte[] hinh2, byte[] hinh3, byte[] hinh4)
        {
            this.MaPhong = maphong;
            this.LoaiPhong = loaiphong;
            this.DonGia = dongia;
            this.TinhTrang = tinhtrang;
            this.ThongTin = thongtin;
            this.Hinh1 = hinh1;
            this.Hinh2 = hinh2;
            this.Hinh3 = hinh3;
            this.Hinh4 = hinh4;
        }

        public QLKS(DataRow row)
        {
            this.MaPhong = row["MaPhong"].ToString();
            this.LoaiPhong = row["LoaiPhong"].ToString();
            this.DonGia = (int)row["DonGia"];
            this.TinhTrang = row["TinhTrang"].ToString();
            this.ThongTin = row["ThongTin"].ToString();
            this.Hinh1 = (byte[])row["HinhAnh1"];
            this.Hinh2 = (byte[])row["HinhAnh2"];
            this.Hinh3 = (byte[])row["HinhAnh3"];
            this.Hinh4 = (byte[])row["HinhAnh4"];
        }

        private string maPhong;
        private string loaiPhong;
        private int donGia;
        private string tinhTrang;
        private string thongTin;
        private byte[] hinh1;
        private byte[] hinh2;
        private byte[] hinh3;
        private byte[] hinh4;

        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string ThongTin { get => thongTin; set => thongTin = value; }
        public byte[] Hinh1 { get => hinh1; set => hinh1 = value; }
        public byte[] Hinh2 { get => hinh2; set => hinh2 = value; }
        public byte[] Hinh3 { get => hinh3; set => hinh3 = value; }
        public byte[] Hinh4 { get => hinh4; set => hinh4 = value; }
    }
}
