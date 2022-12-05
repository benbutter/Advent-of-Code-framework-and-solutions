using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2022._22_05
{
    class Solver22_05 : ISolver
    {
        StreamReader input;
        List<string> crates = new List<string>();
        public void SetInput(StreamReader streamReader)
        {
            input = streamReader;
        }
        public string GetSolution()
        {
            bool stackingPhaseOver = false;
            string line;
            while (!input.EndOfStream)
            {
                line = input.ReadLine();
               
            

                //lenght 11, pos 1,5,9
                /*stack 1 is Position 1
                  stack 2 is position 5
                  stack 3 is position 9
                 * */
                if (!stackingPhaseOver && line[1] == '1')
                {
                    stackingPhaseOver = true;
                    for (int i = 0; i < crates.Count; i++)
                    {
                        crates[i] = ReverseString(crates[i]);
                    }
                }
                if (!stackingPhaseOver)
                {
                    CreateStacksHardCodedForTestInput(line);
                }
                else
                {   if (line.Length > 0)
                    MoveCrates(line);
                }
            }

            for (int i = 0; i < crates.Count; i++)
            {
               Console.WriteLine(crates[i]);
            }
            return "";
        }

        private void MoveCrates(string line)
        {
            int numberToMove = line[5];
            int moveFrom = line[12];
            int moveTo = line[17];
        }

        private void CreateStacksHardCodedForTestInput(string line)
        {
           if (crates.Count == 0)
            {
                crates.Add(line[1].ToString());
                crates.Add(line[5].ToString());
                crates.Add(line[9].ToString());
            }
           else
            {
                crates[0] = crates[0] + (line[1].ToString());
                crates[1] = crates[1] + (line[5].ToString());
                crates[2] = crates[2] + (line[9].ToString());
            }
        }

        private void AddToCrates(string crateName, int crateStack)
        {
           if (crates.Count < crateStack)
            {
                crates.Add(crateName);
            }
            else
            {
                crates[crateStack] = crates[crateStack] + crateName;
            }
        }
        static string ReverseString(string s)
        {
            // Convert to char array, then call Array.Reverse.
            // ... Finally use string constructor on array.
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
