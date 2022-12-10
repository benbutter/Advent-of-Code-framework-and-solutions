using AOC_2022;
using System;

namespace BBRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            const string puzzleDate = "22_08"; //change as needed



            var solverRunner = new SolverRunner();

            // solverRunner.injectedPath = "C:\\Users\\benbu\\source\\repos\\AOC - 2022\\Ben\\22_07\\input.txt";
            //solverRunner.injectedPath = "C: \\Users\\benbu\\source\repos\\AOC - 2022\\Ben\\22_07\\input.txt";
            solverRunner.injectedPath = "C:\\input.txt";
            Console.WriteLine(solverRunner.SolvePuzzle(puzzleDate));
        }
    }
}
