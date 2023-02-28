using System;

namespace c61_guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            



            int secretNumber = 42;
            //Give the user four chances to guess the number.
            for (int i = 1; i <= 4; i++)
            {
                //Display the number of the user's current guess in the prompt. 
                //For example, if the user has already guessed one time, the prommpt 
                //should say something like Your guess (2)>.
                Console.WriteLine($"Guess the secret number (Guess {i}): ");
                int answer = int.Parse(Console.ReadLine());

                //Continue to display the success or failure messages as in phase 2
                if (answer == secretNumber)
                {
                    Console.WriteLine("You guessed the secret number!");
                    // End the loop early if the user guesses the correct number.
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
