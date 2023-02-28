using System;

namespace c61_guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display a message to the user asking them to guess the secret number.
            Console.WriteLine("Guess the secret number: ");

            //Display a prompt for the user's guess.
            //Take the user's guess as input and save it as a variable.
            string answer = Console.ReadLine();
                       

            //Display the user's guess back to the screen.
            Console.WriteLine("You guessed: " + answer);
        }
    }
}
