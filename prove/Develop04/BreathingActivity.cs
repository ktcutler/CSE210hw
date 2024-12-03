public class BreathingActivity : Activity
{
    public BreathingActivity(int lengthTime) : base(lengthTime) { }

    public override void StartActivity()
    {
        ShowStartingMessage("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(LengthTime); // Calculate end time based on duration

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine("Breathe in...");
            DisplayAnimation();
            Thread.Sleep(3000); // Pause for 3 seconds

            Console.WriteLine("Breathe out...");
            DisplayAnimation();
            Thread.Sleep(3000); // Pause for 3 seconds
        }

        ShowEndingMessage();
    }
}
