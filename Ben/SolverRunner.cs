using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2022
{
    public class SolverRunner
    {
       
        public string SolvePuzzle(string puzzleDate, string filePath)
        {
            var fact = new SolverFactory(puzzleDate, filePath);
            

            var solver = fact.CreateSolver();

            return solver.GetSolution(CreateStreamReader(filePath));
        }

        private StreamReader CreateStreamReader(string filePath)
        {
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            var streamReader = new StreamReader(fileStream, Encoding.UTF8);

            return streamReader;
        }
    }
}
