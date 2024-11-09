using System;

class Program
{

    static int corn(){
        Console.WriteLine("Hello World!");
        return 10;
    }

    static void Main(string[] args)
    {
        string first, last;

       
        Console.WriteLine(corn());

        Console.Write("What is your first name? ");
        first = Console.ReadLine();

        Console.Write("What is your last name? ");
        last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}");
    }
}