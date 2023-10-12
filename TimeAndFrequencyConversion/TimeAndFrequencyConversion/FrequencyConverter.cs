using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAndFrequencyConversion
{
    public class FrequencyConverter
    {
        public double HertzToSeconds(double frequencyInHertz)
        {
            if (frequencyInHertz == 0)
            {
                throw new ArgumentException("Frequency cannot be zero.");
            }

            double periodInSeconds = 1.0 / frequencyInHertz;
            return periodInSeconds;
        }
    }
}