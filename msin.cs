using System;

class GuessNumberGame
{
    static void Main()
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 101);
        int userGuess = 0;
        int attempts = 0;

        Console.WriteLine("Welcome to the Guess Number Game!");
        Console.WriteLine("Try to guess the number between 1 and 100.");

        while (userGuess != numberToGuess)
        {
            Console.Write("Enter your guess: ");
            userGuess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (userGuess < numberToGuess)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (userGuess > numberToGuess)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You've guessed the number in {attempts} attempts.");
            }
        }
    }
}
