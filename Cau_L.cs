namespace KieuSoC__L
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen khong am n: ");
            int n = int.Parse(Console.ReadLine());

            bool isPrime = IsPrime(n);

            if (isPrime)
                Console.WriteLine(n + " là số nguyên tố.");
            else
                Console.WriteLine(n + " khong phai la so nguyen to.");
        }

        static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
