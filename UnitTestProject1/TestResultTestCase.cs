using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class TestResultTestCase
    {
        [TestMethod]
        public void TestMarkStats()
        {
            TestResults testResults = new TestResults();
            for (int score = 10; score <= 100; score += 10)
            {
                testResults.addParticipant(new Student("Anna", score));
            }
            testResults.addParticipant(new Student("Anna", 86));
            testResults.addParticipant(new Student("Anna", 79));
            TestResultsService testResultsService = new TestResultsServiceImpl(testResults);
            Assert.AreEqual(3, testResultsService.getAmountOfA());
            Assert.AreEqual(3, testResultsService.getAmountOfB());
            Assert.AreEqual(3, testResultsService.getAmountOfC());
            Assert.AreEqual(2, testResultsService.getAmountOfD());
            Assert.AreEqual(1, testResultsService.getAmountOfF());
        }
    }
}
