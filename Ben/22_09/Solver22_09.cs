using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AOC_2022._22_09
{
    public class Solver22_09 : ISolver
    {
       
        public string GetSolution(StreamReader input)
        {
            string line;
            char direction;
            int numberOfCommands;
            MovementOrchestartor orchestartor = new MovementOrchestartor(10);

            while (!input.EndOfStream)
            {
                line = input.ReadLine();
                Console.WriteLine(line);
                direction = line[0];
                numberOfCommands = Int32.Parse( line.Substring(2, line.Length -2));

                //   Console.WriteLine(direction);
                // Console.WriteLine(numberOfCommands);
                for (int i = 0; i < numberOfCommands; i++)
                {
         /*           if (i == 1)
                    {
                        var a = "a";
                    }*/
                    orchestartor.MoveHead(direction);
                }
              
            }

            List<string> distinctPositions = orchestartor.allKnots.Last().allPositionsVisited.Distinct().ToList();

            foreach (var item in distinctPositions)
            {
         //       Console.WriteLine(item);
            }
            return distinctPositions.Count.ToString();
        }

       
    }
}
