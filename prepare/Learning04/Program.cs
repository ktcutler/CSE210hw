using System;
using System.ComponentModel;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);

        MathAssignment mathassignment = new MathAssignment("Roberto Rodriquez", "Fractions", "7.3", "8-19");
        string homeworklist = mathassignment.GetHomeworkList();
        Console.WriteLine(homeworklist);

        WritingAssignment writingassignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingassignment.GetWritingInformation());
    }
}