using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC_2022._22_03
{
    [TestClass]
   public class StringHalverTest
    {
        [TestMethod]
        public void HalfString_StringPassed_TwoHalvesReturned()
        {
            const string FirstHalf      = "Sfkfkrmfrkrff";
            const string SecondtHalf    = "DFfroBmvsosel";

            StringHalver halver = new StringHalver();

            string[] results = halver.HalveString(FirstHalf + SecondtHalf);

            Assert.AreEqual(FirstHalf, results[0]);
            Assert.AreEqual(SecondtHalf, results[1]);
        }
    }
}
