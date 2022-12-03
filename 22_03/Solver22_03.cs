using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2022._22_03
{
    class Solver22_03 : ISolver
    {
        StreamReader input;
        public void SetInput(StreamReader streamReader)
        {
            input = streamReader;
        }

        public int GetSolution()
        {
            int total = 0;
            string line;
            while (!input.EndOfStream)
            {
                
                var halver = new StringHalver();
                var charsFinder = new CommonCharsFinder();
                var priorityFinder = new PriorityFinder();


                line = input.ReadLine();

                var halvesArray = halver.HalveString(line);

                var chars = charsFinder.FindCommonChars(halvesArray[0], halvesArray[1]);

                foreach (var c in chars)
                {
                    total += priorityFinder.GetPriority(c);
                }

                
            }
            return total;
        }
    }
}
