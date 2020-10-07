using System;
using System.Collections;

namespace non_abundant_sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int limit = 28123;
            ArrayList abundant = new ArrayList();

            for (int i = 2; i <= limit; i++) {
                int x = sumProperDivisor(i);
                if (i < x) {
                    abundant.Add(i);
                }
            }
            
            // bool[] writtenAsAbundant = new bool[limit + 1];
            // for (int x = 0; x < limit / 2; x++) {
            //     for (int y = x; y < abundant.Count; y++) {
            //         if ((int)abundant[x] + (int)abundant[y] <= limit) {
            //             writtenAsAbundant[(int)abundant[x] + (int)abundant[y]] = true;
            //         } else {
            //             break;
            //         }
            //     }  
            // }   

            // for (int i = 1; i <= limit; i++) {
            //     if (writtenAsAbundant[i] == false) {
            //         sum += i;  
            //         Console.WriteLine(sum);
            //     }
            // }
            // Console.WriteLine(sum);
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
