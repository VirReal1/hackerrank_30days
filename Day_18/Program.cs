using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    public List<char> stack = new List<char>();

    public List<char> queue = new List<char>();

    public void pushCharacter(char c)
    {
        stack.Add(c);
    }

    public void enqueueCharacter(char c)
    {
        queue.Add(c);
    }

    public char popCharacter()
    {
        char last = ' ';

        for (int i = stack.Count - 1; i >= 0; i--)
        {
            last = stack[i];
        }

        return last;
    }

    public char dequeueCharacter()
    {
        char first = ' ';

        for (int i = 0; i < stack.Count; i++)
        {
            first = queue[i];
        }

        return first;
    }


    static void Main(String[] args)
    {
        // read the string s.
        string s = Console.ReadLine();

        // create the Solution class object p.
        Solution obj = new Solution();

        // push/enqueue all the characters of string s to stack.
        foreach (char c in s)
        {
            obj.pushCharacter(c);
            obj.enqueueCharacter(c);
        }

        bool isPalindrome = true;

        // pop the top character from stack.
        // dequeue the first character from queue.
        // compare both the characters.
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (obj.popCharacter() != obj.dequeueCharacter())
            {
                isPalindrome = false;

                break;
            }
        }

        // finally print whether string s is palindrome or not.
        if (isPalindrome)
        {
            Console.Write("The word, {0}, is a palindrome.", s);
        }
        else
        {
            Console.Write("The word, {0}, is not a palindrome.", s);
        }
    }
}