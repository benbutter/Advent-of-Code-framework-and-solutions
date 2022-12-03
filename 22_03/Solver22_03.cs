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
            string line;
            
            
            int count = 0;
            var priorityFinder = new PriorityFinder();

            while (!input.EndOfStream)
            {

                // var halver = new StringHalver(); part 1
                //   var charsFinder = new CommonCharsFinder(); //part 1

                //   var halvesArray = halver.HalveString(line); part 1
                //   var chars = charsFinder.FindCommonChars(halvesArray[0], halvesArray[1]); //part 1

                // lines[count] = input.ReadLine();
                //  if (count % 3 == 0)
                //  {

                //  string[] lines = new string[3];

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
          // return 0;
        }
    }
}
