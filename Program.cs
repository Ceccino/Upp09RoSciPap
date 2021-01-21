using System;
using System.Collections.Generic;
using System.Linq;

namespace Upp09RoSciPap
{
    class Program
    {

        static void Main(string[] args)
        {
            int inputPlayer;
            int randomInt;

            int scorePlayer = 0;
            int scoreCPU = 0;

            bool playAgain = true;
            Console.WriteLine("Welcome to rock, paper, scissors!");

            while (playAgain)
            {

                Console.WriteLine("\nPlease make your choice between;");
                Console.WriteLine("1.Rock 2.paper 3.scissors");

                inputPlayer = Convert.ToInt32(Console.ReadLine());
                Random rnd = new Random();

                randomInt = rnd.Next(1, 4);

                switch (randomInt)
                {
                    case 1:
                        Console.WriteLine("\nThe computer has chosen rock");
                        if (inputPlayer == 1)
                        {
                            Console.WriteLine("It's a tie");
                        }
                        else if (inputPlayer == 2)
                        {
                            Console.WriteLine("The player wins!");
                            scorePlayer++;
                        }
                        else if (inputPlayer == 3)
                        {
                            Console.WriteLine("The computer wins!");
                            scoreCPU++;
                        }
                        break;

                    case 2:
                        Console.WriteLine("\nThe computer has chosen paper");
                        if (inputPlayer == 2)
                        {
                            Console.WriteLine("It's a tie!");
                        }
                        else if (inputPlayer == 1)
                        {
                            Console.WriteLine("The computer wins!");
                            scoreCPU++;
                        }
                        else if (inputPlayer == 3)
                        {
                            Console.WriteLine("The player wins!");
                            scorePlayer++;
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nThe computer has chosen scissors!");
                        if (inputPlayer == 3)
                        {
                            Console.WriteLine("It's a tie!");
                        }
                        else if (inputPlayer == 1)
                        {
                            Console.WriteLine("The player wins!");
                            scorePlayer++;
                        }
                        else if (inputPlayer == 2)
                        {
                            Console.WriteLine("The computer wins!");
                            scoreCPU++;
                        }
                        break;
                        
                    default:
                        Console.WriteLine("Invalid entry!");
                        break;
                }

                Console.WriteLine("\nCurrent score; \nPlayer;" + scorePlayer + "\nComputer;" + scoreCPU);

                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {

                }
            }
        }
    }
}
