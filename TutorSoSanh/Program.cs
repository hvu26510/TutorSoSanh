using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorSoSanh
{
    internal class Program
    {
        static void Main(string[] args)
        {


            SinhVien sv1 = new SinhVien("Nguyen Van A", 10, "a");
            SinhVien sv2 = new SinhVien("Nguyen Van B", 5, "b");
           
            List<SinhVien> arrlist = new List<SinhVien>();

            arrlist.Add(sv1);
            arrlist.Add(sv2);

            arrlist.Sort(new SinhVienComparer("email"));

            foreach (SinhVien i in arrlist)
            {
                i.InTT();
            }
            Console.ReadLine();
        }
    }
}
