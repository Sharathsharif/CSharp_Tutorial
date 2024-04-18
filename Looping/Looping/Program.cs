using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            // Task 1 *****************************************************
            // to print the even  number

            /*int i = 0;
            while (i<=10)
            {
                Console.WriteLine(i);
                i+=2;
            }*/


            // Task 2 ******************************************
            // to print the factor of input number

            /* int i = 1;
            Console.WriteLine("Enter the value to find the");

            int factor = int.Parse(Console.ReadLine()); 
            while (i<=(factor/2))
            {
                if (factor%i == 0)
                {
                    Console.WriteLine(i);
                }
                    i++;
            }*/



            // Task 3 *********************************************
            // to print the multiplication Table
            /*
            int i = 0;
            Console.WriteLine("ENTER A NUMBER");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the limit");
            int B = int.Parse(Console.ReadLine());
            while (i<=B)
            {
                int sum = i * A;
                Console.WriteLine(i +"*"+A+ "="+sum);

                i++;
            }

            */

            // write a  C# program to calculate a factorial of a number
            /*Console.WriteLine("Enter the Number");
            int Number = int.Parse(Console.ReadLine());
            int i = 1;
            int value = 1;
            while (i<= Number)
            {
                value = value * i;
                i++;
            }
            Console.Write(value);
            */





            /// for  Loop *********************************
            /// Task 1
            // to print the number from 0 to 10
            /*
            int i;
            for ( i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */


            // Task 2 *************************************
            // find the factors of a number

            /* Console.WriteLine("Enter a number to find its factor");
            int a = int.Parse(Console.ReadLine());
            int i;
            for ( i = 1; i <= a/2; i++)
            {
                if (a%i==0)
                {
                    Console.WriteLine(i);
                }
            }*/


            // Task 3 *****************************
            // to check the entered number is a strong number
            /* Console.WriteLine("Enter a Number to check its is a Strong number or not");
             int num = int.Parse(Console.ReadLine());
             int i;
             int sum=0;
             for ( i = 1; i <= num/2; i++)
             {

                 if (num%i==0)
                 {
                     sum = sum + i;
                 }

             }
             if (sum == num)
             {
                 Console.WriteLine("It is a Strong number");

             }
             else 
             {
                 Console.WriteLine("It is not a Strong number");

             }*/


            // Task 4 **********************************
            // To bring a reverse off a number
            /*
            Console.WriteLine("Enter the 3 digit Number to bring a reverse off a number");
            int num =  int.Parse(Console.ReadLine()); // eg 123
            int reversednum = 0; // initial value assigned as zero
          
            int r;   // temporary variable to find remainder
            for ( ; num != 0; )
            {
                r = num % 10; // for finding the remainder value // step 1=(3) step 2=(2) step=(1)
                reversednum = (reversednum * 10) + r;
                num = num / 10; // for finding the coefficient // step 1=(12 ) step2 =(1) step =(0)

            }
            Console.WriteLine(reversednum);
            */


            // Task 5******************************
            // amstrong **********************
            // To find the number wheather it is a Amstrong *****
            /*
            Console.WriteLine("Enter a Number to check Wheather it is a Amstrong Number?");

            int n = int.Parse(Console.ReadLine());
            int starting = n;
            int remained = 0;
            int value = 0;
            int total = 0;
            for (; n!=0; )
            {
                remained = n % 10;
                value = remained * remained * remained;
                total = total + value;
                n = n / 10;
            }
            if (starting == total)
            {
                Console.WriteLine(  "{0} is a Amstrong Number", starting);
            }
            else
            {
                Console.WriteLine("{0} is  Not a Amstrong Number",starting);
            }
            */

            // Task6 *******************************************
            // To find the Prime Numbers

            /*
            Console.WriteLine(  "Enter a Number to find wheather it is  a Prime Number or not ?");
            int n = int.Parse(Console.ReadLine());
            int i;
            int f = 0;

            if(n==2 || n == 3)
            {
                Console.WriteLine("It is a Prime Number");

            }
            else
            {

                    for (i=2; i<=n/2; i++ )
                    {
                        if (n % i == 0)
                        {
                   
                            f = 1;
                                break;
                        }
             
                    }

                if (f == 0)
                {
                    Console.WriteLine("It is a Prime Number");
                }
                else
                {
                    Console.WriteLine("It is not a Prime Number");

                }
            }
            */


            // For Each loop
            // find how many letter give in an input field using foreach loop
            /*
            Console.WriteLine("Enter a word to find its character count");
            string input = Console.ReadLine();
            int count = 0;
            foreach (char item in input)
            {
                count++;
            }
            Console.WriteLine(count);
            */

            // Task2 ********************************
            // count the character in a word which are vowels
            /*
            Console.WriteLine("count the character in a word which are vowels");
            string word = Console.ReadLine();
            int count = 0;

            foreach (char item in word)
            {
                
                if ( (item== 'a')||(item=='e')||(item=='i') || (item=='o') || (item=='u'))
                {
                    count++;
                }
           
            }
            Console.WriteLine(count);
            */

            // Task 3
            // write a C# program to count how many words in a sentence
            /*
            Console.WriteLine("Enter a Sentence to count its words");
            string sente = Console.ReadLine();
            int count = 0;
            
            foreach (char letters in sente)
            {
                if ( letters==' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count+1);
            */


            // 


           

            Console.ReadKey();
        }
    }
}
