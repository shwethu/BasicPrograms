using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class ReverseString
    {
        
        static void Main(string[] args)
        {
            string s1 = "I love my country";
           char[] stringArray= s1.ToCharArray();
            string s2 = " ";
            for (int i = stringArray.Length-1; i >= 0; i--)
            {
                s2 += stringArray[i];
            }
            Console.Write(s2);
            Console.ReadLine();
        }
    }
}
