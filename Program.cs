using System;

namespace c61_guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the secret number: ");

            string answer = Console.ReadLine();
                    

            /*Create a variable to contain the secret number. 
            This number should be hard-coded for now. 42 is a nice number.*/
            int secretNumber = 42;

            //No longer display the user's guess. They know what they guessed, right?

            /*Compare the user's guess with the secret number. Display
            a success message if the guess is correct, otherwise display a failure message.*/
            if(int.Parse(answer) == secretNumber)
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
