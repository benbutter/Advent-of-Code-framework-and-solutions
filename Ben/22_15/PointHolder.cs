using System.Collections.Generic;
using System.Drawing;

namespace AOC_2022._22_15
{
     class PointHolder
    {
        public HashSet<Point> points = new HashSet<Point>();

        public void DeDupeBeacons(List<Sensor> beacons)
        {
            List<Point> pointsToRemove = new List<Point>();

            foreach (var beacon in beacons)
            {
                foreach (var point in points)
                {
                    if (beacon.beaconx == point.X   && beacon.beacony == point.Y)
                    {
                        pointsToRemove.Add(point);
                    }
                }
            }

            foreach (var pointToRemove in pointsToRemove)
            {
                points.Remove(pointToRemove);
            }
        }

    }
}