using System;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;
        
        public ChecklistGoal(string name, string description, string points, int target, int bonus) 
            : base(name, description, points)
        {
            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
        }
        
        public override void RecordEvent()
        {
            if (!IsComplete())
            {
                _amountCompleted++;
            }
        }
        
        public override bool IsComplete()
        {
            return _amountCompleted >= _target;
        }
        
        public override string GetDetailsString()
        {
            string checkbox = IsComplete() ? "[X]" : "[ ]";
            string progress = $"-- Currently completed: {_amountCompleted}/{_target}";
            string progressBar = GetProgressBar();
            
            return $"{checkbox} {GetShortName()} ({GetDescription()}) {progress} {progressBar}";
        }
        
        private string GetProgressBar()
        {
            int percentage = (_amountCompleted * 100) / _target;
            int filled = _amountCompleted * 10 / _target;
            int empty = 10 - filled;
            
            string bar = "[" + new string('#', filled) + new string('-', empty) + "]";
            return $"{bar} {percentage}%";
        }
        
        public int GetBonus()
        {
            return _bonus;
        }
        
        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
        }
        
        public static ChecklistGoal FromString(string data)
        {
            string[] parts = data.Split(',');
            ChecklistGoal goal = new ChecklistGoal(parts[0], parts[1], parts[2],   int.Parse(parts[4]), int.Parse(parts[3]));
            goal._amountCompleted = int.Parse(parts[5]);
            return goal;
        }
    }
}
