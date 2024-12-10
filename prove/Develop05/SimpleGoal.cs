using System;
using System.Collections.Generic;

public class SimpleGoal : Goal
{
    private string _checkBox;

    public SimpleGoal(string goalName, string goalDescription, int userPoints)
        : base(goalName, goalDescription, userPoints)
    {
        _checkBox = " ";
    }

    public string GetCheckBox()
    {
        return _checkBox;
    }

    public void MarkComplete()
    {
        _checkBox = "X";
    }

    public static SimpleGoal CreateGoal(List<Goal> goals)
    {
        Console.Write("Enter the name of the goal: ");
        string goalName = Console.ReadLine();
        Console.Write("Enter a description of the goal: ");
        string goalDescription = Console.ReadLine();
        Console.Write("Enter how many points this goal is worth: ");
        int userPoints = int.Parse(Console.ReadLine());

        return new SimpleGoal(goalName, goalDescription, userPoints);
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetGoalName()},{GetDescription()},{GetUserPoints()}";
    }
}
