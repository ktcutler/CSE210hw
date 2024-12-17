using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running("Dec 12th 2024", 30, 10.0);
        Cycling cycle = new Cycling("Dec 12th 2024", 60, 18.0);
        Swimming swim = new Swimming("Dec 12th 2024", 5, 40);

        List<Activity> activities = new List<Activity> {run, cycle, swim};

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}