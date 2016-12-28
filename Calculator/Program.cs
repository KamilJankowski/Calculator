using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class first_val
    {
        private int number;

        public void get_val()
        {
            Console.WriteLine("Please enter value: ");
        }

        public int read_val(int val)
        {
            number = Convert.ToInt32(Console.ReadLine());

            val = number;

            return val;
        }
    }

    class operation
    {
        public int add(int a,int b)
        {
            return a + b;
        }

        public int substract(int a, int b)
        {
            return a - b;
        }

        public int multiple(int a, int b)
        {
            return a * b;
        }

        public int devide(int a, int b)
        {
            return a / b;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            
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
                        
            int b = fval.read_val(a);

            Console.WriteLine("Return: {0}", b);
            fval.get_val();
            int c = fval.read_val(a);

            Console.WriteLine("Return: {0}", c);

            operation o = new operation();
            int ra = o.add(b, c);
            int rs = o.substract(b, c);
            int rm = o.multiple(b, c);
            int rd = o.devide(b, c);


            Console.WriteLine("Operation ADD Return: {0}", ra);
            Console.WriteLine("Operation SUBSTARCT: {0}", rs);
            Console.WriteLine("Operation MULTIPLE: {0}", rm);
            Console.WriteLine("Operation DEVIDE: {0}", rd);

            Console.ReadKey();
        }
    }
    
}
