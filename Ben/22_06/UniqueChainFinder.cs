using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_06
{
    public class UniqueChainFinder
    {
        public bool ChainContainsOnlyUniqueChars(string stringToCheck)
        {
            for (int i = 0; i < stringToCheck.Length; i++)
            {
                for (int j = 0; j < stringToCheck.Length; j++)
                {
                    if (stringToCheck[i] == stringToCheck [j] & i != j)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
