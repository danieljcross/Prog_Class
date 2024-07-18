public class Book : Item
{
    // Constructor
    public Book(string title, int daysAllowed, int daysPassed) : base(title, daysAllowed, daysPassed){
        
    }


    // Properties
    private static string type = "Book";
    protected override double penalty => .50;
    protected override double cap => 60;

    // Methods
    public override void LatePenalty()
    {
        if (overdue > 0){
            Console.WriteLine($"Your {type} \"{title}\" is {overdue} days overdue.\nYour fine total for this {type} is now ${Math.Min(Math.Round(overdue * 0.5, 2), 60).ToString("F2")}");
        }
        else{
            Console.WriteLine($"You have {overdue} days left before it becomes past due.");
        }
        Console.WriteLine();
    }
}
