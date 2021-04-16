using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class SplitWord
    {
        static void Main(string[] args)
        {
            string s1 = "I love my country";
            string[] a=s1.Split(' ');

            foreach (var word in a)
                Console.WriteLine(word);

            Console.ReadLine();
        }
    }
}
