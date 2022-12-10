using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace AOC_2022._22_08
{
    [TestClass]
    public class ScenicScoreTest
    {
        [TestMethod]
        public void GetScenicScoreToRight_Returns5()
        {
            var calc = new ScenicScoreCalc();

            string[] trees = new string[1];

            trees[0] = "434123349";

            var result = calc.GetScenicScoreToRight(2, 0, trees);

            Assert.AreEqual(5 , result);
        }

        [TestMethod]
        public void GetScenicScoreToRight_Returns6()
        {
            var calc = new ScenicScoreCalc();

            string[] trees = new string[1];

            trees[0] = "434123331";

            var result = calc.GetScenicScoreToRight(2, 0, trees);

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void GetScenicScoreToRight_Returns0()
        {
            var calc = new ScenicScoreCalc();

            string[] trees = new string[1];

            trees[0] = "434";

            var result = calc.GetScenicScoreToRight(2, 0, trees);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void GetScenicScoreToLeft_Returns2()
        {
            var calc = new ScenicScoreCalc();

            string[] trees = new string[1];

            trees[0] = "434";

            var result = calc.GetScenicScoreToLeft(2, 0, trees);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void GetScenicScoreToLeft_Returns3()
        {
            var calc = new ScenicScoreCalc();

            string[] trees = new string[1];

            trees[0] = "129334";

            var result = calc.GetScenicScoreToLeft(5, 0, trees);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetScenicScoreToFront_Returns3()
        {
            var calc = new ScenicScoreCalc();

            string[] trees = new string[4];

            trees[0] = "129334";
            trees[1] = "129334";
            trees[2] = "129334";
            trees[3] = "149334";

            var result = calc.GetScenicScoreToFront(1, 3, trees);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetScenicScoreToBack_Returns3()
        {
            var calc = new ScenicScoreCalc();

            string[] trees = new string[4];

            trees[0] = "159334";
            trees[1] = "129334";
            trees[2] = "129334";
            trees[3] = "159334";

            var result = calc.GetScenicScoreToBack(1, 0, trees);

            Assert.AreEqual(3, result);
        }
    }
}
