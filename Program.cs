using System;
using System.Collections.Generic;

namespace c61_guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int secretNumber = new Random().Next(1, 101);

            // Prompt the user for a difficulty level before they are prompted to guess the number.
            Console.WriteLine("choose a difficulty level: 1 - easy,2- medium,3- hard");
            int difficulty = int.Parse(Console.ReadLine());

            // The difficulty level should determine how many guesses the user gets. The difficulty levels should be:
            List<int> difficulties = new List<int>() {8, 6, 4};
            int numberOfGuesses = difficulties[difficulty-1];

            for (int i = numberOfGuesses; i >= 1; i--)
            {
                Console.WriteLine($"Guess the secret number (Guess {i}): ");
                int answer = int.Parse(Console.ReadLine());

                if (answer == secretNumber)
                {
                    Console.WriteLine("You guessed the secret number!");
                    break;
                }
                else
                {
                    //Inform the user if their guess was too high or too low, when they guess incorrectly.
                    Console.WriteLine(answer<secretNumber? "too low":"too high");
                }
            }
           
        }
    }
}
