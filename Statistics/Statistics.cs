using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<double> numbers)
        {
            var stats = new Stats();
            if (numbers.Count > 0)
            {
                stats.max = numbers.Max<double>();
                stats.min = numbers.Min<double>();
                stats.average = numbers.Average();
                return stats;
            }

            stats.average = Double.NaN;
            stats.max = Double.NaN; 
            stats.min=Double.NaN;
            return stats;
        }
    }
}
