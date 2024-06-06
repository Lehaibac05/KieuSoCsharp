namespace KieuSoC__d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so nguyen thu nhat co dau: ");
            sbyte num1 = sbyte.Parse(Console.ReadLine());

            Console.Write("Nhap vao so nguyen thu hai co dau: ");
            sbyte num2 = sbyte.Parse(Console.ReadLine());

            sbyte sum = (sbyte)(num1 + num2);
            
            Console.WriteLine("Tong cua hai so la: "+sum);
        }
    }
}
