using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals;
        private int _score;
        
        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }
        
        public void Start()
        {
            bool running = true;
            
            while (running)
            {
                DisplayPlayerInfo();
                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("  1. Create New Goal");
                Console.WriteLine("  2. List Goals");
                Console.WriteLine("  3. Save Goals");
                Console.WriteLine("  4. Load Goals");
                Console.WriteLine("  5. Record Event");
                Console.WriteLine("  6. Quit");
                Console.Write("Select a choice from the menu: ");
                
                string choice = Console.ReadLine();
                Console.WriteLine();
                
                switch (choice)
                {
                    case "1":
                        CreateGoal();
                        break;
                    case "2":
                        ListGoalNames();
                        break;
                    case "3":
                        SaveGoals();
                        break;
                    case "4":
                        LoadGoals();
                        break;
                    case "5":
                        RecordEvent();
                        break;
                    case "6":
                        running = false;
                        Console.WriteLine("Thank you for using Eternal Quest!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        
        public void DisplayPlayerInfo()
        {
            int level = GetLevel();
            int nextLevelScore = GetNextLevelScore(level);
            int currentLevelScore = GetCurrentLevelScore(level);
            int progressInLevel = _score - currentLevelScore;
            int pointsNeededForLevel = nextLevelScore - currentLevelScore;
            
            Console.WriteLine("\n" + new string('=', 50));
            Console.WriteLine($"You have {_score} points. (Level {level})");
            Console.WriteLine($"Progress to Level {level + 1}: {progressInLevel}/{pointsNeededForLevel} points");
            Console.WriteLine(new string('=', 50));
        }
        
        private int GetLevel()
        {
            if (_score < 1000) return 1;
            if (_score < 2500) return 2;
            if (_score < 5000) return 3;
            if (_score < 10000) return 4;
            if (_score < 20000) return 5;
            return 6 + (_score - 20000) / 15000;
        }
        
        private int GetCurrentLevelScore(int level)
        {
            if (level == 1) return 0;
            if (level == 2) return 1000;
            if (level == 3) return 2500;
            if (level == 4) return 5000;
            if (level == 5) return 10000;
            if (level == 6) return 20000;
            return 20000 + (level - 6) * 15000;
        }
        
        private int GetNextLevelScore(int level)
        {
            return GetCurrentLevelScore(level + 1);
        }
        
        public void ListGoalNames()
        {
            Console.WriteLine("The goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
            
            if (_goals.Count == 0)
            {
                Console.WriteLine("  (No goals created yet)");
            }
        }
        
        public void ListGoalDetails()
        {
            Console.WriteLine("\n=== GOAL DETAILS ===");
            foreach (Goal goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
                Console.WriteLine();
            }
        }
        
        public void CreateGoal()
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            
            string typeChoice = Console.ReadLine();
            
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            
            Goal newGoal = null;
            
            switch (typeChoice)
            {
                case "1":
                    newGoal = new SimpleGoal(name, description, points);
                    break;
                    
                case "2":
                    newGoal = new EternalGoal(name, description, points);
                    break;
                    
                case "3":
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());
                    
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());
                    
                    newGoal = new ChecklistGoal(name, description, points, target, bonus);
                    break;
                    
                default:
                    Console.WriteLine("Invalid goal type.");
                    return;
            }
            
            _goals.Add(newGoal);
            Console.WriteLine($"\n✓ Goal '{name}' created successfully!");
        }
        
        public void RecordEvent()
        {
            ListGoalNames();
            
            if (_goals.Count == 0)
            {
                Console.WriteLine("Create some goals first!");
                return;
            }
            
            Console.Write("Which goal did you accomplish? ");
            int goalIndex = int.Parse(Console.ReadLine()) - 1;
            
            if (goalIndex >= 0 && goalIndex < _goals.Count)
            {
                Goal selectedGoal = _goals[goalIndex];
                
                if (selectedGoal.IsComplete() && !(selectedGoal is EternalGoal))
                {
                    Console.WriteLine("\nThis goal is already complete!");
                    return;
                }
                
                int pointsEarned = selectedGoal.GetPointValue();
                bool wasAlmostComplete = false;
                
                if (selectedGoal is ChecklistGoal checklistGoal)
                {
                    wasAlmostComplete = !checklistGoal.IsComplete();
                }
                
                selectedGoal.RecordEvent();
                _score += pointsEarned;
                
                Console.WriteLine($"\nCongratulations! You have earned {pointsEarned} points!");
                
                if (selectedGoal is ChecklistGoal cGoal && cGoal.IsComplete() && wasAlmostComplete)
                {
                    int bonus = cGoal.GetBonus();
                    _score += bonus;
                    Console.WriteLine($"🎉 BONUS! You completed the checklist and earned {bonus} extra points!");
                }
                
                Console.WriteLine($"You now have {_score} points.");
            }
            else
            {
                Console.WriteLine("Invalid goal number.");
            }
        }
        
        public void SaveGoals()
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();
            
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.WriteLine(_score);
                    
                    foreach (Goal goal in _goals)
                    {
                        writer.WriteLine(goal.GetStringRepresentation());
                    }
                }
                
                Console.WriteLine($"\n✓ Goals saved successfully to {filename}!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving goals: {ex.Message}");
            }
        }
        
        public void LoadGoals()
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();
            
            try
            {
                if (!File.Exists(filename))
                {
                    Console.WriteLine("File not found.");
                    return;
                }
                
                _goals.Clear();
                
                using (StreamReader reader = new StreamReader(filename))
                {
                    _score = int.Parse(reader.ReadLine());
                    
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(':');
                        string goalType = parts[0];
                        string goalData = parts[1];
                        
                        Goal goal = null;
                        
                        switch (goalType)
                        {
                            case "SimpleGoal":
                                goal = SimpleGoal.FromString(goalData);
                                break;
                            case "EternalGoal":
                                goal = EternalGoal.FromString(goalData);
                                break;
                            case "ChecklistGoal":
                                goal = ChecklistGoal.FromString(goalData);
                                break;
                        }
                        
                        if (goal != null)
                        {
                            _goals.Add(goal);
                        }
                    }
                }
                
                Console.WriteLine($"\n✓ Goals loaded successfully from {filename}!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading goals: {ex.Message}");
            }
        }
    }
}