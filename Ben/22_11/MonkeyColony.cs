using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_11
{
    public class MonkeyColony
    {
        public List<Monkey> monkeys;

        public MonkeyColony()
        {
            monkeys = new List<Monkey>();
        }
        
        public Monkey GetMonkey(int position)
        {
            return monkeys[position];
        }
    }
}
