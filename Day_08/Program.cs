using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        IDictionary<string, int> Book = new Dictionary<string, int>();
        for (int i = 0; i < n; i++)
        {
            string[] st = Console.ReadLine().Split(' ');
            string s = st[0];
            int t = Convert.ToInt32(st[1]);
            Book.Add(s, t);
        }
        string name = "";
        while ((name = Console.ReadLine()) != null)
        {
            if (Book.ContainsKey(name))
            {
                Console.WriteLine(name + "=" + Book[name]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}