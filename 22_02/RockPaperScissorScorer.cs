using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_02
{
    class RockPaperScissorScorer
    {
        public int GetScoreForRound(Char opponetsGo, Char yourGo)
        {
            int score = 0;

            score = GetPointsForResult(opponetsGo, yourGo);

            score += GetPointsForChoice(yourGo);

            return score;
        }

        private static int GetPointsForChoice(char yourGo)
        {
            int pointsForChoice = 0;
            if(yourGo == 'X')
            {
                pointsForChoice = 1;
            }
            else if (yourGo == 'Y')
            {
                pointsForChoice = 2;
            }
            else if (yourGo == 'Z')
            {
                pointsForChoice = 3;
            }
            return pointsForChoice;
        }

        private int GetPointsForResult(char opponetsGo, char yourGo)
        {
           
            if (WasAWin(opponetsGo, yourGo))
            {
                return 6;
            }

            if (WasDraw(opponetsGo, yourGo))
            {
                return 3;
            }

            return 0;
  
        }

        private bool WasAWin(char opponetsGo, char yourGo)
        {
            return (opponetsGo == 'A' & yourGo == 'Y') ||
              (opponetsGo == 'B' & yourGo == 'Z') ||
              (opponetsGo == 'C' & yourGo == 'X');
      
        }

        private bool WasDraw(char opponetsGo, char yourGo)
        {
            return (opponetsGo == 'A' & yourGo == 'X') ||
              (opponetsGo == 'B' & yourGo == 'Y') ||
              (opponetsGo == 'C' & yourGo == 'Z');

        }
    }
}
