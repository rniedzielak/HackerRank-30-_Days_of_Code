using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{

    static void Main(String[] args)
    {
        string S = Console.ReadLine();
        
        try
        {
            int answear = Convert.ToInt32(S);
            Console.WriteLine(answear);
        }
        catch
        {
            Console.WriteLine("Bad String");
        }

    }
}
