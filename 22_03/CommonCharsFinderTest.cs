using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC_2022._22_03
{
    [TestClass]
    public class CommonCharsFinderTest
    {
        [TestMethod]
        public void FindCommonChars_FindsH()
        {
            CommonCharsFinder finder = new CommonCharsFinder();
            string firstString = "ABCDEFGH";
            string secondString = "HIJKLMN";

            var result = finder.FindCommonChars(firstString, secondString);

            Assert.AreEqual('H', result[0]);
        }

        //bad test - misunderstood requirement - need to break on first match.
       // [TestMethod]
       /* public void FindCommonChars_FindsHK()
        {
            CommonCharsFinder finder = new CommonCharsFinder();
            string firstString = "ABCDEFGHIJLK";
            string secondString = "HKMN";

            var result = finder.FindCommonChars(firstString, secondString);

            Assert.AreEqual('H', result[0]);
            Assert.AreEqual('K', result[1]);
        }
       */
        [TestMethod]
        public void FindCommonChars_FindskAsLowercase()
        {
            CommonCharsFinder finder = new CommonCharsFinder();
            string firstString = "ABCDEFGhIJLk";
            string secondString = "abcdefgHkMN";

            var result = finder.FindCommonChars(firstString, secondString);

            
            Assert.AreEqual('k', result[0]);
        }
    }
}
