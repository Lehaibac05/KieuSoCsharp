namespace KieuSoC__m
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());

            bool isPerfect = IsPerfectNumber(n);

            if (isPerfect)
                Console.WriteLine(n + " là so hoan hao.");
            else
                Console.WriteLine(n + " khong phai là so hoan hao.");
        }

        static bool IsPerfectNumber(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    sum += i;
            }

            return sum == n;
        }
    }
}
