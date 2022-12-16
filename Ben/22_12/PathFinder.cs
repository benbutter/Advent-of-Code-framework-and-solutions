using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AOC_2022._22_12
{
    class PathFinder
    {
        //if multiple options preference is u,r,d,l

        List<string> previousPaths = new List<string>();
        public List<string> map;

        string currentPath;
        // int currentX = 0;
        //int currentY = 0;
        Point currentPoint = new Point();
        public  List<Point> allPoints = new List<Point>();
        string lastDirectionMoved;
        int[] options = new int[4];
        public void AttemptPath()
        {
           
            while (true)
            {
                var options = GetOptions();

                int bestOption = GetBestOption(options);

                Point recordPoint = new Point();
                recordPoint.X = currentPoint.X;
                recordPoint.Y = currentPoint.Y;
                allPoints.Add(recordPoint);
                if (bestOption == 0)
                {
                    MoveUp();
                }

                else if (bestOption == 1)
                {
                    MoveRight();
                }
                else if (bestOption == 2)
                {
                    MoveLeft();
                }
                else if (bestOption == 3)
                {
                    MoveDown();
                }

                if (map[currentPoint.Y][currentPoint.X] == 'E')
                {
                    return;
                }
            }
        }

        private void MoveDown()
        {
            currentPoint.Y++;
            lastDirectionMoved = "down";
        }

        private void MoveLeft()
        {
            currentPoint.X--;
            lastDirectionMoved = "left";
        }

        private void MoveRight()
        {
            currentPoint.X++;
            lastDirectionMoved = "right";
        }

        private void MoveUp()
        {
            currentPoint.Y--;
            lastDirectionMoved = "up";
        }

        public int GetBestOption(char[] options)
        {

            //check if finished 
            foreach (var c in options)
            {
                if (c == 'E')
                return Array.IndexOf(options, c);
            }
            char currentChar = map[currentPoint.Y][currentPoint.X];
            int currentValue = char.ToUpper(currentChar) - 64;
            // char[] optionsSorted = (char[])options.Clone(); 
            // Array.Sort(optionsSorted);
            //Array.Reverse(optionsSorted);
            char bestOption = '.';
            foreach (var c in options)
            {
               if ((char.ToUpper(c) - 64) - currentValue < 2)
                {
                    if (bestOption == '.')
                    {
                        bestOption = c;
                    }
                    if ((char.ToUpper(c) - 64) > (char.ToUpper(bestOption) - 64))
                    {
                        bestOption = c;
                    }
                   // return Array.IndexOf(options, c);
                }
            }

            return Array.IndexOf(options, bestOption);
        }
        public char[] GetOptions()
        {
            char[] options = new char[4];
            //Get up option
            if ((currentPoint.Y > 0) && (lastDirectionMoved != "down"))
            {
                options[0] = map[currentPoint.Y - 1][currentPoint.X];
            }
            //Get Right option
            if ((currentPoint.X < map[currentPoint.Y].Length) && (lastDirectionMoved != "left"))
            {
                options[1] = map[currentPoint.Y][currentPoint.X + 1];
            }
            //Get Down Option
            if ((currentPoint.Y < map.Count) && (lastDirectionMoved != "up"))
            {
                options[2] = map[currentPoint.Y + 1][currentPoint.X];
            }
            //Get Left Option
            if ((currentPoint.X > 0) && (lastDirectionMoved != "right"))
            {
                options[3] = map[currentPoint.Y][currentPoint.X - 1];
            }

            return options;
        }
    }
}
