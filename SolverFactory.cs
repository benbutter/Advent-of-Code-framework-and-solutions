using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_2022
{
    public class SolverFactory
    {
        public ISolver CreateSolver(string puzzleDate)
        {
            Type type = GetSolverType(puzzleDate);

            ISolver solver = CreateSolverInstance(type);

            SetInputOnSolver(puzzleDate, solver);

            return solver;

        }

        private void SetInputOnSolver(string puzzleDate, ISolver solver)
        {
            solver.SetInput(GetInput(puzzleDate));
        }

        private Type GetSolverType(string puzzleDate)
        {
            string typename = $"AOC_2022._{puzzleDate}.Solver{puzzleDate}";

            Type type = Type.GetType(typename);

            if (type == null)
            {
                throw new Exception("Type not found.");
            }

            return type;
        }

        private ISolver CreateSolverInstance(Type type)
        {
            var instance = Activator.CreateInstance(type);

            ISolver solver = (ISolver)instance;
            return solver;
        }

        private StreamReader GetInput(string puzzleDate)
        {
            //TODO - relative path needed
            string path = $"C:\\Users\\benbu\\source\\repos\\AOC-2022\\{puzzleDate}\\input.txt";
            if (!File.Exists(path))
            {
                throw new Exception("File not found.");
            }

            var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

            var streamReader = new StreamReader(fileStream, Encoding.UTF8);

            return streamReader;
        }
    }
}
