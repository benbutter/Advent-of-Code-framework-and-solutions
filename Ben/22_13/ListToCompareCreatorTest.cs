using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace AOC_2022._22_13
{
    [TestClass]
    public class ListToCompareCreatorTest
    {
        /*== Pair 2 ==
       - Compare [[1],[2,3,4]] vs [[1],4]
         - Compare [1] vs [1]
           - Compare 1 vs 1
         - Compare [2,3,4] vs 4
           - Mixed types; convert right to [4] and retry comparison
           - Compare [2,3,4] vs [4]
             - Compare 2 vs 4
               - Left side is smaller, so inputs are in the right order*/
        [TestMethod]
        public void CreateListsToCompare_pair2ListsCorrect()
        {
            string packet1 = "[[1], [2, 3, 4]]";
            string packet2 = "[[1],4]";

            ListToCompareCreator creator = new ListToCompareCreator();

            var lists = creator.CreateListsToCompare(packet1, packet2);

            Assert.AreEqual(lists[0].packetOne , "1");
            Assert.AreEqual(lists[0].packetTwo, "1");
            Assert.AreEqual(lists[1].packetOne, "2,3,4");
            Assert.AreEqual(lists[1].packetTwo, "4");
        }

        /*- Compare [9] vs [[8,7,6]]
  - Compare 9 vs [8,7,6]
    - Mixed types; convert left to [9] and retry comparison
    - Compare [9] vs [8,7,6]
      - Compare 9 vs 8
        - Right side is smaller, so inputs are not in the right order*/

        [TestMethod]
        public void CreateListsToCompare_pair3ListsCorrect()
        {
            string packet1 = "[9]";
            string packet2 = "[[8,7,6]]";


            ListToCompareCreator creator = new ListToCompareCreator();

            var lists = creator.CreateListsToCompare(packet1, packet2);

            Assert.AreEqual(lists[0].packetOne, "9");
            Assert.AreEqual(lists[0].packetTwo, "8,7,6");
         
        }
    }
}
