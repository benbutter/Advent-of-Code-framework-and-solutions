using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_13
{
    public class PacketComparer
    {
        public bool ArePacketsInCorrectOrder(List<int> list1, List<int> list2)
        {
            bool result = true;
            int equalCount =0;
            int i = 0;
            // for (int i = 0; i > list1.Count; i++)
            foreach (var item in list1)
            {
                if (i==list2.Count)
                {
                    break;
                }
                if (list1[i] == list2[i])
                {
                    equalCount++;
                }    
                if (i >= list2.Count)
                {
                    break;
                }
                if (list1[i] > list2[i])
                {
                    result = false;
                    break;
                }
                i++;
            }
            if (list2.Count < list1.Count)
            {
                if (equalCount == list1.Count)
                result = false;
                
            }
            return result;
        }
    }
}
