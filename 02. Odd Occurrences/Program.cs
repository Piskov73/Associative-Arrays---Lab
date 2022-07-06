﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Dictionary<string,int> listWord=new Dictionary<string,int>();
            foreach (var item in input)
            {
                string word = item.ToLower();
                if (listWord.ContainsKey(word))
                {
                    listWord[word]++;
                }
                else
                {
                    listWord.Add(word, 1);
                }


            }

            foreach (var word in listWord)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write($"{word.Key} ");
                }
            }
                
        }
    }
}
