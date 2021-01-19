using System;
using System.Collections.Generic;

namespace list_tutorial {
    class Program {
        static void Main (string[] args) {
            //WorkingWithStrings ();
            //fibonacciNumbers (20);
         int i =123;
         object o =i;
         o=123;
         i=(int)o;

        }

        static void fibonacciNumbers (int n) {
            var fibonacciNumbers = new List<int> { 1, 1 };
            while (fibonacciNumbers.Count < n) {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add (previous + previous2);
            }
            foreach (var item in fibonacciNumbers)
                Console.WriteLine (item);
        }

        static void WorkingWithStrings () {
            var names = new List<string> { "<name>", "Ana", "Feli" };
            foreach (var name in names) {
                Console.WriteLine ($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine ();
            names.Add ("Maria");
            names.Add ("li");
            names.Remove ("Ana");
            foreach (var name in names) {
                Console.WriteLine ($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine ();
            Console.WriteLine ($"My name is {names[0]}");
            Console.WriteLine ($"I've added {names[2]} and {names[3]} to the list");
            Console.WriteLine ($"The list has {names.Count} people in it");

            var index = names.IndexOf ("Feli");
            if (index == -1) {
                Console.WriteLine ($"When an item is not found, IndexOf returns {index}");
            } else {
                Console.WriteLine ($"The name {names[index]} is at index {index}");
            }

            index = names.IndexOf ("Not Found");
            if (index == -1) {
                Console.WriteLine ($"When an item is not found, IndexOf returns {index}");
            } else {
                Console.WriteLine ($"The name {names[index]} is at index {index}");

            }

            Console.WriteLine ();
            // Sort 方法按正常顺序（如果是字符串则按字母顺序）对列表中的所有项进行排序
            names.Sort ();
            foreach (var name in names) {
                Console.WriteLine ($"Hello {name.ToUpper()}!");
            }
        }
    }
}