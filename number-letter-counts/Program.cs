using System;
using System.Collections.Generic;
using System.Collections;

namespace number_letter_counts
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> strToNumDic = new Dictionary<string, int>();
            strToNumDic = addElemStr(strToNumDic);

            int sum = 0;
            for (int i = 1; i <= 1000; i++) {
                string sentence = numberToWords(i);
                int value = 0;

                string[] words = sentence.Split(' ');

                foreach (string w in words) {
                    strToNumDic.TryGetValue(w, out value);
                    sum += value;
                }
            }
            Console.WriteLine($"total: {sum}");
        }

        static Dictionary<string, int> addElemStr(Dictionary<string, int> dictionary) {
            dictionary.Add("one", 3);
            dictionary.Add("two", 3);
            dictionary.Add("three", 5);
            dictionary.Add("four", 4);
            dictionary.Add("five", 4);
            dictionary.Add("six", 3);
            dictionary.Add("seven", 5);
            dictionary.Add("eight", 5);
            dictionary.Add("nine", 4);

            dictionary.Add("eleven", 6);
            dictionary.Add("twelve", 6);
            dictionary.Add("thirteen", 8);
            dictionary.Add("fourteen", 8);
            dictionary.Add("fifteen", 7);
            dictionary.Add("sixteen", 7);
            dictionary.Add("seventeen", 9);
            dictionary.Add("eighteen", 8);
            dictionary.Add("nineteen", 8);

            dictionary.Add("ten", 3);
            dictionary.Add("twenty", 6);
            dictionary.Add("thirty", 6);
            dictionary.Add("forty", 5);
            dictionary.Add("fifty", 5);
            dictionary.Add("sixty", 5);
            dictionary.Add("seventy", 7);
            dictionary.Add("eighty", 6);
            dictionary.Add("ninety", 6);

            dictionary.Add("hundred", 7);
            dictionary.Add("thousand", 8);

            dictionary.Add("and", 3);

            return dictionary;
        }

        static string numberToWords(int number) {
            if (number == 0) {
                return "zero";
            }

            string words = "";

            if ((number / 1000) > 0) {
                words += numberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }
 
            if ((number / 100) > 0) {
                words += numberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0) {
                if (words != "") {
                    words += "and ";
                }

                string[] units = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
                string[] tens = {"zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};

                if (number < 20) {
                    words += units.GetValue(number);
                } else {
                    words += tens.GetValue(number / 10);
                    if ((number % 10) > 0) {
                        words += " " + units.GetValue(number % 10);
                    }
                }
            }

            return words;
        }
    }
}
