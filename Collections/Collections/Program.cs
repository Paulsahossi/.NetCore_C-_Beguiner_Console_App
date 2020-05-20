using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("Bo");
            names.Add("Li");
            names.Add("An");

            //names[names.Count - 1] = "Po";

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            //Console.WriteLine(queue.Dequeue());

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());

            var people = new Dictionary<String, int>();
            people.Add("Bob", 30);
            people.Add("Pop", 45);
            people.Add("Tot", 80);

            Console.WriteLine(people["Bob"]);

        }
    }
}
