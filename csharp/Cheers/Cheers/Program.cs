using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            name = name.ToLower();
            
                for (int i = 0; i < name.Length; i++)
            {
                char[] aArray = new char[] { 'b', 'c', 'd', 'g', 'j', 'k', 'p', 'q', 't', 'u', 'v', 'w', 'y', 'z' };
                // char[] anArray = new char[] { 'a', 'e', 'f', 'h', 'i', 'l', 'm', 'n', 'o', 'r', 's', 'x' };
                bool needAn = false;
                if (name.IndexOfAny(aArray) == -1)
                {
                    needAn = true;
                }
                if (needAn)
                {
                    Console.Write(string.Format("Give me an {0}{1}", name[i], Environment.NewLine));
                }
                else
                {
                    Console.Write(string.Format("Give me a {0}{1}", name[i], Environment.NewLine));
                }
            }
            Console.Write("{0} is.. GRAND!", name.ToUpper());
            Console.ReadKey();
        }
    }
}
