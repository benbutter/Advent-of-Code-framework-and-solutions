using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC_2022._22_02
{
    [TestClass]
    public class RockPaperScissorScorerTests
    {
        //          Rock Paper Scissors
        //Opponents A       B       C
        //you       X       Y       Z

        //Winning tests
        [TestMethod]
        public void GetScoreForRound_A_Y_Returns8()
        {
            var scorer = new RockPaperScissorScorer();

            var result = scorer.GetScoreForRound('A', 'Y');

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void GetScoreForRound_B_Z_Returns9()
        {
            var scorer = new RockPaperScissorScorer();

            var result = scorer.GetScoreForRound('B', 'Z');

            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void GetScoreForRound_C_X_Returns9()
        {
            var scorer = new RockPaperScissorScorer();

            var result = scorer.GetScoreForRound('C', 'X');

            Assert.AreEqual(7, result);
        }


        //losing tests
        [TestMethod]
        public void GetScoreForRound_A_Z_Returns3()
        {
            var scorer = new RockPaperScissorScorer();

            var result = scorer.GetScoreForRound('A', 'Z');

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetScoreForRound_B_X_Returns1()
        {
            var scorer = new RockPaperScissorScorer();

            var result = scorer.GetScoreForRound('B', 'X');

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetScoreForRound_C_Y_Returns2()
        {
            var scorer = new RockPaperScissorScorer();

            var result = scorer.GetScoreForRound('X', 'Y');

            Assert.AreEqual(2, result);
        }

        //draw test
        [TestMethod]
        public void GetScoreForRound_A_X_Returns4()
        {
            var scorer = new RockPaperScissorScorer();

            var result = scorer.GetScoreForRound('A', 'X');

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void GetScoreForRound_B_Y_Returns5()
        {
            var scorer = new RockPaperScissorScorer();

            var result = scorer.GetScoreForRound('B', 'Y');

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void GetScoreForRound_C_Z_Returns6()
        {
            var scorer = new RockPaperScissorScorer();

            var result = scorer.GetScoreForRound('C', 'Z');

            Assert.AreEqual(6, result);
        }
    }
}
