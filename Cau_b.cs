namespace KieuSoC__b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao chieu dai: ");
            Byte cd = Byte.Parse(Console.ReadLine());

            Console.Write("Nhap vao chieu rong: ");
            Byte cr = Byte.Parse(Console.ReadLine());

            int S = cd*cr;
            int C = (cr + cd) * 2;

            Console.WriteLine("Dien tich cua hcn la: " +S);
            Console.WriteLine("Dien tich cua hcn la: " + C);
        }
    }
}
