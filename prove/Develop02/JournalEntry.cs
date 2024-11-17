// this class is used to breakdown what exactly is put inside of a journal entry
public class JournalEntry
{
    // Attributes
    public string _date;
    public string _prompt;
    public string _entryText;

    // Constructor
    public JournalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _entryText = response;
    }

    // Display the entry along with word count
    public void Display()
    {
        int wordCount = GetWordCount(); // STRETCH ASSIGNMENT
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"Word Count: {wordCount}");
        Console.WriteLine(_entryText);
    }

    // Convert entry to string
    public override string ToString()
    {
        return $"{_date}#{_prompt}#{_entryText}";
    }

    // STRETCH ASSIGNMENT
    public int GetWordCount()
    {
        string[] words = _entryText.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}
