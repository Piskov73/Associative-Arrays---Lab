using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            SortedDictionary <int,int> conts=new SortedDictionary<int,int>();
            foreach (var item in input)
            {
                if (conts.ContainsKey(item))
                {
                    conts[item]++;
                }
                else
                {
                    conts.Add(item, 1);
                }
            }
            foreach (var numb in conts)
            {
                Console.WriteLine($"{numb.Key} -> {numb.Value}");
            }
        }
    }
}
