using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_2022._24_07
{
    public class Solver24_01Ben : ISolver
    {
        public string GetSolution(StreamReader streamReader)
        {

            List<int> listOne = new List<int>();
            List<int> listTwo = new List<int>();
            List<int> differences = new List<int>();

            PopulateBothLists(streamReader, listOne, listTwo);

            listOne.Sort();
            listTwo.Sort();

            PopulateDifferences(listOne, listTwo, differences);

            return differences.Sum().ToString();
            
        }

        private static void PopulateDifferences(List<int> listOne, List<int> listTwo, List<int> differences)
        {
            for (int i = 0; i < listOne.Count; i++)
            {
                differences.Add(Math.Abs((listOne[i] - listTwo[i])));
            }
        }

        private  void PopulateBothLists(StreamReader streamReader, List<int> listOne, List<int> listTwo)
        {
            while (!streamReader.EndOfStream)
            {
                var line = streamReader.ReadLine();

                var splitLines = line.Split("  ");

                listOne.Add(Int32.Parse(splitLines[0].Trim()));

                listTwo.Add(Int32.Parse(splitLines[1].Trim()));
            }
        }
    }
}
