public class Menu{
    public Menu(){}
    private string menu = "Menu Options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit";

    public void PrintMenu(){
        Console.WriteLine(menu);
    }
}