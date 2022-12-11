using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_09
{
    class AdjacentTailMover : ITailMover
    {
        public MovementOrchestartor myMover;

        public void Move(char direction)
        {
          
            //is gap move to space opposite to the direction
            //- if H moved R now on L of it still adjacent
            if (myMover.IsAGap())
            {
                myMover.PositionTailAdjacentToHeade(direction);
            }
            else   //no gap stay where are - now diagonl
            {
                myMover.myTailMover = myMover.myDiagonalTailMover;
            }
        }

        public void SetMover(MovementOrchestartor mover)
        {
            myMover = mover;
        }
    }
}
