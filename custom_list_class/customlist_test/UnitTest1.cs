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
        //[TestMethod]
        //public void Add_MultiInts_ImprovedArray()
        //{
        //    // Arrange
        //    CustomList<int> list = new CustomList<int>();
        //    CustomList<int> expected = new CustomList<int>() { 1, 2, 3 };
        //    // Act 

        //    list.Add(1);
        //    list.Add(2);
        //    list.Add(3);
        //    Assert.AreEqual(list[0], expected[0]);
        //}
        [TestMethod]
        public void Remove_SingleInt_CountGoesDown()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(12);
            
            // Act
            int Expected = list.Count;
            list.Remove(1);
            // Assert
            Assert.AreEqual(Expected, list.Count);
        }
    }
    }

