using System;

public class Entry{
    public string _promptText;
    public string _entryText;
    public DateTime _date = DateTime.Now;


    public void Display()
    {
        Console.WriteLine($"{_date: yyyy-MM-dd HH:mm}  Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine();
        
    }
}
