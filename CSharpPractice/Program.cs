using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Console.WriteLine("You have entered {0} command line arguments",args.Length);
            foreach(string param in args)
            {
                Console.WriteLine(param);
            }
            Console.ReadLine();
        }
    }
}
