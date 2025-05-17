using System;
using System.IO;

public class Journal
{
    // List of entries
    // This property is used to access the list of entries from outside the class
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Display all entries
    // This method iterates through the list of entries
    // and calls the Display method of each entry
    public void DisplayAll()
    {
        foreach (Entry evidencia in _entries)
        {
            evidencia.Display();
        }

    }

    // Save all entries to a file
    // This method creates a new file with the specified name
    public void SaveToFile(string fileName)
    {
        string doc = fileName + ".txt";

        using StreamWriter outputFile = new StreamWriter(doc);
        foreach (Entry evidencia in _entries)
        {
            outputFile.WriteLine($"{evidencia._date:yyyy-MM-dd HH:mm}/{evidencia._promptText}/{evidencia._entryText}");
        }
        Console.WriteLine($"{doc} was saved");
    }

    // Load entries from a file
    // This method reads the file line by line
    public void LoadFromFile(string fileName)
    {
        string _doc = fileName + ".txt";
        string[] _lines = System.IO.File.ReadAllLines(_doc);

        foreach (string _line in _lines)
        {
            // Split the line into parts using "/" as the delimiter
            // and trim any whitespace from each part
            // Create a new Entry object and set its properties
            // using the parsed values
            // Add the new Entry object to the list of entries
            string[] parts = _line.Split("/");
            Entry _entry = new Entry();
            _entry._date = DateTime.Parse(parts[0].Trim());
            _entry._promptText = parts[1].Trim();
            _entry._entryText = parts[2].Trim();
            _entry.Display();
            _entries.Add(_entry);
        }
    }      
    
}



