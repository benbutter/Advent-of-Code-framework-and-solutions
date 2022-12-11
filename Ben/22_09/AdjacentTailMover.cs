using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_09
{
    public class AdjacentTailMover : ITailMover
    {
     //   public MovementOrchestartor myMover;
        public Knot myKnot;

        public void Move(char direction)
        {
          
            //is gap move to space opposite to the direction
            //- if H moved R now on L of it still adjacent
            if (myKnot.myMover.IsAGap(myKnot))
            {
                myKnot.myMover.PositionTailAdjacentToHeade(direction, myKnot);
            }
            else   //no gap stay where are - now diagonl
            {
                myKnot.myTailMover = myKnot.myDiagonalTailMover;
            }
        }

        public void SetKnot(Knot knot)
        {
            myKnot = knot;
        }

        public void SetMover(MovementOrchestartor mover)
        {
          //  myMover = mover;
        }
    }
}
