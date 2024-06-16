class Setup{
    // Properties
    bool run = true;
    int choice;
    string choiceString;

    // Methods
    public void DisplayMenu(){
        Console.Clear();
        while (run == true){
            Console.WriteLine("Menu Options:\n1. Start breathing activity\n2. Start reflection activity\n3. Start listening activity\n4. Quit\nSelect a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1){
                choiceString = "Breathing";
                Breathing breathing = new();
                breathing.DisplayProgramIntro(choiceString);
            }
            else if (choice == 2){
                choiceString = "Reflection";
                Reflecting reflecting = new();
                reflecting.DisplayProgramIntro(choiceString);
            }
            else if (choice == 3){
                choiceString = "Listening";
                Listening listening = new();
                listening.DisplayProgramIntro(choiceString);
            }
            else if (choice == 4){
                run = false;
            }
            else{
                run = false;
            }
        }
    }

    // Constructor
    public Setup(){
        
    }
}