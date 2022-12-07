using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2021_1_Recap;

namespace _2021_1_Recap_Tests
{
    [TestClass]
    public class ValueAnalyzerTest
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

        [TestMethod]
        public void ValueSameAsPreviousValue_AnalyzerReturnsFalse()
        {
            ValueAnalyzer analyzer = new ValueAnalyzer();

            analyzer.IsValueHigherThanPrevious(TestHighValue);

            var result = analyzer.IsValueHigherThanPrevious(TestHighValue);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValueLowerPreviousValue_AnalyzerReturnsFalse()
        {
            ValueAnalyzer analyzer = new ValueAnalyzer();

            analyzer.IsValueHigherThanPrevious(TestHighValue);

            var result = analyzer.IsValueHigherThanPrevious(TestLowValue);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValueSameHigherPreviousValue_AnalyzerReturnsTrue()
        {
            ValueAnalyzer analyzer = new ValueAnalyzer();

            analyzer.IsValueHigherThanPrevious(TestLowValue);

            var result = analyzer.IsValueHigherThanPrevious(TestHighValue);

            Assert.IsTrue(result);
        }
    }
}
