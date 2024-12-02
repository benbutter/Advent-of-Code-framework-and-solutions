using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_2022._23_07
{
    [TestClass]
    public class _23_07Tests
    {
        [TestMethod]
        public void  Hand_FiveOfAKindPAssed_CorrectCategorySet()
        {
            var hand = new Hand("TTTTT");

            Assert.AreEqual(Hand.FiveOfAKind, hand.category);
        }

        [TestMethod]
        public void Hand_FourOfAKindPAssed_CorrectCategorySet()
        {
            var hand = new Hand("33A33");

            Assert.AreEqual(Hand.FourOfAKind, hand.category);
        }

        [TestMethod]
        public void Hand_DiffFourOfAKindPAssed_CorrectCategorySet()
        {
            var hand = new Hand("A3AAA");

            Assert.AreEqual(Hand.FourOfAKind, hand.category);
        }

        [TestMethod]
        public void Hand_FullHousePAssed_CorrectCategorySet()
        {
            var hand = new Hand("3AAA3");

            Assert.AreEqual(Hand.FullHouse, hand.category);
        }

        [TestMethod]
        public void Hand_DifferentFullHousePAssed_CorrectCategorySet()
        {
            var hand = new Hand("33AA3");

            Assert.AreEqual(Hand.FullHouse, hand.category);
        }

        [TestMethod]
        public void Hand_ThreesOfAkindPAssed_CorrectCategorySet()
        {
            var hand = new Hand("332A3");

            Assert.AreEqual(Hand.ThreeOfAKind, hand.category);
        }

        public void Hand_TwoPairPAssed_CorrectCategorySet()
        {
            var hand = new Hand("332A2");

            Assert.AreEqual(Hand.TwoPair, hand.category);
        }
    }
}
