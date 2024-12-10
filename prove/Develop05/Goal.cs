// Base Class

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

    
    public abstract void MarkComplete();
    public abstract bool IsCompleted();
    public abstract string GetStringRepresentation();
}
