using System;

namespace coin_sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] amounts = {1, 2, 5, 10, 20, 50, 100, 200};
            int goal = 200;
            int[] ways = new int[goal+1];

            ways[0] = 1;
            
            for (int i = 0; i < amounts.Length; i++) {
                for (int j = amounts[i]; j <= goal; j++) {
                    ways[j] += ways[j - amounts[i]];
                }
            }
        }
    }
}