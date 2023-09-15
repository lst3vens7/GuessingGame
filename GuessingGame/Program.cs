using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1,100);
            int lives = 6;
            int guess = 0;

            bool outOfLives = false;

            while (outOfLives == false)
            {
                Console.Write("Lives Remaining: {0}. Please guess a number between 1-99: ", lives);

                try
                {
                    string input = Console.ReadLine();
                    guess = Int32.Parse(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                

                if (guess < 1 | guess > 99)
                {
                    Console.WriteLine("Invalid guess");
                } else if (guess > number)
                {
                    Console.WriteLine("Lower");
                } else if (guess < number)
                {
                    Console.WriteLine("Higher");
                } else 
                {
                    Console.WriteLine("You have guessed the number!!");
                    break;
                }

                lives = lives - 1;

                if (lives == 0)
                {
                    Console.WriteLine("You are out of lives!! Better luck next time!!");
                    outOfLives = true;
                }
            }
            
            Console.ReadLine();

        }
    }
}
