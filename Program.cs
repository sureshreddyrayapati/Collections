using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Collections
{
    public class Program
    {
        public static void arrayList()
        {
            ArrayList list = new ArrayList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input.Equals(""))
                {
                    break;
                }
                else
                {
                    list.Add(input);
                }
            }
            Console.WriteLine("Items in the ArrayList:");
            int c = 0;
            Console.Write("{");
            foreach (var ele in list)
            {
                c++;
                if (c != 1)
                {
                    Console.Write(",");
                }
                Console.Write(ele);
            }
            Console.Write("}");
           
            Console.WriteLine();
        }
        public static void arrayList2()
        {
            ArrayList list = new ArrayList();
            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                else
                {
                    list.Add(input);
                }
            }
            Console.WriteLine("Numbers in the ArrayList:");
            foreach (var ele in list)
            {
                ExtractNumbers(ele.ToString());
            }
        }

        public static void ExtractNumbers(string input)
        {
            ArrayList list2= new ArrayList();
            string number = "";
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    number += c;
                }
                else if (number != "")
                {
                    list2.Add(number);
                    number = "";
                }
            }
            if (number != "")
            {
                list2.Add(number);
            }
            foreach(var e in list2)
            {
                Console.WriteLine(e);
            }
        }

        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            int[] aa=new int[10];
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add("Apple");
            list.Add("Banana");
            //Console.WriteLine(list.BinarySearch(5));
            //list.Clear();
            //list.Clone();
            //Console.WriteLine(list.Contains(5));
            //list.CopyTo(aa,0);
            //Console.WriteLine(list.IndexOf("Apple"));
            list.Insert(5, 90);
            list.Reverse();
            list.RemoveAt(2);
            //list.Sort();
            Console.WriteLine("Elements are :");
            foreach (var e in list)
            {
                Console.WriteLine(e);
            }
            //for(int i=0;i<10; i++)
            //{
            //    Console.WriteLine(aa[i]);
            //}
        }
    }
}
