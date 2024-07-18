public class Dvd: Item{
    // Constructor
    public Dvd(string title, int daysAllowed, int daysPassed) : base(title, daysAllowed, daysPassed){
    }


    // Properties
    private string type = "DVD";
    protected override double penalty => 1;
    protected override double cap => 30;


    // Methods
    public override void LatePenalty(){
        if (overdue > 0){
            Console.WriteLine($"Your {type} \"{title}\" is {overdue} days overdue.\nYour fine total for this {type} is now ${Math.Min(overdue,30)}.00");
        }
        else{
            Console.WriteLine($"You have {overdue} days left before it becomes past due.");
        }
        Console.WriteLine();
    }
}