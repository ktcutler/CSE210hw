public class EternalGoal : Goal
{
    private bool _isComplete;

    public EternalGoal(string goalName, string goalDescription, int userPoints)
        : base(goalName, goalDescription, userPoints)
    {
        _isComplete = false; // Initially, this goal is not completed.
    }

    public override bool IsCompleted()
    {
        return true;  // Eternal goals are always considered completed.
    }

    public override void MarkComplete()
    {
        // No need to implement as it's always complete
    }

    public static EternalGoal CreateGoal(List<Goal> goals)
    {
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int userPoints = int.Parse(Console.ReadLine());

        return new EternalGoal(goalName, goalDescription, userPoints);
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetGoalName()},{GetDescription()},{GetUserPoints()}";
    }
}
