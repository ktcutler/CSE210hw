using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static int totalPoints = 0;  // Starting with some points for testing purposes

    static void Main(string[] args)
    {
        // A placeholder for where you'll store goals
        var goals = new List<Goal>();

        // Optionally, load goals from the file
        // goals = LoadGoals("goals.txt");

        while (true)
        {
            // Display total points above the menu
            Console.Clear();
            Console.WriteLine($"You have {totalPoints} points.");

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    // Submenu for creating a new goal
                    CreateNewGoal(goals);
                    break;

                case "2":
                    // List all the goals
                    ListGoals(goals);
                    break;

                case "3":
                    // Save the goals
                    SaveGoals(goals, "goals.txt");
                    break;

                case "4":
                    // Load the goals
                    goals = LoadGoals("goals.txt");
                    break;

                case "5":
                    // Record an event (for simplicity, we won't handle event recording in this example)
                    break;

                case "6":
                    // Exit the program
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }

    static void CreateNewGoal(List<Goal> goals)
    {
        Console.Clear();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?");

        string goalType = Console.ReadLine();

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

    static void CreateSimpleGoal(List<Goal> goals)
    {
        SimpleGoal newGoal = SimpleGoal.CreateGoal(goals);
        goals.Add(newGoal);
        totalPoints += newGoal.GetUserPoints();
        Console.WriteLine("Simple Goal created. Press Enter to Return to the Main Menu.");
    }

    static void CreateEternalGoal(List<Goal> goals)
    {
        EternalGoal newGoal = EternalGoal.CreateGoal(goals);
        goals.Add(newGoal);
        totalPoints += newGoal.GetUserPoints();
        Console.WriteLine("Eternal Goal created. Press Enter to Return to the Main Menu.");
    }

    static void CreateCheckListGoal(List<Goal> goals)
    {
        CheckList newGoal = CheckList.CreateGoal(goals);
        goals.Add(newGoal);
        totalPoints += newGoal.GetUserPoints();
        Console.WriteLine("Checklist Goal created. Press Enter to Return to the Main Menu.");
    }

    static void SaveGoals(List<Goal> goals, string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals have been saved.");
    }

    static List<Goal> LoadGoals(string filename)
    {
        List<Goal> goals = new List<Goal>();

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
    Console.Clear(); // Ensure the screen is cleared before listing the goals

    if (goals.Count == 0)
    {
        Console.WriteLine("No goals found.");
    }
    else
    {
        int goalNumber = 1;
        foreach (var goal in goals)
        {
            // Get goal representation
            string status = goal.GetStringRepresentation();
            string[] statusParts = status.Split(':');

            if (statusParts.Length != 2)
            {
                Console.WriteLine($"Invalid goal format: {status}. Skipping this goal.");
                continue;
            }

            // Extract goal details
            string goalDetails = statusParts[1];
            string[] goalDetailsParts = goalDetails.Split(',');

            if (goalDetailsParts.Length < 3)
            {
                Console.WriteLine($"Incomplete goal details: {goalDetails}. Skipping this goal.");
                continue;
            }

            // Display goal in the desired format: "1. Goal Name (Goal Description)"
            Console.WriteLine($"{goalNumber}. {goal.GetGoalName()} ({goal.GetDescription()})");
            goalNumber++;
        }
    }

    Console.WriteLine("Press any key to return to the main menu...");
    Console.ReadKey();
}

}
