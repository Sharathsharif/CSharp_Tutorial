using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task1
            // Enter the size of an array and ask for the array values.
            // later the array value must me displayed in reverse order.

            /* Console.WriteLine("Enter the size of an array");
             int size = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter the {0} elements",size);
             int[] array1 = new int[size];

             for (int i = 0; i < size; i++)
             {
                 array1[i]= int.Parse(Console.ReadLine());
             }

             // for displaying the array element

             Console.Write("All the elements in the Array are ");

             for (int i = (size-1); i >= 0; i--)
             {
                 Console.Write(array1[i]+" ");
             }*/


            // Task2
            // To calculate the sum of array values
            /*
            Console.WriteLine("Enter the Size of an Array");
            int size = int.Parse(Console.ReadLine());
            int [] array2=new int[size];
            Console.WriteLine("Enter the {0} Elements", size);

            for (int i = 0; i < size; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            // to calculate the sum of values stored in the array
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += sum + array2[i];
            }
            Console.WriteLine(sum);
            */


            // Task3 
            //users input data for a array must only accept even numbers

            Console.WriteLine("Enter the size of an Array");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the {0} elements. note the value must be even numbers",size);
            int[] array3 = new int[size];
            int value = 0;
            for (int i = 0; i < size; i++)
            {
                value = value+ int.Parse(Console.ReadLine());
                if (value % 2 == 0)
                {
                    array3[i] = value;
                    value = 0;
                }
                else
                {
                    Console.WriteLine("Please enter the even numbers");
                    i--;
                    value = 0;
                }
            }
            Console.Write("The elements in the Array are ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(array3[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
