using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class AccountListDAO
    {
        private static AccountListDAO instance;

        public static AccountListDAO Instance
        {
            get { if (instance == null) instance = new AccountListDAO(); return AccountListDAO.instance; }
            private set { AccountListDAO.instance = value; }
        }
        private AccountListDAO() { }

        public DataTable Load_Data()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select nv.MaNV, ac.TenTK, ac.LoaiTK , nv.TenNV , nv.SDT , nv.GTinh , nv.DiaChi , nv.NgSinh from ACCOUNT ac join NHANVIEN nv on ac.MaTK = nv.MaNV");
            return data;
        }

        public DataTable Load_Data_NV(string manv)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select MaNV as [Mã NV], TenNV as [Họ Tên] from NHANVIEN nv join ACCOUNT ac on nv.MATK = ac.MATK where MaNV != '"+ manv + "' and ac.LoaiTK = N'Nhân Viên'");
            return data;
        }

        public void Update_QuanLyNV(string manv, string nvql)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE NHANVIEN SET NVQL = '"+ nvql + "' WHERE MaNV = '" + manv + "'");
        }

        public void Update_NV(string manv)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE NHANVIEN SET NVQL = null WHERE MaNV = '" + manv + "'");
        }

        public void Delete_Account(string manv)
        {
            DataProvider.Instance.ExecuteNonQuery("DELETE FROM NHANVIEN WHERE MaTK = '" + manv + "'");
            DataProvider.Instance.ExecuteNonQuery("DELETE FROM ACCOUNT WHERE MaTK = '" + manv + "'");
        }
        public DataTable Search_Accoutn(string manv)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select nv.MaNV, ac.TenTK, ac.LoaiTK , nv.TenNV , nv.SDT , nv.GTinh , nv.DiaChi from ACCOUNT ac join NHANVIEN nv on ac.MaTK = nv.MaNV where nv.MaNV like '%" + manv + "%'");
            return data;
        }

        public bool Reset_Pass(string manv)
        {
            string PassReset = "1";
            var strPwd = PassReset;
            var sha = new SHA1CryptoServiceProvider();
            var arrBytePwd = ASCIIEncoding.ASCII.GetBytes(PassReset);
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
            if(DataProvider.Instance.ExecuteNonQuery("UPDATE ACCOUNT SET MatKhau = '"+ strPwdHashed + "' WHERE MaTK = '" + manv + "'") == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Update_Account(string manv, string email, string hoten, string sdt, string gioitinh, string diachi, string loaitk, DateTime ngsinh)
        {
            DataProvider.Instance.ExecuteQuery("EXEC USP_UPDATE_TAIKHOAN @manv , @email ,  @hoten , @sdt ,  @gioitinh , @diachi ,  @loaiTK , @ngaysinh" , new object[] { manv, email , hoten , sdt , gioitinh , diachi , loaitk , ngsinh });
        }

        public void Update_ManagerEmployee(string manv)
        {
            DataProvider.Instance.ExecuteQuery("EXEC USP_UPDATE_NHANVIEN @manv", new object[] { manv });
        }
        public void Update_Password(string email, string mk)
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
            DataProvider.Instance.ExecuteQuery("UPDATE ACCOUNT SET MatKhau = '"+ strPwdHashed + "' where TenTK = '"+ email + "'");
        }
    
    }
}
