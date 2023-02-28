using System;

namespace c61_guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            


            //Use a random number to set the secret number between 1 and 100 instead of a hard-coded number.
            int secretNumber = new Random().Next(1, 101);
            Console.WriteLine(secretNumber.ToString());

            for (int i = 4; i >= 1; i--)
            {
                //The prompt should display the number of guesses the user has left.
                Console.WriteLine($"Guess the secret number (Guess {i}): ");
                int answer = int.Parse(Console.ReadLine());

                if (answer == secretNumber)
                {
                    Console.WriteLine("You guessed the secret number!");
                    break;
                }
                else
                {
                    Console.WriteLine("You did not guess the secret number.");
                }
            }



            

            
        }
    }
}
