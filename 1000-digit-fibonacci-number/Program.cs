using System;
using System.Numerics;

namespace _1000_digit_fibonacci_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int index = 2;
            BigInteger limit = BigInteger.Pow(10, 999);
            BigInteger[] fib = new BigInteger[3];
            
            fib[0] = 1;
            fib[2] = 1;
            
            while (fib[i] <= limit) {
                i = (i + 1) % 3;
                index++;
                fib[i] = fib[(i + 1) % 3] + fib[(i + 2) % 3];
            }
            Console.WriteLine($"{index} - {fib[i]}");
        }
    }
}

        //     // Using Binet's formula
        //     //((1 + √5)^n - (1 - √5)^n) / (2^n * √5)

        //     BigInteger limit = BigInteger.Pow(10, 999);
        //     BigInteger binet = 0;
        //     int i = 0;

        //     while (binet <= limit)
        //     {
        //         binet = binetFunction(i);
        //         Console.WriteLine($"{i} - {binet}");
        //         i++;
        //     }
        // }

        // static BigInteger binetFunction (int n) 
        // {
        //     double sqrt5 = Math.Sqrt(5);
        //     return (BigInteger) (( Math.Pow(1 + sqrt5, n) - Math.Pow(1 - sqrt5, n) ) / ( Math.
        //     Pow(2, n) * sqrt5 ));
        // }
