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
        int n = Convert.ToInt32(Console.ReadLine());
        string binary_form = Convert.ToString(n, 2);
        int counter1 = 0;
        for (int i = 0; i < binary_form.Length; i++)
        {
            int counter2 = 1;
            for(int j=i + 1 ; j < binary_form.Length;j++)
            {
                 if (binary_form[i]!= binary_form[j])
                    break;
                else
                    counter2++;
                
                
            }
            if (counter2>counter1)
            {
                counter1 = counter2;
            }
        }
        Console.WriteLine(counter1);
    }
}
