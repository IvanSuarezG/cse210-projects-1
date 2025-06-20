using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Exercise Tracking Program!");

        Activity[] activities = new Activity[3];
        activities[0] = new Running(5.0, 30.0, 70.0); // 5 km in 30 minutes with a weight of 70 kg
        activities[1] = new Swimming(70.0, 45.0, 20); // 20 laps in 45 minutes with a weight of 70 kg
        activities[2] = new StationeryBicycle(10.0, 70.0, 60.0); // 10 km in 60 minutes with a weight of 70 kg  

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}