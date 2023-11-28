using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace AOC_2022._22_05
{
    public class Solver22_05 : ISolver
    {
        
        List<string> crates = new List<string>();
      
        public string GetSolution(StreamReader input)
        {
            bool stackingPhaseOver = false;
            string line;
            string returnVal = "";

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
                        crates[i] = ReverseString(crates[i]).Trim();
                    }
                    continue;
                }
                if (!stackingPhaseOver)
                {
                   // CreateStacksHardCodedForTestInput(line);
                      CreateStacksHardCodedForProdInput(line);
                }
                else
                {   if (line.Length > 0)
                    MoveCrates(line);
                }
            }

            for (int i = 0; i < crates.Count; i++)
            {
                returnVal += GetLastCharOfEachCrate(i);
            }

            return returnVal;
        }

        private string GetLastCharOfEachCrate(int i)
        {
            return crates[i][crates[i].Length - 1].ToString();
        }

        private void MoveCrates(string line)
        {
      

            string[] numbers = Regex.Split(line, @"\D+");
            int numberToMove = Int32.Parse(numbers[1]);
            int moveFrom = Int32.Parse(numbers[2])-1;
            int moveTo = Int32.Parse(numbers[3])-1;
            string staging = "";
            for (int i = 0; i < numberToMove; i++)
            {
                //move last char
                // crates[moveTo] = crates[moveTo] + crates[moveFrom][crates[moveFrom].Length -1];cpart1
                staging += crates[moveFrom][crates[moveFrom].Length - 1];
                //remove last char
                crates[moveFrom] = crates[moveFrom].Remove(crates[moveFrom].Length - 1, 1);
               
            }
            crates[moveTo] += ReverseString(staging);
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

        private void CreateStacksHardCodedForProdInput(string line)
        {
            if (crates.Count == 0)
            {
                crates.Add(line[1].ToString());
                crates.Add(line[5].ToString());
                crates.Add(line[9].ToString());
                crates.Add(line[13].ToString());
                crates.Add(line[17].ToString());
                crates.Add(line[21].ToString());
                crates.Add(line[25].ToString());
                crates.Add(line[29].ToString());
                crates.Add(line[33].ToString());
            }
            else
            {
                crates[0] = crates[0] + (line[1].ToString());
                crates[1] = crates[1] + (line[5].ToString());
                crates[2] = crates[2] + (line[9].ToString());
                crates[3] = crates[3] + (line[13].ToString());
                crates[4] = crates[4] + (line[17].ToString());
                crates[5] = crates[5] + (line[21].ToString());
                crates[6] = crates[6] + (line[25].ToString());
                crates[7] = crates[7] + (line[29].ToString());
                crates[8] = crates[8] + (line[33].ToString());
            }
        }

      
        static string ReverseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
