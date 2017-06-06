using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[5,5];
            int[] rowTotal = new int[5];
            int[] rowColumn = new int[5];
            Random rand = new Random();


            for ( int i = 0; i<5; i++)
            {
                for (int j=0; j<5; j++)
                {
                    numbers[i, j] = rand.Next(1, 10);
                    Console.Write(numbers[i, j] + " ");


                }
                Console.WriteLine();
            }

         //   for



        }
    }
}
