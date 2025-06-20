using System;
using System.Collections.Generic;

public class StationeryBicycle : Activity
{
    private DateTime _date;

    public StationeryBicycle(double distance, double weight, double time)
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
        if (_currentSpeed <= 16)
        {
            MET = 4.0; // Light effort
            return MET * 0.0175 * _weight * _time;
        }
        else if (_currentSpeed > 16 && _currentSpeed <= 19)
        {
            MET = 6.8; // Moderate effort
            return MET * 0.0175 * _weight * _time;
        }
        else if (_currentSpeed > 20 && _currentSpeed <= 23)
        {
            MET = 8.0; // Vigorous effort
            return MET * 0.0175 * _weight * _time;
        }
        else if (_currentSpeed >= 23 && _currentSpeed <= 26)
        {
            MET = 10.0; // Very vigorous effort
            return MET * 0.0175 * _weight * _time;
        }
        else
        {
            MET = 13.5; // Vigorous effort
            return MET * 0.0175 * _weight * _time;
        }
    }

    public override string GetSummary()
    {
        return $"{_date.ToShortDateString()} - Stationary Bicycle: Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} km/h, Pace: {GetPace():F2} min/km, Calories Burned: {GetCaloriesBurned():F2} kcal";
    }
    
}