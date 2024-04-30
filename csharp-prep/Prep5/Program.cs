using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        void DisplayWelcome(){
            Console.WriteLine("Welcome to the Program!");
        }
        string PromptUserName(){
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        int PromptUserNumber(){
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        int SquareNumber(int num){
            int numSquared = num * num;
            return numSquared;
        }
        void DisplayResult(string name, int numSquared){
            Console.WriteLine($"{name}, the square of your number is {numSquared}");
        }
        void Main(){
            DisplayWelcome();
            string name = PromptUserName();
            int num = PromptUserNumber();
            DisplayResult(name, SquareNumber(num));
        }
        Main();
    }
}