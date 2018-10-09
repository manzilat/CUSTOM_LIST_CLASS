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
        public void Add_MultiObjects_SizeExpands()
        {
            // Arrange
            CustomList<object> list = new CustomList<object>();
            // Act
            object obj = new object();
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);

            int expected = 15;
            // Assert
            Assert.AreEqual(expected, list.Count);

        }
        [TestMethod]
        public void Add_MultiInt_ImprovedArray()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>();
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
            CustomList<int> list = new CustomList<int>();
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
        [TestMethod]
        public void Remove_Object_ResultEqualsTrue()
        {
            // Arrange
            CustomList<object> list = new CustomList<object>();
            list.Add(list);
            list.Add(list);
            // Act
            bool expected = true;
            bool remove = list.Remove(list);
            // Assert
            Assert.AreEqual(expected, remove);
        }
        [TestMethod]
        public void Plus_Bools_ListsConcat()
        {
            // Arrange
            CustomList<bool> list = new CustomList<bool>();
            list.Add(true);
            list.Add(false);
            // Act
            list = list + list;
            bool expected = true;
            // Assert
            Assert.AreEqual(expected, list[2]);
        }
        [TestMethod]
        public void Plus_Strings_ConcatLists()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            list.Add("one");
            list.Add("Two");
            // Act
            list = list + list;
            string expected = "Two";
            // Assert
            Assert.AreEqual(expected, list[3]);
        }
        [TestMethod]
        public void Plus_Ints_CountIncrease()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            // Act
            list = list + list;
            int expected = 6;
            // Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void Minus_Strings_IndexShifts()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            list.Add("true");
            list.Add("true");
            list.Add("false");
            CustomList<string> otherList = new CustomList<string>();
            list.Add("true");
            // Act
            string expected = "true";
            list = list - otherList;
            // Assert
            Assert.AreEqual(expected, list[1]);
        }
        [TestMethod]
        public void Minus_Bool_CountDecrease()
        {
            // Arrange
            CustomList<bool> list = new CustomList<bool>();
            list.Add(true);
            list.Add(true);
            list.Add(true);

            // Act
            int expected = 0;
            list = list - list;
            // Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void Minus_Objects_CountDecreases()
        {
            // Arrange
            CustomList<object> list = new CustomList<object>() { };
            list.Add(list);
            // Act
            int expected = 0;
            list = list - list;
            // Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void ToString_MultiInts_ReturnOneString()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            // Act
            string expected = "123";
            string result = list.ToString();
            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ToString_Bools_ReturnOneString()
        {
            // Arrange
            CustomList<bool> list = new CustomList<bool>();
            list.Add(true);
            list.Add(false);
            list.Add(true);

            // Act
            string expected = "TrueFalseTrue";
            string result = list.ToString();
            // Assert
            Assert.AreEqual(expected, result);
        }
        // Zip TestMethods
        [TestMethod]
        public void ZipListProperties_ListPropertiesString_ListPropertiesZipped()
        {
            //Arrange
            CustomList<string> expectedResult = new CustomList<string>();
            expectedResult.Add("A");
            expectedResult.Add("B");
            expectedResult.Add("C");
            expectedResult.Add("D");

            CustomList<string> stringsA = new CustomList<string>();
            CustomList<string> stringsB = new CustomList<string>();
            CustomList<string> actualResult = new CustomList<string>();
            stringsA.Add("A");
            stringsA.Add("C");
            stringsB.Add("B");
            stringsB.Add("D");

        }
        [TestMethod]
        public void ZipList_Listint_ListZipped()
        {
            //Arrange
            CustomList<int> expectedResult = new CustomList<int>();
                 
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);


            CustomList<int> moreNumbers = new CustomList<int>();
            CustomList<int> actualResult = new CustomList<int>();
            list.Add(1);
            list.Add(3);
            moreNumbers.Add(2);
            moreNumbers.Add(4);

            //Act
            actualResult = list.Zip(moreNumbers);

            //Assert
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }
    }

}

















