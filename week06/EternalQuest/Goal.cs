using System;

namespace EternalQuest
{
    public abstract class Goal
    {
        private string _shortName;
        private string _description;
        private string _points;
        
        public Goal(string name, string description, string points)
        {
            _shortName = name;
            _description = description;
            _points = points;
        }
        
    protected string GetShortName() { return _shortName; }
    protected string GetDescription() { return _description; }
    protected string GetPoints() { return _points; }

// Public method for external classes to access points
public int GetPointValue() 
{ 
    return int.Parse(_points.Split(',')[0]); 
}
        
        public abstract void RecordEvent();
        public abstract bool IsComplete();
        public abstract string GetDetailsString();
        public abstract string GetStringRepresentation();
    }
}
