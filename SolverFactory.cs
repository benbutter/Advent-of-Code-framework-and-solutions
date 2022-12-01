using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_2022
{
    public class SolverFactory
    {
        public ISolver GetSolver(string suffix)
        {
            string typename = $"AOC_2022._{suffix}.Solver{suffix}";
           string fileName = 
             Type type = Type.GetType(typename);
       
            if (type == null)
            {
                throw new Exception("Type not found.");
            }
            var instance = Activator.CreateInstance(type);
            //or
            var newClass = System.Reflection.Assembly.GetAssembly(type).CreateInstance(typename);

            return (ISolver)newClass;

           // C: \Users\benbu\source\repos\AOC - 2022\21_01\
        }
    }
}
