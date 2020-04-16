using System;

namespace PaceCalculator.Core
{
    public class Calculator
    {
        public static readonly double Distance5Km = 5.0;
        public static readonly double Distance10Km = 10.0;
        public static readonly double DistanceHalfMarathonInKm = 21.0975;
        public static readonly double DistanceMarathonInKm = 42.195;
        public static TimeSpan FromGoalTime(TimeSpan targetTime, double distanceInKm)
        {
            var result = targetTime.TotalMilliseconds / distanceInKm;
            return new TimeSpan(0, 0, 0, 0, (int)result);
        }
    }
}