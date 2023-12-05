using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_2022._23_03
{
    public class Solver23_03Ben : ISolver
    {
        Dictionary<Int32, Point> pointsNextToSymbols;
        int total = 0;
        int x = 0;
        int y = 0;
        public Solver23_03Ben()
        {
                pointsNextToSymbols = new Dictionary<Int32, Point>();
        }

        public string GetSolution(StreamReader streamReader)
        {
            //fill adjacentpoints with all next to symbols
            int currentNumber = 0;
            while (!streamReader.EndOfStream)
            {
                var line = streamReader.ReadLine();
                x = 0;
                foreach (var character in line)
                {
                    if (!Int32.TryParse(character.ToString(), out currentNumber))
                    {
                        if (character != '.')
                        {
                            Point symbolPoint = new Point(x,y);
                            pointsNextToSymbols.Add(symbolPoint.GetHashCode(), symbolPoint); //not needed?

                            AddAdjacentPoints(symbolPoint);
                        }
                    }
                    x++;
                }
                y++;
            }


            ResetReader(streamReader);
            x = 0;
            y = 0;
            string nbrString = "" ;
            List<Point> pointsToCheck = new List<Point>();

            while (!streamReader.EndOfStream)
            {

                var line = streamReader.ReadLine();
                x = 0;
                

                foreach (var character in line)
                {
                    if (Int32.TryParse(character.ToString(), out currentNumber))
                    {
                        nbrString = nbrString + character.ToString();
                        Point point = new Point(x,y);
                        pointsToCheck.Add(point);
                    }

                    else //not a number so check the number we built (if any or just keep on keeping on
                    {
                        nbrString = DealWithEndOfNbrString(nbrString, pointsToCheck);
                    }
                    x++;
                }
                DealWithEndOfNbrString(nbrString, pointsToCheck);
                y++;
            }

            return total.ToString();
        }

        private string DealWithEndOfNbrString(string nbrString, List<Point> pointsToCheck)
        {
            if (nbrString.Length > 0)
            {
                foreach (var item in pointsToCheck)
                {
                    if (pointsNextToSymbols.ContainsKey(item.GetHashCode()))
                    {
                        total = total + Int32.Parse(nbrString);
                        nbrString = "";
                        pointsToCheck.Clear();
                        return nbrString;
                    }
                }

            }
            pointsToCheck.Clear();
            return nbrString;
        }

        public void AddAdjacentPoints(Point symbolPoint) 
        {
            //adjecentLeft
            Point point = new Point(symbolPoint.X -1, symbolPoint.Y);
            AddWithCheck(point);

            //adjecentRight
            Point point1 = new Point(symbolPoint.X + 1, symbolPoint.Y);
            AddWithCheck(point1);

            //above
            Point point2 = new Point(symbolPoint.X , symbolPoint.Y-1);
            AddWithCheck(point2);

            //below
            Point point3 = new Point(symbolPoint.X, symbolPoint.Y +1);
            AddWithCheck(point3);

            //above left
            Point point4 = new Point(symbolPoint.X - 1, symbolPoint.Y-1);
            AddWithCheck(point4);

            //adjecentRight
            Point point5 = new Point(symbolPoint.X + 1, symbolPoint.Y -1);
            AddWithCheck(point5);

            //belowLeft
            Point point6 = new Point(symbolPoint.X - 1, symbolPoint.Y +1);
            AddWithCheck(point6);

            //belowRight
            Point point7 = new Point(symbolPoint.X + 1, symbolPoint.Y+1);
            AddWithCheck(point7);
        }

        private void AddWithCheck(Point point)
        {
            try
            {
                pointsNextToSymbols.Add(point.GetHashCode(),point);
            }
            catch 
            { 
                //just chill
             }
        }

        private static void ResetReader(StreamReader reader)

        {
            reader.DiscardBufferedData();
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
        }
    }
}
