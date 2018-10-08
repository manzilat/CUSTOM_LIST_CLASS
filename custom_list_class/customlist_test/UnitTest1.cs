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
            int expected = 0;

            // Act
           

            //Assert
            Assert.AreEqual(expected, numbers[1]);

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
            int expected = 6;
            // Act
            numbers.Add(2);
            numbers.Add(6);
            
            //Assert
            Assert.AreEqual(expected, numbers[1]);

        }
        [TestMethod]
        public void Add_MultipleObjects_ToList()
        {
            //Arrange
            CustomList<String> list = new CustomList<string>();
            //Act
            list.Add("hi");
            list.Add("bye");
            list.Add("hello");
            //Assert
            Assert.AreEqual(list.size, 3);
        }
    }
}

