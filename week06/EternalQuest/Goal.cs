using System;
using System.Collections.Generic;

public abstract class Goal
{

    protected int _points;
    protected string _shortName;
    protected string _description;
    protected static int _totalPoints;

    public Goal(string Name, string Description, int Points)
    {
        _shortName = Name;
        _description = Description;
        _points = Points;
    }


    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    

    public void AddTotalPoints(int points)
    {
        _totalPoints += points;
    }

    public virtual string GetDetailsString()
    {
        return $"[ ] {_shortName} :  {_description} - (Points: {_points})";
    }
}