using System;
using System.ComponentModel.DataAnnotations;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();
        List<string> menu = ["Write", "Display", "Load", "Save", "Quit"];
        int choice = 0;
        while (choice != 5)
        {

            for (int i = 0; i < menu.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i]}");
            }

            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                journal.NewEntry();
            }
            else if (choice == 2)
            {
                journal.DisplayJournal();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Load");
            }
            else if (choice == 4)
            {
                journal.SaveJournalEntries();
            }
            else
            {
                Console.WriteLine("Quit");
            }
        }
    }
}