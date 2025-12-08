using System;

namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, string points) 
            : base(name, description, points)
        {
        }
        
        public override void RecordEvent()
        {
            // Eternal goals don't change state
        }
        
        public override bool IsComplete()
        {
            return false;
        }
        
        public override string GetDetailsString()
        {
            return $"[ ] {GetShortName()} ({GetDescription()})";
        }
        
        public override string GetStringRepresentation()
        {
            return $"EternalGoal:{GetShortName()},{GetDescription()},{GetPoints()}";
        }
        
        public static EternalGoal FromString(string data)
        {
            string[] parts = data.Split(',');
            return new EternalGoal(parts[0], parts[1], parts[2]);
        }
    }
}
