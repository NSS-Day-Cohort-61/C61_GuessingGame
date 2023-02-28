using System;

namespace c61_guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int secretNumber = new Random().Next(1, 101);
            Console.WriteLine(secretNumber.ToString());

            for (int i = 4; i >= 1; i--)
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
