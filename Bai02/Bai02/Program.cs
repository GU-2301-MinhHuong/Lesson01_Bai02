using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap gia tri cua n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            DanhSach(n);
            SoChan(n);
            SoLe(n);
            DaoNguoc(n);
            Console.ReadKey();
        }

        static void DanhSach(int n)
        {
            int i;
            Console.WriteLine("Danh sach cac so tu 1 den n: ");
            for(i = 1; i <= n; i++)
            {
                Console.WriteLine("     " +i);
            }
        }
        static void SoChan(int n)
        {
            int i;
            Console.WriteLine("Danh sach cac so chan tu 1 den n: ");
            for (i = 1; i <= n; i++)
            {
                if(i % 2 == 0 )
                {
                    Console.WriteLine("     " + i);
                }
            }
        }
        static void SoLe(int n)
        {
            int i;
            Console.WriteLine("Danh sach cac so le tu 1 den n: ");
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("     " + i);
                }
            }
        }
        static void DaoNguoc(int n)
        {
            int i;
            Console.WriteLine("Danh sach cac so tu n den 1: ");
            for (i = n; i >= 1; i--)
            {
                Console.WriteLine("     " + i);
            }
        }
    }
}
