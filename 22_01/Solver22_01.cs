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

        public string GetSolution()
        {
            
            List<int> accumulatedValues = AccumulateValuesIntoList();

            //part one
            //return GetHighestValueInList(accumulatedValues); 

            //part two
            return GetTotalThreeHighestValueInList(accumulatedValues).ToString();
        }

       
        private List<int> AccumulateValuesIntoList()
        {
            String line = "";
            List<int> accumulatedValues = new List<int>();

            int totalForCurrent = 0;

            while (!input.EndOfStream)
            {
                line = input.ReadLine();
                if (line == "")
                {
                    accumulatedValues.Add(totalForCurrent);
                    totalForCurrent = 0;
                }
                else
                {
                    totalForCurrent += Int32.Parse(line);

                }

            }
            
            if (line != "")
            {
                accumulatedValues.Add(totalForCurrent);
            }
            return accumulatedValues;
        }

        private int GetTotalThreeHighestValueInList(List<int> accumulatedValues)
        {
            int highestThreeValuesCombined = 0;

            accumulatedValues.Sort();
            accumulatedValues.Reverse();

            for (int i = 0; i < accumulatedValues.Count; i++)
            {
              
                if (i > 2)
                {
                    break;
                }

                highestThreeValuesCombined += accumulatedValues[i];
            }

            return highestThreeValuesCombined;
        }


        private int GetHighestValueInList(List<int> accumulatedValues)
        {
            int highestValue = 0;

            for (int i = 0; i < accumulatedValues.Count; i++)
            {
                if (accumulatedValues[i] > highestValue)
                {
                    highestValue = accumulatedValues[i];
                }
            }

            return highestValue;
        }

    }
}
