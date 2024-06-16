using System.Security.Cryptography.X509Certificates;

public class Mindfulness{
    // Properties
    int time;

    // Methods
    public void DisplayProgramIntro(string choice){
        Console.WriteLine($"Welcome to the {choice} Activity.");
        if (choice == "Breathing"){
            Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        }
        else if (choice == "Reflection"){
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        }
        else if (choice == "Listening"){
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        }
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        time = int.Parse(Console.ReadLine());
    }
    public void LoadSymbol(){
        int TIME = 600;
        List<string> hands = ["-", "\\", "|", "/", "-"];
        for (int x=0;x<2;x++){
            foreach (string hand in hands){
                Console.Write(hand);
                Thread.Sleep(TIME/8);
                Console.Write("\b \b ");
            }
        }
        Console.Write("-");
        Thread.Sleep(TIME/8);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(TIME/8);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(TIME/8);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(TIME/8);
        Console.Write("\b \b");
        Console.Write("-");
    }

    // Constructor
    public Mindfulness(){

    }
}