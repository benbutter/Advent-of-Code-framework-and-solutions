using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_09
{
    public class DiagonalTailMover : ITailMover
    {
      //  public MovementOrchestartor myMover;
        public Knot myKnot;

        public void Move(char direction)
        {
         
            //is gap move to space opposite to the direction - if H moved R now on L of it now adjacent
            if (myKnot.myMover.IsAGap(myKnot))
            {
                myKnot.myMover.PositionTailAdjacentToHeade(direction,myKnot);
                myKnot.myTailMover = myKnot.myAdjecentTailMover;
            }
            else      //no gap stay where are - now adjacent
            {
                myKnot.myTailMover = myKnot.myAdjecentTailMover;
            }
        }

        public void SetMover(MovementOrchestartor mover)
        {
          //  myMover = mover;
        }

        public void SetKnot(Knot knot)
        {
            myKnot = knot;
        }
    }
}
