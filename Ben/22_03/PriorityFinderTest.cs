using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC_2022._22_03
{
    [TestClass]
    public class PriorityFinderTest
    {
        [TestMethod]
        public void PrioritiseChar_Lowerz_Returns26()
        {
            PriorityFinder finder = new PriorityFinder();

            var priority = finder.GetPriority('z');

            Assert.AreEqual(26, priority);
        }

        [TestMethod]
        public void PrioritiseChar_UpperD_Returns30()
        {
            PriorityFinder finder = new PriorityFinder();

            var priority = finder.GetPriority('D');

            Assert.AreEqual(30, priority);
        }
    }
}
