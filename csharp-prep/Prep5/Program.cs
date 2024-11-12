using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string UserName = PromptUserName();

        int UserNumber = PromptUserNumber();

        int squaredNumber = SquaredNumber(UserNumber);  

        DisplayResult(UserName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquaredNumber(int number)  
    {
        int squaredNumber = number * number;  
        return squaredNumber;
    }
    static void DisplayResult(string UserName, int squaredNumber)
    {
        Console.WriteLine($"{UserName}, the square of your number is {squaredNumber}");
    }
}
