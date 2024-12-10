public abstract class Goal
{
    string _goalName;
    string _goalDescription;
    int _userPoints;

    public string GetGoalName() => _goalName;
    public string GetDescription() => _goalDescription;
    public int GetUserPoints() => _userPoints;

    public void SetGoalName(string goalName) => _goalName = goalName;
    public void SetDescription(string goalDescription) => _goalDescription = goalDescription;
    public void SetUserPoints(int userPoints) => _userPoints = userPoints;

    // Constructor to initialize the Goal
    public Goal(string goalName, string goalDescription, int userPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _userPoints = userPoints;
    }

    // Abstract method for MarkComplete() that must be implemented by subclasses
    public abstract void MarkComplete();

    // Abstract method for checking if a goal is completed
    public abstract bool IsCompleted();

    // Abstract method for getting the string representation of the goal (for saving purposes)
    public abstract string GetStringRepresentation();
}
