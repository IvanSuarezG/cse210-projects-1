using System;
using System.Collections.Generic;


public class Activity
{

    protected string _name;
    protected string _description;

    protected int _duration;

    public string DisplayStartMessage()
    {
        return $"Welcome to the {_name} activity." + 
               $"{_description}";
    }

    public string DisplayEndMessage()
    {
        return $"Well done! You have completed the activity {_name}" +
               " " + $"You have completed {_duration} seconds of the {_name} activity.";
    }


    public void Spinner()
    {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
    }

    public void CountDown(int seconds)
    {
        _duration = seconds;
        
    }
}