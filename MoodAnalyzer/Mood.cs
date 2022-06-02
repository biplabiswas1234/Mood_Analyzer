using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class Mood_Analyzer
    {
        public string message;

        public Mood_Analyzer()
        {
            this.message = "I am in any mood";
        }
        public Mood_Analyzer(string message)
        {
            this.message = message;
        }
        public string AnalyZerMood(string message)
        {
            this.message = message;

            try
            {
                if (this.message.Contains("SAD"))
                {
                    Console.WriteLine("Sad Mood 1");
                    return "SAD";
                }
                else
                {
                    Console.WriteLine("Happy Mood 1");
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Happy Mood 1 NULL");
                return "HAPPY";

            }
        }

        public string AnalyZerMood()
        {

            try
            {
                if (this.message.Contains("SAD"))
                {
                    Console.WriteLine("Sad Mood 2");
                    return "SAD";
                }
                else
                {
                    Console.WriteLine("Happy Mood 2");
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Happy Mood 2 NULL");
                return "HAPPY";

            }

        }
        

    
    }
}