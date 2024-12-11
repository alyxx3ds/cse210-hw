// File: MindfulnessActivity.cs

using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    abstract class MindfulnessActivity
    {
        protected string Name;
        protected string Description;
        protected int Duration;

        public void Start()
        {
            Console.Clear();
            Console.WriteLine($"Starting {Name} Activity");
            Console.WriteLine(Description);
            Console.Write("Enter the duration in seconds: ");
            Duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Prepare to begin...");
            DisplaySpinner(3);
            RunActivity();
            End();
        }

        protected abstract void RunActivity();

        protected void End()
        {
            Console.WriteLine("\nGood job! You have completed the activity.");
            Console.WriteLine($"Activity: {Name}, Duration: {Duration} seconds.");
            DisplaySpinner(3);
        }

        protected void DisplaySpinner(int seconds)
        {
            for (int i = 0; i < seconds * 2; i++)
            {
                Console.Write("-\b|\b/\b-\b\\\b");
                Thread.Sleep(250);
            }
            Console.WriteLine();
        }

        protected void Countdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i}\b ");
                Thread.Sleep(1000);
            }
        }
    }
}