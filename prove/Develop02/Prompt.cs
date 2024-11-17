// stores all the prompts and randomizes the prompt questions
using System;
using System.Collections.Generic;

public class Prompts
{
    // Attribute to store questions
    private List<string> _questions;
    private Random _random;
    private List<string> _usedQuestions;

    // Constructor to initialize the list of questions
    public Prompts()
    {
        _random = new Random();
        _questions = new List<string>
        {
            "What makes you feel accomplished?",
            "What did you learn today?",
            "How do you handle stress?",
            "What is your biggest fear?",
            "What is something you are grateful for today?",
            "What is one thing you want to improve about yourself?",
            "Describe a time when you overcame a challenge.",
            "What are your goals for the next year?",
            "What inspires you to keep going when times are tough?",
            "What does success look like to you?"
        };
        _usedQuestions = new List<string>();
    }

    // Get a random question from the list
    public string NextQuestion()
    {
        if (_questions.Count == 0)
        {
            _questions.AddRange(_usedQuestions);
            _usedQuestions.Clear();
        }

        int index = _random.Next(_questions.Count);
        string question = _questions[index];
        _usedQuestions.Add(question);
        _questions.RemoveAt(index);
        return question;
    }
}
