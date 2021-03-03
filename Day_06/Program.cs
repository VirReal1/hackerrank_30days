using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    public Solution(string[] name1)
    {
        for(int i = 0; i<name1.Length; i++)
        {
            for (int y = 0; y < name1[i].Length; y++)
            {
                if ((y % 2) == 0)
                {
                    Console.Write(name1[i][y]);
                }
            }
            Console.Write(" ");
            for (int y = 0; y < name1[i].Length; y++)
            {
                if ((y % 2) == 1)
                {
                    Console.Write(name1[i][y]);
                }
            }
            Console.WriteLine("");
        }
    }
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] name = new string[n];
        for(int i = 0; i < n; i++)
        {
            name[i] = Console.ReadLine();
        }
        Solution name1= new Solution(name);
    }
}