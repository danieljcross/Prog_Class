public class Edit{
    // Constructors
    public Edit(){

    }


    // Methods
    public void ViewItems(List<Item> itemList){
        Console.Clear();
        if (itemList.Count() == 0){
            Console.WriteLine("You have nothing checked out.\n");
        }
        foreach (Item item in itemList){
            item.LatePenalty();
        }
            Console.WriteLine("Press Enter to continue.\n");
            Console.ReadLine();
    }

    public Item NewItem(){
        int type = 1;
        string title;
        int daysAllowed;
        int daysPassed;

        while (true){

            // Collect data
            Console.Clear();
            Console.WriteLine("What type of item did you check out?\n\n1. Book\n2. DVD\n3. Magazine\n");
            type = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("What is its title?\n");
            title = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("How many days were you allowed to check it out for?\n");
            daysAllowed = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("How many days has it been?\n");
            daysPassed = int.Parse(Console.ReadLine());

            // Create correct instance type
            if (type == 1){
                Book book = new(title, daysAllowed, daysPassed);
                return book;
            }
            else if (type == 2){
                Dvd dvd = new(title, daysAllowed, daysPassed);
                return dvd;
            }
            else if (type == 3){
                Magazine magazine = new(title, daysAllowed, daysPassed);
                return magazine;
            }
        }
    }
}