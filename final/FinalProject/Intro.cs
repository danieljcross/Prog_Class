public class Intro{
    // Constructor
    public Intro(){
        
    }


    // Attributes
    Book book = new();
    Dvd dvd = new();
    Magazine magazine = new();


    // Methods
    public void DisplayIntro(){
        Console.WriteLine("This program allows you to keep track of items borrowed from a library, and calculates your late penalties for each item.\n");
        Console.WriteLine($"Late Penalties:\nBook: ${book.GetPenalty().ToString("F2")} per day late, stops at ${book.GetCap().ToString("F2")}\nDVD: ${dvd.GetPenalty().ToString("F2")} per day late, stops at ${dvd.GetCap().ToString("F2")}\nMagazine: ${magazine.GetPenalty().ToString("F2")} if late\n\nPress Enter to begin\n");
        Console.ReadLine();
    }
}