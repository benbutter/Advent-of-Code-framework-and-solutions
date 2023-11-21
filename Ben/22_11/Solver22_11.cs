using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AOC_2022._22_11
{
    public class Solver22_11 : ISolver
    {
        private StreamReader input;
        public string GetSolution()
        {
            string line;
            int lineCountPerMonkey = 0;
            string[] startingItems = new string[0];
           // List<String> startingItemList = new List<string>();
            string operation = "";
            int test = 0;
            int trueMonkey =0;
            int falseMonkey =0;
            MonkeyColony colony = new MonkeyColony();
            while (!input.EndOfStream)
            {
             
                line = input.ReadLine();
                lineCountPerMonkey++;
                if (lineCountPerMonkey == 2)
                {
                    //starting items
                    string starter = line.Substring(17);
                    startingItems = starter.Split(',');
                   // startingItemList = startingItems.
                }
                else if (lineCountPerMonkey == 3)
                {
                    //operation
                    operation = line.Substring(19);
                }
                else if (lineCountPerMonkey == 4)
                {
                    //test
                    test = Int32.Parse( line.Substring(20));
                }
                else if (lineCountPerMonkey == 5)
                {
                    //monkey true
                    trueMonkey = Int32.Parse(line.Substring(29));
                }
                else if (lineCountPerMonkey == 6)
                {
                    //monkey false
                    falseMonkey = Int32.Parse(line.Substring(30));
                }
                else if (lineCountPerMonkey == 7)
                {
                    //create monkey 
                    CreateMonkey(startingItems, operation, test, trueMonkey, falseMonkey, colony);

                    //blank attributes

                    lineCountPerMonkey = 0;
                }

                // return "";
            }
            CreateMonkey(startingItems, operation, test, trueMonkey, falseMonkey, colony);

            for (int i = 0; i < 10000; i++)  //20 rounds part 1 10000 rounds part 2
            {


                int count = 0;
                foreach (var monkey in colony.monkeys)
                {
                    monkey.InspectAndThrow();
                    count++;
                }
            }

            List<Monkey> SortedList = colony.monkeys.OrderByDescending(m => m.inspectionCount).ToList();
            return (SortedList[0].inspectionCount * SortedList[1].inspectionCount).ToString();
        }

        private void CreateMonkey(string[] startingItems, string operation, int test, int trueMonkey, int falseMonkey, MonkeyColony colony)
        {
            Monkey monkey = new Monkey(operation, test, trueMonkey, falseMonkey, colony);
            foreach (var item in startingItems)
            {
                monkey.items.Add(Int32.Parse(item));
            }

            colony.monkeys.Add(monkey);
        }

        public void SetInput(StreamReader streamReader)
        {
            input = streamReader;
        }
    }
}
