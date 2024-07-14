using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EternalQuest
{
    class Program
    {
        static List<Goal> goals = new List<Goal>();
        static int totalScore = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Eternal Quest");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. Record Event");
                Console.WriteLine("3. Display Goals");
                Console.WriteLine("4. Display Score");
                Console.WriteLine("5. Save Goals");
                Console.WriteLine("6. Load Goals");
                Console.WriteLine("7. Exit");

                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateNewGoal();
                        break;
                    case 2:
                        RecordEvent();
                        break;
                    case 3:
                        DisplayGoals();
                        break;
                    case 4:
                        DisplayScore();
                        break;
                    case 5:
                        SaveGoals();
                        break;
                    case 6:
                        LoadGoals();
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        static void CreateNewGoal()
        {
            Console.WriteLine("Select Goal Type:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            int type = int.Parse(Console.ReadLine());

            Console.Write("Enter the goal name: ");
            string name = Console.ReadLine();

            switch (type)
            {
                case 1:
                    Console.Write("Enter the points for completion: ");
                    int simplePoints = int.Parse(Console.ReadLine());
                    goals.Add(new SimpleGoal(name, simplePoints));
                    break;
                case 2:
                    Console.Write("Enter the points per event: ");
                    int eternalPoints = int.Parse(Console.ReadLine());
                    goals.Add(new EternalGoal(name, eternalPoints));
                    break;
                case 3:
                    Console.Write("Enter the points per event: ");
                    int checklistPoints = int.Parse(Console.ReadLine());
                    Console.Write("Enter the number of events required: ");
                    int targetCount = int.Parse(Console.ReadLine());
                    Console.Write("Enter the bonus points for completion: ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    goals.Add(new ChecklistGoal(name, checklistPoints, targetCount, bonusPoints));
                    break;
                default:
                    Console.WriteLine("Invalid goal type.");
                    break;
            }
        }

        static void RecordEvent()
        {
            Console.WriteLine("Select Goal to Record Event:");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].Name} - {goals[i].GetProgress()}");
            }

            int choice = int.Parse(Console.ReadLine());
            if (choice > 0 && choice <= goals.Count)
            {
                goals[choice - 1].RecordEvent();
                totalScore += goals[choice - 1].Points;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        static void DisplayGoals()
        {
            Console.WriteLine("Goals:");
            foreach (var goal in goals)
            {
                Console.WriteLine($"{goal.Name} - {goal.GetProgress()} - {goal.Points} Points");
            }
        }

        static void DisplayScore()
        {
            Console.WriteLine($"Total Score: {totalScore}");
        }

        static void SaveGoals()
        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                writer.WriteLine(totalScore);
                foreach (var goal in goals)
                {
                    string goalType = goal.GetType().Name;
                    string progress = goal.GetProgress();
                    writer.WriteLine($"{goalType},{goal.Name},{goal.Points},{progress}");
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }

        static void LoadGoals()
        {
            if (File.Exists("goals.txt"))
            {
                goals.Clear();
                using (StreamReader reader = new StreamReader("goals.txt"))
                {
                    totalScore = int.Parse(reader.ReadLine());
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        string goalType = parts[0];
                        string name = parts[1];
                        int points = int.Parse(parts[2]);
                        string progress = parts[3];

                        Goal goal;
                        switch (goalType)
                        {
                            case "SimpleGoal":
                                goal = new SimpleGoal(name, points);
                                break;
                            case "EternalGoal":
                                goal = new EternalGoal(name, points);
                                break;
                            case "ChecklistGoal":
                                goal = new ChecklistGoal(name, points, int.Parse(parts[4]), int.Parse(parts[5]));
                                break;
                            default:
                                continue;
                        }

                        goal.Points = points;
                        goal.IsCompleted = progress.Contains("[X]");
                        goals.Add(goal);
                    }
                }
                Console.WriteLine("Goals loaded successfully.");
            }
            else
            {
                Console.WriteLine("No saved goals found.");
            }
        }
    }
}
