using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Dimensional_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            // Task 1
            // storing the data in the two dimensional array manually and displaying it.

            /*
             int[,]array1=new int[2, 2];
             array1[0, 0] = 55;
             array1[0, 1] = 52;
             array1[1, 0] = 44;
             array1[1, 1] = 10;


             // first loop is for row
             for (int r = 0; r < 2; r++)
             {

                 // second loop is for column
                 for (int c = 0; c < 2; c++)
                 {
                     Console.Write(array1[r,c] +" ");
                 }
                 //another console.writeline is for the coloum break
                 Console.WriteLine();
             }
             */

            //*******************************************************************

            //Task2
            // storing the two dimenional array data using input field and display them
            /*
            Console.WriteLine("Enter the size of Two dimensional array");
            Console.WriteLine("Enter the size of Row");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the size of coloumn");
            int b = int.Parse(Console.ReadLine());

            int[,] array2 = new int[a, b];

            // storing data
            for (int r = 0; r < a; r++)
            {
                for (int c = 0; c < b; c++)
                {
                    Console.WriteLine(" enter the value");
                    array2[r, c] = int.Parse(Console.ReadLine());
                }
            }

            /// Displaying data
            for (int r = 0; r < a; r++)
            {
                for (int c = 0; c < b; c++)
                {
                    Console.Write(array2[r,c]+" ");
                }
                Console.WriteLine();
            }
            */

            //******************************************************************

            // Task2
            // in a Square array the diagonal  value must be change into "*"

            /*
            Console.WriteLine(" Enter the size of an array which are in the form of square");
            Console.WriteLine("Enter the row size");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the column size");
            int b = int.Parse(Console.ReadLine());

            if (a==b)
            {
                int[,] array3 = new int[a, a];

                // Reading the values of the array
                for (int r = 0; r < a; r++)
                {

                    for (int c = 0; c < a; c++)
                    {
                        array3[r, c] = int.Parse(Console.ReadLine());
                    }
                }


                // displaying the value
                Console.WriteLine("the Output is");
                for (int r = 0; r < a; r++)
                {
                    for (int c = 0; c < a; c++)
                    {
                        if (r == c)
                        {

                            Console.Write('*' + " ");

                        }
                        else
                        {

                            Console.Write(array3[r, c] + " ");
                        }

                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("please enter the correct square array size");
            }
            */

            // ****************************************************************
            // Task 3
            // printing pattern
            /*
            Console.WriteLine(" enter a size to print a pattern length");
            int a = int.Parse(Console.ReadLine());
            int[,] array3 = new int[a, a];
            for (int r = 0; r < a; r++)
            {
                for (int c = 0; c <= r; c++)
                {
                    Console.Write('*' + " ");
                }
                Console.WriteLine();
            }*/

            // ****************************************************************
            // Task 4
            // printing pattern in a  reverse order
            /*
            Console.WriteLine(" enter a size to print a pattern length");
            int a = int.Parse(Console.ReadLine());
            int[,] array3 = new int[a, a];
            for (int r = 0; r < a; r++)
            {
                for (int c = a; c > r; c--)
                {
                    Console.Write('*' + " ");
                }
                Console.WriteLine();
            }
            */
            // Task 5
            // create a 2 dimensional array like below
            /*
             * 1
             * 1 2
             * 1 2 3
             * 1 2 3 4
             * 1 2 3 4 5
             */

            //ANswer
            /*
            Console.WriteLine(" Enter the array Size");
            int a = int.Parse(Console.ReadLine());
            int[,] array5 = new int[a, a];

            for (int r = 0; r < a; r++)
            {
                for (int c = 0; c <=r; c++)
                {
                    Console.Write(c + 1 +" ");
                }
                Console.WriteLine();
            }
            */

            // Task6
            // create a 2 dimensional array like below
            /*
             * 1
             * 1 0
             * 1 0 1
             * 1 0 1 0
             * 1 0 1 0 1
             */
            /*
            Console.WriteLine(" Enter the array Size");
            int a = int.Parse(Console.ReadLine());
            int[,] array5 = new int[a, a];

            for (int r = 0; r < a; r++)
            {
                for (int c = 0; c <= r; c++)
                {
                    if (c%2==0)
                    {
                    Console.Write( 1 + " ");

                    }
                    else
                    {
                        Console.Write(0 + " ");

                    }
                }
                Console.WriteLine();
            }
            */

            // Task6
            // create a 2 dimensional array like below
            /*
             * 1
             * 1 1
             * 1 0 1
             * 1 0 0 1
             * 1 0 0 0 1
             * 1 1 1 1 1 1
             */

            /*
            Console.WriteLine(" enter the row count");
            int a = int.Parse(Console.ReadLine());
            int b = a - 1;
            int[,]array6= new int[a, a];

            Console.WriteLine("Output is");
            for (int r = 0; r < a; r++)
            {
                for (int c = 0; c <= r; c++)
                {
                    
                    if ((r==c) || (c==0) || (r==b))
                    {
                    Console.Write("1" + ' ');

                    }
                    else
                    {
                        Console.Write("0" + ' ');

                    }
                }
                Console.WriteLine();
            } */


            // task7 
            // create a multi dimensional array pattern in a triangle in center

            Console.WriteLine("Enter a size of an array in odd number");
            int a = int.Parse(Console.ReadLine());
            int b = a / 2;
            int[,] array7 = new int[a, a];
            for (int r = 0; r <= a; r++)
            {
                for (int c = 0; c <= a; c++)
                {
                    int d = b- r;
                    if (c>=d)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            

            Console.ReadKey();
        }
    }
}
