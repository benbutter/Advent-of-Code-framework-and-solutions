using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_09
{
    class MovementOrchestartor
    {
        //if were adjacent 
        //no gap stay where are - now diagonl
        //is gap move to space opposite to the direction - if H moved R now on L of it still adjacent
        //if were diagonal
        //no gap stay where are - now adjacent
        //is gap move to space opposite to the direction - if H moved R now on L of it now adjacent

        //need to check for gaps and on top of.

        //state patter? - 3 states, on top of, adjacnet, diagonal - think thats it.
        public ITailMover myTailMover;
        public Head myHead;
        public Tail myTail;
        public AdjacentTailMover myAdjecentTailMover;
        public DiagonalTailMover myDiagonalTailMover;
        public OnTopOfTailMover myOnTopOfMover;
        public CurrentPositionFinder myPositionFinder;
        public MovementOrchestartor()
        {
            myHead = new Head();
            myTail = new Tail();
            myAdjecentTailMover = new AdjacentTailMover();
            myAdjecentTailMover.SetMover(this);
            myDiagonalTailMover = new DiagonalTailMover();
            myDiagonalTailMover.SetMover(this);
            myOnTopOfMover = new OnTopOfTailMover();
            myOnTopOfMover.SetMover(this);
            myTailMover = myOnTopOfMover;
            myPositionFinder = new CurrentPositionFinder();
        }

        public void MoveHead(char direction)
        {
            if (direction == 'U')
            {
                myHead.positionY++;
            }
            if (direction == 'D')
            {
                myHead.positionY--;
            }
            if (direction == 'R')
            {
                myHead.positionX++;
            }
            if (direction == 'L')
            {
                myHead.positionX--;
            }
            //need to check if now on top of each other - if so emergency intervention of state
            if (myPositionFinder.AreOnTopOfEachOther(myHead.positionX, myHead.positionY,
                                                      myTail.positionX, myTail.positionY))
            {
                myTailMover = myOnTopOfMover;
            }
            else
            {
                myTailMover.Move(direction);
            }
            myTail.RecordCurrentPosition();
            WriteDetails(direction);
        }

        private void WriteDetails(char direction)
        {
            Console.WriteLine(direction.ToString() + " " +
                              "Head " + myHead.positionX + "," + myHead.positionY +
                              " Tail " + myTail.positionX + "," + myTail.positionY);
        }

        public bool IsAGap()
        {
            return myPositionFinder.IsAGap(myHead.positionX,
                                            myHead.positionY,
                                            myTail.positionX,
                                            myTail.positionY);
        }

        public void PositionTailAdjacentToHeade(char directionHeadMoved)
        {
            if (directionHeadMoved == 'U')
            {
                myTail.positionY = myHead.positionY - 1;
                myTail.positionX = myHead.positionX;
            }
            if (directionHeadMoved == 'D')
            {
                myTail.positionY = myHead.positionY + 1;
                myTail.positionX = myHead.positionX;
            }
            if (directionHeadMoved == 'R')
            {
                myTail.positionX = myHead.positionX - 1;
                myTail.positionY = myHead.positionY;
            }
            if (directionHeadMoved == 'L')
            {
                myTail.positionX = myHead.positionX + 1;
                myTail.positionY = myHead.positionY;
            }
        }
    }
}
