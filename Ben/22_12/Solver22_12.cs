using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2022._22_12
{
    public class Solver22_12 :ISolver
    {
       

        public string GetSolution(StreamReader input)
        {
            List<string> map = new List<string>();

            while (!input.EndOfStream)
            {
                map.Add(input.ReadLine());
            }

            PathFinder pathFinder = new PathFinder();
            pathFinder.map = map;

            pathFinder.AttemptPath();

            return pathFinder.allPoints.Count.ToString();
        }


        
        

    }
}
