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
            }

            //draw
            if (resultToFixTo == 'Y')
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
            }
                
            //WINS
             if (resultToFixTo == 'Z')
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
            }
            return 'Q';
        }
    }
}
