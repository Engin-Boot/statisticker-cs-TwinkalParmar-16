using System;
using Xunit;
using Statistics;
using System.Collections.Generic;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(new List<float>{1.5F, 8.9F, 3.2F, 4.5F});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(statsComputer.Average - 4.525) <= epsilon);
            Assert.True(Math.Abs(statsComputer.Max - 8.9) <= epsilon);
            Assert.True(Math.Abs(statsComputer.Min - 1.5) <= epsilon);
            Console.WriteLine("ReportsAverageMinMax Done!");
        }

        [Fact]
        public void ReportsAverageMinMax2()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(new List<float> { 0F, 0F, 0F, 1F });
            float avg = 0.25F;
            float max = 1F;
            float min = 0F;
            Assert.True(avg.CompareTo(statsComputer.Average) == 0);
            Assert.True(max.CompareTo(statsComputer.Max) == 0);
            Assert.True(min.CompareTo(statsComputer.Min) == 0);
            Console.WriteLine("ReportsAverageMinMax2 Done!");
        }

        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(new List<float>{});
            Assert.True((float)Double.NaN.CompareTo(statsComputer.Average) == 0);
            Assert.True((float)Double.NaN.CompareTo(statsComputer.Average) == 0);
            Assert.True((float)Double.NaN.CompareTo(statsComputer.Average) == 0);
            Console.WriteLine("ReportsNaNForEmptyInput Done!");
        }
    }
}
