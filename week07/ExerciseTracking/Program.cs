using System;
using System.Collections.Generic;

namespace FitnessTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create activities
            Running running = new Running(new DateTime(2023, 10, 1), 30, 4.8);
            Cycling cycling = new Cycling(new DateTime(2023, 10, 2), 45, 20.0);
            Swimming swimming = new Swimming(new DateTime(2023, 10, 3), 60, 40);

            // Add activities to a list
            List<Activity> activities = new List<Activity>
            {
                running,
                cycling,
                swimming
            };

            // Display summaries
            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}