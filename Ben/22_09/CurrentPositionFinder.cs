using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_09
{
    public class CurrentPositionFinder
    {
        
        public const int onTopOf = 1;
        public const int adjecent = 2;
        public const int diagonal = 3;

        public int GetCurrentRelativePos(int headx, int heady, int tailx, int taily)
        {
            if ( AreOnTopOfEachOther(headx,heady,tailx,taily))
            {
                return 1;
            }

            return 0;
        }

        public bool IsAGap(int headx, int heady, int tailx, int taily)
        {
            return Math.Abs(headx - tailx) >= 2 || Math.Abs(heady-taily) >= 2;
        }

        public bool AreOnTopOfEachOther(int headx, int heady, int tailx, int taily)
        {
            return (headx == tailx && heady == taily);
        }
    }
}
