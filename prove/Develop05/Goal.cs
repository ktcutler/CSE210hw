public abstract class Goal
{
    string _goalName;
    string _goalDescription;
    int _userPoints;

    public string GetGoalName() { return _goalName; }
    public void SetGoalName(string goalName) { _goalName = goalName; }
    public string GetDescription() { return _goalDescription; }
    public void SetDescription(string goalDescription) { _goalDescription = goalDescription; }
    public int GetUserPoints() { return _userPoints; }
    public void SetUserPoints(int userPoints) { _userPoints = userPoints; }

    public Goal(string goalName, string goalDescription, int userPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _userPoints = userPoints;
    }

    public abstract string GetStringRepresentation();
}
