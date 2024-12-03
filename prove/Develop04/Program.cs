// Mindfulness Program  - Kole Cutler
// I used W3 schools and ChatGPT to aid and refine this program
// I was not in class this week due to Thanksgiving Break and the example video wasn't working
// I did my best to make a program that fits the prompts as best as possible

// Program/Main to Compile all of the files
class Program
{
    static void Main(string[] args)
    {
        // "While" loop keep programing looping through menu until user exits the program
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            // user input
            string choice = Console.ReadLine();

            if (choice == "4") break;

            Console.Write("Enter the duration (in seconds): ");
            // converts user input into an integer
            int duration;

            while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
            {
                Console.WriteLine("Please enter a valid positive number for the duration.");
                Console.Write("Enter the duration (in seconds): ");
            }

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(duration),
                "2" => new ReflectionActivity(duration),
                "3" => new ListingActivity(duration),
                _ => null
            };

            if (activity != null)
            {
                // Code copied and adjusted from "Code Helps"
                Console.WriteLine("\nStarting the activity...");
                Thread.Sleep(1000); 
                activity.StartActivity();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid activity.");
                Thread.Sleep(1000); 
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();  
        }

        Console.WriteLine("\nThank you for using the Mindfulness Program!");
        Thread.Sleep(1000); 
    }
}
