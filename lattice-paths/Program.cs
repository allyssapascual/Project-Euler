using System;

namespace lattice_paths
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 20;
            long path = 1;

            for (int i = 0; i < size; i++) {
                path *= (2 * size) - i;
                path /= i + 1;
            }

            Console.WriteLine(path);
        }
    }
}
