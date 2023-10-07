using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XepSach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sach> tenList = new List<Sach>();

            Sach s1 = new Sach("Triet hoc mac-lenin", "C.Mac", 1840);
            Sach s2 = new Sach("Harry phong to", "J.K rau link", 1497);
            Sach s3 = new Sach("Nhat ky trong tu", "Chu tich HCM", 1941);

            tenList.Add(s1);
            tenList.Add(s2);
            tenList.Add(s3);


            tenList.Sort();
            foreach (Sach s in tenList)
            {
                s.InTT();
            }

            Console.ReadLine();
        }
    }
}
