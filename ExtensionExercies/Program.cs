using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionExercies
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2();
            //Exercise3();
        }

        private static void Exercise1()
        {
            Console.WriteLine("Exercise 1");
            Console.WriteLine("Please enter an integer to have reversed.");
            string input = Console.ReadLine();
            int integer = Int32.Parse(input);
            integer = integer.Reverse();
            Console.WriteLine(integer + "\n");
            Console.ReadKey();
        }

        private static void Exercise2()
        {
            Console.WriteLine("Exercise 2");
            Console.WriteLine("Please enter a word to have put in alphabetical order");
            string input = Console.ReadLine();
            string alphabetical = input.Alphabetical();
            Console.WriteLine(alphabetical + "\n");
            Console.ReadKey();
        }

        private static void Exercise3()
        {
            Console.WriteLine("Exercise 3");
            Console.WriteLine("Please enter a word to have put in alphabetical order");
            string input = Console.ReadLine();
            Dictionary<string, List<string>> anagramDictionary;
            anagramDictionary = input.AnagramChecker();
            foreach (KeyValuePair<string, List<string>> kvp in anagramDictionary)
            {
                Console.WriteLine("Key = {0}", kvp.Key);
                foreach (string output in kvp.Value)
                {
                    Console.WriteLine("Anagrams = {1}", kvp.Key, output);
                }
            }
            Console.ReadKey();
        }
    }
}
