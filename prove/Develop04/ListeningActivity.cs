public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you have helped this week?",
        "What are some achievements you're proud of?",
        "Who are your personal heroes?"
    };

    public ListingActivity(int lengthTime) : base(lengthTime) { }

    public override void StartActivity()
    {
        ShowStartingMessage("Listing", "This activity will help you reflect on the good things in your life by having you list as many items as you can in a certain area.");

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        DisplayAnimation();

        Console.WriteLine("Start listing items:");
        int itemCount = 0;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(LengthTime);

        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine(); 
            itemCount++; 
        }

        Console.WriteLine($"You listed {itemCount} items.");
        ShowEndingMessage();
    }
}
