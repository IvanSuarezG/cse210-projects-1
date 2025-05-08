using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade (percetage)?");

        string grade = Console.ReadLine();
        double value = double.Parse(grade);
        double integer = Math.Floor(value);
        double sign = value - integer;

        char letter;
        char symbol;

        if (value >= 90)
        { 
            if (sign >= 0.7)
            {
                letter = 'A';
                Console.WriteLine($"Your grade is {letter}");
            }else{
                letter = 'A';
                symbol = '-';
                Console.WriteLine($"Your grade is {letter} {symbol}");

            }
        }else if (value >=80)
        {
            if (sign >= 0.7)
            {
                letter = 'B';
                symbol = '+';
                Console.WriteLine($"Your grade is {letter}{symbol}");
            }else{
                letter = 'B';
                symbol = '-';
                Console.WriteLine($"Your grade is {letter} {symbol}");

            }
        }else if (value >=70){
            if (sign >= 0.7)
            {
                letter = 'C';
                symbol = '+';
                Console.WriteLine($"Your grade is {letter}{symbol}");
            }else{
                letter = 'C';
                symbol = '-';
                Console.WriteLine($"Your grade is {letter} {symbol}");

            }
        }else if (value >= 60)
        {
            if (sign >= 0.7)
            {
                letter = 'D';
                symbol = '+';
                Console.WriteLine($"Your grade is {letter}{symbol}");
            }else{
                letter = 'D';
                symbol = '-';
                Console.WriteLine($"Your grade is {letter} {symbol}");

            }
            
        }else
        { 
            letter = 'F';
            Console.WriteLine($"Your grade is {letter}");
        }

        if (value >= 70)
        {
           Console.WriteLine("Congratulations! You have passed the course");
        }else{
            Console.WriteLine("You have not passed the course. Dont worry. You could try again and you will be better. Dont give up.");
        }
    }
}