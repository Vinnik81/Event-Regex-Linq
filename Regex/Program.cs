using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  string name = "Aaaaaaaa188aaaaaa";
            // string name = "0123 4567 8910 1112";

            //string name = "62";
            //Regex regex = new Regex("^[a-z,A-Z]{3,50}$");

            //    Regex regex = new Regex("^[A-Z][a-z]{3,15}$");
            ////0000 0000 0000 0000
            //Regex regex = new Regex("^[0-9]{4} [0-9]{4} [0-9]{4} [0-9]{4}$");

            //Regex regex = new Regex("^[0-9]?$");


            //   string name = "#####3";
            //Regex regex = new Regex("^[0-9,A-Z,a-z]$");
            // ^ - совпадение с начала
            // $ - совпадение с начала
            // [a-z]    1symb
            // ? -  0 - 1
            // + -  1 - ...

            //  Match match = regex.Match(name);

            //    if (match.Success)
            //    {
            //        Console.WriteLine("Welcome");
            //    }
            //   else
            //   {
            //         Console.WriteLine("Bad data");
            //   }



            //if (name.Length >= 3 && name[0] = )
            //{
            //    Console.WriteLine("Welcome");
            //}
            //else
            //{
            //    Console.WriteLine("Bad data");
            //}


            ////////////////////////////////////////////////////////////////////////////////
            ///

            //Non-Generic

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add(true);
            //arrayList.Add("Hello");
            //arrayList.Add(1.4);
            //arrayList.Add(1.5f);


            //int num = 0;
            //foreach (int item in arrayList)
            //{
            //    num += item;
            //    Console.WriteLine(item);
            //}



            //List<int> arr = new List<int>();
            //arr.Add(5);
            //arr.Add(15);
            //arr.Add(25);
            //arr.Add(35);



            // Generic collections

            //List<int> a;                   // dynamic array
            //LinkedList<int> b;             // double linked list
            //Queue<int> c;                  // queue
            //Stack<int> d;                  // stack
            //ObservableCollection<int> e;   // dynamic array

            //Dictionary<double, double> q;  // hash table
            //HashSet<int> w;                // hash table

            //SortedList<int, string> r;      // binaqry tree
            //SortedSet<int> t;               // binaqry tree
            //SortedDictionary<int, string> z;// binaqry tree
        }
    }
}