using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snowWhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };

            for ( int i = 0; i < sevenDwarves.Length ; i++)
            {

                Console.WriteLine("Here's your dinner " + sevenDwarves[i]);
            }

            foreach (string j in sevenDwarves)
            {
                Console.WriteLine("Your drink is ready " + j);
            }

            for (int k = 0; k < sevenDwarves.Length; k++)
            {
                Console.WriteLine("What do you want for dinner " + sevenDwarves[k]);
                string meal = Console.ReadLine();
                Console.WriteLine(sevenDwarves[k] + "Your" + meal + "is ready!");
            }

        }
    }
}
