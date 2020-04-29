using System;
using System.ComponentModel.DataAnnotations;

namespace PaceCalculator.Core
{
    public class GoalTime
    {
        [Required]
        [Range(0, 10)]
        public int? Hours { get; set; }

        [Range(0, 59, ErrorMessage = "Must be between 0 and 59")]
        [Required]
        public int? Minutes { get; set; }

        [Range(0, 59, ErrorMessage = "Must be between 0 and 59")]
        [Required]
        public int? Seconds { get; set; }

        public TimeSpan ToTimeSpan()
        {
            return new TimeSpan(Hours.Value, Minutes.Value, Seconds.Value);
        }
    }
}
