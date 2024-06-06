using System.Diagnostics.CodeAnalysis;

namespace KieuSoC__e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao mot so nguyen khong am bat ky: ");
            uint n = uint.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("so khong hop le, xin moi nhap lai.");
                return;
            }
            else
            {
                uint sum = (n*(n+1))/2;
                Console.WriteLine("Tong cua ca so tu 1 den " + n + " la: " + sum);
            }

            
        }
    }
}
