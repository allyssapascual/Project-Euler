using System;

namespace digit_fifth_powers
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            for (int i = 2; i <= 355000; i++) 
            {
                double calculated = calculate(i);
                if (calculated != -1) 
                {
                    Console.WriteLine(calculated);
                    sum += calculated;
                }
            }
            Console.WriteLine(sum);
        }

        static double calculate(double n) 
        {
            string nStr = n.ToString();
            double sum = 0;
            foreach (var chr in nStr)
            {
                double chrInt = char.GetNumericValue(chr);
                sum += Math.Pow(chrInt, 5);
            }
            if (sum == n) 
            {
                return sum;
            }
            return -1;
        }
    }
}
