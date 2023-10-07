using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorSoSanh
{
    public class SinhVien : IComparable<SinhVien>
    {
        public string hoten;
        public double diem;
        public string email;
        public void InTT()
        {
            Console.WriteLine($"Ten: {hoten}, Diem: {diem}, email:{email}");
        }

        public int CompareTo(SinhVien other)
        {
            return email.CompareTo( other.email);
        }

        public SinhVien(string hoten, double diem, string email)
        {
            this.hoten = hoten;
            this.diem = diem;
            this.email = email;
        }

        public SinhVien()
        {
        }
    }

    public class SinhVienComparer : IComparer<SinhVien>
    {
        public string sortBy;

        public SinhVienComparer(string sortBy)
        {
            this.sortBy= sortBy;
        }

        public int Compare(SinhVien x, SinhVien y)
        {
            int output = 0;
            switch (sortBy)
            {
                case "hoten":
                    {
                        output = x.hoten.CompareTo(y.hoten);
                        return output;
                    }
                case "diem":
                    {
                        output = x.diem.CompareTo(y.diem);
                        return output;
                    }
                case "email":
                    {
                        output = x.email.CompareTo(y.email);
                        return output;
                    }
                default: return 0;
            }
        }
    }
}
