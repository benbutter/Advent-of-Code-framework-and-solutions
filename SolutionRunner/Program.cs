using AOC_2022;
using System;



namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            const string solverName = "AOC_2022._22_02.Solver22_02"; //change as needed

            const string filePath = "C:\\Users\\benbu\\OneDrive\\Documents\\Aoc Input\\22_02"; //change as needed

            var solverRunner = new SolverRunner();



            Console.WriteLine(solverRunner.SolvePuzzle(solverName, filePath));
        }
    }
}