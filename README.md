# AOC-2022

Simple framework and solutions for Advent of Code. 

How to run a puzzle solver:

You will need to create an application with access to the class SolverRunner. These easiest way to do this is to create a new project with a project reference.

From there create an instance of SolverRunner and call SolvePuzzle() passing in the puzzle date. The puzzle date should be YY_DD - eg the first one of 2021 is 21_01.

example:
 class Program
    {
        static void Main(string[] args)
        {
           const string puzzleDate = "21_01";//change as needed

           var solverRunner = new SolverRunner();

          Console.WriteLine( solverRunner.SolvePuzzle(puzzleDate));
        }
    }

How to create a new puzzle solver:

Create a new folder in the AdventOfCode project with the puzzle date as the name - The puzzle date should be YY_DD - eg the first one of 2021 is 21_01. 
In this folder create a class called Solver with the puzzle date appended - eg Solver22_01. Then reimplement the ISolver interface this will give the Class two new methods:

SetInput(StreamReader streamReader) - this allows the framework to pass the input in a StreamReader to the Solver - easiest implemntation is to store this locally.

 StreamReader input;
        public void SetInput(StreamReader streamReader)
        {
            input = streamReader;
        }
 
 The second method is GetSolution() use this to create your answer
 
   public int GetSolution()
        {
          Work out answer
          return answer;
        }
        
 Input is also provided for the solver in this folder. create a file called input.txt and paste in your input. Remember your input id persoanlized to you as is the answer.
 C.copy and paste into the file is the easiest way to vary input - use the example/someone elses input/ your own test input.
