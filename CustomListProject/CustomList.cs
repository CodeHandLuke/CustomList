﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable
    {
        //member variables
        private int count; //make a get for the count
        private int capacity; //make a get for the capacity
        public T[] items;
        public T this[int index]
        {
            get
            {
                if (index < 0 || index > count - 1)
                {
					throw new ArgumentOutOfRangeException();
                }

                else
                {
                    return items[index];
                }
            }
            set
            {
                items[index] = value;
            }
}

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
        }

        





        //constructor
        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
            count = 0;
            
        }


        //member methods
        public void Add(T item)
        {
            if (count == capacity)
            {
                ResizeArray();
                items[count] = item;
                count++;
            }
            else
            {
                items[count] = item;
                count++;

            }
        }

        public void ResizeArray() //this will be used to create a new array, double its size, and copy the old array into the new one.
        {
            T[] tempItems;
            capacity *= 2;
            tempItems = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                tempItems[i] = items[i]; 
            }
            items = tempItems; //left is where we want it to go, right is where it is coming from
        }

        //--------------------------------------
        //REMOVE METHOD

        public bool Remove(T item) //
        {
            bool isFound = false;
            for (int i = 0; i < count; i++) //checklist
            {
                if (items[i].Equals(item) && !isFound) //determines bool
                {
                    //if/else check to make sure that there actually is another index. i.e. if count = 1, do a direct replacement, else, => go to next index logic
                    // Replacing with next index
                    // then I want to have that 'i' equal the item in the next index
                    // I will repeat this process until the end of the array
                    //**First check to see if the index we are at equals item, if so, then only ++ index i.
                    //**If it doesn't match the item, then items i = temparray j; then increment both indices
                    //Be sure to write in logic that accounts for only removing the first instance of item. i.e. if user wanted to remove '2' from the list, make sure only the first 2 is removed, not any other instances of 2.
                    isFound = true;
                }

                if (isFound) //remover
                {
                    RemoveNewTempArray(item);
                    count--;
                    return true;
                }
            }
            return false;
        }

        public void RemoveNewTempArray(T item)
        {
            T[] tempItems;
            tempItems = new T[capacity];
            int j = 0;
            bool foundInstance = false;
            for (int i = 0; i < count; i++, j++)
            {
                if (items[i].Equals(item) && !foundInstance)
                {
                    j--;
                    foundInstance = true;
                }
                else
                {
                    if (!items[i].Equals(null))
                    {
                        tempItems[j] = items[i];
                    }
                }
            }
            items = tempItems;
        }

        //---------------------------------------
        //TO STRING METHOD

        public override string ToString()
        {
            string newString = "";
            for (int i = 0; i < count; i++)
            {
                newString += items[i].ToString();
            }
            return newString;
        }

        //-----------------------------------
        //OVERLOAD + OPERATOR

        public static CustomList<T> operator +(CustomList<T> item1, CustomList<T> item2)
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < item1.count; i++)
            {
                newList.Add(item1[i]);
            }
            for (int i = 0; i < item2.count; i++)
            {
                newList.Add(item2[i]);
            }
            return newList;
            //
        }

        //-----------------------------------
        //OVERLOAD - OPERATOR

        public static CustomList<T> operator -(CustomList<T> item1, CustomList<T> item2)
        {
            //Create a new list that will hold the result of the two lists being subtracted
            //Have a for loop that looks to see if list 1 and 2 share an instance
            //Once that instance is found, print out list 1 with the first instance of the shared value being removed
            CustomList<T> newList = new CustomList<T>();
            CustomList<T> output = new CustomList<T>();
            //First create a new list that is a copy of "item2", the second list.
            for (int i = 0; i < item2.Count; i++)
            {
                newList.Add(item2[i]);
            }

            for (int i = 0; i < item1.Count; i++)
            {
                bool foundInstance = false;
                for (int j = 0; j < newList.Count; j++)
                {
                    //If a value in item1 is found in item2, the boolean foundInstance will return true and that corresponding instance is removed from item2 ensuring it won't be compared to any other instances in item1.
                    if (item1[i].Equals(newList[j]) && !foundInstance)
                    {
                        newList.Remove(newList[j]);
                        foundInstance = true;
                        j--;
                        //It is important to decrement 'j' to ensure that the method doesn't throw an out of range exception. Whenever a value is removed from a list, the index is decremented by one so we have to check the placeholder of the value that was removed
                    }

                    if (j == newList.Count - 1)
                    {
                        if (!foundInstance)
                        {
                            output.Add(item1[i]);
                            //If a match for a value in item1 was not found in item2, it is added to the output list.
                        }
                    }
                }
            }
            return output;
        }

        //---------------------------------------------------
        //ZIPPER METHOD

        public CustomList<T> Zipper(CustomList<T> item1) //maybe create a method with only one parameter to pass in
        {
            int maxLength;
            if (count > item1.Count)
            {
                maxLength = count;
            }

            else
            {
                maxLength = item1.Count;
            }

            CustomList<T> output = new CustomList<T>();
            for (int i = 0; i < maxLength; i++)
            {
                if (i < count)
                {
                    output.Add(items[i]);
                }

                if (i < item1.Count)
                {
                    output.Add(item1[i]);
                }
            }
            return output;
        }

		public IEnumerator GetEnumerator()
		{
			for (int i = 0; i < items.Length; i++)
			{
				yield return items[i];
			}
		}
	}
}
