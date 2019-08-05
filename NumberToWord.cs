using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool isValid;
            int number;
            //check the valid number entry
            do
            {
                Console.Write("Enter integer : if you want to exit press 0\n");
                input = Console.ReadLine();
                isValid = int.TryParse(input, out number);
                if (!isValid)
                    Console.WriteLine("\n  Not an integer, please try again\n");
                else
                    Console.WriteLine("\n  {0}\n", NumberToWords(number));
            }
            while (!(isValid && number == 0));
            Console.WriteLine("\nend of pavan program");

        }
     //Main algortihm to convert number to words
        public static string NumberToWords(int num)
        {
          
            if (num < 0 )
            {
                return "enter greater than 0";
            }
            if (num == 0)
                return "zero";

            string cnvWords = "";

            if ((num / 1000000) > 0)
            {
                cnvWords += NumberToWords(num / 1000000) + " million ";
                num %= 1000000;
            }

            if ((num / 1000) > 0)
            {
                cnvWords += NumberToWords(num / 1000) + " thousand ";
                num %= 1000;
            }

            if ((num / 100) > 0)
            {
                cnvWords += NumberToWords(num / 100) + " hundred ";
                num %= 100;
            }

            if (num > 0)
            {
                if (cnvWords != "")
                    cnvWords += "and ";

                var onsAr = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tnsAr = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (num < 20)
                    cnvWords += onsAr[num];
                else
                {
                    cnvWords += tnsAr[num / 10];
                    if ((num % 10) > 0)
                        cnvWords +=   onsAr[num % 10];
                }
            }

            return cnvWords;
        }
    }
}
