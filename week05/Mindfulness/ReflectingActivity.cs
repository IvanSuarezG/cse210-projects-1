using System;
using System.Collections.Generic;



public class ReflectingActivity : Activity
{

    private List<string> _reflections;
    private List<string> _questions;

    public ReflectingActivity() : base()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you felt a strength and resilience. This will help you recognize the power you have and how can use it in other aspects of your life";

        List<string> _reflections = new List<string>
        {
            "Think of a time when you felt proud of yourself. What were you doing?",
            "Think of a time when you felt challenged. How did you overcome it?",
            "Think of a time when you learned something new. What was it and how did it change you?",
            "Think of a time when you helped someone else. How did it make you feel?"
        };
        
        List<string> _questions= new List<string>
        {
            "How did that experience shape who you are today?",
            "What did you learn about yourself from that experience?",
            "How can you apply what you learned to future challenges?",
            "What would you do differently if you faced a similar situation again?",
            "What strengths did you draw on to overcome the challenge?",
            "How did that experience change your perspective on life?",
            "What emotions did you feel during that time, and how did they affect your actions?",
            "How can you use the lessons learned from that experience to help others?",
            "How can you cultivate a mindset of resilience in your daily life?"

        };

    }

    public string GetRandomPrompt()
    {

        Random random = new Random();
        int index = random.Next(_reflections.Count);
        return _reflections[index];
    }

    public string GetRandomQuestion()
    {

        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"---{GetRandomPrompt()}---");
    }

    public void DisplayQuestion()
    {
        Console.Write($"{GetRandomQuestion()} \t");
    }


    public void Run()
    {

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        

        for (int i = 3; i > 0; i--)
        {
            Console.Write("\r You began in:  " + i);
            Thread.Sleep(1000);
        }

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Get ready... \n");
            Spinner();
            Thread.Sleep(2000);
            
            Console.WriteLine("Consider the following prompt: ");
            DisplayPrompt();
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");

            while (DateTime.Now < endTime)
            {
                Console.WriteLine("\n");
                DisplayQuestion();
                Spinner();
                Thread.Sleep(4000);
                Console.WriteLine("\n");
            }
        }
    }

}