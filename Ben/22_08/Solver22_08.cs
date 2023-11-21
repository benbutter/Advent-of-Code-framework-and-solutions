using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2022._22_08
{
    public class Solver22_08 : ISolver
    {
        StreamReader input;
        public void SetInput(StreamReader streamReader)
        {
            input = streamReader;
        }
        public string GetSolution()
        {
   
            List<string> listOfTrees = new List<string>();
            
            while (!input.EndOfStream)
            {
                listOfTrees.Add(input.ReadLine());
            }

            string[] arrayOfTrees = new string[listOfTrees.Count];

            listOfTrees.CopyTo(arrayOfTrees);

            //  return ArrayReader(arrayOfTrees); //part 1

            //part 2
            return GetTopScenicScore(arrayOfTrees);
        }

        public  string ArrayReader( string[] arrayOfTrees)
        {
            int count = 0;
            VisibilityChecker checker = new VisibilityChecker();
            string line;

            for (int i = 0; i < arrayOfTrees.Length; i++)
            {
                line = arrayOfTrees[i];

                for (int j = 0; j < line.Length; j++)
                {
                    if (checker.IsCoOrdinateVisible(j, i, arrayOfTrees))
                    {
                        count++;
                    }
                }
            }
            return count.ToString();
        }

        public string GetTopScenicScore(string[] arrayOfTrees)
        {
            int topScenicScore = 0;
            int currentScenicScore;
            string line;

            ScenicScoreCalc calc = new ScenicScoreCalc();
            for (int i = 0; i < arrayOfTrees.Length; i++)
            {
                line = arrayOfTrees[i];

                for (int j = 0; j < line.Length; j++)
                {
                    currentScenicScore = calc.GetScenicScore(j, i, arrayOfTrees);
                    if (currentScenicScore > topScenicScore)
                    {
                        topScenicScore = currentScenicScore;
                    }
                }
            }
            return topScenicScore.ToString();
        }
    }
}
