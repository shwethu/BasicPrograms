using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class PalindromeString
    {
        static void Main(string[] args)
        {
            //string s1 = "MADAM";
            string s1;
            string s2="";
            Console.WriteLine("Enter the string:");
               s1=Console.ReadLine();
            char[] polStr= s1.ToCharArray();
            for(int i=s1.Length-1;i>=0;i--)
            {
                s2+=polStr[i];
            }
            Console.WriteLine(s2);
            if (s1.Equals(s2))
                Console.WriteLine("Given string is palindrome:" + s2);
            else
                Console.WriteLine("Not a palindrome");
            Console.ReadLine();
        }
    }
}
