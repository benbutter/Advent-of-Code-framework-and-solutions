using _2021_1_Recap;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2022._21_01
{
    class Solver21_01 : ISolver
    {
        StreamReader input;
        public void SetInput(StreamReader streamReader)
        {
            input = streamReader;
        }

        public int GetSolution()
        {
            String line;
            int total =0;
            var analyzer = new ValueAnalyzer();
            while (!String.IsNullOrEmpty(line = input.ReadLine()))
            {
                
                if (analyzer.IsValueHigherThanPrevious(Int32.Parse(line)))
                {
                    total++;
                }
            }
            
            
            return total;
        }

       


    }
}
