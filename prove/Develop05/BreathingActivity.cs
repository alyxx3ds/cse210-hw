// File: BreathingActivity.cs

using System;

namespace MindfulnessApp
{
    class BreathingActivity : MindfulnessActivity
    {
        public BreathingActivity()
        {
            Name = "Breathing";
            Description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }

        protected override void RunActivity()
        {
            int interval = 4;
            int cycles = Duration / (interval * 2);

            for (int i = 0; i < cycles; i++)
            {
                Console.WriteLine("Breathe in...");
                Countdown(interval);
                Console.WriteLine("Breathe out...");
                Countdown(interval);
            }
        }
    }
}