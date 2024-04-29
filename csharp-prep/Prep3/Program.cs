using System;
using System.Xml.Serialization;


class Program
{
    static void Main(string[] args)
    {
        
        // Welcome and declare variables
        Console.WriteLine("Welcome to Guess my Number!");
        Random random = new Random();
        int magicNumber = random.Next(1, 11);
        int guess = 0;
        int guess_count = 0;
        string again = "y";

        // Begin loop to allow to restart
        while (again == "y" || again == "yes"){

            // Begin loop to make guesses
            while (magicNumber != guess){
                Console.WriteLine("What is your next guess?");
                guess = int.Parse(Console.ReadLine());
                guess_count ++;

                // Find if it's higher or lower
                if (guess > magicNumber){
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber){
                    Console.WriteLine("Higher");
                }
            };

            // Message upon completion
            if (guess_count == 1){
                Console.WriteLine("You got it on your first try! Great job!");
            }
            else{
                Console.WriteLine($"You got it! It took you {guess_count} tries.");
            }

            // Play again option
            Console.WriteLine("Would you like to play again? (y/n)");
            again = Console.ReadLine().ToLower();
            guess = 0;
            guess_count = 0;
            magicNumber = random.Next(0, 11);
        }

        // Exit message
        Console.WriteLine("Thanks for playing!");

    }
}