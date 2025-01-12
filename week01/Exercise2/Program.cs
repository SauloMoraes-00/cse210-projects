using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Grade Persentege? ");
        string gradeNumb = Console.ReadLine();
        int gradePerc = int.Parse(gradeNumb);

        string letter = "";

        if ((gradePerc == 90) || gradePerc > 90)
        {
            letter = "A";
        }

        else if ((gradePerc == 80) || gradePerc > 80)
        {
            letter = "B";
        }

        else if ((gradePerc == 70) || gradePerc > 70)
        {
            letter = "C";
        }
        else if ((gradePerc == 60) || gradePerc > 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (gradePerc >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Sadly, you failed.");
        }

    }
}