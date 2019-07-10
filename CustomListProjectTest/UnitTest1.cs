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
            int expected = 1;
            int actual;

            //act
            test.Add(1);
            actual = test[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Add_AddToList_CountIncrementsProperly()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            int expected = 1;
            int actual;

            //act
            test.Add(1);
            actual = test.ListCount; //?Create a custom property that accounts for how many items are in my custom list


            //assert
            Assert.AreEqual(expected, actual);
        }

        public void Add_AddToListWithTwoValues_NewValueGoesToIndexTwo()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            int expected = 3;
            int actual;

            //act
            test.Add(1);
            test.Add(2);
            test.Add(3);
            actual = test[2];


            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
