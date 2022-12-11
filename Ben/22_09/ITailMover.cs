using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_09
{
    public interface ITailMover
    {
        public void SetMover(MovementOrchestartor mover);

        public void SetKnot(Knot knot);

        public void Move(char direction);
    }
}
