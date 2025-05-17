using System;

public class PromptGenerator {
    // List of prompts
    public List<string> _prompt = new List<string> {

        "What was a new thing you learned today?",
        "What was the best part of my day?",
        "Who was the most interesting person I interacted with today?",
        "What challenge did you manage to overcome today?",
        "What change did you do today?",
        "What was the most fun thing you did today?",
        "What was the most beautiful thing you saw today?",
        "Did you establish a new goal in your life? which?",
        "What dream you have achieved to fulfill today?",
        "What was the most difficult thing you did today?",
        "What was the most interesting thing you learned today?",
        "What was the most important thing you did today?",
        "Did you have a good time with your friends today?",
        "Did you have a good time with your family today?",
        "Did you have a good time with your pets today?",
        "Did you have a good memory today?"
    };
    // This property is used to access the list of prompts from outside the class
    // but it is read-only to prevent modification
    public IReadOnlyList<string> PromptList => _prompt;
    
    // Randomly select a prompt from the list
    // and return it
    private static Random _aleatorio = new Random();
     
    
    public string GetRandomPrompt()
    {
        // Generate a random number between 0 and the count of prompts
        // Select a prompt from the list using the random number
        int number = _aleatorio.Next(0, _prompt.Count);
        string index = _prompt[number];
        return index;
    }
}
        

