﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AOC_2022._22_09
{
    class Solver22_09 : ISolver
    {
        StreamReader input;
        public void SetInput(StreamReader streamReader)
        {
            input = streamReader;
        }
        public string GetSolution()
        {
            string line;
            char direction;
            int numberOfCommands;
            MovementOrchestartor orchestartor = new MovementOrchestartor();

            while (!input.EndOfStream)
            {
                line = input.ReadLine();
                direction = line[0];
                numberOfCommands = Int32.Parse( line.Substring(2, line.Length -2));

                //   Console.WriteLine(direction);
                // Console.WriteLine(numberOfCommands);
                for (int i = 0; i < numberOfCommands; i++)
                {
                    if (direction == 'L')
                    {
                        var a = "a";
                    }
                    orchestartor.MoveHead(direction);
                }
              
            }

            List<string> distinctPositions = orchestartor.myTail.allPositionsVisited.Distinct().ToList();

            foreach (var item in distinctPositions)
            {
         //       Console.WriteLine(item);
            }
            return distinctPositions.Count.ToString();
        }

       
    }
}
