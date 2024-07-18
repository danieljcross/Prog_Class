using System.ComponentModel.DataAnnotations;

public class Guess{
    // Constructor
    public Guess(){
    }

    // Attributes
    string guess;

    // Methods
    public string GuessWord(){
        guess = Console.ReadLine();
        while (guess.Length != 5){
            guess = Console.ReadLine();
        }
        return guess;
    }

}