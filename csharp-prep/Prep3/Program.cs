using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);

        Console.WriteLine($"What is the magic number? {magic_number}");
        
        int userInput = 0;

    
        while (userInput != magic_number)
        {
            Console.Write("What is your guess? ");
            userInput = int.Parse(Console.ReadLine());

            if (magic_number > userInput)
            {
                Console.WriteLine("Higher");
            }
            else if (magic_number < userInput)
            {
                Console.WriteLine("Lower");
            }
            else if (magic_number == userInput)
            {
                Console.WriteLine("You got it!");
            }
        }
    }
}