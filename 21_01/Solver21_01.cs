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
            
            Console.WriteLine(input.ReadToEnd());
            
            return 0;
        }

       


    }
}
