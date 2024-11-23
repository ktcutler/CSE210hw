// Class to define scripture reference
// This is important because this needs to be separated from the verse that gets hidden

public class Reference
{
    // Attributes
    // Private because it is not necessary for the user to have this info
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // Constructor to create object
    public Reference(string book, int chapter, int startVerse, int endVerse = -1)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        // chatGPT wrote "?" in the following line. It is shorthand to write an if-else statement in one line
        // I kept this because it simplifies the code once you understand what it does
        // It is basically creating an way to display the reference if part of the verse isn't fully disclosed
        _endVerse = endVerse == -1 ? _startVerse : endVerse;
    }

    // ToString method to display the reference
    // Had to use W3 schools and chatGPT to understand the ToString method
    // It takes the reference object and converts it all to a string
    // This is necessary because it has to be a string in order to hide all the words 
    public override string ToString()
    {
        return _startVerse == _endVerse
            ? $"{_book} {_chapter}:{_startVerse}"
            : $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}
