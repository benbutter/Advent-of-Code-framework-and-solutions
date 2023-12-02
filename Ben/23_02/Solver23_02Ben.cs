using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_2022._23_02
{
    internal class Solver23_02Ben : ISolver
    {
        Dictionary<string, int> colourTotal;
        List<int> validGames;
        int gameNumber;
        int total;
        public Solver23_02Ben()
        {
            colourTotal = new Dictionary<string, int>();

            colourTotal.Add("Blue", 0);
            colourTotal.Add("Red", 0);
            colourTotal.Add("Green", 0);

            validGames = new List<int>();

            gameNumber = 0;
            total = 0;
        }
        public string GetSolution(StreamReader streamReader)
        {
            while (!streamReader.EndOfStream)
            {
                var line = streamReader.ReadLine();
                gameNumber++;

                var reversedLine = line.Reverse();
                var splitLines = reversedLine.ToString().Split(" ");


            }

            return "0";
        }



        private void ResetTotals()
        {
            colourTotal["Blue"] = 0;
            colourTotal["Red"] = 0;
            colourTotal["Green"]= 0;
        }

        private bool IsGameVaid()
        {
            return  colourTotal["Blue"] <= 14 &
                    colourTotal["Red"] <= 12 &
                    colourTotal["Green"] <= 13;
        }
    }
}
