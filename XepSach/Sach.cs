using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XepSach
{
    public  class Sach : IComparable<Sach>
    {
        public string Ten;
        public string tacgia;
        public int namST;

        public Sach(string ten, string tacgia, int namST)
        {
            Ten = ten;
            this.tacgia = tacgia;
            this.namST = namST;
        }

        public int CompareTo(Sach other)
        {
            return this.namST.CompareTo(other.namST);
        }

        public void InTT()
        {
            Console.WriteLine($"Ten: {Ten}, Tac gia: {tacgia}, nam: {namST}");
        }
    }
}
