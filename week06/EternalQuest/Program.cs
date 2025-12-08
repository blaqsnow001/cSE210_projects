// FILE: Program.cs
// Main entry point
// 
// CREATIVITY AND EXCEEDING REQUIREMENTS:
// 1. LEVELING SYSTEM: Users gain levels based on their score. Each level 
//    requires progressively more points. The system displays current level 
//    and progress to next level, adding motivation beyond just points.
// 
// 2. VISUAL PROGRESS BARS: For ChecklistGoal, displays visual progress bars
//    showing completion percentage (e.g., [####------] 40%). Provides
//    immediate visual feedback on goal progress.
// 
// 3. ENHANCED GOAL DISPLAY: Goals show detailed status information including
//    completion counts, progress percentages, and visual indicators for
//    quick reference.

using System;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╔════════════════════════════════════════════════╗");
            Console.WriteLine("║         WELCOME TO ETERNAL QUEST!              ║");
            Console.WriteLine("║      Track Your Goals & Level Up Your Life     ║");
            Console.WriteLine("╚════════════════════════════════════════════════╝");
            
            GoalManager manager = new GoalManager();
            manager.Start();
        }
    }
}