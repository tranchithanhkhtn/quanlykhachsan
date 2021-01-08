using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class FoodListOrder
    {
        public FoodListOrder(string id, string tentp, int solg,int giathanh , int tongtien)
        {
            this.ID = id;
            this.TenTP = tentp;
            this.GiaThanh = giathanh;
            this.SoLuong = solg;
            this.TongTien = tongtien;
        }


        public FoodListOrder(DataRow row)
        {
            this.ID = row["ID"].ToString();
            this.TenTP = row["TenTP"].ToString();
            this.GiaThanh = (int)row["GiaThanh"];
            this.SoLuong = (int)row["SoLuong"];
            this.TongTien = (int)row["TongTien"];
        }

        private string iD;
        private string tenTP;
        private int soLuong;
        private int giaThanh;
        private int tongTien;


        public string ID { get => iD; set => iD = value; }
        public string TenTP { get => tenTP; set => tenTP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int GiaThanh { get => giaThanh; set => giaThanh = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
    }
}
