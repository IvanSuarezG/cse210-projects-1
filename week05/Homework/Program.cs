using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Assigment assigment1 = new Assigment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assigment1.GetSummary());

        MathAssigment mathAssigment1 = new MathAssigment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(mathAssigment1.GetSummary());
        Console.WriteLine(mathAssigment1.GetHomeworkList());

        WritingAssigment writingAssigment1 = new WritingAssigment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssigment1.GetSummary());
        Console.WriteLine(writingAssigment1.GetWritingInformation());
    }
}