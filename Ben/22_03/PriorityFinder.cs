using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_03
{
    public class PriorityFinder
    {
        public int GetPriority(char characterToPrioritise)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            char gauranteedLowerCaseChar = Char.ToLower(characterToPrioritise);

            if (Char.IsLower(characterToPrioritise))
            {
                return alphabet.IndexOf(gauranteedLowerCaseChar) + 1 ;
            }
            else
            {
                return alphabet.IndexOf(gauranteedLowerCaseChar) + 1 + 26;
            }
           
        }
    }
}
