using System;
using System.Collections.Generic;

public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    public override void RecordEvent()
    {
        AddTotalPoints(_points); // Add points to the total score
    }

    public override bool IsComplete()
    {
        return false; // Placeholder return value
    }

    public override string GetStringRepresentation()
    {

        // Return a detailed string representation of the goal
        return  $"{_shortName} : {_description} - (Points: {_points})";
    }
}