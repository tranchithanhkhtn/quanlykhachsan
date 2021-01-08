using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class TransactionInvoiceDAO
    {
        private static TransactionInvoiceDAO instance;
        public static TransactionInvoiceDAO Instance
        {
            get { if (instance == null) instance = new TransactionInvoiceDAO(); return TransactionInvoiceDAO.instance; }
            private set { TransactionInvoiceDAO.instance = value; }
        }
        private TransactionInvoiceDAO() { }

        public DataTable Load_PhieuThue()
        {
            string sql = "select pt.MaPT as [Phiếu Thuê], ctpt.MaPhong as [Phòng], pt.NgayThue as [Ngày Thuê], pt.NgayTra as [Ngày Trả], ctpt.SoNgayThue as [Số NT], kh.SoCMND as [Số CMND], kh.TenKH as [Tên KH] from PHIEUTHUE pt join CT_PHIEUTHUE ctpt on pt.MaPT = ctpt.MaPT join KHACHHANG kh on pt.MaKH = kh.MaKH";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            return data;
        }

        public DataTable Load_PhieuTra()
        {
            string sql = "select pt.MaPTra as [Phiếu Trả], pt.MaPT as [Phiếu Thuê], ctpt.MaPhong as [Phòng] , pt.NgayTra as [Ngày Trả], ctpt.SoNgayThue as [Số NT], ctpt.SoTienPhaiTra as [Tổng Tiền], ctpt.Discount as [Giảm Giá] from PHIEUTRA pt join CT_PHIEUTRA ctpt on pt.MaPTra = ctpt.MaPTra";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            return data;
        }

        public DataTable Search_PhieuThue(string mapt)
        {
            string sql = "select pt.MaPT as [Phiếu Thuê], ctpt.MaPhong as [Phòng], pt.NgayThue as [Ngày Thuê], pt.NgayTra as [Ngày Trả], ctpt.SoNgayThue as [Số NT], kh.SoCMND as [Số CMND], kh.TenKH as [Tên KH] from PHIEUTHUE pt join CT_PHIEUTHUE ctpt on pt.MaPT = ctpt.MaPT join KHACHHANG kh on pt.MaKH = kh.MaKH where pt.MaPT like '%" + mapt +"%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            return data;
        }

        public DataTable Search_PhieuTra(string mapt)
        {
            string sql = "select pt.MaPTra as [Phiếu Trả], pt.MaPT as [Phiếu Thuê], ctpt.MaPhong as [Phòng] , pt.NgayTra as [Ngày Trả], ctpt.SoNgayThue as [Số NT], ctpt.SoTienPhaiTra as [Tổng Tiền], ctpt.Discount as [Giảm Giá] from PHIEUTRA pt join CT_PHIEUTRA ctpt on pt.MaPTra = ctpt.MaPTra where pt.MaPTra like '%"+ mapt + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            return data;
        }
        public DataTable Revenue_RentalSlip()
        {
            string sql = "select ctpt.MaPhong, count(pt.MaPT) as [SL Phiếu Thuê] from PHIEUTHUE pt join CT_PHIEUTHUE ctpt on pt.MaPT = ctpt.MaPT GROUP BY ctpt.MaPhong";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            return data;
        }

        public DataTable Revenue_ReturnSlip()
        {
            string sql = "select MONTH(pt.NgayTra) as [Thang] , SUM(ctpt.SoTienPhaiTra) as [TongTien] from PHIEUTRA pt join CT_PHIEUTRA ctpt on pt.MaPTra = ctpt.MaPTra GROUP BY MONTH(pt.NgayTra) ";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            return data;
        }
    }
}
