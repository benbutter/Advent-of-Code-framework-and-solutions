using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_09
{
    public class MovementOrchestartor
    {
        //if were adjacent 
        //no gap stay where are - now diagonl
        //is gap move to space opposite to the direction - if H moved R now on L of it still adjacent
        //if were diagonal
        //no gap stay where are - now adjacent
        //is gap move to space opposite to the direction - if H moved R now on L of it now adjacent

        //need to check for gaps and on top of.

        //state patter? - 3 states, on top of, adjacnet, diagonal - think thats it.
       // public ITailMover myTailMover;
        public Knot myHead;
      //  public Knot myTail;
    //    public AdjacentTailMover myAdjecentTailMover;
     //   public DiagonalTailMover myDiagonalTailMover;
      //  public OnTopOfTailMover myOnTopOfMover;
        public CurrentPositionFinder myPositionFinder;
        public List<Knot> allKnots;
        public MovementOrchestartor()
        {
            InitialSetup();
        }
        public MovementOrchestartor(int numberOfKnots)
        {
            InitialSetup();

            for (int i = 0; i < numberOfKnots; i++)
            {
                Knot newKnot = new Knot();
                allKnots.Add(newKnot);
                if (i==0)
                {
                    myHead = newKnot;
                }
                newKnot.myMover = this;
            }
        }
        private void InitialSetup()
        {
            myHead = new Knot();
         //   myTail = new Knot();
           // myAdjecentTailMover = new AdjacentTailMover();
            //myAdjecentTailMover.SetMover(this);
            //myDiagonalTailMover = new DiagonalTailMover();
            //myDiagonalTailMover.SetMover(this);
            //myOnTopOfMover = new OnTopOfTailMover();
            //myOnTopOfMover.SetMover(this);
            //myTailMover = myOnTopOfMover;
            myPositionFinder = new CurrentPositionFinder();
            allKnots = new List<Knot>();
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

            Knot previousKnot = myHead;
            foreach (var currentKnot in allKnots)
            {
                if (currentKnot == myHead)
                {
                    previousKnot = currentKnot;
                }
                else
                {
                    MoveKnot(direction, previousKnot, currentKnot);
                    previousKnot = currentKnot;
                }
            }
            
        }

        public void MoveKnot(char direction, Knot previousKnot, Knot currentKnot)
        {
            //need to check if now on top of each other - if so emergency intervention of state

            if (myPositionFinder.AreOnTopOfEachOther(previousKnot.positionX, previousKnot.positionY,
                                                     currentKnot.positionX, currentKnot.positionY))
            {
               currentKnot.myTailMover = currentKnot.myOnTopOfMover;
            }
            else
            {
               currentKnot.myTailMover.Move(direction);
            }
            currentKnot.RecordCurrentPosition();
            WriteDetails(direction, previousKnot,currentKnot);
        }
        private void WriteDetails(char direction, Knot previousKnot, Knot currentKnot)
        {
            Console.WriteLine(direction.ToString() + " " +
                              "Head " + previousKnot.positionX + "," + previousKnot.positionY +
                              " Tail " + currentKnot.positionX + "," + currentKnot.positionY);
        }

        public bool IsAGap(Knot currentKnot)
        {
            int indexForPrev = allKnots.IndexOf(currentKnot) -1;
            Knot previousKnot = allKnots[indexForPrev];
           
            return myPositionFinder.IsAGap(previousKnot.positionX,
                                            previousKnot.positionY,
                                            currentKnot.positionX,
                                            currentKnot.positionY);
        }

        public void PositionTailAdjacentToHeade(char directionHeadMoved, Knot currentKnot)
        {
            int indexForPrev = allKnots.IndexOf(currentKnot) - 1;
            Knot previousKnot = allKnots[indexForPrev];

            if (directionHeadMoved == 'U')
            {
                currentKnot.positionY = previousKnot.positionY - 1;
                currentKnot.positionX = previousKnot.positionX;
            }
            if (directionHeadMoved == 'D')
            {
                currentKnot.positionY = previousKnot.positionY + 1;
                currentKnot.positionX = previousKnot.positionX;
            }
            if (directionHeadMoved == 'R')
            {
                currentKnot.positionX = previousKnot.positionX - 1;
                currentKnot.positionY = previousKnot.positionY;
            }
            if (directionHeadMoved == 'L')
            {
                currentKnot.positionX = previousKnot.positionX + 1;
                currentKnot.positionY = previousKnot.positionY;
            }
        }
    }
}
