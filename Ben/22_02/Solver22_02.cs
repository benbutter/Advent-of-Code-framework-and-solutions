using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2022._22_02
{
    public class Solver22_02 : ISolver
    {
        StreamReader input;
        public void SetInput(StreamReader streamReader)
        {
            input = streamReader;
        }

        public string GetSolution()
        {
            string line;
            int score = 0;
            var scorer = new RockPaperScissorScorer();
            var fixer = new RockPaperScissorFixer();
            char choiceToFix;

            while (!input.EndOfStream)
            {
                line = input.ReadLine();
                //part 1
                //  score += scorer.GetScoreForRound(line[0], line[2]); //part 1

                //part 2
                choiceToFix = fixer.GetOptionToFixResult(line[0], line[2]);

                score += scorer.GetScoreForRound(line[0], choiceToFix);
            }
            return score.ToString();
        }
    }
}
