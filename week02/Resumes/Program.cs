using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Tech Corp";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Senior Developer";
        job2._company = "Innovate Solutions";
        job2._startYear = 2023;
        job2._endYear = 2025;

        Console.WriteLine("Job 1 Details:");
        job1.DisplayJobDetails();

        Console.WriteLine("\nJob 2 Details:");
        job2.DisplayJobDetails();
    }
}