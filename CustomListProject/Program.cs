using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> test = new CustomList<int>(); //*TESTING CODE*
                                                          //test.Add(1);
                                                          //Console.WriteLine(test[0]);
                                                          //test.Add(2);
                                                          //Console.WriteLine(test[1]);
                                                          //test.Add(3);
                                                          //Console.WriteLine(test[2]);
                                                          //test.Add(4);
                                                          //Console.WriteLine(test[3]);
                                                          //test.Add(5);
                                                          //Console.WriteLine(test[4]);
                                                          //test.Add(6);
                                                          //Console.WriteLine(test[5]);
                                                          //test.Add(7);
                                                          //Console.WriteLine(test[6]);
                                                          //test.Add(8);
                                                          //Console.WriteLine(test[7]);
                                                          //test.Add(9);
                                                          //Console.WriteLine(test[8]);
                                                          //test.Add(10);
                                                          //Console.WriteLine(test[9]);
                                                          //Console.ReadLine();
                                                          //test.Remove(4);
                                                          //Console.WriteLine(test);
                                                          //Console.ReadLine();
                                                          //test.Remove(1);
                                                          //test.Remove(10);
                                                          //test.Remove(6);
                                                          //test.Remove(3);
                                                          //Console.WriteLine(test);
                                                          //Console.ReadLine();


            //test.Add(1);
            //Console.WriteLine(test[0]);
            //test.Add(2);
            //Console.WriteLine(test[1]);
            //test.Add(3);
            //Console.WriteLine(test[2]);
            //test.Add(4);
            //Console.WriteLine(test[3]);
            //test.Add(5);
            //Console.WriteLine(test[4]);
            //test.Add(6);
            //Console.WriteLine(test[5]);
            //test.Add(7);
            //Console.WriteLine(test[6]);
            //test.Add(8);
            //Console.WriteLine(test[7]);
            //test.Add(9);
            //Console.WriteLine(test[8]);
            //test.Add(10);
            //Console.WriteLine(test[9]);
            //Console.ReadLine();
            //Console.WriteLine(test.ToString());
            //Console.ReadLine();


            //CustomList<int> one = new CustomList<int>();
            //CustomList<int> two = new CustomList<int>();
            //one.Add(1);
            //one.Add(2);
            //one.Add(3);
            //one.Add(4);
            //one.Add(5);
            //Console.WriteLine(one);
            //Console.WriteLine(one.Count);
            //Console.WriteLine(one.Capacity);
            //Console.ReadLine();
            //two.Add(9);
            //two.Add(2);
            //two.Add(3);
            //Console.WriteLine(two);
            //Console.ReadLine();
            //CustomList<int> result = one - two;
            //Console.WriteLine(result);
            //Console.ReadLine();


            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value7 = 7;
            int value9 = 9;
            int value11 = 11;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            odd.Add(value1);
            odd.Add(value3);
            odd.Add(value5);
            odd.Add(value7);
            odd.Add(value9);
            odd.Add(value11);
            even.Add(value2);
            even.Add(value4);
            even.Add(value6);
            Console.WriteLine(odd);
            Console.WriteLine(even);
            Console.ReadLine();
            Console.WriteLine(odd.Zipper(even));
            Console.ReadLine();
        }
    }
}
