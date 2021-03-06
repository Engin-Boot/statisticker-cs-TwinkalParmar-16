using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer: Stats
    {
       
        public Stats CalculateStatistics(List<float> numbers) {

            //Implement statistics here
            int sizeOfList = numbers.Count;
            if (sizeOfList == 0)
            {
                this.Average = (float)Double.NaN;
                this.Max = (float)Double.NaN;
                this.Min = (float)Double.NaN;
                return this;
            }
            while(numbers.Contains((float)Double.NaN))
            {
                int indexOfElementConainingNanValue = numbers.IndexOf((float)Double.NaN);
                numbers[indexOfElementConainingNanValue] = 0F; ;
            }
            this.Average = numbers.Average();
            this.Max = numbers.Max();
            this.Min = numbers.Min();
            
            return this;
        }
    }
}
