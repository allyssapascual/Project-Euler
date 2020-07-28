using System;
using System.Numerics;

namespace factorial_digit_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = factorial(100);
            Console.WriteLine(num);
            BigInteger sum = 0;

            while (num > 0) {
                sum += (num % 10);
                num /= 10;
            }
            Console.WriteLine(sum);
        }

        static BigInteger factorial(int num) {
            if (num == 1) {
                return 1;
            } else {
                return num * factorial(num -1);
            }
        }
    }
}
