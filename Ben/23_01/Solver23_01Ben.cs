using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_2022._23_01
{
    public class _23_01Ben : ISolver
    {
        List<int> ints;
        public _23_01Ben()
        {
            ints = new List<int>();   
        }
        public string GetSolution(StreamReader streamReader)
        {
            while (!streamReader.EndOfStream)
            {
                int firstNumber = 0;
                int secondNumber = 0;
                
                var line = streamReader.ReadLine();
                
                foreach (var item in line)
                {
                    if (Int32.TryParse(item.ToString(),out firstNumber))
                    {
                        break;
                    }

                }

               var reversedLine = line.Reverse();


                foreach (var item in reversedLine)
                {
                    if (Int32.TryParse(item.ToString(), out secondNumber))
                    {
                        break;
                    }

                }
                
                ints.Add(Int32.Parse(firstNumber.ToString() + secondNumber.ToString()));
            }

            int total = 0;

            foreach (var item in ints)
            {
                total += item;
            }

            return total.ToString();
        }
    }
}
