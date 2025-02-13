using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
        }
    }
}
