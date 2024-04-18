using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class linkedlist
    {
        static void Main(string[] args)

            /* linked list may or may not be continuous
             * the data in the linked list are called  as " nodes"
             * two types of inked list are there
            * linear linked list
            * circular Linked List
            */
        {

            // Examples for linked list funtions (AddFirst , AddLast, AddBefore and Add After)
            /*
            LinkedList<int> ls = new LinkedList<int>();
            ls.AddFirst(10);
            ls.AddFirst(20);
            ls.AddLast(60);
            ls.AddLast(67);
            Console.WriteLine("elements are:");
            foreach (int item in ls)
            {
                Console.Write(item+ " =>");
            }
            LinkedListNode<int> name_of_node = ls.Find(20);
            ls.AddBefore(name_of_node ,50);

            LinkedListNode<int> node = ls.Find(10);
            ls.AddAfter(node, 30);
            Console.WriteLine();
            Console.WriteLine("elements after  add after()");
            foreach (int item in ls)
            {
                Console.Write(item + " =>");
            }
            //LinkedListNode<int> node1 = ls.Find(30);
            ls.AddBefore(node, 55);
            Console.WriteLine();
            Console.WriteLine("elements after  add after()");
            foreach (int item in ls)
            {
                Console.Write(item + " =>");
            }
            */

            // Task1
            // Creating a menu with repeated menu access options



               
            LinkedList<int> listitem = new LinkedList<int>();
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1) Add Headnode");
                Console.WriteLine("2) Add Tailnode");
                Console.WriteLine("3) Add element Before");
                Console.WriteLine("4) Add element after");
                Console.WriteLine("5) Display List");
                Console.WriteLine("6) exit");
                Console.WriteLine("select the list of Option by replying with option number");


                int slno = int.Parse(Console.ReadLine());
                int value = 0;
                int findvalue = 0;
                int Totallist = 0;
                if (slno == 1)
                {
                    Console.WriteLine("Enter the Value to addFirst");
                    value = int.Parse(Console.ReadLine());
                    listitem.AddFirst(value);
                    Console.WriteLine("Value Added");
                    Console.WriteLine();
                    Totallist += 1;
                    value = 0;
                    i--;
                    slno = 0;

                }
                if (slno == 2)
                {
                    Console.WriteLine("Enter the Value to addlast");
                    value = int.Parse(Console.ReadLine());
                    listitem.AddLast(value);
                    Console.WriteLine("Value Added");
                    Console.WriteLine();
                    Totallist += 1;

                    value = 0;
                    i--;
                    slno = 0;

                }
                if (slno == 3)
                {
                    if (!(listitem.Count>0))
                    {
                        Console.WriteLine("Your List is empty");
                        i--;
                        slno = 0;
                    }
                    else
                    {

                        Console.WriteLine("Enter the element to find and add it before");
                        findvalue = int.Parse(Console.ReadLine());
                        if (listitem.Contains(findvalue))
                        {
                            LinkedListNode<int> find1 = listitem.Find(findvalue);
                            Console.WriteLine("Enter an element to add before {0}", findvalue);
                            value = int.Parse(Console.ReadLine());
                            listitem.AddBefore(find1, value);
                            Console.WriteLine("Value Added");
                            Console.WriteLine();
                            Totallist += 1;

                            value = 0;
                            findvalue = 0;
                            i--;
                            slno = 0;

                        }
                        else
                        {
                            Console.WriteLine("Please note the value{0} not able to find or not in the list, please verify it again", findvalue);
                            Console.WriteLine();
                            findvalue = 0;
                            i--;
                            slno = 0;
                        }
                    }
                }
                if (slno == 4)
                
                    {
                    if (!(listitem.Count > 0))
                    {
                        Console.WriteLine("Your List is empty");
                        i--;
                        slno = 0;
                    }
                    else
                    {

                    Console.WriteLine("Enter the element to find and add it after the value");
                        findvalue = int.Parse(Console.ReadLine());
                        if (listitem.Contains(findvalue))
                        {
                            LinkedListNode<int> find1 = listitem.Find(findvalue);
                            Console.WriteLine("Enter an element to add before {0}", findvalue);
                            value = int.Parse(Console.ReadLine());
                            listitem.AddAfter(find1, value);
                            Console.WriteLine("Value Added");
                            Console.WriteLine();
                            Totallist += 1;

                            value = 0;
                            findvalue = 0;
                            i--;
                            slno = 0;

                        }
                        else
                        {
                            Console.WriteLine("Please note the value{0} not able to find or not in the list, please verify it again", findvalue);
                            Console.WriteLine();
                            findvalue = 0;
                            i--;
                            slno = 0;
                        }
                    }

                }
                if (slno == 5)
                    {
                    if (!(listitem.Count > 0))
                    {
                        Console.WriteLine("Your List is empty");
                        i--;
                        slno = 0;
                    }
                    else
                    {
                        Console.WriteLine(" All the values in the List are");

                        foreach (int item in listitem)
                        {
                            Console.Write(item + " ");

                        }

                        i--;
                        slno = 0;
                    }
                    }
                    if (slno == 6)
                    {
                        Console.WriteLine("Exiting!!!");
                        slno = 0;

                    }
                    if (slno >= 7)
                    {
                        Console.WriteLine("please enter the correct code");
                        i--;
                        slno = 0;
                    }
                }
            

            Console.ReadKey();
        }
    }
}
