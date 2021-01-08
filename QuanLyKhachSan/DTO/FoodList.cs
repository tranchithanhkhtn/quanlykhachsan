using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class FoodList
    {
        public FoodList(string id, string loai, string tentp, float giathanh, Image hinhanh, int solg, string status)
        {
            this.ID = id;
            this.Loai = loai;
            this.TenTP = tentp;
            this.GiaThanh = giathanh;
            this.HinhAnh = hinhanh;
            this.SoLuong = solg;
            this.TrangThai = status;
        }

        public Image ByteArrayToImage(byte[] arr)
        {
            try
            {
                MemoryStream stream = new MemoryStream(arr);
                return Image.FromStream(stream);
            }
            catch
            {
                return null;
            }
        }
        public FoodList(DataRow row)
        {
            this.ID = row["ID"].ToString();
            this.Loai = row["Loai"].ToString();
            this.TenTP = row["TenTP"].ToString();
            this.GiaThanh = Convert.ToSingle(row["GiaThanh"]);
            this.SoLuong = (int)row["SoLuong"];
            this.TrangThai = row["TrangThai"].ToString();
            this.HinhAnh = ByteArrayToImage((byte[])row["HinhAnh"]);
        }
        private string iD;
        private string loai;
        private string tenTP;
        private float giaThanh;
        private Image hinhAnh;
        private int soLuong;
        private string trangThai;
        public string ID { get => iD; set => iD = value; }
        public string Loai { get => loai; set => loai = value; }
        public string TenTP { get => tenTP; set => tenTP = value; }
        public float GiaThanh { get => giaThanh; set => giaThanh = value; }
        public Image HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }


    }
}
