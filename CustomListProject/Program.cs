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
            test.Add(1);
            Console.WriteLine(test[0]);
            test.Add(2);
            Console.WriteLine(test[1]);
            test.Add(3);
            Console.WriteLine(test[2]);
            test.Add(4);
            Console.WriteLine(test[3]);
            test.Add(5);
            Console.WriteLine(test[4]);
            test.Add(6);
            Console.WriteLine(test[5]);
            test.Add(7);
            Console.WriteLine(test[6]);
            test.Add(8);
            Console.WriteLine(test[7]);
            test.Add(9);
            Console.WriteLine(test[8]);
            Console.ReadLine();
            test.Remove(1);
            Console.WriteLine(test[0]);
            Console.ReadLine();
            Console.WriteLine(test[0]);
            Console.WriteLine(test[1]);
            Console.WriteLine(test[2]);
            Console.WriteLine(test[3]);
            Console.WriteLine(test[4]);
            Console.WriteLine(test[5]);
            Console.WriteLine(test[6]);
            Console.WriteLine(test[7]);
            Console.WriteLine(test[8]);
            Console.WriteLine(test[9]);
            Console.ReadLine();

        }
    }
}
