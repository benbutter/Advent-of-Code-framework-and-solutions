using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2022._22_10
{
    class Solver22_10 : ISolver
    {
        int x = 1;
        int total = 0;
        StreamReader input;
        int lineCount;
        int cycleNumber = 1;
        string[] screen = new string[6];

        public void SetInput(StreamReader streamReader)
        {
            input = streamReader;
        }
        public string GetSolution()
        {
            string line;


            while (!input.EndOfStream)
            {
                line = input.ReadLine();
                lineCount++;
                //     Console.WriteLine(lineCount + "," + lineCount + "," + line + "," + cyclenumber + "," + x);
                if (line.Contains("noop"))
                {
                    CheckCycle();
                    IncrementCycle(); ;
                }

                if (line.Contains("addx"))
                {
                    CheckCycle();
                    IncrementCycle();
                    CheckCycle();
                    IncrementCycle();

                    var substring = line.Substring(4).Trim();
                    x += int.Parse(substring);
                }
            }

            //  return total.ToString();
            for (int i = 0; i < screen.Length; i++)
            {
                Console.WriteLine(screen[i]);
            }
        }

        private void CheckCycle()
        {
            if (cycleNumber % 40 == 20)
            {
                total += x * cycleNumber;
            }
        }

        private void IncrementCycle()
        {
            cycleNumber++;
            DrawChar();
        }

        private void DrawChar()
        {
            int y = (cycleNumber -1) % 40;

            string currentRow = screen[y];
            var charArr = currentRow.ToCharArray();

            if ((cycleNumber == x) || (cycleNumber == x - 1) || (cycleNumber == x + 1))
            {
                charArr[x - 1] = '#';
                charArr[x] = '#';
                charArr[x + 1] = '#';
            }
            else
            {
                charArr[x] = '.';
            }
           
        }
    }
}
