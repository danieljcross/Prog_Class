using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare variables
        int points  = 0;
        int choice = 0;

        // Menu
        while (choice != 6){
            Console.Clear();
            Console.WriteLine($"You have {points} points.");
            Menu menu = new();
            menu.PrintMenu();
            bool validInput = false;
            
            // Call the right class
            while (!validInput){
                try{
                    Console.Write("Select a choice from the menu: ");
                    choice = int.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch (FormatException){
                    Console.Clear();
                    menu.PrintMenu();
                }
            }
            if (choice == 1){
                NewGoal goal = new();
                goal.CreateNewGoal();
            }
            else if (choice == 2){
                List list = new();
                list.ListGoals();
            }
            else if (choice == 3){
                Save save = new();
                save.SaveGoal();
            }
            else if (choice == 4){
                Load load = new();
                load.LoadGoals();
            }
            else if (choice == 5){
                Record record = new();
                record.RecordEvent();
            }
            else {
                choice = 6;
            }
        }
    }
}