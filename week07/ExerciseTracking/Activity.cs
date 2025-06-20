using System;
using System.Collections.Generic;

public abstract class Activity
{
    protected double _distance;
    protected double MET = 0;  
    protected double _weight = 0;
    protected double _time = 0;

    public Activity(double distance, double weight, double time)
    {
        _distance = distance;
        _weight = weight;
        _time = time;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract double GetCaloriesBurned();
    public abstract string GetSummary();
    
}