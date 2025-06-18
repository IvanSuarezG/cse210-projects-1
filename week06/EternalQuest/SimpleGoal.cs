using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


public class SimpleGoal : Goal
{

    protected bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true; // Mark the goal as complete
            AddTotalPoints(_points); // Add points to the total score
        }
        else
        {
            _points = 0; // If the goal is already complete, no points are awarded
        }
    }


    public override bool IsComplete()
    {
        // Logic to determine if the goal is complete
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        // Return a detailed string representation of the goal
        return $"{_shortName} : {_description} - (Points: {_points})";
    }
    
}