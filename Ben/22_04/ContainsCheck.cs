using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_04
{
    public  class ContainsCheck
    {
        string[] firstRange;
        string[] secondRange;

        public bool DoesOneStringContainTheOther(string stringOne, string stringTwo)
        {
            if (stringOne.Length > stringTwo.Length)
            {
                return stringOne.Contains(stringTwo);
            }
            else
            {
                return stringTwo.Contains(stringOne);
            }
        }

        public bool DoesOnenumberRangeContainTheOther(string numberRangeOne, string numberRangeTwo)
        {
            GetRanges(numberRangeOne, numberRangeTwo);

            return (FirstRangeContainsSecond(firstRange, secondRange) |
                    SecondRangeContainsFirst(firstRange, secondRange));        
        }

        public bool DoNumberRangesOverlap(string numberRangeOne, string numberRangeTwo)
        {
            GetRanges(numberRangeOne, numberRangeTwo);

            return  (Int32.Parse(firstRange[1]) >= Int32.Parse(secondRange[0]) &
                     Int32.Parse(firstRange[0]) <= Int32.Parse(secondRange[1]));
        }

        private void GetRanges(string numberRangeOne, string numberRangeTwo)
        {
            firstRange = numberRangeOne.Split('-');
            secondRange = numberRangeTwo.Split('-');
        }

        private bool FirstRangeContainsSecond(string[] firstRange, string[] secondRange)
        {
            return (Int32.Parse(firstRange[0]) <= Int32.Parse(secondRange[0]) &
                    Int32.Parse(firstRange[1]) >= Int32.Parse(secondRange[1]));
        }

        private bool SecondRangeContainsFirst(string[] firstRange, string[] secondRange)
        {
            return (Int32.Parse(secondRange[0]) <= Int32.Parse(firstRange[0]) &
                    Int32.Parse(secondRange[1]) >= Int32.Parse(firstRange[1]));
        }
    }

   
        
}
