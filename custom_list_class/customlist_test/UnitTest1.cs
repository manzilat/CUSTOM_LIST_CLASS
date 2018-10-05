using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using custom_list_class;
using System.Collections.Generic;

namespace custom_list_class
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_EmptyList_ValueToIndexZero()
        {

            // Arrange
            CustomList<int> numbers = new CustomList<int>();
            int expected = 1;

            // Act
            numbers.Add(2);

            //Assert
            Assert.AreEqual(expected, numbers[0]);

        }

        [TestMethod]
        public void Add_EmptyList_CountOfOne()
        {

            // Arrange
            CustomList<int> numbers = new CustomList<int>();
            int expected = 1;
            // Act
            numbers.Add(100);
            //Assert
            Assert.AreEqual(expected, numbers.Count);
        }

        [TestMethod]
        public void Add_TwoItems_SecondItemGoesToIndexOne()
        {

            // Arrange
            CustomList<int> numbers = new CustomList<int>();
            int expected = 1;
            // Act
            numbers.Add(2);
            //Assert
            Assert.AreEqual(expected, numbers[0]);


        }
    }
}
