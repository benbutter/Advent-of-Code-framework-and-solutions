using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022
{
    public class Initializer
    {
        public void Initialize(string puzzleDate)
        {
           
            var fact = new SolverFactory();

            var solver = fact.GetSolver(puzzleDate);

            solver.GetSolution();
        }
    }
}
