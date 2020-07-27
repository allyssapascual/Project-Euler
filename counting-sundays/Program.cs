using System;

namespace counting_sundays
{
    class Program
    {
        static void Main(string[] args)
        {
            int sunday = 0;

            for (int year = 1901; year <= 2000; year++) {
                for (int month = 1; month <= 12; month++) {
                    if ((new DateTime(year, month, 1)).DayOfWeek == DayOfWeek.Sunday) {
                        sunday++;
                    }
                }
            }
            Console.WriteLine(sunday);
        }
    }
}
