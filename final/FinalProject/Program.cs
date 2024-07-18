using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();

        // Create instances of each class
        Dvd dvd = new("Knives Out", 14, 21);
        Book book = new("Gone with the Wind", 31, 33);
        Magazine magazine = new("The New Yorker", 7, 7); // NOT LATE, NO PENALTY
        Dvd dvd1 = new("Newsies", 14, 55);
        Book book1 = new("Grapes of Wrath", 31, 140);
        Magazine magazine1 = new("People", 7, 100);

        // Describe penalties
        Console.WriteLine($"Late Penalties:\nBook: ${book.GetPenalty().ToString("F2")} per day late, stops at ${book.GetCap().ToString("F2")}\nDVD: ${dvd.GetPenalty().ToString("F2")} per day late, stops at ${dvd.GetCap().ToString("F2")}\nMagazine: ${magazine.GetPenalty().ToString("F2")} if late\n\n");

        // Display each late penalty, prove they work
        dvd.LatePenalty();
        book.LatePenalty();
        magazine.LatePenalty();
        dvd1.LatePenalty();
        book1.LatePenalty();
        magazine1.LatePenalty();

    }
}