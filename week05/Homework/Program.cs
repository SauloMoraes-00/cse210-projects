using System;

class Program
{
    static void Main()
    {
        MathAssignment mathHw = new MathAssignment("John Doe", "Fractions", "7.3", "3-10, 20-21");
        Console.WriteLine(mathHw.GetSummary());
        Console.WriteLine(mathHw.GetHomeworkList());
        
        WritingAssignment writingHw = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingHw.GetSummary());
        Console.WriteLine(writingHw.GetWritingInformation());
    }
}
