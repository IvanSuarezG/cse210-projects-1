using System;
using System.Collections.Generic;



public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void Run()
    {
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Get ready... \n");
            Spinner();
            Thread.Sleep(2000);
            
            for (int i = 5; i > 0 && DateTime.Now < endTime; i--)
            {
                Console.Write("\r Breathe in... " + i);
                Thread.Sleep(1000);
            }

            Console.WriteLine();

            for (int j = 6; j > 0 && DateTime.Now < endTime; j--)
            {
                Console.Write("\r Breathe out... " + j);
                Thread.Sleep(1000);
            }
            
            Console.WriteLine();
        }
    }
}
