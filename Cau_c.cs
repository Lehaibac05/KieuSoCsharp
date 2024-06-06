using System.Formats.Asn1;

namespace KieuSoC__c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao mot so nguyen khong am: ");
            byte num = byte.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("So khong hop le, xin moi nhap lai.");
                return;
            }
            else if (num % 2 == 0)
            {
                Console.WriteLine("Day la mot so chan.");
            }
            else
            {
                Console.WriteLine("Day la mot so le.");
            }
        }
    }
}
