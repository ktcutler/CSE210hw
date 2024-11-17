// used to create menu for the user to read and interact with prompts
using System;

public class Menu
{
    // Attributes. Made this private so that the user cannot access these prompts 
    private Journal _journal;
    private Prompts _prompts;

    // Constructor
    public Menu(Journal journal, Prompts prompts)
    {
        _journal = journal;
        _prompts = prompts;
    }

    // Display menu options
    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");  
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
    }

    // Process user input
    public int ProcessMenu()
    {
        int choice = -1;
        while (choice < 1 || choice > 5)  // Updated to include "Save"
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out choice) && choice >= 1 && choice <= 5)
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
        return choice;
    }

    // Handle Write Option. I used ChatGPT to give me examples of how to use all these handle functions
    public void HandleWrite()
    {
        Console.Clear();
        string question = _prompts.NextQuestion();
        Console.WriteLine($"Prompt: {question}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        string date = DateTime.Now.ToString("yyyy-MM-dd");
        JournalEntry entry = new JournalEntry(date, question, response);
        _journal.AddEntry(entry);

        Console.WriteLine("Your entry has been added!");
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }

    // Handle Display Option
    public void HandleDisplay()
    {
        Console.Clear();
        if (_journal.HasEntries()) 
        {
            _journal.Display();  
        }
        else
        {
            Console.WriteLine("No journal entries found.");
        }
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }

    // Handle Load Option
    public void HandleLoad()
    {
        Console.Clear();
        Console.Write("Enter the filename to load from: ");
        string filename = Console.ReadLine();
        try
        {
            _journal.ReadFromFile(filename);
            Console.WriteLine("Journal entries loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }

    // Handle Save Option
    public void HandleSave()
    {
        Console.Clear();
        Console.Write("Enter the filename to save to: ");
        string filename = Console.ReadLine();
        try
        {
            _journal.WriteToFile(filename);
            Console.WriteLine($"Journal entries saved to {filename} successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }
}
