public class CheckList : Goal
{
    private int _timesCompleted;     // Tracks the number of times the goal has been completed
    private int _targetCompletion;   // How many times the goal needs to be completed
    private int _bonusPoints;        // Bonus points for completing the goal the target number of times

    // Constructor to initialize the checklist goal
    public CheckList(string goalName, string goalDescription, int userPoints, int bonusPoints, int targetCompletion)
        : base(goalName, goalDescription, userPoints)
    {
        _bonusPoints = bonusPoints;
        _targetCompletion = targetCompletion;
        _timesCompleted = 0;  // Initialize the completed count to 0
    }

   // Submenu for CheckList Goal
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

    // Used ChatGPT to help with this one
    // Basically it says once the times completed is at the target completion, it will mark complete
    public override void MarkComplete()
    {
        if (_timesCompleted < _targetCompletion)
        {
            _timesCompleted++; // Increment completion count
        }
    }

    // Check if the goal is completed (i.e., target completion is met)
    public override bool IsCompleted()
    {
        return _timesCompleted >= _targetCompletion;
    }

    // Get a string representation of the goal (for saving and loading purposes)
    public override string GetStringRepresentation()
    {
        return $"CheckList:{GetGoalName()},{GetDescription()},{GetUserPoints()},{_bonusPoints},{_targetCompletion},{_timesCompleted}";
    }

    // Method to get the current completion status (how many times the goal has been completed)
    public string GetCompletionStatus()
    {
        return $"Currently Completed: {_timesCompleted}/{_targetCompletion}";
    }
}
