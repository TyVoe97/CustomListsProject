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
            int value = 2;
            //Act
            customList.Add(value);

            // Assert
            Assert.AreEqual(value, customList[0]);
        }
        public void TestMethod2()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 2;
            int countValue = 1;

            //Act
            customList.Add(value);


            // Assert
            Assert.AreEqual(customList.Count, countValue);
        }
        public void TestMethod3()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 2;
            int value1 = 4;

            //Act
            customList.Add(value);
            customList.Add(value1);


            // Assert
            Assert.AreEqual(value, customList[0]);
        }
    }
}
