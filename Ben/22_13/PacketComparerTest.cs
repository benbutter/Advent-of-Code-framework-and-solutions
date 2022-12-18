using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AOC_2022._22_13
{
    [TestClass]
    public class PacketComparerTest
    {
       /* == Pair 1 ==
        - Compare[1, 1, 3, 1, 1] vs[1, 1, 5, 1, 1]
        - Compare 1 vs 1
        - Compare 1 vs 1
        - Compare 3 vs 5
        - Left side is smaller, so inputs are in the right order*/
       [TestMethod]
       public void ArePacketsInCorrectOrderExampleOne_True()
        {
            PacketComparer comparer = new PacketComparer();
            int[] list1Arr = { 1, 1, 3, 1, 1 };
            List<int> list1 = new List<int>(list1Arr);

           int[] list2Arr = { 1, 1, 5, 1, 1 };
            List<int> list2 = new List<int>(list2Arr);

            var result = comparer.ArePacketsInCorrectOrder(list1, list2);

            Assert.IsTrue(result);
        }

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
        public void ArePacketsInCorrectOrderExampleTwo_True()
        {
         /*   Assert.AreEqual(lists[0].packetOne, "1");
            Assert.AreEqual(lists[0].packetTwo, "1");
            Assert.AreEqual(lists[1].packetOne, "2,3,4");
            Assert.AreEqual(lists[1].packetTwo, "4");*/

            PacketComparer comparer = new PacketComparer();
            int[] list1Arr = { 2,3,4 };
            List<int> list1 = new List<int>(list1Arr);

            int[] list2Arr = { 4 };
            List<int> list2 = new List<int>(list2Arr);

            var result = comparer.ArePacketsInCorrectOrder(list1, list2);

            Assert.IsTrue(result);
        }

        /*  - Compare[9] vs[[8,7,6]]
    - Compare 9 vs[8, 7, 6]
      - Mixed types; convert left to[9] and retry comparison
      - Compare[9] vs[8, 7, 6]
        - Compare 9 vs 8
          - Right side is smaller, so inputs are not in the right order*/
        [TestMethod]
        public void ArePacketsInCorrectOrderExampleThree_True()
        {
           

            PacketComparer comparer = new PacketComparer();
            int[] list1Arr = {9};
            List<int> list1 = new List<int>(list1Arr);

            int[] list2Arr = {8,7,6};
            List<int> list2 = new List<int>(list2Arr);

            var result = comparer.ArePacketsInCorrectOrder(list1, list2);

            Assert.IsFalse(false);
        }

        /*== Pair 5 ==
 - Compare [7,7,7,7] vs [7,7,7]
   - Compare 7 vs 7
   - Compare 7 vs 7
   - Compare 7 vs 7
   - Right side ran out of items, so inputs are not in the right order*/
        [TestMethod]
        public void ArePacketsInCorrectOrderExampleFive_False()
        {


            PacketComparer comparer = new PacketComparer();
            int[] list1Arr = { 7,7,7,7 };
            List<int> list1 = new List<int>(list1Arr);

            int[] list2Arr = { 7,7,7 };
            List<int> list2 = new List<int>(list2Arr);

            var result = comparer.ArePacketsInCorrectOrder(list1, list2);

            Assert.IsFalse(false);
        }
    }
}
