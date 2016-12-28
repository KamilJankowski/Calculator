using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class first_val
    {
        public void get_val()
        {
            Console.WriteLine("Please enter first value: ");
        }

        public void read_val()
        {
            string number;
            number = Console.ReadLine();
            Console.WriteLine("Your fisrt value is {0} ", number);

        }


        


    }


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
            for (int i = 0; i < welcome.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("");
            Console.WriteLine("");


            first_val fval = new first_val();
            fval.get_val();
            fval.read_val();


            Console.ReadKey();
        }
    }
    
}
