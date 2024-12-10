// Eternal Quest Program - Kole Cutler
// Fully completed and exceeds requirements
// This assignment was HARD. I used W3 schools, chatGPT, and classtime to help with
// with this assignment

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    // Creates a variable for total points
    static int totalPoints = 0;  

    static void Main(string[] args)
    {
        var goals = new List<Goal>(); // List where all of the users inputed goals will be stored

        while (true)
        {
            // Display total points above the menu
            Console.Clear();
            Console.WriteLine($"You have {totalPoints} points.");
            // Main menu
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string choice = Console.ReadLine(); // takes user input in the form of a string calls it "choice"

            // Decided to use a switch statement since Bro. Godridge used one
            switch (choice)
            {
                case "1":
                    CreateNewGoal(goals);
                    break;

                case "2":
                    ListGoals(goals);
                    break;

                case "3":
                    SaveGoals(goals);
                    break;

                case "4":
                    goals = LoadGoals();
                    break;

                case "5":
                    RecordEvent(goals);
                    break;

                case "6":
                    return;

                // ChatGPT wrote this when debugging and I kept it. It ensures that user inputs the correct number
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }

    // Method to create all new goals and store them in the same list
    static void CreateNewGoal(List<Goal> goals)
    {
        // Submenu
        Console.Clear();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?");

        string goalType = Console.ReadLine(); // Converts user input to useable variable

        switch (goalType)
        {
            case "1":
                CreateSimpleGoal(goals);
                break;
            case "2":
                CreateEternalGoal(goals);
                break;
            case "3":
                CreateCheckListGoal(goals);
                break;
            default:
                Console.WriteLine("Invalid selection. Returning to the main menu.");
                break;
        }

        Console.ReadKey();
        Console.Clear();
    }

    // Method to create simple goal and store it
    static void CreateSimpleGoal(List<Goal> goals)
    {
        SimpleGoal newGoal = SimpleGoal.CreateGoal(goals);
        goals.Add(newGoal);
        totalPoints += newGoal.GetUserPoints();
        Console.WriteLine("Simple Goal created. Press Enter to Return to the Main Menu.");
    }

    // Method to create eternal goal and store it
    static void CreateEternalGoal(List<Goal> goals)
    {
        EternalGoal newGoal = EternalGoal.CreateGoal(goals);
        goals.Add(newGoal);
        totalPoints += newGoal.GetUserPoints();
        Console.WriteLine("Eternal Goal created. Press Enter to Return to the Main Menu.");
    }

    // Method to create CheckListGoal and store it
    static void CreateCheckListGoal(List<Goal> goals)
    {
        CheckList newGoal = CheckList.CreateGoal(goals);
        goals.Add(newGoal);
        totalPoints += newGoal.GetUserPoints();
        Console.WriteLine("Checklist Goal created. Press Enter to Return to the Main Menu.");
    }

    // Method for save goals 
    static void SaveGoals(List<Goal> goals)
    {
        Console.Write("Enter the filename to save your goals (e.g., goals.txt): ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine($"Goals have been saved to {filename}.");
    }

    // Method for loading goals
    static List<Goal> LoadGoals()
    {
        List<Goal> goals = new List<Goal>();

        Console.Write("Enter the filename to load goals from: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(":");
                if (parts.Length == 2)
                {
                    string goalType = parts[0];
                    string[] goalDetails = parts[1].Split(",");

                    switch (goalType)
                    {
                        case "SimpleGoal":
                            goals.Add(new SimpleGoal(goalDetails[0], goalDetails[1], int.Parse(goalDetails[2])));
                            break;
                        case "EternalGoal":
                            goals.Add(new EternalGoal(goalDetails[0], goalDetails[1], int.Parse(goalDetails[2])));
                            break;
                        case "CheckList":
                            goals.Add(new CheckList(goalDetails[0], goalDetails[1], int.Parse(goalDetails[2]), int.Parse(goalDetails[3]), int.Parse(goalDetails[4])));
                            break;
                        default:
                            Console.WriteLine("Unknown goal type in file.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid goal format in line: {line}");
                }
            }

            Console.WriteLine("Goals have been loaded.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }

        return goals;
    }

    static void ListGoals(List<Goal> goals)
    {
        Console.Clear();
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
        }
        else
        {
            int goalNumber = 1;
            foreach (var goal in goals)
            {
                string checkbox = goal.IsCompleted() ? "[X]" : "[ ]";
                if (goal is CheckList checklistGoal)
                {
                    Console.WriteLine($"{goalNumber}. {checkbox} {goal.GetGoalName()} ({goal.GetDescription()}) -- {checklistGoal.GetCompletionStatus()}");
                }
                else
                {
                    Console.WriteLine($"{goalNumber}. {checkbox} {goal.GetGoalName()} ({goal.GetDescription()})");
                }
                goalNumber++;
            }
        }

        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }

    static void RecordEvent(List<Goal> goals)
    {
        Console.Clear();

        Console.WriteLine("Here are your goals: ");
        int goalNumber = 1;
        foreach (var goal in goals)
        {
            string checkbox = goal.IsCompleted() ? "[X]" : "[ ]";
            if (goal is CheckList checklistGoal)
            {
                Console.WriteLine($"{goalNumber}. {checkbox} {goal.GetGoalName()} ({goal.GetDescription()}) -- {checklistGoal.GetCompletionStatus()}");
            }
            else
            {
                Console.WriteLine($"{goalNumber}. {checkbox} {goal.GetGoalName()} ({goal.GetDescription()})");
            }
            goalNumber++;
        }

        // STRETCH added functionality where you can mark off multiple goals at once
        Console.WriteLine("Enter the number of the goal you accomplished, separated by commas (e.g., 1, 3, 5): ");
        string input = Console.ReadLine();
        string[] goalNumbers = input.Split(',');

        foreach (string goalNumberStr in goalNumbers)
        {
            if (int.TryParse(goalNumberStr.Trim(), out int goalIndex) && goalIndex > 0 && goalIndex <= goals.Count)
            {
                Goal goal = goals[goalIndex - 1];
                if (!goal.IsCompleted())
                {
                    goal.MarkComplete();
                    totalPoints += goal.GetUserPoints();
                    Console.WriteLine($"You completed the goal: {goal.GetGoalName()} and earned {goal.GetUserPoints()} points.");
                }
                else
                {
                    Console.WriteLine($"Goal '{goal.GetGoalName()}' is already completed.");
                }
            }
            else
            {
                Console.WriteLine($"Invalid goal number: {goalNumberStr.Trim()}.");
            }
        }

        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }
}
