using System;

namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer");
            Console.WriteLine("Using Default Constructor");
            //using default constructor
            Console.WriteLine("Enter the message");
            string message1 = Console.ReadLine();
            Mood_Analyzer analyzer1 = new Mood_Analyzer();
            analyzer1.AnalyZerMood(message1);

            Console.WriteLine("Using parametrized Constructor");
            //using parametrized constructor
            string message2 = Console.ReadLine();
            Mood_Analyzer Analyzer2 = new Mood_Analyzer(message2);
            Analyzer2.AnalyZerMood();
        }
    }
}