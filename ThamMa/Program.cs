using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThamMa
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ab bc bb aa";
            string t = "abc aaa bbbb aa";
            float[] a = Lib.tinhTanSo2(s, t);
            Console.Write(a);
        }
    }
}
