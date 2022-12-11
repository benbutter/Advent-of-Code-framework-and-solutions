using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_09
{
    public class Tail
    {
        public int positionX;
        public int positionY;

        public List<string> allPositionsVisited;

        public Tail()
        {
            allPositionsVisited = new List<string>();
            RecordCurrentPosition();
        }

        public void RecordCurrentPosition()
        {
            allPositionsVisited.Add(positionX + "," + positionY);
        }
    }
}
