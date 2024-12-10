public class EternalGoal : Goal
{
    private bool _isComplete;

    public EternalGoal(string goalName, string goalDescription, int userPoints)
        : base(goalName, goalDescription, userPoints)
    {
        _isComplete = false;
    }

    public override bool IsCompleted()
    {
        return true; // Makes it so every goal is automatically complete
    }

    public override void MarkComplete()
    {
        
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

    // Sourced from assignment page
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetGoalName()},{GetDescription()},{GetUserPoints()}";
    }
}
