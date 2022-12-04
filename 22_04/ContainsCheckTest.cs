using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC_2022._22_04
{
    [TestClass]
    public class ContainsCheckTest
    {
        [TestMethod]
        public void DoesOneStringContainTheOther_TwoDifferentStrings_ReturnFalse()
        {
            const string FirstString = "ABCDEFG";
            const string SecondString = "HIJKL";
            var checker = new ContainsCheck();

            var result = checker.DoesOneStringContainTheOther(FirstString, SecondString);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DoesOneStringContainTheOther_StringsOneContainsStringTwo_ReturnTrue()
        {
            const string FirstString = "ABCDEFG";
            const string SecondString = "CDEFG";
            var checker = new ContainsCheck();

            var result = checker.DoesOneStringContainTheOther(FirstString, SecondString);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DoesOneStringContainTheOther_StringTwoContainsStringOne_ReturnTrue()
        {
            const string FirstString = "CDEFG";
            const string SecondString = "ABCDEFGH";
            var checker = new ContainsCheck();

            var result = checker.DoesOneStringContainTheOther(FirstString, SecondString);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DoesOneStringContainTheOther_StringsMatch_ReturnTrue()
        {
            const string FirstString = "CDEFG";
            const string SecondString = "CDEFG";
            var checker = new ContainsCheck();

            var result = checker.DoesOneStringContainTheOther(FirstString, SecondString);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DoesOnenumberRangeContainTheOther_DifferentRanges_ReturnFalse()
        {
            const string FirstNumberRange = "1-5";
            const string SecondNumberRange = "6-7";
            var checker = new ContainsCheck();

            var result = checker.DoesOnenumberRangeContainTheOther(FirstNumberRange, SecondNumberRange);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DoesOnenumberRangeContainTheOther_FirstContainsSecond_ReturnTrue()
        {
            const string FirstNumberRange = "1-9";
            const string SecondNumberRange = "6-7";
            var checker = new ContainsCheck();

            var result = checker.DoesOnenumberRangeContainTheOther(FirstNumberRange, SecondNumberRange);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DoesOnenumberRangeContainTheOther_SecondContainsFirst_ReturnTrue()
        {
            const string FirstNumberRange = "2-8";
            const string SecondNumberRange = "1-9";
            var checker = new ContainsCheck();

            var result = checker.DoesOnenumberRangeContainTheOther(FirstNumberRange, SecondNumberRange);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DoesOnenumberRangeContainTheOther_SameRanges_ReturnTrue()
        {
            const string FirstNumberRange = "2-8";
            const string SecondNumberRange = "2-8";
            var checker = new ContainsCheck();

            var result = checker.DoesOnenumberRangeContainTheOther(FirstNumberRange, SecondNumberRange);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DoesOnenumberRangeContainTheOther_FirstContainsSecond_BigNumbers_ReturnTrue()
        {
            const string FirstNumberRange = "1234-9789";
            const string SecondNumberRange = "6234-7987";
            var checker = new ContainsCheck();

            var result = checker.DoesOnenumberRangeContainTheOther(FirstNumberRange, SecondNumberRange);

            Assert.IsTrue(result);

        }
    }
}

    
