using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rnd = new Random();
            //int Value = rnd.Next(1, 10);
            //string guessed;
            //int guess;

            //do 
            //    {
            //        Console.WriteLine("Please guess a number between 1 and 10");
            //        guessed = Console.ReadLine();
            //        guess = int.Parse(guessed);
            //    if (guess < Value)
            //    {
            //        Console.WriteLine("Number you entered is less than the value");


            //    }
            //    else if (guess > Value)
            //    {
            //        Console.WriteLine("Number you entered is greater than the value");

            //    }
            //    else
            //    {

            //        Console.WriteLine("You guessed the right number!");
            //    }

            //}

            //while (guess != Value) ;

            string primeMinister;

            Console.WriteLine("Jeremy Corbyn and Theresa May are standing for the upcoming elections. Who do you think will win?");
            primeMinister = Console.ReadLine();

            switch (primeMinister.ToLower())
            {
                case "jeremy corbyn":
                
                    Console.WriteLine("He shouldn't win ");
                    break;

                case "theresa may":
                     Console.WriteLine("She's not ideal but we don't have a better alternative");
                    break;

                default:
                    Console.WriteLine("Please choose from the options above");
                    break;






            }
            {



            }



        }
        }

    }  
    

