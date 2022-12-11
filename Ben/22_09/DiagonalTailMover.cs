using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_09
{
    class DiagonalTailMover : ITailMover
    {
        public MovementOrchestartor myMover;


        public void Move(char direction)
        {
         
            //is gap move to space opposite to the direction - if H moved R now on L of it now adjacent
            if (myMover.IsAGap())
            {
                myMover.PositionTailAdjacentToHeade(direction);
                myMover.myTailMover = myMover.myAdjecentTailMover;
            }
            else      //no gap stay where are - now adjacent
            {
                myMover.myTailMover = myMover.myAdjecentTailMover;
            }
        }

        public void SetMover(MovementOrchestartor mover)
        {
            myMover = mover;
        }
    }
}
