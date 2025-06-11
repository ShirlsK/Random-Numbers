using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 31); // Random number between 1 and 30
        int userGuess = 0;
        int attempts = 0;

        Console.WriteLine("Welcome to 'Guess the Number'!");
        Console.WriteLine("I have selected a number between 1 and 30. Can you guess what it is?");
        
        // Game loop
        while (userGuess != numberToGuess)
        {
            Console.Write("Enter your guess: ");
            
            string input = Console.ReadLine();
            if (int.TryParse(input, out userGuess))
            {
                attempts++;
                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("TOO LOW! TRY AGAIN");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("TOO HIGH! TRY AGAIN");
                }
                else
                {
                    Console.WriteLine($"Correct! You guessed the number in {attempts} attempts.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        Console.WriteLine("Thank you for playing!");
    }
}
