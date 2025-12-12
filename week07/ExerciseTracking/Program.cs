

using System;
using System.Collections.Generic;
using ExerciseTracking;  // Explicit reference for the namespace

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store all activities
            List<Activity> activities = new List<Activity>();

            // Create one of each activity type
            Running running1 = new Running("03 Nov 2022", 30, 3.0);
            Cycling cycling1 = new Cycling("04 Nov 2022", 30, 12.0);
            Swimming swimming1 = new Swimming("05 Nov 2022", 30, 20);

            // Add activities to the list
            activities.Add(running1);
            activities.Add(cycling1);
            activities.Add(swimming1);

            // Display summary for each activity
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}