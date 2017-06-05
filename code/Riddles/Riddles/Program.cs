using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riddles
{
    class Program
    {
        static void Main(string[] args)
        {
            string response ="";
            int count = 0;
            int countCorrect = 0;
            Console.WriteLine("Why did the chicken cross the road?");
      
           
            while ((response != "to get to the other side") && (response != "because the light was green") &&(response != "i give up") && count<3)
            {
               response= Console.ReadLine();
                if ((response != "to get to the other side") && (response != "because the light was green"))
                {
                    if (response == "i give up")
                    {
                        Console.WriteLine("The correct answer is To get to the other side");
                    }
                    else
                        Console.WriteLine("Wrong. Try again");
                    count++;

                }

                else
                {
                    Console.WriteLine("Well done!");
                    countCorrect++;
                }

            } //while

            Console.WriteLine("Next riddle is What's yellow and dangerous?");
            count = 0;
            do
            {
                response = Console.ReadLine();

                if ((response != "shark infested custard") && (response != "shark infested lemon"))
                {

                    if (response == "i give up")
                    {
                        Console.WriteLine("The correct answer is shark infested custard");
                    }
                    else
                        Console.WriteLine("Wrong. Try again");
                    
                   count++;
                    

                }
                else
                    Console.WriteLine("Well done!");
                countCorrect++;


            } while ((response != "shark infested custard") && (response != "shark infested lemon") && (response != "i give up") && count < 3);


            Console.WriteLine("You got" + countCorrect + "correct");  //0 not showing

        }  //main


    }
  
}
