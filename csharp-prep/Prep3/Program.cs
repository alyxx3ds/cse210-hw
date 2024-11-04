using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        int guess = 0;
        Console.WriteLine("What is your magic number?");
        guess = Convert.ToInt32(Console.ReadLine());

        while (guess != number) {
            if (guess < number) {
                Console.WriteLine("Higher");
            } 
            else if (guess > number) {
                Console.WriteLine("Lower");
            }
    
            Console.WriteLine("Try again:");
            guess = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("You guessed it!");    }
}