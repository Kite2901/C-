using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[5];
            double total = 0;
            int count = 0;
            double average = 0;
        
            Console.WriteLine("Please enter 5 numbers");
         
            numbers[0] = Convert.ToDouble(Console.ReadLine());
            numbers[1] = Convert.ToDouble(Console.ReadLine());
            numbers[2] = Convert.ToDouble(Console.ReadLine());
            numbers[3] = Convert.ToDouble(Console.ReadLine());
            numbers[4] = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i<numbers.Length; i++)
            {
                total += numbers[i];
                count = numbers.Length;
                average = total / count;

            }
            Console.WriteLine("The average is "+ average);




        }
    }
}
