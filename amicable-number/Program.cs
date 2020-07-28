using System;
using System.Collections.Generic;

namespace amicable_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int factors1, factors2;
            int limit = 10000;

            for (int i = 2; i <= limit; i++) {
                factors1 = sumProperDivisor(i);
                if (factors1 > i && factors1 <= limit) {
                    factors2 = sumProperDivisor(factors1);
                    if (factors2 == i) {
                        sum += i + factors1;
                        Console.WriteLine($"factors1: {i} factors2: {factors1}");
                    }
                } 
            }
            Console.WriteLine(sum);
        }

        static int sumProperDivisor(int num) {
            int limit = (int)Math.Sqrt(num);
            int sum = 1;

            if (num == limit * limit) {
                sum += limit;
                limit--;
            }

            for (int i = 2; i < limit; i++) {
                if (num % i == 0) {
                    sum = sum + i + (num / i);
                }
            }
            return sum;
        }
    }
}
