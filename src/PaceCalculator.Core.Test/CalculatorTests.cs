using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace PaceCalculator.Core.Test
{
    public class CalculatorTests
    {
        [Test]
        [TestCaseSource(nameof(Data))]
        public void Test(TestData testData)
        {
            var pace = Calculator.FromGoalTime(testData.TargetTime, testData.DistanceInKm);
            Assert.AreEqual(testData.ExpectedResult, pace, $"Failure in {testData.TestName}.");
        }

        public static IEnumerable<TestData> Data => new List<TestData>
        {
            new TestData("20 Min 5 Km", new TimeSpan(0, 20, 0), Calculator.Distance5Km, new TimeSpan(0, 4, 0)),
            new TestData("50 Min 10 Km", new TimeSpan(0, 50, 0), Calculator.Distance10Km, new TimeSpan(0, 5, 0)),
            new TestData("4 hours Marathon", new TimeSpan(4, 0, 0), Calculator.DistanceMarathonInKm, new TimeSpan(0, 0, 5, 41, 272))
        };

        public class TestData
        {
            public TestData(string testName, TimeSpan targetTime, double distanceInKm, TimeSpan expectedResult)
            {
                TestName = testName;
                TargetTime = targetTime;
                DistanceInKm = distanceInKm;
                ExpectedResult = expectedResult;
            }
            public string TestName { get; }
            public TimeSpan TargetTime { get; }
            public double DistanceInKm { get; }
            public TimeSpan ExpectedResult { get; }
            public override string ToString()
            {
                return TestName;
            }
        }
    }
}