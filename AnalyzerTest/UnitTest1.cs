using MoodAnalyzer;
using NUnit.Framework;

namespace AnalyzerTest
{
    public class MoodAnalyserTest
    {
        Mood_Analyzer moodAnalyser;
        [SetUp]
        public void Setup()
        {
            moodAnalyser = new Mood_Analyzer();
        }
        //UC 1.1:Given message "I am in SAD mood" returns SAD
        [Test]
        public void Given_Message_in_SAD_Mood_returns_SAD_Message()
        {
            //Arrange
            string message = "I am in SAD mood";
            moodAnalyser = new Mood_Analyzer();
            //Act
            string expected = "SAD";
            string actual = moodAnalyser.AnalyZerMood(message);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //UC1.2 :Given message "I am in any mood" returns HAPPY
        [Test]
        public void Given_Message_in_any_Mood_returns_HAPPY_Message()
        {
            //Arrange
            string message = "I am in any mood";
            moodAnalyser = new Mood_Analyzer();
            //Act
            string expected = "HAPPY";
            string actual = moodAnalyser.AnalyZerMood(message);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}