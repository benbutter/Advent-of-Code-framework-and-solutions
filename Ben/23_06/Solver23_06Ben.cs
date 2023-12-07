using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_2022._23_06
{
    public class Solver23_06Ben : ISolver
    {
        List<int> distances;
        List<int> times;
        int raceTotalWinners = 0;
        int returnTotal = 0;

        public Solver23_06Ben()
        {
             distances = new List<int>();
             times = new List<int>();
        }
        

        public string GetSolution(StreamReader streamReader)
        {
            SetupTimesAndDistances(streamReader);

            DistanceCalculator calc = new DistanceCalculator();

            for (int i = 0; i < times.Count; i++) 
            {
                var possibleDistancesForRace = calc.GetDistances(times[i]);

                foreach (var possibleDistance in possibleDistancesForRace)
                {
                    if (possibleDistance > distances[i])
                    {
                        raceTotalWinners++;
                    }
                }

                if (returnTotal == 0)
                {
                    returnTotal = raceTotalWinners;
                }
                else
                {
                    returnTotal = returnTotal * raceTotalWinners;
                }
                raceTotalWinners = 0;
            }
          
            return returnTotal.ToString();
        }

        private void SetupTimesAndDistances(StreamReader streamReader)
        {
            var line = streamReader.ReadLine();

            var unsanitizedTimes = line.Split(' ');

            var line2 = streamReader.ReadLine();

            var unsanitizedDistances = line2.Split(" ");



            foreach (var s in unsanitizedTimes)
            {
                int number = 0;

                if (Int32.TryParse(s, out number))
                {
                    times.Add(number);
                }
            }

            foreach (var s in unsanitizedDistances)
            {
                int number = 0;

                if (Int32.TryParse(s, out number))
                {
                    distances.Add(number);
                }
            }
        }
    }
}
