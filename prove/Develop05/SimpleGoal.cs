public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string goalName, string goalDescription, int userPoints)
        : base(goalName, goalDescription, userPoints)
    {
        _isComplete = false; // Initial state is incomplete
    }

    public override bool IsCompleted()
    {
        return _isComplete;
    }

    public override void MarkComplete()
    {
        _isComplete = true;
    }

    public static SimpleGoal CreateGoal(List<Goal> goals)
    {
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int userPoints = int.Parse(Console.ReadLine());

        return new SimpleGoal(goalName, goalDescription, userPoints);
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetGoalName()},{GetDescription()},{GetUserPoints()}";
    }
}
