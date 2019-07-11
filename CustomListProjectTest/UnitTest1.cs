using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListProjectTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void Add_AddToEmptyList_ValueGoesToIndexZero()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            int value1 = 1;
            int expected = 1;
            int actual;

            //act
            test.Add(value1);
            actual = test[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Add_AddToList_CountIncrementsProperly()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            int value1 = 1;
            int expected = 1;
            int actual;

            //act
            test.Add(value1);
            actual = test.Count; //?Create a custom property that accounts for how many items are in my custom list


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Add_AddToListWithTwoValues_NewValueGoesToIndexTwo()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int expected = 3;
            int actual;

            //act
            test.Add(value1);
            test.Add(value2);
            test.Add(value3);
            actual = test[2];


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Add_AddtoListWithFullArray_NewArrayCreatedPlusIncremented() //If original capacity is 4...
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int value7 = 6;
            int value8 = 8;
            int value9 = 9;
            int expected = 9;
            int actual;

            //act
            test.Add(value1);
            test.Add(value2);
            test.Add(value3);
            test.Add(value4);
            test.Add(value5);
            test.Add(value6);
            test.Add(value7);
            test.Add(value8);
            test.Add(value9);
            actual = test.Count; //This test is best used when the original capacity of the inner array is less than 5

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Add_InvalidIndexInput_ReturnException()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int actual;


            //act
            test.Add(1);
            actual = test[4];


            //assert
        }
    }
}
