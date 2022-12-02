using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_02
{
    class RockPaperScissorFixer
    {
        public char GetOptionToFixResult(char opponetsGo, char resultToFixTo)
        {

            //LOSE
            if (resultToFixTo == 'X')
            {
                return GetChoiceIfFixingLoss(opponetsGo);
            }

            //draw
            if (resultToFixTo == 'Y')
            {
                return GetChoiceIfFixingDraw(opponetsGo);
            }
                
            //WINS
             if (resultToFixTo == 'Z')
            {
                return GetChoiceIfFixingWin(opponetsGo);
            }
            return ' ';
        }
        private char GetChoiceIfFixingLoss(char opponetsGo)
        {
            if (opponetsGo == 'A')
            {
                return 'Z';
            }
            if (opponetsGo == 'B')
            {
                return 'X';
            }
            if (opponetsGo == 'C')
            {
                return 'Y';
            }
            return ' ';
        }

        private char GetChoiceIfFixingDraw(char opponetsGo)
        {
            if (opponetsGo == 'A')
            {
                return 'X';
            }
            if (opponetsGo == 'B')
            {
                return 'Y';
            }
            if (opponetsGo == 'C')
            {
                return 'Z';
            }
            return ' ';
        }

        private char GetChoiceIfFixingWin(char opponetsGo)
        {
            if (opponetsGo == 'A')
            {
                return 'Y';
            }

            if (opponetsGo == 'B')
            {
                return 'Z';
            }

            if (opponetsGo == 'C')
            {
                return 'X';
            }
            return ' ';
        }
    }
}
