using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus) 
        : base(name, description, points)
    {
        this.targetCount = targetCount;
        this.bonus = bonus;
        currentCount = 0;
    }

    public override void RecordEvent()
    {
        if (currentCount < targetCount)
        {
            currentCount++;
            if (currentCount == targetCount)
            {
                IsCompleted = true;
                Points += bonus;
            }
        }
    }

    public override string ToString()
    {
        return $"{Name} - {Description} [Points: {Points}] [Completed: {IsCompleted}] [Progress: {currentCount}/{targetCount}]";
    }
}
