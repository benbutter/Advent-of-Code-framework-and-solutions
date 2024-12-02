using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_2022._23_07
{
    internal class Hand
    {
        public string value {  get; set; }
        public int category {  get;  }

        public const int FiveOfAKind = 7;
        public const int FourOfAKind = 6;
        public const int FullHouse = 5;
        public const int ThreeOfAKind = 4;
        public const int TwoPair = 3;
        public const int OnePair = 2;
        public const int HighCard = 1;


        public Hand(string _value) 
        {
            value = _value;
            category = DetermineCategory();
        }   

        private int DetermineCategory()
        {
            Dictionary<char,int> dic = new Dictionary<char,int>();
            int currentCount = 0;
            foreach (char c in value)
            {
                dic.TryGetValue(c, out currentCount);

                dic[c] = currentCount + 1;
            }
            
            if (dic[value[0]] == 5 )
            {
                return FiveOfAKind;
            }

            if (dic[value[0]] == 4  || dic[value[1]] == 4)
            {
                    return FourOfAKind;
            }

          //  if (dic.Count == 2 d[0] == 3 & dic[1] == 2)
            //{
              //  return FullHouse;

            //}
            if (dic[value[0]] == 2 & dic[value[1]] == 3)
            {
                return FullHouse;
            }
        
            if ((dic.Count == 3 && (dic[value[0]] ==3 || dic[value[1]] == 3) || dic[value[2]] == 3))
                    {
                return ThreeOfAKind;
            }
           

       
            return 0;
            
        }

    }
}
