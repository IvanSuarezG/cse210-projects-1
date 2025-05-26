using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Reference _FirstReference = new Reference("Jhon", 3, 16, 16);
        string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        
        // Create a new Scripture object with the reference and words
        // and display the reference and words
        Scripture _scripture = new Scripture(_FirstReference, text);
        Console.WriteLine($"{_scripture.GetDisplayText()}");

        string input = "";

        do
        {
            // Prompt the user to hide words
            Console.WriteLine(_scripture.GetDisplayText().Trim());
            input = Console.ReadLine().ToLower();

            if (input != "quit")
            // Hide 3 random words
            // if the user does not type "quit"
            {
                _scripture.HideRandomWords(3);
            }

            if (_scripture.IsCompletelyHidden() == true)
            // Check if all words are hidden
            // and display a message if they are
            {
                Console.WriteLine("All words are hidden.");
                break;
            }

        } while (input != "quit");
       
    }
}