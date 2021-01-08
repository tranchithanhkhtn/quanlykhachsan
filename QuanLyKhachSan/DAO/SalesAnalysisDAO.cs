using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class SalesAnalysisDAO
    {
        private static SalesAnalysisDAO instance;
        public static SalesAnalysisDAO Instance
        {
            get { if (instance == null) instance = new SalesAnalysisDAO(); return SalesAnalysisDAO.instance; }
            private set { SalesAnalysisDAO.instance = value; }
        }
        private SalesAnalysisDAO() { }
        public DataTable Revenue_SalesAnalysis()
        {
            string sql = "select SUBSTRING(pt.GioThue, 1, 2) as [GioThue], count(*) AS [Số Lượt Thuê] from PHIEUTHUE pt join CT_PHIEUTHUE ctpt on pt.MaPT = ctpt.MaPT where pt.NgayThue = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' group by SUBSTRING(pt.GioThue, 1, 2)";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            return data;
        }

    }
}
