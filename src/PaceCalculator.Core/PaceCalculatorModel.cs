using System;
using System.ComponentModel.DataAnnotations;

namespace PaceCalculator.Core
{
    public class PaceCalculatorModel
    {
        public PaceCalculatorModel()
        {
            Goal = new GoalTime();
        }
        [ValidateComplexType]
        public GoalTime Goal { get; set; }

        [Required]
        [Range(0, 1000)]
        public double? Distance { get; set; }

        public TimeSpan? TimeSpan = null;

        public string FormatPace()
        {
           if(!TimeSpan.HasValue)
           {
                return "";
           };
           var paceFormat = TimeSpan.Value.Hours > 0 ? @"h\:m\:ss" : @"m\:ss";
           return TimeSpan.Value.ToString(paceFormat) + " /km";
        }
    }
}
