public class Book : Item{
    // Constructor
    public Book(string title, int daysAllowed, int daysPassed) : base(title, daysAllowed, daysPassed){
        
    }
    public Book() : base(){}


    // Properties
    private static string type = "Book";
    protected override double penalty => .50;
    protected override double cap => 60;


    // Methods
    public override void LatePenalty()
    {
        if (overdue > 0){
            Console.WriteLine($"Your {type} \"{title}\" is {overdue} days overdue.\nYour fine total for this {type.ToLower()} is now ${Math.Min(Math.Round(overdue * 0.5, 2), 60).ToString("F2")}");
        }
        else{
            Console.WriteLine($"You have {overdue*-1} days left before your {type.ToLower()} \"{title}\" becomes past due.");
        }
        Console.WriteLine();
    }
}
