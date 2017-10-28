using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VismaTasks;

namespace TestsForTasks
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Task1Test1()
        {
            string ransom = "a";
            string magazine = "b";

            Tasks foo = new Tasks();

            Assert.IsFalse(foo.canConstruct(ransom, magazine));
        }
        [TestMethod]
        public void Task1Test2()
        {
            string ransom = "aa";
            string magazine = "ab";

            Tasks foo = new Tasks();

            Assert.IsFalse(foo.canConstruct(ransom, magazine));
        }
        [TestMethod]
        public void Task1Test3()
        {
            string ransom = "aa";
            string magazine = "aab";

            Tasks foo = new Tasks();

            Assert.IsTrue(foo.canConstruct(ransom, magazine));
        }
        [TestMethod]
        public void Task1Test4()
        {
            string ransom = "aaa";
            string magazine = "aababa";

            Tasks foo = new Tasks();

            Assert.IsTrue(foo.canConstruct(ransom, magazine));
        }
        [TestMethod]
        public void Task1Test5()
        {
            string ransom = "aaa";
            string magazine = "bbbbb";

            Tasks foo = new Tasks();

            Assert.IsFalse(foo.canConstruct(ransom, magazine));
        }

        [TestMethod]
        public void Task2Test1()
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            int[] answer = { 1, 3, 12, 0, 0 };
            Tasks foo = new Tasks();

            CollectionAssert.AreEqual(answer, foo.Zeros(nums));

        }
        [TestMethod]
        public void Task2Test2()
        {
            int[] nums = { 0, 0, 0, 0, 1 };
            int[] answer = { 1, 0, 0, 0, 0 };
            Tasks foo = new Tasks();

            CollectionAssert.AreEqual(answer, foo.Zeros(nums));
        }
        [TestMethod]
        public void Task2Test3()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int[] answer = { 1, 2, 3, 4, 5 };
            Tasks foo = new Tasks();

            CollectionAssert.AreEqual(answer, foo.Zeros(nums));
        }
        [TestMethod]
        public void Task2Test4()
        {
            int[] nums = { 1, 2, 0, 0, 3, 0, 4 };
            int[] answer = { 1, 2, 3, 4, 0, 0, 0 };
            Tasks foo = new Tasks();

            CollectionAssert.AreEqual(answer, foo.Zeros(nums));
        }

    }
}

