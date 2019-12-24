using System;

namespace ConsoleApp1
{
    class Program
    {
       

        static void Main(string[] args)
        {
            bool game = true;
            while (game)

            {
                Console.WriteLine("\nWelcome to Chris's number game, user gets 3 tries to correctly guess a number from 1-10, What's your guess\n");
                string input = Console.ReadLine();
                int inputNum = Convert.ToInt32(input);
                if (inputNum == 0)
                {
                    Console.Clear();
                    Console.WriteLine("\n you dont know how to play a guessing game? \n");  
                }               
                else if (inputNum == -1)
                {
                    Environment.Exit(0);
                }
                else if (inputNum == 7)
                {
                    Console.Clear();
                    Console.WriteLine("\nAye, congrats you won! enter -1 to exit\n");
                }

                else if (inputNum >= 8 && inputNum <= 10)
                {
                    Console.Clear();
                    Console.WriteLine("\nthat aint it cheif, lower\n");
                }
                else if (inputNum <= 6)
                {
                    Console.Clear();
                    Console.WriteLine("\nthat aint it cheif,higher\n");
                }
                else
                {
                    Console.Clear();    
                    Console.Write("\nDamn son, where'd ya find this?\n");


                }
            }
            
             

        }
    }
}
