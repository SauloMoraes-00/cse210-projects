using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        Points += 50;
    }
}
