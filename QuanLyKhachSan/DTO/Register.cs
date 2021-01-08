using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class Register
    {
        public Register(string email, string fullname, string numphone, string sex, string address)
        {
            this.Email = email;
            this.Fullname = fullname;
            this.Numberphone = numphone;
            this.Sex = sex;
            this.Address = address;
        }

        public Register(DataRow row)
        {
            this.Email = row["TenTK"].ToString();
            this.Fullname = row["TenNV"].ToString();
            this.Numberphone = row["SDT"].ToString();
            this.Sex = row["GTinh"].ToString();
            this.Address = row["DiaChi"].ToString();
        }
        private string email;
        private string fullname;
        private string numberphone;
        private string sex;
        private string address;

        public string Email { get => email; set => email = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Numberphone { get => numberphone; set => numberphone = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Address { get => address; set => address = value; }
    }
}
