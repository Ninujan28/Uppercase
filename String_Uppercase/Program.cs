using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Uppercase
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string s1 = "String created by assignment";
                Console.WriteLine(s1);
                char[] array = { 'a', 'b', 'c', 'd', 'e', 'f' };
                string s2 = new string (array);
                Console.WriteLine(s2);
                s2.ToUpper();
                Console.WriteLine(s2); // s2 is not changed by the invocation
                string s3 = s2.ToUpper();
                Console.WriteLine(s3); // s3 is created from s2 with uppercase characters
                Console.WriteLine(s2); // s2 is not changed
            

        }
    }
}
