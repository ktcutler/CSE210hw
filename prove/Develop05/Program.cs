using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static int totalPoints = 0;  // Variable to hold the user's total points

    static void Main(string[] args)
    {
        // A placeholder for where you'll store goals
        var goals = new List<Goal>();

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

    // Submenu method to create a new goal
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
                // Create a Simple Goal
                CreateSimpleGoal(goals);
                break;

            case "2":
                // Create an Eternal Goal
                CreateEternalGoal(goals);
                break;

            case "3":
                // Create a Checklist Goal
                CreateCheckListGoal(goals);
                break;

            default:
                Console.WriteLine("Invalid selection. Returning to the main menu.");
                break;
        }

        Console.ReadKey();  // Wait for user input before returning to the main menu
        Console.Clear();  // Clear the console for the main menu
    }

    // Method to create a Simple Goal
    static void CreateSimpleGoal(List<Goal> goals)
    {
        // Call the CreateGoal method from SimpleGoal class to handle creation
        SimpleGoal newGoal = SimpleGoal.CreateGoal(goals);
        
        // Add the new goal to the list and update the total points
        goals.Add(newGoal);
        totalPoints += newGoal.GetUserPoints();  // Add points to totalPoints

        Console.WriteLine("Simple Goal created. Press Enter to Return to the Main Menu.");
    }

    // Method to create an Eternal Goal
    static void CreateEternalGoal(List<Goal> goals)
    {
        EternalGoal newGoal = EternalGoal.CreateGoal(goals);

        goals.Add(newGoal);
        totalPoints += newGoal.GetUserPoints();

        Console.WriteLine("Eternal Goal created. Press Enter to Return to the Main Menu.");
    }

    // Method to create a CheckList Goal
    static void CreateCheckListGoal(List<Goal> goals)
    {
        CheckList newGoal = CheckList.CreateGoal(goals);
        goals.Add(newGoal);
        totalPoints += newGoal.GetUserPoints();
        Console.WriteLine("Checklist Goal created. Press Enter to Return to the Main Menu.");
    }

    // Method to save goals to a file
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

    // Method to load goals from a file
    static List<Goal> LoadGoals(string filename)
    {
        List<Goal> goals = new List<Goal>();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 2)
                {
                    string goalType = parts[0];  // SimpleGoal, EternalGoal, CheckList

                    string[] goalDetails = parts[1].Split(',');

                    // Validate that goalDetails has the correct number of items
                    if (goalDetails.Length >= 3)
                    {
                        switch (goalType)
                        {
                            case "SimpleGoal":
                                goals.Add(new SimpleGoal(goalDetails[0], goalDetails[1], int.Parse(goalDetails[2])));
                                break;

                            case "EternalGoal":
                                goals.Add(new EternalGoal(goalDetails[0], goalDetails[1], int.Parse(goalDetails[2])));
                                break;

                            case "CheckList":
                                if (goalDetails.Length >= 5)
                                {
                                    goals.Add(new CheckList(goalDetails[0], goalDetails[1], int.Parse(goalDetails[2]), int.Parse(goalDetails[3]), int.Parse(goalDetails[4])));
                                }
                                break;

                            default:
                                Console.WriteLine("Unknown goal type in file.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid data format in line: {line}");
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

    // Method to list all goals
    static void ListGoals(List<Goal> goals)
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
        }
        else
        {
            int goalNumber = 1;
            foreach (var goal in goals)
            {
                string status = goal.GetStringRepresentation();
                string[] statusParts = status.Split(':');

                if (statusParts.Length != 2)
                {
                    Console.WriteLine($"Invalid goal format: {status}. Skipping this goal.");
                    continue; // Skip invalid goal format
                }

                string goalDetails = statusParts[1];
                string[] goalDetailsParts = goalDetails.Split(',');

                if (goalDetailsParts.Length < 3)
                {
                    Console.WriteLine($"Incomplete goal details: {goalDetails}. Skipping this goal.");
                    continue; // Skip incomplete goal details
                }

                // Handle different goal types
                if (goal is SimpleGoal)
                {
                    Console.WriteLine($"{goalNumber}. Simple Goal: {goalDetailsParts[0]} ({goalDetailsParts[1]})");
                }
                else if (goal is EternalGoal)
                {
                    Console.WriteLine($"{goalNumber}. Eternal Goal: {goalDetailsParts[0]} ({goalDetailsParts[1]})");
                }
                else if (goal is CheckList)
                {
                    Console.WriteLine($"{goalNumber}. Checklist Goal: {goalDetailsParts[0]} ({goalDetailsParts[1]})");
                }
                else
                {
                    Console.WriteLine($"{goalNumber}. Unknown Goal Type.");
                }

                goalNumber++;
            }
        }
    }
}
