using System;
using System.Collections.Generic;

public class Prompts
{
    // Attributes
    private List<string> promptList;
    private Random random;

    // Constructor
    public Prompts()
    {
        promptList = new List<string>
        {
            "What is something you’re grateful for today, and why?", 
            "Describe a place that makes you feel completely at peace.", 
            "Write about a time when you felt truly proud of yourself.", 
            "What are three things you want to achieve this year, and what steps will you take to get there?", 
            "How do you define success, and what does it look like for you?", 
            "Write a letter to your future self 5 years from now.", 
            "What’s a belief you’ve held for a long time that you’re starting to question?", 
            "Reflect on a recent challenge you overcame. What did you learn from it?", 
            "Write about your ideal day, from the moment you wake up to the moment you fall asleep.", 
            "What are the things that make you feel energized and alive?", 
            "Describe a time when you felt deeply connected to someone.", 
            "If you could live anywhere in the world, where would it be and why?", 
            "What’s something you’ve always wanted to learn or try, but haven’t yet?", 
            "How do you handle stress? What methods work best for you?", 
            "What’s one fear you’d like to overcome, and how could you start facing it?", 
            "Write about a book, movie, or song that deeply resonated with you.", 
            "How do you define self-care, and what are some of your favorite ways to practice it?", 
            "Reflect on a time when you felt truly understood. What made that experience special?", 
            "What does your inner critic say to you, and how can you counter those thoughts with compassion?", 
            "List 5 things that bring you joy, no matter how small.", 
            "If you could have a conversation with your childhood self, what would you say?", 
            "What’s something you’ve been avoiding, and why do you think that is?", 
            "Write about a goal you’re currently working toward and what you’ve learned so far.", 
            "What would you like your legacy to be? How do you want to be remembered?", 
            "Describe a dream you’ve had recently and explore what it might mean.", 
            "What are the qualities in others that you most admire?", 
            "How do you want to grow as a person over the next year?", 
            "Write about a time when you had to let go of something or someone. How did it feel?", 
            "What’s something you’ve learned about yourself this year?", 
            "How does your environment (home, work, etc.) affect your mood and productivity?", 
            "What’s the most important lesson you’ve learned about relationships?", 
            "Write about a time when you took a risk. Was it worth it?", 
            "What does success look like in your personal life versus your professional life?", 
            "Reflect on a meaningful conversation you had recently. What made it impactful?", 
            "What’s something you wish more people understood about you?", 
            "What is your biggest source of inspiration right now?", 
            "How do you define personal growth? What area of your life are you focusing on?", 
            "Describe a time when you felt completely confident.", 
            "What’s one thing you’ve been meaning to forgive yourself for?", 
            "How do you balance work and play in your life?", 
            "Write a thank-you letter to someone who has made a positive impact on your life.", 
            "What would your dream career look like, and what steps can you take to move closer to it?", 
            "What’s a skill you’d like to develop or improve? Why?", 
            "Reflect on a mistake you made. What did it teach you?", 
            "What’s something about the world that you’d like to change, and how could you contribute to that change?", 
            "Write about a time when you experienced something “magical” or out of the ordinary.", 
            "What’s something you do to ground yourself when life feels overwhelming?", 
            "How do you celebrate your achievements, both big and small?", 
            "Write about a person who has inspired you and explain why.", 
            "What do you think your soul needs right now to feel fulfilled?"
        };
        
        random = new Random(); // Initialize Random
    }

    // Method to return a random prompt
    public string RandomizePrompt()
    {
        int index = random.Next(promptList.Count); // Get a random index
        return promptList[index]; // Return the prompt at that index
    }

    // display prompts
    public void DisplayPrompts()
    {
        foreach (string prompt in promptList)
        {
            Console.WriteLine(prompt);
        }
    }
}
