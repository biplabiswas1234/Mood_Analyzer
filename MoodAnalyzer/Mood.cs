using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class Mood_Analyzer
    {

        public string AnalyZerMood(string message)
        {
            if (message.Contains("SAD"))
            {
                Console.WriteLine("Sad Mood");
                return "SAD";

            }
            else
            {
                Console.WriteLine("Happy Mood");
                return "HAPPY";
            }

        }
    }
}