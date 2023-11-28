using _2021_1_Recap;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2022._21_01
{
    public class Solver21_01 : ISolver
    {
      //  StreamReader input;
       // public void SetInput(StreamReader streamReader)
      //  {
      //      input = streamReader;
      //  }

        public string GetSolution(StreamReader input)
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
            
            
            return total.ToString();
        }

       


    }
}
