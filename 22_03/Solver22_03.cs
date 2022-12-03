using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2022._22_03
{
    class Solver22_03 : ISolver
    {
        string[] lines = new string[3];
        List<string> linesToCheck = new List<string>();

        StreamReader input;
        public void SetInput(StreamReader streamReader)
        {
            input = streamReader;
        }

        public int GetSolution()
        {
            int total = 0;
        
            var priorityFinder = new PriorityFinder();

            while (!input.EndOfStream)
            {

                linesToCheck.Add(input.ReadLine());
                if (linesToCheck.Count == 3)
                {
                   total += FindPriorityOfCommonChars(linesToCheck);
                    linesToCheck.Clear();
                }
              
            }
            return total;
        }
        public int FindPriorityOfCommonChars(List<string> linesRead)
        {
           var charsFinder = new CommonCharsFinderGroups();

           var chars =  charsFinder.FindCommonChars(linesRead[0], linesRead[1], linesRead[2]);

            var priorityFinder = new PriorityFinder();
            return priorityFinder.GetPriority(chars[0]);
        
        }
    }
}
