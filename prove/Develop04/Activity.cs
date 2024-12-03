using System;
using System.Collections.Generic;
using System.Threading;

// Base actvity class
public abstract class Activity
{
    // Ending message that is shown after every activity
    private string _endingMessage = "Good job! You have completed the activity.";
    private int _lengthTime;
    private int _pauses = 3;

    protected string EndingMessage => _endingMessage;
    protected int LengthTime { get => _lengthTime; set => _lengthTime = value; }
    protected int Pauses { get => _pauses; }

    public Activity(int lengthTime)
    {
        _lengthTime = lengthTime;
    }

    // Same starting message
    protected void ShowStartingMessage(string activityName, string description)
    {
        Console.WriteLine($"{activityName} Activity: {description}");
        Console.Write("Enter the duration (in seconds): ");
        LengthTime = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Prepare to begin...");
        DisplayAnimation(); 
    }

    // Display an animation (spinner)
    // I had ChatGPT help me with this one because I couldn't get the spinner to work.
    // The notes below will help show my understanding
    protected void DisplayAnimation()
    {
        // This is the characters that create a spinning effect
        char[] animationChars = new char[] { '|', '/', '-', '\\' }; 
        int i = 0;

        // This is a loop that goes off of the number of pauses that the user inputs
        for (int j = 0; j < Pauses; j++) 
        {
            Console.Write(animationChars[i]);
            Thread.Sleep(500);
            Console.Write("\b \b"); 
            // This goes through the characters 
            i = (i + 1) % animationChars.Length;
        }
        Console.WriteLine();
    }

    protected void ShowEndingMessage()
    {
        Console.WriteLine(EndingMessage);
        DisplayAnimation(); 
        Console.WriteLine($"You spent {LengthTime} seconds on this activity.");
    }

    public abstract void StartActivity();
}
