public class Magazine : Item{
    // Constructor
    public Magazine(string title, int daysAllowed, int daysPassed) : base(title, daysAllowed, daysPassed){
        
    }
    public Magazine() : base(){}


    // Properties
    private static string type = "Magazine";
    protected override double penalty => 3;
    protected override double cap => 3;


    // Methods
    public override void LatePenalty()
    {
        if (overdue > 0){
            Console.WriteLine($"Your {type} \"{title}\" is {overdue} days overdue.\nYour fine total for this {type.ToLower()} is now ${penalty.ToString("F2")}");
        }
        else{
            Console.WriteLine($"You have {overdue*-1} days left before your {type} \"{title.ToLower()}\" becomes past due.");
        }
        Console.WriteLine();
    }
}
