using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace AOC_2022
{
    public class SolverFactory
    {
        private string filePath;
        private string solverName;

        public SolverFactory(string _solverName, string _filePath)
        {
            filePath = _filePath;
            solverName = _solverName;
        }
        public ISolver CreateSolver()
        {
            Type type = GetSolverType(solverName);

            ISolver solver = CreateSolverInstance(type);

            SetInputOnSolver(solverName, solver);

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
            string path;

            if (filePath == null)
            {
                //there must be a better way of doing this
                DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
                path = di.Parent.Parent.Parent.Parent.FullName + $"\\AOC-2022\\Ben\\{puzzleDate}\\input.txt";
                path = "C:\\Users\\Rosia\\Documents\\GitHub\\AOC-2022\\Ben\\22_04r\\input.txt";
            }
            else
            {
               path = filePath;
            }
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
