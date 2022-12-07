using System;
using System.Collections.Generic;
using System.Text;

namespace _2021_1_Recap
{
    public  class ValueAnalyzer
    {
        int? previousValue = null;

        public bool IsValueHigherThanPrevious(int value)
        {
           

            if (previousValue == null)
            {
                previousValue = value;
                return false;
            }

            var result = value > previousValue;
            previousValue = value;
            return result;

        }

    }
}
