using System;
using System.Collections.Generic;

public class MathAssigment : Assigment
{
    private string _textbookSection = "";
    private string _problems = "";

    public MathAssigment(string studentName, string subject, string textbookSection, string problems) : base(studentName, subject)
    {
        
        _textbookSection = textbookSection;
        _problems = problems;
    }

   
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}