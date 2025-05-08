using System;

class Program
{
    static void Main(string[] args)
    {
        // C# Prep 1
        Console.Write("What is your first name?  ");
        string _name = Console.ReadLine();
        Console.Write("What is your last name?  ");
        string _last_name = Console.ReadLine();

        Console.WriteLine($"Your name is {_last_name}, {_name} {_last_name}.");

    }
}