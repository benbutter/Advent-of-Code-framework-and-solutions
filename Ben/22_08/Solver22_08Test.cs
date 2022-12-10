using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AOC_2022._22_08
{
    [TestClass]
    public class Solver22_08Test
    {
        [TestMethod]
        public void MediumArray_ExtractFromProd()
        {
            Solver22_08 solver = new Solver22_08();

            string[] array = new string[5];

            array[0] = "9899999999";
            array[1] = "9999999999";
            array[2] = "9699999999";
            array[3] = "9799999999";
            array[4] = "9899999999";

            var result = solver.ArrayReader(array);

            Assert.AreEqual("27", result);
            
        }

        [TestMethod]
        public void MediumArrayGotZerosIn_ExtractFromProd()
        {
            Solver22_08 solver = new Solver22_08();

            string[] array = new string[5];

            array[0] = "9899999909";
            array[1] = "9999999909";
            array[2] = "9699999999";
            array[3] = "9799999999";
            array[4] = "9899999999";

            var result = solver.ArrayReader(array);

            Assert.AreEqual("29", result);

        }
        [TestMethod]
        public void MediumArrayGotZerosIn()
        {
            Solver22_08 solver = new Solver22_08();

            string[] array = new string[5];

            array[0] = "0000000000";
            array[1] = "0000000000";
            array[2] = "0000900000";
            array[3] = "0000000000";
            array[4] = "0000000000";

            var result = solver.ArrayReader(array);

            Assert.AreEqual("27", result);

        }
    }
}
