using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaryExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> frenchDictionary = new Dictionary<string, string>();
            char response = ' ';
            string French = "";

            frenchDictionary.Add("Bonjour", "Hello");
            frenchDictionary.Add("Lundi", "Monday");
            frenchDictionary.Add("blanc", "White");
            frenchDictionary.Add("dimanche", "sunday");

            do
            {
                Console.WriteLine("Welcome to the Dictionary. To look up a French word, press F. To check if a meaning exists, press M. To use a key to look up value press L. To count the list, press C. To exit, press X");
                response = Convert.ToChar(Console.ReadLine().ToUpper());

                if (response == 'F')
                {
                    Console.WriteLine("Enter the French word you want to look for:");
                    French = Console.ReadLine();
                //    frenchDictionary.ContainsKey("French");

                    if (frenchDictionary.ContainsKey(French))
                    {
                        Console.WriteLine("The value exists");
                    }

                }

            }
            while (response != 'X');
        }
    }
}
