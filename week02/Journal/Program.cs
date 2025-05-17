using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Please enter your name: ");
        string _Name = Console.ReadLine();
        int _number = 0;
        Journal _journal = new Journal();
        do
        {

            Console.Write($"Welcome to the Journal´s {_Name} Program! \n");
            ShowMenu();

            string _option = Console.ReadLine();
            // Validate the input to ensure it's a number
            // If it's not a number, prompt the user to enter a valid option
            if (!int.TryParse(_option, out _number))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (_number)
            {
                case 1:

                    PromptGenerator _prompt = new PromptGenerator();
                    string _question = _prompt.GetRandomPrompt();
                    Console.WriteLine(_question);

                    Entry _note = new Entry();
                    _note._promptText = _question;

                    Console.Write("Please write your entry: ");
                    _note._entryText = Console.ReadLine();

                    _journal.AddEntry(_note);

                    break;

                case 2:
                    _journal.DisplayAll();
                    break;

                case 3:
                    Console.WriteLine("What is the name of the file you want to load?");
                    string _file = Console.ReadLine();
                    _journal.LoadFromFile(_file);
                    Console.WriteLine("File loaded successfully.");
                    break;

                case 4:
                    Console.WriteLine("What is the name of the file you want to save?");
                    string _fileName = Console.ReadLine();
                    _journal.SaveToFile(_fileName);

                    break;

                case 5:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;


            }
        } while (_number != 5);
    }   

    
    // Display the menu options
    // This method prints the available options to the console
    static void ShowMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }
}