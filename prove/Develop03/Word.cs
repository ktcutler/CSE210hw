public class Word
{
    // Attributes
    public string _word;
    public bool _hidden;

    // Constructor
    public Word(string word)
    {
        _word = word;
        _hidden = false; // important for scripture class 
    }
    
    // Hide the word
    public void Hide()
    {
        _hidden = true; // same importance. You need to create a bool here dicern whether a word is hidden or not
    }

    // ToString method explained in Reference class
    public override string ToString()
    {
        // "________" hides the word because it replaces _word with underscores
        // this is another shorthand that chatGPT taught me to make the program simpler
        // it is a bool that says if _hidden is true, hide the word. If it is false, display _word
        return _hidden ? "_______" : _word;
    }
}
