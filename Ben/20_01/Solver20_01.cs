using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_2022._20_01
{
    public class Solver20_01 : ISolver
    {
        public string GetSolution(StreamReader streamReader)
        {
            List<string> lines = new List<string>();
            List<string> lines2 = new List<string>();

            while (!streamReader.EndOfStream)
            {
                var line = streamReader.ReadLine();
                lines.Add(line);
                lines2.Add(line);
            }

           foreach (var line in lines)
            {
                foreach (var line2 in lines2)
                {
                    if (Int32.Parse(line2.Trim()) + Int32.Parse(line.Trim()) == 2020)
                    {
                        return (Int32.Parse(line2.Trim()) * Int32.Parse(line.Trim())).ToString();

                    }
                }
            }
            return "-1";
        }
    }
}
