using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string welcome = "Welcome to Simple Calculator - created by Kamil Jankowski";
            Console.WriteLine(welcome);
            Console.WriteLine("");
    
            for(int i = 0; i<=30; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
