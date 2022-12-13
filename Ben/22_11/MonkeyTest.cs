using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOC_2022._22_11
{
    [TestClass]
    public class MonkeyTest
    {
        [TestMethod]
        public void Operation_old_times_old_returns9()
        {
            Monkey monkey = new Monkey("old * old", 0, 1, 2, null);

            monkey.items.Add(3);

            var ressult = monkey.Operation();

            Assert.AreEqual(9, ressult);
        }

        [TestMethod]
        public void Operation_old_plus_old_returns6()
        {
            Monkey monkey = new Monkey("old + old", 0, 1, 2, null);

            monkey.items.Add(3);

            var ressult = monkey.Operation();

            Assert.AreEqual(6, ressult);
        }

        [TestMethod]
        public void Operation_old_plus_four_returns7()
        {
            Monkey monkey = new Monkey("old + 4", 0, 1, 2, null);

            monkey.items.Add(3);

            var ressult = monkey.Operation();

            Assert.AreEqual(7, ressult);
        }
    }
}
