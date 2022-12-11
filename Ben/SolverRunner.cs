using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022
{
    public class SolverRunner
    {
        public string injectedPath;
        public string SolvePuzzle(string puzzleDate)
        {
            var fact = new SolverFactory();
            fact.injectedPath = injectedPath;

            var solver = fact.CreateSolver(puzzleDate);

            return solver.GetSolution();
        }
    }
}
