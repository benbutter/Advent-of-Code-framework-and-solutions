using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_09
{
    public class Knot
    {
        public int positionX;
        public int positionY;

        public List<string> allPositionsVisited;
        public ITailMover myTailMover;
        public Knot myHead;
        public Knot myTail;
        public AdjacentTailMover myAdjecentTailMover;
        public DiagonalTailMover myDiagonalTailMover;
        public OnTopOfTailMover myOnTopOfMover;
        public MovementOrchestartor myMover;

        public Knot()
        {
            allPositionsVisited = new List<string>();
            RecordCurrentPosition();

            myAdjecentTailMover = new AdjacentTailMover();
            myAdjecentTailMover.SetKnot(this);
            myDiagonalTailMover = new DiagonalTailMover();
            myDiagonalTailMover.SetKnot(this);
            myOnTopOfMover = new OnTopOfTailMover();
            myOnTopOfMover.SetKnot(this);
            myTailMover = myOnTopOfMover;

        }

        public void RecordCurrentPosition()
        {
            allPositionsVisited.Add(positionX + "," + positionY);
        }
    }
}
