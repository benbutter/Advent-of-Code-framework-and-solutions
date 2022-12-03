using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC_2022._22_03
{
    [TestClass]
    public class CommonCharsFinderGroupsTest
    {
        [TestMethod]
        public void FindCommonChars_FindsH()
        {
            CommonCharsFinderGroups finder = new CommonCharsFinderGroups();
            string firstString = "ABCDEFGH";
            string secondString = "AHIJKLMN";
            string thirdString = "zxyHOPQ";
            var result = finder.FindCommonChars(firstString, secondString,thirdString);

            Assert.AreEqual('H', result[0]);
        }
    }
}
