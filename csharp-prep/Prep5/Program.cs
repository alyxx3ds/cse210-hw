using System;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.DisplayWelcome();
        string userName = program.DisplayUserName();
        int userNumber = program.PromptUserNumber();
        int squaredNum = program.SquaredNumber(userNumber);
        program.DisplayResult(userName, squaredNum);
    }

    void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    string DisplayUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    int PromptUserNumber()
    {
        Console.Write("Please enter your favourite number: ");
        return int.Parse(Console.ReadLine());
    }

    int SquaredNumber(int number)
    {
        return number * number;
    }

    void DisplayResult(string userName, int squaredNum)
    {
        Console.WriteLine($"{userName}, the square of your favourite number is {squaredNum}");
    }
}