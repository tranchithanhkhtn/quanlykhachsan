using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class RentListDAO
    {
        private static RentListDAO instance;
        public static RentListDAO Instance
        {
            get { if (instance == null) instance = new RentListDAO(); return RentListDAO.instance; }
            private set { RentListDAO.instance = value; }
        }
        private RentListDAO() { }

        public DataTable Load_Data()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_LOADRentList");
            return data;
        }
        public DataTable Load_CustomerCode(string CustomerCode)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select kh.MaKH , kh.TenKH , kh.SoCMND , ct_pt.MaPhong , pt.NgayThue , ct_pt.SoNgayThue from PHIEUTHUE pt join CT_PHIEUTHUE ct_pt on pt.MaPT = ct_pt.MaPT join KHACHHANG kh on pt.MaKH = kh.MaKH where pt.MaPT not in (select MaPT from PHIEUTRA) and kh.SoCMND like '%" + CustomerCode + "%'");
            return data;
        }

        public DataTable Load_CustomerName(string CustomerName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select kh.MaKH , kh.TenKH , kh.SoCMND , ct_pt.MaPhong , pt.NgayThue , ct_pt.SoNgayThue from PHIEUTHUE pt join CT_PHIEUTHUE ct_pt on pt.MaPT = ct_pt.MaPT join KHACHHANG kh on pt.MaKH = kh.MaKH where pt.MaPT not in (select MaPT from PHIEUTRA) and TenKH like N'%" + CustomerName + "%'");
            return data;
        }
    }
}
