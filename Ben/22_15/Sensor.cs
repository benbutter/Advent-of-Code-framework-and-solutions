using System;
using System.Collections.Generic;
using System.Drawing;

namespace AOC_2022._22_15
{
    public class Sensor
    {
        public int x;
        public int y;
        public int beaconx;
        public int beacony;

        public Sensor(string stringIn)
        {
            string[] split = stringIn.Split(":");

            string[] sensorSplit = split[0].Split(",");

            x = GetCoordinates(sensorSplit[0], "x=");
            y = GetCoordinates(sensorSplit[1], "y=");

            string[] beaconSplit = split[1].Split(",");
            beaconx = GetCoordinates(beaconSplit[0], "x=");
            beacony = GetCoordinates(beaconSplit[1], "y=");
        }

        public int GetRange()
        {
            return Math.Abs(x - beaconx) + Math.Abs(y - beacony);
        }
        private int GetCoordinates(string stringIn, string CharToGet)
        {
            int pos = stringIn.IndexOf(CharToGet);
            int coordinate = Int32.Parse(stringIn.Substring(pos + CharToGet.Length));
            return coordinate;
        }

        public List<Point> GetPointsCoveredInRow(int row)
        {
            List<Point> pointsCovered = new List<Point>();
            //Work out how far away the row is vertically
            int yDistance = Math.Abs(y - row);
            int xRange = GetRange() - yDistance;

            CreatePointsThatCanBeCoveredOnX(xRange, row, pointsCovered);

            return pointsCovered;
        }

        private void CreatePointsThatCanBeCoveredOnX(int xRange, int row, List<Point> pointsCovered)
        {
            for (int i = 0; i <= xRange; i++)
            {
                Point newPoint = new Point();
                newPoint.Y = row;
                newPoint.X = x + i;
                pointsCovered.Add(newPoint);

                //and the negative one
                Point newNegPoint = new Point();
                newNegPoint.Y = row;
                newNegPoint.X = x - i;
                pointsCovered.Add(newNegPoint);
            }

        }
    }
}