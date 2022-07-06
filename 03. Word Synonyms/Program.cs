using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();


            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string sinonim = Console.ReadLine();
                if (!words.ContainsKey(word))
                {
                    words.Add(word, new List<string>());
                    words[word].Add(sinonim);

                }
                else
                {
                    words[word].Add(sinonim);

                }






            }
            foreach (var item in words)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            }
        }
    }
}
