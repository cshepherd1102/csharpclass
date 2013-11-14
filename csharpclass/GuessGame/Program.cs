using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //make this generator
            Random generator = new Random();

            //make this number
            int number = generator.Next(0, 1000);

            Console.WriteLine("I'm thinking of a number from 1-1000");

            //loop uptil our guess does not equal number
            for (int guess = Convert.ToInt32(Console.ReadLine());
                 guess != number;
                 guess = Convert.ToInt32(Console.ReadLine()))
            {
                if (guess < number)
                {
                    Console.WriteLine("Too low! Guess a higher number!");
                }
                if (guess > number)
                {
                    Console.WriteLine("Too high! Guess a lower number!");
                }
            }

            //the guess is correct
            Console.WriteLine("You are amazing! You guessed the correct number!");
            Console.ReadKey();
        }
    }
}
