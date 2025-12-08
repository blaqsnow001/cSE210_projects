using System;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;
        
        public SimpleGoal(string name, string description, string points) 
            : base(name, description, points)
        {
            _isComplete = false;
        }
        
        public override void RecordEvent()
        {
            _isComplete = true;
        }
        
        public override bool IsComplete()
        {
            return _isComplete;
        }
        
        public override string GetDetailsString()
        {
            string checkbox = _isComplete ? "[X]" : "[ ]";
            return $"{checkbox} {GetShortName()} ({GetDescription()})";
        }
        
        public override string GetStringRepresentation()
        {
            return $"SimpleGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_isComplete}";
        }
        
        public static SimpleGoal FromString(string data)
        {
            string[] parts = data.Split(',');
            SimpleGoal goal = new SimpleGoal(parts[0], parts[1], parts[2]);
            goal._isComplete = bool.Parse(parts[3]);
            return goal;
        }
    }
}