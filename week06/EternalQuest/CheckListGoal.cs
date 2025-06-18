using System;
using System.Collections.Generic;

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;

    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++; // Increment the amount completed
        AddTotalPoints(_points); // Add points to the total score
        if (_amountCompleted == _target)
        {
            AddTotalPoints(_bonus); // If the target is reached, add bonus points
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target; // Check if the amount completed meets or exceeds the target
    }


    public override string GetStringRepresentation()
    {
        return  $"{base.GetDetailsString()} -- Complete  {_amountCompleted} / {_target}";
    }

    public override string GetDetailsString()
    {
        if (_amountCompleted >= _target)
        {
            return $"[X] {_shortName} : {_description}";
        }
        else
        {
            return $"[ ] {_shortName} : {_description}";
        }
        

    }


}