using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2020";
        job1._endYear = "2023";

        job2._jobTitle = "Graphic Designer";
        job2._company = "Keller Williams";
        job2._startYear = "2021";
        job2._endYear = "2024";
        
        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

        Resume resume1 = new Resume();
        resume1._name = "Kole Cutler";

        resume1.();

        

    }

}