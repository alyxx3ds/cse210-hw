// File: ListingActivity.cs

using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    class ListingActivity : MindfulnessActivity
    {
        private readonly List<string> Prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity()
        {
            Name = "Listing";
            Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }

        protected override void RunActivity()
        {
            Random random = new Random();
            string prompt = Prompts[random.Next(Prompts.Count)];
            Console.WriteLine($"\n{prompt}\n");

            Countdown(5);
            Console.WriteLine("Start listing items now:");
            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            int count = 0;

            while (DateTime.Now < endTime)
            {
                Console.ReadLine();
                count++;
            }

            Console.WriteLine($"You listed {count} items.");
        }
    }
}