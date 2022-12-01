using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2021_1_Recap;

namespace _2021_1_Recap_Tests
{
    [TestClass]
    public class UnitTest1
    {
        const int TestHighValue = 999;
        const int TestLowValue = 1;
        [TestMethod]
        public void NoPreviousValue_AnalyzerReturnsFalse()
        {
            ValueAnalyzer analyzer = new ValueAnalyzer();

            var result = analyzer.IsValueHigherThanPrevious(TestHighValue);

            Assert.IsFalse(result);
        }
    }
}
