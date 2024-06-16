using System.ComponentModel.DataAnnotations;
using System.Data;

public class Scripture{

    // Constructors
    public Scripture(int num, string book, int chapter, string first, string last, string words){
        this.num = num;
        this.book = book;
        this.chapter = chapter;
        this.first = $"{first}-{last}";
        this.last = last;
        this.words = words;
        string reference = $"{this.book} {chapter}:{first}-{last}";
        verses.Add(reference);
    }
    public Scripture(int num, string book, int chapter, string first, string words){
        this.num = num;
        this.book = book;
        this.chapter = chapter;
        this.first = $"{first}";
        this.words = words;
        string reference = $"{this.book} {chapter}:{first}";
        verses.Add(reference);
    }
    

    // Properties
    public List<string> verses = new List<string>();
    private int num;
    private string book;
    private int chapter;
    private string first;
    private string last;
    private string words;
    // public string reference = $"{book} {chapter}:{first}-{last}";

    // Methods
    public void DisplayScripture(){
        foreach (string verse in verses){
            Console.WriteLine($"{num}. {verse}");
        }
    }

    public void Study()
    {
        Console.WriteLine($"{book} {chapter}:{first}");
        Console.WriteLine(words);
    }
}