using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        string filename = "";

        while (true)
        {
            Console.WriteLine("\nEternal Quest - Menu");
            Console.WriteLine($"Total Points: {manager.TotalScore}");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Choose the type of goal:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Checklist Goal");
                    Console.WriteLine("3. Eternal Goal");
                    Console.Write("Option: ");
                    string goalType = Console.ReadLine();

                    Console.Write("Goal Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Description: ");
                    string desc = Console.ReadLine();
                    Console.Write("Points: ");
                    int points = int.Parse(Console.ReadLine());

                    switch (goalType)
                    {
                        case "1":
                            manager.AddGoal(new SimpleGoal(name, desc, points));
                            break;
                        case "2":
                            Console.Write("Required completions: ");
                            int targetCount = int.Parse(Console.ReadLine());
                            Console.Write("Bonus on completion: ");
                            int bonus = int.Parse(Console.ReadLine());
                            manager.AddGoal(new ChecklistGoal(name, desc, points, targetCount, bonus));
                            break;
                        case "3":
                            manager.AddGoal(new EternalGoal(name, desc, points));
                            break;
                        default:
                            Console.WriteLine("Invalid option!");
                            break;
                    }
                    break;
                case "2":
                    manager.DisplayGoals();
                    Console.Write("Choose the goal number: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(index);
                    break;
                case "3":
                    manager.DisplayGoals();
                    break;
                case "4":
                    if (string.IsNullOrEmpty(filename))
                    {
                        Console.Write("Enter the filename to save goals (e.g., goals.txt): ");
                        filename = Console.ReadLine();
                    }
                    manager.SaveGoals(filename);
                    Console.WriteLine("Goals saved successfully!");
                    break;
                case "5":
                    Console.Write("Enter the filename to load goals (e.g., goals.txt): ");
                    filename = Console.ReadLine();
                    if (File.Exists(filename))
                    {
                        manager.LoadGoals(filename);
                        Console.WriteLine("Goals loaded successfully!");
                    }
                    else
                    {
                        Console.WriteLine("File does not exist!");
                    }
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }
    }
}