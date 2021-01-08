using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class HomepageDAO
    {
        private static HomepageDAO instance;
        public static HomepageDAO Instance
        {
            get { if (instance == null) instance = new HomepageDAO(); return HomepageDAO.instance; }
            private set { HomepageDAO.instance = value; }
        }

        private HomepageDAO() { }

        public string Load_NameNV(string email)
        {
            string tennv = "";
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.connectSTR))
            {
                SqlCommand cmd = new SqlCommand("select TenNV from NHANVIEN nv join ACCOUNT ac on nv.MaTK = ac.MaTK where ac.TenTK = '" + email + "'", connection);
                cmd.CommandType = System.Data.CommandType.Text;

                connection.Open();
                var sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        tennv = sqlDataReader.GetString(0);
                    }
                }
            }
            return tennv;
        }

        public string Type_Account(string email)
        {
            string loaiTK = "";
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.connectSTR))
            {
                SqlCommand cmd = new SqlCommand("select LoaiTK from ACCOUNT where TenTK = '" + email + "'", connection);
                cmd.CommandType = System.Data.CommandType.Text;

                connection.Open();
                var sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        loaiTK = sqlDataReader.GetString(0);
                    }
                }
            }
            return loaiTK;
        }

        public Image ByteArrayToImage(string email)
        {
            try
            {
                byte[] arr = (byte[])DataProvider.Instance.ExecuteScalar("select nv.AnhDaiDien from NHANVIEN nv join ACCOUNT ac on nv.MaTK = ac.MaTK where ac.TenTK = '" + email + "'");
                MemoryStream stream = new MemoryStream(arr);
                return Image.FromStream(stream);
            }
            catch
            {
                return null;
            }
        }

        public DataTable Load_Infor(string email)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("select * from NHANVIEN nv join ACCOUNT ac on nv.MaTK = ac.MaTK where ac.TenTK = '" + email + "'");
            return dt;
        }

        public void Update_InforEmployee(string manv, string email, string hoten, string sdt, string gioitinh, string diachi, DateTime ngsinh)
        {
            DataProvider.Instance.ExecuteQuery("EXEC USP_UPDATE_TAIKHOAN @manv , @email , @hoten , @sdt , @gioitinh , @diachi , 'Nhân Viên' , @ngaysinh", new object[] { manv, email, hoten, sdt, gioitinh, diachi, ngsinh });
        }

        byte[] ImageToByte(Image img)
        {
            MemoryStream stream = new MemoryStream();
            img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            return stream.ToArray();
        }

        public void InsertImage_Employee(Image avatar, string manv)
        {
            byte[] b = ImageToByte(avatar);

            DataProvider.Instance.ExecuteQuery("UPDATE NHANVIEN SET AnhDaiDien = @avartar WHERE MaNV = '" + manv + "'", new object[] { b });
        }

        public DataTable LoadListEmployee(string email)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("select * from NHANVIEN where NVQL in (select MaTK from ACCOUNT where LoaiTK = N'Quản Lý' and TenTK = '" + email + "')");
            return dt;
        }


        public bool Check_Email(string email, string emailtemp)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from ACCOUNT ac where '" + emailtemp + "' not in (select ac1.TenTK from ACCOUNT ac1 where ac1.MaTK = ac.MaTK)");
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i]["TenTK"].ToString() == email)
                {
                    return false;
                }
            }
            return true;
        }

        public DataTable Load_Customers()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from KHACHHANG");
            return data;
        }
        public DataTable Search_Customers(string somcnd)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from KHACHHANG where SoCMND like '%" + somcnd + "%'");
            return data;
        }

    }
}
