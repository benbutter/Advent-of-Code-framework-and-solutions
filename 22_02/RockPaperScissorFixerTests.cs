using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC_2022._22_02
{
    [TestClass]
    public class RockPaperScissorFixerTests
    {
        //          Rock Paper Scissors
        //Opponents A       B       C
        //you       X       Y       Z

        //         lose   draw    win
        //result     X       Y       Z


        //Losses
        [TestMethod]
        public void GetOptionToFixResult_A_X_ReturnsZ()
        {
            var fixer = new RockPaperScissorFixer();

            var result = fixer.GetOptionToFixResult('A', 'X');

            Assert.AreEqual('Z', result);
        }

        [TestMethod]
        public void GetOptionToFixResult_B_X_ReturnsX()
        {
            var fixer = new RockPaperScissorFixer();

            var result = fixer.GetOptionToFixResult('B', 'X');

            Assert.AreEqual('X', result);
        }


        [TestMethod]
        public void GetOptionToFixResult_C_X_ReturnsY()
        {
            var fixer = new RockPaperScissorFixer();

            var result = fixer.GetOptionToFixResult('C', 'X');

            Assert.AreEqual('Y', result);
        }
    


        //Draws
        [TestMethod]
        public void GetOptionToFixResult_A_Y_ReturnsX()
        {
            var fixer = new RockPaperScissorFixer();

            var result = fixer.GetOptionToFixResult('A', 'Y');

            Assert.AreEqual('X', result);
        }

        [TestMethod]
        public void GetOptionToFixResult_B_Y_ReturnsY()
        {
            var fixer = new RockPaperScissorFixer();

            var result = fixer.GetOptionToFixResult('B', 'Y');

            Assert.AreEqual('Y', result);
        }

        [TestMethod]
        public void GetOptionToFixResult_C_Y_ReturnsZ()
        {
            var fixer = new RockPaperScissorFixer();

            var result = fixer.GetOptionToFixResult('C', 'Y');

            Assert.AreEqual('Z', result);
        }

        //Wins
        [TestMethod]
        public void GetOptionToFixResult_A_Z_ReturnsY()
        {
            var fixer = new RockPaperScissorFixer();

            var result = fixer.GetOptionToFixResult('A', 'Z');

            Assert.AreEqual('Y', result);
        }

        [TestMethod]
        public void GetOptionToFixResult_B_Z_ReturnsZ()
        {
            var fixer = new RockPaperScissorFixer();

            var result = fixer.GetOptionToFixResult('B', 'Z');

            Assert.AreEqual('Z', result);
        }

        [TestMethod]
        public void GetOptionToFixResult_C_Z_ReturnsX()
        {
            var fixer = new RockPaperScissorFixer();

            var result = fixer.GetOptionToFixResult('C', 'Z');

            Assert.AreEqual('X', result);
        }
    }
}
