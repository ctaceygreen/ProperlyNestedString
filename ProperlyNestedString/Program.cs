using System;
using System.Collections;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(string S)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        //Use a stack for this
        Stack charStack = new Stack();
        Dictionary<char, char> matchedBrackets = new Dictionary<char, char> {
            { ']', '[' },
            {')', '(' },
            {'}', '{' }
        };

        HashSet<char> charsToPush = new HashSet<char> { '[', '(', '{' };

        foreach(var character in S)
        {
            if(charsToPush.Contains(character))
            {
                charStack.Push(character);
            }
            else
            {
                if(charStack.Count == 0)
                {
                    //We cannot start with anything but a pushable bracket
                    return 0;
                }
                else
                {
                    if((char)charStack.Pop() != matchedBrackets[character])
                    {
                        return 0;
                    }
                }
            }
        }
        if(charStack.Count != 0)
        {
            return 0;
        }
        return 1;

    }
}