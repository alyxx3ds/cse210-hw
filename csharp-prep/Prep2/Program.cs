using System;

class Program
{
    static void Main(string[] args)
    {int grade;
        Console.WriteLine("What is your grade?");
        grade = Convert.ToInt32(Console.ReadLine());
        if (grade >= 90)
        {
            Console.WriteLine("A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("B");
        }

        else if (grade >= 70)
        {
            Console.WriteLine("C");
        }

        else if (grade >= 60)
        {
            Console.WriteLine("D");
        }

        else {
            Console.WriteLine("F");
        }

        if (grade >= 70)
        {
            Console.WriteLine("You passed");
        }
        else
        {
            Console.WriteLine("You failed");
        }
    }
}