using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2022
{
    public  interface ISolver
    {
        public string GetSolution();

        public void SetInput(StreamReader streamReader);
    }
}
