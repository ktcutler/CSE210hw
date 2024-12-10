public abstract class Goal
{
    string _goalName;
    string _goalDescription;
    int _userPoints;

    // Getter for GoalName
    public string GetGoalName()
    {
        return _goalName;
    }

    // Setter for GoalName (no return type, just sets the value)
    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }

    // Getter for Description
    public string GetDescription()
    {
        return _goalDescription;
    }

    // Setter for Description (no return type, just sets the value)
    public void SetDescription(string goalDescription)
    {
        _goalDescription = goalDescription;
    }

    // Getter for UserPoints
    public int GetUserPoints()
    {
        return _userPoints;
    }

    // Setter for UserPoints (no return type, just sets the value)
    public void SetUserPoints(int userPoints)
    {
        _userPoints = userPoints;
    }

    // Constructor to initialize the Goal
    public Goal(string goalName, string goalDescription, int userPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _userPoints = userPoints;
    }

    public abstract string GetStringRepresentation();
}
