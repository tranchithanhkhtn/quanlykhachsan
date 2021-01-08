using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyKhachSan.DAO
{
    public class QLKS_DAO
    {
        private static QLKS_DAO instance;
        public static QLKS_DAO Instance
        {
            get { if (instance == null) instance = new QLKS_DAO(); return QLKS_DAO.instance; }
            private set { QLKS_DAO.instance = value; }
        }
        private QLKS_DAO() { }

        public List<QLKS> LoadData()
        {
            List<QLKS> list = new List<QLKS>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from PHONG");
            foreach (DataRow item in data.Rows)
            {
                QLKS fl = new QLKS(item);
                list.Add(fl);
            }

            return list;
        }


        public List<QLKS> Load_TypeRoom(string type)
        {
            List<QLKS> list = new List<QLKS>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from PHONG where LoaiPhong = '" + type + "'");

            foreach (DataRow item in data.Rows)
            {
                QLKS fl = new QLKS(item);
                list.Add(fl);
            }

            return list;
        }

        public List<QLKS> Load_RoomCode(string type)
        {
            List<QLKS> list = new List<QLKS>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from PHONG where MaPhong = '" + type + "'");

            foreach (DataRow item in data.Rows)
            {
                QLKS fl = new QLKS(item);
                list.Add(fl);
            }

            return list;
        }

        public List<QLKS> Load_Status(string status)
        {
            List<QLKS> list = new List<QLKS>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from PHONG where TinhTrang = N'" + status + "'");

            foreach (DataRow item in data.Rows)
            {
                QLKS fl = new QLKS(item);
                list.Add(fl);
            }

            return list;
        }

        public List<QLKS> Load_Type_Status(string type, string status)
        {
            List<QLKS> list = new List<QLKS>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from PHONG where LoaiPhong = '" + type + "' and TinhTrang = N'" + status + "'");

            foreach (DataRow item in data.Rows)
            {
                QLKS fl = new QLKS(item);
                list.Add(fl);
            }

            return list;
        }
    }
}
