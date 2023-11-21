using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2022._22_10
{
    public class Solver22_10 : ISolver
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
            for (int i = 0; i < 6; i++)
            {
                screen[i] = "........................................";
            }
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
            return "done";
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
            DrawChar();
            cycleNumber++;
            
        }

        private void DrawChar()
        {
             int y = 0;
           // if (cycleNumber > 40)
           // {
           //    int  y = (cycleNumber - 1) / 40;
           // }
           //div not working?
            if (cycleNumber < 40)
            {
                y = 0;
            }
            else if (cycleNumber < 80)
            {
                y = 1;
            }
            else if (cycleNumber < 120)
            {
                y = 2;
            }
            else if (cycleNumber < 160)
            {
                y = 3;
            }
            else if (cycleNumber < 200)
            {
                y = 4;
            }
            else if (cycleNumber < 240)
            {
                y = 5;
            }

            int screenPos = cycleNumber % 40;

            string currentRow = screen[y];
            var charArr = currentRow.ToCharArray();

            if ((screenPos == x) || (screenPos == x - 1) || (screenPos == x + 1))
            {
                // charArr[x - 1] = '#';
                charArr[screenPos] = '#';
               //  charArr[x + 1] = '#';
            }
            screen[y] = new string(charArr);
             
          /*  else
            {
                charArr[x] = '.';
            }*/
           
        }
    }
}
