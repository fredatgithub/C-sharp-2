﻿using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp8
{
    //collections
    class Program
    {
        static void Main(string[] args)
        {
            // ---------- ARRAYLISTS ----------
            #region ArrayList Code

            ArrayList aList = new ArrayList();

            aList.Add("Bob");
            aList.Add(40);

            Console.WriteLine("Count: {0}",
                aList.Count);

            Console.WriteLine("Capacity: {0}",
                aList.Capacity);

            ArrayList aList2 = new ArrayList();

            aList2.AddRange(new object[] { "Krunal", "Poorav", "Gaurang" });
            aList.AddRange(aList2);
            aList2.Sort();
            aList2.Reverse();
            aList2.Insert(1, "India");
            ArrayList range = aList2.GetRange(0, 2);

       
            Console.WriteLine("India Index : {0}",
                aList2.IndexOf("India", 0));

            foreach (object o in range)
            {
                Console.WriteLine(o);
            }

            string[] myArray = (string[])aList2.ToArray(typeof(string));

            string[] customers = { "Bob", "Sally", "Sue" };
            ArrayList custArrayList = new ArrayList();
            custArrayList.AddRange(customers);

            #endregion


            // ---------- DICTIONARIES ----------
            #region Dictionary Code

            Dictionary<string, string> superheroes = new Dictionary<string, string>();

            superheroes.Add("Clark Kent", "Superman");
            superheroes.Add("Bruce Wayne", "Batman");
            superheroes.Add("ABC", "Saktiman");

            superheroes.Remove("Barry West");

            Console.WriteLine("Count : {0}",
                superheroes.Count);

            Console.WriteLine("Clark Kent : {0}",
                superheroes.ContainsKey("Clark Kent"));

            superheroes.TryGetValue("Clark Kent", out string test);

            Console.WriteLine($"Clark Kent : {test}");

            foreach (KeyValuePair<string, string> item in superheroes)
            {
                Console.WriteLine("{0} : {1}",
                    item.Key,
                    item.Value);
            }

            superheroes.Clear();


            #endregion

            // ---------- QUEUES ----------
            #region Queue Code

            Queue queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("1 in Queue : {0}",
                queue.Contains(1));

            Console.WriteLine("Remove 1 : {0}",
                queue.Dequeue());

            Console.WriteLine("Peek 1 : {0}",
                queue.Peek());

            object[] numArray = queue.ToArray();

            Console.WriteLine(string.Join(",", numArray));

            foreach (object o in queue)
            {
                Console.WriteLine($"Queue : {o}");
            }

            queue.Clear();


            #endregion

            // ---------- STACKS ----------
            #region Queue Code

 
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine("Peek 1 : {0}",
                stack.Peek());

            Console.WriteLine("Pop 1 : {0}",
                stack.Pop());

            Console.WriteLine("Contain 1 : {0}",
                stack.Contains(1));

            object[] numArray2 = stack.ToArray();

            Console.WriteLine(string.Join(",", numArray2));

            foreach (object o in stack)
            {
                Console.WriteLine($"Stack : {o}");
            }
            #endregion

        }

    }

}