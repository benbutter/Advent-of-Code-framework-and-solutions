using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_08
{
    class ScenicScoreCalc
    {
        public int GetScenicScore(int x, int y, string[] trees)
        {
            return GetScenicScoreToRight(x, y, trees) *
                    GetScenicScoreToLeft(x, y, trees) *
                    GetScenicScoreToFront(x, y, trees) *
                    GetScenicScoreToBack(x, y, trees);
        }
        public int GetScenicScoreToRight(int x, int y, string[] trees)
        {
            char treeHeightChar = trees[y][x];
            int treeHeight = Int32.Parse(treeHeightChar.ToString());
            int count =0;
            for (int i = x + 1; i < trees[y].Length; i++)
            {
                char heightOfTreeToRightChar = trees[y][i];
                int HeightOfTreeToRight = Int32.Parse(heightOfTreeToRightChar.ToString());
                count++;
                if (HeightOfTreeToRight >= treeHeight)
                {
                    return count;
                }
            }
            return count;
        }

        public int GetScenicScoreToLeft(int x, int y, string[] trees)
        {
            char treeHeightChar = trees[y][x];
            int treeHeight = Int32.Parse(treeHeightChar.ToString());
            int count = 0;

            for (int i = 0; i < x; i++)
            {
                char heightOfTreeToLeftChar = trees[y][i];
                int heightOfTreeToLeft = Int32.Parse(heightOfTreeToLeftChar.ToString());
                count++;
                if (heightOfTreeToLeft >= treeHeight)
                {
                    count = 1;;
                }
            }
            return count;
        }

        public int GetScenicScoreToFront(int x, int y, string[] trees)
        {
            char treeHeightChar = trees[y][x];
            int treeHeight = Int32.Parse(treeHeightChar.ToString());
            int count = 0;
            for (int i = 0; i < y; i++)
            {
                char heightOfInFrontTreeChar = trees[i][x];
                int heightOfInFrontTree = Int32.Parse(heightOfInFrontTreeChar.ToString());
                count++;
                if (heightOfInFrontTree >= treeHeight)
                {
                    count = 1;
                }
            }
            return count;
        }
        public int GetScenicScoreToBack(int x, int y, string[] trees)
        {
            Array.Reverse(trees);
            int reverseY = trees.Length - y - 1;

            var result = GetScenicScoreToFront(x, reverseY, trees);
            Array.Reverse(trees); 

            return result;
        }
    }
}
