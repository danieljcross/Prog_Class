public class Magazine : Item
{
    // Constructor
    public Magazine(string title, int daysAllowed, int daysPassed) : base(title, daysAllowed, daysPassed){
        
    }


    // Properties
    private static string type = "Magazine";
    protected override double penalty => 3;
    protected override double cap => 3;



    // Methods
    public override void LatePenalty()
    {
        if (overdue > 0){
            Console.WriteLine($"Your {type} \"{title}\" is {overdue} days overdue.\nYour fine total for this {type} is now ${penalty.ToString("2F")}");
        }
        else{
            Console.WriteLine($"You have {overdue} days left before it becomes past due.");
        }
        Console.WriteLine();
    }
}
