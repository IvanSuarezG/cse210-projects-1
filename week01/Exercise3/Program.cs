using System;

class Program
{
    static void Main(string[] args)
    {
        Start:
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);
        
        int attemps = 0;
        string try_again = "";

        while (try_again != "no")
        {
            Console.WriteLine("What is the magic number?");
            string temp2 = Console.ReadLine();
            int guess_number = int.Parse(temp2);

            if (guess_number > number)
            {
                Console.WriteLine("Higher");
                attemps = attemps + 1;
            }else if (guess_number < number)
            {
                 Console.WriteLine("Lower");
                 attemps = attemps + 1;
            }else{
                 attemps = attemps + 1;
                 Console.WriteLine("Congratulations!");
                 Console.WriteLine("You guess it !");
                 Console.WriteLine($"Intents: {attemps}");
                 Console.WriteLine("Do you want to play again?");
                 try_again = Console.ReadLine();
                 if (try_again == "yes"){
                    attemps = 0;
                    goto Start;
                 }
            }
        }
        Console.WriteLine("End Program!");
    }
}