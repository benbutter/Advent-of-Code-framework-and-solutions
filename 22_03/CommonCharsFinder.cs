using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_03
{
    public class CommonCharsFinder
    {
        public List<char> FindCommonChars(string firstString, string secondString)
        {
            List<char> results = new List<char>();
            char c;

            for (int i = 0; i < firstString.Length; i++)
            {
                c = firstString[i];

                for (int j = 0; j < secondString.Length; j++)
                {
                    if (c ==secondString[j])
                    {
                        
                        results.Add(c);
                        return results; //return when find first one

                    }
                }
            }
            return results;
        }
    }
}
