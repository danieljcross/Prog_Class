public class Intro{
    // Constructors
    public Intro(){

    }

    // Attributes

    string intro = "Welcome to Wordle!\n\nTry to guess the mystery work in 6 tries!\nAn uppercase letter means it is in the correct spot and a lowercase letter means it is in the word, but in the wrong spot.\n\nGood luck!\n\n\n\nPress Enter to begin";

    // Methods
    public void DisplayIntro(){
        Console.WriteLine(intro);
        Console.ReadLine();
        Console.Clear();
    }

}