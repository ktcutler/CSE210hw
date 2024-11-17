// The journal class is used to define what attributes a journal would have and the actions you take within a journal. 
public class Journal
{
    // attributes. Fundamentally a journal is a list of entries. that is why I only put one attribute for this and 
    //based my functions around this.
    private List<JournalEntry> _entries;

    // constructor. I used a contructor to create the object "Journal". This is used in the main and also is used in my functions as well
    public Journal()
    {
        _entries = new List<JournalEntry>();
    }

    // Add entry. You take the _entries attribute and put .add so that it appends new entries to the list

    public void AddEntry(JournalEntry entry)
    {
         _entries.Add(entry);
    }
    
    // Display

    public void Display()
{
    if (_entries.Count == 0)
    {
        Console.WriteLine("No journal entries found.");
    }
    else
    {
        foreach (var entry in _entries)
        {
            entry.Display(); 
            Console.WriteLine("----------------------------");
        }
    }
}

    // Write to File. Sourced from class slides

    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(JournalEntry entry in _entries)
            {
                outputFile.WriteLine(entry.ToString());
            }
        }
    }

    // Has Entries, sourced from W3 schools. This is called in the main to help with saving the file

    public bool HasEntries()
    {
        return _entries.Count > 0;
    }


    // Read From File. Sourced from Class slides

    public void ReadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            string date = parts[0];
            string question = parts[1];
            string entryText = parts[2];

            JournalEntry entry = new JournalEntry (date, question, entryText);
            this.AddEntry(entry);
        }
    }
}
