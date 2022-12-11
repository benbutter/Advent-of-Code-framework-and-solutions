using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC_2022._22_09
{
    [TestClass]
    public class CurrentPositionFinderTest
    {
        [TestMethod]
        public void GetCurrentRelativePos_SamePos_OnTopOf()
        {
            CurrentPositionFinder finder = new CurrentPositionFinder();

            var result = finder.GetCurrentRelativePos(2, 2, 2, 2);

            Assert.AreEqual(CurrentPositionFinder.onTopOf, result);
        }

        [TestMethod]
        public void IsAGap_ReturnsTrue()
        {
            CurrentPositionFinder finder = new CurrentPositionFinder();

            var result = finder.IsAGap(2, 0, 2, 2);

            Assert.IsTrue(result);
        }
    }
}
