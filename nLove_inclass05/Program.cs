using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nLove_inclass05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[8] { 1, 3, 5, 7, 9, 78, 60, 10 };

            int total = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];// adds all numbers of the array
            }

            Console.WriteLine(total);
            Console.WriteLine();

            //create 2 additional arrays with the same numbers to modify them with methods
            
            int[] sortNumbers = new int[numbers.Length];
            int[] revNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                // this way - assigning each element of one array to another - the modifications of one array won't influence the other (unlike in: 
                sortNumbers[i] = numbers[i];
                revNumbers[i] = numbers[i];
            }
            // arranges elements in ascending order (unicode for chars and strings)
            Array.Sort(sortNumbers);

            foreach (int number in sortNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            // reverses the elements in array
            Array.Reverse(revNumbers);

            foreach (int number in revNumbers)
            {
                Console.WriteLine(number);
            }

            int checkNumber_good = 10;
            int checkNumber_bad = 12;

            int goodCheck = Array.BinarySearch(sortNumbers, checkNumber_good); // the var goodcheck gets equal to the number we are searching for(checknumber_good) in the array sortnumbers
            int badCheck = Array.BinarySearch(sortNumbers, checkNumber_bad); // not necessary to check in reality, because if there's NO number in the array - the method will ALWAYS return -1 (negative 1)

            if (goodCheck >= 0)
            {
                Console.WriteLine("I found {0} at index {1}.", checkNumber_good, goodCheck);
            }
            else
            {
                Console.WriteLine("I could not find {0}.", checkNumber_good);
            }

            if (badCheck >= 0)
            {
                Console.WriteLine("I found {0} at index {1}.", checkNumber_bad, badCheck);
            
            }
            else
            {
                Console.WriteLine("I could not find {0}.", checkNumber_bad);
            }


            //WriteLine - adds a new line; Write - stays in the same line.
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
