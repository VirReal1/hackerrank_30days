using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        try
        {
            string S = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(S));
        }
        catch
        {
            Console.WriteLine("Bad String");
        }
        Console.ReadLine();
    }
}
