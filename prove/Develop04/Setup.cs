class Setup{
    // Properties
    private bool run = true;
    private int choice;
    private string choiceString;

    // Methods
    public void DisplayMenu(){
        Console.Clear();
        while (run == true){
            Console.Clear();
            Console.WriteLine("Menu Options:\n1. Start breathing activity\n2. Start reflection activity\n3. Start listening activity\n4. Quit\nSelect a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1){
                choiceString = "Breathing";
                Breathing breathing = new();
                breathing.DisplayProgramIntro(choiceString);
                breathing.doBreathing();
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
                Console.Clear();
                Console.WriteLine("Please select a number 1-4.");
                Thread.Sleep(3000);
            }
        }
    }

    // Constructor
    public Setup(){
        
    }
}