using System;
using System.Collections.Generic;
using System.ComponentModel;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();
    private bool _isCompletelyHidden = false;
    

    public Scripture(Reference reference, string text)
    { 
        // Initialize the scripture with a reference and a text
        _reference = reference;
        string[] words = text.Split(' ');
        _words = new List<Word>();
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int count = 0;
        int attemps = 0;

        do
        {
            // Hide a random word from the list of words
            // if the word is already hidden, skip it
            int index = _random.Next(_words.Count);
            if (_words[index].IsHidden() == false)
            {
                _words[index].HiddenWord();
                count++;
            }
            attemps++;


        } while (count < numberToHide && attemps < _words.Count * 2);
        // Check if all words are hidden
        for (int i = 0; i < _words.Count; i++)
        {
            if (_words[i].IsHidden() == false)
            {
                _isCompletelyHidden = false; // If at least one word is visible, we are not completely hidden
                return;
            }
        }
       _isCompletelyHidden = true; // Assume all words are hidden after this operation

      

    }

    public string GetDisplayText()
    { 
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        return $"{_reference.GetDisplayText()} {string.Join(" ", displayWords).Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        return _isCompletelyHidden;
    }
}