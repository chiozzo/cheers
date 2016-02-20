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
            string name = Console.ReadLine();
            name = name.ToLower();
            for (int i = 0; i < name.Length; i++)
            {
                /*
                This is a bunch of garbage. I'd like to use name.IndexOfAny(aArray) == -1, but it consistently returns zero.
                */
                bool needAn = false;
                if (name[i] == 'a' ||
                name[i] == 'e' ||
                name[i] == 'f' ||
                name[i] == 'h' ||
                name[i] == 'i' ||
                name[i] == 'l' ||
                name[i] == 'm' ||
                name[i] == 'n' ||
                name[i] == 'o' ||
                name[i] == 'r' ||
                name[i] == 's' ||
                name[i] == 'x')
                {
                    needAn = true;
                }
                // char[] anArray = new char[] { 'a', 'e', 'f', 'h', 'i', 'l', 'm', 'n', 'o', 'r', 's', 'x' };
                // char[] aArray = new char[] { 'b', 'c', 'd', 'g', 'j', 'k', 'p', 'q', 't', 'u', 'v', 'w', 'y', 'z' };
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
