using System;

public class Entry
{
    // Attributes
    public string _date;
    public string _prompt;
    public string _response;

    // Constructor
    public Entry(string prompt, string response)
    {
        _date = DateTime.Now.ToString("MM/dd/yyyy");
        _prompt = prompt;
        _response = response;
    }

    // Method to create a new entry
    public static Entry CreateEntry(string prompt, string response)
    {
        return new Entry(prompt, response);
    }

    // Function to display entry
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_response);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Example of creating and displaying an entry
        Entry entry = Entry.CreateEntry("What makes you happy?", "Spending time with family and friends.");
        entry.DisplayEntry();
    }
}
