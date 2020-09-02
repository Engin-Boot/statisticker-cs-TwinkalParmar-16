using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer: Stats
    {
       
        public Stats CalculateStatistics(List<float> numbers) {

            //Implement statistics here
            //Stats avgMinMax = new Stats();
            int sizeOfList = numbers.Count;
            if (sizeOfList == 0)
            {
                this.Average = (float)Double.NaN;
                this.Max = (float)Double.NaN;
                this.Min = (float)Double.NaN;
                return this;
            }
            this.Average = numbers.Average();
            this.Max = numbers.Max();
            this.Min = numbers.Min();
            
            return this;
        }
    }
}
