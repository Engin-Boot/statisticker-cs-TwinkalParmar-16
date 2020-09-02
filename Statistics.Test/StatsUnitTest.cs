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
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(new List<float>{});
            Double NaN = Double.NaN;
            Assert.False(statsComputer.Average == NaN);
            Assert.True(statsComputer.Average == NaN);
            Assert.True(statsComputer.Average == NaN);
            Console.WriteLine("ReportsNaNForEmptyInput Done!");
           
        }
    }
}

//https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1
