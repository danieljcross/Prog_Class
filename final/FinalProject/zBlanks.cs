using System;
using System.Collections.Generic;

public class Blanks{
    // Attributes
    private string one;
    private string two;
    private string three;
    private string four;
    private string five;
    private string six;
    private List<string> blanks;


    // Constructors
    public Blanks(string one = "_ _ _ _ _ ", string two = "_ _ _ _ _ ", string three = "_ _ _ _ _ ", string four = "_ _ _ _ _ ", string five = "_ _ _ _ _ ", string six = "_ _ _ _ _ ")
    {
        this.one = one;
        this.two = two;
        this.three = three;
        this.four = four;
        this.five = five;
        this.six = six;
        blanks = new List<string> { this.one, this.two, this.three, this.four, this.five, this.six };
    }


    // Methods
    public void DisplayBlanks()
    {
        foreach (string blank in blanks)
        {
            Console.WriteLine(blank);
        }
    }
}
