using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class BillRentRoomDAO
    {
        private static BillRentRoomDAO instance;
        public static BillRentRoomDAO Instance
        {
            get { if (instance == null) instance = new BillRentRoomDAO(); return BillRentRoomDAO.instance; }
            private set { BillRentRoomDAO.instance = value; }
        }
        private BillRentRoomDAO() { }

        public string Load_CodeRentRoom()
        {
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.connectSTR))
            {
                SqlCommand cmd = new SqlCommand("USP_AUTO_MAPHIEU", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter outputpara = new SqlParameter();
                cmd.Parameters.Add("@MaPT", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;

                connection.Open();
                cmd.ExecuteNonQuery();
                return cmd.Parameters["@MaPT"].Value.ToString();
            }
        }

        public void Insert_KHACHHANG(string socmnd, string tenkh, DateTime ngsinh, string diachi)
        {
            DataProvider.Instance.ExecuteQuery("EXEC USP_INSERT_KHACHHANG @SoCMND , @TenKH , @NgSinh , @DiaChiTT", new object[] { socmnd, tenkh, ngsinh, diachi });
        }

        public void Insert_PHIEUTHUE_CT(string mapt, string socmnd, string giothue, DateTime ngaythue, string maphong, int songaythue, DateTime ngaytra)
        {
            DataProvider.Instance.ExecuteQuery("EXEC USP_INSERT_PHIEUTHUE_CTPT @MaPT , @SoCMND , @GioThue , @NgayThue , @MaPhong , @SoNgayThue , @NgayTra", new object[] { mapt, socmnd, giothue, ngaythue, maphong, songaythue, ngaytra });
        }

        public void Update_PHONG(string maphong)
        {
            DataProvider.Instance.ExecuteQuery("UPDATE PHONG SET TinhTrang = N'Đã Thuê' WHERE MaPhong = '" + maphong + "'");
        }
    }
}
