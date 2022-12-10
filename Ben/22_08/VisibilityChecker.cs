using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_08
{
    class VisibilityChecker
    {
        public bool IsCoOrdinateVisible(int x, int y, string[] trees)
        {
            bool isVisible = false;

            isVisible = IsTreeOnAnEdge(x, y, trees);
           
            if (!isVisible)
            {
                isVisible = IsTreeOVisibleFromLeft(x, y, trees) ||
                            IsTreeOVisibleFromRight(x, y, trees) ||
                            IsTreeOVisibleFromFront(x, y, trees) ||
                            IsTreeOVisibleFromBack(x, y, trees);
            }

            return isVisible;
        }

       

        private bool IsTreeOnAnEdge(int x, int y, string[] trees)
        {
            return IsTreeOnLeftSide(x) ||
                   IsTreeOnRightSide(x, y, trees) ||
                   IsTreeOnTopSide(y) ||
                   IsTreeOnBottomSide(y, trees);
        }

        private bool IsTreeOnLeftSide(int x)
        {
            return (x == 0);
        }
        private bool IsTreeOnRightSide(int x, int y, string[] trees)
        {
            return (x == trees[y].Length - 1);
        }
        private bool IsTreeOnTopSide(int y)
        {
            return (y == 0);
        }
       private bool IsTreeOnBottomSide(int y, string[] trees)
        {
            return (y == trees.Length -1);
        }

        private bool IsTreeOVisibleFromLeft(int x, int y, string[] trees)
        {
            char treeHeightChar =  trees[y][x];
            int treeHeight = Int32.Parse(treeHeightChar.ToString());

            for (int i = 0; i < x; i++)
            {
                char heightOfTreeToLeftChar = trees[y][i];
                int heightOfTreeToLeft = Int32.Parse(heightOfTreeToLeftChar.ToString());

                if (heightOfTreeToLeft >= treeHeight)
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsTreeOVisibleFromRight(int x, int y, string[] trees)
        {
            char treeHeightChar = trees[y][x];
            int treeHeight = Int32.Parse(treeHeightChar.ToString());

            for (int i = x+1; i < trees[y].Length; i++)
            {
                char heightOfTreeToRightChar = trees[y][i];
                int HeightOfTreeToRight = Int32.Parse(heightOfTreeToRightChar.ToString());

                if (HeightOfTreeToRight >= treeHeight)
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsTreeOVisibleFromFront(int x, int y, string[] trees)
        {
            char treeHeightChar = trees[y][x];
            int treeHeight = Int32.Parse(treeHeightChar.ToString());

            for (int i = 0; i < y; i++)
            {
                char heightOfInFrontTreeChar = trees[i][x];
                int heightOfInFrontTree = Int32.Parse(heightOfInFrontTreeChar.ToString());

                if (heightOfInFrontTree >= treeHeight)
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsTreeOVisibleFromBack(int x, int y, string[] trees)
        {
            Array.Reverse(trees);
            int reverseY = trees.Length - y;
          
            return IsTreeOVisibleFromFront(x, reverseY, trees);
        }
    }
    
}
