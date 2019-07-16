using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListProjectTest
{
    [TestClass]
    public class CustomListTest
    {
        //ADD METHOD TESTS
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
            actual = test.Count; 


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
            test.Add(value1);
            test.Add(value2);
            actual = test[4];


            //assert
        }


        //--------------------------------------------
        //REMOVE METHOD TESTS

        [TestMethod]
        public void Remove_RemoveFromList_CountDecrementsProperly()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int expected = 3;
            int actual;


            //act
            test.Add(value1);
            test.Add(value2);
            test.Add(value3);
            test.Add(value4);
            test.Remove(value4);
            actual = test.Count;


            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        public void Remove_RemoveValidItem_ReturnTrueItemExists() 
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            bool expected = true;
            bool actual;


            //act
            test.Add(value1);
            test.Add(value2);
            test.Add(value3);
            test.Add(value4);
            actual = test.Remove(value2);


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Remove_RemoveItem_ListShiftsLeft() //also make sure count goes down 1
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int expected = 3;
            int actual;


            //act
            test.Add(value1);
            test.Add(value2);
            test.Add(value3);
            test.Add(value4);
            test.Remove(value2);
            actual = test[1];


            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]

        public void Remove_RemoveItem_ReturnFalseItemNonexistent() 
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            bool expected = false;
            bool actual;


            //act
            test.Add(value1);
            test.Add(value2);
            test.Add(value3);
            test.Add(value4);
            actual = test.Remove(value5);


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveItemFromList_CapacityRemainsSame()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int expected = 4;
            int actual;

            //act
            test.Add(value1);
            test.Add(value2);
            test.Add(value3);
            test.Add(value4);
            test.Remove(value4);
            actual = test.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }

        //---------------------------------------------------
        //TO STRING TESTS

        [TestMethod]

        public void ToString_OverrideToString_ReturnAccurateStringLength()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int expected = 4;
            string newString;
            int actual;
            

            //act
            test.Add(value1);
            test.Add(value2);
            test.Add(value3);
            test.Add(value4);
            newString = test.ToString();
            actual = newString.Length;


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void ToString_OverrideToString_ReturnStringofContents()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            string expected = "1234";
            string actual;

            //act
            test.Add(value1);
            test.Add(value2);
            test.Add(value3);
            test.Add(value4);
            actual = test.ToString();


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void ToString_OverrideBoolToString_ReturnBoolStrings()
        {
            //arrange
            CustomList<bool> test = new CustomList<bool>();
            bool value1 = true;
            bool value2 = false;
            bool value3 = true;
            bool value4 = false;
            string expected = "TrueFalseTrueFalse";
            string actual;

            //act - make sure a specific index of the old list has the same value as the corresponding index of the newly ToString'd list
            test.Add(value1);
            test.Add(value2);
            test.Add(value3);
            test.Add(value4);
            actual = test.ToString();


            //assert
            Assert.AreEqual(expected, actual);
        }

        //----------------------------------------------------------------
        //OVERLOAD OPERATOR + TESTS

        [TestMethod]

        public void OverloadPlus_AddTwoLists_ReturnSingleList()
        {
            //arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            string expected;
            string actual;

            //act
            one.Add(value1);
            one.Add(value3);
            one.Add(value5);
            two.Add(value2);
            two.Add(value4);
            two.Add(value6);
            result.Add(value1);
            result.Add(value3);
            result.Add(value5);
            result.Add(value2);
            result.Add(value4);
            result.Add(value6);
            CustomList<int> actualList = one + two;
            expected = result.ToString();
            actual = actualList.ToString();


            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        public void OverloadPlus_AddTwoLists_AccurateCount()
        {
            //arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int expected = 6;
            int actual;

            //act
            one.Add(value1);
            one.Add(value3);
            one.Add(value5);
            two.Add(value2);
            two.Add(value4);
            two.Add(value6);
            CustomList<int> actualList = one + two;
            actual = actualList.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void OverloadPlus_AddTwoLists_ReturnCorrectIndex()
        {
            //arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int expected = 2;
            int actual;

            //act
            one.Add(value1);
            one.Add(value3);
            one.Add(value5);
            two.Add(value2);
            two.Add(value4);
            two.Add(value6);
            CustomList<int> actualList = one + two;
            actual = actualList[3];


            //assert
            Assert.AreEqual(expected, actual);
        }

        //-----------------------------------------
        //OVERLOAD OPERATOR - TESTS

        [TestMethod]

        public void OverloadMinus_SubtractTwoLists_CountDecrementsProperly()
        {
            //arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value5 = 5;
            int value6 = 6;
            int expected = 2;
            int actual;


            //act
            one.Add(value1);
            one.Add(value3);
            one.Add(value5);
            two.Add(value2);
            two.Add(value1);
            two.Add(value6);
            CustomList<int> actualList = one - two;
            actual = actualList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void OverloadMinus_SubtractTwoList_OnlyOneInstanceRemoved() //create an index copy
        {
            //arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value5 = 5;
            int value6 = 6;
            int expected = 4;
            int actual;


            //act
            one.Add(value1);
            one.Add(value3);
            one.Add(value5);
            one.Add(value1);
            one.Add(value1);
            two.Add(value2);
            two.Add(value1);
            two.Add(value6);
            CustomList<int> actualList = one - two;
            actual = actualList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void OverloadMinus_SubtractTwoLists_ReturnCorrectIndex()
        {
            //arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value5 = 5;
            int value6 = 6;
            int expected = 3;
            int actual;


            //act
            one.Add(value1);
            one.Add(value3);
            one.Add(value5);
            two.Add(value2);
            two.Add(value1);
            two.Add(value6);
            CustomList<int> actualList = one - two;
            actual = actualList[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void OverloadMinus_SubtractTwoList_DuplicateInstanesIndexedProperly()
        {
            //arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value5 = 5;
            int value6 = 6;
            int expected = 1;
            int actual;


            //act
            one.Add(value1);
            one.Add(value3);
            one.Add(value5);
            one.Add(value1);
            one.Add(value1);
            two.Add(value2);
            two.Add(value1);
            two.Add(value6);
            CustomList<int> actualList = one - two;
            actual = actualList[2];

            //assert
            Assert.AreEqual(expected, actual);
        }

        //----------------------------------------------
        //ZIPPER METHOD TESTS

        [TestMethod]

        public void Zipper_ZipTwoLists_CountIncrementsProperly()
        {
            //arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int expected = 6;
            int actual;

            

            //act
            odd.Add(value1);
            odd.Add(value3);
            odd.Add(value5);
            even.Add(value2);
            even.Add(value4);
            even.Add(value6);
            result = odd.Zipper(even);
            actual = result.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Zipper_ZipTwoLists_ReturnCorrectIndex()
        {
            //arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int expected = 3;
            int actual;


            //act
            odd.Add(value1);
            odd.Add(value3);
            odd.Add(value5);
            even.Add(value2);
            even.Add(value4);
            even.Add(value6);
            result = odd.Zipper(even);
            actual = result[2];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Zipper_ZipTwoLists_ReturnProperString()
        {
            //arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            string expected = "123456";
            string actual;


            //act
            odd.Add(value1);
            odd.Add(value3);
            odd.Add(value5);
            even.Add(value2);
            even.Add(value4);
            even.Add(value6);
            result = odd.Zipper(even);
            actual = result.ToString();


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Zipper_ZipTwoLists_IndexIncreasesProperly()
        {
            //arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int expected = 8;
            int actual;


            //act
            odd.Add(value1);
            odd.Add(value3);
            odd.Add(value5);
            even.Add(value2);
            even.Add(value4);
            even.Add(value6);
            result = odd.Zipper(even);
            actual = result.Capacity;


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Zipper_ZipTwoListsOfDifferentLengths_ReturnListWithExtraNumbersAtEnd()
        {
            //arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int value7 = 7;
            int value9 = 9;
            int value11 = 11;
            int value13 = 13;
            string expected = "123456791113";
            string actual;


            //act
            odd.Add(value1);
            odd.Add(value3);
            odd.Add(value5);
            odd.Add(value7);
            odd.Add(value9);
            odd.Add(value11);
            odd.Add(value13);
            even.Add(value2);
            even.Add(value4);
            even.Add(value6);
            result = odd.Zipper(even);
            actual = result.ToString();


            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
