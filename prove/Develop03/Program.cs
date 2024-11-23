// Scripture Memorizer - Kole Cutler
// I used W3 schools and chatGPT to help with this assignemnt

using System;

class Program
{
    // Main for the program. This is where all the classes are compiled
    static void Main(string[] args)
    {
        var reference = new Reference("Alma", 26, 12);
        var scripture = new Scripture(reference, "Yea, I know that I am nothing; as to my strength I am weak; therefore I will not boast of myself, but I will boast of my God, for in his strength I can do all things; yea, behold, many mighty miracles we have wrought in this land, for which we will praise his name forever.");

        // Loop until all words are hidden or the user types "quit"
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.Display());
            Console.WriteLine(Environment.NewLine + "Press Enter to continue or type 'quit' to finish:");

            // Get user input
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.Clear();
                break;  // Exit the loop and end the program
            }

            // Otherwise, hide the next word
            scripture.HideNextWord();
        }

        // Final display once all words are hidden or if user quits
        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.Display());
            Console.WriteLine("Congrats! You finished the program!"); 

            Console.WriteLine("What did you like about the scripture?"); // STRETCH
            string userComment = Console.ReadLine();
            Console.WriteLine("Great points! Thank you for sharing them.");
        }
    }
}
