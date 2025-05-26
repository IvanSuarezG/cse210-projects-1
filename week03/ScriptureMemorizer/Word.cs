using System;
using System.Collections.Generic;

public class Word
{
    
    private string _text = "";
    private bool _isHidden = false;
    

    public Word(string text)
    {
        _text = text;
    }

    public Word(string text, bool isHidden)
    {
        _text = text;
        _isHidden = isHidden;
    }

    public void ShownWord()
    {
        // Show the word if it wasn't hidden
        _isHidden = false; 
    }
  
    public void HiddenWord()
    {
        // Hide the word by setting _isHidden to true
        // and replacing the text with underscores
        _isHidden = true;
        _text = string.Join(" ", new string('_', _text.Length).ToCharArray());  
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        // Return the word text, or underscores if it is hidden
        return _text.Trim();
    }

}

