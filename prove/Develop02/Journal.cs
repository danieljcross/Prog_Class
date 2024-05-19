using System;
using System.Data;
using System.Net.Quic;
public class Journal
{

    // Attributes
    private List<Entry> entries = new List<Entry>();

    // Methods
    public void NewEntry()
    {
        Entry entry = new Entry();
        Console.WriteLine("Please respond to the following prompt: ");
        Console.WriteLine(entry.prompt);
        string response = Console.ReadLine();
        entry.content = response;
        entries.Add(entry);
    }

    public string GetJournalEntries()
    {
        string entriesString = "";
        foreach (Entry entry in entries)
        {
            entriesString += entry.ToString();
        }
        return entriesString;
    }

    public void DisplayJournal()
    {
        Console.WriteLine(GetJournalEntries());
    }

    public void SaveJournalEntries()
    {
        Console.WriteLine("Please name your document:");
        string docName = Console.ReadLine();
        File.WriteAllText(@$"C:\Users\User\OneDrive\Desktop\Prog_Class\Prog_Class\prove\Develop02\{docName}", GetJournalEntries());
    }

    // Constructor
    public Journal()
    {

    }
}

