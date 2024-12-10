public class CheckList : Goal
{
    private int _timesCompleted;   // Tracks how many times the goal was completed
    private int _targetCompletion; // How many completions required for the bonus
    private int _bonusPoints;      // Bonus points for completing the goal a certain number of times

    // Constructor for CheckList Goal
    public CheckList(string goalName, string goalDescription, int userPoints, int bonusPoints, int targetCompletion)
        : base(goalName, goalDescription, userPoints)
    {
        _bonusPoints = bonusPoints;
        _targetCompletion = targetCompletion;
        _timesCompleted = 0;  // Initially, no completions
    }

    // Method to mark the goal as completed and check for bonus points
    public void MarkComplete()
    {
        _timesCompleted++;
        if (_timesCompleted >= _targetCompletion)
        {
            // If the user completes the goal enough times, they get the bonus points
            Console.WriteLine($"Congratulations! You've earned a bonus of {_bonusPoints} points!");
            SetUserPoints(GetUserPoints() + _bonusPoints);  // Add bonus points
        }
    }

    // Method to display the current status of the goal, including completion count
    public void DisplayStatus()
    {
        Console.WriteLine($"{GetGoalName()} - {GetDescription()}");
        Console.WriteLine($"Points: {GetUserPoints()}");
        Console.WriteLine($"Completed {GetTimesCompleted()} of {_targetCompletion} times.");
    }

    // Getter for times completed
    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }

    // Static method to create the CheckList goal
    public static CheckList CreateGoal(List<Goal> goals)
    {
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int userPoints = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int targetCompletion = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonusPoints = int.Parse(Console.ReadLine());

        return new CheckList(goalName, goalDescription, userPoints, bonusPoints, targetCompletion);
    }

    // String representation for saving/loading goals
    public override string GetStringRepresentation()
    {
        return $"CheckList:{GetGoalName()},{GetDescription()},{GetUserPoints()},{_bonusPoints},{_targetCompletion},{_timesCompleted}";
    }
}
