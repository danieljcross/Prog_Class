using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture(1, "John", 3, "16", "17", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in Him shall not perish, but have everlasting life. For God sent not his Son into the world to condemn the world; but that the world through Him might be saved.");
        Scripture scripture2 = new Scripture(2, "Alma", 41, "10", "Do not suppose, because it has been spoken concerning restoration, that ye shall be restored from sin to happiness. Behold, I say unto you, wickedness never was happiness.");

        List<Scripture> scriptures = [scripture1, scripture2];

        string scripture = "";
        while (scripture != "quit"){

            Console.WriteLine("Please choose a scripture to memorize!");

            foreach (Scripture refer in scriptures){
                    refer.DisplayScripture();
            }
            
            Console.Write("-->");
            scripture = Console.ReadLine();

            if (scripture == "quit"){
                Console.WriteLine("\n\nBye.");
                break;
            }
            else if (scripture == "1"){
                scripture1.Study();
            }
            else if (scripture == "2"){
                scripture2.Study();
            }

        }
    }
}