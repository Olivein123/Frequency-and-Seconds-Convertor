using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAndFrequencyConversion
{
    public class TimeConverter
    {
        public double SecondsToHertz(double seconds)
        {
            if (seconds <= 0)
            {
                throw new ArgumentException("Period must be a positive non-zero value.");
            }

            double frequencyInHertz = 1.0 / seconds;
            return frequencyInHertz;
        }

    }
}
