using System;
using System.Collections.Generic;

public class Swimming : Activity
{

    private DateTime _date;
    private int _laps;

    public Swimming(double weight, double time, int laps)
        : base(laps * 50 / 1000.0, weight, time)
    {
        _date = DateTime.Now;
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _distance; // Assuming each lap is 50 meters
    }

    public override double GetSpeed()
    {
        return GetDistance() / (_time / 60); // Speed in km/h
    }

    public override double GetPace()
    {
        return _time / GetDistance(); // Pace in minutes per km
    }

    public override double GetCaloriesBurned()
    {
        MET = 6.0; // Average MET for swimming
        return MET * 0.0175 * _weight * _time; // Calories burned formula
    }

    public override string GetSummary()
    {
        return $"{_date.ToShortDateString()} - Swimming: Laps: {_laps}, Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} km/h, Pace: {GetPace():F2} min/km, Calories Burned: {GetCaloriesBurned():F2} kcal";
    }


}