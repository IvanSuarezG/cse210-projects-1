using System;
using System.Collections;


class Program
{
    static void Main(string[] args)
    {
        int _number = 0;

        Console.WriteLine("Welcome to the Mindfulness App!");
        ShowMenu();
        do
        {
            string _option = Console.ReadLine();
            if (!int.TryParse(_option, out _number))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (_number)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    Console.WriteLine(breathingActivity.DisplayStartMessage());
                    breathingActivity.CountDown(RunActivity());
                    breathingActivity.Run();
                    Console.WriteLine(breathingActivity.DisplayEndMessage());
                    breathingActivity.Spinner();
                    Console.WriteLine("\n");
                    Thread.Sleep(2000);
                    ShowMenu();
                    break;

                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    Console.WriteLine(reflectingActivity.DisplayStartMessage());
                    reflectingActivity.CountDown(RunActivity());
                    reflectingActivity.Run();
                    Console.WriteLine(reflectingActivity.DisplayEndMessage());
                    reflectingActivity.Spinner();
                    Console.WriteLine("\n");
                    Thread.Sleep(2000);
                    ShowMenu();
                    break;

                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    Console.WriteLine(listingActivity.DisplayStartMessage());
                    listingActivity.CountDown(RunActivity());
                    Console.WriteLine("\n");
                    listingActivity.Run();
                    Console.WriteLine(listingActivity.DisplayEndMessage());
                    listingActivity.Spinner();
                    Console.WriteLine("\n");
                    Thread.Sleep(2000);
                    ShowMenu();
                    break;

                case 4:
                    Console.WriteLine("Goodbye!");

                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        } while (_number != 4);
    }

    static void ShowMenu()
    {
        // Display the menu options
        // This method prints the available options to the console
   
        Console.WriteLine("Menu Options:");
        Console.WriteLine("Please select an activity");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
    }

    static int RunActivity()
    {
        Console.WriteLine("How long, in seconds, would you like to do this activity?");
        string _durationInput = Console.ReadLine();
        return int.Parse(_durationInput);
    }
}
 
    