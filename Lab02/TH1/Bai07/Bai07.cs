using System;

class Program7
{
    static bool isPrime(long n)
    {
        if (n < 2) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        for (long i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    public static void run()
    {
        Console.Write("Nhap n: ");
        long n = long.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine($"Da nhap n = {n}");

        if (isPrime(n))
            Console.WriteLine($"{n} la so nguyen to");
        else
            Console.WriteLine($"{n} khong phai so nguyen to");
    }
}