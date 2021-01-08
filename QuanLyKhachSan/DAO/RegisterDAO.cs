using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class RegisterDAO
    {
        int Haslen = 20;

        static List<char> lHex = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', };

        private static RegisterDAO instance;
        public static RegisterDAO Instance
        {
            get { if (instance == null) instance = new RegisterDAO(); return RegisterDAO.instance; }
            private set { RegisterDAO.instance = value; }
        }
        private RegisterDAO() { }

        public string Load_CodeAccount()
        {
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.connectSTR))
            {
                SqlCommand cmd = new SqlCommand("USP_ascending_NV", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter outputpara = new SqlParameter();
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;

                connection.Open();
                cmd.ExecuteNonQuery();
                return cmd.Parameters["@MaNV"].Value.ToString();
            }
        }

        public bool Check_Email(string email)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from ACCOUNT where TenTK = '" + email + "'");
            if (data.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Insert_Account(string matk, string tentk, string mk)
        {
            var strPwd = mk;
            var sha = new SHA1CryptoServiceProvider();
            var arrBytePwd = ASCIIEncoding.ASCII.GetBytes(strPwd);
            var strTimeNow = DateTime.Now.Millisecond.ToString();
            var arrTimeNow = ASCIIEncoding.ASCII.GetBytes(strTimeNow);
            var arrPwdSalt = new byte[arrBytePwd.Length + arrTimeNow.Length];
            Array.Copy(arrBytePwd, arrPwdSalt, arrBytePwd.Length);
            Array.Copy(arrTimeNow, 0, arrPwdSalt, arrBytePwd.Length, arrTimeNow.Length);

            var arrPwdHashed = sha.ComputeHash(arrPwdSalt);
            var arrPwdSaltHashed = new byte[arrPwdHashed.Length + arrTimeNow.Length];
            Array.Copy(arrPwdHashed, arrPwdSaltHashed, arrPwdHashed.Length);
            Array.Copy(arrTimeNow, 0, arrPwdSaltHashed, arrPwdHashed.Length, arrTimeNow.Length);
            var strPwdHashed = BitConverter.ToString(arrPwdSaltHashed).Replace("-", "");
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_INSERT_ACCOUNT @MaTK , @TenTK , @MatKhau , @LoaiTK", new object[] { matk, tentk, strPwdHashed, "Nhân Viên" });
        }

        public void Insert_NhanVien(string matk, string tennv, string sdt, string gtinh, string diachi, DateTime ngaysinh)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_INSERT_NHANVIEN @MaTK , @TenNV , @SDT , @GTinh , @DiaChi , @NgaySinh", new object[] { matk, tennv, sdt, gtinh, diachi , ngaysinh });
        }

        public bool Check_Login(string email, string mk)
        {
            string pass = "";
            var strPwd = mk;
            var sha = new SHA1CryptoServiceProvider();
            var arrBytePwd = ASCIIEncoding.ASCII.GetBytes(strPwd);
            DataTable data = DataProvider.Instance.ExecuteQuery("select MatKhau from ACCOUNT where TenTK = '" + email + "'");
            pass = data.Rows[0]["MatKhau"].ToString();
            var arrChar = pass.ToCharArray();
            var arrByte = new byte[pass.Length / 2 - Haslen];
            for (int i = Haslen * 2, j = 0; i < arrChar.Length; i += 2)
            {
                arrByte[j++] = (byte)(lHex.IndexOf(arrChar[i]) * 16 + lHex.IndexOf(arrChar[i + 1]));
            }
            var arrPwdSalt = new byte[arrBytePwd.Length + arrByte.Length];
            Array.Copy(arrBytePwd, arrPwdSalt, arrBytePwd.Length);
            Array.Copy(arrByte, 0, arrPwdSalt, arrBytePwd.Length, arrByte.Length);

            var arrPwdHashed = sha.ComputeHash(arrPwdSalt);
            var arrPwdSaltHashed = new byte[arrPwdHashed.Length + arrByte.Length];
            Array.Copy(arrPwdHashed, arrPwdSaltHashed, arrPwdHashed.Length);
            Array.Copy(arrByte, 0, arrPwdSaltHashed, arrPwdHashed.Length, arrByte.Length);
            var strPwdHashed = BitConverter.ToString(arrPwdSaltHashed).Replace("-", "");
            if(strPwdHashed == pass)
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
