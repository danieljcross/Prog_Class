public abstract class Item{
    // Constructors
    public Item(string title, int daysAllowed, int daysPassed){
        this.title = title;
        this.daysAllowed = daysAllowed;
        this.daysPassed = daysPassed;
    }


    // Attributes
    protected string title { get; private set; }
    protected int daysAllowed { get; private set; }
    protected int daysPassed { get; private set; }
    protected int overdue{ get { return daysPassed - daysAllowed; }
    }
    protected abstract double penalty { get; }
    protected abstract double cap { get;}


    // Methods
    public abstract void LatePenalty();
    
    public double GetPenalty(){
        return penalty;
    }
    public double GetCap(){
        return cap;
    }
}