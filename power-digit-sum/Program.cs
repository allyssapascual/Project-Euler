using System;
using System.Numerics;

namespace power_digit_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger exp = (BigInteger) Math.Pow(2, 1000);
            BigInteger result = 0;

            while (exp > 0) {
                result += (exp % 10);
                exp /= 10;
            }
            Console.WriteLine($"{result}");
        }
    }
}
