using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_09
{
    class OnTopOfTailMover : ITailMover
    {
        public MovementOrchestartor myMover;
        public void Move(char direction)
        {
            //do nothing except change state
            myMover.myTailMover = myMover.myAdjecentTailMover;
        }

        public void SetMover(MovementOrchestartor mover)
        {
            myMover = mover;
        }
    }
}
