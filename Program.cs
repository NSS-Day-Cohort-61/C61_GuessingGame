using System;

namespace c61_guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            



            int secretNumber = 42;
            //Give the user four chances to guess the number.
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Guess the secret number: ");
                int answer = int.Parse(Console.ReadLine());

                //Continue to display the success or failure messages as in phase 2
                if (answer == secretNumber)
                {
                    Console.WriteLine("You guessed the secret number!");
                }
                else
                {
                    Console.WriteLine("You did not guess the secret number.");
                }
            }



            

            
        }
    }
}
