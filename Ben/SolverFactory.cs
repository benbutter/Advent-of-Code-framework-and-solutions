using AOC_2022._22_02;
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
            Type type = GetSolverType();

            ISolver solver = CreateSolverInstance(type);

            return solver;

        }

       

        private Type GetSolverType()
        {
            Type type = Type.GetType(solverName);
            var solver = new Solver22_02();
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
    }
}
