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
            //welcome string declartion
            string welcome = "Welcome to Simple Calculator - created by Kamil Jankowski";

            //display character '-' to separate welcome and program content  
            for (int i = 0; i < welcome.Length; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine("");
            Console.WriteLine(welcome);
           

            //display character '-' to separate welcome and program content    
            for(int i = 0; i<welcome.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Please enter first number: ");


            Console.ReadKey();
        }
    }
}
