using System.Xml.Linq;

namespace Sorts
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBubbleSort()
        {
            int[] mas = {3,8,10,5,1};
            int[] res = { 1, 3, 5, 8, 10 };
            CollectionAssert.AreEqual(res, sortic.BubbleSort(mas));
        }
        [TestMethod]
        public void TestQuic()
        {
            int[] mas = { 3, 8, 10, 5, 1 };
            int[] res = { 1, 3, 5, 8, 10 };
            CollectionAssert.AreEqual(res, sortic.QuickSortStart(mas));
        }
        [TestMethod]
        public void TestVibor()
        {
            int[] mas = { 3, 8, 10, 5, 1 };
            int[] res = { 1, 3, 5, 8, 10 };
            CollectionAssert.AreEqual(res, sortic.ViborSort(mas));
        }
    }
}