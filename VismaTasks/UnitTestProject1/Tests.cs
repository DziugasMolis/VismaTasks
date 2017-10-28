using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VismaTasks;

namespace TestsForTasks
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Task1Test1()
        {
            // arrange
            string ransom = "a";
            string magazine = "b";
            Tasks foo = new Tasks();

            // act 
            bool actual = foo.CanConstruct(ransom, magazine);

            // assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void Task1Test2()
        {
            // arrange
            string ransom = "aa";
            string magazine = "ab";
            Tasks foo = new Tasks();

            // act 
            bool actual = foo.CanConstruct(ransom, magazine);

            // assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void Task1Test3()
        {
            // arrange
            string ransom = "aa";
            string magazine = "aab";
            Tasks foo = new Tasks();

            // act 
            bool actual = foo.CanConstruct(ransom, magazine);

            // assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void Task1Test4()
        {
            // arrange
            string ransom = "aaa";
            string magazine = "aababa";
            Tasks foo = new Tasks();

            // act 
            bool actual = foo.CanConstruct(ransom, magazine);

            // assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void Task1Test5()
        {
            // arrange
            string ransom = "aaa";
            string magazine = "bbbbb";
            Tasks foo = new Tasks();

            // act 
            bool actual = foo.CanConstruct(ransom, magazine);

            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Task2Test1()
        {
            // arrange 
            int[] nums = { 0, 1, 0, 3, 12 };
            int[] answer = { 1, 3, 12, 0, 0 };
            Tasks foo = new Tasks();

            // act 
            int[] actual = foo.Zeros(nums);

            // assert
            CollectionAssert.AreEqual(answer, actual);

        }
        [TestMethod]
        public void Task2Test2()
        {
            // arrange
            int[] nums = { 0, 0, 0, 0, 1 };
            int[] answer = { 1, 0, 0, 0, 0 };
            Tasks foo = new Tasks();

            // act 
            int[] actual = foo.Zeros(nums);

            // assert
            CollectionAssert.AreEqual(answer, actual);
        }
        [TestMethod]
        public void Task2Test3()
        {
            // arrange
            int[] nums = { 1, 2, 3, 4, 5 };
            int[] answer = { 1, 2, 3, 4, 5 };
            Tasks foo = new Tasks();

            // act 
            int[] actual = foo.Zeros(nums);

            // assert
            CollectionAssert.AreEqual(answer, actual);
        }
        [TestMethod]
        public void Task2Test4()
        {
            // arrange
            int[] nums = { 1, 2, 0, 0, 3, 0, 4 };
            int[] answer = { 1, 2, 3, 4, 0, 0, 0 };
            Tasks foo = new Tasks();

            // act 
            int[] actual = foo.Zeros(nums);

            // assert
            CollectionAssert.AreEqual(answer, actual);
        }

    }
}

