using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class FoodListDAO
    {
        private static FoodListDAO instance;

        public static FoodListDAO Instance
        {
            get { if (instance == null) instance = new FoodListDAO(); return FoodListDAO.instance; }
            private set { FoodListDAO.instance = value; }
        }
        private FoodListDAO() { }

        public List<FoodList> Load_ItemList()
        {
            List<FoodList> listfood = new List<FoodList>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetFoodList");

            foreach (DataRow item in data.Rows)
            {
                FoodList fl = new FoodList(item);
                listfood.Add(fl);
            }

            return listfood;
        }

        public DataTable Load_IDKH()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("select ctpt.MaPhong from PHIEUTHUE pt join CT_PHIEUTHUE ctpt on pt.MaPT = ctpt.MaPT");
            return dt;
        }

        public string Load_WithIDRoom(string maphong)
        {
            try
            {
                var dt = DataProvider.Instance.ExecuteScalar("select pt.MaKH from PHIEUTHUE pt join CT_PHIEUTHUE ctpt on pt.MaPT = ctpt.MaPT where ctpt.MaPhong = '" + maphong + "'");
                return dt.ToString();
            }
            catch
            {
                return null;
            }
        }

        public void Insert_BillFoods(string makh, string id, string tentp, int slg, float giathanh, float tongtien)
        {
            DataProvider.Instance.ExecuteQuery("EXEC USP_INSERT_BILLFOODS @MaKH , @ID , @TenTP , @SoLuong , @GiaThanh , @TongTien", new object[] { makh, id, tentp, slg, giathanh, tongtien });
        }

        public DataTable Load_Bill(string makh)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("select * from BILLFOOD where MaKH = '" + makh + "'");
            return dt;
        }

        public DataTable NameCustomer(string makh)
        {
            DataTable dt =  DataProvider.Instance.ExecuteQuery("select TenKH from KHACHHANG where MaKH = '"+ makh + "'");
            return dt;
        }

        public void Update_SoLuong(int soluong, string id)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE FOODLIST SET SoLuong = "+ soluong + " where ID = '"+ id + "'");
        }
    }
}
