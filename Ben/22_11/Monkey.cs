using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022._22_11
{
    public class Monkey
    {
        public List<int> items ;
        public string operationString;
        public int testInt;
        public int trueMonkeyToThrowTo;
        public int falseMonkeyTothrowTo;
        public MonkeyColony colony;
        public int inspectionCount = 0;
        public Monkey(  string _operationString,
                        int _testInt,
                        int _trueMonkeyToThrowTo,
                        int _falseMonkeyTothrowTo,
                        MonkeyColony _colony)
        {
            items = new List<int>();
            operationString = _operationString;
            testInt = _testInt;
            trueMonkeyToThrowTo = _trueMonkeyToThrowTo;
            falseMonkeyTothrowTo = _falseMonkeyTothrowTo;
            colony = _colony;
        }

        public void InspectAndThrow()
        {
            for (int i = 0; i < items.Count; i++)
            {
                inspectionCount++;
               
                items[i] = Operation(i);
                
              //  items[i] = items[i] / 3; //part 2
                
                bool result = (items[i] % testInt) == 0;
         
                if (result)
                {
                    colony.GetMonkey(trueMonkeyToThrowTo).items.Add(items[i]);
                
                }
                else
                {
                    colony.GetMonkey(falseMonkeyTothrowTo).items.Add(items[i]);
                }


            }
            RemoveItem();
        }

        public int Operation(int itemNumber)
        {
            var tokens = operationString.Split(" ");
            int result = 0;

            if (tokens[0] == "old")
            {
                tokens[0] = items[itemNumber].ToString();
            }

            if (tokens[2] == "old")
            {
                tokens[2] = items[itemNumber].ToString();
            }

            if (tokens[1] == "*")
            {
                result =  Int32.Parse(tokens[0]) * Int32.Parse(tokens[2]);
            }
            else if (tokens[1] == "+")
            {
                result = Int32.Parse(tokens[0]) + Int32.Parse(tokens[2]);
            }
            return result;
        }
         private void Throw()
        {

        }
        private void RemoveItem()
        {
            items.Clear();
        }
    }
}
