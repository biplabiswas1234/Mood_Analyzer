﻿using System;

namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer");
            Mood_Analyzer moodAnalyser = new Mood_Analyzer();
            moodAnalyser.AnalyZerMood("I am in any mood");
        }
    }
}