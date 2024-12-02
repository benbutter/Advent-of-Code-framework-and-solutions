using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AOC_2022._24_07
{
    public class Solver24_01Ben : ISolver
    {
        public int intToMatchFromListOne;

        public string GetSolution(StreamReader streamReader)
        {

            List<int> listOne = new List<int>();
            List<int> listTwo = new List<int>();
            List<int> differences = new List<int>();
            int count = 0;

            PopulateBothLists(streamReader, listOne, listTwo);

            listOne.Sort();
            listTwo.Sort();

            //part 1
           // PopulateDifferences(listOne, listTwo, differences);

           // return differences.Sum().ToString();
            //part 2

            foreach (int i in listOne)
            {
                var matches = GetNumberOfMatches(i, listTwo);

                count = count + (i * matches);
            }

            return count.ToString();
        }

        private static void PopulateDifferences(List<int> listOne, List<int> listTwo, List<int> differences)
        {
            for (int i = 0; i < listOne.Count; i++)
            {
                differences.Add(Math.Abs((listOne[i] - listTwo[i])));
            }
        }

        private static int GetNumberOfMatches(int intToMatch, List<int> list)
        {
            //  intToMatchFromListOne = intToMatch;
            //List<int> Result = new List<int>(list.FindAll(Predicate));
            int count;
            count = 0;
            IEnumerable matches = list.Where(x => x == intToMatch);
            
            foreach (var match in matches)
            {
                count++;
            }
            return count;
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
