using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2022._22_04
{
    public class Solver22_04 : ISolver
    {
        StreamReader input;
        int count = 0;
        ContainsCheck checker = new ContainsCheck();

        public void SetInput(StreamReader streamReader)
        {
            input = streamReader; ;
        }
        public string GetSolution()
        {
            string line;

            while (!input.EndOfStream)
            {
                line = input.ReadLine();
                string[] ranges = line.Split(',');

                //  if (checker.DoesOnenumberRangeContainTheOther(ranges[0], ranges[1])) //part 1
                if (checker.DoNumberRangesOverlap(ranges[0], ranges[1])) //part 2
                {
                    count++;
                }
            }

            return count.ToString();
        }

   
    }
}
