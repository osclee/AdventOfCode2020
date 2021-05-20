using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Day1
{
    class Program
    {
        // https://adventofcode.com/2020/day/1

        static void Main(string[] args)
        {
            var expenses = new List<int>();

            var tr = new StreamReader(@"input.txt");

            string line;
            while ((line = tr.ReadLine()) != null)
            {
                expenses.Add(int.Parse(line));
            }

            Console.WriteLine(Part1(expenses, 2020));
            Console.WriteLine(Part1Better(expenses, 2020));
        }

        // n^2 
        static int Part1(List<int> expenses, int goal)
        {
            foreach (var expense in expenses)
            {
                foreach (var expense2 in expenses)
                {
                    if (expense == expense2) continue;
                    if (expense + expense2 == goal) return expense * expense2;
                }
            }

            return 0;
        }

        // n^3; Yuck!
        static int Part2(List<int> expenses, int goal)
        {
            foreach (var expense in expenses)
            {
                foreach (var expense2 in expenses)
                {
                    foreach (var expense3 in expenses)
                    {
                        if ((expense == expense2) && (expense == expense3) && (expense2 == expense3)) continue;
                        if (expense + expense2 + expense3 == goal) return expense * expense2 * expense3;
                    }
                }
            }

            return 0;
        }

        static int Part1Better(List<int> expenses, int goal)
        {
            // do 2020 - x to drop out a loop
            foreach (var expense in expenses)
            {
                if(expenses.Contains(goal - expense))
                {
                    return expense * (2020 - expense);
                }
            }

            return 0;
        }
        
    }
}
