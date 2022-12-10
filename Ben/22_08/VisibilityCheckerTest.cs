using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC_2022._22_08
{
    [TestClass]
    public class VisibilityCheckerTest
    {
        [TestMethod]
        public void IsCoOrdinateVisible_treeOnLeftEdge_True()
        {
            var checker = new VisibilityChecker();

            string[] trees = new string[1];

            trees[0] = "4";

            var result = checker.IsCoOrdinateVisible(0, 0, trees);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsCoOrdinateVisible_treeOnRightEdge_True()
        {
            var checker = new VisibilityChecker();

            string[] trees = new string[1];

            trees[0] = "434";

            var result = checker.IsCoOrdinateVisible(2, 0, trees);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsCoOrdinateVisible_treeOnTopEdge_True()
        {
            var checker = new VisibilityChecker();

            string[] trees = new string[2];

            trees[0] = "434";
            trees[0] = "454";

            var result = checker.IsCoOrdinateVisible(1, 0, trees);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsCoOrdinateVisible_treeOnBottomEdge_True()
        {
            var checker = new VisibilityChecker();

            string[] trees = new string[2];

            trees[0] = "434";
            trees[1] = "454";

            var result = checker.IsCoOrdinateVisible(1, 1, trees);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsCoOrdinateVisible_treesToLeftAreLower_True()
        {
            var checker = new VisibilityChecker();

            string[] trees = new string[3];

            trees[0] = "99999";
            trees[1] = "12345";
            trees[2] = "99999";

            var result = checker.IsCoOrdinateVisible(3, 1, trees);
        
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsCoOrdinateVisible_treeToLeftIsHigher_False()
        {
            var checker = new VisibilityChecker();

            string[] trees = new string[3];

            trees[0] = "99999";
            trees[1] = "19345";
            trees[2] = "99999";

            var result = checker.IsCoOrdinateVisible(3, 1, trees);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsCoOrdinateVisible_treesToRightAreLower_True()
        {
            var checker = new VisibilityChecker();

            string[] trees = new string[3];

            trees[0] = "9999999";
            trees[1] = "9234321";
            trees[2] = "9999999";

            var result = checker.IsCoOrdinateVisible(3, 1, trees);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsCoOrdinateVisible_treesToRightAreHigher_False()
        {
            var checker = new VisibilityChecker();

            string[] trees = new string[3];

            trees[0] = "9999999";
            trees[1] = "9234329";
            trees[2] = "9999999";

            var result = checker.IsCoOrdinateVisible(3, 1, trees);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsCoOrdinateVisible_treesToFrontAreLower_True()
        {
            var checker = new VisibilityChecker();

            string[] trees = new string[3];

            trees[0] = "9993999";
            trees[1] = "9234329";
            trees[2] = "9999999";

            var result = checker.IsCoOrdinateVisible(3, 1, trees);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsCoOrdinateVisible_treesToFrontAreHigher_False()
        {
            var checker = new VisibilityChecker();

            string[] trees = new string[3];

            trees[0] = "9999999";
            trees[1] = "9234329";
            trees[2] = "9999999";

            var result = checker.IsCoOrdinateVisible(3, 1, trees);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsCoOrdinateVisible_treesBehindAreLower_True()
        {
            var checker = new VisibilityChecker();

            string[] trees = new string[3];

            trees[0] = "9999999";
            trees[1] = "9234329";
            trees[2] = "9993999";

            var result = checker.IsCoOrdinateVisible(3, 1, trees);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsCoOrdinateVisible_treesBehindAreHigher_False()
        {
            var checker = new VisibilityChecker();

            string[] trees = new string[3];

            trees[0] = "9999999";
            trees[1] = "9234329";
            trees[2] = "9999999";

            var result = checker.IsCoOrdinateVisible(3, 1, trees);

            Assert.IsFalse(result);
        }
    }

    
}

