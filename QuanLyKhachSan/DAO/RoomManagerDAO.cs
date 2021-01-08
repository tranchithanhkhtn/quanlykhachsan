using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class RoomManagerDAO
    {
        private static RoomManagerDAO instance;
        public static RoomManagerDAO Instance
        {
            get { if (instance == null) instance = new RoomManagerDAO(); return RoomManagerDAO.instance; }
            private set { RoomManagerDAO.instance = value; }
        }
        private RoomManagerDAO() { }
        public List<RoomManager> Load_PHONG()
        {
            List<RoomManager> list = new List<RoomManager>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from PHONG");

            foreach (DataRow item in data.Rows)
            {
                RoomManager fl = new RoomManager(item);
                list.Add(fl);
            }

            return list;
        }
       
        public List<RoomManager> Load_RoomCode(string type)
        {
            List<RoomManager> list = new List<RoomManager>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from PHONG where MaPhong = '" + type + "'");

            foreach (DataRow item in data.Rows)
            {
                RoomManager fl = new RoomManager(item);
                list.Add(fl);
            }

            return list;
        }

        public bool Check_Code(string type)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from PHONG where MaPhong = '" + type + "'");
            if(data.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private byte[] Xuly_Image(Image temp)
        {
            MemoryStream stream = new MemoryStream();
            temp.Save(stream, ImageFormat.Jpeg);
            return stream.ToArray();
        }

        public void Insert_PHONG(string maphong, string loaiphong, string dongia, string thongtin, Image hinh1, Image hinh2, Image hinh3, Image hinh4)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_INSERT_PHONG @MaPhong , @LoaiPhong , @DonGia , @ThongTin , @Hinh1 , @Hinh2 , @Hinh3 , @Hinh4", new object[] { maphong , loaiphong , dongia , thongtin , Xuly_Image(hinh1), Xuly_Image(hinh2), Xuly_Image(hinh3), Xuly_Image(hinh4) });
        }

        public void Update_PHONG(string maphong, string loaiphong, string dongia, string thongtin, Image hinh1, Image hinh2, Image hinh3, Image hinh4)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_UPDATE_PHONG @MaPhong , @LoaiPhong , @DonGia , @ThongTin , @Hinh1 , @Hinh2 , @Hinh3 , @Hinh4", new object[] { maphong, loaiphong, dongia, thongtin, Xuly_Image(hinh1), Xuly_Image(hinh2), Xuly_Image(hinh3), Xuly_Image(hinh4) });
        }

        public bool Delete_Phong(string maphong)
        {
            if(DataProvider.Instance.ExecuteNonQuery("DELETE FROM PHONG WHERE MaPhong = '" + maphong + "'") == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
}
