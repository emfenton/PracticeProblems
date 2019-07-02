using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentGuess = 0;
            int userGuess = -1;
            Random randm = new Random();
            int compNum = randm.Next(0,10);
            int count = 0;
            while (userGuess != compNum)
            {
                Console.WriteLine("Guess a number between 1 and 10.");
                userGuess = Int32.Parse(Console.ReadLine());

                if (userGuess < compNum)
                {
                    Console.WriteLine("Your guess is too low. Try again.");
                }
                else if (userGuess > compNum)
                {
                    Console.WriteLine("Your guess is too high. Try again.");
                }
                if (currentGuess != userGuess)
                {
                    count++;
                }
                currentGuess = userGuess;
            }
            Console.WriteLine("You guessed it! " + "It took " + count + " guesses.");
        }
    }
}
