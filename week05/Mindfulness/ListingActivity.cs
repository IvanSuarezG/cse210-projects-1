using System;
using System.Collections.Generic;
using System.Threading;


public class ListingActivity : Activity
{

    private List<string> _prompts;
    private List<string> _listFromUser = new List<string>();
    private int _count;

    public ListingActivity() : base()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list by having you list as many things as you can in a certain area ";

        _prompts = new List<string>
        {
            "When have you felt Holy Ghost this month?",
            "What did you learn at the church during the class the last time?",
            "What was your blessings today?",
            "What was the miracles you can see today?",
            "What did you do good today?",
            "What things did you learn from others this week?",
            "Who taught you something this week?",
            "What were some good moments you had today?"
        };
        
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine($"--- {_prompts[index]} ---");
    }

    public List <string> GetListFromUser()
    {
        string text = Console.ReadLine();
        _listFromUser.Add(text);
        _count = _listFromUser.Count();
        
        return _listFromUser;
    }

    public void Run()
    {
        Console.WriteLine("Get ready... \n");
        Spinner();
        Thread.Sleep(2000);

        Console.WriteLine("List as many responses you can to the following prompt: \n");
        GetRandomPrompt();

        for (int i = 3; i > 0; i--)
        {
            Console.Write("\r You began in:  " + i);
            Thread.Sleep(1000);
        }

        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(">  ");
            GetListFromUser();
        }

        Console.WriteLine($"You listed {_count} items");
    }
}