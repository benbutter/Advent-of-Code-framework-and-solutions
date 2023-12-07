using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_2022._23_06
{
    public class DistanceCalculator
    {
        public List<int> GetDistances (int maxTime)
        { 
            List<int> result = new List<int>();

            for (int i = 0; i <= maxTime; i++) 
            { 
                int timeLeft = maxTime - i;

                int distance = i * timeLeft;

                result.Add(distance);
            }
            
            return result;
        }
    }
}
