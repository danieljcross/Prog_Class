using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your percent grade?");
        int percent = int.Parse(Console.ReadLine());
        string letterGrade;
        if (percent > 90){
            letterGrade = "A";
        }
        else if (percent > 80){
            letterGrade = "B";
        }
        else if (percent > 70){
            letterGrade = "C";
        }
        else if (percent > 60){
            letterGrade = "D";
        }
        else{
            letterGrade = "F";
        }

        Console.WriteLine($"You got a{(letterGrade == "A" || letterGrade == "F" ? "n" : "")} {letterGrade} in the class.");
        if (percent >= 70){
            Console.WriteLine("You passed!");
        }
        else{
            Console.WriteLine("This is not a passing grade. Please take the course again for credit.");
        }
    }
}
