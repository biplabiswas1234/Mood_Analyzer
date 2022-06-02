using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class Mood_Analyzer
    {
        public string message;

        public Mood_Analyzer(string message)
        {
            this.message = message;
        }


        public string AnalyZerMood()
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