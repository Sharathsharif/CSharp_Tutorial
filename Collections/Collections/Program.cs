using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Program
    {
        //static void Main(string[] args)
        //{

            //C sharp collections
            // two types of collection are 
            // 1) Standard Collection
            // 2) Generic Collection

            // 1) Standard Collection

            /*
            ArrayList ar = new ArrayList();
            ar.Add("fxgdh");
            ar.Add(9);
            ar.Add(89.7);
            ar.Add('g');

            foreach (object item in ar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(ar[3]);
            */

            //********************************************************
            // 2) Generic Collection
            // the name space of the generic collection is "using System.Collections.Generic"
            // some of the eg are
            /* i) List
             * ii) Linked list
             * iii) Dictionary
             * iV) Stack
             * V)Queue
             */

            // i) List

            // example 1
            /*
            List<int> ls = new List<int>();

            ls.Add(78);
            ls.Add(67);
            ls.Add(678);
            foreach (int item in ls)
            {
                Console.WriteLine(item);
            }
            */

            //*******************************************************************
            /*
            // example 2
            Console.WriteLine("Enter the size of an array");
            int size = int.Parse(Console.ReadLine());
            List<int> array = new List<int>();
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(" Enter the value");
                array.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(array[0]);
            */

            // Task1
            // add the datas in the generic collection array and must decline the duplicate values in the array
            //Console.WriteLine("Enter the size of an array");
            //int size = int.Parse(Console.ReadLine());
            //List<int> array2 = new List<int>();
            //array2.Add(int.Parse(Console.ReadLine()));
            //for (int i = 1; i < (size); i++)
            //{
            //    int fl = 0;
            //    int value = int.Parse(Console.ReadLine());
            //    for (int s = 0; s <= (i-1); s++)
            //    {

            //            if (value==array2[s])
            //            {
            //            fl = 1;
            //            i--;
            //            break;
            //            }

            //    }
            //    if (fl==0)
            //    {
            //        array2.Add(value);
            //    }
            //    else
            //    {
            //        Console.WriteLine("already in the list.pls nter another one");
            //    }
            //}
            //Console.WriteLine("The Output is");
            //for (int i = 0; i < size; i++)
            //{

            //    Console.Write(array2[i]+" ");
            //}







            // Another method

            /*
            Console.WriteLine("Enter the size of an array");
            int size = int.Parse(Console.ReadLine());
            List<int> array2 = new List<int>();
            array2.Add(int.Parse(Console.ReadLine()));
            for (int i = 1; i < (size); i++)
            {
                int fl = 0;
                int value = int.Parse(Console.ReadLine());
               
                if (!array2.Contains(value))
                {
                    array2.Add(value);
                }
                else
                {
                    i--;
                    Console.WriteLine("already in the list.pls nter another one");
                }
            }
            Console.WriteLine("The Output is");
            for (int i = 0; i < size; i++)
            {

                Console.Write(array2[i] + " ");
            }
            */

            // task 3
            // read a list from a user and printt the sum of list elements.

            //Console.WriteLine("Enter the Size of an list");
            //int a = int.Parse(Console.ReadLine());
            //int b=0;
            //List<int> listar = new List<int>();
            //for (int i = 0; i < a; i++)
            //{
            //    listar.Add(int.Parse(Console.ReadLine()));

            //}
            //for (int i = 0; i < a; i++)
            //{
            //    b = listar[i] + b;
            //}
            //Console.Write("the sum of the list array is ");
            //Console.WriteLine(b);



            //List<int> ls = new List<int>();
            //ls.Add(78);
            //ls.Add(89);
            //ls.Add(23);
            //ls.Add(65);
            //Console.WriteLine("before sorting");
            //foreach (int item in ls)
            //{
            //    Console.WriteLine(item);
            //}
            //ls.Sort();
            //Console.WriteLine("After sorting");
            //foreach (int item in ls)
            //{
            //    Console.WriteLine(item);
            //}
            //ls.Reverse();
            //Console.WriteLine("After reversing");
            //foreach (int item in ls)
            //{
            //    Console.WriteLine(item);
            //}

            //ls.Remove(23);
            //Console.WriteLine("After removing 23");
            //foreach (int item in ls)
            //{
            //    Console.WriteLine(item);
            //}

            //ls.RemoveAt(0);
            //Console.WriteLine("After removing the element at 0th position");
            //foreach (int item in ls)
            //{
            //    Console.WriteLine(item);
            //}

            //ls.RemoveAll(item => item > 70);

            //Console.WriteLine("After removing the element greater than 70");
            //foreach (int item in ls)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

       // }
    }
}
