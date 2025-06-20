using System;
using System.Collections.Generic;

public class Running : Activity
{
    private DateTime _date;

    public Running(double distance, double time, double weight)
        : base(distance, weight, time)
    {
        _date = DateTime.Now;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {

        return _distance / (_time / 60); // Speed in km/h
    }

    public override double GetPace()
    {
        return _time / _distance; // Pace in minutes per km
    }

    public override double GetCaloriesBurned()
    {
        double _currentSpeed = GetSpeed();

        if (_currentSpeed <= 5.0)
        {
            MET = 3.3;
            return MET * 0.0175 * _weight * _time;
        }
        else if (_currentSpeed >= 5.5 && _currentSpeed  <= 10.0)
        {
            MET = 7.5;
            return MET * 0.0175 * _weight * _time;
        }
        else if (_currentSpeed >= 10.5 && _currentSpeed <= 12.0)
        {
            MET = 10.0;
            return MET * 0.0175 * _weight * _time;
        }
        else
        {
            MET = 8.0;
            return MET * 0.0175 * _weight * _time;
        }
    }

    public override string GetSummary()
    {
        return $"{_date.ToShortDateString()} - Running: Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} km/h, Pace: {GetPace():F2} min/km, Calories Burned: {GetCaloriesBurned():F2} kcal";
    }

}
