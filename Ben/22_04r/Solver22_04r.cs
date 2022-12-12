using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AOC_2022._22_04r
{
    internal class Solver22_04r : ISolver
    {
        StreamReader input;
        public string GetSolution()
        {
            int total = 0;
            while (!input.EndOfStream)
            {
                var line = input.ReadLine();

                // split into 2 ranges (e.g. 1-2)
                string[] ranges = line.Split(",");
                string[][] finalRanges = { ranges[0].Split("-"), ranges[1].Split("-") };

                // {{1, 6},{2, 4}}
                if (rangeOverlaps(finalRanges[0], finalRanges[1]) || rangeOverlaps(finalRanges[1], finalRanges[0]))
                {
                    total++;
                }
            }
            return total.ToString();
        }

        private static bool rangeWithinRange(string[] range1, string[] range2)
        {
            return int.Parse(range1[0]) <= int.Parse(range2[0]) &&
                                int.Parse(range1[1]) >= int.Parse(range2[1]);
        }

        private static bool rangeOverlaps(string[] range1, string[] range2)
        {
            return int.Parse(range1[0]) <= int.Parse(range2[0]) &&
                   int.Parse(range2[0]) <= int.Parse(range1[1]) ||
                   int.Parse(range1[1]) >= int.Parse(range2[1]) &&
                   int.Parse(range2[1]) >= int.Parse(range1[0]);
        }

        public void SetInput(StreamReader streamReader)
        {
            input = streamReader;
        }
    }
}
