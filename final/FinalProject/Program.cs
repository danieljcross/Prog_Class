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
        menu.RunMenu();

    }
}