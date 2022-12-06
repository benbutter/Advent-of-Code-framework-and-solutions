using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC_2022._22_06
{
    [TestClass]
    public class UniqueChainFinderTest
    {
        [TestMethod]
        public void ChainContainsOnlyUniqueChars_UniquePassed_True()
        {
            const string UniqueChain = "ABCD";
            var chainFinder = new UniqueChainFinder();

            var result = chainFinder.ChainContainsOnlyUniqueChars(UniqueChain);

            Assert.IsTrue(result);
        }


        [TestMethod]
        public void ChainContainsOnlyUniqueChars_RepeatedPassed_False()
        {
            const string UniqueChain = "ABCDA";
            var chainFinder = new UniqueChainFinder();

            var result = chainFinder.ChainContainsOnlyUniqueChars(UniqueChain);

            Assert.IsFalse(result);
        }
    }
}
