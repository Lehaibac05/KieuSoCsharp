namespace KieuSoC__g
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu dai: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("Dien tich hinh chu nhat: " + area);
            Console.WriteLine("Chu vi hinh chu nhat: " + perimeter);
        }
    }
}
