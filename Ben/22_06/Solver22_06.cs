using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2022._22_06
{
    public class Solver22_06 : ISolver
    {
        string line;
        StreamReader input;
        UniqueChainFinder finder = new UniqueChainFinder();
        public void SetInput(StreamReader streamReader)
        {
            input = streamReader;
        }
        public string GetSolution()
        {
            while (!input.EndOfStream)
            {
                line = input.ReadLine();

                var array = line.ToCharArray();
                for (int i = 0; i < array.Length + 3; i++)
                {
                    // int end = i + 4; part 1
                    int end = i + 14; //part 2
                    var chars = array[i..end];
                    string charsStr = new string(chars);
                    
                    if (finder.ChainContainsOnlyUniqueChars(charsStr))
                    {
                        return (end).ToString();
                    }
                }
            }

            return "";
        }
    }
}
