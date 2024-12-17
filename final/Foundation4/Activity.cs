public class Activity
{
    private string _date;
    private double _minutes;

    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }
    public virtual double GetPace()
    {
        return 0.0;
    }
    public virtual string GetSummary()
    {
        return $"{_date} {_minutes} min: Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()}";
    }

    protected double GetMinutes()
    {
        return _minutes;
    }


}