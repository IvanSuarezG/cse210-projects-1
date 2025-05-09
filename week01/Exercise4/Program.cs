using System;

class Program
{
    static void Main(string[] args)
    {
         List<int> numbers = new List<int>();
        int num = 1;
        int sum = 0;
        double average = 9;
        int bigger = int.MinValue;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (num != 0){
            string num_entered = Console.ReadLine();
            num = int.Parse(num_entered);

            if (num != 0)
            {
                numbers.Add(num);
            }  
        }
        foreach (int number in numbers)
        {
            sum += number;
            if(number > bigger){
                    bigger = number;
                }
            
        }
        
        int amount = numbers.Count;
        if (amount > 0)
        {
            average = sum / amount;
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {bigger}");
        }
    }
}