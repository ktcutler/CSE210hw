using System;
using System.Collections.Generic;

public class Scripture
{
    // Attributes
    public List<Word> _verse;
    public Reference _reference;

    // Constructor to create scripture object
    public Scripture(Reference reference, string verse)
    {
        _reference = reference;
        _verse = new List<Word>();
        // Loop to split all the words in the verse
        foreach (string word in verse.Split(' '))
        {
            // Append to the Word List once it is split
            _verse.Add(new Word(word));
        }
    }
    
    // Display the current verse with hidden words
    public string Display()
    {
        // Joins the split words into one verse but now defined as individual words
        var verseDisplay = string.Join(" ", _verse);
        // Formats string with reference first and verse second
        return $"{_reference}{verseDisplay}";
    }

    // The following methods were added to my diagram because I didn't realize that I needed loops to hide the words and also
    // to end the program when all the words are hidden

    // Hide the next word
    public void HideNextWord()
    {
        // Since all the words are split, create loop that hides every individual word
        foreach (var word in _verse)
        {
            // after using chatGPT to debug, it put "!" in front the word variable
            // it inverts the boolean value which is important here because if the word is hidden,
            // it should not hide the word and vice versa 
            if (!word._hidden)
            {
                word.Hide();
                break;
            }
        }
    }

    // Check if all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (var word in _verse)
        {
            // same logic as the previous method
            if (!word._hidden)
            {
                return false;  
            }
        }
        return true;  // All words are hidden
    } 
}
