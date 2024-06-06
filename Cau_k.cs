namespace KieuSoC__k
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen khong am n: ");
            int n = int.Parse(Console.ReadLine());

            int factorial = CalculateFactorial(n);

            Console.WriteLine("Giai thua cua " + n + " la: " + factorial);
        }

        static int CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * CalculateFactorial(n - 1);
        }
    }
}
