using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2022._22_15
{
    public class Solver22_15 : ISolver
    {
        List<Sensor> allSensors = new List<Sensor>();
        StreamReader input;
        // const int RowToCheck = 10;
        const int RowToCheck = 2000000;
        public void SetInput(StreamReader streamReader)
        {
            input = streamReader;
        }
        public string GetSolution()
        {
            ReadFileToCreateSensors();

            PointHolder holder = CreatePointsCoveredBySensorOnRowToCheck();

            DedupeBeaconPointsFromPointsCovered(holder);

            return holder.points.Count.ToString();
        }

        private void DedupeBeaconPointsFromPointsCovered(PointHolder holder)
        {
            holder.DeDupeBeacons(allSensors);
        }

        private PointHolder CreatePointsCoveredBySensorOnRowToCheck()
        {
            PointHolder holder = new PointHolder();
            foreach (var sensor in allSensors)
            {
                var pointsCovered = sensor.GetPointsCoveredInRow(RowToCheck);

                foreach (var itpointCoveredem in pointsCovered)
                {
                       holder.points.Add(itpointCoveredem);
                }
            }

            return holder;
        }

        private void ReadFileToCreateSensors()
        {
            while (!input.EndOfStream)
            {
                string line = input.ReadLine();
                Sensor sensor = new Sensor(line);
                allSensors.Add(sensor);
            }
        }
    }
}
