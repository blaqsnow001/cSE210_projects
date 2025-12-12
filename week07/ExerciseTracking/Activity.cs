using System;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        private string _date;
        private int _minutes;

        public Activity(string date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        protected string Date => _date;
        protected int Minutes => _minutes;

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            return $"{_date} {GetActivityType()} ({_minutes} min): " +
                   $"Distance {GetDistance():F1} miles, " +
                   $"Speed: {GetSpeed():F1} mph, " +
                   $"Pace: {GetPace():F1} min per mile";
        }

        protected abstract string GetActivityType();
    }
}