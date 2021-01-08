using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class PayRentListDAO
    {
        private static PayRentListDAO instance;
        public static PayRentListDAO Instance
        {
            get { if (instance == null) instance = new PayRentListDAO(); return PayRentListDAO.instance; }
            private set { PayRentListDAO.instance = value; }
        }

        private PayRentListDAO() { }

        public string Load_Maphieuthue(string makh)
        {
            string mapt = "";
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.connectSTR))
            {
                SqlCommand cmd = new SqlCommand("select MaPT from PHIEUTHUE where MaKH = '" + makh + "'", connection);
                cmd.CommandType = System.Data.CommandType.Text;

                connection.Open();
                var sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        mapt = sqlDataReader.GetString(0);
                    }
                }
            }
            return mapt;
        }
       
        public string Load_LoaiPhong(string maphong)
        {
            string loaip = "";
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.connectSTR))
            {
                SqlCommand cmd = new SqlCommand("select LoaiPhong from PHONG where MaPhong = '" + maphong + "'", connection);
                cmd.CommandType = System.Data.CommandType.Text;

                connection.Open();
                var sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        loaip = sqlDataReader.GetString(0);
                    }
                }
            }
            return loaip;
        }

        public string Load_DonGia(string maphong)
        {
            string dongia = "";
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.connectSTR))
            {
                SqlCommand cmd = new SqlCommand("select DonGia from PHONG where MaPhong = '" + maphong + "'", connection);
                cmd.CommandType = System.Data.CommandType.Text;

                connection.Open();
                var sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        dongia = sqlDataReader.GetInt32(0).ToString();
                    }
                }
            }
            return dongia;
        }

        public string Load_NgayGH(string maphieu)
        {
            string ngaygh = "";
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.connectSTR))
            {
                SqlCommand cmd = new SqlCommand("select NgayGH from GIAHAN where MaPT = '" + maphieu + "'", connection);
                cmd.CommandType = System.Data.CommandType.Text;

                connection.Open();
                var sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        ngaygh = sqlDataReader.GetDateTime(0).ToString("MM/dd/yyyy");
                    }
                }
                else
                {
                    ngaygh = "00/00/0000";
                }
            }
            return ngaygh;
        }

        public int Load_SoNgayGH(string maphieu)
        {
            int songaygh = 0;
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.connectSTR))
            {
                SqlCommand cmd = new SqlCommand("select SoNgayGH from GIAHAN where MaPT = '" + maphieu + "'", connection);
                cmd.CommandType = System.Data.CommandType.Text;

                connection.Open();
                var sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        songaygh = sqlDataReader.GetInt32(0);
                    }
                }
                else
                {
                    songaygh = 0;
                }
                return songaygh;
            }
        }

        public void Insert_GIAHAN(string mapt, int songaygh, string ngaygh)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_INSERT_PHIEUGH @MaPT , @SoNgayGH , @NgayGH", new object[] { mapt, songaygh, DateTime.Parse(ngaygh) });
        }
        public void Insert_PHIEUTRA_CTPT(string mapt, string ngaytra, string maphong, string songaythue, string sotienphaitra, string discount)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_INSERT_PHIEUTRA_CTPT @MaPT , @NgayTra , @MaPhong , @SoNgayThue , @SoTienPhaiTra , @Discount", new object[] { mapt, ngaytra, maphong, Int32.Parse(songaythue), sotienphaitra, discount });
        }

        public void Update_Status_PHONG(string mapt)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE PHONG SET TinhTrang = N'Chưa Thuê' WHERE MaPhong = @MaPhong", new object[] { mapt });
        }

    }
}
