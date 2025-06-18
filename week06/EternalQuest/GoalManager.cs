using System;
using System.Collections.Generic;

public class GoalManager 
{

    protected List<Goal> _goals;
    protected int _score;

    public GoalManager() 
    {
        // Initialize the list of goals and score
        _goals = new List<Goal>();
        _score = 0; // Initialize score to zero

    }

    public void Start()
    {
        bool state = true;
        while (state)
        {
            Console.WriteLine("\n Menu");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5  Record Event");
            Console.WriteLine("6. Quit");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    Console.WriteLine("The goals are:");
                   
                    break;
                case "6":
                    state = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }

    }

    public void RecordEvent()
    {
        // Logic to record an event for the goal manager
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.WriteLine("Which goal did you Accomplish?");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
            _score += _goals[goalIndex].GetPoints(); // Add points to the score
        }

        Console.WriteLine($"Congratulations! You have earned {_goals[goalIndex].GetPoints()} points.");
        DisplayPlayerInfo();
        
    }

    public bool IsComplete()
    {
        // Logic to determine if the goal manager is complete
        Console.WriteLine("Checking if GoalManager is complete.");
        return false; // Placeholder return value
    }

    
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. CheckList Goal");

        Console.WriteLine("Which type of goal would you like to create?");
        string choice = Console.ReadLine();

        Console.WriteLine("What is the name of your goal:");
        string name = Console.ReadLine();

        Console.WriteLine("What is the description of your goal:");
        string description = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                Console.WriteLine("Simple Goal created successfully.");
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                Console.WriteLine("Eternal Goal created successfully.");
                break;
            case "3":
                Console.WriteLine("What is the target amount for this goal?");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the bonus for this goal?");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new CheckListGoal(name, description, points, target, bonus));
                Console.WriteLine("CheckList Goal created successfully.");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }

    }

    public void ListGoalNames()
    {
        
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
        
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }


    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }


    public void SaveGoals()
    {
        Console.WriteLine("What is the name of the file you want to save?");
        string _fileName = Console.ReadLine();
        string doc = _fileName + ".txt";
        using StreamWriter outputFile = new StreamWriter(doc);

        foreach (Goal goal in _goals)
        {
            outputFile.WriteLine(goal.GetStringRepresentation());
        }
        
        Console.WriteLine($"Goals saved to {doc}.");
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the name of the file you want to load?");
        string _file = Console.ReadLine();

        string doc = _file + ".txt";
        string[] lines = File.ReadAllLines(doc);

        foreach (string line in lines)
        {
            string[] parts = line.Split(" : ");
            if (parts.Length < 3) continue; // Skip invalid lines

            string name = parts[0].Trim();
            string description = parts[1].Trim();
            int points = int.Parse(parts[2].Trim().Split('-')[1].Trim().Replace("Points: ", ""));
            
            // Check for specific goal types based on the name or description
            if (line.Contains("Simple Goal"))
            {
                _goals.Add(new SimpleGoal(name, description, points));
            }
            else if (line.Contains("Eternal Goal"))
            {
                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (line.Contains("CheckList Goal"))
            {
                // Additional parsing for CheckListGoal specifics can be added here
                _goals.Add(new CheckListGoal(name, description, points, 0, 0)); // Placeholder values
            }
        }
    }
}