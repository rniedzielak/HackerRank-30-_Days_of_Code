using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution 
{
    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        List<string> Names = new List<string>();
        for (int NItr = 0; NItr < N; NItr++)
        {
            string[] firstNameEmailID = Console.ReadLine().Split(' ');
            string firstName = firstNameEmailID[0];
            string emailID = firstNameEmailID[1];
            int index = emailID.IndexOf('@');
            if(emailID.Substring(index + 1, 5) == "gmail")
            {
                Names.Add(firstName);
            }            
        }
        Names.Sort();
        foreach(string s in Names)
        {
            Console.WriteLine(s);
        }
    }
}
