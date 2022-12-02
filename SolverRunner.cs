using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022
{
    public class SolverRunner
    {
        public int SolvePuzzle(string puzzleDate)
        {
           
            var fact = new SolverFactory();

            var solver = fact.GetSolver(puzzleDate);

            return solver.GetSolution();
        }
    }
}
