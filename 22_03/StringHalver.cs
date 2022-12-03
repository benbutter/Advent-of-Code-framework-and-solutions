using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_03
{
    public class StringHalver
    {
        public string[] HalveString(string stringToHalf)
        {
            string[] halves = new string[2];
            halves[0] = stringToHalf.Substring(0, stringToHalf.Length / 2);
            halves[1] = stringToHalf.Substring(stringToHalf.Length / 2, stringToHalf.Length / 2);
            return halves;
        }
    }
}
