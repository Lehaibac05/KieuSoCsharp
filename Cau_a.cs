using System.Formats.Asn1;

namespace KieuSoC__a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            uint num1 = uint.Parse(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            uint num2 = uint.Parse(Console.ReadLine()); 

            uint sum = num1 + num2;

            Console.WriteLine("Tong cua hai so la: " +sum);
        }
    }
}
