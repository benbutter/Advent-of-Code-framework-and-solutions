using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AOC_2022._22_13
{
    public class ListToCompareCreator
    {
        //this method will return a list of lists. Each list entry in the first list will be two lists of ints to compare.
        public List<PacketsToCompare> CreateListsToCompare(string packet1, string packet2)
        {
            string p1 = packet1.Substring(1);
            p1 = p1.Substring(0, p1.Length - 1);
            string p2 = packet2.Substring(1);
            p2 = p2.Substring(0, p2.Length - 1);

            List<string> p1List = new List<string>(p1.Split("]"));
            List<string> p2List = new List<string>(p2.Split("]"));

            // foreach (var item in p1Arr)
            FixupLisy(p1List);
            FixupLisy(p2List);
            // Console.WriteLine(p1 + " " + p2);*/
             List<PacketsToCompare> returnVal = new List<PacketsToCompare>();
           // returnVal.Add(p1List);
            //returnVal.Add(p2List);

            //get highest length
            int count = 0;
            if (p1List.Count > p2List.Count)
            {
                count = p2List.Count;
            }
            else
            {
                count = p2List.Count;
            }

            for (int i = 0; i < count; i++)
            {
                var packs = new PacketsToCompare();
                if ( i < p1List.Count)
                {
                    packs.packetOne = p1List[i];
                }
               
                if (i < p2List.Count)
                {
                    packs.packetTwo = p2List[i];
                }
                returnVal.Add(packs);
            }
            return returnVal;
        }

        private static void FixupLisy(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = list[i].Replace(']', ' ').Trim();
                list[i] = list[i].Replace('[', ' ').Trim();

                Regex r = new Regex("\\s+");
                list[i] = r.Replace(list[i], "");

                // = list[i].Replace(' ', "").Trim();
                if (list[i].Length == 0)
                {
                    list.RemoveAt(i); //might mess loop up?
                }
               
                else if (list[i][0] == ',')
                {
                    list[1] = list[1].Substring(1).Trim();
                }

              
            }
        }
    }
}
