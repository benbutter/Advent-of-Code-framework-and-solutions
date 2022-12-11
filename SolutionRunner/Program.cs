using AOC_2022;
using System;



namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            const string puzzleDate = "22_07"; //change as needed



            var solverRunner = new SolverRunner();



            Console.WriteLine(solverRunner.SolvePuzzle(puzzleDate));
        }
    }
}