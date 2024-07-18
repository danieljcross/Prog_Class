using System;

class Program
{
    static void Main(string[] args)
    {

        // Introduce Program, begin Menu
        Console.Clear();
        Intro intro = new();
        intro.DisplayIntro();
        Menu menu = new();
        menu.BeginMenu();

        // // Create instances of each class
        // Dvd dvd = new("Knives Out", 14, 21);
        // Book book = new("Gone with the Wind", 31, 33);
        // Magazine magazine = new("The New Yorker", 7, 7); // NOT LATE, NO PENALTY
        // Dvd dvd1 = new("Newsies", 14, 55);
        // Book book1 = new("Grapes of Wrath", 31, 140);
        // Magazine magazine1 = new("People", 7, 100);

        // // Display each late penalty, prove they work
        // dvd.LatePenalty();
        // book.LatePenalty();
        // magazine.LatePenalty();
        // dvd1.LatePenalty();
        // book1.LatePenalty();
        // magazine1.LatePenalty();

    }
}