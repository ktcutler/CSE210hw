using System;
using System.Collections.Generic;

public class EternalGoal : Goal
{
    public EternalGoal(string goalName, string goalDescription, int userPoints)
        : base(goalName, goalDescription, userPoints)
    {
    }

    public static EternalGoal CreateGoal(List<Goal> goals)
    {
        Console.Write("Enter the name of the goal: ");
        string goalName = Console.ReadLine();
        Console.Write("Enter a description of the goal: ");
        string goalDescription = Console.ReadLine();
        Console.Write("Enter how many points this goal is worth: ");
        int userPoints = int.Parse(Console.ReadLine());

        return new EternalGoal(goalName, goalDescription, userPoints);
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetGoalName()},{GetDescription()},{GetUserPoints()}";
    }
}
