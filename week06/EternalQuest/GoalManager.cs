using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    public int TotalScore { get; private set; } = 0;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void DisplayGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i]}");
        }
    }

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            goals[index].RecordEvent();
            TotalScore += goals[index].Points;
            Console.WriteLine("Event recorded successfully!");
        }
        else
        {
            Console.WriteLine("Invalid goal index!");
        }
    }

    public void SaveGoals(string filename)
    {
        var data = new
        {
            Goals = goals,
            TotalScore = TotalScore
        };
        var options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(data, options);
        File.WriteAllText(filename, json);
    }

    public void LoadGoals(string filename)
    {
        string json = File.ReadAllText(filename);
        var data = JsonSerializer.Deserialize<Dictionary<string, object>>(json);
        goals = JsonSerializer.Deserialize<List<Goal>>(data["Goals"].ToString());
        TotalScore = JsonSerializer.Deserialize<int>(data["TotalScore"].ToString());
    }
}
