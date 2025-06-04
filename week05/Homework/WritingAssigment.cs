using System;
using System.Collections.Generic;
using System.ComponentModel;

public class WritingAssigment : Assigment
{
    private string _title = "";

    public WritingAssigment(string studentName, string subject, string title) : base(studentName, subject)
    {
        _title = title; 
    }



    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}