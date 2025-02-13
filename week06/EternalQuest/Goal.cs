using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

abstract class Goal
{
    public string Name { get; }
    public string Description { get; }
    public int Points { get; protected set; }
    public bool IsCompleted { get; protected set; }

    protected Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        IsCompleted = false;
    }

    public abstract void RecordEvent();

    public override string ToString()
    {
        return $"{Name} - {Description} [Points: {Points}] [Completed: {IsCompleted}]";
    }
}


