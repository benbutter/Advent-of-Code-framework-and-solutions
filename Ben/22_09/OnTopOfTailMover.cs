using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_09
{
   public class OnTopOfTailMover : ITailMover
    {
       // public MovementOrchestartor myMover;
        public Knot myKnot;
        public void Move(char direction)
        {
            //do nothing except change state
            myKnot.myTailMover = myKnot.myAdjecentTailMover;
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
