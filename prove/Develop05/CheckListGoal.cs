using System;
using System.Collections.Generic;

public class CheckList : Goal
{
    private int _timesCompleted;
    private int _targetCompletion;

    public CheckList(string goalName, string goalDescription, int userPoints, int timesCompleted, int targetCompletion)
        : base(goalName, goalDescription, userPoints)
    {
        _timesCompleted = timesCompleted;
        _targetCompletion = targetCompletion;
    }

    public static CheckList CreateGoal(List<Goal> goals)
    {
        Console.Write("Enter the name of the goal: ");
        string goalName = Console.ReadLine();
        Console.Write("Enter a description of the goal: ");
        string goalDescription = Console.ReadLine();
        Console.Write("Enter how many points this goal is worth: ");
        int userPoints = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of times this goal needs to be completed: ");
        int targetCompletion = int.Parse(Console.ReadLine());
        Console.Write("Enter how many times this goal has been completed: ");
        int timesCompleted = int.Parse(Console.ReadLine());

        return new CheckList(goalName, goalDescription, userPoints, timesCompleted, targetCompletion);
    }

    public override string GetStringRepresentation()
    {
        return $"CheckList:{GetGoalName()},{GetDescription()},{GetUserPoints()},{_timesCompleted},{_targetCompletion}";
    }
}
