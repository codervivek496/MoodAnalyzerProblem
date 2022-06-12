using Microsoft.VisualStudio.TestTools.UnitTesting;

using MoodAnalyzerProblem;

namespace MoodAnalyzerMSTest
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyzerProblem.MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am in Any Mood");


        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            //Arrange
            string expected = "SAD";

            //Act
            string actual = moodAnalyzer.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenAnyMoodShouldReturnHAPPY()
        {
            //Arrange
            string expected = "HAPPY";

            //Act
            string actual = moodAnalyzer.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}