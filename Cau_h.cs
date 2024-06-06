namespace KieuSoC__h
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu ba: ");
            int num3 = int.Parse(Console.ReadLine());

            int max = Math.Max(num1, Math.Max(num2, num3));

            Console.WriteLine("So lon nhat trong ba so là: " + max);
        }
    }
}
