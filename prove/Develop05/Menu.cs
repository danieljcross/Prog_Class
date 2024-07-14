using System.Diagnostics.CodeAnalysis;

public class Menu{
    // Constructor
    public Menu(string menu){
        this.menu = menu;
    }

    // Attributes
    // private string menu = "Menu Options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit"; 
    private string menu;

    // Methods
    public void PrintMenu(){
        foreach (string item in menuOptions){
            Console.WriteLine(item);
        }
    }

    public (int, string) PrintGoalTypes(){
        Console.Write("The types of goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\nWhich type of goal would you like ot create? ");
        int goalType = int.Parse(Console.ReadLine());
        Console.Write("What is the name of your goal? ");
        string goal = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        return (goalType, goal);
    }
}