using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2022._22_02
{
    class Solver22_02 : ISolver
    {
        StreamReader input;
        public void SetInput(StreamReader streamReader)
        {
            input = streamReader;
        }

        public int GetSolution()
        {
            string line;
            int score = 0;
            var scorer = new RockPaperScissorScorer();

            while (!input.EndOfStream)
            {
                line = input.ReadLine();
                score += scorer.GetScoreForRound(line[0], line[2]);
            }
            return score;
        }
    }
}
