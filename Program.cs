using System;
using System.Collections.Generic;

namespace c61_guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int secretNumber = new Random().Next(1, 101);

            //Add a difficulty level of "Cheater" 
            //which will cause the program to continue prompting the user until they get the answer correct.

            Console.WriteLine("choose a difficulty level: 1 - easy,2- medium,3- hard, 4- cheater");
            int difficulty = int.Parse(Console.ReadLine());

            
            List<int> difficulties = new List<int>() {8, 6, 4, 2};
            int numberOfGuesses = difficulties[difficulty-1];

            int numberGuessesLeft = numberOfGuesses;
            while (difficulty == 4 || numberGuessesLeft >= 1)
            {
                Console.WriteLine($"Guess the secret number (Guess {(difficulty == 4 ? "infinite!!!": numberGuessesLeft)}): ");
                int answer = int.Parse(Console.ReadLine());

                if (answer == secretNumber)
                {
                    Console.WriteLine("You guessed the secret number!");
                    break;
                }
                else
                {
                    Console.WriteLine(answer<secretNumber? "too low":"too high");
                }
                numberGuessesLeft--;
            }
           
        }
    }
}
