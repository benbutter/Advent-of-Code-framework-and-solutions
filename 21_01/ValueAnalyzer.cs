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
                return false;
            }

            return true;

        }

    }
}
