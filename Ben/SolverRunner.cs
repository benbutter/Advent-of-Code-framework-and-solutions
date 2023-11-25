using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022
{
    public class SolverRunner
    {
       
        public string SolvePuzzle(string puzzleDate, string filePath)
        {
            var fact = new SolverFactory(puzzleDate, filePath);
            

            var solver = fact.CreateSolver();

            return solver.GetSolution();
        }
    }
}
