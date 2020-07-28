using System;
using System.IO;

namespace names_scores
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = readFile();
            Array.Sort(names);
            int sum = 0;

            for (int i = 0; i < names.Length; i++) {
                sum += (i + 1) * getScore(names[i]);
            }

            Console.WriteLine(sum);
        }
        static string[] readFile() {
            StreamReader rdr = new StreamReader("names.txt");
            string str = rdr.ReadToEnd();
            rdr.Close();

            string[] names = str.Split(',');

            for (int i = 0; i < names.Length; i++) {
                names[i] = names[i].Trim('"');
            }

            return names;
        }

        static int getScore(string name) {
            int sum = 0;

            for (int i = 0; i < name.Length; i++) {
                sum += Convert.ToInt32(name[i]) - 64;
            } 

            return sum;
        }
    }
}
