using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2022._22_01
{
    class Solver22_01 : ISolver
    {
        StreamReader input;
        public void SetInput(StreamReader streamReader)
        {
            input = streamReader;
        }

        public int GetSolution()
        {
            
            List<int> accumulatedValues = AccumulateValuesIntoList();

            return GetHighestValueInList(accumulatedValues);

        }

        private List<int> AccumulateValuesIntoList()
        {
            String line;
            List<int> accumulatedValues = new List<int>();

            int totalForCurrent = 0;

            while (!input.EndOfStream)
            {
                line = input.ReadLine();
                if (line == null)
                {
                    accumulatedValues.Add(totalForCurrent);
                    totalForCurrent = 0;
                }
                totalForCurrent = totalForCurrent + Int32.Parse(line);
            }

            return accumulatedValues;
        }

        private int GetHighestValueInList(List<int> accumulatedValues)
        {
            int highestValue = 0;

            for (int i = 0; i < accumulatedValues.Count; i++)
            {
                if (accumulatedValues[i] > highestValue)
                {
                    highestValue = accumulatedValues[1];
                }
            }

            return highestValue;
        }

    }
}
