using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 1;
            //Act
            customList.Add(value);

            // Assert
            Assert.AreEqual(value, customList[0]);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 4;
            int countValue = 1;

            //Act
            customList.Add(value);


            // Assert
            Assert.AreEqual(customList.Count, countValue);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 1;
            int value1 = 2;
            //Act
            customList.Add(value);
            customList.Add(value1);
            Assert.AreEqual(value, customList[0]);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            customList.Add(15);
            customList.Add(24);
            customList.Add(28);
            customList.Add(34);
            customList.Add(47);
            customList.Add(55);
            Assert.AreEqual(15, customList[0]);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            customList.Add(15);
            customList.Add(24);
            customList.Add(28);
            customList.Add(34);
            customList.Add(47);
            customList.Add(55);
            customList.Remove(28);
            Assert.AreEqual(34, customList[2]);
        }
        [TestMethod]
        public void TestMethod6()
        {
            string expected = "152428344755";
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            customList.Add(15);
            customList.Add(24);
            customList.Add(28);
            customList.Add(34);
            customList.Add(47);
            customList.Add(55);
            string actual = customList.ToString();

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod7()
        {
            string expected = "15,24,28,34,47,55";
            CustomList<int> one = new CustomList<int>() { 15, 24, 28};
            CustomList<int> two = new CustomList<int>() { 34, 47, 55};
            
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            customList.Add(15);
            customList.Add(24);
            customList.Add(28);
            customList.Add(34);
            customList.Add(47);
            customList.Add(55); 
            CustomList<int> result = one + two; 
            
            Assert.AreEqual( expected,);

        }
    }
}
