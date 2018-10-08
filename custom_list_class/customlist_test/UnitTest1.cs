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
        public void Add_MultiInt_ImprovedArray()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>() ;
            list.Add(1);
            list.Add(2);
            list.Add(3);
            // Act 

            list.Add(5);
            list.Add(6);
            list.Add(4);
            Assert.AreEqual(list[6], expected[1]);
        }
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
            Assert.AreNotEqual(Expected, list.Count);
        }
        [TestMethod]
        public void Remove_SingleString_IndexChange()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            // Act

            list.Remove("One");
            string expected = "Three";
            // Assert
            Assert.AreEqual(expected, list[1]);
        }
        [TestMethod]
        public void Remove_MultiInt_IndexChange()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>() ;
            int expected = 5;
            list.Add(0);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            // Act

            list.Remove(0);
            list.Remove(3);
            // Assert
            Assert.AreEqual(expected, list[2]);
        }
        [TestMethod]
        public void Remove_Nothing_ResultEqualsFalse()
        {
            // Arrange
            CustomList<object> list = new CustomList<object>();
            // Act
            bool expected = false;
            bool remove = list.Remove(list);
            // Assert
            Assert.AreEqual(expected, remove);
        }
    }
    }

