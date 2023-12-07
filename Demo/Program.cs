using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ban kinh r = ");
            float r = float.Parse(Console.ReadLine());

            Console.WriteLine("Chu vi hinh tron co ban kinh {0} la: {1}", r, 2 * 3.14 * r);
            Console.WriteLine("Dien tich hinh tron co ban kinh {0} la: {1}", r, 3.14 * r * r);
            Console.ReadLine();
        }
        public static int TinhTong(int a, int b)
        { return a + b; }
        public static double TinhHieu(double a, double b)
        {
            return a - b;
        }
    }
}
