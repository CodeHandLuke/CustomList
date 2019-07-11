using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        //member variables
        private int count; //make a get for the count
        private int capacity; //make a get for the capacity
        public T[] items;
        public T this[int index]
        {
            get
            {
                return items[index];
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

        public void ResizeArray()
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
    }
}
