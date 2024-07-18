using System.ComponentModel.DataAnnotations;

public class Menu{
    // Constructors
    public Menu(){

    }


    // Attributes
    List<Item> itemList = new List<Item>();


    // Methods
    public void RunMenu(){

        int selection = 0;
        while (selection != 3){
            Console.Clear();
            Console.WriteLine($"What would you like to do?\n\n1. Add item\n2. View items\n3. End program\n");
            selection = int.Parse(Console.ReadLine());
            if (selection == 1){
                Edit edit = new();
                Item newItem = edit.NewItem();
                itemList.Add(newItem);
            }
            else if (selection == 2){
                Edit edit = new();
                edit.ViewItems(itemList);
            }
            else if (selection == 3){
                break;
            }
            else{
                Console.WriteLine("Please enter a 1, 2, or a 3. Press Enter to continue.");
            }

        }
    }
}